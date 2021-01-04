<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SocialForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SocialForm))
        Me.pnlCabecera = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblPlanyvent = New System.Windows.Forms.Label()
        Me.btnRestaurar = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.btnMinimizar = New System.Windows.Forms.Button()
        Me.btnMaximizar = New System.Windows.Forms.Button()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblDesc = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rtbDesc = New System.Windows.Forms.RichTextBox()
        Me.gbInfoBasica = New System.Windows.Forms.GroupBox()
        Me.rtbInfo = New System.Windows.Forms.RichTextBox()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.lblLugar = New System.Windows.Forms.Label()
        Me.txtLugar = New System.Windows.Forms.TextBox()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnInvitacionesAvanzadas = New System.Windows.Forms.Button()
        Me.txtInvTotales = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnPresupuestoAvanzadas = New System.Windows.Forms.Button()
        Me.txtPresupuestoRestante = New System.Windows.Forms.TextBox()
        Me.lblPresupuestoRestante = New System.Windows.Forms.Label()
        Me.txtPresupuestoGastado = New System.Windows.Forms.TextBox()
        Me.lblPresupuestoGastado = New System.Windows.Forms.Label()
        Me.txtPresupuestoTotal = New System.Windows.Forms.TextBox()
        Me.lblPresupuesto = New System.Windows.Forms.Label()
        Me.ttPTotal = New System.Windows.Forms.ToolTip(Me.components)
        Me.ttPGastado = New System.Windows.Forms.ToolTip(Me.components)
        Me.ttPRestante = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnAñadirEvento = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.btnGuardarCambios = New System.Windows.Forms.Button()
        Me.pnlMenu = New System.Windows.Forms.Panel()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox13 = New System.Windows.Forms.PictureBox()
        Me.btnCerrarSesion = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnMenu = New System.Windows.Forms.Button()
        Me.btnCuenta = New System.Windows.Forms.Button()
        Me.pnlCabecera.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbInfoBasica.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.pnlMenu.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlCabecera
        '
        Me.pnlCabecera.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.pnlCabecera.Controls.Add(Me.PictureBox1)
        Me.pnlCabecera.Controls.Add(Me.lblPlanyvent)
        Me.pnlCabecera.Controls.Add(Me.btnRestaurar)
        Me.pnlCabecera.Controls.Add(Me.btnCerrar)
        Me.pnlCabecera.Controls.Add(Me.btnMinimizar)
        Me.pnlCabecera.Controls.Add(Me.btnMaximizar)
        Me.pnlCabecera.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlCabecera.Location = New System.Drawing.Point(0, 0)
        Me.pnlCabecera.Name = "pnlCabecera"
        Me.pnlCabecera.Size = New System.Drawing.Size(1162, 35)
        Me.pnlCabecera.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(33, 27)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'lblPlanyvent
        '
        Me.lblPlanyvent.AutoSize = True
        Me.lblPlanyvent.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlanyvent.Location = New System.Drawing.Point(540, 6)
        Me.lblPlanyvent.Name = "lblPlanyvent"
        Me.lblPlanyvent.Size = New System.Drawing.Size(112, 20)
        Me.lblPlanyvent.TabIndex = 49
        Me.lblPlanyvent.Text = "PLANYVENT"
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
        Me.btnRestaurar.Location = New System.Drawing.Point(1092, 0)
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
        Me.btnCerrar.Location = New System.Drawing.Point(1127, 0)
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
        Me.btnMinimizar.Location = New System.Drawing.Point(1058, 0)
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
        Me.btnMaximizar.Location = New System.Drawing.Point(1092, 0)
        Me.btnMaximizar.Name = "btnMaximizar"
        Me.btnMaximizar.Size = New System.Drawing.Size(35, 35)
        Me.btnMaximizar.TabIndex = 46
        Me.btnMaximizar.UseVisualStyleBackColor = True
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblNombre.Location = New System.Drawing.Point(46, 30)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(97, 13)
        Me.lblNombre.TabIndex = 5
        Me.lblNombre.Text = "Nombre del evento"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(171, 30)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(200, 20)
        Me.txtNombre.TabIndex = 6
        '
        'lblDesc
        '
        Me.lblDesc.AutoSize = True
        Me.lblDesc.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblDesc.Location = New System.Drawing.Point(46, 62)
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.Size = New System.Drawing.Size(116, 13)
        Me.lblDesc.TabIndex = 7
        Me.lblDesc.Text = "Descripcion del evento"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(46, 142)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Fecha del evento"
        '
        'rtbDesc
        '
        Me.rtbDesc.Location = New System.Drawing.Point(171, 63)
        Me.rtbDesc.Name = "rtbDesc"
        Me.rtbDesc.Size = New System.Drawing.Size(200, 68)
        Me.rtbDesc.TabIndex = 10
        Me.rtbDesc.Text = ""
        '
        'gbInfoBasica
        '
        Me.gbInfoBasica.Controls.Add(Me.rtbInfo)
        Me.gbInfoBasica.Controls.Add(Me.lblInfo)
        Me.gbInfoBasica.Controls.Add(Me.lblLugar)
        Me.gbInfoBasica.Controls.Add(Me.txtLugar)
        Me.gbInfoBasica.Controls.Add(Me.dtpFecha)
        Me.gbInfoBasica.Controls.Add(Me.lblNombre)
        Me.gbInfoBasica.Controls.Add(Me.rtbDesc)
        Me.gbInfoBasica.Controls.Add(Me.Label1)
        Me.gbInfoBasica.Controls.Add(Me.txtNombre)
        Me.gbInfoBasica.Controls.Add(Me.lblDesc)
        Me.gbInfoBasica.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.gbInfoBasica.Location = New System.Drawing.Point(219, 55)
        Me.gbInfoBasica.Name = "gbInfoBasica"
        Me.gbInfoBasica.Size = New System.Drawing.Size(433, 350)
        Me.gbInfoBasica.TabIndex = 11
        Me.gbInfoBasica.TabStop = False
        Me.gbInfoBasica.Text = "Información básica"
        '
        'rtbInfo
        '
        Me.rtbInfo.Location = New System.Drawing.Point(171, 200)
        Me.rtbInfo.Name = "rtbInfo"
        Me.rtbInfo.Size = New System.Drawing.Size(200, 121)
        Me.rtbInfo.TabIndex = 15
        Me.rtbInfo.Text = ""
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblInfo.Location = New System.Drawing.Point(46, 199)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(107, 13)
        Me.lblInfo.TabIndex = 14
        Me.lblInfo.Text = "Información adicional"
        '
        'lblLugar
        '
        Me.lblLugar.AutoSize = True
        Me.lblLugar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblLugar.Location = New System.Drawing.Point(46, 168)
        Me.lblLugar.Name = "lblLugar"
        Me.lblLugar.Size = New System.Drawing.Size(87, 13)
        Me.lblLugar.TabIndex = 12
        Me.lblLugar.Text = "Lugar del evento"
        '
        'txtLugar
        '
        Me.txtLugar.Location = New System.Drawing.Point(171, 165)
        Me.txtLugar.Name = "txtLugar"
        Me.txtLugar.Size = New System.Drawing.Size(200, 20)
        Me.txtLugar.TabIndex = 13
        '
        'dtpFecha
        '
        Me.dtpFecha.Location = New System.Drawing.Point(171, 137)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(200, 20)
        Me.dtpFecha.TabIndex = 11
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnInvitacionesAvanzadas)
        Me.GroupBox1.Controls.Add(Me.txtInvTotales)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.btnPresupuestoAvanzadas)
        Me.GroupBox1.Controls.Add(Me.txtPresupuestoRestante)
        Me.GroupBox1.Controls.Add(Me.lblPresupuestoRestante)
        Me.GroupBox1.Controls.Add(Me.txtPresupuestoGastado)
        Me.GroupBox1.Controls.Add(Me.lblPresupuestoGastado)
        Me.GroupBox1.Controls.Add(Me.txtPresupuestoTotal)
        Me.GroupBox1.Controls.Add(Me.lblPresupuesto)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox1.Location = New System.Drawing.Point(692, 55)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(433, 212)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Información avanzada"
        '
        'btnInvitacionesAvanzadas
        '
        Me.btnInvitacionesAvanzadas.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btnInvitacionesAvanzadas.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnInvitacionesAvanzadas.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnInvitacionesAvanzadas.Location = New System.Drawing.Point(208, 168)
        Me.btnInvitacionesAvanzadas.Name = "btnInvitacionesAvanzadas"
        Me.btnInvitacionesAvanzadas.Size = New System.Drawing.Size(116, 24)
        Me.btnInvitacionesAvanzadas.TabIndex = 19
        Me.btnInvitacionesAvanzadas.Text = "Opciones avanzadas"
        Me.btnInvitacionesAvanzadas.UseVisualStyleBackColor = False
        '
        'txtInvTotales
        '
        Me.txtInvTotales.Enabled = False
        Me.txtInvTotales.Location = New System.Drawing.Point(177, 142)
        Me.txtInvTotales.Name = "txtInvTotales"
        Me.txtInvTotales.ReadOnly = True
        Me.txtInvTotales.Size = New System.Drawing.Size(192, 20)
        Me.txtInvTotales.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(55, 145)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Invitaciones totales"
        '
        'btnPresupuestoAvanzadas
        '
        Me.btnPresupuestoAvanzadas.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btnPresupuestoAvanzadas.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPresupuestoAvanzadas.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnPresupuestoAvanzadas.Location = New System.Drawing.Point(208, 106)
        Me.btnPresupuestoAvanzadas.Name = "btnPresupuestoAvanzadas"
        Me.btnPresupuestoAvanzadas.Size = New System.Drawing.Size(116, 24)
        Me.btnPresupuestoAvanzadas.TabIndex = 12
        Me.btnPresupuestoAvanzadas.Text = "Opciones avanzadas"
        Me.btnPresupuestoAvanzadas.UseVisualStyleBackColor = False
        '
        'txtPresupuestoRestante
        '
        Me.txtPresupuestoRestante.Enabled = False
        Me.txtPresupuestoRestante.Location = New System.Drawing.Point(177, 79)
        Me.txtPresupuestoRestante.Name = "txtPresupuestoRestante"
        Me.txtPresupuestoRestante.ReadOnly = True
        Me.txtPresupuestoRestante.Size = New System.Drawing.Size(192, 20)
        Me.txtPresupuestoRestante.TabIndex = 11
        '
        'lblPresupuestoRestante
        '
        Me.lblPresupuestoRestante.AutoSize = True
        Me.lblPresupuestoRestante.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblPresupuestoRestante.Location = New System.Drawing.Point(55, 82)
        Me.lblPresupuestoRestante.Name = "lblPresupuestoRestante"
        Me.lblPresupuestoRestante.Size = New System.Drawing.Size(78, 13)
        Me.lblPresupuestoRestante.TabIndex = 10
        Me.lblPresupuestoRestante.Text = "Deuda a pagar"
        '
        'txtPresupuestoGastado
        '
        Me.txtPresupuestoGastado.Enabled = False
        Me.txtPresupuestoGastado.Location = New System.Drawing.Point(177, 53)
        Me.txtPresupuestoGastado.Name = "txtPresupuestoGastado"
        Me.txtPresupuestoGastado.ReadOnly = True
        Me.txtPresupuestoGastado.Size = New System.Drawing.Size(192, 20)
        Me.txtPresupuestoGastado.TabIndex = 9
        '
        'lblPresupuestoGastado
        '
        Me.lblPresupuestoGastado.AutoSize = True
        Me.lblPresupuestoGastado.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblPresupuestoGastado.Location = New System.Drawing.Point(55, 56)
        Me.lblPresupuestoGastado.Name = "lblPresupuestoGastado"
        Me.lblPresupuestoGastado.Size = New System.Drawing.Size(78, 13)
        Me.lblPresupuestoGastado.TabIndex = 8
        Me.lblPresupuestoGastado.Text = "Deuda pagada"
        '
        'txtPresupuestoTotal
        '
        Me.txtPresupuestoTotal.Location = New System.Drawing.Point(177, 27)
        Me.txtPresupuestoTotal.Name = "txtPresupuestoTotal"
        Me.txtPresupuestoTotal.Size = New System.Drawing.Size(192, 20)
        Me.txtPresupuestoTotal.TabIndex = 7
        '
        'lblPresupuesto
        '
        Me.lblPresupuesto.AutoSize = True
        Me.lblPresupuesto.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblPresupuesto.Location = New System.Drawing.Point(55, 30)
        Me.lblPresupuesto.Name = "lblPresupuesto"
        Me.lblPresupuesto.Size = New System.Drawing.Size(89, 13)
        Me.lblPresupuesto.TabIndex = 0
        Me.lblPresupuesto.Text = "Presupuesto total"
        '
        'btnAñadirEvento
        '
        Me.btnAñadirEvento.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btnAñadirEvento.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAñadirEvento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAñadirEvento.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnAñadirEvento.Location = New System.Drawing.Point(750, 288)
        Me.btnAñadirEvento.Name = "btnAñadirEvento"
        Me.btnAñadirEvento.Size = New System.Drawing.Size(165, 50)
        Me.btnAñadirEvento.TabIndex = 13
        Me.btnAñadirEvento.Text = "AÑADIR EVENTO"
        Me.btnAñadirEvento.UseVisualStyleBackColor = False
        '
        'btnVolver
        '
        Me.btnVolver.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnVolver.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolver.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnVolver.Location = New System.Drawing.Point(921, 288)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(165, 50)
        Me.btnVolver.TabIndex = 15
        Me.btnVolver.Text = "VOLVER"
        Me.btnVolver.UseVisualStyleBackColor = False
        '
        'btnGuardarCambios
        '
        Me.btnGuardarCambios.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btnGuardarCambios.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnGuardarCambios.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardarCambios.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnGuardarCambios.Location = New System.Drawing.Point(750, 288)
        Me.btnGuardarCambios.Name = "btnGuardarCambios"
        Me.btnGuardarCambios.Size = New System.Drawing.Size(165, 50)
        Me.btnGuardarCambios.TabIndex = 16
        Me.btnGuardarCambios.Text = "GUARDAR CAMBIOS"
        Me.btnGuardarCambios.UseVisualStyleBackColor = False
        '
        'pnlMenu
        '
        Me.pnlMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.pnlMenu.Controls.Add(Me.PictureBox4)
        Me.pnlMenu.Controls.Add(Me.PictureBox13)
        Me.pnlMenu.Controls.Add(Me.btnCerrarSesion)
        Me.pnlMenu.Controls.Add(Me.PictureBox3)
        Me.pnlMenu.Controls.Add(Me.PictureBox2)
        Me.pnlMenu.Controls.Add(Me.btnMenu)
        Me.pnlMenu.Controls.Add(Me.btnCuenta)
        Me.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlMenu.Location = New System.Drawing.Point(0, 35)
        Me.pnlMenu.Name = "pnlMenu"
        Me.pnlMenu.Size = New System.Drawing.Size(187, 393)
        Me.pnlMenu.TabIndex = 17
        '
        'PictureBox4
        '
        Me.PictureBox4.BackgroundImage = CType(resources.GetObject("PictureBox4.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox4.Location = New System.Drawing.Point(12, 16)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(144, 107)
        Me.PictureBox4.TabIndex = 3
        Me.PictureBox4.TabStop = False
        '
        'PictureBox13
        '
        Me.PictureBox13.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox13.BackgroundImage = CType(resources.GetObject("PictureBox13.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox13.Location = New System.Drawing.Point(0, 212)
        Me.PictureBox13.Name = "PictureBox13"
        Me.PictureBox13.Size = New System.Drawing.Size(55, 35)
        Me.PictureBox13.TabIndex = 14
        Me.PictureBox13.TabStop = False
        '
        'btnCerrarSesion
        '
        Me.btnCerrarSesion.FlatAppearance.BorderSize = 0
        Me.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrarSesion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrarSesion.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnCerrarSesion.Location = New System.Drawing.Point(55, 212)
        Me.btnCerrarSesion.Name = "btnCerrarSesion"
        Me.btnCerrarSesion.Size = New System.Drawing.Size(120, 35)
        Me.btnCerrarSesion.TabIndex = 15
        Me.btnCerrarSesion.Text = "CERRAR SESIÓN"
        Me.btnCerrarSesion.UseVisualStyleBackColor = True
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Location = New System.Drawing.Point(3, 129)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(52, 35)
        Me.PictureBox3.TabIndex = 4
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(0, 170)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(55, 35)
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'btnMenu
        '
        Me.btnMenu.FlatAppearance.BorderSize = 0
        Me.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMenu.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnMenu.Location = New System.Drawing.Point(55, 129)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(120, 35)
        Me.btnMenu.TabIndex = 5
        Me.btnMenu.Text = "MENU"
        Me.btnMenu.UseVisualStyleBackColor = True
        '
        'btnCuenta
        '
        Me.btnCuenta.FlatAppearance.BorderSize = 0
        Me.btnCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCuenta.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnCuenta.Location = New System.Drawing.Point(55, 170)
        Me.btnCuenta.Name = "btnCuenta"
        Me.btnCuenta.Size = New System.Drawing.Size(120, 35)
        Me.btnCuenta.TabIndex = 3
        Me.btnCuenta.Text = "CUENTA"
        Me.btnCuenta.UseVisualStyleBackColor = True
        '
        'SocialForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1162, 428)
        Me.Controls.Add(Me.pnlMenu)
        Me.Controls.Add(Me.btnGuardarCambios)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnAñadirEvento)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbInfoBasica)
        Me.Controls.Add(Me.pnlCabecera)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SocialForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SocialForm"
        Me.pnlCabecera.ResumeLayout(False)
        Me.pnlCabecera.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbInfoBasica.ResumeLayout(False)
        Me.gbInfoBasica.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.pnlMenu.ResumeLayout(False)
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlCabecera As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblPlanyvent As Label
    Friend WithEvents btnRestaurar As Button
    Friend WithEvents btnCerrar As Button
    Friend WithEvents btnMinimizar As Button
    Friend WithEvents btnMaximizar As Button
    Friend WithEvents lblNombre As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents lblDesc As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents rtbDesc As RichTextBox
    Friend WithEvents gbInfoBasica As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnPresupuestoAvanzadas As Button
    Friend WithEvents txtPresupuestoRestante As TextBox
    Friend WithEvents lblPresupuestoRestante As Label
    Friend WithEvents txtPresupuestoGastado As TextBox
    Friend WithEvents lblPresupuestoGastado As Label
    Friend WithEvents txtPresupuestoTotal As TextBox
    Friend WithEvents lblPresupuesto As Label
    Friend WithEvents ttPTotal As ToolTip
    Friend WithEvents ttPGastado As ToolTip
    Friend WithEvents ttPRestante As ToolTip
    Friend WithEvents btnInvitacionesAvanzadas As Button
    Friend WithEvents txtInvTotales As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnAñadirEvento As Button
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents btnVolver As Button
    Friend WithEvents lblLugar As Label
    Friend WithEvents txtLugar As TextBox
    Friend WithEvents rtbInfo As RichTextBox
    Friend WithEvents lblInfo As Label
    Friend WithEvents btnGuardarCambios As Button
    Friend WithEvents pnlMenu As Panel
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox13 As PictureBox
    Friend WithEvents btnCerrarSesion As Button
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnMenu As Button
    Friend WithEvents btnCuenta As Button
End Class
