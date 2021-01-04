<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InvitacionesAvanzado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InvitacionesAvanzado))
        Me.pnlCabecera = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblPlanyvent = New System.Windows.Forms.Label()
        Me.btnRestaurar = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.btnMinimizar = New System.Windows.Forms.Button()
        Me.btnMaximizar = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.dgvInvitaciones = New System.Windows.Forms.DataGridView()
        Me.Invitados = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumPersonas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnAñadir = New System.Windows.Forms.Button()
        Me.lblInvitados = New System.Windows.Forms.Label()
        Me.lblInvitacion = New System.Windows.Forms.Label()
        Me.txtNumPersonas = New System.Windows.Forms.TextBox()
        Me.txtInvitados = New System.Windows.Forms.TextBox()
        Me.btnEliminarTodos = New System.Windows.Forms.Button()
        Me.btnActSelecc = New System.Windows.Forms.Button()
        Me.btnGuardarCambios = New System.Windows.Forms.Button()
        Me.btnAñadirInv = New System.Windows.Forms.Button()
        Me.ttAñadirInv = New System.Windows.Forms.ToolTip(Me.components)
        Me.ttEditarInv = New System.Windows.Forms.ToolTip(Me.components)
        Me.ttEliminarSelecc = New System.Windows.Forms.ToolTip(Me.components)
        Me.ttEliminarTodos = New System.Windows.Forms.ToolTip(Me.components)
        Me.ttAñadir = New System.Windows.Forms.ToolTip(Me.components)
        Me.pnlCabecera.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvInvitaciones, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.pnlCabecera.Size = New System.Drawing.Size(410, 35)
        Me.pnlCabecera.TabIndex = 4
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
        Me.lblPlanyvent.Location = New System.Drawing.Point(139, 6)
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
        Me.btnRestaurar.Location = New System.Drawing.Point(340, 0)
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
        Me.btnCerrar.Location = New System.Drawing.Point(375, 0)
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
        Me.btnMinimizar.Location = New System.Drawing.Point(306, 0)
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
        Me.btnMaximizar.Location = New System.Drawing.Point(340, 0)
        Me.btnMaximizar.Name = "btnMaximizar"
        Me.btnMaximizar.Size = New System.Drawing.Size(35, 35)
        Me.btnMaximizar.TabIndex = 46
        Me.btnMaximizar.UseVisualStyleBackColor = True
        '
        'btnVolver
        '
        Me.btnVolver.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnVolver.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnVolver.Location = New System.Drawing.Point(33, 414)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(332, 34)
        Me.btnVolver.TabIndex = 23
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = False
        '
        'dgvInvitaciones
        '
        Me.dgvInvitaciones.AllowUserToDeleteRows = False
        Me.dgvInvitaciones.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.dgvInvitaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInvitaciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Invitados, Me.NumPersonas})
        Me.dgvInvitaciones.Location = New System.Drawing.Point(33, 169)
        Me.dgvInvitaciones.Name = "dgvInvitaciones"
        Me.dgvInvitaciones.ReadOnly = True
        Me.dgvInvitaciones.Size = New System.Drawing.Size(332, 239)
        Me.dgvInvitaciones.TabIndex = 20
        '
        'Invitados
        '
        Me.Invitados.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Invitados.HeaderText = "Invitados"
        Me.Invitados.Name = "Invitados"
        Me.Invitados.ReadOnly = True
        Me.Invitados.ToolTipText = "Nombre de los invitados"
        '
        'NumPersonas
        '
        Me.NumPersonas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NumPersonas.HeaderText = "Numero de personas"
        Me.NumPersonas.Name = "NumPersonas"
        Me.NumPersonas.ReadOnly = True
        Me.NumPersonas.ToolTipText = "Número de personas a las que va destinada la invitación"
        '
        'btnAñadir
        '
        Me.btnAñadir.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btnAñadir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAñadir.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnAñadir.Location = New System.Drawing.Point(33, 87)
        Me.btnAñadir.Name = "btnAñadir"
        Me.btnAñadir.Size = New System.Drawing.Size(332, 34)
        Me.btnAñadir.TabIndex = 19
        Me.btnAñadir.Text = "Añadir invitación a la lista"
        Me.btnAñadir.UseVisualStyleBackColor = False
        '
        'lblInvitados
        '
        Me.lblInvitados.AutoSize = True
        Me.lblInvitados.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblInvitados.Location = New System.Drawing.Point(214, 45)
        Me.lblInvitados.Name = "lblInvitados"
        Me.lblInvitados.Size = New System.Drawing.Size(105, 13)
        Me.lblInvitados.TabIndex = 18
        Me.lblInvitados.Text = "Numero de personas"
        '
        'lblInvitacion
        '
        Me.lblInvitacion.AutoSize = True
        Me.lblInvitacion.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblInvitacion.Location = New System.Drawing.Point(112, 45)
        Me.lblInvitacion.Name = "lblInvitacion"
        Me.lblInvitacion.Size = New System.Drawing.Size(50, 13)
        Me.lblInvitacion.TabIndex = 17
        Me.lblInvitacion.Text = "Invitados"
        '
        'txtNumPersonas
        '
        Me.txtNumPersonas.Location = New System.Drawing.Point(207, 61)
        Me.txtNumPersonas.Name = "txtNumPersonas"
        Me.txtNumPersonas.Size = New System.Drawing.Size(123, 20)
        Me.txtNumPersonas.TabIndex = 16
        '
        'txtInvitados
        '
        Me.txtInvitados.Location = New System.Drawing.Point(74, 61)
        Me.txtInvitados.Name = "txtInvitados"
        Me.txtInvitados.Size = New System.Drawing.Size(127, 20)
        Me.txtInvitados.TabIndex = 15
        '
        'btnEliminarTodos
        '
        Me.btnEliminarTodos.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btnEliminarTodos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEliminarTodos.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnEliminarTodos.Location = New System.Drawing.Point(203, 129)
        Me.btnEliminarTodos.Name = "btnEliminarTodos"
        Me.btnEliminarTodos.Size = New System.Drawing.Size(162, 34)
        Me.btnEliminarTodos.TabIndex = 25
        Me.btnEliminarTodos.Text = "Eliminar todas las actividades"
        Me.btnEliminarTodos.UseVisualStyleBackColor = False
        '
        'btnActSelecc
        '
        Me.btnActSelecc.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btnActSelecc.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnActSelecc.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnActSelecc.Location = New System.Drawing.Point(33, 129)
        Me.btnActSelecc.Name = "btnActSelecc"
        Me.btnActSelecc.Size = New System.Drawing.Size(164, 34)
        Me.btnActSelecc.TabIndex = 24
        Me.btnActSelecc.Text = "Eliminar actividad seleccionada"
        Me.btnActSelecc.UseVisualStyleBackColor = False
        '
        'btnGuardarCambios
        '
        Me.btnGuardarCambios.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btnGuardarCambios.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnGuardarCambios.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnGuardarCambios.Location = New System.Drawing.Point(203, 87)
        Me.btnGuardarCambios.Name = "btnGuardarCambios"
        Me.btnGuardarCambios.Size = New System.Drawing.Size(162, 34)
        Me.btnGuardarCambios.TabIndex = 26
        Me.btnGuardarCambios.Text = "Editar y guardar invitación seleccionada" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnGuardarCambios.UseVisualStyleBackColor = False
        '
        'btnAñadirInv
        '
        Me.btnAñadirInv.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btnAñadirInv.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAñadirInv.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnAñadirInv.Location = New System.Drawing.Point(33, 87)
        Me.btnAñadirInv.Name = "btnAñadirInv"
        Me.btnAñadirInv.Size = New System.Drawing.Size(162, 34)
        Me.btnAñadirInv.TabIndex = 27
        Me.btnAñadirInv.Text = "Añadir nueva invitación" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnAñadirInv.UseVisualStyleBackColor = False
        '
        'InvitacionesAvanzado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(410, 459)
        Me.Controls.Add(Me.btnAñadirInv)
        Me.Controls.Add(Me.btnGuardarCambios)
        Me.Controls.Add(Me.btnEliminarTodos)
        Me.Controls.Add(Me.btnActSelecc)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.dgvInvitaciones)
        Me.Controls.Add(Me.btnAñadir)
        Me.Controls.Add(Me.lblInvitados)
        Me.Controls.Add(Me.lblInvitacion)
        Me.Controls.Add(Me.txtNumPersonas)
        Me.Controls.Add(Me.txtInvitados)
        Me.Controls.Add(Me.pnlCabecera)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "InvitacionesAvanzado"
        Me.Text = "InvitacionesAvanzado"
        Me.pnlCabecera.ResumeLayout(False)
        Me.pnlCabecera.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvInvitaciones, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents btnVolver As Button
    Friend WithEvents dgvInvitaciones As DataGridView
    Friend WithEvents btnAñadir As Button
    Friend WithEvents lblInvitados As Label
    Friend WithEvents lblInvitacion As Label
    Friend WithEvents txtNumPersonas As TextBox
    Friend WithEvents txtInvitados As TextBox
    Friend WithEvents btnEliminarTodos As Button
    Friend WithEvents btnActSelecc As Button
    Friend WithEvents Invitados As DataGridViewTextBoxColumn
    Friend WithEvents NumPersonas As DataGridViewTextBoxColumn
    Friend WithEvents btnGuardarCambios As Button
    Friend WithEvents btnAñadirInv As Button
    Friend WithEvents ttAñadirInv As ToolTip
    Friend WithEvents ttEditarInv As ToolTip
    Friend WithEvents ttEliminarSelecc As ToolTip
    Friend WithEvents ttEliminarTodos As ToolTip
    Friend WithEvents ttAñadir As ToolTip
End Class
