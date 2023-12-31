Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Proyecto_ent

    'defino las variables
    Friend dt As DataTable
    Friend dr As DataRow
    Friend da As SqlClient.SqlDataAdapter
    Friend cnn As New Conexion
    Friend cnntxt As New Conexion_txt

    'defino las propiedades
    Private _id_proyecto As Int32
    Public ReadOnly Property id_proyecto() As Int32
        Get
            _id_proyecto = CInt(dr("id_proyecto"))
            Return _id_proyecto
        End Get
    end property

    Private _nombre_proyecto As String
    Public Property nombre_proyecto() As String
        Get
            _nombre_proyecto = CStr(dr("nombre_proyecto"))
            Return _nombre_proyecto
        End Get
        Set(ByVal Value As String)
            dr("nombre_proyecto") = Value
        End Set
    end property

    Private _codigo_proyecto As String
    Public Property codigo_proyecto() As String
        Get
            _codigo_proyecto = CStr(dr("codigo_proyecto"))
            Return _codigo_proyecto
        End Get
        Set(ByVal Value As String)
            dr("codigo_proyecto") = Value
        End Set
    end property

    Private _id_tipo_proyecto As Int32
    Public Property id_tipo_proyecto() As Int32
        Get
            _id_tipo_proyecto = CInt(dr("id_tipo_proyecto"))
            Return _id_tipo_proyecto
        End Get
        Set(ByVal Value As Int32)
            dr("id_tipo_proyecto") = Value
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

    Private _fecha_prevista_fin As DateTime
    Public Property fecha_prevista_fin() As DateTime
        Get
            _fecha_prevista_fin = CDate(dr("fecha_prevista_fin"))
            Return _fecha_prevista_fin
        End Get
        Set(ByVal Value As DateTime)
            dr("fecha_prevista_fin") = Value
        End Set
    end property

    Private _fecha_real_fin As DateTime
    Public Property fecha_real_fin() As DateTime
        Get
            _fecha_real_fin = CDate(dr("fecha_real_fin"))
            Return _fecha_real_fin
        End Get
        Set(ByVal Value As DateTime)
            dr("fecha_real_fin") = Value
        End Set
    end property

    Private _id_estado_proyecto As Int32
    Public Property id_estado_proyecto() As Int32
        Get
            _id_estado_proyecto = CInt(dr("id_estado_proyecto"))
            Return _id_estado_proyecto
        End Get
        Set(ByVal Value As Int32)
            dr("id_estado_proyecto") = Value
        End Set
    end property


    'procedimiento insertar
    Public Sub Insertar()
        dt = New DataTable("Proyecto")
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)

        Me.AsignarTipos()

        Dim cmdins As New SqlCommand("cop_Proyecto_Insert", cnn.Coneccion)
        cmdins.CommandType = CommandType.StoredProcedure
        da.InsertCommand = cmdins

        Dim prm As SqlParameter
        prm = da.InsertCommand.Parameters.Add("@id_proyecto", SqlDbType.int, 0, "id_proyecto")
        prm.Direction = ParameterDirection.Output
        da.InsertCommand.Parameters.Add("@nombre_proyecto", SqlDbType.varchar, 50, "nombre_proyecto")
        da.InsertCommand.Parameters.Add("@codigo_proyecto", SqlDbType.varchar, 50, "codigo_proyecto")
        da.InsertCommand.Parameters.Add("@id_tipo_proyecto", SqlDbType.int, 4, "id_tipo_proyecto")
        da.InsertCommand.Parameters.Add("@id_empresa", SqlDbType.int, 4, "id_empresa")
        da.InsertCommand.Parameters.Add("@hora_prevista", SqlDbType.decimal, 9, "hora_prevista")
        da.InsertCommand.Parameters.Add("@hora_real", SqlDbType.decimal, 9, "hora_real")
        da.InsertCommand.Parameters.Add("@fecha_prevista_fin", SqlDbType.datetime, 8, "fecha_prevista_fin")
        da.InsertCommand.Parameters.Add("@fecha_real_fin", SqlDbType.datetime, 8, "fecha_real_fin")
        da.InsertCommand.Parameters.Add("@id_estado_proyecto", SqlDbType.int, 4, "id_estado_proyecto")

        dr = dt.NewRow()
        dr("nombre_proyecto") = ""
        dr("codigo_proyecto") = ""
        dr("id_tipo_proyecto") = 0
        dr("id_empresa") = 0
        dr("hora_prevista") = 0
        dr("hora_real") = 0
        dr("fecha_prevista_fin") = DateTime.Now
        dr("fecha_real_fin") = DateTime.Now
        dr("id_estado_proyecto") = 0
        dt.Rows.Add(dr)
        CrearComandoUpdate()
    End Sub

    'procedimiento modificar
    Public Sub Modificar(ByVal idProyecto As Integer)
        dt = New DataTable("Proyecto")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Proyecto WHERE id_proyecto = @id_Proyecto", cnn.Coneccion)
        da.SelectCommand.Parameters.AddWithValue("@id_Proyecto", idProyecto)
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
    Public Sub Borrar(ByVal idProyecto As Integer)
        dt = New DataTable("Proyecto")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Proyecto WHERE id_proyecto = " & _
        idProyecto, cnn.Coneccion)
        da.Fill(dt)

        Me.AsignarTipos()

        If dt.Rows.Count = 0 Then
            Exit Sub
        Else
            dr = dt.Rows(0)
        End If

        Try
            Dim cmddel As New SqlCommand("cop_Proyecto_Delete", cnn.Coneccion)
            cmddel.CommandType = CommandType.StoredProcedure
            da.DeleteCommand = cmddel
            Dim prm As SqlParameter
            prm = da.DeleteCommand.Parameters.Add("@id_proyecto", SqlDbType.Int, 4, "id_proyecto")
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
               Case "id_proyecto"
                  dc.DataType = Type.GetType("System.Int32")
               Case "nombre_proyecto"
                  dc.DataType = Type.GetType("System.String")
               Case "codigo_proyecto"
                  dc.DataType = Type.GetType("System.String")
               Case "id_tipo_proyecto"
                  dc.DataType = Type.GetType("System.Int32")
               Case "id_empresa"
                  dc.DataType = Type.GetType("System.Int32")
               Case "hora_prevista"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "hora_real"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "fecha_prevista_fin"
                  dc.DataType = Type.GetType("System.DateTime")
               Case "fecha_real_fin"
                  dc.DataType = Type.GetType("System.DateTime")
               Case "id_estado_proyecto"
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
        dt = New DataTable("Proyecto")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Proyecto WHERE id_proyecto = 0", cnn.Coneccion)
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)
        Return dt
    End Function

    'funcion de busqueda
    Public Function Buscar(ByVal Nombre As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Proyecto_Find", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre", SqlDbType.NChar, 30, "nombre")
        oda.SelectCommand.Parameters("@nombre").Value = Nombre

        oda.Fill(odt)

        Return odt
    End Function

    'funcion de consulta
    Public Function ConsultarTodo() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Proyecto_GetAll", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion para llenar el combo
    Public Function GetCmb() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Proyecto_GetCmb", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion que trae un registro poniendo el id
    Public Function GetOne(ByVal id_Proyecto As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Proyecto_GetOne", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_proyecto", SqlDbType.Int, 4, "id_proyecto")
        oda.SelectCommand.Parameters("@id_proyecto").Value = id_Proyecto

        oda.Fill(odt)

        Return odt
    End Function

    'controla si existe el registro en la base de datos
    Public Function Exist() As Boolean
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Proyecto_Exist", cnn.Coneccion)
        Dim Total As Integer

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre_proyecto", SqlDbType.varchar, 50, "nombre_proyecto")
        oda.SelectCommand.Parameters("@nombre_proyecto").Value = Me.nombre_proyecto
        oda.SelectCommand.Parameters.Add("@codigo_proyecto", SqlDbType.varchar, 50, "codigo_proyecto")
        oda.SelectCommand.Parameters("@codigo_proyecto").Value = Me.codigo_proyecto
        oda.SelectCommand.Parameters.Add("@id_tipo_proyecto", SqlDbType.int, 4, "id_tipo_proyecto")
        oda.SelectCommand.Parameters("@id_tipo_proyecto").Value = Me.id_tipo_proyecto
        oda.SelectCommand.Parameters.Add("@id_empresa", SqlDbType.int, 4, "id_empresa")
        oda.SelectCommand.Parameters("@id_empresa").Value = Me.id_empresa
        oda.SelectCommand.Parameters.Add("@hora_prevista", SqlDbType.decimal, 9, "hora_prevista")
        oda.SelectCommand.Parameters("@hora_prevista").Value = Me.hora_prevista
        oda.SelectCommand.Parameters.Add("@hora_real", SqlDbType.decimal, 9, "hora_real")
        oda.SelectCommand.Parameters("@hora_real").Value = Me.hora_real
        oda.SelectCommand.Parameters.Add("@fecha_prevista_fin", SqlDbType.datetime, 8, "fecha_prevista_fin")
        oda.SelectCommand.Parameters("@fecha_prevista_fin").Value = Me.fecha_prevista_fin
        oda.SelectCommand.Parameters.Add("@fecha_real_fin", SqlDbType.datetime, 8, "fecha_real_fin")
        oda.SelectCommand.Parameters("@fecha_real_fin").Value = Me.fecha_real_fin
        oda.SelectCommand.Parameters.Add("@id_estado_proyecto", SqlDbType.int, 4, "id_estado_proyecto")
        oda.SelectCommand.Parameters("@id_estado_proyecto").Value = Me.id_estado_proyecto

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
        Command.CommandText = "DELETE FROM Proyecto"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'borra todos los datos de la tabla
    Public Sub Truncate()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "TRUNCATE TABLE Proyecto"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'inserta un registro en la tabla
    Public Sub InsertOne()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Proyecto_InsertOne"

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'importa los datos de una campa�a desde el txt
    Public Function Cargar_Archivo(ByVal path As String) As DataTable
        Dim odt As New DataTable("Proyecto")

        Dim oda As New System.Data.OleDb.OleDbDataAdapter( _
        "SELECT * FROM Proyecto.txt", cnntxt.Coneccion(path))

        oda.Fill(odt)

        Return odt
    End Function


End Class
