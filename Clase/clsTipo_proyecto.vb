Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Tipo_proyecto
    Inherits Tipo_proyecto_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Tipo_proyecto As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Tipo_proyecto", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_tipo_proyecto", SqlDbType.Int, 4, "id_tipo_proyecto")
        oda.SelectCommand.Parameters("@id_tipo_proyecto").Value = id_Tipo_proyecto

        oda.Fill(odt)
        Return odt
    End Function

End Class
