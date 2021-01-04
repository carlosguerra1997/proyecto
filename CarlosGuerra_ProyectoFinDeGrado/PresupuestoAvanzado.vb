Imports System.Runtime.InteropServices
Imports System.Data.SqlClient
Public Class PresupuestoAvanzado

    'Variables para la conexión a la base de datos'
    Dim conexion As String
    Dim precioTotal As Decimal
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

    Private Sub btnAñadir_Click(sender As Object, e As EventArgs) Handles btnAñadir.Click
        'Abrimos la conexión'
        cn.Open()

        'Creamos el adaptador que compruebe si existe el nombre del actividad para dicho usuario'
        Dim buscarActividad As New SqlDataAdapter("SELECT * FROM actividadesSocial WHERE id_evento= '" & ModuloVars.codigoPresupuesto & "' AND nombre_actividad= '" & txtActividad.Text & "'", cn)
        Dim ds As New DataSet
        buscarActividad.Fill(ds, "datos")

        If ds.Tables("datos").Rows.Count > 0 Then
            MessageBox.Show("Ya existe una actividad con ese nombre", "Nombre repetido", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            If txtActividad.Text.Equals("") Or txtCoste.Text.Equals("") Then
                MessageBox.Show("Alguno de los campos a rellenar está vacio", "Campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ElseIf IsNumeric(txtCoste.Text) Then
                If ckbPagado.Checked Then
                    'Creamos el adaptador para insertar los datos en la tabla de la BBDD'
                    Dim adaptadorInsert As New SqlCommand("insert into actividadesSocial values('" & ModuloVars.codigoPresupuesto & "', '" & txtActividad.Text & "', '" & txtCoste.Text & "', 'True')", cn)
                    adaptadorInsert.ExecuteNonQuery()

                    'Añadimos los datos al Data Grid View'
                    Dim cadena = New String() {txtActividad.Text, txtCoste.Text & "€", "Si"}
                    dgvPresupuesto.Rows.Add(cadena)
                    MessageBox.Show("La actividad se agregó con éxito", "Actividad agregada", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    'Pasamos la variable del coste de un formulario a otro'
                    'Vamos sumando las cantidades de las actividades que añadimos en el data grid view'
                    If SocialForm.txtPresupuestoGastado.Text.Equals("") Then
                        precioTotal = Convert.ToDecimal(txtCoste.Text)
                        SocialForm.txtPresupuestoGastado.Text = precioTotal.ToString
                    Else
                        precioTotal = Convert.ToDecimal(SocialForm.txtPresupuestoGastado.Text) + Convert.ToDecimal(txtCoste.Text)
                        SocialForm.txtPresupuestoGastado.Text = precioTotal.ToString
                    End If
                Else
                    'Creamos el adaptador para insertar los datos en la tabla de la BBDD'
                    Dim adaptadorInsert As New SqlCommand("insert into actividadesSocial values('" & ModuloVars.codigoPresupuesto & "', '" & txtActividad.Text & "', '" & txtCoste.Text & "', 'False')", cn)
                    adaptadorInsert.ExecuteNonQuery()

                    'Añadimos los datos al Data Grid View'
                    Dim cadena = New String() {txtActividad.Text, txtCoste.Text & "€", "No"}
                    dgvPresupuesto.Rows.Add(cadena)
                    MessageBox.Show("La actividad se agregó con éxito", "Actividad agregada", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    'Pasamos la variable del coste de un formulario a otro'
                    'Vamos sumando las cantidades de las actividades que añadimos en el data grid view'
                    If SocialForm.txtPresupuestoRestante.Text.Equals("") Then
                        precioTotal = Convert.ToDecimal(txtCoste.Text)
                        SocialForm.txtPresupuestoRestante.Text = precioTotal.ToString
                    Else
                        precioTotal = Convert.ToDecimal(SocialForm.txtPresupuestoRestante.Text) + Convert.ToDecimal(txtCoste.Text)
                        SocialForm.txtPresupuestoRestante.Text = precioTotal.ToString
                    End If
                End If
            Else
                MessageBox.Show("El campo coste debe contener un valor numérico", "Campo inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
        'Cerramos la conexión'
        cn.Close()
    End Sub

    Private Sub PresupuestoAvanzado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Cargamos la conexión a la base de datos'
        conexion = "Data Source=DESKTOP-LCH6UJM\SQLEXPRESS;Initial Catalog=Proyecto_Planyvent;Integrated Security=True"
        cn.ConnectionString = conexion
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Hide()
        SocialForm.Show()
    End Sub

    Private Sub btnEliminarTodos_Click(sender As Object, e As EventArgs) Handles btnEliminarTodos.Click
        'Abrimos la conexión'
        cn.Open()

        'Borramos las actividades de la BBDD'
        'Creamos el adaptador para borrar la actividad'
        Dim borrarActividades As New SqlCommand("DELETE FROM actividadesSocial WHERE id_evento= '" & ModuloVars.codigoEvento & "'", cn)
        borrarActividades.ExecuteNonQuery()

        'Limpiamos el data grid view'
        dgvPresupuesto.Rows.Clear()

        'Limpiamos los textboxes'
        txtActividad.Text = ""
        txtCoste.Text = ""
        ckbPagado.Checked = False
        SocialForm.txtPresupuestoGastado.Text = ""
        SocialForm.txtPresupuestoRestante.Text = ""

        'Actualizamos los valores de la tabla de Eventos'
        Dim actualizarActEventos As New SqlCommand("UPDATE Eventos SET deuda_pagada= '" & 0 & "', deuda_pagar= '" & 0 & "' WHERE id_evento= '" & ModuloVars.codigoEvento & "'", cn)
        actualizarActEventos.ExecuteNonQuery()

        'Mostramos el mensaje de feedback'
        MessageBox.Show("Todas las actividades han sido borradas con éxito", "Invitaciones borradas", MessageBoxButtons.OK, MessageBoxIcon.Information)

        'Cerramos la conexión'
        cn.Close()
    End Sub

    Private Sub btnActSelecc_Click(sender As Object, e As EventArgs) Handles btnActSelecc.Click
        'Abrimos la conexión'
        cn.Open()

        Dim FilaSeleccionada As Integer = dgvPresupuesto.CurrentRow.Index

        If txtActividad.Text.Equals("") Or txtCoste.Text.Equals("") Then
            MessageBox.Show("Debe seleccionar que actividad quiere eliminar", "Error al eliminar", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf dgvPresupuesto.Rows(FilaSeleccionada).Cells(0).Value = Nothing Then
            MessageBox.Show("La fila seleccionada no es váldia", "Fila no válida", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            If dgvPresupuesto.Rows(FilaSeleccionada).Cells(2).Value = "Si" Then
                'Pasamos la variable del coste de un formulario a otro'
                'Vamos sumando las cantidades de las actividades que añadimos en el data grid view'
                If SocialForm.txtPresupuestoGastado.Text.Equals("") Then
                Else
                    precioTotal = Convert.ToDecimal(SocialForm.txtPresupuestoGastado.Text) - Convert.ToDecimal(txtCoste.Text)
                    SocialForm.txtPresupuestoGastado.Text = precioTotal.ToString
                End If
            Else
                'Pasamos la variable del coste de un formulario a otro'
                'Vamos sumando las cantidades de las actividades que añadimos en el data grid view'
                If SocialForm.txtPresupuestoRestante.Text.Equals("") Then
                Else
                    precioTotal = Convert.ToDecimal(SocialForm.txtPresupuestoRestante.Text) - Convert.ToDecimal(txtCoste.Text)
                    SocialForm.txtPresupuestoRestante.Text = precioTotal.ToString
                End If
            End If

            'Creamos el adaptador para borrar la actividad'
            Dim actualizarActividades As New SqlCommand("DELETE FROM actividadesSocial WHERE id_evento= '" & ModuloVars.codigoEvento & "' AND nombre_actividad='" & dgvPresupuesto.Rows(FilaSeleccionada).Cells(0).Value & "'", cn)
            actualizarActividades.ExecuteNonQuery()

            'Creamos el adaptador para actualizar el presupuesto en el evento'
            Dim actualizarPrecio As New SqlCommand("UPDATE Eventos SET deuda_pagada= '" & SocialForm.txtPresupuestoGastado.Text & "', deuda_pagar= '" & SocialForm.txtPresupuestoRestante.Text & "' WHERE id_evento= '" & ModuloVars.codigoEvento & "'", cn)
            actualizarPrecio.ExecuteNonQuery()

            'Borramos la fila del data grid view'
            dgvPresupuesto.Rows.Remove(dgvPresupuesto.Rows(FilaSeleccionada))

            MessageBox.Show("Actividad eliminada con éxito", "Actividad eliminada", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        'Cerramos la conexión'
        cn.Close()
    End Sub

    Private Sub btnGuardarCambios_Click(sender As Object, e As EventArgs) Handles btnGuardarCambios.Click
        'Abrimos la conexión'
        cn.Open()

        'Cogemos la fila seleccionada en el data grid view'
        Dim FilaSeleccionada As Integer = dgvPresupuesto.CurrentRow.Index

        If txtActividad.Text.Equals("") Or txtCoste.Text.Equals("") Then
            MessageBox.Show("Alguno de los campos está vacio", "Campo vacio", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf dgvPresupuesto.Rows(FilaSeleccionada).Cells(0).Value = Nothing Then
            MessageBox.Show("La fila seleccionada no es váldia", "Fila no válida", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf IsNumeric(txtCoste.Text) And txtCoste.Text > 0 Then
            If ckbPagado.Checked Then
                'Creamos el adaptador para actualizar los datos de las actividades'
                Dim actualizarActividades As New SqlCommand("UPDATE actividadesSocial SET nombre_actividad= '" & txtActividad.Text & "', precio_actividad= '" & txtCoste.Text & "', pagada= 'True' WHERE id_evento= '" & ModuloVars.codigoEvento & "' AND nombre_actividad= '" & dgvPresupuesto.Rows(FilaSeleccionada).Cells(0).Value & "'", cn)
                actualizarActividades.ExecuteNonQuery()

                'Pasamos la variable del coste de un formulario a otro'
                'Vamos sumando las cantidades de las actividades que añadimos en el data grid view'
                If SocialForm.txtPresupuestoGastado.Text.Equals("") Then
                    precioTotal = Convert.ToDecimal(txtCoste.Text)
                    SocialForm.txtPresupuestoGastado.Text = precioTotal.ToString
                Else
                    precioTotal = Convert.ToDecimal(SocialForm.txtPresupuestoGastado.Text) - Convert.ToDecimal(dgvPresupuesto.Rows(FilaSeleccionada).Cells(1).Value) + Convert.ToDecimal(txtCoste.Text)
                    SocialForm.txtPresupuestoGastado.Text = precioTotal.ToString
                End If
                'Actualizamos el DGV en tiempo real'
                dgvPresupuesto.Rows(FilaSeleccionada).Cells(0).Value = txtActividad.Text
                dgvPresupuesto.Rows(FilaSeleccionada).Cells(1).Value = txtCoste.Text
                dgvPresupuesto.Rows(FilaSeleccionada).Cells(2).Value = "Si"

                'Creamos el adaptador para actualizar el presupuesto del evento'
                Dim actualizarEvento As New SqlCommand("UPDATE Eventos SET deuda_pagada= '" & SocialForm.txtPresupuestoGastado.Text & "', deuda_pagar= '" & txtCoste.Text & "' WHERE id_evento= '" & ModuloVars.codigoEvento & "'", cn)
                actualizarEvento.ExecuteNonQuery()

                MessageBox.Show("Actividad actualizada con éxito", "Actividad actualizada", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                'Creamos el adaptador para actualizar los datos de las actividades'
                Dim actualizarActividades As New SqlCommand("UPDATE actividadesSocial SET nombre_actividad= '" & txtActividad.Text & "', precio_actividad= '" & txtCoste.Text & "', pagada= 'False' WHERE id_evento= '" & ModuloVars.codigoEvento & "' AND nombre_actividad= '" & dgvPresupuesto.Rows(FilaSeleccionada).Cells(0).Value & "'", cn)
                actualizarActividades.ExecuteNonQuery()

                'Pasamos la variable del coste de un formulario a otro'
                'Vamos sumando las cantidades de las actividades que añadimos en el data grid view'
                If SocialForm.txtPresupuestoRestante.Text.Equals("") Then
                    precioTotal = Convert.ToDecimal(txtCoste.Text)
                    SocialForm.txtPresupuestoRestante.Text = precioTotal.ToString
                Else
                    precioTotal = Convert.ToDecimal(SocialForm.txtPresupuestoRestante.Text) - Convert.ToDecimal(dgvPresupuesto.Rows(FilaSeleccionada).Cells(1).Value) + Convert.ToDecimal(txtCoste.Text)
                    SocialForm.txtPresupuestoRestante.Text = precioTotal.ToString
                End If

                'Actualizamos el DGV en tiempo real'
                dgvPresupuesto.Rows(FilaSeleccionada).Cells(0).Value = txtActividad.Text
                dgvPresupuesto.Rows(FilaSeleccionada).Cells(1).Value = txtCoste.Text
                dgvPresupuesto.Rows(FilaSeleccionada).Cells(2).Value = "No"

                'Creamos el adaptador para actualizar el presupuesto del evento'
                Dim actualizarEvento As New SqlCommand("UPDATE Eventos SET deuda_pagada= '" & SocialForm.txtPresupuestoGastado.Text & "', deuda_pagar= '" & txtCoste.Text & "' WHERE id_evento= '" & ModuloVars.codigoEvento & "'", cn)
                actualizarEvento.ExecuteNonQuery()

                MessageBox.Show("Actividad actualizada con éxito", "Actividad actualizada", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("El campo coste debe contener un valor numérico mayor que 0", "Campo inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        'Cerramos la conexión'
        cn.Close()
    End Sub

    Private Sub dgvPresupuesto_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvPresupuesto.RowHeaderMouseClick
        'Cogemos la fila seleccionada'
        Dim FilaSeleccionada As Integer = dgvPresupuesto.CurrentRow.Index

        'Cargamos los datos en los Textboxes'
        txtActividad.Text = dgvPresupuesto.Rows(FilaSeleccionada).Cells(0).Value
        txtCoste.Text = dgvPresupuesto.Rows(FilaSeleccionada).Cells(1).Value
        If dgvPresupuesto.Rows(FilaSeleccionada).Cells(2).Value = "Si" Then
            ckbPagado.Checked = True
        Else
            ckbPagado.Checked = False
        End If

        If dgvPresupuesto.Rows(FilaSeleccionada).Cells(0).Value = Nothing Then
            MessageBox.Show("La actividad que desea editar o eliminar no ha sido encontrada", "Error al editar", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            btnGuardarCambios.Enabled = True
            btnActSelecc.Enabled = True
        End If


    End Sub

    Private Sub btnAñadirNuevaAct_Click(sender As Object, e As EventArgs) Handles btnAñadirNuevaAct.Click
        'Abrimos la conexión'
        cn.Open()
        If txtActividad.Text.Equals("") Or txtCoste.Text.Equals("") Then
            MessageBox.Show("Alguno de los campos a rellenar está vacio", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf IsNumeric(txtCoste.Text) Then
            If ckbPagado.Checked Then
                'Creamos el adaptador para insertar los datos en la tabla de la BBDD'
                Dim adaptadorInsert As New SqlCommand("insert into actividadesSocial values('" & ModuloVars.codigoEvento & "', '" & txtActividad.Text & "', '" & txtCoste.Text & "', 'True')", cn)
                adaptadorInsert.ExecuteNonQuery()

                'Añadimos los datos al Data Grid View'
                Dim cadena = New String() {txtActividad.Text, txtCoste.Text & "€", "Si"}
                dgvPresupuesto.Rows.Add(cadena)

                'Pasamos la variable del coste de un formulario a otro'
                'Vamos sumando las cantidades de las actividades que añadimos en el data grid view'
                If SocialForm.txtPresupuestoGastado.Text.Equals("") Then
                    precioTotal = Convert.ToDecimal(txtCoste.Text)
                    SocialForm.txtPresupuestoGastado.Text = precioTotal.ToString
                Else
                    precioTotal = Convert.ToDecimal(SocialForm.txtPresupuestoGastado.Text) + Convert.ToDecimal(txtCoste.Text)
                    SocialForm.txtPresupuestoGastado.Text = precioTotal.ToString
                End If

                'Actualizamos el presupuesto del evento'
                Dim actualizarPresupuestos As New SqlCommand("UPDATE Eventos SET deuda_pagada= '" & SocialForm.txtPresupuestoGastado.Text & "', deuda_pagar= '" & SocialForm.txtPresupuestoRestante.Text & "' WHERE id_evento= '" & ModuloVars.codigoEvento & "'", cn)
                actualizarPresupuestos.ExecuteNonQuery()

                'Sacamos el mensaje'
                MessageBox.Show("La actividad se ha insertado correctamente", "Inserción realizada", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                'Creamos el adaptador para insertar los datos en la tabla de la BBDD'
                Dim adaptadorInsert As New SqlCommand("insert into actividadesSocial values('" & ModuloVars.codigoEvento & "', '" & txtActividad.Text & "', '" & txtCoste.Text & "', 'False')", cn)
                adaptadorInsert.ExecuteNonQuery()

                'Añadimos los datos al Data Grid View'
                Dim cadena = New String() {txtActividad.Text, txtCoste.Text & "€", "No"}
                dgvPresupuesto.Rows.Add(cadena)

                'Pasamos la variable del coste de un formulario a otro'
                'Vamos sumando las cantidades de las actividades que añadimos en el data grid view'
                If SocialForm.txtPresupuestoRestante.Text.Equals("") Then
                    precioTotal = Convert.ToDecimal(txtCoste.Text)
                    SocialForm.txtPresupuestoRestante.Text = precioTotal.ToString
                Else
                    precioTotal = Convert.ToDecimal(SocialForm.txtPresupuestoRestante.Text) + Convert.ToDecimal(txtCoste.Text)
                    SocialForm.txtPresupuestoRestante.Text = precioTotal.ToString
                End If

                'Actualizamos el presupuesto del evento'
                Dim actualizarPresupuestos As New SqlCommand("UPDATE Eventos SET deuda_pagada= '" & SocialForm.txtPresupuestoGastado.Text & "', deuda_pagar= '" & SocialForm.txtPresupuestoRestante.Text & "' WHERE id_evento= '" & ModuloVars.codigoEvento & "'", cn)
                actualizarPresupuestos.ExecuteNonQuery()

                'Sacamos el mensaje'
                MessageBox.Show("La actividad se ha insertado correctamente", "Inserción realizada", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("El campo coste debe contener un valor numérico", "Campo inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        'Cerramos la conexión'
        cn.Close()
    End Sub

    Private Sub btnAñadirNuevaAct_MouseEnter(sender As Object, e As EventArgs) Handles btnAñadirNuevaAct.MouseEnter
        'Tooltip para el botón de añadir nueva actividad al editar'
        ttAñadirAct.SetToolTip(btnAñadirNuevaAct, "Añade una nueva actividad al evento correspondiente")
        ttAñadirAct.ToolTipTitle = "Añadir actividad"
        ttAñadirAct.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnGuardarCambios_MouseEnter(sender As Object, e As EventArgs) Handles btnGuardarCambios.MouseEnter
        ttEditarAct.ShowAlways = True
        If btnGuardarCambios.Enabled = True Then
            'Tooltip para el botón de editar una actividad'
            ttEditarAct.SetToolTip(btnGuardarCambios, "Edita los cambios sobre la actividad seleccionada")
            ttEditarAct.ToolTipTitle = "Editar actividad"
            ttEditarAct.ToolTipIcon = ToolTipIcon.Info
        Else
            ttEditarAct.SetToolTip(btnGuardarCambios, "Debe seleccionar una fila para poder editar una actividad")
            ttEditarAct.ToolTipTitle = "Editar actividad"
            ttEditarAct.ToolTipIcon = ToolTipIcon.Info
        End If

    End Sub

    Private Sub btnActSelecc_MouseEnter(sender As Object, e As EventArgs) Handles btnActSelecc.MouseEnter
        'Tooltip para el botón de eliminar una actividad seleccionada'
        ttEliminarSelecc.SetToolTip(btnActSelecc, "Borra la actividad seleccionada")
        ttEliminarSelecc.ToolTipTitle = "Eliminar actividad"
        ttEliminarSelecc.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnEliminarTodos_MouseEnter(sender As Object, e As EventArgs) Handles btnEliminarTodos.MouseEnter
        'Tooltip para el botón de eliminar todas las actividades'
        ttEliminarTodas.SetToolTip(btnEliminarTodos, "Elimina todas las actividades del evento")
        ttEliminarTodas.ToolTipTitle = "Eliminar todas las actividades"
        ttEliminarTodas.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnAñadir_MouseEnter(sender As Object, e As EventArgs) Handles btnAñadir.MouseEnter
        'Tooltip para el botón de añadir las actividades'
        TtAñadir.SetToolTip(btnAñadir, "Añade una nueva actividad")
        TtAñadir.ToolTipTitle = "Añadir actividad"
        TtAñadir.ToolTipIcon = ToolTipIcon.Info
    End Sub
End Class