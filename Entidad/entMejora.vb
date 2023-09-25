Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Mejora_ent

    'defino las variables
    Friend dt As DataTable
    Friend dr As DataRow
    Friend da As SqlClient.SqlDataAdapter
    Friend cnn As New Conexion
    Friend cnntxt As New Conexion_txt

    'defino las propiedades
    Private _id_mejora As Int32
    Public ReadOnly Property id_mejora() As Int32
        Get
            _id_mejora = CInt(dr("id_mejora"))
            Return _id_mejora
        End Get
    end property

    Private _descripcion_mejora As String
    Public Property descripcion_mejora() As String
        Get
            _descripcion_mejora = CStr(dr("descripcion_mejora"))
            Return _descripcion_mejora
        End Get
        Set(ByVal Value As String)
            dr("descripcion_mejora") = Value
        End Set
    end property

    Private _id_tipo_mejora As Int32
    Public Property id_tipo_mejora() As Int32
        Get
            _id_tipo_mejora = CInt(dr("id_tipo_mejora"))
            Return _id_tipo_mejora
        End Get
        Set(ByVal Value As Int32)
            dr("id_tipo_mejora") = Value
        End Set
    end property

    Private _id_sub_proyecto As Int32
    Public Property id_sub_proyecto() As Int32
        Get
            _id_sub_proyecto = CInt(dr("id_sub_proyecto"))
            Return _id_sub_proyecto
        End Get
        Set(ByVal Value As Int32)
            dr("id_sub_proyecto") = Value
        End Set
    end property

    Private _fecha_prevista_cierre As DateTime
    Public Property fecha_prevista_cierre() As DateTime
        Get
            _fecha_prevista_cierre = CDate(dr("fecha_prevista_cierre"))
            Return _fecha_prevista_cierre
        End Get
        Set(ByVal Value As DateTime)
            dr("fecha_prevista_cierre") = Value
        End Set
    end property

    Private _fecha_real As DateTime
    Public Property fecha_real() As DateTime
        Get
            _fecha_real = CDate(dr("fecha_real"))
            Return _fecha_real
        End Get
        Set(ByVal Value As DateTime)
            dr("fecha_real") = Value
        End Set
    end property

    Private _prioridad As Decimal
    Public Property prioridad() As Decimal
        Get
            _prioridad = CDec(dr("prioridad"))
            Return _prioridad
        End Get
        Set(ByVal Value As Decimal)
            dr("prioridad") = Value
        End Set
    end property

    Private _id_usuario As Int32
    Public Property id_usuario() As Int32
        Get
            _id_usuario = CInt(dr("id_usuario"))
            Return _id_usuario
        End Get
        Set(ByVal Value As Int32)
            dr("id_usuario") = Value
        End Set
    end property

    Private _id_usuario_asignado As Int32
    Public Property id_usuario_asignado() As Int32
        Get
            _id_usuario_asignado = CInt(dr("id_usuario_asignado"))
            Return _id_usuario_asignado
        End Get
        Set(ByVal Value As Int32)
            dr("id_usuario_asignado") = Value
        End Set
    end property

    Private _id_origen_mejora As Int32
    Public Property id_origen_mejora() As Int32
        Get
            _id_origen_mejora = CInt(dr("id_origen_mejora"))
            Return _id_origen_mejora
        End Get
        Set(ByVal Value As Int32)
            dr("id_origen_mejora") = Value
        End Set
    end property

    Private _ubicacion_archivos As String
    Public Property ubicacion_archivos() As String
        Get
            _ubicacion_archivos = CStr(dr("ubicacion_archivos"))
            Return _ubicacion_archivos
        End Get
        Set(ByVal Value As String)
            dr("ubicacion_archivos") = Value
        End Set
    end property

    Private _id_responsable_analisis As Int32
    Public Property id_responsable_analisis() As Int32
        Get
            _id_responsable_analisis = CInt(dr("id_responsable_analisis"))
            Return _id_responsable_analisis
        End Get
        Set(ByVal Value As Int32)
            dr("id_responsable_analisis") = Value
        End Set
    end property

    Private _descripcion_causa As String
    Public Property descripcion_causa() As String
        Get
            _descripcion_causa = CStr(dr("descripcion_causa"))
            Return _descripcion_causa
        End Get
        Set(ByVal Value As String)
            dr("descripcion_causa") = Value
        End Set
    end property

    Private _id_metodo_causa As Int32
    Public Property id_metodo_causa() As Int32
        Get
            _id_metodo_causa = CInt(dr("id_metodo_causa"))
            Return _id_metodo_causa
        End Get
        Set(ByVal Value As Int32)
            dr("id_metodo_causa") = Value
        End Set
    end property

    Private _fecha_causa As DateTime
    Public Property fecha_causa() As DateTime
        Get
            _fecha_causa = CDate(dr("fecha_causa"))
            Return _fecha_causa
        End Get
        Set(ByVal Value As DateTime)
            dr("fecha_causa") = Value
        End Set
    end property

    Private _fecha_finalizacion_accion As DateTime
    Public Property fecha_finalizacion_accion() As DateTime
        Get
            _fecha_finalizacion_accion = CDate(dr("fecha_finalizacion_accion"))
            Return _fecha_finalizacion_accion
        End Get
        Set(ByVal Value As DateTime)
            dr("fecha_finalizacion_accion") = Value
        End Set
    end property

    Private _id_usuario_accion_correctiva As Int32
    Public Property id_usuario_accion_correctiva() As Int32
        Get
            _id_usuario_accion_correctiva = CInt(dr("id_usuario_accion_correctiva"))
            Return _id_usuario_accion_correctiva
        End Get
        Set(ByVal Value As Int32)
            dr("id_usuario_accion_correctiva") = Value
        End Set
    end property

    Private _descripcion_accion_correctiva As String
    Public Property descripcion_accion_correctiva() As String
        Get
            _descripcion_accion_correctiva = CStr(dr("descripcion_accion_correctiva"))
            Return _descripcion_accion_correctiva
        End Get
        Set(ByVal Value As String)
            dr("descripcion_accion_correctiva") = Value
        End Set
    end property

    Private _prevision_accion_correctiva As String
    Public Property prevision_accion_correctiva() As String
        Get
            _prevision_accion_correctiva = CStr(dr("prevision_accion_correctiva"))
            Return _prevision_accion_correctiva
        End Get
        Set(ByVal Value As String)
            dr("prevision_accion_correctiva") = Value
        End Set
    end property

    Private _fecha_accion_correctiva As DateTime
    Public Property fecha_accion_correctiva() As DateTime
        Get
            _fecha_accion_correctiva = CDate(dr("fecha_accion_correctiva"))
            Return _fecha_accion_correctiva
        End Get
        Set(ByVal Value As DateTime)
            dr("fecha_accion_correctiva") = Value
        End Set
    end property

    Private _id_usuario_cierre As Int32
    Public Property id_usuario_cierre() As Int32
        Get
            _id_usuario_cierre = CInt(dr("id_usuario_cierre"))
            Return _id_usuario_cierre
        End Get
        Set(ByVal Value As Int32)
            dr("id_usuario_cierre") = Value
        End Set
    end property

    Private _analisis_eficacia As String
    Public Property analisis_eficacia() As String
        Get
            _analisis_eficacia = CStr(dr("analisis_eficacia"))
            Return _analisis_eficacia
        End Get
        Set(ByVal Value As String)
            dr("analisis_eficacia") = Value
        End Set
    end property

    Private _descripcion_cierre As String
    Public Property descripcion_cierre() As String
        Get
            _descripcion_cierre = CStr(dr("descripcion_cierre"))
            Return _descripcion_cierre
        End Get
        Set(ByVal Value As String)
            dr("descripcion_cierre") = Value
        End Set
    end property

    Private _numero_accion_relacionada As Decimal
    Public Property numero_accion_relacionada() As Decimal
        Get
            _numero_accion_relacionada = CDec(dr("numero_accion_relacionada"))
            Return _numero_accion_relacionada
        End Get
        Set(ByVal Value As Decimal)
            dr("numero_accion_relacionada") = Value
        End Set
    end property

    Private _costo_prevencion As Decimal
    Public Property costo_prevencion() As Decimal
        Get
            _costo_prevencion = CDec(dr("costo_prevencion"))
            Return _costo_prevencion
        End Get
        Set(ByVal Value As Decimal)
            dr("costo_prevencion") = Value
        End Set
    end property

    Private _costo_acciones As Decimal
    Public Property costo_acciones() As Decimal
        Get
            _costo_acciones = CDec(dr("costo_acciones"))
            Return _costo_acciones
        End Get
        Set(ByVal Value As Decimal)
            dr("costo_acciones") = Value
        End Set
    end property

    Private _costo_no_calidad As Decimal
    Public Property costo_no_calidad() As Decimal
        Get
            _costo_no_calidad = CDec(dr("costo_no_calidad"))
            Return _costo_no_calidad
        End Get
        Set(ByVal Value As Decimal)
            dr("costo_no_calidad") = Value
        End Set
    end property

    Private _costo_total As Decimal
    Public Property costo_total() As Decimal
        Get
            _costo_total = CDec(dr("costo_total"))
            Return _costo_total
        End Get
        Set(ByVal Value As Decimal)
            dr("costo_total") = Value
        End Set
    end property

    Private _fecha_cierre As DateTime
    Public Property fecha_cierre() As DateTime
        Get
            _fecha_cierre = CDate(dr("fecha_cierre"))
            Return _fecha_cierre
        End Get
        Set(ByVal Value As DateTime)
            dr("fecha_cierre") = Value
        End Set
    end property

    Private _id_estado_mejora As Int32
    Public Property id_estado_mejora() As Int32
        Get
            _id_estado_mejora = CInt(dr("id_estado_mejora"))
            Return _id_estado_mejora
        End Get
        Set(ByVal Value As Int32)
            dr("id_estado_mejora") = Value
        End Set
    End Property


    'procedimiento insertar
    Public Sub Insertar()
        dt = New DataTable("Mejora")
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)

        Me.AsignarTipos()

        Dim cmdins As New SqlCommand("cop_Mejora_Insert", cnn.Coneccion)
        cmdins.CommandType = CommandType.StoredProcedure
        da.InsertCommand = cmdins

        Dim prm As SqlParameter
        prm = da.InsertCommand.Parameters.Add("@id_mejora", SqlDbType.int, 0, "id_mejora")
        prm.Direction = ParameterDirection.Output
        da.InsertCommand.Parameters.Add("@descripcion_mejora", SqlDbType.varchar, 5000, "descripcion_mejora")
        da.InsertCommand.Parameters.Add("@id_tipo_mejora", SqlDbType.int, 4, "id_tipo_mejora")
        da.InsertCommand.Parameters.Add("@id_sub_proyecto", SqlDbType.int, 4, "id_sub_proyecto")
        da.InsertCommand.Parameters.Add("@fecha_prevista_cierre", SqlDbType.datetime, 8, "fecha_prevista_cierre")
        da.InsertCommand.Parameters.Add("@fecha_real", SqlDbType.datetime, 8, "fecha_real")
        da.InsertCommand.Parameters.Add("@prioridad", SqlDbType.decimal, 9, "prioridad")
        da.InsertCommand.Parameters.Add("@id_usuario", SqlDbType.int, 4, "id_usuario")
        da.InsertCommand.Parameters.Add("@id_usuario_asignado", SqlDbType.int, 4, "id_usuario_asignado")
        da.InsertCommand.Parameters.Add("@id_origen_mejora", SqlDbType.int, 4, "id_origen_mejora")
        da.InsertCommand.Parameters.Add("@ubicacion_archivos", SqlDbType.varchar, 5000, "ubicacion_archivos")
        da.InsertCommand.Parameters.Add("@id_responsable_analisis", SqlDbType.int, 4, "id_responsable_analisis")
        da.InsertCommand.Parameters.Add("@descripcion_causa", SqlDbType.varchar, 5000, "descripcion_causa")
        da.InsertCommand.Parameters.Add("@id_metodo_causa", SqlDbType.int, 4, "id_metodo_causa")
        da.InsertCommand.Parameters.Add("@fecha_causa", SqlDbType.datetime, 8, "fecha_causa")
        da.InsertCommand.Parameters.Add("@fecha_finalizacion_accion", SqlDbType.datetime, 8, "fecha_finalizacion_accion")
        da.InsertCommand.Parameters.Add("@id_usuario_accion_correctiva", SqlDbType.int, 4, "id_usuario_accion_correctiva")
        da.InsertCommand.Parameters.Add("@descripcion_accion_correctiva", SqlDbType.varchar, 5000, "descripcion_accion_correctiva")
        da.InsertCommand.Parameters.Add("@prevision_accion_correctiva", SqlDbType.varchar, 5000, "prevision_accion_correctiva")
        da.InsertCommand.Parameters.Add("@fecha_accion_correctiva", SqlDbType.datetime, 8, "fecha_accion_correctiva")
        da.InsertCommand.Parameters.Add("@id_usuario_cierre", SqlDbType.int, 4, "id_usuario_cierre")
        da.InsertCommand.Parameters.Add("@analisis_eficacia", SqlDbType.char, 1, "analisis_eficacia")
        da.InsertCommand.Parameters.Add("@descripcion_cierre", SqlDbType.varchar, 5000, "descripcion_cierre")
        da.InsertCommand.Parameters.Add("@numero_accion_relacionada", SqlDbType.decimal, 9, "numero_accion_relacionada")
        da.InsertCommand.Parameters.Add("@costo_prevencion", SqlDbType.decimal, 9, "costo_prevencion")
        da.InsertCommand.Parameters.Add("@costo_acciones", SqlDbType.decimal, 9, "costo_acciones")
        da.InsertCommand.Parameters.Add("@costo_no_calidad", SqlDbType.decimal, 9, "costo_no_calidad")
        da.InsertCommand.Parameters.Add("@costo_total", SqlDbType.decimal, 9, "costo_total")
        da.InsertCommand.Parameters.Add("@fecha_cierre", SqlDbType.datetime, 8, "fecha_cierre")
        da.InsertCommand.Parameters.Add("@id_estado_mejora", SqlDbType.int, 4, "id_estado_mejora")

        dr = dt.NewRow()
        dr("descripcion_mejora") = ""
        dr("id_tipo_mejora") = 0
        dr("id_sub_proyecto") = 0
        dr("fecha_prevista_cierre") = DateTime.Now
        dr("fecha_real") = DateTime.Now
        dr("prioridad") = 0
        dr("id_usuario") = 0
        dr("id_usuario_asignado") = 0
        dr("id_origen_mejora") = 0
        dr("ubicacion_archivos") = ""
        dr("id_responsable_analisis") = 0
        dr("descripcion_causa") = ""
        dr("id_metodo_causa") = 0
        dr("fecha_causa") = DateTime.Now
        dr("fecha_finalizacion_accion") = DateTime.Now
        dr("id_usuario_accion_correctiva") = 0
        dr("descripcion_accion_correctiva") = ""
        dr("prevision_accion_correctiva") = ""
        dr("fecha_accion_correctiva") = DateTime.Now
        dr("id_usuario_cierre") = 0
        dr("analisis_eficacia") = ""
        dr("descripcion_cierre") = ""
        dr("numero_accion_relacionada") = 0
        dr("costo_prevencion") = 0
        dr("costo_acciones") = 0
        dr("costo_no_calidad") = 0
        dr("costo_total") = 0
        dr("fecha_cierre") = DateTime.Now
        dr("id_estado_mejora") = 0
        dt.Rows.Add(dr)
        CrearComandoUpdate()
    End Sub

    'procedimiento modificar
    Public Sub Modificar(ByVal idMejora As Integer)
        dt = New DataTable("Mejora")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Mejora WHERE id_mejora = @id_Mejora", cnn.Coneccion)
        da.SelectCommand.Parameters.AddWithValue("@id_Mejora", idMejora)
        da.Fill(dt)
        Me.AsignarTipos()
        If dt.Rows.Count = 0 Then
            Throw New Exception("No se a encontrado el Registro")
        Else
            dr = dt.Rows(0)
        End If
        CrearComandoUpdate()
    End Sub

    'procedimiento borrar
    Public Sub Borrar(ByVal idMejora As Integer)
        dt = New DataTable("Mejora")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Mejora WHERE id_mejora = " & _
        idMejora, cnn.Coneccion)
        da.Fill(dt)

        Me.AsignarTipos()

        If dt.Rows.Count = 0 Then
            Exit Sub
        Else
            dr = dt.Rows(0)
        End If

        Try
            Dim cmddel As New SqlCommand("cop_Mejora_Delete", cnn.Coneccion)
            cmddel.CommandType = CommandType.StoredProcedure
            da.DeleteCommand = cmddel
            Dim prm As SqlParameter
            prm = da.DeleteCommand.Parameters.Add("@id_mejora", SqlDbType.Int, 4, "id_mejora")
            dt.Rows(0).Delete()
            CrearComandoUpdate()
            Guardar()
        Catch ex As Exception
            If Err.Number = 5 Then
            End If
        End Try
    End Sub

    'asigno el tipo de datos a los parametros
    Private Sub AsignarTipos()
        For Each dc As DataColumn In dt.Columns
            Select Case dc.ColumnName
                Case "id_mejora"
                    dc.DataType = Type.GetType("System.Int32")
                Case "descripcion_mejora"
                    dc.DataType = Type.GetType("System.String")
                Case "id_tipo_mejora"
                    dc.DataType = Type.GetType("System.Int32")
                Case "id_sub_proyecto"
                    dc.DataType = Type.GetType("System.Int32")
                Case "fecha_prevista_cierre"
                    dc.DataType = Type.GetType("System.DateTime")
                Case "fecha_real"
                    dc.DataType = Type.GetType("System.DateTime")
                Case "prioridad"
                    dc.DataType = Type.GetType("System.Decimal")
                Case "id_usuario"
                    dc.DataType = Type.GetType("System.Int32")
                Case "id_usuario_asignado"
                    dc.DataType = Type.GetType("System.Int32")
                Case "id_origen_mejora"
                    dc.DataType = Type.GetType("System.Int32")
                Case "ubicacion_archivos"
                    dc.DataType = Type.GetType("System.String")
                Case "id_responsable_analisis"
                    dc.DataType = Type.GetType("System.Int32")
                Case "descripcion_causa"
                    dc.DataType = Type.GetType("System.String")
                Case "id_metodo_causa"
                    dc.DataType = Type.GetType("System.Int32")
                Case "fecha_causa"
                    dc.DataType = Type.GetType("System.DateTime")
                Case "fecha_finalizacion_accion"
                    dc.DataType = Type.GetType("System.DateTime")
                Case "id_usuario_accion_correctiva"
                    dc.DataType = Type.GetType("System.Int32")
                Case "descripcion_accion_correctiva"
                    dc.DataType = Type.GetType("System.String")
                Case "prevision_accion_correctiva"
                    dc.DataType = Type.GetType("System.String")
                Case "fecha_accion_correctiva"
                    dc.DataType = Type.GetType("System.DateTime")
                Case "id_usuario_cierre"
                    dc.DataType = Type.GetType("System.Int32")
                Case "analisis_eficacia"
                    dc.DataType = Type.GetType("System.String")
                Case "descripcion_cierre"
                    dc.DataType = Type.GetType("System.String")
                Case "numero_accion_relacionada"
                    dc.DataType = Type.GetType("System.Decimal")
                Case "costo_prevencion"
                    dc.DataType = Type.GetType("System.Decimal")
                Case "costo_acciones"
                    dc.DataType = Type.GetType("System.Decimal")
                Case "costo_no_calidad"
                    dc.DataType = Type.GetType("System.Decimal")
                Case "costo_total"
                    dc.DataType = Type.GetType("System.Decimal")
                Case "fecha_cierre"
                    dc.DataType = Type.GetType("System.DateTime")
                Case "id_estado_mejora"
                    dc.DataType = Type.GetType("System.Int32")
            End Select
        Next
    End Sub

    'creo el commandbuilder
    Private Sub CrearComandoUpdate()
        Dim cmd As New SqlCommandBuilder(da)
        da.UpdateCommand = cmd.GetUpdateCommand
    End Sub

    'cancelo los cambios del datatable
    Public Sub Cancelar()
        dt.Clear()
    End Sub

    'asigno el datatable
    Public Function DataTable() As DataTable
        Return dt
    End Function

    'actualizo la base de datos
    Public Sub Guardar()
        da.Update(dt)
    End Sub

    'funcion que carga el datatable
    Public Function Cargar() As DataTable
        dt = New DataTable("Mejora")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Mejora WHERE id_mejora = 0", cnn.Coneccion)
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)
        Return dt
    End Function

    'funcion de busqueda
    Public Function Buscar(ByVal Nombre As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Mejora_Find", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre", SqlDbType.NChar, 30, "nombre")
        oda.SelectCommand.Parameters("@nombre").Value = Nombre

        oda.Fill(odt)

        Return odt
    End Function

    'funcion de consulta
    Public Function ConsultarTodo() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Mejora_GetAll", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion para llenar el combo
    Public Function GetCmb() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Mejora_GetCmb", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion que trae un registro poniendo el id
    Public Function GetOne(ByVal id_Mejora As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Mejora_GetOne", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_mejora", SqlDbType.Int, 4, "id_mejora")
        oda.SelectCommand.Parameters("@id_mejora").Value = id_Mejora

        oda.Fill(odt)

        Return odt
    End Function

    'controla si existe el registro en la base de datos
    Public Function Exist() As Boolean
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Mejora_Exist", cnn.Coneccion)
        Dim Total As Integer

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@descripcion_mejora", SqlDbType.varchar, 5000, "descripcion_mejora")
        oda.SelectCommand.Parameters("@descripcion_mejora").Value = Me.descripcion_mejora
        oda.SelectCommand.Parameters.Add("@id_tipo_mejora", SqlDbType.int, 4, "id_tipo_mejora")
        oda.SelectCommand.Parameters("@id_tipo_mejora").Value = Me.id_tipo_mejora
        oda.SelectCommand.Parameters.Add("@id_sub_proyecto", SqlDbType.int, 4, "id_sub_proyecto")
        oda.SelectCommand.Parameters("@id_sub_proyecto").Value = Me.id_sub_proyecto
        oda.SelectCommand.Parameters.Add("@fecha_prevista_cierre", SqlDbType.datetime, 8, "fecha_prevista_cierre")
        oda.SelectCommand.Parameters("@fecha_prevista_cierre").Value = Me.fecha_prevista_cierre
        oda.SelectCommand.Parameters.Add("@fecha_real", SqlDbType.datetime, 8, "fecha_real")
        oda.SelectCommand.Parameters("@fecha_real").Value = Me.fecha_real
        oda.SelectCommand.Parameters.Add("@prioridad", SqlDbType.decimal, 9, "prioridad")
        oda.SelectCommand.Parameters("@prioridad").Value = Me.prioridad
        oda.SelectCommand.Parameters.Add("@id_usuario", SqlDbType.int, 4, "id_usuario")
        oda.SelectCommand.Parameters("@id_usuario").Value = Me.id_usuario
        oda.SelectCommand.Parameters.Add("@id_usuario_asignado", SqlDbType.int, 4, "id_usuario_asignado")
        oda.SelectCommand.Parameters("@id_usuario_asignado").Value = Me.id_usuario_asignado
        oda.SelectCommand.Parameters.Add("@id_origen_mejora", SqlDbType.int, 4, "id_origen_mejora")
        oda.SelectCommand.Parameters("@id_origen_mejora").Value = Me.id_origen_mejora
        oda.SelectCommand.Parameters.Add("@ubicacion_archivos", SqlDbType.varchar, 5000, "ubicacion_archivos")
        oda.SelectCommand.Parameters("@ubicacion_archivos").Value = Me.ubicacion_archivos
        oda.SelectCommand.Parameters.Add("@id_responsable_analisis", SqlDbType.int, 4, "id_responsable_analisis")
        oda.SelectCommand.Parameters("@id_responsable_analisis").Value = Me.id_responsable_analisis
        oda.SelectCommand.Parameters.Add("@descripcion_causa", SqlDbType.varchar, 5000, "descripcion_causa")
        oda.SelectCommand.Parameters("@descripcion_causa").Value = Me.descripcion_causa
        oda.SelectCommand.Parameters.Add("@id_metodo_causa", SqlDbType.int, 4, "id_metodo_causa")
        oda.SelectCommand.Parameters("@id_metodo_causa").Value = Me.id_metodo_causa
        oda.SelectCommand.Parameters.Add("@fecha_causa", SqlDbType.datetime, 8, "fecha_causa")
        oda.SelectCommand.Parameters("@fecha_causa").Value = Me.fecha_causa
        oda.SelectCommand.Parameters.Add("@fecha_finalizacion_accion", SqlDbType.datetime, 8, "fecha_finalizacion_accion")
        oda.SelectCommand.Parameters("@fecha_finalizacion_accion").Value = Me.fecha_finalizacion_accion
        oda.SelectCommand.Parameters.Add("@id_usuario_accion_correctiva", SqlDbType.int, 4, "id_usuario_accion_correctiva")
        oda.SelectCommand.Parameters("@id_usuario_accion_correctiva").Value = Me.id_usuario_accion_correctiva
        oda.SelectCommand.Parameters.Add("@descripcion_accion_correctiva", SqlDbType.varchar, 5000, "descripcion_accion_correctiva")
        oda.SelectCommand.Parameters("@descripcion_accion_correctiva").Value = Me.descripcion_accion_correctiva
        oda.SelectCommand.Parameters.Add("@prevision_accion_correctiva", SqlDbType.varchar, 5000, "prevision_accion_correctiva")
        oda.SelectCommand.Parameters("@prevision_accion_correctiva").Value = Me.prevision_accion_correctiva
        oda.SelectCommand.Parameters.Add("@fecha_accion_correctiva", SqlDbType.datetime, 8, "fecha_accion_correctiva")
        oda.SelectCommand.Parameters("@fecha_accion_correctiva").Value = Me.fecha_accion_correctiva
        oda.SelectCommand.Parameters.Add("@id_usuario_cierre", SqlDbType.int, 4, "id_usuario_cierre")
        oda.SelectCommand.Parameters("@id_usuario_cierre").Value = Me.id_usuario_cierre
        oda.SelectCommand.Parameters.Add("@analisis_eficacia", SqlDbType.char, 1, "analisis_eficacia")
        oda.SelectCommand.Parameters("@analisis_eficacia").Value = Me.analisis_eficacia
        oda.SelectCommand.Parameters.Add("@descripcion_cierre", SqlDbType.varchar, 5000, "descripcion_cierre")
        oda.SelectCommand.Parameters("@descripcion_cierre").Value = Me.descripcion_cierre
        oda.SelectCommand.Parameters.Add("@numero_accion_relacionada", SqlDbType.decimal, 9, "numero_accion_relacionada")
        oda.SelectCommand.Parameters("@numero_accion_relacionada").Value = Me.numero_accion_relacionada
        oda.SelectCommand.Parameters.Add("@costo_prevencion", SqlDbType.decimal, 9, "costo_prevencion")
        oda.SelectCommand.Parameters("@costo_prevencion").Value = Me.costo_prevencion
        oda.SelectCommand.Parameters.Add("@costo_acciones", SqlDbType.decimal, 9, "costo_acciones")
        oda.SelectCommand.Parameters("@costo_acciones").Value = Me.costo_acciones
        oda.SelectCommand.Parameters.Add("@costo_no_calidad", SqlDbType.decimal, 9, "costo_no_calidad")
        oda.SelectCommand.Parameters("@costo_no_calidad").Value = Me.costo_no_calidad
        oda.SelectCommand.Parameters.Add("@costo_total", SqlDbType.decimal, 9, "costo_total")
        oda.SelectCommand.Parameters("@costo_total").Value = Me.costo_total
        oda.SelectCommand.Parameters.Add("@fecha_cierre", SqlDbType.datetime, 8, "fecha_cierre")
        oda.SelectCommand.Parameters("@fecha_cierre").Value = Me.fecha_cierre
        oda.SelectCommand.Parameters.Add("@id_estado_mejora", SqlDbType.int, 4, "id_estado_mejora")
        oda.SelectCommand.Parameters("@id_estado_mejora").Value = Me.id_estado_mejora

        oda.Fill(odt)
        Total = CInt(odt.Rows(0).Item("Total").ToString)
        If Total = 0 Then
            Return False  'NO EXISTE
        Else
            Return True 'SI EXISTE
        End If
    End Function

    'borra todos los datos de la tabla
    Public Sub BorrarTodo()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "DELETE FROM Mejora"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'borra todos los datos de la tabla
    Public Sub Truncate()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "TRUNCATE TABLE Mejora"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'inserta un registro en la tabla
    Public Sub InsertOne()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Mejora_InsertOne"

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'importa los datos de una campaña desde el txt
    Public Function Cargar_Archivo(ByVal path As String) As DataTable
        Dim odt As New DataTable("Mejora")

        Dim oda As New System.Data.OleDb.OleDbDataAdapter( _
        "SELECT * FROM Mejora.txt", cnntxt.Coneccion(path))

        oda.Fill(odt)

        Return odt
    End Function


End Class
