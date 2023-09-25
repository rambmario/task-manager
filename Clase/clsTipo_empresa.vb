Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Tipo_empresa
    Inherits Tipo_empresa_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Tipo_empresa As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Tipo_empresa", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_tipo_empresa", SqlDbType.Int, 4, "id_tipo_empresa")
        oda.SelectCommand.Parameters("@id_tipo_empresa").Value = id_Tipo_empresa

        oda.Fill(odt)
        Return odt
    End Function

End Class
