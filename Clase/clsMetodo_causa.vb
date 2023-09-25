Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Metodo_causa
    Inherits Metodo_causa_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Metodo_causa As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Metodo_causa", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_metodo_causa", SqlDbType.Int, 4, "id_metodo_causa")
        oda.SelectCommand.Parameters("@id_metodo_causa").Value = id_Metodo_causa

        oda.Fill(odt)
        Return odt
    End Function

End Class
