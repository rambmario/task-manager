Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Proyecto
    Inherits Proyecto_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Proyecto As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Proyecto", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_proyecto", SqlDbType.Int, 4, "id_proyecto")
        oda.SelectCommand.Parameters("@id_proyecto").Value = id_Proyecto

        oda.Fill(odt)
        Return odt
    End Function

    'funcion para llenar el combo
    Public Function GetCmbEmpresa(ByVal id_empresa As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Proyecto_GetCmbEmpresa", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_empresa", SqlDbType.Int, 4, "id_empresa")
        oda.SelectCommand.Parameters("@id_empresa").Value = id_empresa
        oda.Fill(odt)

        Return odt
    End Function

    Public Function GetAll_2() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Proyecto_GetAll_2", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

End Class
