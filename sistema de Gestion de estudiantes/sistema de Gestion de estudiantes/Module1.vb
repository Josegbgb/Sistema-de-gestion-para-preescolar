Module Module1
    Public Sub Main()

        Dim dbPath As String = IO.Path.Combine(Application.StartupPath, "escuela BD.accdb")
        Dim nuevaCadena As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & dbPath


        My.Settings("escuela_BDConnectionString") = nuevaCadena


        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)
        Application.Run(New Form8())
    End Sub
End Module
