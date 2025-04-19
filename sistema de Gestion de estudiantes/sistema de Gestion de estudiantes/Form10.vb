Public Class Form10


    Private usuario As String


    Public Sub New(ByVal _usuario As String)
        InitializeComponent()
        usuario = _usuario
    End Sub

    Private Sub Form10_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MaximizeBox = False
        Me.UsuariosTableAdapter.Fill(Me.Escuela_BDDataSet.Usuarios)
        nombre.Text = usuario

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try

            Dim filaSeleccionada As DataGridViewRow = DataGridView1.CurrentRow
            If filaSeleccionada IsNot Nothing Then
                Dim idUsuario As Integer = Convert.ToInt32(filaSeleccionada.Cells("IdDataGridViewTextBoxColumn").Value)
                Dim adapter As New escuela_BDDataSetTableAdapters.UsuariosTableAdapter()
                adapter.eliminarUsuario(idUsuario)


                MessageBox.Show("usuario eliminado")

                Me.UsuariosTableAdapter.Fill(Me.Escuela_BDDataSet.Usuarios)

            Else
                MessageBox.Show("Selecciona un usuario para eliminar.")
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim inicioForm As New Form9(usuario)
        inicioForm.Show() '
        Me.Close()

    End Sub

    Function RegistrarUsuario(ByVal user As String, ByVal pass As String) As Boolean
        Try
            Dim adapter As New escuela_BDDataSetTableAdapters.UsuariosTableAdapter()
            adapter.insertarUsuario(user, pass)

            Return True
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim usuario As String = txtUsuario.Text.Trim()
        Dim contraseña As String = txtContraseña.Text.Trim()
        Dim adapter As New escuela_BDDataSetTableAdapters.UsuariosTableAdapter()
        Dim verificar As Integer = adapter.existeUsuario(usuario, contraseña)


        If usuario = "" OrElse contraseña = "" Then
            MessageBox.Show("Ingrese todos los datos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.UsuariosTableAdapter.Fill(Me.Escuela_BDDataSet.Usuarios)
            Exit Sub
        Else
            If verificar > 0 Then
                MessageBox.Show("Este usuario ya se encuentra registrado en el sistema", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtUsuario.Text = ""
                txtContraseña.Text = ""
            Else
                ' Intentar registrar el usuario
                If RegistrarUsuario(usuario, contraseña) Then
                    MessageBox.Show("Usuario registrado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.UsuariosTableAdapter.Fill(Me.Escuela_BDDataSet.Usuarios)
                End If
            End If
        End If
        
    End Sub

  
End Class