Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Cliente
    Inherits Cliente_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Cliente As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Cliente", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_cliente", SqlDbType.Int, 4, "id_cliente")
        oda.SelectCommand.Parameters("@id_cliente").Value = id_Cliente

        oda.Fill(odt)
        Return odt
    End Function


    'Public Function GetCmb_2(ByVal id_proyecto As Integer) As DataTable
    '    Dim odt As New DataTable
    '    Dim oda As New SqlDataAdapter("cop_Cliente_GetCmb_2", cnn.Coneccion)

    '    oda.SelectCommand.CommandType = CommandType.StoredProcedure
    '    oda.SelectCommand.Parameters.Add("@id_proyecto", SqlDbType.Int, 4, "id_proyecto")
    '    oda.SelectCommand.Parameters("@id_proyecto").Value = id_proyecto

    '    oda.Fill(odt)
    '    Return odt
    'End Function


    Public Function GetAll_2() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Cliente_GetAll_2", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    Public Function Find_2(ByVal Nombre As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Cliente_Find_2", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre", SqlDbType.NChar, 30, "nombre")
        oda.SelectCommand.Parameters("@nombre").Value = Nombre

        oda.Fill(odt)

        Return odt
    End Function

End Class
