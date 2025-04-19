Public Class Form12

    Private usuario As String
    Public Sub New(ByVal _usuario As String)
        InitializeComponent()
        usuario = _usuario
    End Sub

    Public id_grado As Integer
    Public grado As Integer
    Public seccion As String

    Private Sub Form12_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        gradoLabel.Text = grado
        seccionLabel.Text = seccion

        gradoA.Text = grado
        seccionA.Text = seccion
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            If gradoA.Text <> "" And seccionA.Text <> "" Then

                Dim adapter As New escuela_BDDataSetTableAdapters.GradosTableAdapter()
                Dim resultado As Integer = adapter.existeGrado(gradoA.Text, seccionA.Text)


                If resultado > 0 Then
                    MessageBox.Show("Este grado ya se encuentra registrado en el sistema")
                Else
                    adapter.nuevoGrado(gradoA.Text, id_grado)
                    adapter.nuevoSeccion(seccionA.Text.ToUpper(), id_grado)
                    MessageBox.Show("Datos Actualizados")
                    Me.DialogResult = DialogResult.OK
                    Me.Close()
                End If
            Else
                MessageBox.Show("Complete todos los datos")
            End If
        Catch ex As Exception
            MessageBox.Show("Ingrese un valor valido para grados")
        End Try

    End Sub
End Class