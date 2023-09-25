Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Gantt_ent

    'defino las variables
    Friend dt As DataTable
    Friend dr As DataRow
    Friend da As SqlClient.SqlDataAdapter
    Friend cnn As New Conexion
    Friend cnntxt As New Conexion_txt

    'defino las propiedades
    Private _id_gantt As Int32
    Public ReadOnly Property id_gantt() As Int32
        Get
            _id_gantt = CInt(dr("id_gantt"))
            Return _id_gantt
        End Get
    end property

    Private _dia As String
    Public Property dia() As String
        Get
            _dia = CStr(dr("dia"))
            Return _dia
        End Get
        Set(ByVal Value As String)
            dr("dia") = Value
        End Set
    end property

    Private _fecha As DateTime
    Public Property fecha() As DateTime
        Get
            _fecha = CDate(dr("fecha"))
            Return _fecha
        End Get
        Set(ByVal Value As DateTime)
            dr("fecha") = Value
        End Set
    end property

    Private _nombre_usuario As String
    Public Property nombre_usuario() As String
        Get
            _nombre_usuario = CStr(dr("nombre_usuario"))
            Return _nombre_usuario
        End Get
        Set(ByVal Value As String)
            dr("nombre_usuario") = Value
        End Set
    end property

    Private _horas As Decimal
    Public Property horas() As Decimal
        Get
            _horas = CDec(dr("horas"))
            Return _horas
        End Get
        Set(ByVal Value As Decimal)
            dr("horas") = Value
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


    'procedimiento insertar
    Public Sub Insertar()
        dt = New DataTable("Gantt")
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)

        Me.AsignarTipos()

        Dim cmdins As New SqlCommand("cop_Gantt_Insert", cnn.Coneccion)
        cmdins.CommandType = CommandType.StoredProcedure
        da.InsertCommand = cmdins

        Dim prm As SqlParameter
        prm = da.InsertCommand.Parameters.Add("@id_gantt", SqlDbType.int, 0, "id_gantt")
        prm.Direction = ParameterDirection.Output
        da.InsertCommand.Parameters.Add("@dia", SqlDbType.varchar, 50, "dia")
        da.InsertCommand.Parameters.Add("@fecha", SqlDbType.datetime, 8, "fecha")
        da.InsertCommand.Parameters.Add("@nombre_usuario", SqlDbType.varchar, 50, "nombre_usuario")
        da.InsertCommand.Parameters.Add("@horas", SqlDbType.decimal, 9, "horas")
        da.InsertCommand.Parameters.Add("@es_feriado", SqlDbType.bit, 1, "es_feriado")

        dr = dt.NewRow()
        dr("dia") = ""
        dr("fecha") = DateTime.Now
        dr("nombre_usuario") = ""
        dr("horas") = 0
        dr("es_feriado") = False
        dt.Rows.Add(dr)
        CrearComandoUpdate()
    End Sub

    'procedimiento modificar
    Public Sub Modificar(ByVal idGantt As Integer)
        dt = New DataTable("Gantt")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Gantt WHERE id_gantt = @id_Gantt", cnn.Coneccion)
        da.SelectCommand.Parameters.AddWithValue("@id_Gantt", idGantt)
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
    Public Sub Borrar(ByVal idGantt As Integer)
        dt = New DataTable("Gantt")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Gantt WHERE id_gantt = " & _
        idGantt, cnn.Coneccion)
        da.Fill(dt)

        Me.AsignarTipos()

        If dt.Rows.Count = 0 Then
            Exit Sub
        Else
            dr = dt.Rows(0)
        End If

        Try
            Dim cmddel As New SqlCommand("cop_Gantt_Delete", cnn.Coneccion)
            cmddel.CommandType = CommandType.StoredProcedure
            da.DeleteCommand = cmddel
            Dim prm As SqlParameter
            prm = da.DeleteCommand.Parameters.Add("@id_gantt", SqlDbType.Int, 4, "id_gantt")
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
               Case "id_gantt"
                  dc.DataType = Type.GetType("System.Int32")
               Case "dia"
                  dc.DataType = Type.GetType("System.String")
               Case "fecha"
                  dc.DataType = Type.GetType("System.DateTime")
               Case "nombre_usuario"
                  dc.DataType = Type.GetType("System.String")
               Case "horas"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "es_feriado"
                  dc.DataType = Type.GetType("System.Boolean")
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
        dt = New DataTable("Gantt")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Gantt WHERE id_gantt = 0", cnn.Coneccion)
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)
        Return dt
    End Function

    'funcion de busqueda
    Public Function Buscar(ByVal Nombre As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Gantt_Find", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre", SqlDbType.NChar, 30, "nombre")
        oda.SelectCommand.Parameters("@nombre").Value = Nombre

        oda.Fill(odt)

        Return odt
    End Function

    'funcion de consulta
    Public Function ConsultarTodo() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Gantt_GetAll", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion para llenar el combo
    Public Function GetCmb() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Gantt_GetCmb", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion que trae un registro poniendo el id
    Public Function GetOne(ByVal id_Gantt As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Gantt_GetOne", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_gantt", SqlDbType.Int, 4, "id_gantt")
        oda.SelectCommand.Parameters("@id_gantt").Value = id_Gantt

        oda.Fill(odt)

        Return odt
    End Function

    'controla si existe el registro en la base de datos
    Public Function Exist() As Boolean
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Gantt_Exist", cnn.Coneccion)
        Dim Total As Integer

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@dia", SqlDbType.varchar, 50, "dia")
        oda.SelectCommand.Parameters("@dia").Value = Me.dia
        oda.SelectCommand.Parameters.Add("@fecha", SqlDbType.datetime, 8, "fecha")
        oda.SelectCommand.Parameters("@fecha").Value = Me.fecha
        oda.SelectCommand.Parameters.Add("@nombre_usuario", SqlDbType.varchar, 50, "nombre_usuario")
        oda.SelectCommand.Parameters("@nombre_usuario").Value = Me.nombre_usuario
        oda.SelectCommand.Parameters.Add("@horas", SqlDbType.decimal, 9, "horas")
        oda.SelectCommand.Parameters("@horas").Value = Me.horas
        oda.SelectCommand.Parameters.Add("@es_feriado", SqlDbType.bit, 1, "es_feriado")
        oda.SelectCommand.Parameters("@es_feriado").Value = Me.es_feriado

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
        Command.CommandText = "DELETE FROM Gantt"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'borra todos los datos de la tabla
    Public Sub Truncate()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "TRUNCATE TABLE Gantt"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'inserta un registro en la tabla
    Public Sub InsertOne()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Gantt_InsertOne"

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'importa los datos de una campaña desde el txt
    Public Function Cargar_Archivo(ByVal path As String) As DataTable
        Dim odt As New DataTable("Gantt")

        Dim oda As New System.Data.OleDb.OleDbDataAdapter( _
        "SELECT * FROM Gantt.txt", cnntxt.Coneccion(path))

        oda.Fill(odt)

        Return odt
    End Function


End Class
