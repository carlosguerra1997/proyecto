Imports System.Runtime.InteropServices
Imports System.Data.SqlClient
Public Class datosPersonales

    Dim flagPassActual As Boolean = False
    Dim flagNuevaPass As Boolean = False
    Dim flagRepPass As Boolean = False
    Dim conexion As String
    Dim cn As New SqlConnection

    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
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

    Private Sub btnVolverDatos_Click(sender As Object, e As EventArgs) Handles btnVolverDatos.Click
        Me.Hide()
        menuPrincipal.Show()
    End Sub

    Private Sub btnVolverPass_Click(sender As Object, e As EventArgs) Handles btnVolverPass.Click
        Me.Hide()
        menuPrincipal.Show()
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        End
    End Sub
    Private Sub pnlCabecera_MouseMove(sender As Object, e As MouseEventArgs) Handles pnlCabecera.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub btnCerrarSesion_Click(sender As Object, e As EventArgs) Handles btnCerrarSesion.Click
        Me.Hide()
        loginForm.Show()
        loginForm.txtUsuario.Text = ""
        loginForm.txtContraseña.Text = ""
        primerLogin.txtPrimerLogin.Text = ""
    End Sub

    Private Sub pbPassActual_Click(sender As Object, e As EventArgs) Handles pbPassActual.Click
        If flagPassActual = False Then
            txtPassActual.PasswordChar = ""
            flagPassActual = True
        Else
            txtPassActual.PasswordChar = ""
            flagPassActual = False
        End If
    End Sub

    Private Sub pbNuevaPass_Click(sender As Object, e As EventArgs) Handles pbNuevaPass.Click
        If flagNuevaPass = False Then
            txtNewPass.PasswordChar = ""
            flagNuevaPass = True
        Else
            txtNewPass.PasswordChar = ""
            flagNuevaPass = False
        End If
    End Sub

    Private Sub pbRepNuevaPass_Click(sender As Object, e As EventArgs) Handles pbRepNuevaPass.Click
        If flagRepPass = False Then
            txtRepNewPass.PasswordChar = ""
            flagRepPass = True
        Else
            txtRepNewPass.PasswordChar = ""
            flagRepPass = False
        End If
    End Sub

    Private Sub btnInicio_Click(sender As Object, e As EventArgs) Handles btnInicio.Click
        Me.Hide()
        menuPrincipal.Show()
    End Sub

    Private Sub txtVacios(sender As Object, e As EventArgs) Handles txtUsuario.TextChanged,
            txtTfno1.TextChanged, txtTfno2.TextChanged
        If txtUsuario.Text.Trim().Equals("") And txtTfno1.Text.Trim().Equals("") And txtTfno2.Text.Trim().Equals("") Then
            btnGuardarDatos.Enabled = False
        Else
            btnGuardarDatos.Enabled = True
        End If

    End Sub

    Private Sub btnGuardarPass_Click(sender As Object, e As EventArgs) Handles btnGuardarPass.Click
        'Abrimos la conexión'
        cn.Open()

        If txtPassActual.Text.Equals("") Or txtNewPass.Text.Equals("") Or txtRepNewPass.Text.Equals("") Then
            MessageBox.Show("Debe rellenar todos los campos para guardar", "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            'Buscamos la contraseña del usuario'
            Dim buscarRegistro As New SqlDataAdapter("SELECT * FROM Registro WHERE codigo_registro= '" & ModuloVars.codigo & "'", cn)
            Dim dsBuscarRegistro As New DataSet
            buscarRegistro.Fill(dsBuscarRegistro, "buscarRegistro")

            If txtNewPass.Text.Length < 8 Or txtRepNewPass.Text.Length < 8 Then
                MessageBox.Show("La nueva contraseña debe tener más de 8 caracteres", "Error al cambiar la contraseña", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtNewPass.Text = ""
                txtPassActual.Text = ""
                txtRepNewPass.Text = ""
            Else
                If txtNewPass.Text.Equals(txtRepNewPass.Text) Then
                    If dsBuscarRegistro.Tables("buscarRegistro").Rows(0).Item(3).ToString.Trim().Equals(txtPassActual.Text) Then
                        'Actualizamos los datos que quiera el usuario'
                        Dim actualizarContraseña As New SqlCommand("UPDATE Registro SET pass_user= '" & txtNewPass.Text & "', repPass_user= '" & txtRepNewPass.Text & "' WHERE codigo_registro= '" & ModuloVars.codigo & "'", cn)
                        actualizarContraseña.ExecuteNonQuery()
                        MessageBox.Show("La contraseña ha sido cambiada con éxito", "Éxito al guardar", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        'Mensaje de error'
                        MessageBox.Show("Ha introducido mal la contraseña actual", "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        txtNewPass.Text = ""
                        txtPassActual.Text = ""
                        txtRepNewPass.Text = ""
                    End If
                Else
                    MessageBox.Show("Las contraseñas no coinciden", "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    txtNewPass.Text = ""
                    txtPassActual.Text = ""
                    txtRepNewPass.Text = ""
                End If
            End If
        End If

        'Cerramos la conexión'
        cn.Close()
    End Sub

    Private Sub btnGuardarDatos_Click(sender As Object, e As EventArgs) Handles btnGuardarDatos.Click
        'Abrimos la conexión'
        cn.Open()

        If txtUsuario.Text.Equals("") And txtTfno1.Text.Equals("") And txtTfno2.Text.Equals("") Then
            MessageBox.Show("Debe al menos rellenar un campo para poder guardar cambios", "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf txtUsuario.Text.Contains(" ") Then
            MessageBox.Show("El nombre de perfil no puede contener espacios", "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf txtTfno1.Text.Length > 9 Or txtTfno2.Text.Length > 9 Or txtTfno1.Text.Length < 9 Or txtTfno2.Text.Length < 9 Then
            'Actualizamos los datos que quiera el usuario'
            Dim comprobarNombre As New SqlDataAdapter("SELECT * FROM Cuenta WHERE codigo_cuenta= '" & ModuloVars.codigo & "'", cn)
            Dim dsComprobarNombre As New DataSet
            comprobarNombre.Fill(dsComprobarNombre, "comprobarNombre")
            If txtTfno1.Text.Length > 9 Or txtTfno1.Text.Length < 9 Then
                txtTfno1.Text = dsComprobarNombre.Tables("comprobarNombre").Rows(0).Item(2).ToString
            End If
            If txtTfno2.Text.Length > 9 Or txtTfno2.Text.Length < 9 Then
                txtTfno2.Text = dsComprobarNombre.Tables("comprobarNombre").Rows(0).Item(3).ToString
            End If
            MessageBox.Show("El teléfono debe contener 9 caracteres", "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf IsNumeric(txtTfno1.Text) Or IsNumeric(txtTfno2.Text) Then
            'Actualizamos los datos que quiera el usuario'
            Dim buscarNombre As New SqlDataAdapter("SELECT * FROM Cuenta WHERE nombre_perfil= '" & txtUsuario.Text & "'", cn)
            Dim dsBuscarNombre As New DataSet
            buscarNombre.Fill(dsBuscarNombre, "buscarNombre")

            'Actualizamos los datos que quiera el usuario'
            Dim comprobarNombre As New SqlDataAdapter("SELECT * FROM Cuenta WHERE codigo_cuenta= '" & ModuloVars.codigo & "'", cn)
            Dim dsComprobarNombre As New DataSet
            comprobarNombre.Fill(dsComprobarNombre, "comprobarNombre")

            If dsBuscarNombre.Tables("buscarNombre").Rows().Count > 0 Then
                If dsComprobarNombre.Tables("comprobarNombre").Rows(0).Item(1).ToString.Trim().Equals(txtUsuario.Text.Trim()) Then
                    'Actualizamos los datos que quiera el usuario'
                    Dim actualizarDatos As New SqlCommand("UPDATE Cuenta SET nombre_perfil= '" & txtUsuario.Text.Trim() & "', telefono_uno= '" & txtTfno1.Text.Trim() & "', telefono_dos= '" & txtTfno2.Text.Trim() & "' WHERE codigo_cuenta= '" & ModuloVars.codigo & "'", cn)
                    actualizarDatos.ExecuteNonQuery()

                    'Actualizamos la label de bienvenida del usuario'
                    menuPrincipal.lblBienvenidaUser.Text = "Hola, " & txtUsuario.Text
                    'Mandamos el mensaje pertinente'
                    MessageBox.Show("Los datos se han actualizado con éxito", "Éxito al guardar", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("El nombre de perfil ya existe", "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                End If
            Else
                'Actualizamos los datos que quiera el usuario'
                Dim actualizarDatos As New SqlCommand("UPDATE Cuenta SET nombre_perfil= '" & txtUsuario.Text.Trim() & "', telefono_uno= '" & txtTfno1.Text.Trim() & "', telefono_dos= '" & txtTfno2.Text.Trim() & "' WHERE codigo_cuenta= '" & ModuloVars.codigo & "'", cn)
                actualizarDatos.ExecuteNonQuery()

                'Actualizamos la label de bienvenida del usuario'
                menuPrincipal.lblBienvenidaUser.Text = "Hola, " & txtUsuario.Text
                'Mandamos el mensaje pertinente'
                MessageBox.Show("Los datos se han actualizado con éxito", "Éxito al guardar", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("El teléfono debe contener valores numéricos", "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        'Cerramos la conexión'
        cn.Close()
    End Sub

    Private Sub datosPersonales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Cargamos la conexión a la base de datos'
        conexion = "Data Source=DESKTOP-LCH6UJM\SQLEXPRESS;Initial Catalog=Proyecto_Planyvent;Integrated Security=True"
        cn.ConnectionString = conexion

        'Cogemos de la tabla Cuenta los datos correspondientes al usuario'
        Dim buscarDatos As New SqlDataAdapter("SELECT * FROM Cuenta WHERE codigo_cuenta= '" & ModuloVars.codigo & "'", cn)
        Dim dsBuscarDatos As New DataSet
        buscarDatos.Fill(dsBuscarDatos, "buscarDatos")

        'Ponemos los datos recogidos en los textboxes'
        txtUsuario.Text = dsBuscarDatos.Tables("buscarDatos").Rows(0).Item(1).ToString().Trim()
        txtTfno1.Text = dsBuscarDatos.Tables("buscarDatos").Rows(0).Item(2).ToString().Trim()
        txtTfno2.Text = dsBuscarDatos.Tables("buscarDatos").Rows(0).Item(3).ToString().Trim()

    End Sub
End Class