Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Empresa_ent

    'defino las variables
    Friend dt As DataTable
    Friend dr As DataRow
    Friend da As SqlClient.SqlDataAdapter
    Friend cnn As New Conexion
    Friend cnntxt As New Conexion_txt

    'defino las propiedades
    Private _id_empresa As Int32
    Public ReadOnly Property id_empresa() As Int32
        Get
            _id_empresa = CInt(dr("id_empresa"))
            Return _id_empresa
        End Get
    end property

    Private _nombre_empresa As String
    Public Property nombre_empresa() As String
        Get
            _nombre_empresa = CStr(dr("nombre_empresa"))
            Return _nombre_empresa
        End Get
        Set(ByVal Value As String)
            dr("nombre_empresa") = Value
        End Set
    end property

    Private _codigo_empresa As String
    Public Property codigo_empresa() As String
        Get
            _codigo_empresa = CStr(dr("codigo_empresa"))
            Return _codigo_empresa
        End Get
        Set(ByVal Value As String)
            dr("codigo_empresa") = Value
        End Set
    end property

    Private _id_tipo_empresa As Int32
    Public Property id_tipo_empresa() As Int32
        Get
            _id_tipo_empresa = CInt(dr("id_tipo_empresa"))
            Return _id_tipo_empresa
        End Get
        Set(ByVal Value As Int32)
            dr("id_tipo_empresa") = Value
        End Set
    end property

    Private _mail_empresa As String
    Public Property mail_empresa() As String
        Get
            _mail_empresa = CStr(dr("mail_empresa"))
            Return _mail_empresa
        End Get
        Set(ByVal Value As String)
            dr("mail_empresa") = Value
        End Set
    end property

    Private _password_mail As String
    Public Property password_mail() As String
        Get
            _password_mail = CStr(dr("password_mail"))
            Return _password_mail
        End Get
        Set(ByVal Value As String)
            dr("password_mail") = Value
        End Set
    end property

    Private _logo As String
    Public Property logo() As String
        Get
            _logo = CStr(dr("logo"))
            Return _logo
        End Get
        Set(ByVal Value As String)
            dr("logo") = Value
        End Set
    end property


    'procedimiento insertar
    Public Sub Insertar()
        dt = New DataTable("Empresa")
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)

        Me.AsignarTipos()

        Dim cmdins As New SqlCommand("cop_Empresa_Insert", cnn.Coneccion)
        cmdins.CommandType = CommandType.StoredProcedure
        da.InsertCommand = cmdins

        Dim prm As SqlParameter
        prm = da.InsertCommand.Parameters.Add("@id_empresa", SqlDbType.int, 0, "id_empresa")
        prm.Direction = ParameterDirection.Output
        da.InsertCommand.Parameters.Add("@nombre_empresa", SqlDbType.varchar, 50, "nombre_empresa")
        da.InsertCommand.Parameters.Add("@codigo_empresa", SqlDbType.varchar, 50, "codigo_empresa")
        da.InsertCommand.Parameters.Add("@id_tipo_empresa", SqlDbType.int, 4, "id_tipo_empresa")
        da.InsertCommand.Parameters.Add("@mail_empresa", SqlDbType.varchar, 50, "mail_empresa")
        da.InsertCommand.Parameters.Add("@password_mail", SqlDbType.varchar, 50, "password_mail")
        da.InsertCommand.Parameters.Add("@logo", SqlDbType.varchar, 5000, "logo")

        dr = dt.NewRow()
        dr("nombre_empresa") = ""
        dr("codigo_empresa") = ""
        dr("id_tipo_empresa") = 0
        dr("mail_empresa") = ""
        dr("password_mail") = ""
        dr("logo") = ""
        dt.Rows.Add(dr)
        CrearComandoUpdate()
    End Sub

    'procedimiento modificar
    Public Sub Modificar(ByVal idEmpresa As Integer)
        dt = New DataTable("Empresa")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Empresa WHERE id_empresa = @id_Empresa", cnn.Coneccion)
        da.SelectCommand.Parameters.AddWithValue("@id_Empresa", idEmpresa)
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
    Public Sub Borrar(ByVal idEmpresa As Integer)
        dt = New DataTable("Empresa")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Empresa WHERE id_empresa = " & _
        idEmpresa, cnn.Coneccion)
        da.Fill(dt)

        Me.AsignarTipos()

        If dt.Rows.Count = 0 Then
            Exit Sub
        Else
            dr = dt.Rows(0)
        End If

        Try
            Dim cmddel As New SqlCommand("cop_Empresa_Delete", cnn.Coneccion)
            cmddel.CommandType = CommandType.StoredProcedure
            da.DeleteCommand = cmddel
            Dim prm As SqlParameter
            prm = da.DeleteCommand.Parameters.Add("@id_empresa", SqlDbType.Int, 4, "id_empresa")
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
               Case "id_empresa"
                  dc.DataType = Type.GetType("System.Int32")
               Case "nombre_empresa"
                  dc.DataType = Type.GetType("System.String")
               Case "codigo_empresa"
                  dc.DataType = Type.GetType("System.String")
               Case "id_tipo_empresa"
                  dc.DataType = Type.GetType("System.Int32")
               Case "mail_empresa"
                  dc.DataType = Type.GetType("System.String")
               Case "password_mail"
                  dc.DataType = Type.GetType("System.String")
               Case "logo"
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
        dt = New DataTable("Empresa")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Empresa WHERE id_empresa = 0", cnn.Coneccion)
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)
        Return dt
    End Function

    'funcion de busqueda
    Public Function Buscar(ByVal Nombre As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Empresa_Find", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre", SqlDbType.NChar, 30, "nombre")
        oda.SelectCommand.Parameters("@nombre").Value = Nombre

        oda.Fill(odt)

        Return odt
    End Function

    'funcion de consulta
    Public Function ConsultarTodo() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Empresa_GetAll", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion para llenar el combo
    Public Function GetCmb() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Empresa_GetCmb", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion que trae un registro poniendo el id
    Public Function GetOne(ByVal id_Empresa As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Empresa_GetOne", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_empresa", SqlDbType.Int, 4, "id_empresa")
        oda.SelectCommand.Parameters("@id_empresa").Value = id_Empresa

        oda.Fill(odt)

        Return odt
    End Function

    'controla si existe el registro en la base de datos
    Public Function Exist() As Boolean
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Empresa_Exist", cnn.Coneccion)
        Dim Total As Integer

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre_empresa", SqlDbType.varchar, 50, "nombre_empresa")
        oda.SelectCommand.Parameters("@nombre_empresa").Value = Me.nombre_empresa
        oda.SelectCommand.Parameters.Add("@codigo_empresa", SqlDbType.varchar, 50, "codigo_empresa")
        oda.SelectCommand.Parameters("@codigo_empresa").Value = Me.codigo_empresa
        oda.SelectCommand.Parameters.Add("@id_tipo_empresa", SqlDbType.int, 4, "id_tipo_empresa")
        oda.SelectCommand.Parameters("@id_tipo_empresa").Value = Me.id_tipo_empresa
        oda.SelectCommand.Parameters.Add("@mail_empresa", SqlDbType.varchar, 50, "mail_empresa")
        oda.SelectCommand.Parameters("@mail_empresa").Value = Me.mail_empresa
        oda.SelectCommand.Parameters.Add("@password_mail", SqlDbType.varchar, 50, "password_mail")
        oda.SelectCommand.Parameters("@password_mail").Value = Me.password_mail
        oda.SelectCommand.Parameters.Add("@logo", SqlDbType.varchar, 5000, "logo")
        oda.SelectCommand.Parameters("@logo").Value = Me.logo

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
        Command.CommandText = "DELETE FROM Empresa"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'borra todos los datos de la tabla
    Public Sub Truncate()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "TRUNCATE TABLE Empresa"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'inserta un registro en la tabla
    Public Sub InsertOne()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Empresa_InsertOne"

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'importa los datos de una campaña desde el txt
    Public Function Cargar_Archivo(ByVal path As String) As DataTable
        Dim odt As New DataTable("Empresa")

        Dim oda As New System.Data.OleDb.OleDbDataAdapter( _
        "SELECT * FROM Empresa.txt", cnntxt.Coneccion(path))

        oda.Fill(odt)

        Return odt
    End Function


End Class
