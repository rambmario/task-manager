Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Tarea_ent

    'defino las variables
    Friend dt As DataTable
    Friend dr As DataRow
    Friend da As SqlClient.SqlDataAdapter
    Friend cnn As New Conexion
    Friend cnntxt As New Conexion_txt

    'defino las propiedades
    Private _id_tarea As Int32
    Public ReadOnly Property id_tarea() As Int32
        Get
            _id_tarea = CInt(dr("id_tarea"))
            Return _id_tarea
        End Get
    end property

    Private _id_tipo_tarea As Int32
    Public Property id_tipo_tarea() As Int32
        Get
            _id_tipo_tarea = CInt(dr("id_tipo_tarea"))
            Return _id_tipo_tarea
        End Get
        Set(ByVal Value As Int32)
            dr("id_tipo_tarea") = Value
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

    Private _nombre_tarea As String
    Public Property nombre_tarea() As String
        Get
            _nombre_tarea = CStr(dr("nombre_tarea"))
            Return _nombre_tarea
        End Get
        Set(ByVal Value As String)
            dr("nombre_tarea") = Value
        End Set
    end property

    Private _fecha_pedido As DateTime
    Public Property fecha_pedido() As DateTime
        Get
            _fecha_pedido = CDate(dr("fecha_pedido"))
            Return _fecha_pedido
        End Get
        Set(ByVal Value As DateTime)
            dr("fecha_pedido") = Value
        End Set
    end property

    Private _fecha_inicio As DateTime
    Public Property fecha_inicio() As DateTime
        Get
            _fecha_inicio = CDate(dr("fecha_inicio"))
            Return _fecha_inicio
        End Get
        Set(ByVal Value As DateTime)
            dr("fecha_inicio") = Value
        End Set
    end property

    Private _fecha_fin As DateTime
    Public Property fecha_fin() As DateTime
        Get
            _fecha_fin = CDate(dr("fecha_fin"))
            Return _fecha_fin
        End Get
        Set(ByVal Value As DateTime)
            dr("fecha_fin") = Value
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

    Private _ubicacion_documento As String
    Public Property ubicacion_documento() As String
        Get
            _ubicacion_documento = CStr(dr("ubicacion_documento"))
            Return _ubicacion_documento
        End Get
        Set(ByVal Value As String)
            dr("ubicacion_documento") = Value
        End Set
    end property

    Private _hora_prevista As Decimal
    Public Property hora_prevista() As Decimal
        Get
            _hora_prevista = CDec(dr("hora_prevista"))
            Return _hora_prevista
        End Get
        Set(ByVal Value As Decimal)
            dr("hora_prevista") = Value
        End Set
    end property

    Private _hora_real As Decimal
    Public Property hora_real() As Decimal
        Get
            _hora_real = CDec(dr("hora_real"))
            Return _hora_real
        End Get
        Set(ByVal Value As Decimal)
            dr("hora_real") = Value
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

    Private _id_estado_tarea As Int32
    Public Property id_estado_tarea() As Int32
        Get
            _id_estado_tarea = CInt(dr("id_estado_tarea"))
            Return _id_estado_tarea
        End Get
        Set(ByVal Value As Int32)
            dr("id_estado_tarea") = Value
        End Set
    end property

    Private _id_proyecto As Int32
    Public Property id_proyecto() As Int32
        Get
            _id_proyecto = CInt(dr("id_proyecto"))
            Return _id_proyecto
        End Get
        Set(ByVal Value As Int32)
            dr("id_proyecto") = Value
        End Set
    end property

    Private _id_empresa As Int32
    Public Property id_empresa() As Int32
        Get
            _id_empresa = CInt(dr("id_empresa"))
            Return _id_empresa
        End Get
        Set(ByVal Value As Int32)
            dr("id_empresa") = Value
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

    Private _enviada As Boolean
    Public Property enviada() As Boolean
        Get
            _enviada = CBool(dr("enviada"))
            Return _enviada
        End Get
        Set(ByVal Value As Boolean)
            dr("enviada") = Value
        End Set
    end property

    Private _archivo_relacionado As String
    Public Property archivo_relacionado() As String
        Get
            _archivo_relacionado = CStr(dr("archivo_relacionado"))
            Return _archivo_relacionado
        End Get
        Set(ByVal Value As String)
            dr("archivo_relacionado") = Value
        End Set
    end property

    Private _complejidad As String
    Public Property complejidad() As String
        Get
            _complejidad = CStr(dr("complejidad"))
            Return _complejidad
        End Get
        Set(ByVal Value As String)
            dr("complejidad") = Value
        End Set
    end property

    Private _es_feriado As Boolean
    Public Property es_feriado() As Boolean
        Get
            _es_feriado = CBool(dr("es_feriado"))
            Return _es_feriado
        End Get
        Set(ByVal Value As Boolean)
            dr("es_feriado") = Value
        End Set
    end property

    Private _IDCalendar As String
    Public Property IDCalendar() As String
        Get
            _IDCalendar = CStr(dr("IDCalendar"))
            Return _IDCalendar
        End Get
        Set(ByVal Value As String)
            dr("IDCalendar") = Value
        End Set
    end property


    'procedimiento insertar
    Public Sub Insertar()
        dt = New DataTable("Tarea")
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)

        Me.AsignarTipos()

        Dim cmdins As New SqlCommand("cop_Tarea_Insert", cnn.Coneccion)
        cmdins.CommandType = CommandType.StoredProcedure
        da.InsertCommand = cmdins

        Dim prm As SqlParameter
        prm = da.InsertCommand.Parameters.Add("@id_tarea", SqlDbType.int, 0, "id_tarea")
        prm.Direction = ParameterDirection.Output
        da.InsertCommand.Parameters.Add("@id_tipo_tarea", SqlDbType.int, 4, "id_tipo_tarea")
        da.InsertCommand.Parameters.Add("@id_sub_proyecto", SqlDbType.int, 4, "id_sub_proyecto")
        da.InsertCommand.Parameters.Add("@nombre_tarea", SqlDbType.varchar, 5000, "nombre_tarea")
        da.InsertCommand.Parameters.Add("@fecha_pedido", SqlDbType.datetime, 8, "fecha_pedido")
        da.InsertCommand.Parameters.Add("@fecha_inicio", SqlDbType.datetime, 8, "fecha_inicio")
        da.InsertCommand.Parameters.Add("@fecha_fin", SqlDbType.datetime, 8, "fecha_fin")
        da.InsertCommand.Parameters.Add("@fecha_real", SqlDbType.datetime, 8, "fecha_real")
        da.InsertCommand.Parameters.Add("@ubicacion_documento", SqlDbType.varchar, 5000, "ubicacion_documento")
        da.InsertCommand.Parameters.Add("@hora_prevista", SqlDbType.decimal, 9, "hora_prevista")
        da.InsertCommand.Parameters.Add("@hora_real", SqlDbType.decimal, 9, "hora_real")
        da.InsertCommand.Parameters.Add("@prioridad", SqlDbType.decimal, 9, "prioridad")
        da.InsertCommand.Parameters.Add("@id_usuario", SqlDbType.int, 4, "id_usuario")
        da.InsertCommand.Parameters.Add("@id_estado_tarea", SqlDbType.int, 4, "id_estado_tarea")
        da.InsertCommand.Parameters.Add("@id_proyecto", SqlDbType.int, 4, "id_proyecto")
        da.InsertCommand.Parameters.Add("@id_empresa", SqlDbType.int, 4, "id_empresa")
        da.InsertCommand.Parameters.Add("@id_usuario_asignado", SqlDbType.int, 4, "id_usuario_asignado")
        da.InsertCommand.Parameters.Add("@enviada", SqlDbType.bit, 1, "enviada")
        da.InsertCommand.Parameters.Add("@archivo_relacionado", SqlDbType.varchar, 5000, "archivo_relacionado")
        da.InsertCommand.Parameters.Add("@complejidad", SqlDbType.char, 1, "complejidad")
        da.InsertCommand.Parameters.Add("@es_feriado", SqlDbType.bit, 1, "es_feriado")
        da.InsertCommand.Parameters.Add("@IDCalendar", SqlDbType.varchar, 5000, "IDCalendar")

        dr = dt.NewRow()
        dr("id_tipo_tarea") = 0
        dr("id_sub_proyecto") = 0
        dr("nombre_tarea") = ""
        dr("fecha_pedido") = DateTime.Now
        dr("fecha_inicio") = DateTime.Now
        dr("fecha_fin") = DateTime.Now
        dr("fecha_real") = DateTime.Now
        dr("ubicacion_documento") = ""
        dr("hora_prevista") = 0
        dr("hora_real") = 0
        dr("prioridad") = 0
        dr("id_usuario") = 0
        dr("id_estado_tarea") = 0
        dr("id_proyecto") = 0
        dr("id_empresa") = 0
        dr("id_usuario_asignado") = 0
        dr("enviada") = False
        dr("archivo_relacionado") = ""
        dr("complejidad") = ""
        dr("es_feriado") = False
        dr("IDCalendar") = ""
        dt.Rows.Add(dr)
        CrearComandoUpdate()
    End Sub

    'procedimiento modificar
    Public Sub Modificar(ByVal idTarea As Integer)
        dt = New DataTable("Tarea")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Tarea WHERE id_tarea = @id_Tarea", cnn.Coneccion)
        da.SelectCommand.Parameters.AddWithValue("@id_Tarea", idTarea)
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
    Public Sub Borrar(ByVal idTarea As Integer)
        dt = New DataTable("Tarea")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Tarea WHERE id_tarea = " & _
        idTarea, cnn.Coneccion)
        da.Fill(dt)

        Me.AsignarTipos()

        If dt.Rows.Count = 0 Then
            Exit Sub
        Else
            dr = dt.Rows(0)
        End If

        Try
            Dim cmddel As New SqlCommand("cop_Tarea_Delete", cnn.Coneccion)
            cmddel.CommandType = CommandType.StoredProcedure
            da.DeleteCommand = cmddel
            Dim prm As SqlParameter
            prm = da.DeleteCommand.Parameters.Add("@id_tarea", SqlDbType.Int, 4, "id_tarea")
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
               Case "id_tarea"
                  dc.DataType = Type.GetType("System.Int32")
               Case "id_tipo_tarea"
                  dc.DataType = Type.GetType("System.Int32")
               Case "id_sub_proyecto"
                  dc.DataType = Type.GetType("System.Int32")
               Case "nombre_tarea"
                  dc.DataType = Type.GetType("System.String")
               Case "fecha_pedido"
                  dc.DataType = Type.GetType("System.DateTime")
               Case "fecha_inicio"
                  dc.DataType = Type.GetType("System.DateTime")
               Case "fecha_fin"
                  dc.DataType = Type.GetType("System.DateTime")
               Case "fecha_real"
                  dc.DataType = Type.GetType("System.DateTime")
               Case "ubicacion_documento"
                  dc.DataType = Type.GetType("System.String")
               Case "hora_prevista"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "hora_real"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "prioridad"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "id_usuario"
                  dc.DataType = Type.GetType("System.Int32")
               Case "id_estado_tarea"
                  dc.DataType = Type.GetType("System.Int32")
               Case "id_proyecto"
                  dc.DataType = Type.GetType("System.Int32")
               Case "id_empresa"
                  dc.DataType = Type.GetType("System.Int32")
               Case "id_usuario_asignado"
                  dc.DataType = Type.GetType("System.Int32")
               Case "enviada"
                  dc.DataType = Type.GetType("System.Boolean")
               Case "archivo_relacionado"
                  dc.DataType = Type.GetType("System.String")
               Case "complejidad"
                  dc.DataType = Type.GetType("System.String")
               Case "es_feriado"
                  dc.DataType = Type.GetType("System.Boolean")
               Case "IDCalendar"
                  dc.DataType = Type.GetType("System.String")
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
        dt = New DataTable("Tarea")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Tarea WHERE id_tarea = 0", cnn.Coneccion)
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)
        Return dt
    End Function

    'funcion de busqueda
    Public Function Buscar(ByVal Nombre As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Tarea_Find", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre", SqlDbType.NChar, 30, "nombre")
        oda.SelectCommand.Parameters("@nombre").Value = Nombre

        oda.Fill(odt)

        Return odt
    End Function

    'funcion de consulta
    Public Function ConsultarTodo() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Tarea_GetAll", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion para llenar el combo
    Public Function GetCmb() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Tarea_GetCmb", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion que trae un registro poniendo el id
    Public Function GetOne(ByVal id_Tarea As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Tarea_GetOne", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_tarea", SqlDbType.Int, 4, "id_tarea")
        oda.SelectCommand.Parameters("@id_tarea").Value = id_Tarea

        oda.Fill(odt)

        Return odt
    End Function

    'controla si existe el registro en la base de datos
    Public Function Exist() As Boolean
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Tarea_Exist", cnn.Coneccion)
        Dim Total As Integer

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_tipo_tarea", SqlDbType.int, 4, "id_tipo_tarea")
        oda.SelectCommand.Parameters("@id_tipo_tarea").Value = Me.id_tipo_tarea
        oda.SelectCommand.Parameters.Add("@id_sub_proyecto", SqlDbType.int, 4, "id_sub_proyecto")
        oda.SelectCommand.Parameters("@id_sub_proyecto").Value = Me.id_sub_proyecto
        oda.SelectCommand.Parameters.Add("@nombre_tarea", SqlDbType.varchar, 5000, "nombre_tarea")
        oda.SelectCommand.Parameters("@nombre_tarea").Value = Me.nombre_tarea
        oda.SelectCommand.Parameters.Add("@fecha_pedido", SqlDbType.datetime, 8, "fecha_pedido")
        oda.SelectCommand.Parameters("@fecha_pedido").Value = Me.fecha_pedido
        oda.SelectCommand.Parameters.Add("@fecha_inicio", SqlDbType.datetime, 8, "fecha_inicio")
        oda.SelectCommand.Parameters("@fecha_inicio").Value = Me.fecha_inicio
        oda.SelectCommand.Parameters.Add("@fecha_fin", SqlDbType.datetime, 8, "fecha_fin")
        oda.SelectCommand.Parameters("@fecha_fin").Value = Me.fecha_fin
        oda.SelectCommand.Parameters.Add("@fecha_real", SqlDbType.datetime, 8, "fecha_real")
        oda.SelectCommand.Parameters("@fecha_real").Value = Me.fecha_real
        oda.SelectCommand.Parameters.Add("@ubicacion_documento", SqlDbType.varchar, 5000, "ubicacion_documento")
        oda.SelectCommand.Parameters("@ubicacion_documento").Value = Me.ubicacion_documento
        oda.SelectCommand.Parameters.Add("@hora_prevista", SqlDbType.decimal, 9, "hora_prevista")
        oda.SelectCommand.Parameters("@hora_prevista").Value = Me.hora_prevista
        oda.SelectCommand.Parameters.Add("@hora_real", SqlDbType.decimal, 9, "hora_real")
        oda.SelectCommand.Parameters("@hora_real").Value = Me.hora_real
        oda.SelectCommand.Parameters.Add("@prioridad", SqlDbType.decimal, 9, "prioridad")
        oda.SelectCommand.Parameters("@prioridad").Value = Me.prioridad
        oda.SelectCommand.Parameters.Add("@id_usuario", SqlDbType.int, 4, "id_usuario")
        oda.SelectCommand.Parameters("@id_usuario").Value = Me.id_usuario
        oda.SelectCommand.Parameters.Add("@id_estado_tarea", SqlDbType.int, 4, "id_estado_tarea")
        oda.SelectCommand.Parameters("@id_estado_tarea").Value = Me.id_estado_tarea
        oda.SelectCommand.Parameters.Add("@id_proyecto", SqlDbType.int, 4, "id_proyecto")
        oda.SelectCommand.Parameters("@id_proyecto").Value = Me.id_proyecto
        oda.SelectCommand.Parameters.Add("@id_empresa", SqlDbType.int, 4, "id_empresa")
        oda.SelectCommand.Parameters("@id_empresa").Value = Me.id_empresa
        oda.SelectCommand.Parameters.Add("@id_usuario_asignado", SqlDbType.int, 4, "id_usuario_asignado")
        oda.SelectCommand.Parameters("@id_usuario_asignado").Value = Me.id_usuario_asignado
        oda.SelectCommand.Parameters.Add("@enviada", SqlDbType.bit, 1, "enviada")
        oda.SelectCommand.Parameters("@enviada").Value = Me.enviada
        oda.SelectCommand.Parameters.Add("@archivo_relacionado", SqlDbType.varchar, 5000, "archivo_relacionado")
        oda.SelectCommand.Parameters("@archivo_relacionado").Value = Me.archivo_relacionado
        oda.SelectCommand.Parameters.Add("@complejidad", SqlDbType.char, 1, "complejidad")
        oda.SelectCommand.Parameters("@complejidad").Value = Me.complejidad
        oda.SelectCommand.Parameters.Add("@es_feriado", SqlDbType.bit, 1, "es_feriado")
        oda.SelectCommand.Parameters("@es_feriado").Value = Me.es_feriado
        oda.SelectCommand.Parameters.Add("@IDCalendar", SqlDbType.varchar, 5000, "IDCalendar")
        oda.SelectCommand.Parameters("@IDCalendar").Value = Me.IDCalendar

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
        Command.CommandText = "DELETE FROM Tarea"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'borra todos los datos de la tabla
    Public Sub Truncate()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "TRUNCATE TABLE Tarea"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'inserta un registro en la tabla
    Public Sub InsertOne()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Tarea_InsertOne"

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'importa los datos de una campaña desde el txt
    Public Function Cargar_Archivo(ByVal path As String) As DataTable
        Dim odt As New DataTable("Tarea")

        Dim oda As New System.Data.OleDb.OleDbDataAdapter( _
        "SELECT * FROM Tarea.txt", cnntxt.Coneccion(path))

        oda.Fill(odt)

        Return odt
    End Function


End Class
