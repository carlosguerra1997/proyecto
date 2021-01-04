Imports System.Data.SqlClient
Imports System.Runtime.InteropServices
Public Class primerLogin

    'Variables para la conexión a la base de datos'
    Dim conexion As String
    Dim cn As New SqlConnection

    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub pnlCabecera_MouseMove(sender As Object, e As MouseEventArgs) Handles pnlCabecera.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        cn.Open()

        'Creamos el adaptador que compruebe si existe algún usuario o correo existe ya'
        Dim adaptadorBuscar As New SqlDataAdapter("SELECT * FROM Cuenta WHERE nombre_perfil= '" & txtPrimerLogin.Text & "'", cn)
        Dim ds As New DataSet
        adaptadorBuscar.Fill(ds, "datos")

        'Miramos si nos devuelve registros o no la búsqueda para comprobar si existe el nombre de perfil o no'
        If ds.Tables("datos").Rows.Count > 0 Then
            MessageBox.Show("El nombre de perfil ya existe", "Nombre existente", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf txtPrimerLogin.Text.Contains(" ") Then
            MessageBox.Show("El nombre de perfil no puede contener espacios", "Nombre incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            'Ejecutamos la consulta e insertamos los datos en la tabla'
            Dim adaptadorInsert As New SqlCommand("insert into Cuenta values('" & ModuloVars.codigo & "', '" & txtPrimerLogin.Text & "', '" & "000000000" & "', '" & "000000000" & "')", cn)
            adaptadorInsert.ExecuteNonQuery()
            Me.Hide()
            Bienvenida.Show()
        End If
        cn.Close()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtPrimerLogin.TextChanged
        If txtPrimerLogin.Text.Trim().Equals("") Then
            btnSiguiente.Enabled = False
        Else
            btnSiguiente.Enabled = True
        End If
    End Sub

    Private Sub primerLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Cargamos la conexión a la base de datos'
        conexion = "Data Source=DESKTOP-LCH6UJM\SQLEXPRESS;Initial Catalog=Proyecto_Planyvent;Integrated Security=True"
        cn.ConnectionString = conexion
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        End
    End Sub

    Private Sub btnRestaurar_Click(sender As Object, e As EventArgs) Handles btnRestaurar.Click
        btnRestaurar.Visible = False
        btnMaximizar.Visible = True
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub btnMaximizar_Click(sender As Object, e As EventArgs) Handles btnMaximizar.Click
        btnMaximizar.Visible = False
        btnRestaurar.Visible = True
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class