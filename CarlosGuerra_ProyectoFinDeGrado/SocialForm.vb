Imports System.Runtime.InteropServices
Imports System.Data.SqlClient
Public Class SocialForm

    Dim conexion As String
    Dim cn As New SqlConnection
    Dim contador As String
    Dim fechaActual As Date

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

    Private Sub btnPresupuestoAvanzadas_Click(sender As Object, e As EventArgs) Handles btnPresupuestoAvanzadas.Click
        If btnAñadirEvento.Visible = False Then
            'Activamos y desactivamos los botones correspondientes'
            PresupuestoAvanzado.btnGuardarCambios.Visible = True
            PresupuestoAvanzado.btnAñadirNuevaAct.Visible = True
            PresupuestoAvanzado.btnAñadir.Visible = False
        Else
            'Activamos y desactivamos los botones correspondientes'
            PresupuestoAvanzado.btnGuardarCambios.Visible = False
            PresupuestoAvanzado.btnAñadirNuevaAct.Visible = False
            PresupuestoAvanzado.btnAñadir.Visible = True
        End If
        'Desactivamos el botón de editar y eliminar hasta que seleccionen una fila'
        PresupuestoAvanzado.btnGuardarCambios.Enabled = False
        PresupuestoAvanzado.btnActSelecc.Enabled = False
        Me.Hide()
        PresupuestoAvanzado.Show()
    End Sub

    Private Sub txtPresupuestoTotal_MouseEnter(sender As Object, e As EventArgs) Handles txtPresupuestoTotal.MouseEnter
        'Tooltip para el textbox de presupuesto total'
        ttPTotal.SetToolTip(txtPresupuestoTotal, "Presupuesto total del evento")
        ttPTotal.ToolTipTitle = "Presupuesto total"
        ttPTotal.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtPresupuestoGastado_MouseEnter(sender As Object, e As EventArgs) Handles txtPresupuestoGastado.MouseEnter
        'Tooltip para el textbox de presupuesto gastado'
        ttPGastado.SetToolTip(txtPresupuestoGastado, "Deuda ya pagada del evento")
        ttPGastado.ToolTipTitle = "Deuda pagada"
        ttPGastado.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtPresupuestoRestante_MouseEnter(sender As Object, e As EventArgs) Handles txtPresupuestoRestante.MouseEnter
        'Tooltip para el textbox de presupuesto restante'
        ttPRestante.SetToolTip(txtPresupuestoRestante, "Deuda restante a pagar del evento")
        ttPRestante.ToolTipTitle = "Deuda restante"
        ttPRestante.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub SocialForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Cargamos la conexión a la base de datos'
        conexion = "Data Source=DESKTOP-LCH6UJM\SQLEXPRESS;Initial Catalog=Proyecto_Planyvent;Integrated Security=True"
        cn.ConnectionString = conexion

        Dim adaptadorBuscar As New SqlDataAdapter("SELECT * FROM Eventos ORDER BY id_evento DESC", cn)
        Dim ds As New DataSet
        adaptadorBuscar.Fill(ds, "datos")

        If ds.Tables("datos").Rows.Count > 0 Then
            contador = ds.Tables("datos").Rows(0).Item(0).ToString.Trim()
            Convert.ToInt32(contador)
            contador += 1
            ModuloVars.codigoPresupuesto = contador
        Else
            Convert.ToInt32(contador)
            contador = 1
            ModuloVars.codigoPresupuesto = contador
        End If

    End Sub

    Private Sub btnAñadirEvento_Click(sender As Object, e As EventArgs) Handles btnAñadirEvento.Click
        'Cargamos la fecha actual'
        Dim fecha As Date = Today
        Dim fechaEvento As Date
        Dim opcion As DialogResult

        'Creamos el adaptador que compruebe si existe el nombre del evento para dicho usuario'
        Dim adaptadorBuscar As New SqlDataAdapter("SELECT * FROM Eventos WHERE nombre_evento= '" & txtNombre.Text & "' AND id_usuario= '" & ModuloVars.codigo & "'", cn)
        Dim ds As New DataSet
        adaptadorBuscar.Fill(ds, "datos")

        'Cogemos la fecha actual'
        fechaActual = Today

        If txtNombre.Text.Equals("") Then
            MessageBox.Show("Es necesario introducir el nombre del evento", "Campo vacio", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf ds.Tables("datos").Rows.Count > 0 Then
            MessageBox.Show("Ya existe un evento con el mismo nombre", "Evento repetido", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf fechaActual > dtpFecha.Value Then
            MessageBox.Show("La fecha no puede ser menor a la actual", "Fecha incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            opcion = MessageBox.Show("¿Desea terminar de añadir el evento? Una vez aceptado sólo podrá modificar el evento desde el menú de editar", "Información importante", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If opcion = Windows.Forms.DialogResult.Yes Then
                'Abrimos la conexión'
                cn.Open()

                'Creamos el adaptador para insertar los datos en la tabla de la BBDD'
                Dim adaptadorInsert As New SqlCommand("insert into Eventos values('" & contador & "','" & txtNombre.Text & "', '" & rtbDesc.Text & "', '" & dtpFecha.Value & "', '" & txtLugar.Text & "', '" & rtbInfo.Text & "', '" & ModuloVars.codigo & "', '" & txtPresupuestoTotal.Text & "', '" & txtPresupuestoGastado.Text & "', '" & txtPresupuestoRestante.Text & "', '" & txtInvTotales.Text & "')", cn)
                adaptadorInsert.ExecuteNonQuery()

                'Creamos el adaptador para buscar los eventos que tengamos en menos de una semana'
                Dim buscarEventos As New SqlDataAdapter("SELECT * FROM Eventos WHERE id_usuario= '" & ModuloVars.codigo & "'", cn)
                Dim dsBuscarEventos As New DataSet
                buscarEventos.Fill(dsBuscarEventos, "buscarEventos")

                'Recorremos todos los eventos devueltos'
                Dim contadorFecha = 0
                Dim contadorFilas = 0

                'Limpiamos las filas del data grid view'
                menuPrincipal.dgvEventosProximos.Rows.Clear()

                For Each Row As DataRow In dsBuscarEventos.Tables("buscarEventos").Rows
                    fechaEvento = dsBuscarEventos.Tables("buscarEventos").Rows(contadorFecha).Item(3).ToString()
                    Dim dias As Integer = (fechaEvento - fecha).Days
                    If dias <= 7 And dias >= 0 Then
                        menuPrincipal.dgvEventosProximos.Rows.Add()
                        menuPrincipal.dgvEventosProximos.Rows(contadorFilas).Cells(0).Value = dsBuscarEventos.Tables("buscarEventos").Rows(contadorFecha).Item(1).ToString()
                        menuPrincipal.dgvEventosProximos.Rows(contadorFilas).Cells(1).Value = dsBuscarEventos.Tables("buscarEventos").Rows(contadorFecha).Item(2).ToString()
                        menuPrincipal.dgvEventosProximos.Rows(contadorFilas).Cells(2).Value = dsBuscarEventos.Tables("buscarEventos").Rows(contadorFecha).Item(3).ToString()
                        menuPrincipal.dgvEventosProximos.Rows(contadorFilas).Cells(3).Value = dsBuscarEventos.Tables("buscarEventos").Rows(contadorFecha).Item(4).ToString()
                        menuPrincipal.dgvEventosProximos.Rows(contadorFilas).Cells(4).Value = dsBuscarEventos.Tables("buscarEventos").Rows(contadorFecha).Item(5).ToString()
                        menuPrincipal.dgvEventosProximos.Rows(contadorFilas).Cells(5).Value = dsBuscarEventos.Tables("buscarEventos").Rows(contadorFecha).Item(7).ToString()
                        menuPrincipal.dgvEventosProximos.Rows(contadorFilas).Cells(6).Value = dsBuscarEventos.Tables("buscarEventos").Rows(contadorFecha).Item(8).ToString()
                        menuPrincipal.dgvEventosProximos.Rows(contadorFilas).Cells(7).Value = dsBuscarEventos.Tables("buscarEventos").Rows(contadorFecha).Item(9).ToString()
                        menuPrincipal.dgvEventosProximos.Rows(contadorFilas).Cells(8).Value = dsBuscarEventos.Tables("buscarEventos").Rows(contadorFecha).Item(10).ToString()
                        contadorFilas = contadorFilas + 1
                    End If
                    contadorFecha = contadorFecha + 1
                Next

                MessageBox.Show("El evento ha sido añadido con éxito", "Evento añadido", MessageBoxButtons.OK, MessageBoxIcon.Information)

                'Sumamos 1 a contador'
                Convert.ToInt32(contador)
                contador += 1
                ModuloVars.codigoPresupuesto = contador

                'Vaciamos las cajas de texto y los data grid view'
                txtNombre.Text = ""
                rtbDesc.Text = ""
                rtbInfo.Text = ""
                txtLugar.Text = ""
                dtpFecha.Value = Today()
                txtPresupuestoTotal.Text = ""
                txtPresupuestoGastado.Text = ""
                txtPresupuestoRestante.Text = ""
                txtInvTotales.Text = ""
                PresupuestoAvanzado.dgvPresupuesto.Rows.Clear()
                PresupuestoAvanzado.txtActividad.Text = ""
                PresupuestoAvanzado.txtCoste.Text = ""

                'Cerramos la conexión'
                cn.Close()
            End If
        End If
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Dim opcion As DialogResult
        opcion = MessageBox.Show("¿Está seguro que desea salir? Recuerde que si no ha guardado todos los cambios serán descartados", "Recuerde guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If opcion = Windows.Forms.DialogResult.Yes Then
            Me.Hide()
            Eventos.Show()
        End If
    End Sub

    Private Sub btnInvitacionesAvanzadas_Click(sender As Object, e As EventArgs) Handles btnInvitacionesAvanzadas.Click
        If btnAñadirEvento.Visible = False Then
            InvitacionesAvanzado.btnGuardarCambios.Visible = True
            InvitacionesAvanzado.btnAñadirInv.Visible = True
            InvitacionesAvanzado.btnAñadir.Visible = False
        Else
            InvitacionesAvanzado.btnGuardarCambios.Visible = False
            InvitacionesAvanzado.btnAñadirInv.Visible = False
            InvitacionesAvanzado.btnAñadir.Visible = True
        End If
        InvitacionesAvanzado.btnGuardarCambios.Enabled = False
        InvitacionesAvanzado.btnActSelecc.Enabled = False
        Me.Hide()
        InvitacionesAvanzado.Show()
    End Sub

    Private Sub btnGuardarCambios_Click(sender As Object, e As EventArgs) Handles btnGuardarCambios.Click
        'Cargamos la fecha actual'
        Dim fecha As Date = Today
        Dim fechaEvento As Date

        'Abrimos la conexión'
        cn.Open()

        If fecha > dtpFecha.Value Then
            MessageBox.Show("La fecha no puede ser menor a la actual", "Fecha incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            'Creamos el adaptador para actualizar los datos al editar el evento'
            Dim actualizarEvento As New SqlCommand("UPDATE Eventos SET nombre_evento= '" & txtNombre.Text & "', desc_evento= '" & rtbDesc.Text & "', fecha= '" & dtpFecha.Value & "', lugar_evento= '" & txtLugar.Text & "', info_evento= '" & rtbInfo.Text & "', presupuesto_total= '" & txtPresupuestoTotal.Text & "', deuda_pagada= '" & txtPresupuestoGastado.Text & "', deuda_pagar= '" & txtPresupuestoRestante.Text & "', invitaciones_totales= '" & txtInvTotales.Text & "' WHERE nombre_evento= '" & ModuloVars.nombreEvento & "' AND id_usuario= '" & ModuloVars.codigo & "'", cn)
            actualizarEvento.ExecuteNonQuery()

            'Creamos el adaptador para buscar los eventos que tengamos en menos de una semana'
            Dim buscarEventos As New SqlDataAdapter("SELECT * FROM Eventos WHERE id_usuario= '" & ModuloVars.codigo & "'", cn)
            Dim dsBuscarEventos As New DataSet
            buscarEventos.Fill(dsBuscarEventos, "buscarEventos")

            'Recorremos todos los eventos devueltos'
            Dim contador = 0
            Dim contadorFilas = 0

            For Each Row As DataRow In dsBuscarEventos.Tables("buscarEventos").Rows
                fechaEvento = dsBuscarEventos.Tables("buscarEventos").Rows(contador).Item(3).ToString()
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
            'Mandamos un mensaje de que se ha actualizado correctamente el evento'
            MessageBox.Show("El evento ha sido actualizado con éxito", "Evento actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        'Cerammos la conexión'
        cn.Close()
    End Sub

    Private Sub cambiarTexto(sender As Object, e As EventArgs) Handles txtNombre.TextChanged, txtLugar.TextChanged, rtbDesc.TextChanged, rtbInfo.TextChanged, dtpFecha.TextChanged,
            txtPresupuestoTotal.TextChanged, txtPresupuestoGastado.TextChanged, txtPresupuestoRestante.TextChanged, txtInvTotales.TextChanged
        btnGuardarCambios.Enabled = True
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
End Class