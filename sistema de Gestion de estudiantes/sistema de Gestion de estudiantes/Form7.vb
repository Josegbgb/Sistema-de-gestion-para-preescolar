Imports System.Data.OleDb
Imports System.Data.SqlClient

Public Class Form7

    Private usuario As String


    Public Sub New(ByVal _usuario As String)
        InitializeComponent()
        usuario = _usuario
    End Sub

    Private tablaDatos As New DataTable()
    Private Sub CargarDatos(ByVal tabla As DataTable, Optional ByVal columnasAocultar As List(Of String) = Nothing)

        tablaDatos = tabla
        DataGridView1.DataSource = Nothing
        DataGridView1.Columns.Clear()
        DataGridView1.DataSource = tablaDatos
        For Each columna As DataGridViewColumn In DataGridView1.Columns
            columna.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Next
        If columnasAocultar IsNot Nothing Then
            OcultarColumnas(columnasAocultar)
        End If
    End Sub

    Private Sub OcultarColumnas(ByVal columnasAocultar As List(Of String))
        For Each columna As String In columnasAocultar
            If DataGridView1.Columns.Contains(columna) Then
                DataGridView1.Columns(columna).Visible = False
            End If
        Next
    End Sub



    'Representante 
    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked Then
            Dim adapter As New escuela_BDDataSetTableAdapters.RepresentantesTableAdapter()
            Dim tabla As DataTable = adapter.obtenerTodosLosRepresentantes()
            Dim columnasAocultar As New List(Of String) From {"Id", "grado_id"}
            CargarDatos(tabla, columnasAocultar)
        End If
    End Sub




    'Estudiantes filtrado
    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked Then
            Dim adapter As New escuela_BDDataSetTableAdapters.EstudiantesTableAdapter()
            Dim tabla As DataTable = adapter.obtenerTodosLosEstudiantes()
            Dim columnasAocultar As New List(Of String) From {"e.id", "NombreRepresentante", "seccion", "ApellidoRepresentante", "Expr1", "Expr2", "cedula", "telefono", "Expr3", "grado_id", "g_Grado", "id", "g_Seccion", "representante_id"}
            CargarDatos(tabla, columnasAocultar)
        End If
    End Sub






    'Profesores filtrado
    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked Then
            Dim columnasAocultar As New List(Of String) From {"profesor_id", "grado_seccion_id", "id"}
            Dim adaptador As New escuela_BDDataSetTableAdapters.ProfesoresTableAdapter()
            Dim tabla As DataTable = adaptador.ObtenerTodolosProfesores()
            CargarDatos(tabla, columnasAocultar)
        End If
    End Sub




    'Grados filtrado
    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked Then
            Dim adapter As New escuela_BDDataSetTableAdapters.GradosTableAdapter()
            Dim tabla As DataTable = adapter.obtenerTodosLosGrados()
            Dim columnasAocultar As New List(Of String) From {"id", "grado_seccion_id"}
            CargarDatos(tabla, columnasAocultar)
        End If
    End Sub


    'btn volver
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim inicioForm As New Form9(usuario)
        inicioForm.Show() '
        Me.Close()
    End Sub


    'load
    Private Sub Form7_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MaximizeBox = False
        RadioButton2.Checked = True
    End Sub



    'pdf
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.PrintPreviewControl.Zoom = 1
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim imageBmp As New Bitmap(Me.DataGridView1.Width, Me.DataGridView1.Height)
        DataGridView1.DrawToBitmap(imageBmp, New Rectangle(0, 0, Me.DataGridView1.Width, Me.DataGridView1.Height))
        e.Graphics.DrawImage(imageBmp, 65, 20)
    End Sub

    'buscador filtrado
    Private Sub FiltrarDatos()
        Dim tabla As DataTable = TryCast(DataGridView1.DataSource, DataTable)
        If tabla Is Nothing Then Exit Sub

        Dim textoBusqueda As String = TextBox2.Text.Trim()
        If String.IsNullOrWhiteSpace(textoBusqueda) Then
            tabla.DefaultView.RowFilter = ""
            Exit Sub
        End If

        Dim columnasFiltro = {"nombre", "apellido", "cedula", "telefono", "hijo", "grado", "representante", "seccion", "profesor"}
        Dim condiciones As New List(Of String)

        For Each col In columnasFiltro
            If tabla.Columns.Contains(col) Then
                condiciones.Add(String.Format("CONVERT([{0}], 'System.String') LIKE '%{1}%'", col, textoBusqueda.Replace("'", "''")))
            End If
        Next

        tabla.DefaultView.RowFilter = String.Join(" OR ", condiciones)
    End Sub


    'btn buscar
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        filtrarDatos()
    End Sub
    'btn limpiar
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        TextBox2.Text = ""
        filtrarDatos()
    End Sub
End Class