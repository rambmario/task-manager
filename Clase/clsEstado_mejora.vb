Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Estado_mejora
    Inherits Estado_mejora_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Estado_mejora As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Estado_mejora", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_estado_mejora", SqlDbType.Int, 4, "id_estado_mejora")
        oda.SelectCommand.Parameters("@id_estado_mejora").Value = id_Estado_mejora

        oda.Fill(odt)
        Return odt
    End Function

End Class
