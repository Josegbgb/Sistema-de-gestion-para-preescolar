<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gradoBox = New System.Windows.Forms.TextBox()
        Me.seccionBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GradosDataGridView = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.seccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GradosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Escuela_BDDataSet = New WindowsApplication1.escuela_BDDataSet()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GradosTableAdapter = New WindowsApplication1.escuela_BDDataSetTableAdapters.GradosTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.escuela_BDDataSetTableAdapters.TableAdapterManager()
        CType(Me.GradosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GradosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Escuela_BDDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(272, 126)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Grado" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(272, 157)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Seccion"
        '
        'gradoBox
        '
        Me.gradoBox.Location = New System.Drawing.Point(324, 123)
        Me.gradoBox.Name = "gradoBox"
        Me.gradoBox.Size = New System.Drawing.Size(154, 20)
        Me.gradoBox.TabIndex = 4
        '
        'seccionBox
        '
        Me.seccionBox.Location = New System.Drawing.Point(324, 154)
        Me.seccionBox.Name = "seccionBox"
        Me.seccionBox.Size = New System.Drawing.Size(154, 20)
        Me.seccionBox.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightCyan
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button1.FlatAppearance.BorderSize = 2
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(347, 191)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(92, 36)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Agregar grado"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'GradosDataGridView
        '
        Me.GradosDataGridView.AutoGenerateColumns = False
        Me.GradosDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.GradosDataGridView.BackgroundColor = System.Drawing.Color.Azure
        Me.GradosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GradosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.grado, Me.seccion})
        Me.GradosDataGridView.DataSource = Me.GradosBindingSource
        Me.GradosDataGridView.Location = New System.Drawing.Point(42, 264)
        Me.GradosDataGridView.Name = "GradosDataGridView"
        Me.GradosDataGridView.ReadOnly = True
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Beige
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GradosDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Beige
        Me.GradosDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.GradosDataGridView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Beige
        Me.GradosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GradosDataGridView.Size = New System.Drawing.Size(696, 211)
        Me.GradosDataGridView.TabIndex = 7
        '
        'id
        '
        Me.id.DataPropertyName = "Id"
        Me.id.HeaderText = "id"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Visible = False
        '
        'grado
        '
        Me.grado.DataPropertyName = "grado"
        Me.grado.HeaderText = "grado"
        Me.grado.Name = "grado"
        Me.grado.ReadOnly = True
        '
        'seccion
        '
        Me.seccion.DataPropertyName = "seccion"
        Me.seccion.HeaderText = "seccion"
        Me.seccion.Name = "seccion"
        Me.seccion.ReadOnly = True
        '
        'GradosBindingSource
        '
        Me.GradosBindingSource.DataMember = "Grados"
        Me.GradosBindingSource.DataSource = Me.Escuela_BDDataSet
        '
        'Escuela_BDDataSet
        '
        Me.Escuela_BDDataSet.DataSetName = "escuela_BDDataSet"
        Me.Escuela_BDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Nothing
        Me.BindingNavigator1.CountItem = Nothing
        Me.BindingNavigator1.DeleteItem = Nothing
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator1.MoveFirstItem = Nothing
        Me.BindingNavigator1.MoveLastItem = Nothing
        Me.BindingNavigator1.MoveNextItem = Nothing
        Me.BindingNavigator1.MovePreviousItem = Nothing
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Nothing
        Me.BindingNavigator1.Size = New System.Drawing.Size(100, 25)
        Me.BindingNavigator1.TabIndex = 0
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.LightCyan
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button4.FlatAppearance.BorderSize = 2
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Location = New System.Drawing.Point(420, 515)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(101, 28)
        Me.Button4.TabIndex = 13
        Me.Button4.Text = "Eliminar grado"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.LightCyan
        Me.Button5.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button5.FlatAppearance.BorderSize = 2
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Location = New System.Drawing.Point(688, 517)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(74, 32)
        Me.Button5.TabIndex = 14
        Me.Button5.Text = "Volver"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.WindowsApplication1.My.Resources.Resources.images__3__removebg_preview
        Me.PictureBox2.Location = New System.Drawing.Point(523, 90)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(161, 119)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 16
        Me.PictureBox2.TabStop = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.LightCyan
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button2.FlatAppearance.BorderSize = 2
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(262, 517)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(99, 26)
        Me.Button2.TabIndex = 19
        Me.Button2.Text = "Modificar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'GradosTableAdapter
        '
        Me.GradosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.GradosTableAdapter = Me.GradosTableAdapter
        Me.TableAdapterManager.Profesor_gradoTableAdapter = Nothing
        Me.TableAdapterManager.ProfesoresTableAdapter = Nothing
        Me.TableAdapterManager.RepresentantesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.escuela_BDDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuariosTableAdapter = Nothing
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.GradosDataGridView)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.seccionBox)
        Me.Controls.Add(Me.gradoBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Grados"
        CType(Me.GradosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GradosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Escuela_BDDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents gradoBox As System.Windows.Forms.TextBox
    Friend WithEvents seccionBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Escuela_BDDataSet As WindowsApplication1.escuela_BDDataSet
    Friend WithEvents GradosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GradosTableAdapter As WindowsApplication1.escuela_BDDataSetTableAdapters.GradosTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.escuela_BDDataSetTableAdapters.TableAdapterManager
    Friend WithEvents GradosDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents BindingNavigator1 As System.Windows.Forms.BindingNavigator
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents seccion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Button2 As System.Windows.Forms.Button

End Class
