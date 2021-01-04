Imports System.Runtime.InteropServices
Imports System.Data.SqlClient
Public Class ListadoEvento

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

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnRestaurar_Click(sender As Object, e As EventArgs) Handles btnRestaurar.Click
        btnRestaurar.Visible = False
        btnMaximizar.Visible = True
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub pnlCabecera_MouseMove(sender As Object, e As MouseEventArgs) Handles pnlCabecera.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub ListadoEvento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Cargamos la conexión a la base de datos'
        conexion = "Data Source=DESKTOP-LCH6UJM\SQLEXPRESS;Initial Catalog=Proyecto_Planyvent;Integrated Security=True"
        cn.ConnectionString = conexion
    End Sub

    Private Sub btnEditarEvento_Click(sender As Object, e As EventArgs) Handles btnEditarEvento.Click
        'Abrimos la conexión'
        cn.Open()

        'Cogemos la fila que seleccione el usuario'
        Dim FilaSeleccionada As Integer = dgvListadoEventos.CurrentRow.Index

        If dgvListadoEventos.Rows(FilaSeleccionada).Cells(0).Value = Nothing Then
            MessageBox.Show("El evento seleccionado no es válido", "Fila no válida", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            'Creamos el adaptador para ver que evento está editando el usuario'
            Dim buscarEvento As New SqlDataAdapter("SELECT * FROM Eventos WHERE nombre_evento= '" & dgvListadoEventos.Rows(FilaSeleccionada).Cells(0).Value & "'", cn)
            Dim dsBuscarEvento As New DataSet
            buscarEvento.Fill(dsBuscarEvento, "datosBuscarEvento")
            ModuloVars.codigoEvento = dsBuscarEvento.Tables("datosBuscarEvento").Rows(0).Item(0)

            'Cogemos de la tabla ActividadesSocial las actividades correspondientes a ese evento'
            Dim BuscarActividades As New SqlDataAdapter("SELECT * FROM actividadesSocial WHERE id_evento= '" & dsBuscarEvento.Tables("datosBuscarEvento").Rows(0).Item(0).ToString() & "'", cn)
            Dim dsBuscarActividades As New DataSet
            BuscarActividades.Fill(dsBuscarActividades, "datosBuscarActividades")

            'Cogemos de la tabla invitacionesSocial las actividades correspondientes a ese evento'
            Dim BuscarInvitaciones As New SqlDataAdapter("SELECT * FROM invitacionesSocial WHERE id_evento= '" & dsBuscarEvento.Tables("datosBuscarEvento").Rows(0).Item(0).ToString() & "'", cn)
            Dim dsBuscarInvitaciones As New DataSet
            BuscarInvitaciones.Fill(dsBuscarInvitaciones, "datosBuscarInvitaciones")

            'Cogemos los valores y los ponemos en el formulario de SocialForm'
            SocialForm.txtNombre.Text = dgvListadoEventos.Rows(FilaSeleccionada).Cells(0).Value.Trim()
            SocialForm.rtbDesc.Text = dgvListadoEventos.Rows(FilaSeleccionada).Cells(1).Value.Trim()
            SocialForm.dtpFecha.Text = dgvListadoEventos.Rows(FilaSeleccionada).Cells(2).Value.Trim()
            SocialForm.txtLugar.Text = dgvListadoEventos.Rows(FilaSeleccionada).Cells(3).Value.Trim()
            SocialForm.rtbInfo.Text = dgvListadoEventos.Rows(FilaSeleccionada).Cells(4).Value.Trim()
            SocialForm.txtPresupuestoTotal.Text = dgvListadoEventos.Rows(FilaSeleccionada).Cells(5).Value.Trim()
            SocialForm.txtPresupuestoGastado.Text = dgvListadoEventos.Rows(FilaSeleccionada).Cells(6).Value.Trim()
            SocialForm.txtPresupuestoRestante.Text = dgvListadoEventos.Rows(FilaSeleccionada).Cells(7).Value.Trim()
            SocialForm.txtInvTotales.Text = dgvListadoEventos.Rows(FilaSeleccionada).Cells(8).Value.Trim()

            'Limpiamos el data grid view de presupuesto'
            PresupuestoAvanzado.dgvPresupuesto.Rows.Clear()

            'Rellenamos el data grid view de presupuesto'
            Dim contador = 0
            For Each Row As DataRow In dsBuscarActividades.Tables("datosBuscarActividades").Rows
                PresupuestoAvanzado.dgvPresupuesto.Rows.Add()
                PresupuestoAvanzado.dgvPresupuesto.Rows(contador).Cells(0).Value = dsBuscarActividades.Tables("datosBuscarActividades").Rows(contador).Item(1).ToString().Trim()
                PresupuestoAvanzado.dgvPresupuesto.Rows(contador).Cells(1).Value = dsBuscarActividades.Tables("datosBuscarActividades").Rows(contador).Item(2).ToString().Trim()
                If dsBuscarActividades.Tables("datosBuscarActividades").Rows(contador).Item(3).ToString().Trim() = True Then
                    PresupuestoAvanzado.dgvPresupuesto.Rows(contador).Cells(2).Value = "Si"
                Else
                    PresupuestoAvanzado.dgvPresupuesto.Rows(contador).Cells(2).Value = "No"
                End If
                contador = contador + 1
            Next

            'Limpiamos el data grid view de invitaciones'
            InvitacionesAvanzado.dgvInvitaciones.Rows.Clear()

            'Rellenamos el data grid view de invitaciones'
            Dim contadorInv = 0
            For Each Row As DataRow In dsBuscarInvitaciones.Tables("datosBuscarInvitaciones").Rows
                InvitacionesAvanzado.dgvInvitaciones.Rows.Add()
                InvitacionesAvanzado.dgvInvitaciones.Rows(contadorInv).Cells(0).Value = dsBuscarInvitaciones.Tables("datosBuscarInvitaciones").Rows(contadorInv).Item(1).ToString().Trim()
                InvitacionesAvanzado.dgvInvitaciones.Rows(contadorInv).Cells(1).Value = dsBuscarInvitaciones.Tables("datosBuscarInvitaciones").Rows(contadorInv).Item(2).ToString().Trim()
                contadorInv = contadorInv + 1
            Next

            'Metemos en la variable del módulo el nombre del evento'
            ModuloVars.nombreEvento = dgvListadoEventos.Rows(FilaSeleccionada).Cells(0).Value

            SocialForm.btnAñadirEvento.Visible = False
            SocialForm.btnGuardarCambios.Visible = True
            SocialForm.btnGuardarCambios.Enabled = False
            Me.Hide()
            SocialForm.Show()
        End If
        'Cerramos la conexión'
        cn.Close()
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Hide()
        Eventos.Show()
    End Sub

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        Me.Hide()
        menuPrincipal.Show()
    End Sub

    Private Sub btnCerrarSesion_Click(sender As Object, e As EventArgs) Handles btnCerrarSesion.Click
        Me.Hide()
        loginForm.Show()
    End Sub

    Private Sub btnCuenta_Click(sender As Object, e As EventArgs) Handles btnCuenta.Click
        Me.Hide()
        datosPersonales.Show()
    End Sub

    Private Sub cmbFiltro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFiltro.SelectedIndexChanged
        If cmbFiltro.SelectedIndex = 0 Then
            'Creamos el adaptador para filtrar los eventos por nombre ascendente'
            Dim filtrarNombreAsc As New SqlDataAdapter("SELECT * FROM Eventos WHERE id_usuario= '" & ModuloVars.codigo & "' ORDER BY nombre_evento ASC", cn)
            Dim dsFiltrarNombreAsc As New DataSet
            filtrarNombreAsc.Fill(dsFiltrarNombreAsc, "filtrarNombreAsc")

            'Limpiamos la lista y la rellenamos con los datos filtrados'
            dgvListadoEventos.Rows.Clear()
            Dim contador = 0
            For Each Row As DataRow In dsFiltrarNombreAsc.Tables("filtrarNombreAsc").Rows
                dgvListadoEventos.Rows.Add()
                dgvListadoEventos.Rows(contador).Cells(0).Value = dsFiltrarNombreAsc.Tables("filtrarNombreAsc").Rows(contador).Item(1).ToString()
                dgvListadoEventos.Rows(contador).Cells(1).Value = dsFiltrarNombreAsc.Tables("filtrarNombreAsc").Rows(contador).Item(2).ToString()
                dgvListadoEventos.Rows(contador).Cells(2).Value = dsFiltrarNombreAsc.Tables("filtrarNombreAsc").Rows(contador).Item(3).ToString()
                dgvListadoEventos.Rows(contador).Cells(3).Value = dsFiltrarNombreAsc.Tables("filtrarNombreAsc").Rows(contador).Item(4).ToString()
                dgvListadoEventos.Rows(contador).Cells(4).Value = dsFiltrarNombreAsc.Tables("filtrarNombreAsc").Rows(contador).Item(5).ToString()
                dgvListadoEventos.Rows(contador).Cells(5).Value = dsFiltrarNombreAsc.Tables("filtrarNombreAsc").Rows(contador).Item(7).ToString()
                dgvListadoEventos.Rows(contador).Cells(6).Value = dsFiltrarNombreAsc.Tables("filtrarNombreAsc").Rows(contador).Item(8).ToString()
                dgvListadoEventos.Rows(contador).Cells(7).Value = dsFiltrarNombreAsc.Tables("filtrarNombreAsc").Rows(contador).Item(9).ToString()
                dgvListadoEventos.Rows(contador).Cells(8).Value = dsFiltrarNombreAsc.Tables("filtrarNombreAsc").Rows(contador).Item(10).ToString()
                contador = contador + 1
            Next
        ElseIf cmbFiltro.SelectedIndex = 1 Then
            'Creamos el adaptador para filtrar los eventos por nombre descendente'
            Dim filtrarNombreDesc As New SqlDataAdapter("SELECT * FROM Eventos WHERE id_usuario= '" & ModuloVars.codigo & "' ORDER BY nombre_evento DESC", cn)
            Dim dsFiltrarNombreDesc As New DataSet
            filtrarNombreDesc.Fill(dsFiltrarNombreDesc, "filtrarNombreDesc")

            'Limpiamos la lista y la rellenamos con los datos filtrados'
            dgvListadoEventos.Rows.Clear()
            Dim contador = 0
            For Each Row As DataRow In dsFiltrarNombreDesc.Tables("filtrarNombreDesc").Rows
                dgvListadoEventos.Rows.Add()
                dgvListadoEventos.Rows(contador).Cells(0).Value = dsFiltrarNombreDesc.Tables("filtrarNombreDesc").Rows(contador).Item(1).ToString()
                dgvListadoEventos.Rows(contador).Cells(1).Value = dsFiltrarNombreDesc.Tables("filtrarNombreDesc").Rows(contador).Item(2).ToString()
                dgvListadoEventos.Rows(contador).Cells(2).Value = dsFiltrarNombreDesc.Tables("filtrarNombreDesc").Rows(contador).Item(3).ToString()
                dgvListadoEventos.Rows(contador).Cells(3).Value = dsFiltrarNombreDesc.Tables("filtrarNombreDesc").Rows(contador).Item(4).ToString()
                dgvListadoEventos.Rows(contador).Cells(4).Value = dsFiltrarNombreDesc.Tables("filtrarNombreDesc").Rows(contador).Item(5).ToString()
                dgvListadoEventos.Rows(contador).Cells(5).Value = dsFiltrarNombreDesc.Tables("filtrarNombreDesc").Rows(contador).Item(7).ToString()
                dgvListadoEventos.Rows(contador).Cells(6).Value = dsFiltrarNombreDesc.Tables("filtrarNombreDesc").Rows(contador).Item(8).ToString()
                dgvListadoEventos.Rows(contador).Cells(7).Value = dsFiltrarNombreDesc.Tables("filtrarNombreDesc").Rows(contador).Item(9).ToString()
                dgvListadoEventos.Rows(contador).Cells(8).Value = dsFiltrarNombreDesc.Tables("filtrarNombreDesc").Rows(contador).Item(10).ToString()
                contador = contador + 1
            Next
        ElseIf cmbFiltro.SelectedIndex = 2 Then
            'Creamos el adaptador para filtrar los eventos por fecha ascendente'
            Dim filtrarFechaAsc As New SqlDataAdapter("SELECT * FROM Eventos WHERE id_usuario= '" & ModuloVars.codigo & "' ORDER BY fecha ASC", cn)
            Dim dsFiltrarFechaAsc As New DataSet
            filtrarFechaAsc.Fill(dsFiltrarFechaAsc, "filtrarFechaAsc")

            'Limpiamos la lista y la rellenamos con los datos filtrados'
            dgvListadoEventos.Rows.Clear()
            Dim contador = 0
            For Each Row As DataRow In dsFiltrarFechaAsc.Tables("filtrarFechaAsc").Rows
                dgvListadoEventos.Rows.Add()
                dgvListadoEventos.Rows(contador).Cells(0).Value = dsFiltrarFechaAsc.Tables("filtrarFechaAsc").Rows(contador).Item(1).ToString()
                dgvListadoEventos.Rows(contador).Cells(1).Value = dsFiltrarFechaAsc.Tables("filtrarFechaAsc").Rows(contador).Item(2).ToString()
                dgvListadoEventos.Rows(contador).Cells(2).Value = dsFiltrarFechaAsc.Tables("filtrarFechaAsc").Rows(contador).Item(3).ToString()
                dgvListadoEventos.Rows(contador).Cells(3).Value = dsFiltrarFechaAsc.Tables("filtrarFechaAsc").Rows(contador).Item(4).ToString()
                dgvListadoEventos.Rows(contador).Cells(4).Value = dsFiltrarFechaAsc.Tables("filtrarFechaAsc").Rows(contador).Item(5).ToString()
                dgvListadoEventos.Rows(contador).Cells(5).Value = dsFiltrarFechaAsc.Tables("filtrarFechaAsc").Rows(contador).Item(7).ToString()
                dgvListadoEventos.Rows(contador).Cells(6).Value = dsFiltrarFechaAsc.Tables("filtrarFechaAsc").Rows(contador).Item(8).ToString()
                dgvListadoEventos.Rows(contador).Cells(7).Value = dsFiltrarFechaAsc.Tables("filtrarFechaAsc").Rows(contador).Item(9).ToString()
                dgvListadoEventos.Rows(contador).Cells(8).Value = dsFiltrarFechaAsc.Tables("filtrarFechaAsc").Rows(contador).Item(10).ToString()
                contador = contador + 1
            Next
        Else
            'Creamos el adaptador para filtrar los eventos por fecha descendente'
            Dim filtrarFechaDesc As New SqlDataAdapter("SELECT * FROM Eventos WHERE id_usuario= '" & ModuloVars.codigo & "' ORDER BY fecha DESC", cn)
            Dim dsFiltrarFechaDesc As New DataSet
            filtrarFechaDesc.Fill(dsFiltrarFechaDesc, "filtrarFechaDesc")

            'Limpiamos la lista y la rellenamos con los datos filtrados'
            dgvListadoEventos.Rows.Clear()
            Dim contador = 0
            For Each Row As DataRow In dsFiltrarFechaDesc.Tables("filtrarFechaDesc").Rows
                dgvListadoEventos.Rows.Add()
                dgvListadoEventos.Rows(contador).Cells(0).Value = dsFiltrarFechaDesc.Tables("filtrarFechaDesc").Rows(contador).Item(1).ToString()
                dgvListadoEventos.Rows(contador).Cells(1).Value = dsFiltrarFechaDesc.Tables("filtrarFechaDesc").Rows(contador).Item(2).ToString()
                dgvListadoEventos.Rows(contador).Cells(2).Value = dsFiltrarFechaDesc.Tables("filtrarFechaDesc").Rows(contador).Item(3).ToString()
                dgvListadoEventos.Rows(contador).Cells(3).Value = dsFiltrarFechaDesc.Tables("filtrarFechaDesc").Rows(contador).Item(4).ToString()
                dgvListadoEventos.Rows(contador).Cells(4).Value = dsFiltrarFechaDesc.Tables("filtrarFechaDesc").Rows(contador).Item(5).ToString()
                dgvListadoEventos.Rows(contador).Cells(5).Value = dsFiltrarFechaDesc.Tables("filtrarFechaDesc").Rows(contador).Item(7).ToString()
                dgvListadoEventos.Rows(contador).Cells(6).Value = dsFiltrarFechaDesc.Tables("filtrarFechaDesc").Rows(contador).Item(8).ToString()
                dgvListadoEventos.Rows(contador).Cells(7).Value = dsFiltrarFechaDesc.Tables("filtrarFechaDesc").Rows(contador).Item(9).ToString()
                dgvListadoEventos.Rows(contador).Cells(8).Value = dsFiltrarFechaDesc.Tables("filtrarFechaDesc").Rows(contador).Item(10).ToString()
                contador = contador + 1
            Next
        End If
    End Sub

    Private Sub btnReiniciar_Click(sender As Object, e As EventArgs) Handles btnReiniciar.Click
        'Abrimos la conexión'
        cn.Open()

        'Creamos el adaptador para buscar los eventos que tengamos en menos de una semana'
        Dim buscarEv As New SqlDataAdapter("SELECT * FROM Eventos WHERE id_usuario= '" & ModuloVars.codigo & "'", cn)
        Dim dsBuscarEv As New DataSet
        buscarEv.Fill(dsBuscarEv, "buscarEventos")

        'Recorremos todos los eventos devueltos'
        Dim contador = 0

        'Limpiamos el data grid view'
        dgvListadoEventos.Rows.Clear()

        For Each Row As DataRow In dsBuscarEv.Tables("buscarEventos").Rows
            dgvListadoEventos.Rows.Add()
            dgvListadoEventos.Rows(contador).Cells(0).Value = dsBuscarEv.Tables("buscarEventos").Rows(contador).Item(1).ToString()
            dgvListadoEventos.Rows(contador).Cells(1).Value = dsBuscarEv.Tables("buscarEventos").Rows(contador).Item(2).ToString()
            dgvListadoEventos.Rows(contador).Cells(2).Value = dsBuscarEv.Tables("buscarEventos").Rows(contador).Item(3).ToString()
            dgvListadoEventos.Rows(contador).Cells(3).Value = dsBuscarEv.Tables("buscarEventos").Rows(contador).Item(4).ToString()
            dgvListadoEventos.Rows(contador).Cells(4).Value = dsBuscarEv.Tables("buscarEventos").Rows(contador).Item(5).ToString()
            dgvListadoEventos.Rows(contador).Cells(5).Value = dsBuscarEv.Tables("buscarEventos").Rows(contador).Item(7).ToString()
            dgvListadoEventos.Rows(contador).Cells(6).Value = dsBuscarEv.Tables("buscarEventos").Rows(contador).Item(8).ToString()
            dgvListadoEventos.Rows(contador).Cells(7).Value = dsBuscarEv.Tables("buscarEventos").Rows(contador).Item(9).ToString()
            dgvListadoEventos.Rows(contador).Cells(8).Value = dsBuscarEv.Tables("buscarEventos").Rows(contador).Item(10).ToString()
            contador = contador + 1
        Next
        cmbFiltro.Text = ""

        'Cerramos la conexión'
        cn.Close()
    End Sub

    Private Sub btnEliminarEvento_Click(sender As Object, e As EventArgs) Handles btnEliminarEvento.Click
        'Abrimos la conexión'
        cn.Open()

        'Cogemos la fila que seleccione el usuario'
        Dim FilaSeleccionada As Integer = dgvListadoEventos.CurrentRow.Index

        'Creamos el DialogResult'
        Dim opcion As DialogResult
        opcion = MessageBox.Show("¿Está seguro que desea eliminar el evento seleccionado?", "Eliminar evento", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If opcion = Windows.Forms.DialogResult.Yes Then
            If dgvListadoEventos.Rows(FilaSeleccionada).Cells(0).Value = Nothing Then
                MessageBox.Show("La fila seleccionada no es váldia", "Fila no válida", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                'Creamos el adaptador para borrar el evento seleccionado'
                Dim buscarEvento As New SqlDataAdapter("SELECT * FROM Eventos WHERE nombre_evento= '" & dgvListadoEventos.Rows(FilaSeleccionada).Cells(0).Value & "'", cn)
                Dim dsBuscarEvento As New DataSet
                buscarEvento.Fill(dsBuscarEvento, "datosBuscarEvento")
                ModuloVars.codigoEvento = dsBuscarEvento.Tables("datosBuscarEvento").Rows(0).Item(0).ToString().Trim()

                'Creamos el adaptador para borrar el evento seleccionado'
                Dim eliminarEvento As New SqlCommand("DELETE FROM Eventos WHERE id_evento= '" & ModuloVars.codigoEvento & "'", cn)
                eliminarEvento.ExecuteNonQuery()

                'Cogemos de la tabla ActividadesSocial las actividades correspondientes a ese evento'
                Dim eliminarActividad As New SqlCommand("DELETE FROM actividadesSocial WHERE id_evento= '" & ModuloVars.codigoEvento & "'", cn)
                eliminarActividad.ExecuteNonQuery()

                'Cogemos de la tabla invitacionesSocial las actividades correspondientes a ese evento'
                Dim eliminarInvitacion As New SqlCommand("DELETE FROM invitacionesSocial WHERE id_evento= '" & ModuloVars.codigoEvento & "'", cn)
                eliminarInvitacion.ExecuteNonQuery()

                dgvListadoEventos.Rows.Remove(dgvListadoEventos.CurrentRow)
                menuPrincipal.dgvEventosProximos.Rows.Clear()

                'Creamos el adaptador para buscar los eventos que tengamos en menos de una semana'
                Dim buscarEventos As New SqlDataAdapter("SELECT * FROM Eventos WHERE id_usuario= '" & ModuloVars.codigo & "'", cn)
                Dim dsBuscarEventos As New DataSet
                buscarEventos.Fill(dsBuscarEventos, "buscarEventos")

                'Cargamos la fecha actual'
                Dim fecha As Date = Today
                Dim fechaEvento As Date

                'Recorremos todos los eventos devueltos'
                Dim contador = 0
                Dim contadorFilas = 0

                For Each Row As DataRow In dsBuscarEventos.Tables("buscarEventos").Rows
                    fechaEvento = dsBuscarEventos.Tables("buscarEventos").Rows(contador).Item(3).ToString
                    Dim dias As Integer = (fechaEvento - fecha).Days
                    If dias <= 7 And dias >= 0 Then
                        menuPrincipal.dgvEventosProximos.Rows.Add()
                        menuPrincipal.dgvEventosProximos.Rows(contadorFilas).Cells(0).Value = dsBuscarEventos.Tables("buscarEventos").Rows(contador).Item(1).ToString()
                        menuPrincipal.dgvEventosProximos.Rows(contadorFilas).Cells(1).Value = dsBuscarEventos.Tables("buscarEventos").Rows(contador).Item(2).ToString()
                        menuPrincipal.dgvEventosProximos.Rows(contadorFilas).Cells(2).Value = dsBuscarEventos.Tables("buscarEventos").Rows(contador).Item(3).ToString()
                        menuPrincipal.dgvEventosProximos.Rows(contadorFilas).Cells(3).Value = dsBuscarEventos.Tables("buscarEventos").Rows(contador).Item(4).ToString()
                        menuPrincipal.dgvEventosProximos.Rows(contadorFilas).Cells(4).Value = dsBuscarEventos.Tables("buscarEventos").Rows(contador).Item(5).ToString()
                        menuPrincipal.dgvEventosProximos.Rows(contadorFilas).Cells(5).Value = dsBuscarEventos.Tables("buscarEventos").Rows(contador).Item(7).ToString()
                        menuPrincipal.dgvEventosProximos.Rows(contadorFilas).Cells(6).Value = dsBuscarEventos.Tables("buscarEventos").Rows(contador).Item(8).ToString()
                        menuPrincipal.dgvEventosProximos.Rows(contadorFilas).Cells(7).Value = dsBuscarEventos.Tables("buscarEventos").Rows(contador).Item(9).ToString()
                        menuPrincipal.dgvEventosProximos.Rows(contadorFilas).Cells(8).Value = dsBuscarEventos.Tables("buscarEventos").Rows(contador).Item(10).ToString()
                        contadorFilas = contadorFilas + 1
                    End If
                    contador = contador + 1
                Next
                MessageBox.Show("Evento eliminado con éxito", "Evento eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
        'Cerramos la conexión'
        cn.Close()
    End Sub
End Class