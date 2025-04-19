<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.FileSystemWatcher1 = New System.IO.FileSystemWatcher()
        Me.nombre = New System.Windows.Forms.Label()
        Me.nombreText = New System.Windows.Forms.TextBox()
        Me.apellido = New System.Windows.Forms.Label()
        Me.telefono = New System.Windows.Forms.Label()
        Me.apellidoText = New System.Windows.Forms.TextBox()
        Me.telefonoRepresentante = New System.Windows.Forms.TextBox()
        Me.registrar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.representante_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApellidoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.seccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cedula = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstudiantesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EscuelaBDDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Escuela_BDDataSet = New WindowsApplication1.escuela_BDDataSet()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.apellidoRepresentante = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.nombreRepresentante = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cedulaRepresentante = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.EstudiantesTableAdapter = New WindowsApplication1.escuela_BDDataSetTableAdapters.EstudiantesTableAdapter()
        Me.Button4 = New System.Windows.Forms.Button()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstudiantesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EscuelaBDDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Escuela_BDDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FileSystemWatcher1
        '
        Me.FileSystemWatcher1.EnableRaisingEvents = True
        Me.FileSystemWatcher1.SynchronizingObject = Me
        '
        'nombre
        '
        Me.nombre.AutoSize = True
        Me.nombre.Location = New System.Drawing.Point(65, 67)
        Me.nombre.Name = "nombre"
        Me.nombre.Size = New System.Drawing.Size(44, 13)
        Me.nombre.TabIndex = 0
        Me.nombre.Text = "Nombre"
        '
        'nombreText
        '
        Me.nombreText.Location = New System.Drawing.Point(68, 97)
        Me.nombreText.Name = "nombreText"
        Me.nombreText.Size = New System.Drawing.Size(110, 20)
        Me.nombreText.TabIndex = 1
        '
        'apellido
        '
        Me.apellido.AutoSize = True
        Me.apellido.Location = New System.Drawing.Point(65, 125)
        Me.apellido.Name = "apellido"
        Me.apellido.Size = New System.Drawing.Size(44, 13)
        Me.apellido.TabIndex = 2
        Me.apellido.Text = "Apellido"
        '
        'telefono
        '
        Me.telefono.AutoSize = True
        Me.telefono.Location = New System.Drawing.Point(526, 127)
        Me.telefono.Name = "telefono"
        Me.telefono.Size = New System.Drawing.Size(49, 13)
        Me.telefono.TabIndex = 3
        Me.telefono.Text = "Telefono"
        '
        'apellidoText
        '
        Me.apellidoText.Location = New System.Drawing.Point(68, 157)
        Me.apellidoText.Name = "apellidoText"
        Me.apellidoText.Size = New System.Drawing.Size(110, 20)
        Me.apellidoText.TabIndex = 4
        '
        'telefonoRepresentante
        '
        Me.telefonoRepresentante.Location = New System.Drawing.Point(529, 157)
        Me.telefonoRepresentante.Name = "telefonoRepresentante"
        Me.telefonoRepresentante.Size = New System.Drawing.Size(110, 20)
        Me.telefonoRepresentante.TabIndex = 5
        '
        'registrar
        '
        Me.registrar.BackColor = System.Drawing.Color.LightCyan
        Me.registrar.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.registrar.FlatAppearance.BorderSize = 2
        Me.registrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.registrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.registrar.Location = New System.Drawing.Point(695, 114)
        Me.registrar.Name = "registrar"
        Me.registrar.Size = New System.Drawing.Size(72, 35)
        Me.registrar.TabIndex = 6
        Me.registrar.Text = "registrar"
        Me.registrar.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightCyan
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button1.FlatAppearance.BorderSize = 2
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(745, 541)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(71, 28)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Volver"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Beige
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.Azure
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Beige
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NombreDataGridViewTextBoxColumn, Me.representante_id, Me.ApellidoDataGridViewTextBoxColumn, Me.grado, Me.seccion, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.cedula, Me.DataGridViewTextBoxColumn4, Me.IdDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.EstudiantesBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Beige
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.Location = New System.Drawing.Point(43, 228)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Beige
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Beige
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Beige
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(763, 288)
        Me.DataGridView1.TabIndex = 12
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        '
        'representante_id
        '
        Me.representante_id.DataPropertyName = "representante_id"
        Me.representante_id.HeaderText = "representante_id"
        Me.representante_id.Name = "representante_id"
        Me.representante_id.ReadOnly = True
        Me.representante_id.Visible = False
        '
        'ApellidoDataGridViewTextBoxColumn
        '
        Me.ApellidoDataGridViewTextBoxColumn.DataPropertyName = "apellido"
        Me.ApellidoDataGridViewTextBoxColumn.HeaderText = "Apellido"
        Me.ApellidoDataGridViewTextBoxColumn.Name = "ApellidoDataGridViewTextBoxColumn"
        Me.ApellidoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'grado
        '
        Me.grado.DataPropertyName = "grado"
        Me.grado.HeaderText = "Grado"
        Me.grado.Name = "grado"
        Me.grado.ReadOnly = True
        '
        'seccion
        '
        Me.seccion.DataPropertyName = "seccion"
        Me.seccion.HeaderText = "Seccion"
        Me.seccion.Name = "seccion"
        Me.seccion.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "NombreRepresentante"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Representante"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "ApellidoRepresentante"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Apellido"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'cedula
        '
        Me.cedula.DataPropertyName = "cedula"
        Me.cedula.HeaderText = "Cedula"
        Me.cedula.Name = "cedula"
        Me.cedula.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "TelefonoRepresentante"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Telefono"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdDataGridViewTextBoxColumn.Visible = False
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
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.LightCyan
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button3.FlatAppearance.BorderSize = 2
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(452, 541)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(121, 26)
        Me.Button3.TabIndex = 14
        Me.Button3.Text = "Eliminar estudiante"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(65, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Datos del estudiante"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(383, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Datos del representante"
        '
        'apellidoRepresentante
        '
        Me.apellidoRepresentante.Location = New System.Drawing.Point(386, 157)
        Me.apellidoRepresentante.Name = "apellidoRepresentante"
        Me.apellidoRepresentante.Size = New System.Drawing.Size(110, 20)
        Me.apellidoRepresentante.TabIndex = 20
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(383, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Apellido"
        '
        'nombreRepresentante
        '
        Me.nombreRepresentante.Location = New System.Drawing.Point(386, 97)
        Me.nombreRepresentante.Name = "nombreRepresentante"
        Me.nombreRepresentante.Size = New System.Drawing.Size(110, 20)
        Me.nombreRepresentante.TabIndex = 18
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(383, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Nombre"
        '
        'cedulaRepresentante
        '
        Me.cedulaRepresentante.Location = New System.Drawing.Point(529, 97)
        Me.cedulaRepresentante.Name = "cedulaRepresentante"
        Me.cedulaRepresentante.Size = New System.Drawing.Size(110, 20)
        Me.cedulaRepresentante.TabIndex = 22
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(526, 67)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Cedula"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(228, 82)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(112, 112)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 23
        Me.PictureBox1.TabStop = False
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
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Location = New System.Drawing.Point(307, 541)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(97, 23)
        Me.Button4.TabIndex = 24
        Me.Button4.Text = "Modificar"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.ClientSize = New System.Drawing.Size(844, 581)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.cedulaRepresentante)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.apellidoRepresentante)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.nombreRepresentante)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.registrar)
        Me.Controls.Add(Me.telefonoRepresentante)
        Me.Controls.Add(Me.apellidoText)
        Me.Controls.Add(Me.telefono)
        Me.Controls.Add(Me.apellido)
        Me.Controls.Add(Me.nombreText)
        Me.Controls.Add(Me.nombre)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Estudiantes"
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstudiantesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EscuelaBDDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Escuela_BDDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FileSystemWatcher1 As System.IO.FileSystemWatcher
    Friend WithEvents nombreText As System.Windows.Forms.TextBox
    Friend WithEvents nombre As System.Windows.Forms.Label
    Friend WithEvents telefono As System.Windows.Forms.Label
    Friend WithEvents apellido As System.Windows.Forms.Label
    Friend WithEvents telefonoRepresentante As System.Windows.Forms.TextBox
    Friend WithEvents apellidoText As System.Windows.Forms.TextBox
    Friend WithEvents registrar As System.Windows.Forms.Button
    Friend WithEvents EscuelaBDDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Escuela_BDDataSet As WindowsApplication1.escuela_BDDataSet
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents EstudiantesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EstudiantesTableAdapter As WindowsApplication1.escuela_BDDataSetTableAdapters.EstudiantesTableAdapter
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents GradoidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cedulaRepresentante As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents apellidoRepresentante As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents nombreRepresentante As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TelefonoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GradoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SeccionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents NombreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents representante_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ApellidoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents seccion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cedula As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
