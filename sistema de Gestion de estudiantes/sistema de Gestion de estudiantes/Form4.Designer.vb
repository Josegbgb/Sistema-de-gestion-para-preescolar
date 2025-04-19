<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.EstudiantesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EscuelaBDDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Escuela_BDDataSet = New WindowsApplication1.escuela_BDDataSet()
        Me.EstudiantesBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gradoActual = New System.Windows.Forms.Label()
        Me.seccionActual = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApellidoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelefonoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GradoidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.EstudiantesTableAdapter = New WindowsApplication1.escuela_BDDataSetTableAdapters.EstudiantesTableAdapter()
        CType(Me.EstudiantesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EscuelaBDDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Escuela_BDDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstudiantesBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EstudiantesBindingSource
        '
        Me.EstudiantesBindingSource.DataMember = "Estudiantes"
        Me.EstudiantesBindingSource.DataSource = Me.EscuelaBDDataSetBindingSource
        '
        'EscuelaBDDataSetBindingSource
        '
        Me.EscuelaBDDataSetBindingSource.DataSource = Me.Escuela_BDDataSet
        Me.EscuelaBDDataSetBindingSource.Position = 0
        '
        'Escuela_BDDataSet
        '
        Me.Escuela_BDDataSet.DataSetName = "escuela_BDDataSet"
        Me.Escuela_BDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EstudiantesBindingSource1
        '
        Me.EstudiantesBindingSource1.DataMember = "Estudiantes"
        Me.EstudiantesBindingSource1.DataSource = Me.EscuelaBDDataSetBindingSource
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(62, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(197, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Grado y seccion actual:"
        '
        'gradoActual
        '
        Me.gradoActual.AutoSize = True
        Me.gradoActual.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gradoActual.Location = New System.Drawing.Point(265, 52)
        Me.gradoActual.Name = "gradoActual"
        Me.gradoActual.Size = New System.Drawing.Size(19, 20)
        Me.gradoActual.TabIndex = 2
        Me.gradoActual.Text = "1"
        '
        'seccionActual
        '
        Me.seccionActual.AutoSize = True
        Me.seccionActual.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.seccionActual.Location = New System.Drawing.Point(290, 52)
        Me.seccionActual.Name = "seccionActual"
        Me.seccionActual.Size = New System.Drawing.Size(19, 20)
        Me.seccionActual.TabIndex = 3
        Me.seccionActual.Text = "a"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.NombreDataGridViewTextBoxColumn, Me.ApellidoDataGridViewTextBoxColumn, Me.TelefonoDataGridViewTextBoxColumn, Me.GradoidDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.EstudiantesBindingSource1
        Me.DataGridView1.Location = New System.Drawing.Point(66, 184)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(640, 297)
        Me.DataGridView1.TabIndex = 0
        '
        'id
        '
        Me.id.DataPropertyName = "Id"
        Me.id.HeaderText = "Id"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Visible = False
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ApellidoDataGridViewTextBoxColumn
        '
        Me.ApellidoDataGridViewTextBoxColumn.DataPropertyName = "apellido"
        Me.ApellidoDataGridViewTextBoxColumn.HeaderText = "apellido"
        Me.ApellidoDataGridViewTextBoxColumn.Name = "ApellidoDataGridViewTextBoxColumn"
        Me.ApellidoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TelefonoDataGridViewTextBoxColumn
        '
        Me.TelefonoDataGridViewTextBoxColumn.DataPropertyName = "telefono"
        Me.TelefonoDataGridViewTextBoxColumn.HeaderText = "telefono"
        Me.TelefonoDataGridViewTextBoxColumn.Name = "TelefonoDataGridViewTextBoxColumn"
        Me.TelefonoDataGridViewTextBoxColumn.ReadOnly = True
        Me.TelefonoDataGridViewTextBoxColumn.Visible = False
        '
        'GradoidDataGridViewTextBoxColumn
        '
        Me.GradoidDataGridViewTextBoxColumn.DataPropertyName = "grado_id"
        Me.GradoidDataGridViewTextBoxColumn.HeaderText = "grado_id"
        Me.GradoidDataGridViewTextBoxColumn.Name = "GradoidDataGridViewTextBoxColumn"
        Me.GradoidDataGridViewTextBoxColumn.ReadOnly = True
        Me.GradoidDataGridViewTextBoxColumn.Visible = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightCyan
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button1.FlatAppearance.BorderSize = 2
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(664, 500)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(92, 36)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Volver"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(290, 136)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(200, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Estudiantes disponibles"
        '
        'EstudiantesTableAdapter
        '
        Me.EstudiantesTableAdapter.ClearBeforeFill = True
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.seccionActual)
        Me.Controls.Add(Me.gradoActual)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Estudiantes disponibles"
        CType(Me.EstudiantesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EscuelaBDDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Escuela_BDDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstudiantesBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents EscuelaBDDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Escuela_BDDataSet As WindowsApplication1.escuela_BDDataSet
    Friend WithEvents EstudiantesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EstudiantesTableAdapter As WindowsApplication1.escuela_BDDataSetTableAdapters.EstudiantesTableAdapter
    Friend WithEvents EstudiantesBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents gradoActual As System.Windows.Forms.Label
    Friend WithEvents seccionActual As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ApellidoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TelefonoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GradoidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
