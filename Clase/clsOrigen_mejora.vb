Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Origen_mejora
    Inherits Origen_mejora_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Origen_mejora As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Origen_mejora", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_origen_mejora", SqlDbType.Int, 4, "id_origen_mejora")
        oda.SelectCommand.Parameters("@id_origen_mejora").Value = id_Origen_mejora

        oda.Fill(odt)
        Return odt
    End Function

End Class
