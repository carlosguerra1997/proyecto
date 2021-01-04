Imports System.Runtime.InteropServices
Imports System.Data.SqlClient
Public Class Eventos

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

    Private Sub btnCerrarSesion_Click(sender As Object, e As EventArgs) Handles btnCerrarSesion.Click
        Me.Hide()
        loginForm.Show()
        loginForm.txtUsuario.Text = ""
        loginForm.txtContraseña.Text = ""
        primerLogin.txtPrimerLogin.Text = ""
    End Sub

    Private Sub btnInicio_Click(sender As Object, e As EventArgs) Handles btnInicio.Click
        Me.Close()
        menuPrincipal.Show()
    End Sub

    Private Sub btnCuenta_Click(sender As Object, e As EventArgs) Handles btnCuenta.Click
        Me.Close()
        datosPersonales.Show()
    End Sub

    Private Sub pnlCabecera_MouseMove(sender As Object, e As MouseEventArgs) Handles pnlCabecera.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub btnAñadir_Click(sender As Object, e As EventArgs) Handles btnAñadir.Click
        'Limpiamos todas las cajas de texto'
        SocialForm.txtNombre.Text = ""
        SocialForm.txtLugar.Text = ""
        SocialForm.txtPresupuestoTotal.Text = ""
        SocialForm.txtPresupuestoGastado.Text = ""
        SocialForm.txtPresupuestoRestante.Text = ""
        SocialForm.txtInvTotales.Text = ""
        SocialForm.rtbDesc.Text = ""
        SocialForm.rtbInfo.Text = ""
        PresupuestoAvanzado.dgvPresupuesto.Rows.Clear()
        InvitacionesAvanzado.dgvInvitaciones.Rows.Clear()

        Me.Hide()
        SocialForm.Show()
        SocialForm.btnGuardarCambios.Visible = False
        SocialForm.btnAñadirEvento.Visible = True
    End Sub

    Private Sub Eventos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Cargamos la conexión a la base de datos'
        conexion = "Data Source=DESKTOP-LCH6UJM\SQLEXPRESS;Initial Catalog=Proyecto_Planyvent;Integrated Security=True"
        cn.ConnectionString = conexion
    End Sub

    Private Sub btnEliminarEvento_Click(sender As Object, e As EventArgs) Handles btnEliminarEvento.Click
        ListadoEvento.cmbFiltro.Visible = False
        ListadoEvento.btnReiniciar.Visible = False
        ListadoEvento.lblFiltro.Visible = False
        ListadoEvento.btnEditarEvento.Visible = False
        ListadoEvento.btnEliminarEvento.Visible = True
        ListadoEvento.lblListadoEventos.Text = "PULSA EN EL EVENTO QUE DESEAS ELIMINAR"
        ListadoEvento.dgvListadoEventos.Rows.Clear()
        mostrarEventos()
    End Sub

    Private Sub btnEditarEvento_Click(sender As Object, e As EventArgs) Handles btnEditarEvento.Click
        ListadoEvento.cmbFiltro.Visible = False
        ListadoEvento.btnReiniciar.Visible = False
        ListadoEvento.lblFiltro.Visible = False
        ListadoEvento.btnEditarEvento.Visible = True
        ListadoEvento.btnEliminarEvento.Visible = False
        ListadoEvento.lblListadoEventos.Text = "PULSA EN EL EVENTO QUE DESEAS EDITAR"
        ListadoEvento.dgvListadoEventos.Rows.Clear()
        mostrarEventos()
    End Sub

    Private Sub btnVerEvento_Click(sender As Object, e As EventArgs) Handles btnVerEvento.Click
        ListadoEvento.cmbFiltro.Visible = True
        ListadoEvento.btnReiniciar.Visible = True
        ListadoEvento.lblFiltro.Visible = True
        ListadoEvento.btnEditarEvento.Visible = False
        ListadoEvento.btnEliminarEvento.Visible = False
        ListadoEvento.lblListadoEventos.Text = "LISTADO DE EVENTOS"
        ListadoEvento.cmbFiltro.Text = ""
        ListadoEvento.dgvListadoEventos.Rows.Clear()
        mostrarEventos()
    End Sub

    Private Sub mostrarEventos()
        'Abrimos la conexión'
        cn.Open()

        'Creamos el adaptador que busque los eventos del usuario'
        Dim adaptadorBuscar As New SqlDataAdapter("SELECT * FROM Eventos WHERE id_usuario='" & ModuloVars.codigo & "'", cn)
        Dim ds As New DataSet
        adaptadorBuscar.Fill(ds, "datos")

        If ds.Tables("datos").Rows.Count = 0 Then
            MessageBox.Show("El usuario no tiene ningún evento añadido. Para editar, primero debe añadir algún evento.", "Añade eventos primero", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim contador = 0
            For Each Row As DataRow In ds.Tables("datos").Rows
                ListadoEvento.dgvListadoEventos.Rows.Add()
                ListadoEvento.dgvListadoEventos.Rows(contador).Cells(0).Value = ds.Tables("datos").Rows(contador).Item(1).ToString()
                ListadoEvento.dgvListadoEventos.Rows(contador).Cells(1).Value = ds.Tables("datos").Rows(contador).Item(2).ToString()
                ListadoEvento.dgvListadoEventos.Rows(contador).Cells(2).Value = ds.Tables("datos").Rows(contador).Item(3).ToString()
                ListadoEvento.dgvListadoEventos.Rows(contador).Cells(3).Value = ds.Tables("datos").Rows(contador).Item(4).ToString()
                ListadoEvento.dgvListadoEventos.Rows(contador).Cells(4).Value = ds.Tables("datos").Rows(contador).Item(5).ToString()
                ListadoEvento.dgvListadoEventos.Rows(contador).Cells(5).Value = ds.Tables("datos").Rows(contador).Item(7).ToString()
                ListadoEvento.dgvListadoEventos.Rows(contador).Cells(6).Value = ds.Tables("datos").Rows(contador).Item(8).ToString()
                ListadoEvento.dgvListadoEventos.Rows(contador).Cells(7).Value = ds.Tables("datos").Rows(contador).Item(9).ToString()
                ListadoEvento.dgvListadoEventos.Rows(contador).Cells(8).Value = ds.Tables("datos").Rows(contador).Item(10).ToString()
                contador = contador + 1
            Next
            Me.Hide()
            ListadoEvento.Show()
        End If
        'Cerramos la conexión'
        cn.Close()
    End Sub
End Class