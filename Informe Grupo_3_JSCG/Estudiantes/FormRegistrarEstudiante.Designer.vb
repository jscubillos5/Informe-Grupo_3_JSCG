<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class _formRegistrarEstudiante
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(_formRegistrarEstudiante))
        Me._labelAyudaPrincipal_formRegistrarEstudiante = New System.Windows.Forms.Label()
        Me._labelNombres = New System.Windows.Forms.Label()
        Me._textBoxNombres = New System.Windows.Forms.TextBox()
        Me._textBoxApellidos = New System.Windows.Forms.TextBox()
        Me._labelApellidos = New System.Windows.Forms.Label()
        Me._labelTipoDocumento = New System.Windows.Forms.Label()
        Me._toolTip_formRegistrarEstudiante = New System.Windows.Forms.ToolTip(Me.components)
        Me._comboBoxTipoDocumento = New System.Windows.Forms.ComboBox()
        Me._textBoxNumeroDocumento = New System.Windows.Forms.TextBox()
        Me._textBoxDireccion = New System.Windows.Forms.TextBox()
        Me._maskedTextBoxTelefono = New System.Windows.Forms.MaskedTextBox()
        Me._comboBoxProgramaAcademico = New System.Windows.Forms.ComboBox()
        Me._comboBoxSemestre = New System.Windows.Forms.ComboBox()
        Me._buttonRegistrarEstudiante = New System.Windows.Forms.Button()
        Me._errorProvider_formRegistrarEstudiante = New System.Windows.Forms.ErrorProvider(Me.components)
        Me._labelNumeroDocumento = New System.Windows.Forms.Label()
        Me._labelDireccion = New System.Windows.Forms.Label()
        Me._labelTelefono = New System.Windows.Forms.Label()
        Me._labelProgramaAcademico = New System.Windows.Forms.Label()
        Me._labelSemestre = New System.Windows.Forms.Label()
        CType(Me._errorProvider_formRegistrarEstudiante, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_labelAyudaPrincipal_formRegistrarEstudiante
        '
        Me._labelAyudaPrincipal_formRegistrarEstudiante.AutoSize = True
        Me._labelAyudaPrincipal_formRegistrarEstudiante.Location = New System.Drawing.Point(68, 19)
        Me._labelAyudaPrincipal_formRegistrarEstudiante.Name = "_labelAyudaPrincipal_formRegistrarEstudiante"
        Me._labelAyudaPrincipal_formRegistrarEstudiante.Size = New System.Drawing.Size(481, 13)
        Me._labelAyudaPrincipal_formRegistrarEstudiante.TabIndex = 0
        Me._labelAyudaPrincipal_formRegistrarEstudiante.Text = "Bienvenido señor usuario en está pantalla, usted podra registrar los estudiantes " &
    "nuevos en el sistema"
        '
        '_labelNombres
        '
        Me._labelNombres.AutoSize = True
        Me._labelNombres.Location = New System.Drawing.Point(12, 63)
        Me._labelNombres.Name = "_labelNombres"
        Me._labelNombres.Size = New System.Drawing.Size(59, 13)
        Me._labelNombres.TabIndex = 1
        Me._labelNombres.Text = "Nombres(*)"
        '
        '_textBoxNombres
        '
        Me._textBoxNombres.Location = New System.Drawing.Point(135, 56)
        Me._textBoxNombres.Name = "_textBoxNombres"
        Me._textBoxNombres.Size = New System.Drawing.Size(469, 20)
        Me._textBoxNombres.TabIndex = 0
        Me._toolTip_formRegistrarEstudiante.SetToolTip(Me._textBoxNombres, "Por favor digite los nombres del estudiante")
        '
        '_textBoxApellidos
        '
        Me._textBoxApellidos.Location = New System.Drawing.Point(135, 92)
        Me._textBoxApellidos.Name = "_textBoxApellidos"
        Me._textBoxApellidos.Size = New System.Drawing.Size(469, 20)
        Me._textBoxApellidos.TabIndex = 1
        Me._toolTip_formRegistrarEstudiante.SetToolTip(Me._textBoxApellidos, "Por favor digite los apellidos del estudiante")
        '
        '_labelApellidos
        '
        Me._labelApellidos.AutoSize = True
        Me._labelApellidos.Location = New System.Drawing.Point(12, 99)
        Me._labelApellidos.Name = "_labelApellidos"
        Me._labelApellidos.Size = New System.Drawing.Size(59, 13)
        Me._labelApellidos.TabIndex = 3
        Me._labelApellidos.Text = "Apellidos(*)"
        '
        '_labelTipoDocumento
        '
        Me._labelTipoDocumento.AutoSize = True
        Me._labelTipoDocumento.Location = New System.Drawing.Point(12, 133)
        Me._labelTipoDocumento.Name = "_labelTipoDocumento"
        Me._labelTipoDocumento.Size = New System.Drawing.Size(94, 13)
        Me._labelTipoDocumento.TabIndex = 5
        Me._labelTipoDocumento.Text = "Tipo documento(*)"
        '
        '_comboBoxTipoDocumento
        '
        Me._comboBoxTipoDocumento.FormattingEnabled = True
        Me._comboBoxTipoDocumento.Location = New System.Drawing.Point(135, 125)
        Me._comboBoxTipoDocumento.Name = "_comboBoxTipoDocumento"
        Me._comboBoxTipoDocumento.Size = New System.Drawing.Size(193, 21)
        Me._comboBoxTipoDocumento.TabIndex = 2
        Me._toolTip_formRegistrarEstudiante.SetToolTip(Me._comboBoxTipoDocumento, "Por favor seleccione el tipo de documento del estudiante")
        '
        '_textBoxNumeroDocumento
        '
        Me._textBoxNumeroDocumento.Location = New System.Drawing.Point(469, 126)
        Me._textBoxNumeroDocumento.Name = "_textBoxNumeroDocumento"
        Me._textBoxNumeroDocumento.Size = New System.Drawing.Size(135, 20)
        Me._textBoxNumeroDocumento.TabIndex = 3
        Me._toolTip_formRegistrarEstudiante.SetToolTip(Me._textBoxNumeroDocumento, "Por favor digite el número de documento del estudiante")
        '
        '_textBoxDireccion
        '
        Me._textBoxDireccion.Location = New System.Drawing.Point(135, 161)
        Me._textBoxDireccion.Name = "_textBoxDireccion"
        Me._textBoxDireccion.Size = New System.Drawing.Size(193, 20)
        Me._textBoxDireccion.TabIndex = 4
        Me._toolTip_formRegistrarEstudiante.SetToolTip(Me._textBoxDireccion, "Por favor digite la dirección del estudiante")
        '
        '_maskedTextBoxTelefono
        '
        Me._maskedTextBoxTelefono.Location = New System.Drawing.Point(469, 161)
        Me._maskedTextBoxTelefono.Name = "_maskedTextBoxTelefono"
        Me._maskedTextBoxTelefono.Size = New System.Drawing.Size(135, 20)
        Me._maskedTextBoxTelefono.TabIndex = 5
        Me._toolTip_formRegistrarEstudiante.SetToolTip(Me._maskedTextBoxTelefono, "Por favor digite el teléfono del estudiante")
        '
        '_comboBoxProgramaAcademico
        '
        Me._comboBoxProgramaAcademico.FormattingEnabled = True
        Me._comboBoxProgramaAcademico.Location = New System.Drawing.Point(135, 197)
        Me._comboBoxProgramaAcademico.Name = "_comboBoxProgramaAcademico"
        Me._comboBoxProgramaAcademico.Size = New System.Drawing.Size(193, 21)
        Me._comboBoxProgramaAcademico.TabIndex = 6
        Me._toolTip_formRegistrarEstudiante.SetToolTip(Me._comboBoxProgramaAcademico, "Por favor seleccione el programa académico del estudiante")
        '
        '_comboBoxSemestre
        '
        Me._comboBoxSemestre.FormattingEnabled = True
        Me._comboBoxSemestre.Location = New System.Drawing.Point(469, 197)
        Me._comboBoxSemestre.Name = "_comboBoxSemestre"
        Me._comboBoxSemestre.Size = New System.Drawing.Size(135, 21)
        Me._comboBoxSemestre.TabIndex = 7
        Me._toolTip_formRegistrarEstudiante.SetToolTip(Me._comboBoxSemestre, "Por favor seleccione el semestre del estudiante")
        '
        '_buttonRegistrarEstudiante
        '
        Me._buttonRegistrarEstudiante.Location = New System.Drawing.Point(271, 252)
        Me._buttonRegistrarEstudiante.Name = "_buttonRegistrarEstudiante"
        Me._buttonRegistrarEstudiante.Size = New System.Drawing.Size(75, 23)
        Me._buttonRegistrarEstudiante.TabIndex = 8
        Me._buttonRegistrarEstudiante.Text = "&Registrar"
        Me._toolTip_formRegistrarEstudiante.SetToolTip(Me._buttonRegistrarEstudiante, "Pulse para registrar un nuevo estudiante")
        Me._buttonRegistrarEstudiante.UseVisualStyleBackColor = True
        '
        '_errorProvider_formRegistrarEstudiante
        '
        Me._errorProvider_formRegistrarEstudiante.ContainerControl = Me
        '
        '_labelNumeroDocumento
        '
        Me._labelNumeroDocumento.AutoSize = True
        Me._labelNumeroDocumento.Location = New System.Drawing.Point(353, 133)
        Me._labelNumeroDocumento.Name = "_labelNumeroDocumento"
        Me._labelNumeroDocumento.Size = New System.Drawing.Size(110, 13)
        Me._labelNumeroDocumento.TabIndex = 7
        Me._labelNumeroDocumento.Text = "Número documento(*)"
        '
        '_labelDireccion
        '
        Me._labelDireccion.AutoSize = True
        Me._labelDireccion.Location = New System.Drawing.Point(12, 168)
        Me._labelDireccion.Name = "_labelDireccion"
        Me._labelDireccion.Size = New System.Drawing.Size(52, 13)
        Me._labelDireccion.TabIndex = 9
        Me._labelDireccion.Text = "Dirección"
        '
        '_labelTelefono
        '
        Me._labelTelefono.AutoSize = True
        Me._labelTelefono.Location = New System.Drawing.Point(353, 168)
        Me._labelTelefono.Name = "_labelTelefono"
        Me._labelTelefono.Size = New System.Drawing.Size(49, 13)
        Me._labelTelefono.TabIndex = 11
        Me._labelTelefono.Text = "Teléfono"
        '
        '_labelProgramaAcademico
        '
        Me._labelProgramaAcademico.AutoSize = True
        Me._labelProgramaAcademico.Location = New System.Drawing.Point(12, 205)
        Me._labelProgramaAcademico.Name = "_labelProgramaAcademico"
        Me._labelProgramaAcademico.Size = New System.Drawing.Size(117, 13)
        Me._labelProgramaAcademico.TabIndex = 14
        Me._labelProgramaAcademico.Text = "Programa académico(*)"
        '
        '_labelSemestre
        '
        Me._labelSemestre.AutoSize = True
        Me._labelSemestre.Location = New System.Drawing.Point(353, 205)
        Me._labelSemestre.Name = "_labelSemestre"
        Me._labelSemestre.Size = New System.Drawing.Size(61, 13)
        Me._labelSemestre.TabIndex = 16
        Me._labelSemestre.Text = "Semestre(*)"
        '
        '_formRegistrarEstudiante
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(616, 283)
        Me.Controls.Add(Me._buttonRegistrarEstudiante)
        Me.Controls.Add(Me._comboBoxSemestre)
        Me.Controls.Add(Me._labelSemestre)
        Me.Controls.Add(Me._comboBoxProgramaAcademico)
        Me.Controls.Add(Me._labelProgramaAcademico)
        Me.Controls.Add(Me._maskedTextBoxTelefono)
        Me.Controls.Add(Me._labelTelefono)
        Me.Controls.Add(Me._textBoxDireccion)
        Me.Controls.Add(Me._labelDireccion)
        Me.Controls.Add(Me._textBoxNumeroDocumento)
        Me.Controls.Add(Me._labelNumeroDocumento)
        Me.Controls.Add(Me._comboBoxTipoDocumento)
        Me.Controls.Add(Me._labelTipoDocumento)
        Me.Controls.Add(Me._textBoxApellidos)
        Me.Controls.Add(Me._labelApellidos)
        Me.Controls.Add(Me._textBoxNombres)
        Me.Controls.Add(Me._labelNombres)
        Me.Controls.Add(Me._labelAyudaPrincipal_formRegistrarEstudiante)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "_formRegistrarEstudiante"
        Me.Text = "Registrar Estudiante"
        CType(Me._errorProvider_formRegistrarEstudiante, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents _labelAyudaPrincipal_formRegistrarEstudiante As Label
    Friend WithEvents _labelNombres As Label
    Friend WithEvents _textBoxNombres As TextBox
    Friend WithEvents _textBoxApellidos As TextBox
    Friend WithEvents _labelApellidos As Label
    Friend WithEvents _labelTipoDocumento As Label
    Friend WithEvents _toolTip_formRegistrarEstudiante As ToolTip
    Friend WithEvents _comboBoxTipoDocumento As ComboBox
    Friend WithEvents _errorProvider_formRegistrarEstudiante As ErrorProvider
    Friend WithEvents _labelNumeroDocumento As Label
    Friend WithEvents _textBoxNumeroDocumento As TextBox
    Friend WithEvents _labelDireccion As Label
    Friend WithEvents _textBoxDireccion As TextBox
    Friend WithEvents _labelTelefono As Label
    Friend WithEvents _maskedTextBoxTelefono As MaskedTextBox
    Friend WithEvents _labelProgramaAcademico As Label
    Friend WithEvents _comboBoxProgramaAcademico As ComboBox
    Friend WithEvents _comboBoxSemestre As ComboBox
    Friend WithEvents _labelSemestre As Label
    Friend WithEvents _buttonRegistrarEstudiante As Button
End Class
