Public Class Form13

    Private usuario As String
    Public Sub New(ByVal _usuario As String)
        InitializeComponent()
        usuario = _usuario
    End Sub
    Public idFila As Integer
    Public nombre As String
    Public apellido As String
    Public cedula As Integer
    Public telefono As String


    Private Sub Form13_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        nombreP.Text = nombre
        apellidoP.Text = apellido
        cedulaP.Text = cedula
        telefonoP.Text = telefono

    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If nombreP.Text <> "" And apellidoP.Text <> "" And cedulaP.Text <> "" And telefonoP.Text <> "" Then

            Dim adapter As New escuela_BDDataSetTableAdapters.ProfesoresTableAdapter()
            Dim resultado As Integer = adapter.existeProfesor(cedulaP.Text)
            Dim verificarCedulaConId As DataTable = adapter.verificarCedulaConId(idFila)







            If resultado > 0 Then


                If verificarCedulaConId IsNot Nothing AndAlso verificarCedulaConId.Rows.Count > 0 Then

                    Dim cedulaBaseDeDatos As Integer = verificarCedulaConId.Rows(0)("cedula")
                    MessageBox.Show(cedulaBaseDeDatos)


                    If cedulaBaseDeDatos = cedulaP.Text Then

                        adapter.nuevoNombre(nombreP.Text, idFila)
                        adapter.nuevoApellido(apellidoP.Text, idFila)
                        adapter.nuevaCedula(cedulaP.Text, idFila)
                        adapter.nuevoTelefono(telefonoP.Text, idFila)

                        MessageBox.Show("Datos Actualizados")

                        Me.DialogResult = DialogResult.OK
                        Me.Close()


                    Else
                        MessageBox.Show("Numero de cedula ya registrado en el sistema")
                    End If
                End If

            Else
                adapter.nuevoNombre(nombreP.Text, idFila)
                adapter.nuevoApellido(apellidoP.Text, idFila)
                adapter.nuevaCedula(cedulaP.Text, idFila)
                adapter.nuevoTelefono(telefonoP.Text, idFila)

                MessageBox.Show("Datos Actualizados")

                Me.DialogResult = DialogResult.OK
                Me.Close()
            End If
        Else
            MessageBox.Show("Complete todos los datos")
        End If


    End Sub
End Class