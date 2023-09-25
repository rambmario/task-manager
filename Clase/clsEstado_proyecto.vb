Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Estado_proyecto
    Inherits Estado_proyecto_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Estado_proyecto As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Estado_proyecto", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_estado_proyecto", SqlDbType.Int, 4, "id_estado_proyecto")
        oda.SelectCommand.Parameters("@id_estado_proyecto").Value = id_Estado_proyecto

        oda.Fill(odt)
        Return odt
    End Function

End Class
