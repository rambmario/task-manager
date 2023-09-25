Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Mejora
    Inherits Mejora_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Mejora As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Mejora", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_mejora", SqlDbType.Int, 4, "id_mejora")
        oda.SelectCommand.Parameters("@id_mejora").Value = id_Mejora

        oda.Fill(odt)
        Return odt
    End Function

    Public Function GetAllMaestroODT(ByVal bandera As Integer, ByVal id_empresa As Integer, ByVal id_proyecto As Integer, ByVal id_sub_proyecto As Integer, _
                              ByVal id_usuario As Integer, ByVal id_estado_mejora As Integer, ByVal bandera_estado As Boolean, ByVal todo As Boolean, ByVal usuario As Boolean, ByVal tipo_mejora As Boolean, _
                              ByVal es_entre_fecha As Boolean, ByVal id_tipo_mejora As Integer, ByVal fecha_inicio As DateTime, ByVal fecha_fin As DateTime) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Mejora_GetAllMaestro", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@bandera", SqlDbType.Int, 4, "bandera")
        oda.SelectCommand.Parameters("@bandera").Value = bandera
        oda.SelectCommand.Parameters.Add("@id_empresa", SqlDbType.Int, 4, "id_empresa")
        oda.SelectCommand.Parameters("@id_empresa").Value = id_empresa
        oda.SelectCommand.Parameters.Add("@id_proyecto", SqlDbType.Int, 4, "id_proyecto")
        oda.SelectCommand.Parameters("@id_proyecto").Value = id_proyecto
        oda.SelectCommand.Parameters.Add("@id_sub_proyecto", SqlDbType.Int, 4, "id_sub_proyecto")
        oda.SelectCommand.Parameters("@id_sub_proyecto").Value = id_sub_proyecto
        oda.SelectCommand.Parameters.Add("@id_usuario", SqlDbType.Int, 4, "id_usuario")
        oda.SelectCommand.Parameters("@id_usuario").Value = id_usuario
        oda.SelectCommand.Parameters.Add("@id_estado_mejora", SqlDbType.Int, 4, "id_estado_mejora")
        oda.SelectCommand.Parameters("@id_estado_mejora").Value = id_estado_mejora
        oda.SelectCommand.Parameters.Add("@bandera_estado", SqlDbType.Bit, 4, "bandera_estado")
        oda.SelectCommand.Parameters("@bandera_estado").Value = bandera_estado
        oda.SelectCommand.Parameters.Add("@todo", SqlDbType.Bit, 4, "todo")
        oda.SelectCommand.Parameters("@todo").Value = todo
        oda.SelectCommand.Parameters.Add("@usuario", SqlDbType.Bit, 4, "usuario")
        oda.SelectCommand.Parameters("@usuario").Value = usuario
        oda.SelectCommand.Parameters.Add("@tipo_mejora", SqlDbType.Bit, 4, "tipo_mejora")
        oda.SelectCommand.Parameters("@tipo_mejora").Value = tipo_mejora
        oda.SelectCommand.Parameters.Add("@es_entre_fecha", SqlDbType.Bit, 4, "es_entre_fecha")
        oda.SelectCommand.Parameters("@es_entre_fecha").Value = es_entre_fecha
        oda.SelectCommand.Parameters.Add("@id_tipo_mejora", SqlDbType.Int, 4, "id_tipo_mejora")
        oda.SelectCommand.Parameters("@id_tipo_mejora").Value = id_tipo_mejora
        oda.SelectCommand.Parameters.Add("@fecha_inicio", SqlDbType.DateTime, 8, "fecha_inicio")
        oda.SelectCommand.Parameters("@fecha_inicio").Value = fecha_inicio
        oda.SelectCommand.Parameters.Add("@fecha_fin", SqlDbType.DateTime, 8, "fecha_fin")
        oda.SelectCommand.Parameters("@fecha_fin").Value = fecha_fin

        oda.Fill(odt)

        Dim ods As New DataSet
        oda.Fill(ods, 0, 40, "Mejora")


        Return odt


    End Function
    Public Function GetAllMaestroODS(ByVal bandera As Integer, ByVal id_empresa As Integer, ByVal id_proyecto As Integer, ByVal id_sub_proyecto As Integer,
                                ByVal id_usuario As Integer, ByVal id_estado_mejora As Integer, ByVal bandera_estado As Boolean, ByVal todo As Boolean, ByVal usuario As Boolean, ByVal tipo_mejora As Boolean, _
                                ByVal es_entre_fecha As Boolean, ByVal id_tipo_mejora As Integer, ByVal fecha_inicio As DateTime, ByVal fecha_fin As DateTime) As SqlDataAdapter
        Dim oda As New SqlDataAdapter("cop_Mejora_GetAllMaestro", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@bandera", SqlDbType.Int, 4, "bandera")
        oda.SelectCommand.Parameters("@bandera").Value = bandera
        oda.SelectCommand.Parameters.Add("@id_empresa", SqlDbType.Int, 4, "id_empresa")
        oda.SelectCommand.Parameters("@id_empresa").Value = id_empresa
        oda.SelectCommand.Parameters.Add("@id_proyecto", SqlDbType.Int, 4, "id_proyecto")
        oda.SelectCommand.Parameters("@id_proyecto").Value = id_proyecto
        oda.SelectCommand.Parameters.Add("@id_sub_proyecto", SqlDbType.Int, 4, "id_sub_proyecto")
        oda.SelectCommand.Parameters("@id_sub_proyecto").Value = id_sub_proyecto
        oda.SelectCommand.Parameters.Add("@id_usuario", SqlDbType.Int, 4, "id_usuario")
        oda.SelectCommand.Parameters("@id_usuario").Value = id_usuario
        oda.SelectCommand.Parameters.Add("@id_estado_mejora", SqlDbType.Int, 4, "id_estado_mejora")
        oda.SelectCommand.Parameters("@id_estado_mejora").Value = id_estado_mejora
        oda.SelectCommand.Parameters.Add("@bandera_estado", SqlDbType.Bit, 4, "bandera_estado")
        oda.SelectCommand.Parameters("@bandera_estado").Value = bandera_estado
        oda.SelectCommand.Parameters.Add("@todo", SqlDbType.Bit, 4, "todo")
        oda.SelectCommand.Parameters("@todo").Value = todo
        oda.SelectCommand.Parameters.Add("@usuario", SqlDbType.Bit, 4, "usuario")
        oda.SelectCommand.Parameters("@usuario").Value = usuario
        oda.SelectCommand.Parameters.Add("@tipo_mejora", SqlDbType.Bit, 4, "tipo_mejora")
        oda.SelectCommand.Parameters("@tipo_mejora").Value = tipo_mejora
        oda.SelectCommand.Parameters.Add("@es_entre_fecha", SqlDbType.Bit, 4, "es_entre_fecha")
        oda.SelectCommand.Parameters("@es_entre_fecha").Value = es_entre_fecha
        oda.SelectCommand.Parameters.Add("@id_tipo_mejora", SqlDbType.Int, 4, "id_tipo_mejora")
        oda.SelectCommand.Parameters("@id_tipo_mejora").Value = id_tipo_mejora
        oda.SelectCommand.Parameters.Add("@fecha_inicio", SqlDbType.DateTime, 8, "fecha_inicio")
        oda.SelectCommand.Parameters("@fecha_inicio").Value = fecha_inicio
        oda.SelectCommand.Parameters.Add("@fecha_fin", SqlDbType.DateTime, 8, "fecha_fin")
        oda.SelectCommand.Parameters("@fecha_fin").Value = fecha_fin



        Return oda


    End Function

End Class
