Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Sub_proyecto_ent

    'defino las variables
    Friend dt As DataTable
    Friend dr As DataRow
    Friend da As SqlClient.SqlDataAdapter
    Friend cnn As New Conexion
    Friend cnntxt As New Conexion_txt

    'defino las propiedades
    Private _id_sub_proyecto As Int32
    Public ReadOnly Property id_sub_proyecto() As Int32
        Get
            _id_sub_proyecto = CInt(dr("id_sub_proyecto"))
            Return _id_sub_proyecto
        End Get
    end property

    Private _nombre_sub_proyecto As String
    Public Property nombre_sub_proyecto() As String
        Get
            _nombre_sub_proyecto = CStr(dr("nombre_sub_proyecto"))
            Return _nombre_sub_proyecto
        End Get
        Set(ByVal Value As String)
            dr("nombre_sub_proyecto") = Value
        End Set
    end property

    Private _codigo_sub_proyecto As String
    Public Property codigo_sub_proyecto() As String
        Get
            _codigo_sub_proyecto = CStr(dr("codigo_sub_proyecto"))
            Return _codigo_sub_proyecto
        End Get
        Set(ByVal Value As String)
            dr("codigo_sub_proyecto") = Value
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

    Private _fecha_prevista As DateTime
    Public Property fecha_prevista() As DateTime
        Get
            _fecha_prevista = CDate(dr("fecha_prevista"))
            Return _fecha_prevista
        End Get
        Set(ByVal Value As DateTime)
            dr("fecha_prevista") = Value
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


    'procedimiento insertar
    Public Sub Insertar()
        dt = New DataTable("Sub_proyecto")
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)

        Me.AsignarTipos()

        Dim cmdins As New SqlCommand("cop_Sub_proyecto_Insert", cnn.Coneccion)
        cmdins.CommandType = CommandType.StoredProcedure
        da.InsertCommand = cmdins

        Dim prm As SqlParameter
        prm = da.InsertCommand.Parameters.Add("@id_sub_proyecto", SqlDbType.int, 0, "id_sub_proyecto")
        prm.Direction = ParameterDirection.Output
        da.InsertCommand.Parameters.Add("@nombre_sub_proyecto", SqlDbType.varchar, 50, "nombre_sub_proyecto")
        da.InsertCommand.Parameters.Add("@codigo_sub_proyecto", SqlDbType.varchar, 50, "codigo_sub_proyecto")
        da.InsertCommand.Parameters.Add("@hora_prevista", SqlDbType.decimal, 9, "hora_prevista")
        da.InsertCommand.Parameters.Add("@hora_real", SqlDbType.decimal, 9, "hora_real")
        da.InsertCommand.Parameters.Add("@fecha_prevista", SqlDbType.datetime, 8, "fecha_prevista")
        da.InsertCommand.Parameters.Add("@fecha_real", SqlDbType.datetime, 8, "fecha_real")
        da.InsertCommand.Parameters.Add("@id_proyecto", SqlDbType.int, 4, "id_proyecto")

        dr = dt.NewRow()
        dr("nombre_sub_proyecto") = ""
        dr("codigo_sub_proyecto") = ""
        dr("hora_prevista") = 0
        dr("hora_real") = 0
        dr("fecha_prevista") = DateTime.Now
        dr("fecha_real") = DateTime.Now
        dr("id_proyecto") = 0
        dt.Rows.Add(dr)
        CrearComandoUpdate()
    End Sub

    'procedimiento modificar
    Public Sub Modificar(ByVal idSub_proyecto As Integer)
        dt = New DataTable("Sub_proyecto")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Sub_proyecto WHERE id_sub_proyecto = @id_Sub_proyecto", cnn.Coneccion)
        da.SelectCommand.Parameters.AddWithValue("@id_Sub_proyecto", idSub_proyecto)
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
    Public Sub Borrar(ByVal idSub_proyecto As Integer)
        dt = New DataTable("Sub_proyecto")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Sub_proyecto WHERE id_sub_proyecto = " & _
        idSub_proyecto, cnn.Coneccion)
        da.Fill(dt)

        Me.AsignarTipos()

        If dt.Rows.Count = 0 Then
            Exit Sub
        Else
            dr = dt.Rows(0)
        End If

        Try
            Dim cmddel As New SqlCommand("cop_Sub_proyecto_Delete", cnn.Coneccion)
            cmddel.CommandType = CommandType.StoredProcedure
            da.DeleteCommand = cmddel
            Dim prm As SqlParameter
            prm = da.DeleteCommand.Parameters.Add("@id_sub_proyecto", SqlDbType.Int, 4, "id_sub_proyecto")
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
               Case "id_sub_proyecto"
                  dc.DataType = Type.GetType("System.Int32")
               Case "nombre_sub_proyecto"
                  dc.DataType = Type.GetType("System.String")
               Case "codigo_sub_proyecto"
                  dc.DataType = Type.GetType("System.String")
               Case "hora_prevista"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "hora_real"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "fecha_prevista"
                  dc.DataType = Type.GetType("System.DateTime")
               Case "fecha_real"
                  dc.DataType = Type.GetType("System.DateTime")
               Case "id_proyecto"
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
        dt = New DataTable("Sub_proyecto")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Sub_proyecto WHERE id_sub_proyecto = 0", cnn.Coneccion)
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)
        Return dt
    End Function

    'funcion de busqueda
    Public Function Buscar(ByVal Nombre As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Sub_proyecto_Find", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre", SqlDbType.NChar, 30, "nombre")
        oda.SelectCommand.Parameters("@nombre").Value = Nombre

        oda.Fill(odt)

        Return odt
    End Function

    'funcion de consulta
    Public Function ConsultarTodo() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Sub_proyecto_GetAll", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion para llenar el combo
    Public Function GetCmb() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Sub_proyecto_GetCmb", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion que trae un registro poniendo el id
    Public Function GetOne(ByVal id_Sub_proyecto As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Sub_proyecto_GetOne", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_sub_proyecto", SqlDbType.Int, 4, "id_sub_proyecto")
        oda.SelectCommand.Parameters("@id_sub_proyecto").Value = id_Sub_proyecto

        oda.Fill(odt)

        Return odt
    End Function

    'controla si existe el registro en la base de datos
    Public Function Exist() As Boolean
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Sub_proyecto_Exist", cnn.Coneccion)
        Dim Total As Integer

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre_sub_proyecto", SqlDbType.varchar, 50, "nombre_sub_proyecto")
        oda.SelectCommand.Parameters("@nombre_sub_proyecto").Value = Me.nombre_sub_proyecto
        oda.SelectCommand.Parameters.Add("@codigo_sub_proyecto", SqlDbType.varchar, 50, "codigo_sub_proyecto")
        oda.SelectCommand.Parameters("@codigo_sub_proyecto").Value = Me.codigo_sub_proyecto
        oda.SelectCommand.Parameters.Add("@hora_prevista", SqlDbType.decimal, 9, "hora_prevista")
        oda.SelectCommand.Parameters("@hora_prevista").Value = Me.hora_prevista
        oda.SelectCommand.Parameters.Add("@hora_real", SqlDbType.decimal, 9, "hora_real")
        oda.SelectCommand.Parameters("@hora_real").Value = Me.hora_real
        oda.SelectCommand.Parameters.Add("@fecha_prevista", SqlDbType.datetime, 8, "fecha_prevista")
        oda.SelectCommand.Parameters("@fecha_prevista").Value = Me.fecha_prevista
        oda.SelectCommand.Parameters.Add("@fecha_real", SqlDbType.datetime, 8, "fecha_real")
        oda.SelectCommand.Parameters("@fecha_real").Value = Me.fecha_real
        oda.SelectCommand.Parameters.Add("@id_proyecto", SqlDbType.int, 4, "id_proyecto")
        oda.SelectCommand.Parameters("@id_proyecto").Value = Me.id_proyecto

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
        Command.CommandText = "DELETE FROM Sub_proyecto"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'borra todos los datos de la tabla
    Public Sub Truncate()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "TRUNCATE TABLE Sub_proyecto"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'inserta un registro en la tabla
    Public Sub InsertOne()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Sub_proyecto_InsertOne"

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'importa los datos de una campaña desde el txt
    Public Function Cargar_Archivo(ByVal path As String) As DataTable
        Dim odt As New DataTable("Sub_proyecto")

        Dim oda As New System.Data.OleDb.OleDbDataAdapter( _
        "SELECT * FROM Sub_proyecto.txt", cnntxt.Coneccion(path))

        oda.Fill(odt)

        Return odt
    End Function


End Class
