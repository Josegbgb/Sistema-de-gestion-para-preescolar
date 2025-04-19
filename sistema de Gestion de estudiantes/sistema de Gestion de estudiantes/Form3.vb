Imports System.Data.OleDb
Public Class Form3

    Private grado As Integer
    Private seccion As String
    Private grado_id As Integer
    Private usuario As String

    Public Sub New(ByVal _grado As Integer, ByVal _seccion As String, ByVal _grado_id As Integer, ByVal _usuario As String)
        InitializeComponent()
        grado = _grado
        seccion = _seccion
        grado_id = _grado_id
        usuario = _usuario

    End Sub


    Private Sub ActualizarListaProfesores()
        Dim adapter As New escuela_BDDataSetTableAdapters.GradosTableAdapter()
        Dim nombreCompleto As String = adapter.profesorFiltrado(txtGrado.Text, txtSeccion.Text)

        If Not String.IsNullOrEmpty(nombreCompleto) Then
            profesorName.Text = nombreCompleto
        Else
            profesorName.Text = "Sin asignar"
        End If
    End Sub


    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.EstudiantesTableAdapter.Fill(Me.Escuela_BDDataSet1.Estudiantes)
        Me.MaximizeBox = False

        txtGrado.Text = grado
        txtSeccion.Text = seccion

        ActualizarListaProfesores()


        CargarEstudiantesPorGrado(grado_id)



    End Sub

    Private Sub CargarEstudiantesPorGrado(ByVal gradoSeleccionado As Integer)
        Dim adapter As New escuela_BDDataSetTableAdapters.GradosTableAdapter()
        Dim tabla As DataTable = adapter.GetEstudiantes(gradoSeleccionado)
        estudiantesFiltrados.DataSource = tabla
    End Sub



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim detalleForm As New Form4(grado, seccion, grado_id, usuario)
        detalleForm.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim inicioForm As New Form1(usuario)
        inicioForm.Show() '
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim detalleForm As New Form6(grado, seccion, grado_id, usuario)
        detalleForm.Show()
        Me.Close()

    End Sub



    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Try

            If estudiantesFiltrados.CurrentRow IsNot Nothing Then
                Dim idEstudiante As Integer = Convert.ToInt32(estudiantesFiltrados.CurrentRow.Cells("IdDataGridViewTextBoxColumn2").Value)

                Dim resultado As DialogResult = MessageBox.Show("¿Seguro que quieres eliminar este estudiante?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

                If resultado = DialogResult.Yes Then
                    Dim adapter As New escuela_BDDataSetTableAdapters.EstudiantesTableAdapter()
                    adapter.eliminarGrado(idEstudiante)
                    MessageBox.Show("Estudiante eliminado correctamente.")
                    CargarEstudiantesPorGrado(grado_id)
                End If
            Else
                MessageBox.Show("Selecciona una fila para eliminar.")
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub


    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim adapter As New escuela_BDDataSetTableAdapters.GradosTableAdapter()
        Dim filasAfectadas As Integer = adapter.eliminarProfesor(grado_id)

        If filasAfectadas > 0 Then
            MessageBox.Show("Profesor eliminado del grado correctamente.")
            ActualizarListaProfesores()
        Else
            MessageBox.Show("No se encontró una asignación para eliminar.")
        End If

    End Sub
End Class