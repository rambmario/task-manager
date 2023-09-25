Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Tipo_mejora
    Inherits Tipo_mejora_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Tipo_mejora As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Tipo_mejora", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_tipo_mejora", SqlDbType.Int, 4, "id_tipo_mejora")
        oda.SelectCommand.Parameters("@id_tipo_mejora").Value = id_Tipo_mejora

        oda.Fill(odt)
        Return odt
    End Function

End Class
