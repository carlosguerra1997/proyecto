Imports System.Data.SqlClient
Imports System.Runtime.InteropServices
Public Class loginForm
    Dim flagPass As Boolean = False

    'Variables para la conexión a la base de datos'
    Dim conexion As String
    Dim cn As New SqlConnection

    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Sub txtUsuario_MouseEnter(sender As Object, e As EventArgs) Handles txtUsuario.MouseEnter
        'Tooltip para el textbox de usuario'
        ttUser.SetToolTip(txtUsuario, "Ingresa el nombre de usuario")
        ttUser.ToolTipTitle = "Nombre de usuario"
        ttUser.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Sub txtContraseña_MouseEnter(sender As Object, e As EventArgs) Handles txtContraseña.MouseEnter
        'Tooltip para el textbox de contraseña'
        ttPassword.SetToolTip(txtContraseña, "Ingresa la contraseña")
        ttPassword.ToolTipTitle = "Contraseña"
        ttPassword.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        Me.Hide()
        registerForm.Show()
    End Sub

    Private Sub pnlCabecera_MouseMove(sender As Object, e As MouseEventArgs) Handles pnlCabecera.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        cn.Open()

        'Creamos el adaptador que compruebe si existe algún usuario o correo existe ya'
        Dim adaptadorBuscar As New SqlDataAdapter("SELECT * FROM Registro WHERE nom_user= '" & txtUsuario.Text & "' AND pass_user= '" & txtContraseña.Text & "'", cn)
        Dim ds As New DataSet
        adaptadorBuscar.Fill(ds, "datos")

        'Si encuentra alguna fila es que ya existe el usuario o correo'
        If ds.Tables("datos").Rows.Count > 0 Then
            If ds.Tables("datos").Rows(0).Item(5).ToString().Trim().Equals("True") Then
                'Creamos el adaptador para actualizar el dato de primerLogin'
                Dim adaptadorUpdate As New SqlCommand("UPDATE Registro SET primerLogin= 'False'", cn)
                adaptadorUpdate.ExecuteNonQuery()

                'Pasamos a la variable código de nuestro módulo el código del usuario logueado'
                ModuloVars.codigo = ds.Tables("datos").Rows(0).Item(0).ToString().Trim()

                Me.Hide()
                primerLogin.Show()
            Else
                Me.Hide()
                ModuloVars.codigo = ds.Tables("datos").Rows(0).Item(0).ToString().Trim()
                menuPrincipal.Show()
            End If
        Else
            MessageBox.Show("Los datos son incorrectos", "LOGIN incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtUsuario.Text = ""
            txtContraseña.Text = ""
        End If

        cn.Close()
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

    Private Sub cambiarTexto(sender As Object, e As EventArgs) Handles txtUsuario.TextChanged, txtContraseña.TextChanged
        If txtUsuario.Text.Trim().Equals("") Or txtContraseña.Text.Trim().Equals("") Then
            btnIngresar.Enabled = False
        Else
            btnIngresar.Enabled = True
        End If
    End Sub

    Private Sub loginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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