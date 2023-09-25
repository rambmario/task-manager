Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Usuario
    Inherits Usuario_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Usuario As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Usuario", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_usuario", SqlDbType.Int, 4, "id_usuario")
        oda.SelectCommand.Parameters("@id_usuario").Value = id_Usuario

        oda.Fill(odt)
        Return odt
    End Function



    'funcion para llenar el combo
    Public Function GetCmbAsignado(ByVal id_empresa As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Usuario_GetCmbAsignado", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_empresa", SqlDbType.Int, 4, "id_empresa")
        oda.SelectCommand.Parameters("@id_empresa").Value = id_empresa
        oda.Fill(odt)

        Return odt
    End Function

    'controla el usuario
    Public Function GetUser(ByVal nombre_usuario As String, ByVal password_usuario As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Usuario_GetUser", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre_usuario", SqlDbType.VarChar, 50, "nombre_usuario")
        oda.SelectCommand.Parameters("@nombre_usuario").Value = nombre_usuario
        oda.SelectCommand.Parameters.Add("@password_usuario", SqlDbType.VarChar, 50, "password_usuario")
        oda.SelectCommand.Parameters("@password_usuario").Value = password_usuario

        oda.Fill(odt)
        Return odt
    End Function

    Public Function GetAll_3() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Usuario_GetAll_3", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

End Class
