Imports System.Data.OleDb

Public Class Form4

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

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MaximizeBox = False
        Me.EstudiantesTableAdapter.Fill(Me.Escuela_BDDataSet.Estudiantes)
        gradoActual.Text = grado
        seccionActual.Text = seccion
        CargarEstudiantesSinGrado()
    End Sub

    Private Sub CargarEstudiantesSinGrado()
        Dim adapter As New escuela_BDDataSetTableAdapters.EstudiantesTableAdapter()
        Dim tabla As DataTable = adapter.GetEstudiantesSinGrado()
        DataGridView1.DataSource = tabla
    End Sub

    Private Sub AsignarGrado(ByVal idEstudiante As Integer, ByVal grado As Integer)
        Dim adapter As New escuela_BDDataSetTableAdapters.EstudiantesTableAdapter()
        adapter.asignarNuevoGrado(grado, idEstudiante)
    End Sub

    Private Sub DataGridView1_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        If e.RowIndex >= 0 Then
            Dim idEstudiante As Integer = CInt(DataGridView1.Rows(e.RowIndex).Cells("id").Value)
            AsignarGrado(idEstudiante, grado_id)
            CargarEstudiantesSinGrado()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim detalleForm As New Form3(grado, seccion, grado_id, usuario)
        detalleForm.Show()
        Me.Close()
    End Sub
End Class