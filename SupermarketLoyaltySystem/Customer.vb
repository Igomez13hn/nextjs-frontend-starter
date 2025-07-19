Public Class Customer
    Public Property CustomerID As Integer
    Public Property Name As String
    Public Property ContactNumber As String
    Public Property Email As String
    Public Property Points As Integer
    Public Property RegistrationDate As DateTime

    Public Sub New()
        CustomerID = 0
        Name = ""
        ContactNumber = ""
        Email = ""
        Points = 0
        RegistrationDate = DateTime.Now
    End Sub

    Public Sub New(name As String, contactNumber As String, email As String, Optional initialPoints As Integer = 0)
        Me.Name = name
        Me.ContactNumber = contactNumber
        Me.Email = email
        Me.Points = initialPoints
        Me.RegistrationDate = DateTime.Now
    End Sub

    Public Sub AddPoints(points As Integer)
        If points > 0 Then
            Me.Points += points
        End If
    End Sub

    Public Function RedeemPoints(points As Integer) As Boolean
        If points > 0 AndAlso Me.Points >= points Then
            Me.Points -= points
            Return True
        End If
        Return False
    End Function

    Public Function HasSufficientPoints(points As Integer) As Boolean
        Return Me.Points >= points
    End Function

    Public Overrides Function ToString() As String
        Return $"{Name} - Puntos: {Points}"
    End Function
End Class
