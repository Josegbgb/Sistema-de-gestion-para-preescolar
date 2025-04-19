<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.txtGrado = New System.Windows.Forms.Label()
        Me.txtSeccion = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.profesorName = New System.Windows.Forms.Label()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApellidoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelefonoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstudiantesBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Escuela_BDDataSet1 = New WindowsApplication1.escuela_BDDataSet()
        Me.EstudiantesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Escuela_BDDataSet = New WindowsApplication1.escuela_BDDataSet()
        Me.EstudiantesTableAdapter = New WindowsApplication1.escuela_BDDataSetTableAdapters.EstudiantesTableAdapter()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.IdDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelefonoRepresentante = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApellidoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estudiantesFiltrados = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApellidoDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreRepresentanteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApellidoRepresentanteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelefonoRepresentanteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GGradoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GSeccionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.EstudiantesBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Escuela_BDDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstudiantesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Escuela_BDDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.estudiantesFiltrados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtGrado
        '
        Me.txtGrado.AutoSize = True
        Me.txtGrado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGrado.Location = New System.Drawing.Point(185, 48)
        Me.txtGrado.Name = "txtGrado"
        Me.txtGrado.Size = New System.Drawing.Size(19, 20)
        Me.txtGrado.TabIndex = 3
        Me.txtGrado.Text = "1"
        '
        'txtSeccion
        '
        Me.txtSeccion.AutoSize = True
        Me.txtSeccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSeccion.Location = New System.Drawing.Point(210, 48)
        Me.txtSeccion.Name = "txtSeccion"
        Me.txtSeccion.Size = New System.Drawing.Size(19, 20)
        Me.txtSeccion.TabIndex = 4
        Me.txtSeccion.Text = "a"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(38, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Grado y seccion:  "
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightCyan
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button1.FlatAppearance.BorderSize = 2
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(415, 48)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(152, 32)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Agregar estudiante"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.LightCyan
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button2.FlatAppearance.BorderSize = 2
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(590, 48)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(152, 32)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Asignar profesor"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.LightCyan
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button3.FlatAppearance.BorderSize = 2
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(673, 508)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(90, 32)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "Volver"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(39, 188)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 20)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Profesor:"
        '
        'profesorName
        '
        Me.profesorName.AutoSize = True
        Me.profesorName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.profesorName.Location = New System.Drawing.Point(118, 188)
        Me.profesorName.Name = "profesorName"
        Me.profesorName.Size = New System.Drawing.Size(99, 20)
        Me.profesorName.TabIndex = 12
        Me.profesorName.Text = "Sin asignar"
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        '
        'ApellidoDataGridViewTextBoxColumn
        '
        Me.ApellidoDataGridViewTextBoxColumn.DataPropertyName = "apellido"
        Me.ApellidoDataGridViewTextBoxColumn.HeaderText = "apellido"
        Me.ApellidoDataGridViewTextBoxColumn.Name = "ApellidoDataGridViewTextBoxColumn"
        '
        'TelefonoDataGridViewTextBoxColumn
        '
        Me.TelefonoDataGridViewTextBoxColumn.DataPropertyName = "telefono"
        Me.TelefonoDataGridViewTextBoxColumn.HeaderText = "telefono"
        Me.TelefonoDataGridViewTextBoxColumn.Name = "TelefonoDataGridViewTextBoxColumn"
        '
        'nombre
        '
        Me.nombre.DataPropertyName = "nombre"
        Me.nombre.HeaderText = "nombre"
        Me.nombre.Name = "nombre"
        '
        'apellido
        '
        Me.apellido.DataPropertyName = "apellido"
        Me.apellido.HeaderText = "apellido"
        Me.apellido.Name = "apellido"
        '
        'telefono
        '
        Me.telefono.DataPropertyName = "telefono"
        Me.telefono.HeaderText = "telefono"
        Me.telefono.Name = "telefono"
        '
        'EstudiantesBindingSource1
        '
        Me.EstudiantesBindingSource1.DataMember = "Estudiantes"
        Me.EstudiantesBindingSource1.DataSource = Me.Escuela_BDDataSet1
        '
        'Escuela_BDDataSet1
        '
        Me.Escuela_BDDataSet1.DataSetName = "escuela_BDDataSet"
        Me.Escuela_BDDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EstudiantesBindingSource
        '
        Me.EstudiantesBindingSource.DataMember = "Estudiantes"
        Me.EstudiantesBindingSource.DataSource = Me.Escuela_BDDataSet
        '
        'Escuela_BDDataSet
        '
        Me.Escuela_BDDataSet.DataSetName = "escuela_BDDataSet"
        Me.Escuela_BDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EstudiantesTableAdapter
        '
        Me.EstudiantesTableAdapter.ClearBeforeFill = True
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.LightCyan
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button4.FlatAppearance.BorderSize = 2
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Location = New System.Drawing.Point(590, 89)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(152, 32)
        Me.Button4.TabIndex = 14
        Me.Button4.Text = "Eliminar Profesor"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.LightCyan
        Me.Button5.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button5.FlatAppearance.BorderSize = 2
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Location = New System.Drawing.Point(42, 467)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(121, 26)
        Me.Button5.TabIndex = 15
        Me.Button5.Text = "Eliminar estudiante"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'IdDataGridViewTextBoxColumn1
        '
        Me.IdDataGridViewTextBoxColumn1.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn1.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn1.Name = "IdDataGridViewTextBoxColumn1"
        '
        'TelefonoRepresentante
        '
        Me.TelefonoRepresentante.DataPropertyName = "TelefonoRepresentante"
        Me.TelefonoRepresentante.HeaderText = "TelefonoRepresentante"
        Me.TelefonoRepresentante.Name = "TelefonoRepresentante"
        Me.TelefonoRepresentante.ReadOnly = True
        '
        'NombreDataGridViewTextBoxColumn1
        '
        Me.NombreDataGridViewTextBoxColumn1.DataPropertyName = "nombre"
        Me.NombreDataGridViewTextBoxColumn1.HeaderText = "nombre"
        Me.NombreDataGridViewTextBoxColumn1.Name = "NombreDataGridViewTextBoxColumn1"
        '
        'ApellidoDataGridViewTextBoxColumn1
        '
        Me.ApellidoDataGridViewTextBoxColumn1.DataPropertyName = "apellido"
        Me.ApellidoDataGridViewTextBoxColumn1.HeaderText = "apellido"
        Me.ApellidoDataGridViewTextBoxColumn1.Name = "ApellidoDataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "grado_id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "grado_id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'estudiantesFiltrados
        '
        Me.estudiantesFiltrados.AutoGenerateColumns = False
        Me.estudiantesFiltrados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.estudiantesFiltrados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.estudiantesFiltrados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn2, Me.NombreDataGridViewTextBoxColumn2, Me.ApellidoDataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.NombreRepresentanteDataGridViewTextBoxColumn, Me.ApellidoRepresentanteDataGridViewTextBoxColumn, Me.TelefonoRepresentanteDataGridViewTextBoxColumn, Me.DataGridViewTextBoxColumn4, Me.GGradoDataGridViewTextBoxColumn, Me.GSeccionDataGridViewTextBoxColumn})
        Me.estudiantesFiltrados.DataSource = Me.EstudiantesBindingSource1
        Me.estudiantesFiltrados.Location = New System.Drawing.Point(42, 233)
        Me.estudiantesFiltrados.Name = "estudiantesFiltrados"
        Me.estudiantesFiltrados.ReadOnly = True
        Me.estudiantesFiltrados.Size = New System.Drawing.Size(700, 212)
        Me.estudiantesFiltrados.TabIndex = 16
        '
        'IdDataGridViewTextBoxColumn2
        '
        Me.IdDataGridViewTextBoxColumn2.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn2.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn2.Name = "IdDataGridViewTextBoxColumn2"
        Me.IdDataGridViewTextBoxColumn2.ReadOnly = True
        Me.IdDataGridViewTextBoxColumn2.Visible = False
        '
        'NombreDataGridViewTextBoxColumn2
        '
        Me.NombreDataGridViewTextBoxColumn2.DataPropertyName = "nombre"
        Me.NombreDataGridViewTextBoxColumn2.HeaderText = "nombre"
        Me.NombreDataGridViewTextBoxColumn2.Name = "NombreDataGridViewTextBoxColumn2"
        Me.NombreDataGridViewTextBoxColumn2.ReadOnly = True
        '
        'ApellidoDataGridViewTextBoxColumn2
        '
        Me.ApellidoDataGridViewTextBoxColumn2.DataPropertyName = "apellido"
        Me.ApellidoDataGridViewTextBoxColumn2.HeaderText = "apellido"
        Me.ApellidoDataGridViewTextBoxColumn2.Name = "ApellidoDataGridViewTextBoxColumn2"
        Me.ApellidoDataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Grado"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Grado"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Seccion"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Seccion"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'NombreRepresentanteDataGridViewTextBoxColumn
        '
        Me.NombreRepresentanteDataGridViewTextBoxColumn.DataPropertyName = "NombreRepresentante"
        Me.NombreRepresentanteDataGridViewTextBoxColumn.HeaderText = "NombreRepresentante"
        Me.NombreRepresentanteDataGridViewTextBoxColumn.Name = "NombreRepresentanteDataGridViewTextBoxColumn"
        Me.NombreRepresentanteDataGridViewTextBoxColumn.ReadOnly = True
        Me.NombreRepresentanteDataGridViewTextBoxColumn.Visible = False
        '
        'ApellidoRepresentanteDataGridViewTextBoxColumn
        '
        Me.ApellidoRepresentanteDataGridViewTextBoxColumn.DataPropertyName = "ApellidoRepresentante"
        Me.ApellidoRepresentanteDataGridViewTextBoxColumn.HeaderText = "ApellidoRepresentante"
        Me.ApellidoRepresentanteDataGridViewTextBoxColumn.Name = "ApellidoRepresentanteDataGridViewTextBoxColumn"
        Me.ApellidoRepresentanteDataGridViewTextBoxColumn.ReadOnly = True
        Me.ApellidoRepresentanteDataGridViewTextBoxColumn.Visible = False
        '
        'TelefonoRepresentanteDataGridViewTextBoxColumn
        '
        Me.TelefonoRepresentanteDataGridViewTextBoxColumn.DataPropertyName = "TelefonoRepresentante"
        Me.TelefonoRepresentanteDataGridViewTextBoxColumn.HeaderText = "Telefono"
        Me.TelefonoRepresentanteDataGridViewTextBoxColumn.Name = "TelefonoRepresentanteDataGridViewTextBoxColumn"
        Me.TelefonoRepresentanteDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "grado_id"
        Me.DataGridViewTextBoxColumn4.HeaderText = "grado_id"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Visible = False
        '
        'GGradoDataGridViewTextBoxColumn
        '
        Me.GGradoDataGridViewTextBoxColumn.DataPropertyName = "g_Grado"
        Me.GGradoDataGridViewTextBoxColumn.HeaderText = "g_Grado"
        Me.GGradoDataGridViewTextBoxColumn.Name = "GGradoDataGridViewTextBoxColumn"
        Me.GGradoDataGridViewTextBoxColumn.ReadOnly = True
        Me.GGradoDataGridViewTextBoxColumn.Visible = False
        '
        'GSeccionDataGridViewTextBoxColumn
        '
        Me.GSeccionDataGridViewTextBoxColumn.DataPropertyName = "g_Seccion"
        Me.GSeccionDataGridViewTextBoxColumn.HeaderText = "g_Seccion"
        Me.GSeccionDataGridViewTextBoxColumn.Name = "GSeccionDataGridViewTextBoxColumn"
        Me.GSeccionDataGridViewTextBoxColumn.ReadOnly = True
        Me.GSeccionDataGridViewTextBoxColumn.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.libros21
        Me.PictureBox1.Location = New System.Drawing.Point(42, 89)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(143, 83)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.estudiantesFiltrados)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.profesorName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtSeccion)
        Me.Controls.Add(Me.txtGrado)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Grados"
        CType(Me.EstudiantesBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Escuela_BDDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstudiantesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Escuela_BDDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.estudiantesFiltrados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtGrado As System.Windows.Forms.Label
    Friend WithEvents txtSeccion As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Escuela_BDDataSet As WindowsApplication1.escuela_BDDataSet
    Friend WithEvents EstudiantesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EstudiantesTableAdapter As WindowsApplication1.escuela_BDDataSetTableAdapters.EstudiantesTableAdapter
    Friend WithEvents GradoidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents profesorName As System.Windows.Forms.Label
    Friend WithEvents IdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ApellidoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TelefonoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents apellido As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents telefono As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Escuela_BDDataSet1 As WindowsApplication1.escuela_BDDataSet
    Friend WithEvents EstudiantesBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents TelefonoDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GradoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SeccionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TelefonoRepresentante As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ApellidoDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents estudiantesFiltrados As System.Windows.Forms.DataGridView
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents IdDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ApellidoDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreRepresentanteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ApellidoRepresentanteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TelefonoRepresentanteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GGradoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GSeccionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
