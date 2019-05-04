<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _formActualizarEstudiante
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(_formActualizarEstudiante))
        Me._panelSuperior = New System.Windows.Forms.Panel()
        Me._labelAyudaPrincipal_formActualizarEstudiante = New System.Windows.Forms.Label()
        Me._panelBuscarEstudiante = New System.Windows.Forms.Panel()
        Me._panelInferior = New System.Windows.Forms.Panel()
        Me._panelDatosEstudiante = New System.Windows.Forms.Panel()
        Me._textBoxNumeroDocumento = New System.Windows.Forms.TextBox()
        Me._labelNumeroDocumento = New System.Windows.Forms.Label()
        Me._comboBoxTipoDocumento = New System.Windows.Forms.ComboBox()
        Me._labelTipoDocumento = New System.Windows.Forms.Label()
        Me._buttonActualizarEstudiante = New System.Windows.Forms.Button()
        Me._toolTip_formActualizarEstudiante = New System.Windows.Forms.ToolTip(Me.components)
        Me._errorProvider_formActualizarEstudiante = New System.Windows.Forms.ErrorProvider(Me.components)
        Me._buttonBuscar = New System.Windows.Forms.Button()
        Me._comboBoxSemestre = New System.Windows.Forms.ComboBox()
        Me._labelSemestre = New System.Windows.Forms.Label()
        Me._comboBoxProgramaAcademico = New System.Windows.Forms.ComboBox()
        Me._labelProgramaAcademico = New System.Windows.Forms.Label()
        Me._maskedTextBoxTelefono = New System.Windows.Forms.MaskedTextBox()
        Me._labelTelefono = New System.Windows.Forms.Label()
        Me._textBoxDireccion = New System.Windows.Forms.TextBox()
        Me._labelDireccion = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me._textBoxApellidos = New System.Windows.Forms.TextBox()
        Me._labelApellidos = New System.Windows.Forms.Label()
        Me._textBoxNombres = New System.Windows.Forms.TextBox()
        Me._labelNombres = New System.Windows.Forms.Label()
        Me._panelSuperior.SuspendLayout()
        Me._panelBuscarEstudiante.SuspendLayout()
        Me._panelInferior.SuspendLayout()
        Me._panelDatosEstudiante.SuspendLayout()
        CType(Me._errorProvider_formActualizarEstudiante, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_panelSuperior
        '
        Me._panelSuperior.Controls.Add(Me._labelAyudaPrincipal_formActualizarEstudiante)
        Me._panelSuperior.Dock = System.Windows.Forms.DockStyle.Top
        Me._panelSuperior.Location = New System.Drawing.Point(0, 0)
        Me._panelSuperior.Name = "_panelSuperior"
        Me._panelSuperior.Size = New System.Drawing.Size(668, 57)
        Me._panelSuperior.TabIndex = 2
        '
        '_labelAyudaPrincipal_formActualizarEstudiante
        '
        Me._labelAyudaPrincipal_formActualizarEstudiante.AutoSize = True
        Me._labelAyudaPrincipal_formActualizarEstudiante.Location = New System.Drawing.Point(115, 20)
        Me._labelAyudaPrincipal_formActualizarEstudiante.Name = "_labelAyudaPrincipal_formActualizarEstudiante"
        Me._labelAyudaPrincipal_formActualizarEstudiante.Size = New System.Drawing.Size(439, 13)
        Me._labelAyudaPrincipal_formActualizarEstudiante.TabIndex = 0
        Me._labelAyudaPrincipal_formActualizarEstudiante.Text = "Bienvenido señor usuario en está pantalla, usted podra modificar los estudiantes " &
    "del sistema"
        '
        '_panelBuscarEstudiante
        '
        Me._panelBuscarEstudiante.Controls.Add(Me._buttonBuscar)
        Me._panelBuscarEstudiante.Controls.Add(Me._textBoxNumeroDocumento)
        Me._panelBuscarEstudiante.Controls.Add(Me._labelNumeroDocumento)
        Me._panelBuscarEstudiante.Controls.Add(Me._comboBoxTipoDocumento)
        Me._panelBuscarEstudiante.Controls.Add(Me._labelTipoDocumento)
        Me._panelBuscarEstudiante.Dock = System.Windows.Forms.DockStyle.Top
        Me._panelBuscarEstudiante.Location = New System.Drawing.Point(0, 57)
        Me._panelBuscarEstudiante.Name = "_panelBuscarEstudiante"
        Me._panelBuscarEstudiante.Size = New System.Drawing.Size(668, 69)
        Me._panelBuscarEstudiante.TabIndex = 3
        '
        '_panelInferior
        '
        Me._panelInferior.Controls.Add(Me._buttonActualizarEstudiante)
        Me._panelInferior.Dock = System.Windows.Forms.DockStyle.Bottom
        Me._panelInferior.Location = New System.Drawing.Point(0, 334)
        Me._panelInferior.Name = "_panelInferior"
        Me._panelInferior.Size = New System.Drawing.Size(668, 43)
        Me._panelInferior.TabIndex = 4
        '
        '_panelDatosEstudiante
        '
        Me._panelDatosEstudiante.Controls.Add(Me._comboBoxSemestre)
        Me._panelDatosEstudiante.Controls.Add(Me._labelSemestre)
        Me._panelDatosEstudiante.Controls.Add(Me._comboBoxProgramaAcademico)
        Me._panelDatosEstudiante.Controls.Add(Me._labelProgramaAcademico)
        Me._panelDatosEstudiante.Controls.Add(Me._maskedTextBoxTelefono)
        Me._panelDatosEstudiante.Controls.Add(Me._labelTelefono)
        Me._panelDatosEstudiante.Controls.Add(Me._textBoxDireccion)
        Me._panelDatosEstudiante.Controls.Add(Me._labelDireccion)
        Me._panelDatosEstudiante.Controls.Add(Me.TextBox1)
        Me._panelDatosEstudiante.Controls.Add(Me.Label1)
        Me._panelDatosEstudiante.Controls.Add(Me.ComboBox1)
        Me._panelDatosEstudiante.Controls.Add(Me.Label2)
        Me._panelDatosEstudiante.Controls.Add(Me._textBoxApellidos)
        Me._panelDatosEstudiante.Controls.Add(Me._labelApellidos)
        Me._panelDatosEstudiante.Controls.Add(Me._textBoxNombres)
        Me._panelDatosEstudiante.Controls.Add(Me._labelNombres)
        Me._panelDatosEstudiante.Dock = System.Windows.Forms.DockStyle.Fill
        Me._panelDatosEstudiante.Enabled = False
        Me._panelDatosEstudiante.Location = New System.Drawing.Point(0, 126)
        Me._panelDatosEstudiante.Name = "_panelDatosEstudiante"
        Me._panelDatosEstudiante.Size = New System.Drawing.Size(668, 208)
        Me._panelDatosEstudiante.TabIndex = 5
        '
        '_textBoxNumeroDocumento
        '
        Me._textBoxNumeroDocumento.Location = New System.Drawing.Point(495, 9)
        Me._textBoxNumeroDocumento.Name = "_textBoxNumeroDocumento"
        Me._textBoxNumeroDocumento.Size = New System.Drawing.Size(135, 20)
        Me._textBoxNumeroDocumento.TabIndex = 1
        Me._toolTip_formActualizarEstudiante.SetToolTip(Me._textBoxNumeroDocumento, "Por favor digite el número de documento del estudiante para realizar una busqueda" &
        "")
        '
        '_labelNumeroDocumento
        '
        Me._labelNumeroDocumento.AutoSize = True
        Me._labelNumeroDocumento.Location = New System.Drawing.Point(379, 16)
        Me._labelNumeroDocumento.Name = "_labelNumeroDocumento"
        Me._labelNumeroDocumento.Size = New System.Drawing.Size(110, 13)
        Me._labelNumeroDocumento.TabIndex = 11
        Me._labelNumeroDocumento.Text = "Número documento(*)"
        '
        '_comboBoxTipoDocumento
        '
        Me._comboBoxTipoDocumento.FormattingEnabled = True
        Me._comboBoxTipoDocumento.Location = New System.Drawing.Point(161, 8)
        Me._comboBoxTipoDocumento.Name = "_comboBoxTipoDocumento"
        Me._comboBoxTipoDocumento.Size = New System.Drawing.Size(193, 21)
        Me._comboBoxTipoDocumento.TabIndex = 0
        Me._toolTip_formActualizarEstudiante.SetToolTip(Me._comboBoxTipoDocumento, "Por favor seleccione el tipo de documento del estudiante para realizar una busque" &
        "da")
        '
        '_labelTipoDocumento
        '
        Me._labelTipoDocumento.AutoSize = True
        Me._labelTipoDocumento.Location = New System.Drawing.Point(38, 16)
        Me._labelTipoDocumento.Name = "_labelTipoDocumento"
        Me._labelTipoDocumento.Size = New System.Drawing.Size(94, 13)
        Me._labelTipoDocumento.TabIndex = 10
        Me._labelTipoDocumento.Text = "Tipo documento(*)"
        '
        '_buttonActualizarEstudiante
        '
        Me._buttonActualizarEstudiante.Location = New System.Drawing.Point(297, 10)
        Me._buttonActualizarEstudiante.Name = "_buttonActualizarEstudiante"
        Me._buttonActualizarEstudiante.Size = New System.Drawing.Size(75, 23)
        Me._buttonActualizarEstudiante.TabIndex = 0
        Me._buttonActualizarEstudiante.Text = "&Actualizar"
        Me._toolTip_formActualizarEstudiante.SetToolTip(Me._buttonActualizarEstudiante, "Pulse para actualizar un estudiante")
        Me._buttonActualizarEstudiante.UseVisualStyleBackColor = True
        '
        '_errorProvider_formActualizarEstudiante
        '
        Me._errorProvider_formActualizarEstudiante.ContainerControl = Me
        '
        '_buttonBuscar
        '
        Me._buttonBuscar.Location = New System.Drawing.Point(297, 40)
        Me._buttonBuscar.Name = "_buttonBuscar"
        Me._buttonBuscar.Size = New System.Drawing.Size(75, 23)
        Me._buttonBuscar.TabIndex = 2
        Me._buttonBuscar.Text = "&Buscar"
        Me._toolTip_formActualizarEstudiante.SetToolTip(Me._buttonBuscar, "Pulse para buscar un estudiante")
        Me._buttonBuscar.UseVisualStyleBackColor = True
        '
        '_comboBoxSemestre
        '
        Me._comboBoxSemestre.FormattingEnabled = True
        Me._comboBoxSemestre.Location = New System.Drawing.Point(495, 160)
        Me._comboBoxSemestre.Name = "_comboBoxSemestre"
        Me._comboBoxSemestre.Size = New System.Drawing.Size(135, 21)
        Me._comboBoxSemestre.TabIndex = 7
        Me._toolTip_formActualizarEstudiante.SetToolTip(Me._comboBoxSemestre, "Por favor seleccione el semestre del estudiante")
        '
        '_labelSemestre
        '
        Me._labelSemestre.AutoSize = True
        Me._labelSemestre.Location = New System.Drawing.Point(379, 168)
        Me._labelSemestre.Name = "_labelSemestre"
        Me._labelSemestre.Size = New System.Drawing.Size(61, 13)
        Me._labelSemestre.TabIndex = 32
        Me._labelSemestre.Text = "Semestre(*)"
        '
        '_comboBoxProgramaAcademico
        '
        Me._comboBoxProgramaAcademico.FormattingEnabled = True
        Me._comboBoxProgramaAcademico.Location = New System.Drawing.Point(161, 160)
        Me._comboBoxProgramaAcademico.Name = "_comboBoxProgramaAcademico"
        Me._comboBoxProgramaAcademico.Size = New System.Drawing.Size(193, 21)
        Me._comboBoxProgramaAcademico.TabIndex = 6
        Me._toolTip_formActualizarEstudiante.SetToolTip(Me._comboBoxProgramaAcademico, "Por favor seleccione el programa académico del estudiante")
        '
        '_labelProgramaAcademico
        '
        Me._labelProgramaAcademico.AutoSize = True
        Me._labelProgramaAcademico.Location = New System.Drawing.Point(38, 168)
        Me._labelProgramaAcademico.Name = "_labelProgramaAcademico"
        Me._labelProgramaAcademico.Size = New System.Drawing.Size(117, 13)
        Me._labelProgramaAcademico.TabIndex = 31
        Me._labelProgramaAcademico.Text = "Programa académico(*)"
        '
        '_maskedTextBoxTelefono
        '
        Me._maskedTextBoxTelefono.Location = New System.Drawing.Point(495, 124)
        Me._maskedTextBoxTelefono.Name = "_maskedTextBoxTelefono"
        Me._maskedTextBoxTelefono.Size = New System.Drawing.Size(135, 20)
        Me._maskedTextBoxTelefono.TabIndex = 5
        Me._toolTip_formActualizarEstudiante.SetToolTip(Me._maskedTextBoxTelefono, "Por favor digite el teléfono del estudiante")
        '
        '_labelTelefono
        '
        Me._labelTelefono.AutoSize = True
        Me._labelTelefono.Location = New System.Drawing.Point(379, 131)
        Me._labelTelefono.Name = "_labelTelefono"
        Me._labelTelefono.Size = New System.Drawing.Size(49, 13)
        Me._labelTelefono.TabIndex = 30
        Me._labelTelefono.Text = "Teléfono"
        '
        '_textBoxDireccion
        '
        Me._textBoxDireccion.Location = New System.Drawing.Point(161, 124)
        Me._textBoxDireccion.Name = "_textBoxDireccion"
        Me._textBoxDireccion.Size = New System.Drawing.Size(193, 20)
        Me._textBoxDireccion.TabIndex = 4
        Me._toolTip_formActualizarEstudiante.SetToolTip(Me._textBoxDireccion, "Por favor digite la dirección del estudiante")
        '
        '_labelDireccion
        '
        Me._labelDireccion.AutoSize = True
        Me._labelDireccion.Location = New System.Drawing.Point(38, 131)
        Me._labelDireccion.Name = "_labelDireccion"
        Me._labelDireccion.Size = New System.Drawing.Size(52, 13)
        Me._labelDireccion.TabIndex = 29
        Me._labelDireccion.Text = "Dirección"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(495, 89)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(135, 20)
        Me.TextBox1.TabIndex = 3
        Me._toolTip_formActualizarEstudiante.SetToolTip(Me.TextBox1, "Por favor digite el número de documento del estudiante")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(379, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 13)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Número documento(*)"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(161, 88)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(193, 21)
        Me.ComboBox1.TabIndex = 2
        Me._toolTip_formActualizarEstudiante.SetToolTip(Me.ComboBox1, "Por favor seleccione el tipo de documento del estudiante")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(38, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 13)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Tipo documento(*)"
        '
        '_textBoxApellidos
        '
        Me._textBoxApellidos.Location = New System.Drawing.Point(161, 55)
        Me._textBoxApellidos.Name = "_textBoxApellidos"
        Me._textBoxApellidos.Size = New System.Drawing.Size(469, 20)
        Me._textBoxApellidos.TabIndex = 1
        Me._toolTip_formActualizarEstudiante.SetToolTip(Me._textBoxApellidos, "Por favor digite los apellidos del estudiante")
        '
        '_labelApellidos
        '
        Me._labelApellidos.AutoSize = True
        Me._labelApellidos.Location = New System.Drawing.Point(38, 62)
        Me._labelApellidos.Name = "_labelApellidos"
        Me._labelApellidos.Size = New System.Drawing.Size(59, 13)
        Me._labelApellidos.TabIndex = 22
        Me._labelApellidos.Text = "Apellidos(*)"
        '
        '_textBoxNombres
        '
        Me._textBoxNombres.Location = New System.Drawing.Point(161, 19)
        Me._textBoxNombres.Name = "_textBoxNombres"
        Me._textBoxNombres.Size = New System.Drawing.Size(469, 20)
        Me._textBoxNombres.TabIndex = 0
        Me._toolTip_formActualizarEstudiante.SetToolTip(Me._textBoxNombres, "Por favor digite los nombres del estudiante")
        '
        '_labelNombres
        '
        Me._labelNombres.AutoSize = True
        Me._labelNombres.Location = New System.Drawing.Point(38, 26)
        Me._labelNombres.Name = "_labelNombres"
        Me._labelNombres.Size = New System.Drawing.Size(59, 13)
        Me._labelNombres.TabIndex = 19
        Me._labelNombres.Text = "Nombres(*)"
        '
        '_formActualizarEstudiante
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(668, 377)
        Me.Controls.Add(Me._panelDatosEstudiante)
        Me.Controls.Add(Me._panelInferior)
        Me.Controls.Add(Me._panelBuscarEstudiante)
        Me.Controls.Add(Me._panelSuperior)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "_formActualizarEstudiante"
        Me.Text = "Actualizar Estudiante"
        Me._panelSuperior.ResumeLayout(False)
        Me._panelSuperior.PerformLayout()
        Me._panelBuscarEstudiante.ResumeLayout(False)
        Me._panelBuscarEstudiante.PerformLayout()
        Me._panelInferior.ResumeLayout(False)
        Me._panelDatosEstudiante.ResumeLayout(False)
        Me._panelDatosEstudiante.PerformLayout()
        CType(Me._errorProvider_formActualizarEstudiante, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents _panelSuperior As Panel
    Friend WithEvents _labelAyudaPrincipal_formActualizarEstudiante As Label
    Friend WithEvents _panelBuscarEstudiante As Panel
    Friend WithEvents _panelInferior As Panel
    Friend WithEvents _panelDatosEstudiante As Panel
    Friend WithEvents _textBoxNumeroDocumento As TextBox
    Friend WithEvents _labelNumeroDocumento As Label
    Friend WithEvents _comboBoxTipoDocumento As ComboBox
    Friend WithEvents _labelTipoDocumento As Label
    Friend WithEvents _buttonActualizarEstudiante As Button
    Friend WithEvents _toolTip_formActualizarEstudiante As ToolTip
    Friend WithEvents _errorProvider_formActualizarEstudiante As ErrorProvider
    Friend WithEvents _buttonBuscar As Button
    Friend WithEvents _comboBoxSemestre As ComboBox
    Friend WithEvents _labelSemestre As Label
    Friend WithEvents _comboBoxProgramaAcademico As ComboBox
    Friend WithEvents _labelProgramaAcademico As Label
    Friend WithEvents _maskedTextBoxTelefono As MaskedTextBox
    Friend WithEvents _labelTelefono As Label
    Friend WithEvents _textBoxDireccion As TextBox
    Friend WithEvents _labelDireccion As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents _textBoxApellidos As TextBox
    Friend WithEvents _labelApellidos As Label
    Friend WithEvents _textBoxNombres As TextBox
    Friend WithEvents _labelNombres As Label
End Class
