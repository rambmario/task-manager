Public Class Conexion
    Private ocnn As SqlClient.SqlConnection

    Public Function Coneccion() As SqlClient.SqlConnection
        Dim strServer As String
        Dim strDB As String
        Dim strUser As String
        Dim strPass As String
        Dim strPort As String



        strServer = ".\SQLEXPRESS19"
        strDB = "Gestion_tarea"

        ocnn = New SqlClient.SqlConnection

        'ocnn.ConnectionString = "Server=" & strServer & ";" & _
        '                        "DataBase=" & strDB & ";" & _
        '                        "User ID=" & strUser & ";" & _
        '                        "Password=" & strPass & ";" & _
        '                        "Trusted_Connection=false"


        ocnn.ConnectionString = "Server=" & strServer & ";" &
                        "DataBase=" & strDB & ";" &
                        "Trusted_Connection=true"

        Return ocnn
    End Function

    Public Sub Abrir()
        ocnn.Open()
    End Sub

    Public Sub Cerrar()
        ocnn.Close()
    End Sub

    Public Function Verificar() As Boolean
        Try
            ocnn.Open()
        Catch ex As Exception
            Return False
        End Try
        ocnn.Close()
        Return True
    End Function


End Class
