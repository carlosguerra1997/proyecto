Imports System.Data.SqlClient
Imports System.Runtime.InteropServices
Public Class registerForm
    Dim flagPass As Boolean = False
    Dim flagRepPass As Boolean = False

    'Variables para la conexión a la base de datos'
    Dim conexion As String
    Dim cn As New SqlConnection

    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub txtUsuario_MouseEnter(sender As Object, e As EventArgs) Handles txtUsuario.MouseEnter
        'Tooltip para el textbox de usuario'
        ttUser.SetToolTip(txtUsuario, "Ingresa el nombre de usuario")
        ttUser.ToolTipTitle = "Nombre de usuario"
        ttUser.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtCorreo_MouseEnter(sender As Object, e As EventArgs) Handles txtCorreo.MouseEnter
        'Tooltip para el textbox de correo electronico'
        ttUser.SetToolTip(txtCorreo, "Ingresa el correo electrónico")
        ttUser.ToolTipTitle = "Correo electrónico"
        ttUser.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtContraseña_MouseEnter(sender As Object, e As EventArgs) Handles txtContraseña.MouseEnter
        'Tooltip para el textbox de contraseña'
        ttUser.SetToolTip(txtContraseña, "Ingresa la contraseña")
        ttUser.ToolTipTitle = "Contraseña"
        ttUser.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtRepContraseña_MouseEnter(sender As Object, e As EventArgs) Handles txtRepContraseña.MouseEnter
        'Tooltip para el textbox de repetir contraseña'
        ttUser.SetToolTip(txtRepContraseña, "Repite la contraseña")
        ttUser.ToolTipTitle = "Repite la contraseña"
        ttUser.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub pbMostrarPass_Click(sender As Object, e As EventArgs) Handles pbMostrarPass.Click
        If flagPass = False Then
            txtContraseña.PasswordChar = ""
            flagPass = True
        Else
            txtContraseña.PasswordChar = ""
            flagPass = False
        End If
    End Sub

    Private Sub pbRepMostrarPass_Click(sender As Object, e As EventArgs) Handles pbRepMostrarPass.Click
        If flagRepPass = False Then
            txtRepContraseña.PasswordChar = ""
            flagRepPass = True
        Else
            txtRepContraseña.PasswordChar = ""
            flagRepPass = False
        End If
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Hide()
        loginForm.Show()
    End Sub

    Private Sub pnlCabecera_MouseMove(sender As Object, e As MouseEventArgs) Handles pnlCabecera.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub
    Private Sub registerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Cargamos la conexión a la base de datos'
        conexion = "Data Source=DESKTOP-LCH6UJM\SQLEXPRESS;Initial Catalog=Proyecto_Planyvent;Integrated Security=True"
        cn.ConnectionString = conexion
    End Sub

    Private Sub btnRegistro_Click(sender As Object, e As EventArgs) Handles btnRegistro.Click
        'Abrimos la conexión'
        cn.Open()

        'Hacemos las comprobaciones necesarias'
        If txtUsuario.Text.Equals("") Or txtCorreo.Text.Equals("") Or txtContraseña.Text.Equals("") Or txtRepContraseña.Text.Equals("") Then
            MessageBox.Show("Debes rellenar todos los campos", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf txtUsuario.Text.Contains(" ") Or txtCorreo.Text.Contains(" ") Or txtContraseña.Text.Contains(" ") Or txtRepContraseña.Text.Contains(" ") Then
            MessageBox.Show("Ninguno de los campos puede contener un espacio", "Registro incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf txtContraseña.Text.Equals(txtRepContraseña.Text) And txtContraseña.Text.Length > 7 And txtRepContraseña.Text.Length > 7 Then
            'Creamos el adaptador que compruebe si existe algún usuario o correo existe ya'
            Dim adaptadorBuscar As New SqlDataAdapter("SELECT * FROM Registro WHERE nom_user= '" & txtUsuario.Text & "' OR correo_user= '" & txtCorreo.Text & "'", cn)
            Dim ds As New DataSet
            adaptadorBuscar.Fill(ds, "datos")

            'Si encuentra alguna fila es que ya existe el usuario o correo'
            If ds.Tables("datos").Rows.Count > 0 Then
                If ds.Tables("datos").Rows(0).Item(2).ToString().Trim().Equals(txtCorreo.Text) Then
                    MessageBox.Show("El correo electrónico ya existe", "Correo duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    txtCorreo.Text = ""
                Else
                    MessageBox.Show("El nombre de usuario ya existe", "Usuario duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    txtUsuario.Text = ""
                End If
            Else
                'Ha pasado las comprobaciones y realiza la insercción'
                Dim adaptadorInsert As New SqlCommand("insert into Registro values('" & txtUsuario.Text & "', '" & txtCorreo.Text & "', '" & txtContraseña.Text & "', '" & txtRepContraseña.Text & "', 'True')", cn)
                adaptadorInsert.ExecuteNonQuery()
                MessageBox.Show("El registro se realizó con éxito", "Registro correcto", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtUsuario.Text = ""
                txtCorreo.Text = ""
                txtContraseña.Text = ""
                txtRepContraseña.Text = ""
            End If
        ElseIf txtContraseña.Text.Length < 7 Or txtRepContraseña.Text.Length < 7 Then
            MessageBox.Show("La contraseña es demasiado corta", "Contraseñas corta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtContraseña.Text = ""
            txtRepContraseña.Text = ""
        Else
            MessageBox.Show("Las contraseñas no coinciden", "Contraseñas diferentes", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtContraseña.Text = ""
            txtRepContraseña.Text = ""
        End If

        cn.Close()
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
End Class