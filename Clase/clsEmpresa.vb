Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Empresa
    Inherits Empresa_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Empresa As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Empresa", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_empresa", SqlDbType.Int, 4, "id_empresa")
        oda.SelectCommand.Parameters("@id_empresa").Value = id_Empresa

        oda.Fill(odt)
        Return odt
    End Function

    Public Function GetAll_2() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Empresa_GetAll_2", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure

        oda.Fill(odt)

        Return odt
    End Function

    Public Function GetAllTipo(ByVal id_tipo_empresa As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Empresa_GetAllTipo", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_tipo_empresa", SqlDbType.Int, 4, "id_tipo_empresa")
        oda.SelectCommand.Parameters("@id_tipo_empresa").Value = id_tipo_empresa

        oda.Fill(odt)

        Return odt
    End Function

End Class
