Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Tipo_proyecto_ent

    'defino las variables
    Friend dt As DataTable
    Friend dr As DataRow
    Friend da As SqlClient.SqlDataAdapter
    Friend cnn As New Conexion
    Friend cnntxt As New Conexion_txt

    'defino las propiedades
    Private _id_tipo_proyecto As Int32
    Public ReadOnly Property id_tipo_proyecto() As Int32
        Get
            _id_tipo_proyecto = CInt(dr("id_tipo_proyecto"))
            Return _id_tipo_proyecto
        End Get
    end property

    Private _nombre_tipo_proyecto As String
    Public Property nombre_tipo_proyecto() As String
        Get
            _nombre_tipo_proyecto = CStr(dr("nombre_tipo_proyecto"))
            Return _nombre_tipo_proyecto
        End Get
        Set(ByVal Value As String)
            dr("nombre_tipo_proyecto") = Value
        End Set
    end property


    'procedimiento insertar
    Public Sub Insertar()
        dt = New DataTable("Tipo_proyecto")
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)

        Me.AsignarTipos()

        Dim cmdins As New SqlCommand("cop_Tipo_proyecto_Insert", cnn.Coneccion)
        cmdins.CommandType = CommandType.StoredProcedure
        da.InsertCommand = cmdins

        Dim prm As SqlParameter
        prm = da.InsertCommand.Parameters.Add("@id_tipo_proyecto", SqlDbType.int, 0, "id_tipo_proyecto")
        prm.Direction = ParameterDirection.Output
        da.InsertCommand.Parameters.Add("@nombre_tipo_proyecto", SqlDbType.varchar, 50, "nombre_tipo_proyecto")

        dr = dt.NewRow()
        dr("nombre_tipo_proyecto") = ""
        dt.Rows.Add(dr)
        CrearComandoUpdate()
    End Sub

    'procedimiento modificar
    Public Sub Modificar(ByVal idTipo_proyecto As Integer)
        dt = New DataTable("Tipo_proyecto")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Tipo_proyecto WHERE id_tipo_proyecto = @id_Tipo_proyecto", cnn.Coneccion)
        da.SelectCommand.Parameters.AddWithValue("@id_Tipo_proyecto", idTipo_proyecto)
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
    Public Sub Borrar(ByVal idTipo_proyecto As Integer)
        dt = New DataTable("Tipo_proyecto")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Tipo_proyecto WHERE id_tipo_proyecto = " & _
        idTipo_proyecto, cnn.Coneccion)
        da.Fill(dt)

        Me.AsignarTipos()

        If dt.Rows.Count = 0 Then
            Exit Sub
        Else
            dr = dt.Rows(0)
        End If

        Try
            Dim cmddel As New SqlCommand("cop_Tipo_proyecto_Delete", cnn.Coneccion)
            cmddel.CommandType = CommandType.StoredProcedure
            da.DeleteCommand = cmddel
            Dim prm As SqlParameter
            prm = da.DeleteCommand.Parameters.Add("@id_tipo_proyecto", SqlDbType.Int, 4, "id_tipo_proyecto")
            dt.Rows(0).Delete()
            CrearComandoUpdate()
            Guardar()
        Catch ex As Exception
            If ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint") Then
                MessageBox.Show("No se puede borrar registros que esten siendo utilizados en el sector de PROYECTO", "Error de referencias", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

            If Err.Number = 5 Then
            End If
        End Try
    End Sub

    'asigno el tipo de datos a los parametros
    Private Sub AsignarTipos()
        For Each dc As DataColumn In dt.Columns
            Select Case dc.ColumnName
               Case "id_tipo_proyecto"
                  dc.DataType = Type.GetType("System.Int32")
               Case "nombre_tipo_proyecto"
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
        dt = New DataTable("Tipo_proyecto")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Tipo_proyecto WHERE id_tipo_proyecto = 0", cnn.Coneccion)
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)
        Return dt
    End Function

    'funcion de busqueda
    Public Function Buscar(ByVal Nombre As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Tipo_proyecto_Find", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre", SqlDbType.NChar, 30, "nombre")
        oda.SelectCommand.Parameters("@nombre").Value = Nombre

        oda.Fill(odt)

        Return odt
    End Function

    'funcion de consulta
    Public Function ConsultarTodo() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Tipo_proyecto_GetAll", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion para llenar el combo
    Public Function GetCmb() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Tipo_proyecto_GetCmb", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion que trae un registro poniendo el id
    Public Function GetOne(ByVal id_Tipo_proyecto As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Tipo_proyecto_GetOne", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_tipo_proyecto", SqlDbType.Int, 4, "id_tipo_proyecto")
        oda.SelectCommand.Parameters("@id_tipo_proyecto").Value = id_Tipo_proyecto

        oda.Fill(odt)

        Return odt
    End Function

    'controla si existe el registro en la base de datos
    Public Function Exist() As Boolean
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Tipo_proyecto_Exist", cnn.Coneccion)
        Dim Total As Integer

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre_tipo_proyecto", SqlDbType.varchar, 50, "nombre_tipo_proyecto")
        oda.SelectCommand.Parameters("@nombre_tipo_proyecto").Value = Me.nombre_tipo_proyecto

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
        Command.CommandText = "DELETE FROM Tipo_proyecto"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'borra todos los datos de la tabla
    Public Sub Truncate()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "TRUNCATE TABLE Tipo_proyecto"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'inserta un registro en la tabla
    Public Sub InsertOne()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Tipo_proyecto_InsertOne"

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'importa los datos de una campa�a desde el txt
    Public Function Cargar_Archivo(ByVal path As String) As DataTable
        Dim odt As New DataTable("Tipo_proyecto")

        Dim oda As New System.Data.OleDb.OleDbDataAdapter( _
        "SELECT * FROM Tipo_proyecto.txt", cnntxt.Coneccion(path))

        oda.Fill(odt)

        Return odt
    End Function


End Class
