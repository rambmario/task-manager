Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Hora_real
    Inherits Hora_real_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Hora_real As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Hora_real", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_hora_real", SqlDbType.Int, 4, "id_hora_real")
        oda.SelectCommand.Parameters("@id_hora_real").Value = id_Hora_real

        oda.Fill(odt)
        Return odt
    End Function

    'funcion de consulta
    Public Function GetTarea(ByVal id_tarea As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Hora_real_GetTarea", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_tarea", SqlDbType.Int, 4, "id_tarea")
        oda.SelectCommand.Parameters("@id_tarea").Value = id_tarea
        oda.Fill(odt)

        Return odt
    End Function

    Public Sub DeleteTarea(ByVal id_tarea As Integer, ByVal id_usuario As Integer)
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Hora_Real_DeleteTarea"
        Command.Parameters.Add("@id_tarea", SqlDbType.Int, 4, "id_tarea")
        Command.Parameters("@id_tarea").Value = id_tarea

        Command.Parameters.Add("@id_usuario", SqlDbType.Int, 4, "id_usuario")
        Command.Parameters("@id_usuario").Value = id_usuario

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub


    'actualiza los datos relacionados al encabezado
    Public Sub UpdateID(ByVal id_tarea As Integer, ByVal id_usuario As Integer)
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Hora_Real_UpdateID"
        Command.Parameters.Add("@id_tarea", SqlDbType.Int, 4, "id_tarea")
        Command.Parameters("@id_tarea").Value = id_tarea
        Command.Parameters.Add("@id_usuario", SqlDbType.Int, 4, "id_usuario")
        Command.Parameters("@id_usuario").Value = id_usuario

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

End Class
