Imports System.Data.OleDb
Public Class Form8

 

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        
        Dim usuario As String = txtUsuario.Text
        Dim contraseña As String = txtContraseña.Text
        Dim adapter As New escuela_BDDataSetTableAdapters.UsuariosTableAdapter()
        Dim resultado As DataTable = adapter.verificarUsuario(usuario, contraseña)

        If resultado IsNot Nothing AndAlso resultado.Rows.Count > 0 Then
            MessageBox.Show("¡Bienvenido!", "Inicio de sesion exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtUsuario.Text = ""
            txtContraseña.Text = ""
            Me.Hide()
            Dim inicioForm As New Form9(usuario)
            inicioForm.Show() '
        Else
            MessageBox.Show("Usuario no registrado en el sistema", "Los datos no coinciden", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtUsuario.Text = ""
            txtContraseña.Text = ""
        End If

    End Sub

    Private Sub Form8_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MaximizeBox = False
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        End
    End Sub
End Class