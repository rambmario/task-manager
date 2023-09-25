Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Estado_tarea
    Inherits Estado_tarea_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Estado_tarea As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Estado_tarea", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_estado_tarea", SqlDbType.Int, 4, "id_estado_tarea")
        oda.SelectCommand.Parameters("@id_estado_tarea").Value = id_Estado_tarea

        oda.Fill(odt)
        Return odt
    End Function

End Class
