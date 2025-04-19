<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form12
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
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.gradoA = New System.Windows.Forms.TextBox()
        Me.seccionA = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.gradoLabel = New System.Windows.Forms.Label()
        Me.seccionLabel = New System.Windows.Forms.Label()
        Me.GradosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableAdapterManager = New WindowsApplication1.escuela_BDDataSetTableAdapters.TableAdapterManager()
        Me.Escuela_BDDataSet = New WindowsApplication1.escuela_BDDataSet()
        Me.GroupBox1.SuspendLayout()
        CType(Me.GradosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Escuela_BDDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(53, 32)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(153, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Formulario para modificar datos"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.gradoA)
        Me.GroupBox1.Controls.Add(Me.seccionA)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(42, 119)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(299, 129)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del grado"
        '
        'gradoA
        '
        Me.gradoA.Location = New System.Drawing.Point(24, 69)
        Me.gradoA.Name = "gradoA"
        Me.gradoA.Size = New System.Drawing.Size(91, 20)
        Me.gradoA.TabIndex = 1
        '
        'seccionA
        '
        Me.seccionA.Location = New System.Drawing.Point(174, 69)
        Me.seccionA.Name = "seccionA"
        Me.seccionA.Size = New System.Drawing.Size(91, 20)
        Me.seccionA.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Grado"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(171, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Seccion"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightCyan
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button1.FlatAppearance.BorderSize = 2
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(139, 264)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 35)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Guardar cambios"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(53, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Grado y seccion actual:"
        '
        'gradoLabel
        '
        Me.gradoLabel.AutoSize = True
        Me.gradoLabel.Location = New System.Drawing.Point(170, 73)
        Me.gradoLabel.Name = "gradoLabel"
        Me.gradoLabel.Size = New System.Drawing.Size(13, 13)
        Me.gradoLabel.TabIndex = 20
        Me.gradoLabel.Text = "1"
        '
        'seccionLabel
        '
        Me.seccionLabel.AutoSize = True
        Me.seccionLabel.Location = New System.Drawing.Point(178, 73)
        Me.seccionLabel.Name = "seccionLabel"
        Me.seccionLabel.Size = New System.Drawing.Size(14, 13)
        Me.seccionLabel.TabIndex = 21
        Me.seccionLabel.Text = "B"
        '
        'GradosBindingSource
        '
        Me.GradosBindingSource.DataMember = "Grados"
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.GradosTableAdapter = Nothing
        Me.TableAdapterManager.Profesor_gradoTableAdapter = Nothing
        Me.TableAdapterManager.ProfesoresTableAdapter = Nothing
        Me.TableAdapterManager.RepresentantesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.escuela_BDDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuariosTableAdapter = Nothing
        '
        'Escuela_BDDataSet
        '
        Me.Escuela_BDDataSet.DataSetName = "escuela_BDDataSet"
        Me.Escuela_BDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Form12
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.ClientSize = New System.Drawing.Size(384, 339)
        Me.Controls.Add(Me.seccionLabel)
        Me.Controls.Add(Me.gradoLabel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form12"
        Me.Text = "Modificar"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.GradosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Escuela_BDDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents gradoA As System.Windows.Forms.TextBox
    Friend WithEvents seccionA As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents gradoLabel As System.Windows.Forms.Label
    Friend WithEvents seccionLabel As System.Windows.Forms.Label
    Friend WithEvents GradosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TableAdapterManager As WindowsApplication1.escuela_BDDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Escuela_BDDataSet As WindowsApplication1.escuela_BDDataSet
End Class
