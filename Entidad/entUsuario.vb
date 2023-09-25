Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Usuario_ent

    'defino las variables
    Friend dt As DataTable
    Friend dr As DataRow
    Friend da As SqlClient.SqlDataAdapter
    Friend cnn As New Conexion
    Friend cnntxt As New Conexion_txt

    'defino las propiedades
    Private _id_usuario As Int32
    Public ReadOnly Property id_usuario() As Int32
        Get
            _id_usuario = CInt(dr("id_usuario"))
            Return _id_usuario
        End Get
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

    Private _apellido_usuario As String
    Public Property apellido_usuario() As String
        Get
            _apellido_usuario = CStr(dr("apellido_usuario"))
            Return _apellido_usuario
        End Get
        Set(ByVal Value As String)
            dr("apellido_usuario") = Value
        End Set
    end property

    Private _identificador As String
    Public Property identificador() As String
        Get
            _identificador = CStr(dr("identificador"))
            Return _identificador
        End Get
        Set(ByVal Value As String)
            dr("identificador") = Value
        End Set
    end property

    Private _clave As String
    Public Property clave() As String
        Get
            _clave = CStr(dr("clave"))
            Return _clave
        End Get
        Set(ByVal Value As String)
            dr("clave") = Value
        End Set
    end property

    Private _id_tipo_usuario As Int32
    Public Property id_tipo_usuario() As Int32
        Get
            _id_tipo_usuario = CInt(dr("id_tipo_usuario"))
            Return _id_tipo_usuario
        End Get
        Set(ByVal Value As Int32)
            dr("id_tipo_usuario") = Value
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

    Private _capacidad_trabajo As Decimal
    Public Property capacidad_trabajo() As Decimal
        Get
            _capacidad_trabajo = CDec(dr("capacidad_trabajo"))
            Return _capacidad_trabajo
        End Get
        Set(ByVal Value As Decimal)
            dr("capacidad_trabajo") = Value
        End Set
    end property

    Private _usuario_calendar As String
    Public Property usuario_calendar() As String
        Get
            _usuario_calendar = CStr(dr("usuario_calendar"))
            Return _usuario_calendar
        End Get
        Set(ByVal Value As String)
            dr("usuario_calendar") = Value
        End Set
    end property

    Private _password_calendar As String
    Public Property password_calendar() As String
        Get
            _password_calendar = CStr(dr("password_calendar"))
            Return _password_calendar
        End Get
        Set(ByVal Value As String)
            dr("password_calendar") = Value
        End Set
    end property

    Private _mail As String
    Public Property mail() As String
        Get
            _mail = CStr(dr("mail"))
            Return _mail
        End Get
        Set(ByVal Value As String)
            dr("mail") = Value
        End Set
    end property


    'procedimiento insertar
    Public Sub Insertar()
        dt = New DataTable("Usuario")
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)

        Me.AsignarTipos()

        Dim cmdins As New SqlCommand("cop_Usuario_Insert", cnn.Coneccion)
        cmdins.CommandType = CommandType.StoredProcedure
        da.InsertCommand = cmdins

        Dim prm As SqlParameter
        prm = da.InsertCommand.Parameters.Add("@id_usuario", SqlDbType.int, 0, "id_usuario")
        prm.Direction = ParameterDirection.Output
        da.InsertCommand.Parameters.Add("@nombre_usuario", SqlDbType.varchar, 50, "nombre_usuario")
        da.InsertCommand.Parameters.Add("@apellido_usuario", SqlDbType.varchar, 50, "apellido_usuario")
        da.InsertCommand.Parameters.Add("@identificador", SqlDbType.varchar, 50, "identificador")
        da.InsertCommand.Parameters.Add("@clave", SqlDbType.varchar, 50, "clave")
        da.InsertCommand.Parameters.Add("@id_tipo_usuario", SqlDbType.int, 4, "id_tipo_usuario")
        da.InsertCommand.Parameters.Add("@id_empresa", SqlDbType.int, 4, "id_empresa")
        da.InsertCommand.Parameters.Add("@costo", SqlDbType.decimal, 9, "costo")
        da.InsertCommand.Parameters.Add("@capacidad_trabajo", SqlDbType.decimal, 9, "capacidad_trabajo")
        da.InsertCommand.Parameters.Add("@usuario_calendar", SqlDbType.varchar, 500, "usuario_calendar")
        da.InsertCommand.Parameters.Add("@password_calendar", SqlDbType.varchar, 500, "password_calendar")
        da.InsertCommand.Parameters.Add("@mail", SqlDbType.varchar, 500, "mail")

        dr = dt.NewRow()
        dr("nombre_usuario") = ""
        dr("apellido_usuario") = ""
        dr("identificador") = ""
        dr("clave") = ""
        dr("id_tipo_usuario") = 0
        dr("id_empresa") = 0
        dr("costo") = 0
        dr("capacidad_trabajo") = 0
        dr("usuario_calendar") = ""
        dr("password_calendar") = ""
        dr("mail") = ""
        dt.Rows.Add(dr)
        CrearComandoUpdate()
    End Sub

    'procedimiento modificar
    Public Sub Modificar(ByVal idUsuario As Integer)
        dt = New DataTable("Usuario")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Usuario WHERE id_usuario = @id_Usuario", cnn.Coneccion)
        da.SelectCommand.Parameters.AddWithValue("@id_Usuario", idUsuario)
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
    Public Sub Borrar(ByVal idUsuario As Integer)
        dt = New DataTable("Usuario")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Usuario WHERE id_usuario = " & _
        idUsuario, cnn.Coneccion)
        da.Fill(dt)

        Me.AsignarTipos()

        If dt.Rows.Count = 0 Then
            Exit Sub
        Else
            dr = dt.Rows(0)
        End If

        Try
            Dim cmddel As New SqlCommand("cop_Usuario_Delete", cnn.Coneccion)
            cmddel.CommandType = CommandType.StoredProcedure
            da.DeleteCommand = cmddel
            Dim prm As SqlParameter
            prm = da.DeleteCommand.Parameters.Add("@id_usuario", SqlDbType.Int, 4, "id_usuario")
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
               Case "id_usuario"
                  dc.DataType = Type.GetType("System.Int32")
               Case "nombre_usuario"
                  dc.DataType = Type.GetType("System.String")
               Case "apellido_usuario"
                  dc.DataType = Type.GetType("System.String")
               Case "identificador"
                  dc.DataType = Type.GetType("System.String")
               Case "clave"
                  dc.DataType = Type.GetType("System.String")
               Case "id_tipo_usuario"
                  dc.DataType = Type.GetType("System.Int32")
               Case "id_empresa"
                  dc.DataType = Type.GetType("System.Int32")
               Case "costo"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "capacidad_trabajo"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "usuario_calendar"
                  dc.DataType = Type.GetType("System.String")
               Case "password_calendar"
                  dc.DataType = Type.GetType("System.String")
               Case "mail"
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
        dt = New DataTable("Usuario")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Usuario WHERE id_usuario = 0", cnn.Coneccion)
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)
        Return dt
    End Function

    'funcion de busqueda
    Public Function Buscar(ByVal Nombre As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Usuario_Find", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre", SqlDbType.NChar, 30, "nombre")
        oda.SelectCommand.Parameters("@nombre").Value = Nombre

        oda.Fill(odt)

        Return odt
    End Function

    'funcion de consulta
    Public Function ConsultarTodo() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Usuario_GetAll", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion para llenar el combo
    Public Function GetCmb() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Usuario_GetCmb", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion que trae un registro poniendo el id
    Public Function GetOne(ByVal id_Usuario As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Usuario_GetOne", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_usuario", SqlDbType.Int, 4, "id_usuario")
        oda.SelectCommand.Parameters("@id_usuario").Value = id_Usuario

        oda.Fill(odt)

        Return odt
    End Function

    'controla si existe el registro en la base de datos
    Public Function Exist() As Boolean
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Usuario_Exist", cnn.Coneccion)
        Dim Total As Integer

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre_usuario", SqlDbType.varchar, 50, "nombre_usuario")
        oda.SelectCommand.Parameters("@nombre_usuario").Value = Me.nombre_usuario
        oda.SelectCommand.Parameters.Add("@apellido_usuario", SqlDbType.varchar, 50, "apellido_usuario")
        oda.SelectCommand.Parameters("@apellido_usuario").Value = Me.apellido_usuario
        oda.SelectCommand.Parameters.Add("@identificador", SqlDbType.varchar, 50, "identificador")
        oda.SelectCommand.Parameters("@identificador").Value = Me.identificador
        oda.SelectCommand.Parameters.Add("@clave", SqlDbType.varchar, 50, "clave")
        oda.SelectCommand.Parameters("@clave").Value = Me.clave
        oda.SelectCommand.Parameters.Add("@id_tipo_usuario", SqlDbType.int, 4, "id_tipo_usuario")
        oda.SelectCommand.Parameters("@id_tipo_usuario").Value = Me.id_tipo_usuario
        oda.SelectCommand.Parameters.Add("@id_empresa", SqlDbType.int, 4, "id_empresa")
        oda.SelectCommand.Parameters("@id_empresa").Value = Me.id_empresa
        oda.SelectCommand.Parameters.Add("@costo", SqlDbType.decimal, 9, "costo")
        oda.SelectCommand.Parameters("@costo").Value = Me.costo
        oda.SelectCommand.Parameters.Add("@capacidad_trabajo", SqlDbType.decimal, 9, "capacidad_trabajo")
        oda.SelectCommand.Parameters("@capacidad_trabajo").Value = Me.capacidad_trabajo
        oda.SelectCommand.Parameters.Add("@usuario_calendar", SqlDbType.varchar, 500, "usuario_calendar")
        oda.SelectCommand.Parameters("@usuario_calendar").Value = Me.usuario_calendar
        oda.SelectCommand.Parameters.Add("@password_calendar", SqlDbType.varchar, 500, "password_calendar")
        oda.SelectCommand.Parameters("@password_calendar").Value = Me.password_calendar
        oda.SelectCommand.Parameters.Add("@mail", SqlDbType.varchar, 500, "mail")
        oda.SelectCommand.Parameters("@mail").Value = Me.mail

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
        Command.CommandText = "DELETE FROM Usuario"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'borra todos los datos de la tabla
    Public Sub Truncate()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "TRUNCATE TABLE Usuario"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'inserta un registro en la tabla
    Public Sub InsertOne()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Usuario_InsertOne"

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'importa los datos de una campaña desde el txt
    Public Function Cargar_Archivo(ByVal path As String) As DataTable
        Dim odt As New DataTable("Usuario")

        Dim oda As New System.Data.OleDb.OleDbDataAdapter( _
        "SELECT * FROM Usuario.txt", cnntxt.Coneccion(path))

        oda.Fill(odt)

        Return odt
    End Function


End Class
