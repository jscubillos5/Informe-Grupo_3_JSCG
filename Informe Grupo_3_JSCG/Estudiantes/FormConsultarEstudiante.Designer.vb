<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _formConsultarEstudiante
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(_formConsultarEstudiante))
        Me._toolTip_formConsultarEstudiante = New System.Windows.Forms.ToolTip(Me.components)
        Me._errorProvider_formConsultarEstudiante = New System.Windows.Forms.ErrorProvider(Me.components)
        Me._panelSuperior = New System.Windows.Forms.Panel()
        Me._panelDataGridViewEstudiantes = New System.Windows.Forms.Panel()
        Me._dataGridViewEstudiantes = New System.Windows.Forms.DataGridView()
        Me._bindingNavigatorEstudiantes = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ImprimirToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.CopiarToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.AyudaToolStripButton = New System.Windows.Forms.ToolStripButton()
        CType(Me._errorProvider_formConsultarEstudiante, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._panelSuperior.SuspendLayout()
        Me._panelDataGridViewEstudiantes.SuspendLayout()
        CType(Me._dataGridViewEstudiantes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._bindingNavigatorEstudiantes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._bindingNavigatorEstudiantes.SuspendLayout()
        Me.SuspendLayout()
        '
        '_errorProvider_formConsultarEstudiante
        '
        Me._errorProvider_formConsultarEstudiante.ContainerControl = Me
        '
        '_panelSuperior
        '
        Me._panelSuperior.Controls.Add(Me._bindingNavigatorEstudiantes)
        Me._panelSuperior.Dock = System.Windows.Forms.DockStyle.Top
        Me._panelSuperior.Location = New System.Drawing.Point(0, 0)
        Me._panelSuperior.Name = "_panelSuperior"
        Me._panelSuperior.Size = New System.Drawing.Size(800, 29)
        Me._panelSuperior.TabIndex = 0
        '
        '_panelDataGridViewEstudiantes
        '
        Me._panelDataGridViewEstudiantes.Controls.Add(Me._dataGridViewEstudiantes)
        Me._panelDataGridViewEstudiantes.Dock = System.Windows.Forms.DockStyle.Fill
        Me._panelDataGridViewEstudiantes.Location = New System.Drawing.Point(0, 29)
        Me._panelDataGridViewEstudiantes.Name = "_panelDataGridViewEstudiantes"
        Me._panelDataGridViewEstudiantes.Size = New System.Drawing.Size(800, 421)
        Me._panelDataGridViewEstudiantes.TabIndex = 1
        '
        '_dataGridViewEstudiantes
        '
        Me._dataGridViewEstudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me._dataGridViewEstudiantes.Dock = System.Windows.Forms.DockStyle.Fill
        Me._dataGridViewEstudiantes.Location = New System.Drawing.Point(0, 0)
        Me._dataGridViewEstudiantes.Name = "_dataGridViewEstudiantes"
        Me._dataGridViewEstudiantes.Size = New System.Drawing.Size(800, 421)
        Me._dataGridViewEstudiantes.TabIndex = 0
        '
        '_bindingNavigatorEstudiantes
        '
        Me._bindingNavigatorEstudiantes.AddNewItem = Nothing
        Me._bindingNavigatorEstudiantes.CountItem = Me.BindingNavigatorCountItem
        Me._bindingNavigatorEstudiantes.DeleteItem = Nothing
        Me._bindingNavigatorEstudiantes.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.ImprimirToolStripButton, Me.toolStripSeparator, Me.CopiarToolStripButton, Me.toolStripSeparator1, Me.AyudaToolStripButton})
        Me._bindingNavigatorEstudiantes.Location = New System.Drawing.Point(0, 0)
        Me._bindingNavigatorEstudiantes.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me._bindingNavigatorEstudiantes.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me._bindingNavigatorEstudiantes.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me._bindingNavigatorEstudiantes.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me._bindingNavigatorEstudiantes.Name = "_bindingNavigatorEstudiantes"
        Me._bindingNavigatorEstudiantes.PositionItem = Me.BindingNavigatorPositionItem
        Me._bindingNavigatorEstudiantes.Size = New System.Drawing.Size(800, 25)
        Me._bindingNavigatorEstudiantes.TabIndex = 0
        Me._bindingNavigatorEstudiantes.Text = "Estudiantes"
        Me._toolTip_formConsultarEstudiante.SetToolTip(Me._bindingNavigatorEstudiantes, "Permite moverse en la lista de estudiantes cargada")
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ImprimirToolStripButton
        '
        Me.ImprimirToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ImprimirToolStripButton.Image = CType(resources.GetObject("ImprimirToolStripButton.Image"), System.Drawing.Image)
        Me.ImprimirToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ImprimirToolStripButton.Name = "ImprimirToolStripButton"
        Me.ImprimirToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.ImprimirToolStripButton.Text = "&Imprimir"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'CopiarToolStripButton
        '
        Me.CopiarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CopiarToolStripButton.Image = CType(resources.GetObject("CopiarToolStripButton.Image"), System.Drawing.Image)
        Me.CopiarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CopiarToolStripButton.Name = "CopiarToolStripButton"
        Me.CopiarToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.CopiarToolStripButton.Text = "&Copiar"
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'AyudaToolStripButton
        '
        Me.AyudaToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AyudaToolStripButton.Image = CType(resources.GetObject("AyudaToolStripButton.Image"), System.Drawing.Image)
        Me.AyudaToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AyudaToolStripButton.Name = "AyudaToolStripButton"
        Me.AyudaToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.AyudaToolStripButton.Text = "Ay&uda"
        '
        '_formConsultarEstudiante
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me._panelDataGridViewEstudiantes)
        Me.Controls.Add(Me._panelSuperior)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "_formConsultarEstudiante"
        Me.Text = "Consultar Estudiante"
        CType(Me._errorProvider_formConsultarEstudiante, System.ComponentModel.ISupportInitialize).EndInit()
        Me._panelSuperior.ResumeLayout(False)
        Me._panelSuperior.PerformLayout()
        Me._panelDataGridViewEstudiantes.ResumeLayout(False)
        CType(Me._dataGridViewEstudiantes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._bindingNavigatorEstudiantes, System.ComponentModel.ISupportInitialize).EndInit()
        Me._bindingNavigatorEstudiantes.ResumeLayout(False)
        Me._bindingNavigatorEstudiantes.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents _toolTip_formConsultarEstudiante As ToolTip
    Friend WithEvents _errorProvider_formConsultarEstudiante As ErrorProvider
    Friend WithEvents _panelSuperior As Panel
    Friend WithEvents _panelDataGridViewEstudiantes As Panel
    Friend WithEvents _dataGridViewEstudiantes As DataGridView
    Friend WithEvents _bindingNavigatorEstudiantes As BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents ImprimirToolStripButton As ToolStripButton
    Friend WithEvents toolStripSeparator As ToolStripSeparator
    Friend WithEvents CopiarToolStripButton As ToolStripButton
    Friend WithEvents toolStripSeparator1 As ToolStripSeparator
    Friend WithEvents AyudaToolStripButton As ToolStripButton
End Class
