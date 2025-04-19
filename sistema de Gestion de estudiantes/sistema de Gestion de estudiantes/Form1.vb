Public Class Form1
    Private usuario As String
    Private idActual As Integer
    Private gradoActual As Integer
    Private seccionActual As String
    

    Public Sub New(ByVal _usuario As String)

        InitializeComponent()
        usuario = _usuario


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            If gradoBox.Text <> "" And seccionBox.Text <> "" Then
                Dim adapter As New escuela_BDDataSetTableAdapters.GradosTableAdapter()
                Dim existe As Integer = adapter.existeGrado(CInt(gradoBox.Text), seccionBox.Text)


                If existe > 0 Then
                    MessageBox.Show("Ya existe un grado con esta sección.")
                Else
                    adapter.insertarGrado(CInt(gradoBox.Text), seccionBox.Text.ToUpper())
                    Me.GradosTableAdapter.Fill(Me.Escuela_BDDataSet.Grados)
                    MessageBox.Show("Datos Guardados")
                    gradoBox.Text = ""
                    seccionBox.Text = ""
                End If

            Else
                MessageBox.Show("Completa los datos")
            End If


        Catch ex As Exception
            MessageBox.Show("Ingrese datos apropiados para el registro ")

        End Try
    End Sub

    Private Sub GradosBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.GradosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Escuela_BDDataSet)

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.GradosTableAdapter.Fill(Me.Escuela_BDDataSet.Grados)
        Me.MaximizeBox = False

    End Sub

    Private Sub GradosDataGridView_SelectionChanged(ByVal sender As Object, ByVal e As EventArgs) Handles GradosDataGridView.SelectionChanged
        Try
            If GradosDataGridView.SelectedRows.Count > 0 Then
                Dim row As DataGridViewRow = GradosDataGridView.SelectedRows(0)
                idActual = Convert.ToInt32(row.Cells("id").Value)
                gradoActual = Convert.ToInt32(row.Cells("grado").Value)
                seccionActual = row.Cells("seccion").Value.ToString()
            End If
        Catch ex As Exception

        End Try
        
    End Sub

    Private Sub GradosDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GradosDataGridView.CellContentClick, GradosDataGridView.CellDoubleClick
        Try
            If e.RowIndex >= 0 Then
                Dim id As Integer = Convert.ToInt32(GradosDataGridView.Rows(e.RowIndex).Cells("id").Value)
                Dim grado As Integer = Convert.ToInt32(GradosDataGridView.Rows(e.RowIndex).Cells("grado").Value)
                Dim seccion As String = GradosDataGridView.Rows(e.RowIndex).Cells("seccion").Value.ToString()
                Dim detalleForm As New Form3(grado, seccion, id, usuario)
                detalleForm.Show()
                Me.Hide()
            End If
        Catch ex As Exception
            MessageBox.Show("Selecciona un grado para ver su informacion")

        End Try
       
    End Sub

  
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Try
            If GradosDataGridView.CurrentRow IsNot Nothing Then
                Dim idEstudiante As Integer = Convert.ToInt32(GradosDataGridView.CurrentRow.Cells("id").Value)
                Dim resultado As DialogResult = MessageBox.Show("¿Seguro que quieres eliminar este grado?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                If resultado = DialogResult.Yes Then
                    Dim adapter As New escuela_BDDataSetTableAdapters.GradosTableAdapter()
                    adapter.eliminarGrado_id(idEstudiante)
                    adapter.eliminarGrado(idEstudiante)
                    Me.GradosTableAdapter.Fill(Me.Escuela_BDDataSet.Grados)
                    MessageBox.Show("Grado eliminado correctamente.")
                End If
            Else
                MessageBox.Show("Selecciona un grado para eliminar.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim inicioForm As New Form9(usuario)
        inicioForm.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click


        Dim modal As New Form12(usuario)

        modal.grado = gradoActual
        modal.seccion = seccionActual
        modal.id_grado = idActual

        Dim resultado As DialogResult = modal.ShowDialog()

        If resultado = DialogResult.OK Then
            Me.GradosTableAdapter.Fill(Me.Escuela_BDDataSet.Grados)
        End If

        

    End Sub

   
End Class