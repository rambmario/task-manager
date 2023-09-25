Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Cliente_ent

    'defino las variables
    Private dt As DataTable
    Private dr As DataRow
    Private da As SqlClient.SqlDataAdapter
    Friend cnn As New Conexion
    Friend cnntxt As New Conexion_txt

    'defino las propiedades
    Private _id_cliente As Int32
    Public ReadOnly Property id_cliente() As Int32
        Get
            _id_cliente = CInt(dr("id_cliente"))
            Return _id_cliente
        End Get
    end property

    Private _nombre_cliente As String
    Public Property nombre_cliente() As String
        Get
            _nombre_cliente = CStr(dr("nombre_cliente"))
            Return _nombre_cliente
        End Get
        Set(ByVal Value As String)
            dr("nombre_cliente") = Value
        End Set
    end property

    Private _nombre_permiso As String
    Public Property nombre_permiso() As String
        Get
            _nombre_permiso = CStr(dr("nombre_permiso"))
            Return _nombre_permiso
        End Get
        Set(ByVal Value As String)
            dr("nombre_permiso") = Value
        End Set
    end property


    'procedimiento insertar
    Public Sub Insertar()
        dt = New DataTable("Cliente")
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)

        Me.AsignarTipos()

        Dim cmdins As New SqlCommand("cop_Cliente_Insert", cnn.Coneccion)
        cmdins.CommandType = CommandType.StoredProcedure
        da.InsertCommand = cmdins

        Dim prm As SqlParameter
        prm = da.InsertCommand.Parameters.Add("@id_cliente", SqlDbType.int, 0, "id_cliente")
        prm.Direction = ParameterDirection.Output
        da.InsertCommand.Parameters.Add("@nombre_cliente", SqlDbType.varchar, 50, "nombre_cliente")
        da.InsertCommand.Parameters.Add("@nombre_permiso", SqlDbType.varchar, 50, "nombre_permiso")

        dr = dt.NewRow()
        dr("nombre_cliente") = ""
        dr("nombre_permiso") = ""
        dt.Rows.Add(dr)
        CrearComandoUpdate()
    End Sub

    'procedimiento modificar
    Public Sub Modificar(ByVal idCliente As Integer)
        dt = New DataTable("Cliente")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Cliente WHERE id_cliente = @id_Cliente", cnn.Coneccion)
        da.SelectCommand.Parameters.AddWithValue("@id_Cliente", idCliente)
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
    Public Sub Borrar(ByVal idCliente As Integer)
        dt = New DataTable("Cliente")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Cliente WHERE id_cliente = " & _
        idCliente, cnn.Coneccion)
        da.Fill(dt)

        Me.AsignarTipos()

        If dt.Rows.Count = 0 Then
            Exit Sub
        Else
            dr = dt.Rows(0)
        End If

        Try
            Dim cmddel As New SqlCommand("cop_Cliente_Delete", cnn.Coneccion)
            cmddel.CommandType = CommandType.StoredProcedure
            da.DeleteCommand = cmddel
            Dim prm As SqlParameter
            prm = da.DeleteCommand.Parameters.Add("@id_cliente", SqlDbType.Int, 4, "id_cliente")
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
               Case "id_cliente"
                  dc.DataType = Type.GetType("System.Int32")
               Case "nombre_cliente"
                  dc.DataType = Type.GetType("System.String")
               Case "nombre_permiso"
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
        dt = New DataTable("Cliente")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Cliente WHERE id_cliente = 0", cnn.Coneccion)
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)
        Return dt
    End Function

    'funcion de busqueda
    Public Function Buscar(ByVal Nombre As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Cliente_Find", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre", SqlDbType.NChar, 30, "nombre")
        oda.SelectCommand.Parameters("@nombre").Value = Nombre

        oda.Fill(odt)

        Return odt
    End Function

    'funcion de consulta
    Public Function ConsultarTodo() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Cliente_GetAll", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion para llenar el combo
    Public Function GetCmb() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Cliente_GetCmb", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion que trae un registro poniendo el id
    Public Function GetOne(ByVal id_Cliente As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Cliente_GetOne", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_cliente", SqlDbType.Int, 4, "id_cliente")
        oda.SelectCommand.Parameters("@id_cliente").Value = id_Cliente

        oda.Fill(odt)

        Return odt
    End Function

    'controla si existe el registro en la base de datos
    Public Function Exist() As Boolean
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Cliente_Exist", cnn.Coneccion)
        Dim Total As Integer

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre_cliente", SqlDbType.varchar, 50, "nombre_cliente")
        oda.SelectCommand.Parameters("@nombre_cliente").Value = Me.nombre_cliente
        oda.SelectCommand.Parameters.Add("@nombre_permiso", SqlDbType.varchar, 50, "nombre_permiso")
        oda.SelectCommand.Parameters("@nombre_permiso").Value = Me.nombre_permiso

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
        Command.CommandText = "DELETE FROM Cliente"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'borra todos los datos de la tabla
    Public Sub Truncate()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "TRUNCATE TABLE Cliente"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'inserta un registro en la tabla
    Public Sub InsertOne()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Cliente_InsertOne"

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'importa los datos de una campaña desde el txt
    Public Function Cargar_Archivo(ByVal path As String) As DataTable
        Dim odt As New DataTable("Cliente")

        Dim oda As New System.Data.OleDb.OleDbDataAdapter( _
        "SELECT * FROM Cliente.txt", cnntxt.Coneccion(path))

        oda.Fill(odt)

        Return odt
    End Function


End Class
