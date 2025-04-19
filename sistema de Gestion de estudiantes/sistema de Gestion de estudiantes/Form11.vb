Public Class Form11
    Private usuario As String
    Public Sub New(ByVal _usuario As String)
        InitializeComponent()
        usuario = _usuario
    End Sub
    Public idFila As Integer
    Public nombre As String
    Public apellido As String
    Public nombreRepresentante As String
    Public apellidoRepresentante As String
    Public cedula As Integer
    Public telefono As String



    Private Sub Form11_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        nombreE.Text = nombre
        apellidoE.Text = apellido
        nombreR.Text = nombreRepresentante
        apellidoR.Text = apellidoRepresentante
        cedulaR.Text = cedula
        telefonoR.Text = telefono
    End Sub

 

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            If nombreE.Text <> "" And apellidoE.Text <> "" And nombreR.Text <> "" And apellidoR.Text <> "" And cedulaR.Text <> "" And telefonoR.Text <> "" Then
                Dim adapter As New escuela_BDDataSetTableAdapters.EstudiantesTableAdapter()
                Dim adapterRepresentante As New escuela_BDDataSetTableAdapters.RepresentantesTableAdapter()

                Dim RepresentanteId As Integer

                adapter.NuevoNombre(nombreE.Text, idFila)
                adapter.nuevoApellido(apellidoE.Text, idFila)

                RepresentanteId = adapterRepresentante.representanteId(idFila)

                adapterRepresentante.nuevoNombreRepresentante(nombreR.Text, RepresentanteId)
                adapterRepresentante.nuevoApellidoRepresentante(apellidoR.Text, RepresentanteId)
                adapterRepresentante.nuevaCedulaRepresentante(cedulaR.Text, RepresentanteId)
                adapterRepresentante.nuevoTelefonoRepresentante(telefonoR.Text, RepresentanteId)


                MessageBox.Show("Datos Actualizados")

                Me.DialogResult = DialogResult.OK
                Me.Close()
            Else
                MessageBox.Show("Complete todos los datos")
            End If
            

        Catch ex As Exception
            MessageBox.Show("Ingrese un valor valido para numero de cedula")
        End Try

    End Sub

End Class