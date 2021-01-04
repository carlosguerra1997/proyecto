Imports System.Data.SqlClient
Imports System.Runtime.InteropServices
Public Class menuPrincipal

    'Variables para la conexión a la base de datos'
    Dim conexion As String
    Dim cn As New SqlConnection

    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        End
    End Sub

    Private Sub btnMaximizar_Click(sender As Object, e As EventArgs) Handles btnMaximizar.Click
        btnMaximizar.Visible = False
        btnRestaurar.Visible = True
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub btnRestaurar_Click(sender As Object, e As EventArgs) Handles btnRestaurar.Click
        btnRestaurar.Visible = False
        btnMaximizar.Visible = True
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub pnlCabecera_MouseMove(sender As Object, e As MouseEventArgs) Handles pnlCabecera.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub btnCuenta_Click(sender As Object, e As EventArgs) Handles btnCuenta.Click
        Me.Hide()
        datosPersonales.Show()
    End Sub

    Private Sub btnCerrarSesion_Click(sender As Object, e As EventArgs) Handles btnCerrarSesion.Click
        Me.Hide()
        loginForm.Show()
        loginForm.txtUsuario.Text = ""
        loginForm.txtContraseña.Text = ""
        primerLogin.txtPrimerLogin.Text = ""
    End Sub

    Private Sub btnEventos_Click(sender As Object, e As EventArgs) Handles btnEventos.Click
        Me.Hide()
        Eventos.Show()
    End Sub

    Private Sub menuPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Cargamos la fecha actual'
        Dim fecha As Date = Today
        Dim fechaEvento As Date

        'Cargamos la conexión a la base de datos'
        conexion = "Data Source=DESKTOP-LCH6UJM\SQLEXPRESS;Initial Catalog=Proyecto_Planyvent;Integrated Security=True"
        cn.ConnectionString = conexion

        'Abrimos la conexión'
        cn.Open()

        'Creamos el adaptador para ejecutar la consulta'
        Dim adaptadorBuscar As New SqlDataAdapter("SELECT * FROM Cuenta WHERE codigo_cuenta= '" & ModuloVars.codigo & "'", cn)
        Dim ds As New DataSet
        adaptadorBuscar.Fill(ds, "datos")

        'Añadimos el nombre del usuario al label'
        lblBienvenidaUser.Text = "Hola, " & ds.Tables("datos").Rows(0).Item(1).ToString.Trim()

        'Creamos el adaptador para buscar los eventos que tengamos en menos de una semana'
        Dim buscarEventos As New SqlDataAdapter("SELECT * FROM Eventos WHERE id_usuario= '" & ModuloVars.codigo & "'", cn)
        Dim dsBuscarEventos As New DataSet
        buscarEventos.Fill(dsBuscarEventos, "buscarEventos")

        'Recorremos todos los eventos devueltos'
        Dim contador = 0
        Dim contadorFilas = 0

        For Each Row As DataRow In dsBuscarEventos.Tables("buscarEventos").Rows
            fechaEvento = dsBuscarEventos.Tables("buscarEventos").Rows(contador).Item(3).ToString
            Dim dias As Integer = (fechaEvento - fecha).Days
            If dias <= 7 And dias >= 0 Then
                dgvEventosProximos.Rows.Add()
                dgvEventosProximos.Rows(contadorFilas).Cells(0).Value = dsBuscarEventos.Tables("buscarEventos").Rows(contador).Item(1).ToString()
                dgvEventosProximos.Rows(contadorFilas).Cells(1).Value = dsBuscarEventos.Tables("buscarEventos").Rows(contador).Item(2).ToString()
                dgvEventosProximos.Rows(contadorFilas).Cells(2).Value = dsBuscarEventos.Tables("buscarEventos").Rows(contador).Item(3).ToString()
                dgvEventosProximos.Rows(contadorFilas).Cells(3).Value = dsBuscarEventos.Tables("buscarEventos").Rows(contador).Item(4).ToString()
                dgvEventosProximos.Rows(contadorFilas).Cells(4).Value = dsBuscarEventos.Tables("buscarEventos").Rows(contador).Item(5).ToString()
                dgvEventosProximos.Rows(contadorFilas).Cells(5).Value = dsBuscarEventos.Tables("buscarEventos").Rows(contador).Item(7).ToString()
                dgvEventosProximos.Rows(contadorFilas).Cells(6).Value = dsBuscarEventos.Tables("buscarEventos").Rows(contador).Item(8).ToString()
                dgvEventosProximos.Rows(contadorFilas).Cells(7).Value = dsBuscarEventos.Tables("buscarEventos").Rows(contador).Item(9).ToString()
                dgvEventosProximos.Rows(contadorFilas).Cells(8).Value = dsBuscarEventos.Tables("buscarEventos").Rows(contador).Item(10).ToString()
                contadorFilas = contadorFilas + 1
            End If
            contador = contador + 1
        Next

        'Cerramos la conexión'
        cn.Close()
    End Sub

    Private Sub cmbFiltro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFiltro.SelectedIndexChanged
        Dim fechaEvento As Date
        Dim fecha As Date = Today
        Dim contador = 0
        Dim contadorFilas = 0

        'Abrimos la conexión'
        cn.Open()

        If cmbFiltro.SelectedIndex = 0 Then
            'Creamos el adaptador para filtrar los eventos por nombre ascendente'
            Dim filtrarNombreAsc As New SqlDataAdapter("SELECT * FROM Eventos WHERE id_usuario= '" & ModuloVars.codigo & "' ORDER BY nombre_evento ASC", cn)
            Dim dsFiltrarNombreAsc As New DataSet
            filtrarNombreAsc.Fill(dsFiltrarNombreAsc, "filtrarNombreAsc")

            'Limpiamos la lista y la rellenamos con los datos filtrados'
            dgvEventosProximos.Rows.Clear()

            For Each Row As DataRow In dsFiltrarNombreAsc.Tables("filtrarNombreAsc").Rows
                fechaEvento = dsFiltrarNombreAsc.Tables("filtrarNombreAsc").Rows(contador).Item(3).ToString
                Dim dias As Integer = (fechaEvento - fecha).Days
                If dias >= 0 And dias <= 7 Then
                    dgvEventosProximos.Rows.Add()
                    dgvEventosProximos.Rows(contadorFilas).Cells(0).Value = dsFiltrarNombreAsc.Tables("filtrarNombreAsc").Rows(contador).Item(1).ToString()
                    dgvEventosProximos.Rows(contadorFilas).Cells(1).Value = dsFiltrarNombreAsc.Tables("filtrarNombreAsc").Rows(contador).Item(2).ToString()
                    dgvEventosProximos.Rows(contadorFilas).Cells(2).Value = dsFiltrarNombreAsc.Tables("filtrarNombreAsc").Rows(contador).Item(3).ToString()
                    dgvEventosProximos.Rows(contadorFilas).Cells(3).Value = dsFiltrarNombreAsc.Tables("filtrarNombreAsc").Rows(contador).Item(4).ToString()
                    dgvEventosProximos.Rows(contadorFilas).Cells(4).Value = dsFiltrarNombreAsc.Tables("filtrarNombreAsc").Rows(contador).Item(5).ToString()
                    dgvEventosProximos.Rows(contadorFilas).Cells(5).Value = dsFiltrarNombreAsc.Tables("filtrarNombreAsc").Rows(contador).Item(7).ToString()
                    dgvEventosProximos.Rows(contadorFilas).Cells(6).Value = dsFiltrarNombreAsc.Tables("filtrarNombreAsc").Rows(contador).Item(8).ToString()
                    dgvEventosProximos.Rows(contadorFilas).Cells(7).Value = dsFiltrarNombreAsc.Tables("filtrarNombreAsc").Rows(contador).Item(9).ToString()
                    dgvEventosProximos.Rows(contadorFilas).Cells(8).Value = dsFiltrarNombreAsc.Tables("filtrarNombreAsc").Rows(contador).Item(10).ToString()
                    contadorFilas = contadorFilas + 1
                End If
                contador = contador + 1
            Next
        ElseIf cmbFiltro.SelectedIndex = 1 Then
            'Creamos el adaptador para filtrar los eventos por nombre descendente'
            Dim filtrarNombreDesc As New SqlDataAdapter("SELECT * FROM Eventos WHERE id_usuario= '" & ModuloVars.codigo & "' ORDER BY nombre_evento DESC", cn)
            Dim dsFiltrarNombreDesc As New DataSet
            filtrarNombreDesc.Fill(dsFiltrarNombreDesc, "filtrarNombreDesc")

            'Reseteamos el contador a 0'
            contador = 0

            'Limpiamos la lista y la rellenamos con los datos filtrados'
            dgvEventosProximos.Rows.Clear()

            For Each Row As DataRow In dsFiltrarNombreDesc.Tables("filtrarNombreDesc").Rows
                'Cogemos las fechas y calculamos la resta de dias que quedan para que llegue el evento'
                fechaEvento = dsFiltrarNombreDesc.Tables("filtrarNombreDesc").Rows(contador).Item(3).ToString
                Dim dias As Integer = (fechaEvento - fecha).Days
                If dias >= 0 And dias <= 7 Then
                    dgvEventosProximos.Rows.Add()
                    dgvEventosProximos.Rows(contadorFilas).Cells(0).Value = dsFiltrarNombreDesc.Tables("filtrarNombreDesc").Rows(contador).Item(1).ToString()
                    dgvEventosProximos.Rows(contadorFilas).Cells(1).Value = dsFiltrarNombreDesc.Tables("filtrarNombreDesc").Rows(contador).Item(2).ToString()
                    dgvEventosProximos.Rows(contadorFilas).Cells(2).Value = dsFiltrarNombreDesc.Tables("filtrarNombreDesc").Rows(contador).Item(3).ToString()
                    dgvEventosProximos.Rows(contadorFilas).Cells(3).Value = dsFiltrarNombreDesc.Tables("filtrarNombreDesc").Rows(contador).Item(4).ToString()
                    dgvEventosProximos.Rows(contadorFilas).Cells(4).Value = dsFiltrarNombreDesc.Tables("filtrarNombreDesc").Rows(contador).Item(5).ToString()
                    dgvEventosProximos.Rows(contadorFilas).Cells(5).Value = dsFiltrarNombreDesc.Tables("filtrarNombreDesc").Rows(contador).Item(7).ToString()
                    dgvEventosProximos.Rows(contadorFilas).Cells(6).Value = dsFiltrarNombreDesc.Tables("filtrarNombreDesc").Rows(contador).Item(8).ToString()
                    dgvEventosProximos.Rows(contadorFilas).Cells(7).Value = dsFiltrarNombreDesc.Tables("filtrarNombreDesc").Rows(contador).Item(9).ToString()
                    dgvEventosProximos.Rows(contadorFilas).Cells(8).Value = dsFiltrarNombreDesc.Tables("filtrarNombreDesc").Rows(contador).Item(10).ToString()
                    contadorFilas = contadorFilas + 1
                End If
                contador = contador + 1
            Next
        ElseIf cmbFiltro.SelectedIndex = 2 Then
            'Creamos el adaptador para filtrar los eventos por fecha ascendente'
            Dim filtrarFechaAsc As New SqlDataAdapter("SELECT * FROM Eventos WHERE id_usuario= '" & ModuloVars.codigo & "' ORDER BY fecha ASC", cn)
            Dim dsFiltrarFechaAsc As New DataSet
            filtrarFechaAsc.Fill(dsFiltrarFechaAsc, "filtrarFechaAsc")

            'Reseteamos el contador a 0'
            contador = 0

            'Limpiamos la lista y la rellenamos con los datos filtrados'
            dgvEventosProximos.Rows.Clear()

            For Each Row As DataRow In dsFiltrarFechaAsc.Tables("filtrarFechaAsc").Rows
                'Cogemos las fechas y calculamos la resta de dias que quedan para que llegue el evento'
                fechaEvento = dsFiltrarFechaAsc.Tables("filtrarFechaAsc").Rows(contador).Item(3).ToString
                Dim dias As Integer = (fechaEvento - fecha).Days
                If dias >= 0 And dias <= 7 Then
                    dgvEventosProximos.Rows.Add()
                    dgvEventosProximos.Rows(contadorFilas).Cells(0).Value = dsFiltrarFechaAsc.Tables("filtrarFechaAsc").Rows(contador).Item(1).ToString()
                    dgvEventosProximos.Rows(contadorFilas).Cells(1).Value = dsFiltrarFechaAsc.Tables("filtrarFechaAsc").Rows(contador).Item(2).ToString()
                    dgvEventosProximos.Rows(contadorFilas).Cells(2).Value = dsFiltrarFechaAsc.Tables("filtrarFechaAsc").Rows(contador).Item(3).ToString()
                    dgvEventosProximos.Rows(contadorFilas).Cells(3).Value = dsFiltrarFechaAsc.Tables("filtrarFechaAsc").Rows(contador).Item(4).ToString()
                    dgvEventosProximos.Rows(contadorFilas).Cells(4).Value = dsFiltrarFechaAsc.Tables("filtrarFechaAsc").Rows(contador).Item(5).ToString()
                    dgvEventosProximos.Rows(contadorFilas).Cells(5).Value = dsFiltrarFechaAsc.Tables("filtrarFechaAsc").Rows(contador).Item(7).ToString()
                    dgvEventosProximos.Rows(contadorFilas).Cells(6).Value = dsFiltrarFechaAsc.Tables("filtrarFechaAsc").Rows(contador).Item(8).ToString()
                    dgvEventosProximos.Rows(contadorFilas).Cells(7).Value = dsFiltrarFechaAsc.Tables("filtrarFechaAsc").Rows(contador).Item(9).ToString()
                    dgvEventosProximos.Rows(contadorFilas).Cells(8).Value = dsFiltrarFechaAsc.Tables("filtrarFechaAsc").Rows(contador).Item(10).ToString()
                    contadorFilas = contadorFilas + 1
                End If
                contador = contador + 1
            Next
        Else
            'Creamos el adaptador para filtrar los eventos por fecha descendente'
            Dim filtrarFechaDesc As New SqlDataAdapter("SELECT * FROM Eventos WHERE id_usuario= '" & ModuloVars.codigo & "' ORDER BY fecha DESC", cn)
            Dim dsFiltrarFechaDesc As New DataSet
            filtrarFechaDesc.Fill(dsFiltrarFechaDesc, "filtrarFechaDesc")

            'Reseteamos el contador a 0'
            contador = 0

            'Limpiamos la lista y la rellenamos con los datos filtrados'
            dgvEventosProximos.Rows.Clear()

            For Each Row As DataRow In dsFiltrarFechaDesc.Tables("filtrarFechaDesc").Rows
                'Cogemos las fechas y calculamos la resta de dias que quedan para que llegue el evento'
                fechaEvento = dsFiltrarFechaDesc.Tables("filtrarFechaDesc").Rows(contador).Item(3).ToString
                Dim dias As Integer = (fechaEvento - fecha).Days
                If dias >= 0 And dias <= 7 Then
                    dgvEventosProximos.Rows.Add()
                    dgvEventosProximos.Rows(contadorFilas).Cells(0).Value = dsFiltrarFechaDesc.Tables("filtrarFechaDesc").Rows(contador).Item(1).ToString()
                    dgvEventosProximos.Rows(contadorFilas).Cells(1).Value = dsFiltrarFechaDesc.Tables("filtrarFechaDesc").Rows(contador).Item(2).ToString()
                    dgvEventosProximos.Rows(contadorFilas).Cells(2).Value = dsFiltrarFechaDesc.Tables("filtrarFechaDesc").Rows(contador).Item(3).ToString()
                    dgvEventosProximos.Rows(contadorFilas).Cells(3).Value = dsFiltrarFechaDesc.Tables("filtrarFechaDesc").Rows(contador).Item(4).ToString()
                    dgvEventosProximos.Rows(contadorFilas).Cells(4).Value = dsFiltrarFechaDesc.Tables("filtrarFechaDesc").Rows(contador).Item(5).ToString()
                    dgvEventosProximos.Rows(contadorFilas).Cells(5).Value = dsFiltrarFechaDesc.Tables("filtrarFechaDesc").Rows(contador).Item(7).ToString()
                    dgvEventosProximos.Rows(contadorFilas).Cells(6).Value = dsFiltrarFechaDesc.Tables("filtrarFechaDesc").Rows(contador).Item(8).ToString()
                    dgvEventosProximos.Rows(contadorFilas).Cells(7).Value = dsFiltrarFechaDesc.Tables("filtrarFechaDesc").Rows(contador).Item(9).ToString()
                    dgvEventosProximos.Rows(contadorFilas).Cells(8).Value = dsFiltrarFechaDesc.Tables("filtrarFechaDesc").Rows(contador).Item(10).ToString()
                    contadorFilas = contadorFilas + 1
                End If
                contador = contador + 1
            Next
        End If

        'Cerramos la conexión'
        cn.Close()
    End Sub

    Private Sub btnReiniciar_Click(sender As Object, e As EventArgs) Handles btnReiniciar.Click
        'Abrimos la conexión'
        cn.Open()

        'Limpiamos las filas del data grid view'
        dgvEventosProximos.Rows.Clear()

        'Cargamos la fecha actual'
        Dim fecha As Date = Today
        Dim fechaEvento As Date

        'Creamos el adaptador para buscar los eventos que tengamos en menos de una semana'
        Dim buscarEv As New SqlDataAdapter("SELECT * FROM Eventos WHERE id_usuario= '" & ModuloVars.codigo & "'", cn)
        Dim dsBuscarEv As New DataSet
        buscarEv.Fill(dsBuscarEv, "buscarEventos")

        'Recorremos todos los eventos devueltos'
        Dim contador = 0
        Dim contadorFilas = 0

        For Each Row As DataRow In dsBuscarEv.Tables("buscarEventos").Rows
            fechaEvento = dsBuscarEv.Tables("buscarEventos").Rows(contador).Item(3).ToString
            Dim dias As Integer = (fechaEvento - fecha).Days
            If dias <= 7 And dias >= 0 Then
                dgvEventosProximos.Rows.Add()
                dgvEventosProximos.Rows(contadorFilas).Cells(0).Value = dsBuscarEv.Tables("buscarEventos").Rows(contador).Item(1).ToString()
                dgvEventosProximos.Rows(contadorFilas).Cells(1).Value = dsBuscarEv.Tables("buscarEventos").Rows(contador).Item(2).ToString()
                dgvEventosProximos.Rows(contadorFilas).Cells(2).Value = dsBuscarEv.Tables("buscarEventos").Rows(contador).Item(3).ToString()
                dgvEventosProximos.Rows(contadorFilas).Cells(3).Value = dsBuscarEv.Tables("buscarEventos").Rows(contador).Item(4).ToString()
                dgvEventosProximos.Rows(contadorFilas).Cells(4).Value = dsBuscarEv.Tables("buscarEventos").Rows(contador).Item(5).ToString()
                dgvEventosProximos.Rows(contadorFilas).Cells(5).Value = dsBuscarEv.Tables("buscarEventos").Rows(contador).Item(7).ToString()
                dgvEventosProximos.Rows(contadorFilas).Cells(6).Value = dsBuscarEv.Tables("buscarEventos").Rows(contador).Item(8).ToString()
                dgvEventosProximos.Rows(contadorFilas).Cells(7).Value = dsBuscarEv.Tables("buscarEventos").Rows(contador).Item(9).ToString()
                dgvEventosProximos.Rows(contadorFilas).Cells(8).Value = dsBuscarEv.Tables("buscarEventos").Rows(contador).Item(10).ToString()
                contadorFilas = contadorFilas + 1
            End If
            contador = contador + 1
        Next
        cmbFiltro.Text = ""
        'Cerramos la conexión'
        cn.Close()
    End Sub
End Class