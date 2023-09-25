Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Hora_real_ent

    'defino las variables
    Friend dt As DataTable
    Friend dr As DataRow
    Friend da As SqlClient.SqlDataAdapter
    Friend cnn As New Conexion
    Friend cnntxt As New Conexion_txt

    'defino las propiedades
    Private _id_hora_real As Int32
    Public ReadOnly Property id_hora_real() As Int32
        Get
            _id_hora_real = CInt(dr("id_hora_real"))
            Return _id_hora_real
        End Get
    end property

    Private _id_tarea As Int32
    Public Property id_tarea() As Int32
        Get
            _id_tarea = CInt(dr("id_tarea"))
            Return _id_tarea
        End Get
        Set(ByVal Value As Int32)
            dr("id_tarea") = Value
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

    Private _fecha_carga As DateTime
    Public Property fecha_carga() As DateTime
        Get
            _fecha_carga = CDate(dr("fecha_carga"))
            Return _fecha_carga
        End Get
        Set(ByVal Value As DateTime)
            dr("fecha_carga") = Value
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

    Private _comentario As String
    Public Property comentario() As String
        Get
            _comentario = CStr(dr("comentario"))
            Return _comentario
        End Get
        Set(ByVal Value As String)
            dr("comentario") = Value
        End Set
    end property

    Private _costo As Decimal
    Public Property costo() As Decimal
        Get
            _costo = CDec(dr("costo"))
            Return _costo
        End Get
        Set(ByVal Value As Decimal)
            dr("costo") = Value
        End Set
    end property


    'procedimiento insertar
    Public Sub Insertar()
        dt = New DataTable("Hora_real")
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)

        Me.AsignarTipos()

        Dim cmdins As New SqlCommand("cop_Hora_real_Insert", cnn.Coneccion)
        cmdins.CommandType = CommandType.StoredProcedure
        da.InsertCommand = cmdins

        Dim prm As SqlParameter
        prm = da.InsertCommand.Parameters.Add("@id_hora_real", SqlDbType.int, 0, "id_hora_real")
        prm.Direction = ParameterDirection.Output
        da.InsertCommand.Parameters.Add("@id_tarea", SqlDbType.int, 4, "id_tarea")
        da.InsertCommand.Parameters.Add("@id_usuario", SqlDbType.int, 4, "id_usuario")
        da.InsertCommand.Parameters.Add("@fecha_carga", SqlDbType.datetime, 8, "fecha_carga")
        da.InsertCommand.Parameters.Add("@hora_real", SqlDbType.decimal, 9, "hora_real")
        da.InsertCommand.Parameters.Add("@id_usuario_asignado", SqlDbType.int, 4, "id_usuario_asignado")
        da.InsertCommand.Parameters.Add("@comentario", SqlDbType.varchar, 5000, "comentario")
        da.InsertCommand.Parameters.Add("@costo", SqlDbType.decimal, 9, "costo")

        dr = dt.NewRow()
        dr("id_tarea") = 0
        dr("id_usuario") = 0
        dr("fecha_carga") = DateTime.Now
        dr("hora_real") = 0
        dr("id_usuario_asignado") = 0
        dr("comentario") = ""
        dr("costo") = 0
        dt.Rows.Add(dr)
        CrearComandoUpdate()
    End Sub

    'procedimiento modificar
    Public Sub Modificar(ByVal idHora_real As Integer)
        dt = New DataTable("Hora_real")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Hora_real WHERE id_hora_real = @id_Hora_real", cnn.Coneccion)
        da.SelectCommand.Parameters.AddWithValue("@id_Hora_real", idHora_real)
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
    Public Sub Borrar(ByVal idHora_real As Integer)
        dt = New DataTable("Hora_real")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Hora_real WHERE id_hora_real = " & _
        idHora_real, cnn.Coneccion)
        da.Fill(dt)

        Me.AsignarTipos()

        If dt.Rows.Count = 0 Then
            Exit Sub
        Else
            dr = dt.Rows(0)
        End If

        Try
            Dim cmddel As New SqlCommand("cop_Hora_real_Delete", cnn.Coneccion)
            cmddel.CommandType = CommandType.StoredProcedure
            da.DeleteCommand = cmddel
            Dim prm As SqlParameter
            prm = da.DeleteCommand.Parameters.Add("@id_hora_real", SqlDbType.Int, 4, "id_hora_real")
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
               Case "id_hora_real"
                  dc.DataType = Type.GetType("System.Int32")
               Case "id_tarea"
                  dc.DataType = Type.GetType("System.Int32")
               Case "id_usuario"
                  dc.DataType = Type.GetType("System.Int32")
               Case "fecha_carga"
                  dc.DataType = Type.GetType("System.DateTime")
               Case "hora_real"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "id_usuario_asignado"
                  dc.DataType = Type.GetType("System.Int32")
               Case "comentario"
                  dc.DataType = Type.GetType("System.String")
               Case "costo"
                  dc.DataType = Type.GetType("System.Decimal")
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
        dt = New DataTable("Hora_real")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Hora_real WHERE id_hora_real = 0", cnn.Coneccion)
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)
        Return dt
    End Function

    'funcion de busqueda
    Public Function Buscar(ByVal Nombre As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Hora_real_Find", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre", SqlDbType.NChar, 30, "nombre")
        oda.SelectCommand.Parameters("@nombre").Value = Nombre

        oda.Fill(odt)

        Return odt
    End Function

    'funcion de consulta
    Public Function ConsultarTodo() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Hora_real_GetAll", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion para llenar el combo
    Public Function GetCmb() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Hora_real_GetCmb", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion que trae un registro poniendo el id
    Public Function GetOne(ByVal id_Hora_real As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Hora_real_GetOne", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_hora_real", SqlDbType.Int, 4, "id_hora_real")
        oda.SelectCommand.Parameters("@id_hora_real").Value = id_Hora_real

        oda.Fill(odt)

        Return odt
    End Function

    'controla si existe el registro en la base de datos
    Public Function Exist() As Boolean
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Hora_real_Exist", cnn.Coneccion)
        Dim Total As Integer

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_tarea", SqlDbType.int, 4, "id_tarea")
        oda.SelectCommand.Parameters("@id_tarea").Value = Me.id_tarea
        oda.SelectCommand.Parameters.Add("@id_usuario", SqlDbType.int, 4, "id_usuario")
        oda.SelectCommand.Parameters("@id_usuario").Value = Me.id_usuario
        oda.SelectCommand.Parameters.Add("@fecha_carga", SqlDbType.datetime, 8, "fecha_carga")
        oda.SelectCommand.Parameters("@fecha_carga").Value = Me.fecha_carga
        oda.SelectCommand.Parameters.Add("@hora_real", SqlDbType.decimal, 9, "hora_real")
        oda.SelectCommand.Parameters("@hora_real").Value = Me.hora_real
        oda.SelectCommand.Parameters.Add("@id_usuario_asignado", SqlDbType.int, 4, "id_usuario_asignado")
        oda.SelectCommand.Parameters("@id_usuario_asignado").Value = Me.id_usuario_asignado
        oda.SelectCommand.Parameters.Add("@comentario", SqlDbType.varchar, 5000, "comentario")
        oda.SelectCommand.Parameters("@comentario").Value = Me.comentario
        oda.SelectCommand.Parameters.Add("@costo", SqlDbType.decimal, 9, "costo")
        oda.SelectCommand.Parameters("@costo").Value = Me.costo

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
        Command.CommandText = "DELETE FROM Hora_real"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'borra todos los datos de la tabla
    Public Sub Truncate()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "TRUNCATE TABLE Hora_real"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'inserta un registro en la tabla
    Public Sub InsertOne()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Hora_real_InsertOne"

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'importa los datos de una campaña desde el txt
    Public Function Cargar_Archivo(ByVal path As String) As DataTable
        Dim odt As New DataTable("Hora_real")

        Dim oda As New System.Data.OleDb.OleDbDataAdapter( _
        "SELECT * FROM Hora_real.txt", cnntxt.Coneccion(path))

        oda.Fill(odt)

        Return odt
    End Function


End Class
