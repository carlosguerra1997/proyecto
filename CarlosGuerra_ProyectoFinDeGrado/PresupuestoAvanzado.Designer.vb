<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PresupuestoAvanzado
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PresupuestoAvanzado))
        Me.pnlCabecera = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblPlanyvent = New System.Windows.Forms.Label()
        Me.btnRestaurar = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.btnMinimizar = New System.Windows.Forms.Button()
        Me.btnMaximizar = New System.Windows.Forms.Button()
        Me.txtActividad = New System.Windows.Forms.TextBox()
        Me.txtCoste = New System.Windows.Forms.TextBox()
        Me.lblActividad = New System.Windows.Forms.Label()
        Me.lblGasto = New System.Windows.Forms.Label()
        Me.btnAñadir = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.dgvPresupuesto = New System.Windows.Forms.DataGridView()
        Me.Actividad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pagada = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ckbPagado = New System.Windows.Forms.CheckBox()
        Me.lblPagada = New System.Windows.Forms.Label()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.btnActSelecc = New System.Windows.Forms.Button()
        Me.btnEliminarTodos = New System.Windows.Forms.Button()
        Me.btnGuardarCambios = New System.Windows.Forms.Button()
        Me.btnAñadirNuevaAct = New System.Windows.Forms.Button()
        Me.ttAñadirAct = New System.Windows.Forms.ToolTip(Me.components)
        Me.ttEditarAct = New System.Windows.Forms.ToolTip(Me.components)
        Me.ttEliminarSelecc = New System.Windows.Forms.ToolTip(Me.components)
        Me.ttEliminarTodas = New System.Windows.Forms.ToolTip(Me.components)
        Me.TtAñadir = New System.Windows.Forms.ToolTip(Me.components)
        Me.pnlCabecera.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvPresupuesto, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.pnlCabecera.Size = New System.Drawing.Size(415, 35)
        Me.pnlCabecera.TabIndex = 3
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
        Me.lblPlanyvent.Location = New System.Drawing.Point(141, 6)
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
        Me.btnRestaurar.Location = New System.Drawing.Point(345, 0)
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
        Me.btnCerrar.Location = New System.Drawing.Point(380, 0)
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
        Me.btnMinimizar.Location = New System.Drawing.Point(311, 0)
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
        Me.btnMaximizar.Location = New System.Drawing.Point(345, 0)
        Me.btnMaximizar.Name = "btnMaximizar"
        Me.btnMaximizar.Size = New System.Drawing.Size(35, 35)
        Me.btnMaximizar.TabIndex = 46
        Me.btnMaximizar.UseVisualStyleBackColor = True
        '
        'txtActividad
        '
        Me.txtActividad.Location = New System.Drawing.Point(40, 57)
        Me.txtActividad.Name = "txtActividad"
        Me.txtActividad.Size = New System.Drawing.Size(127, 20)
        Me.txtActividad.TabIndex = 5
        '
        'txtCoste
        '
        Me.txtCoste.Location = New System.Drawing.Point(173, 57)
        Me.txtCoste.Name = "txtCoste"
        Me.txtCoste.Size = New System.Drawing.Size(123, 20)
        Me.txtCoste.TabIndex = 6
        '
        'lblActividad
        '
        Me.lblActividad.AutoSize = True
        Me.lblActividad.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblActividad.Location = New System.Drawing.Point(78, 41)
        Me.lblActividad.Name = "lblActividad"
        Me.lblActividad.Size = New System.Drawing.Size(51, 13)
        Me.lblActividad.TabIndex = 7
        Me.lblActividad.Text = "Actividad"
        '
        'lblGasto
        '
        Me.lblGasto.AutoSize = True
        Me.lblGasto.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblGasto.Location = New System.Drawing.Point(220, 41)
        Me.lblGasto.Name = "lblGasto"
        Me.lblGasto.Size = New System.Drawing.Size(34, 13)
        Me.lblGasto.TabIndex = 8
        Me.lblGasto.Text = "Coste"
        '
        'btnAñadir
        '
        Me.btnAñadir.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btnAñadir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAñadir.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnAñadir.Location = New System.Drawing.Point(40, 83)
        Me.btnAñadir.Name = "btnAñadir"
        Me.btnAñadir.Size = New System.Drawing.Size(332, 34)
        Me.btnAñadir.TabIndex = 9
        Me.btnAñadir.Text = "Añadir actividad a la lista"
        Me.btnAñadir.UseVisualStyleBackColor = False
        '
        'dgvPresupuesto
        '
        Me.dgvPresupuesto.AllowUserToDeleteRows = False
        Me.dgvPresupuesto.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.dgvPresupuesto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPresupuesto.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Actividad, Me.Precio, Me.Pagada})
        Me.dgvPresupuesto.Location = New System.Drawing.Point(40, 163)
        Me.dgvPresupuesto.Name = "dgvPresupuesto"
        Me.dgvPresupuesto.ReadOnly = True
        Me.dgvPresupuesto.Size = New System.Drawing.Size(332, 239)
        Me.dgvPresupuesto.TabIndex = 11
        '
        'Actividad
        '
        Me.Actividad.HeaderText = "Actividad"
        Me.Actividad.Name = "Actividad"
        Me.Actividad.ReadOnly = True
        Me.Actividad.ToolTipText = "Nombre de la actividad"
        '
        'Precio
        '
        Me.Precio.HeaderText = "Precio"
        Me.Precio.Name = "Precio"
        Me.Precio.ReadOnly = True
        Me.Precio.ToolTipText = "Precio de la actividad"
        '
        'Pagada
        '
        Me.Pagada.HeaderText = "Pagada"
        Me.Pagada.Name = "Pagada"
        Me.Pagada.ReadOnly = True
        Me.Pagada.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Pagada.ToolTipText = "Indica si ya has realizado el pago de la actividad o no"
        '
        'ckbPagado
        '
        Me.ckbPagado.AutoSize = True
        Me.ckbPagado.Location = New System.Drawing.Point(323, 60)
        Me.ckbPagado.Name = "ckbPagado"
        Me.ckbPagado.Size = New System.Drawing.Size(15, 14)
        Me.ckbPagado.TabIndex = 12
        Me.ckbPagado.UseVisualStyleBackColor = True
        '
        'lblPagada
        '
        Me.lblPagada.AutoSize = True
        Me.lblPagada.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblPagada.Location = New System.Drawing.Point(309, 41)
        Me.lblPagada.Name = "lblPagada"
        Me.lblPagada.Size = New System.Drawing.Size(44, 13)
        Me.lblPagada.TabIndex = 13
        Me.lblPagada.Text = "Pagada"
        '
        'btnVolver
        '
        Me.btnVolver.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnVolver.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnVolver.Location = New System.Drawing.Point(40, 408)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(332, 34)
        Me.btnVolver.TabIndex = 14
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = False
        '
        'btnActSelecc
        '
        Me.btnActSelecc.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btnActSelecc.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnActSelecc.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnActSelecc.Location = New System.Drawing.Point(40, 123)
        Me.btnActSelecc.Name = "btnActSelecc"
        Me.btnActSelecc.Size = New System.Drawing.Size(164, 34)
        Me.btnActSelecc.TabIndex = 15
        Me.btnActSelecc.Text = "Eliminar actividad seleccionada"
        Me.btnActSelecc.UseVisualStyleBackColor = False
        '
        'btnEliminarTodos
        '
        Me.btnEliminarTodos.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btnEliminarTodos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEliminarTodos.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnEliminarTodos.Location = New System.Drawing.Point(210, 123)
        Me.btnEliminarTodos.Name = "btnEliminarTodos"
        Me.btnEliminarTodos.Size = New System.Drawing.Size(162, 34)
        Me.btnEliminarTodos.TabIndex = 16
        Me.btnEliminarTodos.Text = "Eliminar todas las actividades"
        Me.btnEliminarTodos.UseVisualStyleBackColor = False
        '
        'btnGuardarCambios
        '
        Me.btnGuardarCambios.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btnGuardarCambios.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnGuardarCambios.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnGuardarCambios.Location = New System.Drawing.Point(208, 83)
        Me.btnGuardarCambios.Name = "btnGuardarCambios"
        Me.btnGuardarCambios.Size = New System.Drawing.Size(164, 34)
        Me.btnGuardarCambios.TabIndex = 17
        Me.btnGuardarCambios.Text = "Editar y guardar actividad seleccionada" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnGuardarCambios.UseVisualStyleBackColor = False
        '
        'btnAñadirNuevaAct
        '
        Me.btnAñadirNuevaAct.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btnAñadirNuevaAct.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAñadirNuevaAct.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnAñadirNuevaAct.Location = New System.Drawing.Point(40, 83)
        Me.btnAñadirNuevaAct.Name = "btnAñadirNuevaAct"
        Me.btnAñadirNuevaAct.Size = New System.Drawing.Size(164, 34)
        Me.btnAñadirNuevaAct.TabIndex = 18
        Me.btnAñadirNuevaAct.Text = "Añadir nueva actividad"
        Me.btnAñadirNuevaAct.UseVisualStyleBackColor = False
        '
        'ttEditarAct
        '
        Me.ttEditarAct.ShowAlways = True
        '
        'PresupuestoAvanzado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(415, 456)
        Me.Controls.Add(Me.btnAñadirNuevaAct)
        Me.Controls.Add(Me.btnGuardarCambios)
        Me.Controls.Add(Me.btnEliminarTodos)
        Me.Controls.Add(Me.btnActSelecc)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.lblPagada)
        Me.Controls.Add(Me.ckbPagado)
        Me.Controls.Add(Me.dgvPresupuesto)
        Me.Controls.Add(Me.btnAñadir)
        Me.Controls.Add(Me.lblGasto)
        Me.Controls.Add(Me.lblActividad)
        Me.Controls.Add(Me.txtCoste)
        Me.Controls.Add(Me.txtActividad)
        Me.Controls.Add(Me.pnlCabecera)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PresupuestoAvanzado"
        Me.Text = "s"
        Me.pnlCabecera.ResumeLayout(False)
        Me.pnlCabecera.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvPresupuesto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlCabecera As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblPlanyvent As Label
    Friend WithEvents btnRestaurar As Button
    Friend WithEvents btnCerrar As Button
    Friend WithEvents btnMinimizar As Button
    Friend WithEvents btnMaximizar As Button
    Friend WithEvents txtActividad As TextBox
    Friend WithEvents txtCoste As TextBox
    Friend WithEvents lblActividad As Label
    Friend WithEvents lblGasto As Label
    Friend WithEvents btnAñadir As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents dgvPresupuesto As DataGridView
    Friend WithEvents ckbPagado As CheckBox
    Friend WithEvents lblPagada As Label
    Friend WithEvents btnVolver As Button
    Friend WithEvents btnActSelecc As Button
    Friend WithEvents btnEliminarTodos As Button
    Friend WithEvents Actividad As DataGridViewTextBoxColumn
    Friend WithEvents Precio As DataGridViewTextBoxColumn
    Friend WithEvents Pagada As DataGridViewTextBoxColumn
    Friend WithEvents btnGuardarCambios As Button
    Friend WithEvents btnAñadirNuevaAct As Button
    Friend WithEvents ttAñadirAct As ToolTip
    Friend WithEvents ttEditarAct As ToolTip
    Friend WithEvents ttEliminarSelecc As ToolTip
    Friend WithEvents ttEliminarTodas As ToolTip
    Friend WithEvents TtAñadir As ToolTip
End Class
