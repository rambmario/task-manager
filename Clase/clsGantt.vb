Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Gantt
    Inherits Gantt_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Gantt As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Gantt", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_gantt", SqlDbType.Int, 4, "id_gantt")
        oda.SelectCommand.Parameters("@id_gantt").Value = id_Gantt

        oda.Fill(odt)
        Return odt
    End Function

    'ejemplo de consulta con parametros
    Public Function GetAll_2() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Gantt_GetAll_2", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure

        oda.Fill(odt)
        Return odt
    End Function

End Class
