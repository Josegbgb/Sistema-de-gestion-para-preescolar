Public Class Form9

    Private usuario As String

    Public Sub New(ByVal _usuario As String)
        InitializeComponent()
        usuario = _usuario
    End Sub

    Private Sub Grados_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Grados.Click
        Dim inicioForm As New Form1(usuario)
        inicioForm.Show() '
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim inicioForm As New Form2(usuario)
        inicioForm.Show() '
        Me.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim inicioForm As New Form5(usuario)
        inicioForm.Show() '
        Me.Close()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim inicioForm As New Form10(usuario)
        inicioForm.Show() '
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
        Form8.Show()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim inicioForm As New Form7(usuario)
        inicioForm.Show() '
        Me.Close()
    End Sub

    Private Sub Form9_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MaximizeBox = False
        Label2.Text = usuario
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        End
    End Sub

    Private Sub SplitContainer1_Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles SplitContainer1.Panel2.Paint

    End Sub
End Class