Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Estado_proyecto_ent

    'defino las variables
    Friend dt As DataTable
    Friend dr As DataRow
    Friend da As SqlClient.SqlDataAdapter
    Friend cnn As New Conexion
    Friend cnntxt As New Conexion_txt

    'defino las propiedades
    Private _id_estado_proyecto As Int32
    Public ReadOnly Property id_estado_proyecto() As Int32
        Get
            _id_estado_proyecto = CInt(dr("id_estado_proyecto"))
            Return _id_estado_proyecto
        End Get
    end property

    Private _nombre_estado_proyecto As String
    Public Property nombre_estado_proyecto() As String
        Get
            _nombre_estado_proyecto = CStr(dr("nombre_estado_proyecto"))
            Return _nombre_estado_proyecto
        End Get
        Set(ByVal Value As String)
            dr("nombre_estado_proyecto") = Value
        End Set
    end property


    'procedimiento insertar
    Public Sub Insertar()
        dt = New DataTable("Estado_proyecto")
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)

        Me.AsignarTipos()

        Dim cmdins As New SqlCommand("cop_Estado_proyecto_Insert", cnn.Coneccion)
        cmdins.CommandType = CommandType.StoredProcedure
        da.InsertCommand = cmdins

        Dim prm As SqlParameter
        prm = da.InsertCommand.Parameters.Add("@id_estado_proyecto", SqlDbType.int, 0, "id_estado_proyecto")
        prm.Direction = ParameterDirection.Output
        da.InsertCommand.Parameters.Add("@nombre_estado_proyecto", SqlDbType.varchar, 50, "nombre_estado_proyecto")

        dr = dt.NewRow()
        dr("nombre_estado_proyecto") = ""
        dt.Rows.Add(dr)
        CrearComandoUpdate()
    End Sub

    'procedimiento modificar
    Public Sub Modificar(ByVal idEstado_proyecto As Integer)
        dt = New DataTable("Estado_proyecto")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Estado_proyecto WHERE id_estado_proyecto = @id_Estado_proyecto", cnn.Coneccion)
        da.SelectCommand.Parameters.AddWithValue("@id_Estado_proyecto", idEstado_proyecto)
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
    Public Sub Borrar(ByVal idEstado_proyecto As Integer)
        dt = New DataTable("Estado_proyecto")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Estado_proyecto WHERE id_estado_proyecto = " & _
        idEstado_proyecto, cnn.Coneccion)
        da.Fill(dt)

        Me.AsignarTipos()

        If dt.Rows.Count = 0 Then
            Exit Sub
        Else
            dr = dt.Rows(0)
        End If

        Try
            Dim cmddel As New SqlCommand("cop_Estado_proyecto_Delete", cnn.Coneccion)
            cmddel.CommandType = CommandType.StoredProcedure
            da.DeleteCommand = cmddel
            Dim prm As SqlParameter
            prm = da.DeleteCommand.Parameters.Add("@id_estado_proyecto", SqlDbType.Int, 4, "id_estado_proyecto")
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
               Case "id_estado_proyecto"
                  dc.DataType = Type.GetType("System.Int32")
               Case "nombre_estado_proyecto"
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
        dt = New DataTable("Estado_proyecto")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Estado_proyecto WHERE id_estado_proyecto = 0", cnn.Coneccion)
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)
        Return dt
    End Function

    'funcion de busqueda
    Public Function Buscar(ByVal Nombre As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Estado_proyecto_Find", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre", SqlDbType.NChar, 30, "nombre")
        oda.SelectCommand.Parameters("@nombre").Value = Nombre

        oda.Fill(odt)

        Return odt
    End Function

    'funcion de consulta
    Public Function ConsultarTodo() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Estado_proyecto_GetAll", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion para llenar el combo
    Public Function GetCmb() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Estado_proyecto_GetCmb", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion que trae un registro poniendo el id
    Public Function GetOne(ByVal id_Estado_proyecto As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Estado_proyecto_GetOne", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_estado_proyecto", SqlDbType.Int, 4, "id_estado_proyecto")
        oda.SelectCommand.Parameters("@id_estado_proyecto").Value = id_Estado_proyecto

        oda.Fill(odt)

        Return odt
    End Function

    'controla si existe el registro en la base de datos
    Public Function Exist() As Boolean
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Estado_proyecto_Exist", cnn.Coneccion)
        Dim Total As Integer

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre_estado_proyecto", SqlDbType.varchar, 50, "nombre_estado_proyecto")
        oda.SelectCommand.Parameters("@nombre_estado_proyecto").Value = Me.nombre_estado_proyecto

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
        Command.CommandText = "DELETE FROM Estado_proyecto"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'borra todos los datos de la tabla
    Public Sub Truncate()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "TRUNCATE TABLE Estado_proyecto"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'inserta un registro en la tabla
    Public Sub InsertOne()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Estado_proyecto_InsertOne"

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'importa los datos de una campaña desde el txt
    Public Function Cargar_Archivo(ByVal path As String) As DataTable
        Dim odt As New DataTable("Estado_proyecto")

        Dim oda As New System.Data.OleDb.OleDbDataAdapter( _
        "SELECT * FROM Estado_proyecto.txt", cnntxt.Coneccion(path))

        oda.Fill(odt)

        Return odt
    End Function


End Class
