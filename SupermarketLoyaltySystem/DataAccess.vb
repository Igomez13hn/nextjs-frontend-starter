Imports System.Data.SQLite
Imports System.Configuration

Public Module DataAccess
    Private ReadOnly ConnectionString As String = ConfigurationManager.ConnectionStrings("LoyaltyDB").ConnectionString

    Public Sub InitializeDatabase()
        Try
            Using conn As New SQLiteConnection(ConnectionString)
                conn.Open()
                
                ' Crear tabla de clientes si no existe
                Dim createTableQuery As String = "
                    CREATE TABLE IF NOT EXISTS Customers (
                        CustomerID INTEGER PRIMARY KEY AUTOINCREMENT,
                        Name TEXT NOT NULL,
                        ContactNumber TEXT,
                        Email TEXT,
                        Points INTEGER DEFAULT 0,
                        RegistrationDate DATETIME DEFAULT CURRENT_TIMESTAMP
                    )"
                
                Using cmd As New SQLiteCommand(createTableQuery, conn)
                    cmd.ExecuteNonQuery()
                End Using

                ' Crear tabla de transacciones para historial
                Dim createTransactionTableQuery As String = "
                    CREATE TABLE IF NOT EXISTS Transactions (
                        TransactionID INTEGER PRIMARY KEY AUTOINCREMENT,
                        CustomerID INTEGER,
                        TransactionType TEXT NOT NULL,
                        Points INTEGER NOT NULL,
                        Description TEXT,
                        TransactionDate DATETIME DEFAULT CURRENT_TIMESTAMP,
                        FOREIGN KEY (CustomerID) REFERENCES Customers(CustomerID)
                    )"
                
                Using cmd As New SQLiteCommand(createTransactionTableQuery, conn)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            
            Logger.LogInfo("Base de datos inicializada correctamente")
        Catch ex As Exception
            Logger.Log(ex)
            Throw
        End Try
    End Sub

    Public Function AddCustomer(customer As Customer) As Boolean
        Try
            Using conn As New SQLiteConnection(ConnectionString)
                conn.Open()
                Dim query As String = "INSERT INTO Customers (Name, ContactNumber, Email, Points, RegistrationDate) VALUES (@Name, @ContactNumber, @Email, @Points, @RegistrationDate)"
                
                Using cmd As New SQLiteCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Name", customer.Name)
                    cmd.Parameters.AddWithValue("@ContactNumber", customer.ContactNumber)
                    cmd.Parameters.AddWithValue("@Email", customer.Email)
                    cmd.Parameters.AddWithValue("@Points", customer.Points)
                    cmd.Parameters.AddWithValue("@RegistrationDate", customer.RegistrationDate)
                    
                    Dim result As Integer = cmd.ExecuteNonQuery()
                    
                    If result > 0 Then
                        Logger.LogInfo($"Cliente agregado: {customer.Name}")
                        Return True
                    End If
                End Using
            End Using
            Return False
        Catch ex As Exception
            Logger.Log(ex)
            Return False
        End Try
    End Function

    Public Function GetCustomerById(customerId As Integer) As Customer
        Try
            Using conn As New SQLiteConnection(ConnectionString)
                conn.Open()
                Dim query As String = "SELECT * FROM Customers WHERE CustomerID = @CustomerID"
                
                Using cmd As New SQLiteCommand(query, conn)
                    cmd.Parameters.AddWithValue("@CustomerID", customerId)
                    
                    Using reader As SQLiteDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            Dim customer As New Customer()
                            customer.CustomerID = Convert.ToInt32(reader("CustomerID"))
                            customer.Name = reader("Name").ToString()
                            customer.ContactNumber = reader("ContactNumber").ToString()
                            customer.Email = reader("Email").ToString()
                            customer.Points = Convert.ToInt32(reader("Points"))
                            customer.RegistrationDate = Convert.ToDateTime(reader("RegistrationDate"))
                            Return customer
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            Logger.Log(ex)
        End Try
        Return Nothing
    End Function

    Public Function SearchCustomersByName(name As String) As List(Of Customer)
        Dim customers As New List(Of Customer)()
        Try
            Using conn As New SQLiteConnection(ConnectionString)
                conn.Open()
                Dim query As String = "SELECT * FROM Customers WHERE Name LIKE @Name ORDER BY Name"
                
                Using cmd As New SQLiteCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Name", $"%{name}%")
                    
                    Using reader As SQLiteDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            Dim customer As New Customer()
                            customer.CustomerID = Convert.ToInt32(reader("CustomerID"))
                            customer.Name = reader("Name").ToString()
                            customer.ContactNumber = reader("ContactNumber").ToString()
                            customer.Email = reader("Email").ToString()
                            customer.Points = Convert.ToInt32(reader("Points"))
                            customer.RegistrationDate = Convert.ToDateTime(reader("RegistrationDate"))
                            customers.Add(customer)
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            Logger.Log(ex)
        End Try
        Return customers
    End Function

    Public Function UpdateCustomerPoints(customerId As Integer, newPoints As Integer) As Boolean
        Try
            Using conn As New SQLiteConnection(ConnectionString)
                conn.Open()
                Dim query As String = "UPDATE Customers SET Points = @Points WHERE CustomerID = @CustomerID"
                
                Using cmd As New SQLiteCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Points", newPoints)
                    cmd.Parameters.AddWithValue("@CustomerID", customerId)
                    
                    Dim result As Integer = cmd.ExecuteNonQuery()
                    Return result > 0
                End Using
            End Using
        Catch ex As Exception
            Logger.Log(ex)
            Return False
        End Try
    End Function

    Public Function AddTransaction(customerId As Integer, transactionType As String, points As Integer, description As String) As Boolean
        Try
            Using conn As New SQLiteConnection(ConnectionString)
                conn.Open()
                Dim query As String = "INSERT INTO Transactions (CustomerID, TransactionType, Points, Description) VALUES (@CustomerID, @TransactionType, @Points, @Description)"
                
                Using cmd As New SQLiteCommand(query, conn)
                    cmd.Parameters.AddWithValue("@CustomerID", customerId)
                    cmd.Parameters.AddWithValue("@TransactionType", transactionType)
                    cmd.Parameters.AddWithValue("@Points", points)
                    cmd.Parameters.AddWithValue("@Description", description)
                    
                    Dim result As Integer = cmd.ExecuteNonQuery()
                    Return result > 0
                End Using
            End Using
        Catch ex As Exception
            Logger.Log(ex)
            Return False
        End Try
    End Function

    Public Function GetDashboardStats() As Dictionary(Of String, Object)
        Dim stats As New Dictionary(Of String, Object)()
        Try
            Using conn As New SQLiteConnection(ConnectionString)
                conn.Open()
                
                ' Total de clientes
                Dim totalCustomersQuery As String = "SELECT COUNT(*) FROM Customers"
                Using cmd As New SQLiteCommand(totalCustomersQuery, conn)
                    stats("TotalCustomers") = Convert.ToInt32(cmd.ExecuteScalar())
                End Using
                
                ' Total de puntos otorgados
                Dim totalPointsQuery As String = "SELECT SUM(Points) FROM Customers"
                Using cmd As New SQLiteCommand(totalPointsQuery, conn)
                    Dim result = cmd.ExecuteScalar()
                    stats("TotalPoints") = If(result IsNot Nothing AndAlso Not IsDBNull(result), Convert.ToInt32(result), 0)
                End Using
                
                ' Transacciones del día
                Dim todayTransactionsQuery As String = "SELECT COUNT(*) FROM Transactions WHERE DATE(TransactionDate) = DATE('now')"
                Using cmd As New SQLiteCommand(todayTransactionsQuery, conn)
                    stats("TodayTransactions") = Convert.ToInt32(cmd.ExecuteScalar())
                End Using
                
                ' Puntos canjeados hoy
                Dim todayRedeemedQuery As String = "SELECT SUM(Points) FROM Transactions WHERE TransactionType = 'REDEEM' AND DATE(TransactionDate) = DATE('now')"
                Using cmd As New SQLiteCommand(todayRedeemedQuery, conn)
                    Dim result = cmd.ExecuteScalar()
                    stats("TodayRedeemed") = If(result IsNot Nothing AndAlso Not IsDBNull(result), Convert.ToInt32(result), 0)
                End Using
            End Using
        Catch ex As Exception
            Logger.Log(ex)
        End Try
        Return stats
    End Function

    Public Function GetAllCustomers() As List(Of Customer)
        Dim customers As New List(Of Customer)()
        Try
            Using conn As New SQLiteConnection(ConnectionString)
                conn.Open()
                Dim query As String = "SELECT * FROM Customers ORDER BY Name"
                
                Using cmd As New SQLiteCommand(query, conn)
                    Using reader As SQLiteDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            Dim customer As New Customer()
                            customer.CustomerID = Convert.ToInt32(reader("CustomerID"))
                            customer.Name = reader("Name").ToString()
                            customer.ContactNumber = reader("ContactNumber").ToString()
                            customer.Email = reader("Email").ToString()
                            customer.Points = Convert.ToInt32(reader("Points"))
                            customer.RegistrationDate = Convert.ToDateTime(reader("RegistrationDate"))
                            customers.Add(customer)
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            Logger.Log(ex)
        End Try
        Return customers
    End Function
End Module
