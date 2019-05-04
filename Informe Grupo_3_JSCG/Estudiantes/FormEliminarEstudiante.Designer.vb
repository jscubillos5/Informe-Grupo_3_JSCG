<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class _formEliminarEstudiante
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(_formEliminarEstudiante))
        Me._labelAyudaPrincipal_formEliminarEstudiante = New System.Windows.Forms.Label()
        Me._toolTip_formEliminarEstudiante = New System.Windows.Forms.ToolTip(Me.components)
        Me._errorProvider_formEliminarEstudiante = New System.Windows.Forms.ErrorProvider(Me.components)
        Me._buttonEliminarEstudiante = New System.Windows.Forms.Button()
        Me._textBoxNumeroDocumento = New System.Windows.Forms.TextBox()
        Me._labelNumeroDocumento = New System.Windows.Forms.Label()
        Me._comboBoxTipoDocumento = New System.Windows.Forms.ComboBox()
        Me._labelTipoDocumento = New System.Windows.Forms.Label()
        CType(Me._errorProvider_formEliminarEstudiante, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_labelAyudaPrincipal_formEliminarEstudiante
        '
        Me._labelAyudaPrincipal_formEliminarEstudiante.AutoSize = True
        Me._labelAyudaPrincipal_formEliminarEstudiante.Location = New System.Drawing.Point(94, 15)
        Me._labelAyudaPrincipal_formEliminarEstudiante.Name = "_labelAyudaPrincipal_formEliminarEstudiante"
        Me._labelAyudaPrincipal_formEliminarEstudiante.Size = New System.Drawing.Size(432, 13)
        Me._labelAyudaPrincipal_formEliminarEstudiante.TabIndex = 3
        Me._labelAyudaPrincipal_formEliminarEstudiante.Text = "Bienvenido señor usuario en está pantalla, usted podra eliminar los estudiantes d" &
    "el sistema"
        '
        '_errorProvider_formEliminarEstudiante
        '
        Me._errorProvider_formEliminarEstudiante.ContainerControl = Me
        '
        '_buttonEliminarEstudiante
        '
        Me._buttonEliminarEstudiante.Location = New System.Drawing.Point(274, 91)
        Me._buttonEliminarEstudiante.Name = "_buttonEliminarEstudiante"
        Me._buttonEliminarEstudiante.Size = New System.Drawing.Size(75, 23)
        Me._buttonEliminarEstudiante.TabIndex = 2
        Me._buttonEliminarEstudiante.Text = "&Eliminar"
        Me._toolTip_formEliminarEstudiante.SetToolTip(Me._buttonEliminarEstudiante, "Pulse para eliminar un estudiante")
        Me._buttonEliminarEstudiante.UseVisualStyleBackColor = True
        '
        '_textBoxNumeroDocumento
        '
        Me._textBoxNumeroDocumento.Location = New System.Drawing.Point(476, 48)
        Me._textBoxNumeroDocumento.Name = "_textBoxNumeroDocumento"
        Me._textBoxNumeroDocumento.Size = New System.Drawing.Size(135, 20)
        Me._textBoxNumeroDocumento.TabIndex = 1
        Me._toolTip_formEliminarEstudiante.SetToolTip(Me._textBoxNumeroDocumento, "Por favor digite el número de documento del estudiante para realizar una busqueda" &
        "")
        '
        '_labelNumeroDocumento
        '
        Me._labelNumeroDocumento.AutoSize = True
        Me._labelNumeroDocumento.Location = New System.Drawing.Point(360, 55)
        Me._labelNumeroDocumento.Name = "_labelNumeroDocumento"
        Me._labelNumeroDocumento.Size = New System.Drawing.Size(110, 13)
        Me._labelNumeroDocumento.TabIndex = 15
        Me._labelNumeroDocumento.Text = "Número documento(*)"
        '
        '_comboBoxTipoDocumento
        '
        Me._comboBoxTipoDocumento.FormattingEnabled = True
        Me._comboBoxTipoDocumento.Location = New System.Drawing.Point(142, 47)
        Me._comboBoxTipoDocumento.Name = "_comboBoxTipoDocumento"
        Me._comboBoxTipoDocumento.Size = New System.Drawing.Size(193, 21)
        Me._comboBoxTipoDocumento.TabIndex = 0
        Me._toolTip_formEliminarEstudiante.SetToolTip(Me._comboBoxTipoDocumento, "Por favor seleccione el tipo de documento del estudiante para realizar una busque" &
        "da")
        '
        '_labelTipoDocumento
        '
        Me._labelTipoDocumento.AutoSize = True
        Me._labelTipoDocumento.Location = New System.Drawing.Point(19, 55)
        Me._labelTipoDocumento.Name = "_labelTipoDocumento"
        Me._labelTipoDocumento.Size = New System.Drawing.Size(94, 13)
        Me._labelTipoDocumento.TabIndex = 14
        Me._labelTipoDocumento.Text = "Tipo documento(*)"
        '
        '_formEliminarEstudiante
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(620, 126)
        Me.Controls.Add(Me._textBoxNumeroDocumento)
        Me.Controls.Add(Me._labelNumeroDocumento)
        Me.Controls.Add(Me._comboBoxTipoDocumento)
        Me.Controls.Add(Me._labelTipoDocumento)
        Me.Controls.Add(Me._buttonEliminarEstudiante)
        Me.Controls.Add(Me._labelAyudaPrincipal_formEliminarEstudiante)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "_formEliminarEstudiante"
        Me.Text = "Eliminar Estudiante"
        CType(Me._errorProvider_formEliminarEstudiante, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents _labelAyudaPrincipal_formEliminarEstudiante As Label
    Friend WithEvents _toolTip_formEliminarEstudiante As ToolTip
    Friend WithEvents _errorProvider_formEliminarEstudiante As ErrorProvider
    Friend WithEvents _buttonEliminarEstudiante As Button
    Friend WithEvents _textBoxNumeroDocumento As TextBox
    Friend WithEvents _labelNumeroDocumento As Label
    Friend WithEvents _comboBoxTipoDocumento As ComboBox
    Friend WithEvents _labelTipoDocumento As Label
End Class
