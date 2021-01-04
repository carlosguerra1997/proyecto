<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ListadoEvento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ListadoEvento))
        Me.pnlCabecera = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnRestaurar = New System.Windows.Forms.Button()
        Me.btnMinimizar = New System.Windows.Forms.Button()
        Me.btnMaximizar = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.dgvListadoEventos = New System.Windows.Forms.DataGridView()
        Me.nombre_evento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.desc_evento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha_evento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lugar_evento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.info_evento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.presupuesto_total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.presupuesto_pagado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.presupuesto_restante = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.inv_totales = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblListadoEventos = New System.Windows.Forms.Label()
        Me.btnEditarEvento = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.pnlMenu = New System.Windows.Forms.Panel()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox13 = New System.Windows.Forms.PictureBox()
        Me.btnCerrarSesion = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnMenu = New System.Windows.Forms.Button()
        Me.btnCuenta = New System.Windows.Forms.Button()
        Me.cmbFiltro = New System.Windows.Forms.ComboBox()
        Me.lblFiltro = New System.Windows.Forms.Label()
        Me.btnReiniciar = New System.Windows.Forms.Button()
        Me.btnEliminarEvento = New System.Windows.Forms.Button()
        Me.pnlCabecera.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvListadoEventos, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.pnlCabecera.Controls.Add(Me.Label1)
        Me.pnlCabecera.Controls.Add(Me.btnRestaurar)
        Me.pnlCabecera.Controls.Add(Me.btnMinimizar)
        Me.pnlCabecera.Controls.Add(Me.btnMaximizar)
        Me.pnlCabecera.Controls.Add(Me.btnCerrar)
        Me.pnlCabecera.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlCabecera.Location = New System.Drawing.Point(0, 0)
        Me.pnlCabecera.Name = "pnlCabecera"
        Me.pnlCabecera.Size = New System.Drawing.Size(1218, 35)
        Me.pnlCabecera.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(33, 27)
        Me.PictureBox1.TabIndex = 51
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(629, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 20)
        Me.Label1.TabIndex = 50
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
        Me.btnRestaurar.Location = New System.Drawing.Point(1148, 0)
        Me.btnRestaurar.Name = "btnRestaurar"
        Me.btnRestaurar.Size = New System.Drawing.Size(35, 35)
        Me.btnRestaurar.TabIndex = 5
        Me.btnRestaurar.UseVisualStyleBackColor = True
        Me.btnRestaurar.Visible = False
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
        Me.btnMinimizar.Location = New System.Drawing.Point(1114, 0)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.Size = New System.Drawing.Size(35, 35)
        Me.btnMinimizar.TabIndex = 4
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
        Me.btnMaximizar.Location = New System.Drawing.Point(1148, 0)
        Me.btnMaximizar.Name = "btnMaximizar"
        Me.btnMaximizar.Size = New System.Drawing.Size(35, 35)
        Me.btnMaximizar.TabIndex = 3
        Me.btnMaximizar.UseVisualStyleBackColor = True
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
        Me.btnCerrar.Location = New System.Drawing.Point(1183, 0)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(35, 35)
        Me.btnCerrar.TabIndex = 2
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'dgvListadoEventos
        '
        Me.dgvListadoEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListadoEventos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nombre_evento, Me.desc_evento, Me.fecha_evento, Me.lugar_evento, Me.info_evento, Me.presupuesto_total, Me.presupuesto_pagado, Me.presupuesto_restante, Me.inv_totales})
        Me.dgvListadoEventos.Location = New System.Drawing.Point(235, 93)
        Me.dgvListadoEventos.Name = "dgvListadoEventos"
        Me.dgvListadoEventos.Size = New System.Drawing.Size(944, 319)
        Me.dgvListadoEventos.TabIndex = 3
        '
        'nombre_evento
        '
        Me.nombre_evento.HeaderText = "Nombre"
        Me.nombre_evento.Name = "nombre_evento"
        '
        'desc_evento
        '
        Me.desc_evento.HeaderText = "Descripcion"
        Me.desc_evento.Name = "desc_evento"
        '
        'fecha_evento
        '
        Me.fecha_evento.HeaderText = "Fecha"
        Me.fecha_evento.Name = "fecha_evento"
        '
        'lugar_evento
        '
        Me.lugar_evento.HeaderText = "Lugar del evento"
        Me.lugar_evento.Name = "lugar_evento"
        '
        'info_evento
        '
        Me.info_evento.HeaderText = "Información del evento"
        Me.info_evento.Name = "info_evento"
        '
        'presupuesto_total
        '
        Me.presupuesto_total.HeaderText = "Presupuesto total"
        Me.presupuesto_total.Name = "presupuesto_total"
        '
        'presupuesto_pagado
        '
        Me.presupuesto_pagado.HeaderText = "Presupuesto pagado"
        Me.presupuesto_pagado.Name = "presupuesto_pagado"
        '
        'presupuesto_restante
        '
        Me.presupuesto_restante.HeaderText = "Presupuesto restante"
        Me.presupuesto_restante.Name = "presupuesto_restante"
        '
        'inv_totales
        '
        Me.inv_totales.HeaderText = "Invitaciones totales"
        Me.inv_totales.Name = "inv_totales"
        '
        'lblListadoEventos
        '
        Me.lblListadoEventos.AutoSize = True
        Me.lblListadoEventos.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblListadoEventos.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblListadoEventos.Location = New System.Drawing.Point(231, 55)
        Me.lblListadoEventos.Name = "lblListadoEventos"
        Me.lblListadoEventos.Size = New System.Drawing.Size(415, 24)
        Me.lblListadoEventos.TabIndex = 4
        Me.lblListadoEventos.Text = "PULSA EN EL EVENTO QUE DESEES EDITAR"
        '
        'btnEditarEvento
        '
        Me.btnEditarEvento.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btnEditarEvento.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEditarEvento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditarEvento.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnEditarEvento.Location = New System.Drawing.Point(560, 431)
        Me.btnEditarEvento.Name = "btnEditarEvento"
        Me.btnEditarEvento.Size = New System.Drawing.Size(165, 50)
        Me.btnEditarEvento.TabIndex = 18
        Me.btnEditarEvento.Text = "EDITAR EVENTO "
        Me.btnEditarEvento.UseVisualStyleBackColor = False
        '
        'btnVolver
        '
        Me.btnVolver.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnVolver.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolver.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnVolver.Location = New System.Drawing.Point(731, 431)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(165, 50)
        Me.btnVolver.TabIndex = 17
        Me.btnVolver.Text = "VOLVER"
        Me.btnVolver.UseVisualStyleBackColor = False
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
        Me.pnlMenu.Size = New System.Drawing.Size(187, 461)
        Me.pnlMenu.TabIndex = 19
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
        Me.PictureBox13.Location = New System.Drawing.Point(0, 211)
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
        Me.btnCerrarSesion.Location = New System.Drawing.Point(55, 211)
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
        'cmbFiltro
        '
        Me.cmbFiltro.FormattingEnabled = True
        Me.cmbFiltro.Items.AddRange(New Object() {"Nombre ascendente", "Nombre descendente", "Fecha más reciente", "Fecha más antigua"})
        Me.cmbFiltro.Location = New System.Drawing.Point(879, 58)
        Me.cmbFiltro.Name = "cmbFiltro"
        Me.cmbFiltro.Size = New System.Drawing.Size(170, 21)
        Me.cmbFiltro.TabIndex = 20
        '
        'lblFiltro
        '
        Me.lblFiltro.AutoSize = True
        Me.lblFiltro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFiltro.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblFiltro.Location = New System.Drawing.Point(797, 61)
        Me.lblFiltro.Name = "lblFiltro"
        Me.lblFiltro.Size = New System.Drawing.Size(76, 15)
        Me.lblFiltro.TabIndex = 21
        Me.lblFiltro.Text = "Ordenar por:"
        '
        'btnReiniciar
        '
        Me.btnReiniciar.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btnReiniciar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnReiniciar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnReiniciar.Location = New System.Drawing.Point(1055, 58)
        Me.btnReiniciar.Name = "btnReiniciar"
        Me.btnReiniciar.Size = New System.Drawing.Size(124, 21)
        Me.btnReiniciar.TabIndex = 22
        Me.btnReiniciar.Text = "Reiniciar"
        Me.btnReiniciar.UseVisualStyleBackColor = False
        '
        'btnEliminarEvento
        '
        Me.btnEliminarEvento.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btnEliminarEvento.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEliminarEvento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarEvento.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnEliminarEvento.Location = New System.Drawing.Point(560, 431)
        Me.btnEliminarEvento.Name = "btnEliminarEvento"
        Me.btnEliminarEvento.Size = New System.Drawing.Size(165, 50)
        Me.btnEliminarEvento.TabIndex = 23
        Me.btnEliminarEvento.Text = "ELIMINAR EVENTO"
        Me.btnEliminarEvento.UseVisualStyleBackColor = False
        '
        'ListadoEvento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1218, 496)
        Me.Controls.Add(Me.btnEliminarEvento)
        Me.Controls.Add(Me.btnReiniciar)
        Me.Controls.Add(Me.lblFiltro)
        Me.Controls.Add(Me.cmbFiltro)
        Me.Controls.Add(Me.pnlMenu)
        Me.Controls.Add(Me.btnEditarEvento)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.lblListadoEventos)
        Me.Controls.Add(Me.dgvListadoEventos)
        Me.Controls.Add(Me.pnlCabecera)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ListadoEvento"
        Me.Text = "AgregarEvento"
        Me.pnlCabecera.ResumeLayout(False)
        Me.pnlCabecera.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvListadoEventos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMenu.ResumeLayout(False)
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlCabecera As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnRestaurar As Button
    Friend WithEvents btnMinimizar As Button
    Friend WithEvents btnMaximizar As Button
    Friend WithEvents btnCerrar As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents dgvListadoEventos As DataGridView
    Friend WithEvents nombre_evento As DataGridViewTextBoxColumn
    Friend WithEvents desc_evento As DataGridViewTextBoxColumn
    Friend WithEvents fecha_evento As DataGridViewTextBoxColumn
    Friend WithEvents lugar_evento As DataGridViewTextBoxColumn
    Friend WithEvents info_evento As DataGridViewTextBoxColumn
    Friend WithEvents presupuesto_total As DataGridViewTextBoxColumn
    Friend WithEvents presupuesto_pagado As DataGridViewTextBoxColumn
    Friend WithEvents presupuesto_restante As DataGridViewTextBoxColumn
    Friend WithEvents inv_totales As DataGridViewTextBoxColumn
    Friend WithEvents lblListadoEventos As Label
    Friend WithEvents btnEditarEvento As Button
    Friend WithEvents btnVolver As Button
    Friend WithEvents pnlMenu As Panel
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox13 As PictureBox
    Friend WithEvents btnCerrarSesion As Button
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnMenu As Button
    Friend WithEvents btnCuenta As Button
    Friend WithEvents cmbFiltro As ComboBox
    Friend WithEvents lblFiltro As Label
    Friend WithEvents btnReiniciar As Button
    Friend WithEvents btnEliminarEvento As Button
End Class
