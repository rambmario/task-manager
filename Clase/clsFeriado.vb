Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Feriado
    Inherits Feriado_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Feriado As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Feriado", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_feriado", SqlDbType.Int, 4, "id_feriado")
        oda.SelectCommand.Parameters("@id_feriado").Value = id_Feriado

        oda.Fill(odt)
        Return odt
    End Function

    'busca el feriado por fecha
    Public Function GetOne_Fecha(ByVal fecha As DateTime) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Feriado_GetOne_Fecha", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@fecha", SqlDbType.DateTime, 8, "fecha")
        oda.SelectCommand.Parameters("@fecha").Value = fecha

        oda.Fill(odt)
        Return odt
    End Function

End Class
