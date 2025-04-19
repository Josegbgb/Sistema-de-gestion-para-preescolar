Public Class Form5


    Private id_profesor As Integer
    Private nombreP As String
    Private apellidoP As String
    Private cedulaP As Integer
    Private telefonoP As String

    Private usuario As String
    Public Sub New(ByVal _usuario As String)
        InitializeComponent()
        usuario = _usuario
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            If nombreBox.Text <> "" And apellidoBox.Text <> "" And cedulaBox.Text <> "" And telefonoBox.Text <> "" Then
                Dim adapter As New escuela_BDDataSetTableAdapters.ProfesoresTableAdapter()
                Dim existe As Integer = adapter.existeProfesor(cedulaBox.Text)

                If existe > 0 Then
                    MessageBox.Show("Ya existe un profesor con este numero de cedula.")
                Else
                    adapter.InsertarProfesor(nombreBox.Text, apellidoBox.Text, CInt(cedulaBox.Text), telefonoBox.Text)
                    Me.ProfesoresTableAdapter.Fill(Me.Escuela_BDDataSet.Profesores)
                    MessageBox.Show("Datos Guardados")
                    nombreBox.Text = ""
                    apellidoBox.Text = ""
                    cedulaBox.Text = ""
                    telefonoBox.Text = ""
                End If
            Else
                MessageBox.Show("Completa los datos")
            End If


        Catch ex As Exception
            MessageBox.Show("Ingrese datos apropiados para el registro ")
        End Try
    End Sub

    Private Sub Form5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MaximizeBox = False
        Me.ProfesoresTableAdapter.Fill(Me.Escuela_BDDataSet.Profesores)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim inicioForm As New Form9(usuario)
        inicioForm.Show() '
        Me.Close()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Try
            If DataGridView1.CurrentRow IsNot Nothing Then
                Dim idProfesor As Integer = Convert.ToInt32(DataGridView1.CurrentRow.Cells("id").Value)
                Dim resultado As DialogResult = MessageBox.Show("¿Seguro que quieres eliminar este profesor?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

                If resultado = DialogResult.Yes Then
                    Dim adapter As New escuela_BDDataSetTableAdapters.ProfesoresTableAdapter()
                    Dim adapterRelacion As New escuela_BDDataSetTableAdapters.Profesor_gradoTableAdapter()
                    adapter.eliminarProfesor(idProfesor)
                    adapterRelacion.eliminarRelacion(idProfesor)
                    Me.ProfesoresTableAdapter.Fill(Me.Escuela_BDDataSet.Profesores)
                    MessageBox.Show("Profesor eliminado correctamente.")

                End If
            Else
                MessageBox.Show("Selecciona una fila para eliminar.")
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub DataGridView1_SelectionChanged(ByVal sender As Object, ByVal e As EventArgs) Handles DataGridView1.SelectionChanged
        If DataGridView1.SelectedRows.Count > 0 Then

            Dim row As DataGridViewRow = DataGridView1.SelectedRows(0)
            id_profesor = Convert.ToInt32(row.Cells("id").Value)
            nombreP = row.Cells("NombreDataGridViewTextBoxColumn").Value.ToString()
            apellidoP = row.Cells("ApellidoDataGridViewTextBoxColumn").Value.ToString()
            cedulaP = row.Cells("CedulaDataGridViewTextBoxColumn").Value
            telefonoP = row.Cells("TelefonoDataGridViewTextBoxColumn").Value.ToString()

        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim modal As New Form13(usuario)

        modal.idFila = id_profesor
        modal.nombre = nombreP
        modal.apellido = apellidoP
        modal.cedula = cedulaP
        modal.telefono = telefonoP

        Dim resultado As DialogResult = modal.ShowDialog()

        If resultado = DialogResult.OK Then
            Me.ProfesoresTableAdapter.Fill(Me.Escuela_BDDataSet.Profesores)
        End If

    End Sub

End Class