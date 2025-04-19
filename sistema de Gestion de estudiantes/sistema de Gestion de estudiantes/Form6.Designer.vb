<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.seccionActual = New System.Windows.Forms.Label()
        Me.gradoActual = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.profesores_grado = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ProfesorgradoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Escuela_BDDataSet = New WindowsApplication1.escuela_BDDataSet()
        Me.Profesor_gradoTableAdapter = New WindowsApplication1.escuela_BDDataSetTableAdapters.Profesor_gradoTableAdapter()
        CType(Me.profesores_grado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProfesorgradoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Escuela_BDDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'seccionActual
        '
        Me.seccionActual.AutoSize = True
        Me.seccionActual.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.seccionActual.Location = New System.Drawing.Point(278, 46)
        Me.seccionActual.Name = "seccionActual"
        Me.seccionActual.Size = New System.Drawing.Size(19, 20)
        Me.seccionActual.TabIndex = 6
        Me.seccionActual.Text = "a"
        '
        'gradoActual
        '
        Me.gradoActual.AutoSize = True
        Me.gradoActual.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gradoActual.Location = New System.Drawing.Point(262, 46)
        Me.gradoActual.Name = "gradoActual"
        Me.gradoActual.Size = New System.Drawing.Size(19, 20)
        Me.gradoActual.TabIndex = 5
        Me.gradoActual.Text = "1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(63, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(197, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Grado y seccion actual:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(299, 134)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(191, 20)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Profesores disponibles"
        '
        'profesores_grado
        '
        Me.profesores_grado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.profesores_grado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.profesores_grado.Location = New System.Drawing.Point(67, 186)
        Me.profesores_grado.Name = "profesores_grado"
        Me.profesores_grado.ReadOnly = True
        Me.profesores_grado.Size = New System.Drawing.Size(647, 289)
        Me.profesores_grado.TabIndex = 10
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightCyan
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button1.FlatAppearance.BorderSize = 2
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(669, 506)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(87, 33)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Volver"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ProfesorgradoBindingSource
        '
        Me.ProfesorgradoBindingSource.DataMember = "Profesor_grado"
        Me.ProfesorgradoBindingSource.DataSource = Me.Escuela_BDDataSet
        '
        'Escuela_BDDataSet
        '
        Me.Escuela_BDDataSet.DataSetName = "escuela_BDDataSet"
        Me.Escuela_BDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Profesor_gradoTableAdapter
        '
        Me.Profesor_gradoTableAdapter.ClearBeforeFill = True
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.profesores_grado)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.seccionActual)
        Me.Controls.Add(Me.gradoActual)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Form6"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Profesores disponibles"
        CType(Me.profesores_grado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProfesorgradoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Escuela_BDDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents seccionActual As System.Windows.Forms.Label
    Friend WithEvents gradoActual As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents profesores_grado As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Escuela_BDDataSet As WindowsApplication1.escuela_BDDataSet
    Friend WithEvents ProfesorgradoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Profesor_gradoTableAdapter As WindowsApplication1.escuela_BDDataSetTableAdapters.Profesor_gradoTableAdapter
End Class
