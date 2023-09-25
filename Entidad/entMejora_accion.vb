Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Mejora_accion_ent

    'defino las variables
    Friend dt As DataTable
    Friend dr As DataRow
    Friend da As SqlClient.SqlDataAdapter
    Friend cnn As New Conexion
    Friend cnntxt As New Conexion_txt

    'defino las propiedades
    Private _id_mejora_accion As Int32
    Public ReadOnly Property id_mejora_accion() As Int32
        Get
            _id_mejora_accion = CInt(dr("id_mejora_accion"))
            Return _id_mejora_accion
        End Get
    end property

    Private _id_mejora As Int32
    Public Property id_mejora() As Int32
        Get
            _id_mejora = CInt(dr("id_mejora"))
            Return _id_mejora
        End Get
        Set(ByVal Value As Int32)
            dr("id_mejora") = Value
        End Set
    end property

    Private _fecha_accion As DateTime
    Public Property fecha_accion() As DateTime
        Get
            _fecha_accion = CDate(dr("fecha_accion"))
            Return _fecha_accion
        End Get
        Set(ByVal Value As DateTime)
            dr("fecha_accion") = Value
        End Set
    end property

    Private _id_usuario_accion As Int32
    Public Property id_usuario_accion() As Int32
        Get
            _id_usuario_accion = CInt(dr("id_usuario_accion"))
            Return _id_usuario_accion
        End Get
        Set(ByVal Value As Int32)
            dr("id_usuario_accion") = Value
        End Set
    end property

    Private _descripccion_accion As String
    Public Property descripccion_accion() As String
        Get
            _descripccion_accion = CStr(dr("descripccion_accion"))
            Return _descripccion_accion
        End Get
        Set(ByVal Value As String)
            dr("descripccion_accion") = Value
        End Set
    end property


    'procedimiento insertar
    Public Sub Insertar()
        dt = New DataTable("Mejora_accion")
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)

        Me.AsignarTipos()

        Dim cmdins As New SqlCommand("cop_Mejora_accion_Insert", cnn.Coneccion)
        cmdins.CommandType = CommandType.StoredProcedure
        da.InsertCommand = cmdins

        Dim prm As SqlParameter
        prm = da.InsertCommand.Parameters.Add("@id_mejora_accion", SqlDbType.int, 0, "id_mejora_accion")
        prm.Direction = ParameterDirection.Output
        da.InsertCommand.Parameters.Add("@id_mejora", SqlDbType.int, 4, "id_mejora")
        da.InsertCommand.Parameters.Add("@fecha_accion", SqlDbType.datetime, 8, "fecha_accion")
        da.InsertCommand.Parameters.Add("@id_usuario_accion", SqlDbType.int, 4, "id_usuario_accion")
        da.InsertCommand.Parameters.Add("@descripccion_accion", SqlDbType.varchar, 5000, "descripccion_accion")

        dr = dt.NewRow()
        dr("id_mejora") = 0
        dr("fecha_accion") = DateTime.Now
        dr("id_usuario_accion") = 0
        dr("descripccion_accion") = ""
        dt.Rows.Add(dr)
        CrearComandoUpdate()
    End Sub

    'procedimiento modificar
    Public Sub Modificar(ByVal idMejora_accion As Integer)
        dt = New DataTable("Mejora_accion")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Mejora_accion WHERE id_mejora_accion = @id_Mejora_accion", cnn.Coneccion)
        da.SelectCommand.Parameters.AddWithValue("@id_Mejora_accion", idMejora_accion)
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
    Public Sub Borrar(ByVal idMejora_accion As Integer)
        dt = New DataTable("Mejora_accion")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Mejora_accion WHERE id_mejora_accion = " & _
        idMejora_accion, cnn.Coneccion)
        da.Fill(dt)

        Me.AsignarTipos()

        If dt.Rows.Count = 0 Then
            Exit Sub
        Else
            dr = dt.Rows(0)
        End If

        Try
            Dim cmddel As New SqlCommand("cop_Mejora_accion_Delete", cnn.Coneccion)
            cmddel.CommandType = CommandType.StoredProcedure
            da.DeleteCommand = cmddel
            Dim prm As SqlParameter
            prm = da.DeleteCommand.Parameters.Add("@id_mejora_accion", SqlDbType.Int, 4, "id_mejora_accion")
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
               Case "id_mejora_accion"
                  dc.DataType = Type.GetType("System.Int32")
               Case "id_mejora"
                  dc.DataType = Type.GetType("System.Int32")
               Case "fecha_accion"
                  dc.DataType = Type.GetType("System.DateTime")
               Case "id_usuario_accion"
                  dc.DataType = Type.GetType("System.Int32")
               Case "descripccion_accion"
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
        dt = New DataTable("Mejora_accion")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Mejora_accion WHERE id_mejora_accion = 0", cnn.Coneccion)
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)
        Return dt
    End Function

    'funcion de busqueda
    Public Function Buscar(ByVal Nombre As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Mejora_accion_Find", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre", SqlDbType.NChar, 30, "nombre")
        oda.SelectCommand.Parameters("@nombre").Value = Nombre

        oda.Fill(odt)

        Return odt
    End Function

    'funcion de consulta
    Public Function ConsultarTodo() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Mejora_accion_GetAll", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion para llenar el combo
    Public Function GetCmb() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Mejora_accion_GetCmb", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion que trae un registro poniendo el id
    Public Function GetOne(ByVal id_Mejora_accion As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Mejora_accion_GetOne", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_mejora_accion", SqlDbType.Int, 4, "id_mejora_accion")
        oda.SelectCommand.Parameters("@id_mejora_accion").Value = id_Mejora_accion

        oda.Fill(odt)

        Return odt
    End Function

    'controla si existe el registro en la base de datos
    Public Function Exist() As Boolean
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Mejora_accion_Exist", cnn.Coneccion)
        Dim Total As Integer

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_mejora", SqlDbType.int, 4, "id_mejora")
        oda.SelectCommand.Parameters("@id_mejora").Value = Me.id_mejora
        oda.SelectCommand.Parameters.Add("@fecha_accion", SqlDbType.datetime, 8, "fecha_accion")
        oda.SelectCommand.Parameters("@fecha_accion").Value = Me.fecha_accion
        oda.SelectCommand.Parameters.Add("@id_usuario_accion", SqlDbType.int, 4, "id_usuario_accion")
        oda.SelectCommand.Parameters("@id_usuario_accion").Value = Me.id_usuario_accion
        oda.SelectCommand.Parameters.Add("@descripccion_accion", SqlDbType.varchar, 5000, "descripccion_accion")
        oda.SelectCommand.Parameters("@descripccion_accion").Value = Me.descripccion_accion

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
        Command.CommandText = "DELETE FROM Mejora_accion"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'borra todos los datos de la tabla
    Public Sub Truncate()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "TRUNCATE TABLE Mejora_accion"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'inserta un registro en la tabla
    Public Sub InsertOne()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Mejora_accion_InsertOne"

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'importa los datos de una campaña desde el txt
    Public Function Cargar_Archivo(ByVal path As String) As DataTable
        Dim odt As New DataTable("Mejora_accion")

        Dim oda As New System.Data.OleDb.OleDbDataAdapter( _
        "SELECT * FROM Mejora_accion.txt", cnntxt.Coneccion(path))

        oda.Fill(odt)

        Return odt
    End Function


End Class
