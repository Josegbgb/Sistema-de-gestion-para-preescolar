Imports System.Data.OleDb
Public Class Form6
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

    Private Sub CargarDatos()

        

        Dim adapter As New escuela_BDDataSetTableAdapters.ProfesoresTableAdapter()
        Dim tabla As DataTable = adapter.GetProfesores()
        Dim tablaFiltrada As DataTable = tabla.DefaultView.ToTable(False, "profesor_id", "Profesor", "Grado")
        profesores_grado.DataSource = tablaFiltrada
        profesores_grado.Columns("profesor_id").Visible = False
     

    End Sub

    Private Sub Form6_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       
        Me.MaximizeBox = False
        gradoActual.Text = grado
        seccionActual.Text = seccion
        CargarDatos()
    End Sub

    Private Sub profesores_grado_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles profesores_grado.CellContentClick, profesores_grado.CellContentDoubleClick, profesores_grado.CellDoubleClick
        If e.RowIndex >= 0 Then
            Try
                Dim profesor As Integer = Convert.ToInt32(profesores_grado.Rows(e.RowIndex).Cells("profesor_id").Value)
                Dim adapter As New escuela_BDDataSetTableAdapters.Profesor_gradoTableAdapter()

                Dim existeRelacion As Integer = Convert.ToInt32(adapter.ExisteRelacion(profesor, grado_id))
                Dim existeGrado As Integer = Convert.ToInt32(adapter.ExisteGrado(grado_id))

                If existeRelacion > 0 Then
                    MessageBox.Show("Este profesor ya tiene este grado y sección asignados.")
                ElseIf existeGrado > 0 Then
                    MessageBox.Show("Este grado y sección ya están asignados a otro profesor.")
                Else
                    adapter.InsertarGradoProfesor(profesor, grado_id)
                    CargarDatos()
                    MessageBox.Show("Profesor asignado correctamente.")
                End If
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim detalleForm As New Form3(grado, seccion, grado_id, usuario)
        detalleForm.Show()
        Me.Close()
    End Sub
End Class