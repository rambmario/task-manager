Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Tipo_tarea
    Inherits Tipo_tarea_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Tipo_tarea As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Tipo_tarea", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_tipo_tarea", SqlDbType.Int, 4, "id_tipo_tarea")
        oda.SelectCommand.Parameters("@id_tipo_tarea").Value = id_Tipo_tarea

        oda.Fill(odt)
        Return odt
    End Function

End Class
