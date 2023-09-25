Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Tipo_usuario
    Inherits Tipo_usuario_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Tipo_usuario As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Tipo_usuario", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_tipo_usuario", SqlDbType.Int, 4, "id_tipo_usuario")
        oda.SelectCommand.Parameters("@id_tipo_usuario").Value = id_Tipo_usuario

        oda.Fill(odt)
        Return odt
    End Function

End Class
