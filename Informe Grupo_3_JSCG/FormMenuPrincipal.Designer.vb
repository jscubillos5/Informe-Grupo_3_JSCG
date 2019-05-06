<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class _formMenuPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(_formMenuPrincipal))
        Me._menuStrip_formMenuPrincipal = New System.Windows.Forms.MenuStrip()
        Me._estudiantesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me._estudiantesRegistrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me._estudiantesActualizarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me._estudiantesEliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me._estudiantesConsultarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me._cursosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me._cursosRegistrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me._cursosActualizarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me._cursosEliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me._cursosConsultarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me._apoyoAcademicoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me._apoyoAcademicoProgramaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me._toolTip_formMenuPrincipal = New System.Windows.Forms.ToolTip(Me.components)
        Me._menuStrip_formMenuPrincipal.SuspendLayout()
        Me.SuspendLayout()
        '
        '_menuStrip_formMenuPrincipal
        '
        Me._menuStrip_formMenuPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me._estudiantesToolStripMenuItem, Me._cursosToolStripMenuItem, Me._apoyoAcademicoToolStripMenuItem})
        Me._menuStrip_formMenuPrincipal.Location = New System.Drawing.Point(0, 0)
        Me._menuStrip_formMenuPrincipal.Name = "_menuStrip_formMenuPrincipal"
        Me._menuStrip_formMenuPrincipal.Size = New System.Drawing.Size(564, 24)
        Me._menuStrip_formMenuPrincipal.TabIndex = 0
        '
        '_estudiantesToolStripMenuItem
        '
        Me._estudiantesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me._estudiantesRegistrarToolStripMenuItem, Me._estudiantesActualizarToolStripMenuItem, Me._estudiantesEliminarToolStripMenuItem, Me._estudiantesConsultarToolStripMenuItem})
        Me._estudiantesToolStripMenuItem.Name = "_estudiantesToolStripMenuItem"
        Me._estudiantesToolStripMenuItem.Size = New System.Drawing.Size(79, 20)
        Me._estudiantesToolStripMenuItem.Text = "Estudiantes"
        Me._estudiantesToolStripMenuItem.ToolTipText = "Menú principal del módulo de estudiantes"
        '
        '_estudiantesRegistrarToolStripMenuItem
        '
        Me._estudiantesRegistrarToolStripMenuItem.Name = "_estudiantesRegistrarToolStripMenuItem"
        Me._estudiantesRegistrarToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me._estudiantesRegistrarToolStripMenuItem.Text = "Registrar"
        Me._estudiantesRegistrarToolStripMenuItem.ToolTipText = "Permite registrar estudiantes nuevos"
        '
        '_estudiantesActualizarToolStripMenuItem
        '
        Me._estudiantesActualizarToolStripMenuItem.Name = "_estudiantesActualizarToolStripMenuItem"
        Me._estudiantesActualizarToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me._estudiantesActualizarToolStripMenuItem.Text = "Actualizar"
        Me._estudiantesActualizarToolStripMenuItem.ToolTipText = "Permite modificar a estudiantes antiguos"
        '
        '_estudiantesEliminarToolStripMenuItem
        '
        Me._estudiantesEliminarToolStripMenuItem.Name = "_estudiantesEliminarToolStripMenuItem"
        Me._estudiantesEliminarToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me._estudiantesEliminarToolStripMenuItem.Text = "Eliminar"
        Me._estudiantesEliminarToolStripMenuItem.ToolTipText = "Permite eliminar estudiantes"
        '
        '_estudiantesConsultarToolStripMenuItem
        '
        Me._estudiantesConsultarToolStripMenuItem.Name = "_estudiantesConsultarToolStripMenuItem"
        Me._estudiantesConsultarToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me._estudiantesConsultarToolStripMenuItem.Text = "Consultar"
        Me._estudiantesConsultarToolStripMenuItem.ToolTipText = "Permite buscar estudiantes"
        '
        '_cursosToolStripMenuItem
        '
        Me._cursosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me._cursosRegistrarToolStripMenuItem, Me._cursosActualizarToolStripMenuItem, Me._cursosEliminarToolStripMenuItem, Me._cursosConsultarToolStripMenuItem})
        Me._cursosToolStripMenuItem.Name = "_cursosToolStripMenuItem"
        Me._cursosToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me._cursosToolStripMenuItem.Text = "Cursos"
        Me._cursosToolStripMenuItem.ToolTipText = "Menú principal del módulo de cursos"
        '
        '_cursosRegistrarToolStripMenuItem
        '
        Me._cursosRegistrarToolStripMenuItem.Name = "_cursosRegistrarToolStripMenuItem"
        Me._cursosRegistrarToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me._cursosRegistrarToolStripMenuItem.Text = "Registrar"
        Me._cursosRegistrarToolStripMenuItem.ToolTipText = "Permite registrar cursos nuevos"
        '
        '_cursosActualizarToolStripMenuItem
        '
        Me._cursosActualizarToolStripMenuItem.Name = "_cursosActualizarToolStripMenuItem"
        Me._cursosActualizarToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me._cursosActualizarToolStripMenuItem.Text = "Actualizar"
        Me._cursosActualizarToolStripMenuItem.ToolTipText = "Permite modificar cursos, previamente registrados"
        '
        '_cursosEliminarToolStripMenuItem
        '
        Me._cursosEliminarToolStripMenuItem.Name = "_cursosEliminarToolStripMenuItem"
        Me._cursosEliminarToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me._cursosEliminarToolStripMenuItem.Text = "Eliminar"
        Me._cursosEliminarToolStripMenuItem.ToolTipText = "Permite eliminar cursos, previamente registrados"
        '
        '_cursosConsultarToolStripMenuItem
        '
        Me._cursosConsultarToolStripMenuItem.Name = "_cursosConsultarToolStripMenuItem"
        Me._cursosConsultarToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me._cursosConsultarToolStripMenuItem.Text = "Consultar"
        Me._cursosConsultarToolStripMenuItem.ToolTipText = "Permite buscar cursos"
        '
        '_apoyoAcademicoToolStripMenuItem
        '
        Me._apoyoAcademicoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me._apoyoAcademicoProgramaToolStripMenuItem})
        Me._apoyoAcademicoToolStripMenuItem.Name = "_apoyoAcademicoToolStripMenuItem"
        Me._apoyoAcademicoToolStripMenuItem.Size = New System.Drawing.Size(115, 20)
        Me._apoyoAcademicoToolStripMenuItem.Text = "Apoyo académico"
        Me._apoyoAcademicoToolStripMenuItem.ToolTipText = "Menú principal del módulo de apoyo académico"
        '
        '_apoyoAcademicoProgramaToolStripMenuItem
        '
        Me._apoyoAcademicoProgramaToolStripMenuItem.Name = "_apoyoAcademicoProgramaToolStripMenuItem"
        Me._apoyoAcademicoProgramaToolStripMenuItem.Size = New System.Drawing.Size(105, 22)
        Me._apoyoAcademicoProgramaToolStripMenuItem.Text = "Curso"
        Me._apoyoAcademicoProgramaToolStripMenuItem.ToolTipText = "Permite acceder a los apoyos académicos registrados en los cursos"
        '
        '_formMenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(564, 353)
        Me.Controls.Add(Me._menuStrip_formMenuPrincipal)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me._menuStrip_formMenuPrincipal
        Me.MaximizeBox = False
        Me.Name = "_formMenuPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Informe Grupo_3_JSCG"
        Me._menuStrip_formMenuPrincipal.ResumeLayout(False)
        Me._menuStrip_formMenuPrincipal.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents _menuStrip_formMenuPrincipal As MenuStrip
    Friend WithEvents _estudiantesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents _toolTip_formMenuPrincipal As ToolTip
    Friend WithEvents _estudiantesRegistrarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents _estudiantesActualizarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents _estudiantesEliminarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents _estudiantesConsultarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents _cursosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents _cursosRegistrarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents _cursosActualizarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents _cursosEliminarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents _cursosConsultarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents _apoyoAcademicoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents _apoyoAcademicoProgramaToolStripMenuItem As ToolStripMenuItem
End Class
