Imports System.Data.SqlClient
Imports System.Data
Imports System.IO


Public Class Tarea
    Inherits Tarea_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Tarea As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Tarea", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_tarea", SqlDbType.Int, 4, "id_tarea")
        oda.SelectCommand.Parameters("@id_tarea").Value = id_Tarea

        oda.Fill(odt)
        Return odt
    End Function

    'funcion de consulta
    Public Function GetAll_2() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Tarea_GetAll_2", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

 



        'funcion de consulta
    Public Function GetAll_3() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Tarea_GetAll_3", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion de consulta ok
    Public Function GetAll_4(ByVal id_cliente As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Tarea_GetAll_4", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_cliente", SqlDbType.Int, 4, "id_cliente")
        oda.SelectCommand.Parameters("@id_cliente").Value = id_cliente

        oda.Fill(odt)

        Return odt
    End Function

    'funcion de consulta ok
    Public Function GetAll_5(ByVal id_cliente As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Tarea_GetAll_5", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_cliente", SqlDbType.Int, 4, "id_cliente")
        oda.SelectCommand.Parameters("@id_cliente").Value = id_cliente

        oda.Fill(odt)

        Return odt
    End Function

    'funcion de consulta ok
    Public Function GetAll_6(ByVal id_proyecto As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Tarea_GetAll_6", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_proyecto", SqlDbType.Int, 4, "id_proyecto")
        oda.SelectCommand.Parameters("@id_proyecto").Value = id_proyecto

        oda.Fill(odt)

        Return odt
    End Function

    'funcion de consulta ok
    Public Function GetAll_7(ByVal id_proyecto As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Tarea_GetAll_7", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_proyecto", SqlDbType.Int, 4, "id_proyecto")
        oda.SelectCommand.Parameters("@id_proyecto").Value = id_proyecto

        oda.Fill(odt)

        Return odt
    End Function

    'funcion de consulta ok
    Public Function GetAll_8(ByVal fecha As DateTime) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Tarea_GetAll_8", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@fecha", SqlDbType.DateTime, 8, "fecha")
        oda.SelectCommand.Parameters("@fecha").Value = fecha

        oda.Fill(odt)

        Return odt
    End Function

    'funcion de consulta ok
    Public Function GetAll_9(ByVal fecha As DateTime) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Tarea_GetAll_9", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@fecha", SqlDbType.DateTime, 8, "fecha")
        oda.SelectCommand.Parameters("@fecha").Value = fecha

        oda.Fill(odt)

        Return odt
    End Function

    Public Function GetAllMaestroODT(ByVal bandera As Integer, ByVal id_empresa As Integer, ByVal id_proyecto As Integer, ByVal id_sub_proyecto As Integer, _
                                  ByVal id_usuario As Integer, ByVal id_estado_tarea As Integer, ByVal bandera_estado As Boolean, ByVal todo As Boolean, ByVal usuario As Boolean, ByVal tipo_tarea As Boolean, _
                                  ByVal es_entre_fecha As Boolean, ByVal id_tipo_tarea As Integer, ByVal fecha_inicio As DateTime, ByVal fecha_fin As DateTime) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Tarea_GetAllMaestro", cnn.Coneccion)

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
        oda.SelectCommand.Parameters.Add("@id_estado_tarea", SqlDbType.Int, 4, "id_estado_tarea")
        oda.SelectCommand.Parameters("@id_estado_tarea").Value = id_estado_tarea
        oda.SelectCommand.Parameters.Add("@bandera_estado", SqlDbType.Bit, 4, "bandera_estado")
        oda.SelectCommand.Parameters("@bandera_estado").Value = bandera_estado
        oda.SelectCommand.Parameters.Add("@todo", SqlDbType.Bit, 4, "todo")
        oda.SelectCommand.Parameters("@todo").Value = todo
        oda.SelectCommand.Parameters.Add("@usuario", SqlDbType.Bit, 4, "usuario")
        oda.SelectCommand.Parameters("@usuario").Value = usuario
        oda.SelectCommand.Parameters.Add("@tipo_tarea", SqlDbType.Bit, 4, "tipo_tarea")
        oda.SelectCommand.Parameters("@tipo_tarea").Value = tipo_tarea
        oda.SelectCommand.Parameters.Add("@es_entre_fecha", SqlDbType.Bit, 4, "es_entre_fecha")
        oda.SelectCommand.Parameters("@es_entre_fecha").Value = es_entre_fecha
        oda.SelectCommand.Parameters.Add("@id_tipo_tarea", SqlDbType.Int, 4, "id_tipo_tarea")
        oda.SelectCommand.Parameters("@id_tipo_tarea").Value = id_tipo_tarea
        oda.SelectCommand.Parameters.Add("@fecha_inicio", SqlDbType.DateTime, 8, "fecha_inicio")
        oda.SelectCommand.Parameters("@fecha_inicio").Value = fecha_inicio
        oda.SelectCommand.Parameters.Add("@fecha_fin", SqlDbType.DateTime, 8, "fecha_fin")
        oda.SelectCommand.Parameters("@fecha_fin").Value = fecha_fin

        oda.Fill(odt)

        Dim ods As New DataSet
        oda.Fill(ods, 0, 40, "Tarea")

        Return odt
    End Function

    Public Function GetAllMaestroODSDashboard(ByVal id_usuario As Integer, ByVal fecha As DateTime, ByVal consulta As Integer) As SqlDataAdapter
        Dim oda As New SqlDataAdapter("cop_Tarea_GetAllMaestroDashboard", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@consulta", SqlDbType.Int, 4, "consulta")
        oda.SelectCommand.Parameters("@consulta").Value = consulta
        oda.SelectCommand.Parameters.Add("@id_usuario", SqlDbType.Int, 4, "id_usuario")
        oda.SelectCommand.Parameters("@id_usuario").Value = id_usuario
        oda.SelectCommand.Parameters.Add("@fecha", SqlDbType.DateTime, 8, "fecha")
        oda.SelectCommand.Parameters("@fecha").Value = fecha

        Return oda
    End Function


    Public Function GetAllMaestroODS(ByVal bandera As Integer, ByVal id_empresa As Integer, ByVal id_proyecto As Integer, ByVal id_sub_proyecto As Integer,
                            ByVal id_usuario As Integer, ByVal id_estado_tarea As Integer, ByVal bandera_estado As Boolean, ByVal todo As Boolean, ByVal usuario As Boolean, ByVal tipo_tarea As Boolean, _
                            ByVal es_entre_fecha As Boolean, ByVal id_tipo_tarea As Integer, ByVal fecha_inicio As DateTime, ByVal fecha_fin As DateTime) As SqlDataAdapter
        Dim oda As New SqlDataAdapter("cop_Tarea_GetAllMaestro", cnn.Coneccion)

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
        oda.SelectCommand.Parameters.Add("@id_estado_tarea", SqlDbType.Int, 4, "id_estado_tarea")
        oda.SelectCommand.Parameters("@id_estado_tarea").Value = id_estado_tarea
        oda.SelectCommand.Parameters.Add("@bandera_estado", SqlDbType.Bit, 4, "bandera_estado")
        oda.SelectCommand.Parameters("@bandera_estado").Value = bandera_estado
        oda.SelectCommand.Parameters.Add("@todo", SqlDbType.Bit, 4, "todo")
        oda.SelectCommand.Parameters("@todo").Value = todo
        oda.SelectCommand.Parameters.Add("@usuario", SqlDbType.Bit, 4, "usuario")
        oda.SelectCommand.Parameters("@usuario").Value = usuario
        oda.SelectCommand.Parameters.Add("@tipo_tarea", SqlDbType.Bit, 4, "tipo_tarea")
        oda.SelectCommand.Parameters("@tipo_tarea").Value = tipo_tarea
        oda.SelectCommand.Parameters.Add("@es_entre_fecha", SqlDbType.Bit, 4, "es_entre_fecha")
        oda.SelectCommand.Parameters("@es_entre_fecha").Value = es_entre_fecha
        oda.SelectCommand.Parameters.Add("@id_tipo_tarea", SqlDbType.Int, 4, "id_tipo_tarea")
        oda.SelectCommand.Parameters("@id_tipo_tarea").Value = id_tipo_tarea
        oda.SelectCommand.Parameters.Add("@fecha_inicio", SqlDbType.DateTime, 8, "fecha_inicio")
        oda.SelectCommand.Parameters("@fecha_inicio").Value = fecha_inicio
        oda.SelectCommand.Parameters.Add("@fecha_fin", SqlDbType.DateTime, 8, "fecha_fin")
        oda.SelectCommand.Parameters("@fecha_fin").Value = fecha_fin



        Return oda


    End Function


    'funcion de consulta ok
    Public Function GetAllMailing(ByVal id_empresa As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Tarea_GetAllMailing", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_empresa", SqlDbType.Int, 4, "id_empresa")
        oda.SelectCommand.Parameters("@id_empresa").Value = id_empresa

        oda.Fill(odt)

        Return odt
    End Function

    'funcion de consulta de horas
    Public Function GetAllHorasPrevistas(ByVal id_usuario As Integer, ByVal fecha_inicio As DateTime) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Tarea_GetAllHorasPrevistas", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_usuario", SqlDbType.Int, 4, "id_usuario")
        oda.SelectCommand.Parameters("@id_usuario").Value = id_usuario
        oda.SelectCommand.Parameters.Add("@fecha", SqlDbType.DateTime, 8, "fecha")
        oda.SelectCommand.Parameters("@fecha").Value = fecha_inicio

        oda.Fill(odt)

        Return odt
    End Function

    Public Function GetEntreFecha(ByVal fecha_inicio As DateTime, ByVal fecha_fin As DateTime,
                                  ByVal id_empresa As Integer, ByVal id_proyecto As Integer, ByVal id_subproyecto As Integer, ByVal consulta As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Tarea_GetEntreFecha", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@fecha_inicio", SqlDbType.DateTime, 8, "fecha_inicio")
        oda.SelectCommand.Parameters("@fecha_inicio").Value = fecha_inicio
        oda.SelectCommand.Parameters.Add("@fecha_fin", SqlDbType.DateTime, 8, "fecha_fin")
        oda.SelectCommand.Parameters("@fecha_fin").Value = fecha_fin
        oda.SelectCommand.Parameters.Add("@id_empresa", SqlDbType.Int, 4, "id_empresa")
        oda.SelectCommand.Parameters("@id_empresa").Value = id_empresa
        oda.SelectCommand.Parameters.Add("@id_proyecto", SqlDbType.Int, 4, "id_proyecto")
        oda.SelectCommand.Parameters("@id_proyecto").Value = id_proyecto
        oda.SelectCommand.Parameters.Add("@id_subproyecto", SqlDbType.Int, 4, "id_subproyecto")
        oda.SelectCommand.Parameters("@id_subproyecto").Value = id_subproyecto
        oda.SelectCommand.Parameters.Add("@consulta", SqlDbType.Int, 4, "consulta")
        oda.SelectCommand.Parameters("@consulta").Value = consulta

        oda.Fill(odt)

        Return odt
    End Function
    Public Function GetEntreFechaIngesoft(ByVal fecha_inicio As DateTime, ByVal fecha_fin As DateTime,
                                         ByVal id_empresa As Integer, ByVal id_proyecto As Integer, ByVal id_subproyecto As Integer, ByVal consulta As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Tarea_GetEntreFechaIngesoft", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@fecha_inicio", SqlDbType.DateTime, 8, "fecha_inicio")
        oda.SelectCommand.Parameters("@fecha_inicio").Value = fecha_inicio
        oda.SelectCommand.Parameters.Add("@fecha_fin", SqlDbType.DateTime, 8, "fecha_fin")
        oda.SelectCommand.Parameters("@fecha_fin").Value = fecha_fin
        oda.SelectCommand.Parameters.Add("@id_empresa", SqlDbType.Int, 4, "id_empresa")
        oda.SelectCommand.Parameters("@id_empresa").Value = id_empresa
        oda.SelectCommand.Parameters.Add("@id_proyecto", SqlDbType.Int, 4, "id_proyecto")
        oda.SelectCommand.Parameters("@id_proyecto").Value = id_proyecto
        oda.SelectCommand.Parameters.Add("@id_subproyecto", SqlDbType.Int, 4, "id_subproyecto")
        oda.SelectCommand.Parameters("@id_subproyecto").Value = id_subproyecto
        oda.SelectCommand.Parameters.Add("@consulta", SqlDbType.Int, 4, "consulta")
        oda.SelectCommand.Parameters("@consulta").Value = consulta

        oda.Fill(odt)

        Return odt
    End Function


    'trae el cuadro de control
    Public Function GetAllDashboard(ByVal id_usuario As Integer, ByVal fecha As DateTime) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Tarea_GetAllDashboard", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_usuario", SqlDbType.Int, 4, "id_usuario")
        oda.SelectCommand.Parameters("@id_usuario").Value = id_usuario
        oda.SelectCommand.Parameters.Add("@fecha", SqlDbType.DateTime, 8, "fecha")
        oda.SelectCommand.Parameters("@fecha").Value = fecha

        oda.Fill(odt)

        Return odt
    End Function


    'trae la grilla con los datos filtrados por el cuadro de control
    Public Function GetAllMaestroDashboard(ByVal id_usuario As Integer, ByVal fecha As DateTime, ByVal consulta As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Tarea_GetAllMaestroDashboard", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_usuario", SqlDbType.Int, 4, "id_usuario")
        oda.SelectCommand.Parameters("@id_usuario").Value = id_usuario
        oda.SelectCommand.Parameters.Add("@fecha", SqlDbType.DateTime, 8, "fecha")
        oda.SelectCommand.Parameters("@fecha").Value = fecha
        oda.SelectCommand.Parameters.Add("@consulta", SqlDbType.Int, 4, "consulta")
        oda.SelectCommand.Parameters("@consulta").Value = consulta

        oda.Fill(odt)

        Return odt
    End Function


    'funcion de consulta ok
    Public Function GetAll_Gantt() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Tarea_GetAll_Gantt", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure

        oda.Fill(odt)

        Return odt
    End Function

    'funcion de consulta ok
    Public Function GetAll_Gantt_2(ByVal fecha As DateTime, ByVal id_usuario As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Tarea_GetAll_Gantt_2", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@fecha", SqlDbType.DateTime, 8, "fecha")
        oda.SelectCommand.Parameters("@fecha").Value = fecha
        oda.SelectCommand.Parameters.Add("@id_usuario", SqlDbType.Int, 4, "id_usuario")
        oda.SelectCommand.Parameters("@id_usuario").Value = id_usuario

        oda.Fill(odt)

        Return odt
    End Function

    'funcion de consulta ok
    Public Function GetAll_GanttDetalle(ByVal fecha As DateTime, ByVal id_usuario As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Tarea_GetAll_GanttDetalle", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@fecha", SqlDbType.DateTime, 8, "fecha")
        oda.SelectCommand.Parameters("@fecha").Value = fecha
        oda.SelectCommand.Parameters.Add("@id_usuario", SqlDbType.Int, 4, "id_usuario")
        oda.SelectCommand.Parameters("@id_usuario").Value = id_usuario

        oda.Fill(odt)

        Return odt
    End Function

    'trae inicio y fin
    Public Function GetOne_Fechas(ByVal id_usuario As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Tarea_GetOne_Fechas", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_usuario", SqlDbType.Int, 4, "id_usuario")
        oda.SelectCommand.Parameters("@id_usuario").Value = id_usuario

        oda.Fill(odt)

        Return odt
    End Function

    'trae inicio y fin
    Public Function GetAll_Gantt_Grilla(ByVal id_usuario As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Tarea_GetAll_Gantt_Grilla", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_usuario", SqlDbType.Int, 4, "id_usuario")
        oda.SelectCommand.Parameters("@id_usuario").Value = id_usuario

        oda.Fill(odt)

        Return odt
    End Function


    'consulta si existe un calendario en el sistema
    Public Function GetOneCalendarID(ByVal IDCalendar As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Tarea_GetOneCalendarID", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@IDCalendar", SqlDbType.VarChar, 500, "IDCalendar")
        oda.SelectCommand.Parameters("@IDCalendar").Value = IDCalendar

        oda.Fill(odt)

        Return odt
    End Function

    'funcion de tabla dinamica
    Public Function GetAll_Dinamica(ByVal fecha_desde As DateTime, ByVal fecha_hasta As DateTime) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Tarea_GetAll_Dinamica", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@fecha_desde", SqlDbType.DateTime, 8, "fecha_desde")
        oda.SelectCommand.Parameters("@fecha_desde").Value = fecha_desde
        oda.SelectCommand.Parameters.Add("@fecha_hasta", SqlDbType.DateTime, 8, "fecha_hasta")
        oda.SelectCommand.Parameters("@fecha_hasta").Value = fecha_hasta

        oda.Fill(odt)

        Return odt
    End Function

End Class


