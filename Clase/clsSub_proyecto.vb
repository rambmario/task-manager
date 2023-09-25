Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Sub_proyecto
    Inherits Sub_proyecto_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Sub_proyecto As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Sub_proyecto", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_sub_proyecto", SqlDbType.Int, 4, "id_sub_proyecto")
        oda.SelectCommand.Parameters("@id_sub_proyecto").Value = id_Sub_proyecto

        oda.Fill(odt)
        Return odt
    End Function

    'funcion para llenar el combo
    Public Function GetCmbProyecto(ByVal id_proyecto As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Sub_proyecto_GetCmbProyecto", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_proyecto", SqlDbType.Int, 4, "id_proyecto")
        oda.SelectCommand.Parameters("@id_proyecto").Value = id_proyecto
        oda.Fill(odt)

        Return odt
    End Function

    Public Function GetAll_2() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Sub_proyecto_GetAll_2", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion de busqueda
    Public Function Find_2(ByVal Nombre As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Sub_proyecto_Find_2", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre", SqlDbType.NChar, 30, "nombre")
        oda.SelectCommand.Parameters("@nombre").Value = Nombre

        oda.Fill(odt)

        Return odt
    End Function

End Class
