<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class registerForm
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(registerForm))
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.lblCorreo = New System.Windows.Forms.Label()
        Me.txtRepContraseña = New System.Windows.Forms.TextBox()
        Me.lblRepContraseña = New System.Windows.Forms.Label()
        Me.txtContraseña = New System.Windows.Forms.TextBox()
        Me.lblContraseña = New System.Windows.Forms.Label()
        Me.btnRegistro = New System.Windows.Forms.Button()
        Me.ttUser = New System.Windows.Forms.ToolTip(Me.components)
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.pbMostrarPass = New System.Windows.Forms.PictureBox()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.pbRepMostrarPass = New System.Windows.Forms.PictureBox()
        Me.pnlCabecera = New System.Windows.Forms.Panel()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnRestaurar = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.btnMinimizar = New System.Windows.Forms.Button()
        Me.btnMaximizar = New System.Windows.Forms.Button()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbMostrarPass, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbRepMostrarPass, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlCabecera.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtUsuario
        '
        Me.txtUsuario.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtUsuario.BackColor = System.Drawing.Color.Silver
        Me.txtUsuario.Location = New System.Drawing.Point(328, 89)
        Me.txtUsuario.Multiline = True
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(276, 25)
        Me.txtUsuario.TabIndex = 11
        '
        'lblUsuario
        '
        Me.lblUsuario.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuario.Location = New System.Drawing.Point(271, 43)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(81, 24)
        Me.lblUsuario.TabIndex = 10
        Me.lblUsuario.Text = "Usuario"
        '
        'txtCorreo
        '
        Me.txtCorreo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtCorreo.BackColor = System.Drawing.Color.Silver
        Me.txtCorreo.Location = New System.Drawing.Point(328, 170)
        Me.txtCorreo.Multiline = True
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(276, 25)
        Me.txtCorreo.TabIndex = 14
        '
        'lblCorreo
        '
        Me.lblCorreo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblCorreo.AutoSize = True
        Me.lblCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCorreo.Location = New System.Drawing.Point(271, 124)
        Me.lblCorreo.Name = "lblCorreo"
        Me.lblCorreo.Size = New System.Drawing.Size(184, 24)
        Me.lblCorreo.TabIndex = 13
        Me.lblCorreo.Text = "Correo electronico"
        '
        'txtRepContraseña
        '
        Me.txtRepContraseña.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtRepContraseña.BackColor = System.Drawing.Color.Silver
        Me.txtRepContraseña.Location = New System.Drawing.Point(328, 336)
        Me.txtRepContraseña.Multiline = True
        Me.txtRepContraseña.Name = "txtRepContraseña"
        Me.txtRepContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(61548)
        Me.txtRepContraseña.Size = New System.Drawing.Size(276, 25)
        Me.txtRepContraseña.TabIndex = 20
        '
        'lblRepContraseña
        '
        Me.lblRepContraseña.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblRepContraseña.AutoSize = True
        Me.lblRepContraseña.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRepContraseña.Location = New System.Drawing.Point(271, 290)
        Me.lblRepContraseña.Name = "lblRepContraseña"
        Me.lblRepContraseña.Size = New System.Drawing.Size(186, 24)
        Me.lblRepContraseña.TabIndex = 19
        Me.lblRepContraseña.Text = "Repetir contraseña"
        '
        'txtContraseña
        '
        Me.txtContraseña.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtContraseña.BackColor = System.Drawing.Color.Silver
        Me.txtContraseña.Location = New System.Drawing.Point(328, 255)
        Me.txtContraseña.Multiline = True
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(61548)
        Me.txtContraseña.Size = New System.Drawing.Size(276, 25)
        Me.txtContraseña.TabIndex = 17
        '
        'lblContraseña
        '
        Me.lblContraseña.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblContraseña.AutoSize = True
        Me.lblContraseña.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContraseña.Location = New System.Drawing.Point(271, 209)
        Me.lblContraseña.Name = "lblContraseña"
        Me.lblContraseña.Size = New System.Drawing.Size(116, 24)
        Me.lblContraseña.TabIndex = 16
        Me.lblContraseña.Text = "Contraseña"
        '
        'btnRegistro
        '
        Me.btnRegistro.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnRegistro.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btnRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRegistro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistro.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnRegistro.Location = New System.Drawing.Point(444, 380)
        Me.btnRegistro.Name = "btnRegistro"
        Me.btnRegistro.Size = New System.Drawing.Size(151, 39)
        Me.btnRegistro.TabIndex = 22
        Me.btnRegistro.Text = "REGISTRARSE"
        Me.btnRegistro.UseVisualStyleBackColor = False
        '
        'ttUser
        '
        '
        'PictureBox5
        '
        Me.PictureBox5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox5.BackgroundImage = CType(resources.GetObject("PictureBox5.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox5.Location = New System.Drawing.Point(41, 89)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(196, 201)
        Me.PictureBox5.TabIndex = 21
        Me.PictureBox5.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Location = New System.Drawing.Point(275, 317)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(46, 45)
        Me.PictureBox3.TabIndex = 18
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox4.BackgroundImage = CType(resources.GetObject("PictureBox4.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox4.Location = New System.Drawing.Point(275, 236)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(46, 45)
        Me.PictureBox4.TabIndex = 15
        Me.PictureBox4.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(275, 151)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(46, 45)
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(275, 70)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(46, 45)
        Me.PictureBox2.TabIndex = 9
        Me.PictureBox2.TabStop = False
        '
        'pbMostrarPass
        '
        Me.pbMostrarPass.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pbMostrarPass.BackgroundImage = CType(resources.GetObject("pbMostrarPass.BackgroundImage"), System.Drawing.Image)
        Me.pbMostrarPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbMostrarPass.Location = New System.Drawing.Point(606, 255)
        Me.pbMostrarPass.Name = "pbMostrarPass"
        Me.pbMostrarPass.Size = New System.Drawing.Size(35, 26)
        Me.pbMostrarPass.TabIndex = 23
        Me.pbMostrarPass.TabStop = False
        '
        'btnVolver
        '
        Me.btnVolver.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnVolver.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnVolver.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolver.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnVolver.Location = New System.Drawing.Point(287, 380)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(151, 39)
        Me.btnVolver.TabIndex = 24
        Me.btnVolver.Text = "VOLVER"
        Me.btnVolver.UseVisualStyleBackColor = False
        '
        'pbRepMostrarPass
        '
        Me.pbRepMostrarPass.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pbRepMostrarPass.BackgroundImage = CType(resources.GetObject("pbRepMostrarPass.BackgroundImage"), System.Drawing.Image)
        Me.pbRepMostrarPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbRepMostrarPass.Location = New System.Drawing.Point(606, 336)
        Me.pbRepMostrarPass.Name = "pbRepMostrarPass"
        Me.pbRepMostrarPass.Size = New System.Drawing.Size(35, 26)
        Me.pbRepMostrarPass.TabIndex = 25
        Me.pbRepMostrarPass.TabStop = False
        '
        'pnlCabecera
        '
        Me.pnlCabecera.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.pnlCabecera.Controls.Add(Me.PictureBox6)
        Me.pnlCabecera.Controls.Add(Me.Label1)
        Me.pnlCabecera.Controls.Add(Me.btnRestaurar)
        Me.pnlCabecera.Controls.Add(Me.btnCerrar)
        Me.pnlCabecera.Controls.Add(Me.btnMinimizar)
        Me.pnlCabecera.Controls.Add(Me.btnMaximizar)
        Me.pnlCabecera.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlCabecera.Location = New System.Drawing.Point(0, 0)
        Me.pnlCabecera.Name = "pnlCabecera"
        Me.pnlCabecera.Size = New System.Drawing.Size(653, 35)
        Me.pnlCabecera.TabIndex = 26
        '
        'PictureBox6
        '
        Me.PictureBox6.BackgroundImage = CType(resources.GetObject("PictureBox6.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox6.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(33, 27)
        Me.PictureBox6.TabIndex = 50
        Me.PictureBox6.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(271, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 20)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "PLANYVENT"
        '
        'btnRestaurar
        '
        Me.btnRestaurar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRestaurar.BackgroundImage = CType(resources.GetObject("btnRestaurar.BackgroundImage"), System.Drawing.Image)
        Me.btnRestaurar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRestaurar.FlatAppearance.BorderSize = 0
        Me.btnRestaurar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnRestaurar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRestaurar.Location = New System.Drawing.Point(583, 0)
        Me.btnRestaurar.Name = "btnRestaurar"
        Me.btnRestaurar.Size = New System.Drawing.Size(35, 35)
        Me.btnRestaurar.TabIndex = 48
        Me.btnRestaurar.UseVisualStyleBackColor = True
        Me.btnRestaurar.Visible = False
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.BackgroundImage = CType(resources.GetObject("btnCerrar.BackgroundImage"), System.Drawing.Image)
        Me.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Location = New System.Drawing.Point(618, 0)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(35, 35)
        Me.btnCerrar.TabIndex = 45
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'btnMinimizar
        '
        Me.btnMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimizar.BackgroundImage = CType(resources.GetObject("btnMinimizar.BackgroundImage"), System.Drawing.Image)
        Me.btnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMinimizar.FlatAppearance.BorderSize = 0
        Me.btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimizar.Location = New System.Drawing.Point(549, 0)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.Size = New System.Drawing.Size(35, 35)
        Me.btnMinimizar.TabIndex = 47
        Me.btnMinimizar.UseVisualStyleBackColor = True
        '
        'btnMaximizar
        '
        Me.btnMaximizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMaximizar.BackgroundImage = CType(resources.GetObject("btnMaximizar.BackgroundImage"), System.Drawing.Image)
        Me.btnMaximizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMaximizar.FlatAppearance.BorderSize = 0
        Me.btnMaximizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnMaximizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMaximizar.Location = New System.Drawing.Point(583, 0)
        Me.btnMaximizar.Name = "btnMaximizar"
        Me.btnMaximizar.Size = New System.Drawing.Size(35, 35)
        Me.btnMaximizar.TabIndex = 46
        Me.btnMaximizar.UseVisualStyleBackColor = True
        '
        'registerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(653, 440)
        Me.Controls.Add(Me.pnlCabecera)
        Me.Controls.Add(Me.pbRepMostrarPass)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.pbMostrarPass)
        Me.Controls.Add(Me.btnRegistro)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.txtRepContraseña)
        Me.Controls.Add(Me.lblRepContraseña)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.txtContraseña)
        Me.Controls.Add(Me.lblContraseña)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.txtCorreo)
        Me.Controls.Add(Me.lblCorreo)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.lblUsuario)
        Me.Controls.Add(Me.PictureBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "registerForm"
        Me.Text = "Aplicación"
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbMostrarPass, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbRepMostrarPass, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlCabecera.ResumeLayout(False)
        Me.pnlCabecera.PerformLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents lblUsuario As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents lblCorreo As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtRepContraseña As TextBox
    Friend WithEvents lblRepContraseña As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents txtContraseña As TextBox
    Friend WithEvents lblContraseña As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents btnRegistro As Button
    Friend WithEvents ttUser As ToolTip
    Friend WithEvents pbMostrarPass As PictureBox
    Friend WithEvents btnVolver As Button
    Friend WithEvents pbRepMostrarPass As PictureBox
    Friend WithEvents pnlCabecera As Panel
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnRestaurar As Button
    Friend WithEvents btnCerrar As Button
    Friend WithEvents btnMinimizar As Button
    Friend WithEvents btnMaximizar As Button
End Class
