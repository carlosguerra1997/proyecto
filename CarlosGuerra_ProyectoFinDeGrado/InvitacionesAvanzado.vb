Imports System.Runtime.InteropServices
Imports System.Data.SqlClient
Public Class InvitacionesAvanzado
    Dim conexion As String
    Dim cn As New SqlConnection
    Dim invTotales As Integer
    Dim precioTotal As Decimal

    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub pnlCabecera_MouseMove(sender As Object, e As MouseEventArgs) Handles pnlCabecera.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub


    Private Sub btnMaximizar_Click(sender As Object, e As EventArgs) Handles btnMaximizar.Click
        btnMaximizar.Visible = False
        btnRestaurar.Visible = True
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        End
    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnRestaurar_Click(sender As Object, e As EventArgs) Handles btnRestaurar.Click
        btnRestaurar.Visible = False
        btnMaximizar.Visible = True
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub InvitacionesAvanzado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Cargamos la conexión a la base de datos'
        conexion = "Data Source=DESKTOP-LCH6UJM\SQLEXPRESS;Initial Catalog=Proyecto_Planyvent;Integrated Security=True"
        cn.ConnectionString = conexion
    End Sub

    Private Sub btnAñadir_Click(sender As Object, e As EventArgs) Handles btnAñadir.Click
        'Abrimos la conexión'
        cn.Open()

        'Creamos el adaptador que compruebe si existe el nombre del actividad para dicho usuario'
        Dim buscarInvitacion As New SqlDataAdapter("SELECT * FROM invitacionesSocial WHERE id_evento= '" & ModuloVars.codigoPresupuesto & "' AND invitacion_nombre= '" & txtInvitados.Text & "'", cn)
        Dim ds As New DataSet
        buscarInvitacion.Fill(ds, "datos")

        If ds.Tables("datos").Rows.Count > 0 Then
            MessageBox.Show("Ya existe una actividad con ese nombre", "Nombre repetido", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            If txtInvitados.Text.Equals("") Then
                MessageBox.Show("Alguno de los campos a rellenar está vacio", "Campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ElseIf IsNumeric(txtNumPersonas.Text) Or txtNumPersonas.Text.Equals("") Then
                'Creamos el adaptador para insertar los datos en la tabla de la BBDD'
                Dim adaptadorInsert As New SqlCommand("insert into invitacionesSocial values('" & ModuloVars.codigoPresupuesto & "', '" & txtInvitados.Text & "', '" & txtNumPersonas.Text & "')", cn)
                adaptadorInsert.ExecuteNonQuery()

                'Añadimos los datos al Data Grid View'
                Dim cadena = New String() {txtInvitados.Text, txtNumPersonas.Text}
                dgvInvitaciones.Rows.Add(cadena)
                MessageBox.Show("La invitación se agregó con éxito", "Actividad agregada", MessageBoxButtons.OK, MessageBoxIcon.Information)

                'Pasamos la variable del coste de un formulario a otro'
                'Vamos sumando las cantidades de las actividades que añadimos en el data grid view'
                If SocialForm.txtInvTotales.Text.Equals("") Then
                    invTotales = Convert.ToDecimal(txtNumPersonas.Text)
                    SocialForm.txtInvTotales.Text = invTotales.ToString
                Else
                    invTotales = Convert.ToDecimal(SocialForm.txtInvTotales.Text) + Convert.ToDecimal(txtNumPersonas.Text)
                    SocialForm.txtInvTotales.Text = invTotales.ToString
                End If

            Else
                MessageBox.Show("El campo de invitados debe contener un valor numérico", "Campo inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If

        'Cerramos la conexión'
        cn.Close()
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Hide()
        SocialForm.Show()
    End Sub

    Private Sub btnEliminarTodos_Click(sender As Object, e As EventArgs) Handles btnEliminarTodos.Click
        'Abrimos la conexión'
        cn.Open()

        'Limpiamos el data grid view'
        dgvInvitaciones.Rows.Clear()

        'Borramos las actividades de la BBDD'
        'Creamos el adaptador para borrar la actividad'
        Dim borrarInvitaciones As New SqlCommand("DELETE FROM invitacionesSocial WHERE id_evento= '" & ModuloVars.codigoEvento & "'", cn)
        borrarInvitaciones.ExecuteNonQuery()

        'Limpiamos los textboxes'
        txtInvitados.Text = ""
        txtNumPersonas.Text = ""
        SocialForm.txtInvTotales.Text = ""

        'Actualizamos los valores de la tabla de Eventos'
        Dim actualizarInvEventos As New SqlCommand("UPDATE Eventos SET invitaciones_totales= '" & 0 & "' WHERE id_evento= '" & ModuloVars.codigoEvento & "'", cn)
        actualizarInvEventos.ExecuteNonQuery()

        'Mostramos el mensaje de feedback'
        MessageBox.Show("Todas las invitaciones han sido borradas con éxito", "Invitaciones borradas", MessageBoxButtons.OK, MessageBoxIcon.Information)

        'Cerramos la conexión'
        cn.Close()
    End Sub

    Private Sub btnActSelecc_Click(sender As Object, e As EventArgs) Handles btnActSelecc.Click
        'Abrimos la conexión'
        cn.Open()

        'Cogemos la fila seleccionada del data grid view'
        Dim FilaSeleccionada As Integer = dgvInvitaciones.CurrentRow.Index

        If dgvInvitaciones.Rows(FilaSeleccionada).Cells(0).Value = Nothing Then
            MessageBox.Show("La fila seleccionada para eliminar no es váldia", "Fila no válida", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            'Restamos el número de invitados del textbox'
            If SocialForm.txtInvTotales.Text.Equals("") Then
            Else
                precioTotal = Convert.ToDecimal(SocialForm.txtInvTotales.Text) - Convert.ToDecimal(txtNumPersonas.Text)
                SocialForm.txtInvTotales.Text = precioTotal.ToString
            End If

            'Creamos el adaptador para borrar la invitación'
            Dim borrarInv As New SqlCommand("DELETE FROM invitacionesSocial WHERE id_evento= '" & ModuloVars.codigoEvento & "' AND invitacion_nombre='" & dgvInvitaciones.Rows(FilaSeleccionada).Cells(0).Value & "'", cn)
            borrarInv.ExecuteNonQuery()

            'Creamos el adaptador para actualizar el número de invitados en la BBDD'
            Dim actualizarInv As New SqlCommand("UPDATE Eventos SET invitaciones_totales= '" & SocialForm.txtInvTotales.Text & "' WHERE id_evento= '" & ModuloVars.codigoEvento & "'", cn)
            actualizarInv.ExecuteNonQuery()

            'Borramos la fila correspondiente del data grid view'
            dgvInvitaciones.Rows.Remove(dgvInvitaciones.Rows(FilaSeleccionada))
        End If
        'Cerramos la conexión'
        cn.Close()
    End Sub

    Private Sub btnGuardarCambios_Click(sender As Object, e As EventArgs) Handles btnGuardarCambios.Click
        'Abrimos la conexión'
        cn.Open()

        'Cogemos la fila seleccionada por el usuario'
        Dim FilaSeleccionada As Integer = dgvInvitaciones.CurrentRow.Index

        If txtInvitados.Text.Equals("") Or txtNumPersonas.Text.Equals("") Then
            MessageBox.Show("Alguno de los campos está vacio", "Campo vacio", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf dgvInvitaciones.Rows(FilaSeleccionada).Cells(0).Value = Nothing Then
            MessageBox.Show("La fila seleccionada no es váldia", "Fila no válida", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf IsNumeric(txtNumPersonas.Text) And txtNumPersonas.Text > 0 Then
            'Creamos el adaptador para actualizar los datos de las actividades'
            Dim actualizarActividades As New SqlCommand("UPDATE invitacionesSocial SET invitacion_nombre= '" & txtInvitados.Text & "', numero_invitados= '" & txtNumPersonas.Text & "' WHERE id_evento= '" & ModuloVars.codigoEvento & "' AND invitacion_nombre= '" & dgvInvitaciones.Rows(FilaSeleccionada).Cells(0).Value & "'", cn)
            actualizarActividades.ExecuteNonQuery()
            MessageBox.Show("Invitación actualizada con éxito", "Actividad actualizada", MessageBoxButtons.OK, MessageBoxIcon.Information)

            'Actualizamos el valor del número de invitados del textbox del evento'
            If SocialForm.txtInvTotales.Text.Equals("") Then
                invTotales = Convert.ToDecimal(txtNumPersonas.Text)
                SocialForm.txtInvTotales.Text = invTotales.ToString
            Else
                invTotales = Convert.ToDecimal(SocialForm.txtInvTotales.Text) - Convert.ToDecimal(dgvInvitaciones.Rows(FilaSeleccionada).Cells(1).Value) + Convert.ToDecimal(txtNumPersonas.Text)
                SocialForm.txtInvTotales.Text = invTotales.ToString
            End If

            'Actualizamos el data grid view en tiempo real'
            dgvInvitaciones.Rows(FilaSeleccionada).Cells(0).Value = txtInvitados.Text
            dgvInvitaciones.Rows(FilaSeleccionada).Cells(1).Value = txtNumPersonas.Text

            'Creamos el adaptador para actualizar las invitaciones del evento'
            Dim actualizarEvento As New SqlCommand("UPDATE Eventos SET invitaciones_totales= '" & SocialForm.txtInvTotales.Text & "' WHERE id_evento= '" & ModuloVars.codigoEvento & "'", cn)
            actualizarEvento.ExecuteNonQuery()
        Else
            MessageBox.Show("El campo número de invitados debe contener un valor numérico mayor que 0", "Campo inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        'Cerramos la conexión'
        cn.Close()
    End Sub

    Private Sub dgvInvitaciones_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvInvitaciones.RowHeaderMouseClick
        'Cogemos la fila seleccionada'
        Dim FilaSeleccionada As Integer = dgvInvitaciones.CurrentRow.Index
        'Cargamos los datos en los Textboxes'
        txtInvitados.Text = dgvInvitaciones.Rows(FilaSeleccionada).Cells(0).Value
        txtNumPersonas.Text = dgvInvitaciones.Rows(FilaSeleccionada).Cells(1).Value

        If dgvInvitaciones.Rows(FilaSeleccionada).Cells(0).Value = Nothing Then
            MessageBox.Show("La invitación que desea editar o eliminar no ha sido encontrada", "Error al editar", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            btnGuardarCambios.Enabled = True
            btnActSelecc.Enabled = True
        End If


    End Sub

    Private Sub btnAñadirInv_Click(sender As Object, e As EventArgs) Handles btnAñadirInv.Click
        'Abrimos la conexión'
        cn.Open()

        If txtInvitados.Text.Equals("") Or txtNumPersonas.Text.Equals("") Then
            MessageBox.Show("Alguno de los campos a rellenar está vacio", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf IsNumeric(txtNumPersonas.Text) Then
            'Creamos el adaptador para insertar los datos en la tabla de la BBDD'
            Dim adaptadorNuevaInv As New SqlCommand("insert into invitacionesSocial values('" & ModuloVars.codigoEvento & "', '" & txtInvitados.Text & "', '" & txtNumPersonas.Text & "')", cn)
            adaptadorNuevaInv.ExecuteNonQuery()

            'Añadimos los datos al Data Grid View'
            Dim cadena = New String() {txtInvitados.Text, txtNumPersonas.Text}
            dgvInvitaciones.Rows.Add(cadena)

            'Sumamos el número de invitados al textbox'
            If SocialForm.txtInvTotales.Text.Equals("") Then
            Else
                invTotales = Convert.ToDecimal(SocialForm.txtInvTotales.Text) + Convert.ToDecimal(txtNumPersonas.Text)
                SocialForm.txtInvTotales.Text = invTotales.ToString
            End If

            'Actualizamos las invitaciones del evento'
            Dim actualizarInvs As New SqlCommand("UPDATE Eventos SET invitaciones_totales= '" & SocialForm.txtInvTotales.Text & "' WHERE id_evento= '" & ModuloVars.codigoEvento & "'", cn)
            actualizarInvs.ExecuteNonQuery()

            'Sacamos el mensaje'
            MessageBox.Show("La invitación se ha insertado correctamente", "Inserción realizada", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("El campo número de personas debe contener un valor numérico", "Campo inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

        'Cerramos la conexión'
        cn.Close()
    End Sub

    Private Sub btnAñadirInv_MouseEnter(sender As Object, e As EventArgs) Handles btnAñadirInv.MouseEnter
        'Tooltip para el botón de añadir una nueva invitación'
        ttAñadirInv.SetToolTip(btnAñadirInv, "Añade una nueva invitación al evento")
        ttAñadirInv.ToolTipTitle = "Añade una nueva invitación"
        ttAñadirInv.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnGuardarCambios_MouseEnter(sender As Object, e As EventArgs) Handles btnGuardarCambios.MouseEnter
        'Tooltip para el botón de editar una invitación del evento existente'
        ttEditarInv.SetToolTip(btnGuardarCambios, "Edita la invitación del evento seleccionado")
        ttEditarInv.ToolTipTitle = "Edita una invitación"
        ttEditarInv.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnActSelecc_MouseEnter(sender As Object, e As EventArgs) Handles btnActSelecc.MouseEnter
        'Tooltip para el botón de eliminar una invitación'
        ttEliminarSelecc.SetToolTip(btnActSelecc, "Elimina la invitación seleccionada del evento seleccionado")
        ttEliminarSelecc.ToolTipTitle = "Elimina una nueva invitación"
        ttEliminarSelecc.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnEliminarTodos_MouseEnter(sender As Object, e As EventArgs) Handles btnEliminarTodos.MouseEnter
        'Tooltip para el botón de eliminar todas las invitaciones'
        ttEliminarTodos.SetToolTip(btnEliminarTodos, "Elimina todas las invitaciones del evento seleccionado")
        ttEliminarTodos.ToolTipTitle = "Elimina todas las invitaciones"
        ttEliminarTodos.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnAñadir_MouseEnter(sender As Object, e As EventArgs) Handles btnAñadir.MouseEnter
        'Tooltip para el botón de añadir las invitaciones'
        ttAñadir.SetToolTip(btnAñadir, "Añade una nueva invitación")
        ttAñadir.ToolTipTitle = "Añadir invitación"
        ttAñadir.ToolTipIcon = ToolTipIcon.Info
    End Sub
End Class