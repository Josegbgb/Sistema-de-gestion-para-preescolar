Imports System.Data.OleDb
Public Class Form2

    Private usuario As String
    Public Sub New(ByVal _usuario As String)
        InitializeComponent()
        usuario = _usuario
    End Sub

    Private idFilaE As Integer
    Private nombreE As String
    Private apellidoE As String
    Private nombreR As String
    Private apellidoR As String
    Private cedulaR As Integer
    Private telefonoR As String



    Private Sub registrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles registrar.Click
        Try
            If nombreText.Text <> "" And apellidoText.Text <> "" And nombreRepresentante.Text <> "" And apellidoRepresentante.Text <> "" And telefonoRepresentante.Text <> "" And cedulaRepresentante.Text <> "" Then
                Dim adapter As New escuela_BDDataSetTableAdapters.EstudiantesTableAdapter()
                Dim adapterRepresentante As New escuela_BDDataSetTableAdapters.RepresentantesTableAdapter()

                adapterRepresentante.insertarRepresentante(nombreRepresentante.Text, apellidoRepresentante.Text, cedulaRepresentante.Text, telefonoRepresentante.Text)

                Dim representanteId As Integer

                representanteId = adapterRepresentante.seleccionarRepresentante()

                adapter.insertarEstudiante(nombreText.Text, apellidoText.Text, representanteId)
                Me.EstudiantesTableAdapter.Fill(Me.Escuela_BDDataSet.Estudiantes)

                MessageBox.Show("Datos Guardados")
                nombreText.Text = ""
                apellidoText.Text = ""
                nombreRepresentante.Text = ""
                apellidoRepresentante.Text = ""
                telefonoRepresentante.Text = ""
                cedulaRepresentante.Text = ""
            Else
                MessageBox.Show("Completa los datos")
            End If

        Catch ex As Exception
            MessageBox.Show("Ingrese datos apropiados para el registro ")
        End Try
    End Sub
  

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.EstudiantesTableAdapter.Fill(Me.Escuela_BDDataSet.Estudiantes)
        Me.MaximizeBox = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim inicioForm As New Form9(usuario)
        inicioForm.Show() '
        Me.Close()
    End Sub

    Private Sub DataGridView1_SelectionChanged(ByVal sender As Object, ByVal e As EventArgs) Handles DataGridView1.SelectionChanged
        Try
            If DataGridView1.SelectedRows.Count > 0 Then
                Dim row As DataGridViewRow = DataGridView1.SelectedRows(0)
                idFilaE = Convert.ToInt32(row.Cells("IdDataGridViewTextBoxColumn").Value)
                nombreE = row.Cells("NombreDataGridViewTextBoxColumn").Value.ToString()
                apellidoE = row.Cells("ApellidoDataGridViewTextBoxColumn").Value.ToString()
                nombreR = row.Cells("DataGridViewTextBoxColumn2").Value.ToString()
                apellidoR = row.Cells("DataGridViewTextBoxColumn3").Value.ToString()
                cedulaR = row.Cells("cedula").Value
                telefonoR = row.Cells("DataGridViewTextBoxColumn4").Value.ToString()
            End If
        Catch ex As Exception
            MessageBox.Show("Seleccione un registro para modificar o eliminar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

        
    End Sub


    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim modal As New Form11(usuario)

        modal.idFila = idFilaE
        modal.nombre = nombreE
        modal.apellido = apellidoE
        modal.nombreRepresentante = nombreR
        modal.apellidoRepresentante = apellidoR
        modal.cedula = cedulaR
        modal.telefono = telefonoR

        Dim resultado As DialogResult = modal.ShowDialog()

        If resultado = DialogResult.OK Then
            Me.EstudiantesTableAdapter.Fill(Me.Escuela_BDDataSet.Estudiantes)
        End If

    End Sub


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            If DataGridView1.CurrentRow IsNot Nothing Then
                Dim idEstudiante As Integer = Convert.ToInt32(DataGridView1.CurrentRow.Cells("IdDataGridViewTextBoxColumn").Value)
                Dim idRepresentante As Integer = Convert.ToInt32(DataGridView1.CurrentRow.Cells("representante_id").Value)
                Dim RepresentanteId As Integer = EstudiantesTableAdapter.seleccionarRepresentante(idEstudiante)



               

                Dim resultado As DialogResult = MessageBox.Show("¿Seguro que quieres eliminar este estudiante?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

                If resultado = DialogResult.Yes Then
                    Dim adapter As New escuela_BDDataSetTableAdapters.EstudiantesTableAdapter()
                    Dim adapterRepresentante As New escuela_BDDataSetTableAdapters.RepresentantesTableAdapter()


                    adapter.eliminarEstudiante(idEstudiante)
                    adapterRepresentante.eliminarRepresentante(idRepresentante)



                    MessageBox.Show("Estudiante eliminado correctamente.")
                    Me.EstudiantesTableAdapter.Fill(Me.Escuela_BDDataSet.Estudiantes)

                End If
            Else
                MessageBox.Show("Selecciona una fila para eliminar.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

  
End Class



