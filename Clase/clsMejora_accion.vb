Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Mejora_accion
    Inherits Mejora_accion_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Mejora_accion As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Mejora_accion", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_mejora_accion", SqlDbType.Int, 4, "id_mejora_accion")
        oda.SelectCommand.Parameters("@id_mejora_accion").Value = id_Mejora_accion

        oda.Fill(odt)
        Return odt
    End Function

    Public Function GetAll_2(ByVal id_mejora As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Mejora_accion_GetAll_2", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_mejora", SqlDbType.Int, 4, "id_mejora")
        oda.SelectCommand.Parameters("@id_mejora").Value = id_mejora

        oda.Fill(odt)
        Return odt
    End Function

    Public Sub UpdateID(ByVal id_mejora As Integer)
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Mejora_accion_UpdateID"
        Command.Parameters.Add("@id_mejora", SqlDbType.Int, 4, "id_mejora")
        Command.Parameters("@id_mejora").Value = id_mejora

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

End Class
