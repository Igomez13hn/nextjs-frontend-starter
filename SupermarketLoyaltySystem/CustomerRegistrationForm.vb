Imports System.Configuration

Public Class CustomerRegistrationForm
    Inherits Form
    Private Sub InitializeComponent()
        Me.lblTitle = New Label()
        Me.lblName = New Label()
        Me.txtName = New TextBox()
        Me.lblPhone = New Label()
        Me.txtPhone = New TextBox()
        Me.lblEmail = New Label()
        Me.txtEmail = New TextBox()
        Me.lblInitialPurchase = New Label()
        Me.txtInitialPurchase = New TextBox()
        Me.lblPoints = New Label()
        Me.lblPointsValue = New Label()
        Me.btnRegister = New Button()
        Me.btnCancel = New Button()
        Me.SuspendLayout()
        
        ' Form
        Me.Text = "Registro de Cliente"
        Me.Size = New Size(450, 400)
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.FormBorderStyle = FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.BackColor = Color.White
        Me.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular)
        
        ' lblTitle
        Me.lblTitle.Text = "REGISTRO DE NUEVO CLIENTE"
        Me.lblTitle.Font = New Font("Segoe UI", 14.0F, FontStyle.Bold)
        Me.lblTitle.ForeColor = Color.FromArgb(64, 64, 64)
        Me.lblTitle.TextAlign = ContentAlignment.MiddleCenter
        Me.lblTitle.Location = New Point(50, 20)
        Me.lblTitle.Size = New Size(350, 25)
        
        ' lblName
        Me.lblName.Text = "Nombre Completo:"
        Me.lblName.Font = New Font("Segoe UI", 10.0F, FontStyle.Regular)
        Me.lblName.Location = New Point(30, 70)
        Me.lblName.Size = New Size(120, 23)
        
        ' txtName
        Me.txtName.Font = New Font("Segoe UI", 10.0F)
        Me.txtName.Location = New Point(160, 67)
        Me.txtName.Size = New Size(250, 25)
        
        ' lblPhone
        Me.lblPhone.Text = "Teléfono:"
        Me.lblPhone.Font = New Font("Segoe UI", 10.0F, FontStyle.Regular)
        Me.lblPhone.Location = New Point(30, 110)
        Me.lblPhone.Size = New Size(120, 23)
        
        ' txtPhone
        Me.txtPhone.Font = New Font("Segoe UI", 10.0F)
        Me.txtPhone.Location = New Point(160, 107)
        Me.txtPhone.Size = New Size(250, 25)
        
        ' lblEmail
        Me.lblEmail.Text = "Email:"
        Me.lblEmail.Font = New Font("Segoe UI", 10.0F, FontStyle.Regular)
        Me.lblEmail.Location = New Point(30, 150)
        Me.lblEmail.Size = New Size(120, 23)
        
        ' txtEmail
        Me.txtEmail.Font = New Font("Segoe UI", 10.0F)
        Me.txtEmail.Location = New Point(160, 147)
        Me.txtEmail.Size = New Size(250, 25)
        
        ' lblInitialPurchase
        Me.lblInitialPurchase.Text = "Compra Inicial ($):"
        Me.lblInitialPurchase.Font = New Font("Segoe UI", 10.0F, FontStyle.Regular)
        Me.lblInitialPurchase.Location = New Point(30, 190)
        Me.lblInitialPurchase.Size = New Size(120, 23)
        
        ' txtInitialPurchase
        Me.txtInitialPurchase.Font = New Font("Segoe UI", 10.0F)
        Me.txtInitialPurchase.Location = New Point(160, 187)
        Me.txtInitialPurchase.Size = New Size(100, 25)
        Me.txtInitialPurchase.Text = "0"
        
        ' lblPoints
        Me.lblPoints.Text = "Puntos a Otorgar:"
        Me.lblPoints.Font = New Font("Segoe UI", 10.0F, FontStyle.Regular)
        Me.lblPoints.Location = New Point(30, 230)
        Me.lblPoints.Size = New Size(120, 23)
        
        ' lblPointsValue
        Me.lblPointsValue.Text = "0"
        Me.lblPointsValue.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        Me.lblPointsValue.ForeColor = Color.FromArgb(0, 120, 215)
        Me.lblPointsValue.Location = New Point(160, 227)
        Me.lblPointsValue.Size = New Size(100, 25)
        
        ' btnRegister
        Me.btnRegister.Text = "Registrar Cliente"
        Me.btnRegister.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        Me.btnRegister.BackColor = Color.FromArgb(0, 120, 215)
        Me.btnRegister.ForeColor = Color.White
        Me.btnRegister.FlatStyle = FlatStyle.Flat
        Me.btnRegister.FlatAppearance.BorderSize = 0
        Me.btnRegister.Location = New Point(160, 290)
        Me.btnRegister.Size = New Size(130, 40)
        Me.btnRegister.Cursor = Cursors.Hand
        
        ' btnCancel
        Me.btnCancel.Text = "Cancelar"
        Me.btnCancel.Font = New Font("Segoe UI", 10.0F)
        Me.btnCancel.BackColor = Color.FromArgb(240, 240, 240)
        Me.btnCancel.ForeColor = Color.FromArgb(64, 64, 64)
        Me.btnCancel.FlatStyle = FlatStyle.Flat
        Me.btnCancel.FlatAppearance.BorderColor = Color.FromArgb(200, 200, 200)
        Me.btnCancel.Location = New Point(300, 290)
        Me.btnCancel.Size = New Size(80, 40)
        Me.btnCancel.Cursor = Cursors.Hand
        
        ' Add controls to form
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblPhone)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.lblInitialPurchase)
        Me.Controls.Add(Me.txtInitialPurchase)
        Me.Controls.Add(Me.lblPoints)
        Me.Controls.Add(Me.lblPointsValue)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.btnCancel)
        
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Private WithEvents lblTitle As Label
    Private WithEvents lblName As Label
    Private WithEvents txtName As TextBox
    Private WithEvents lblPhone As Label
    Private WithEvents txtPhone As TextBox
    Private WithEvents lblEmail As Label
    Private WithEvents txtEmail As TextBox
    Private WithEvents lblInitialPurchase As Label
    Private WithEvents txtInitialPurchase As TextBox
    Private WithEvents lblPoints As Label
    Private WithEvents lblPointsValue As Label
    Private WithEvents btnRegister As Button
    Private WithEvents btnCancel As Button

    Public Sub New()
        InitializeComponent()
        AddHandler txtInitialPurchase.TextChanged, AddressOf txtInitialPurchase_TextChanged
    End Sub

    Private Function GetConversionRate() As Integer
        Dim rate As Integer = 1
        Try
            Dim setting = ConfigurationManager.AppSettings("PointsPerDollar")
            If Not String.IsNullOrEmpty(setting) Then
                Integer.TryParse(setting, rate)
            End If
        Catch ex As Exception
            ' Log error and default to 1
            Logger.Log(ex)
            rate = 1
        End Try
        Return rate
    End Function

    Private Sub txtInitialPurchase_TextChanged(sender As Object, e As EventArgs)
        Try
            Dim purchaseAmount As Decimal = 0
            If Decimal.TryParse(txtInitialPurchase.Text, purchaseAmount) Then
                Dim conversionRate As Integer = GetConversionRate()
                Dim points As Integer = CInt(purchaseAmount * conversionRate)
                lblPointsValue.Text = points.ToString()
            Else
                lblPointsValue.Text = "0"
            End If
        Catch ex As Exception
            lblPointsValue.Text = "0"
        End Try
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Try
            ' Validar campos obligatorios
            If String.IsNullOrWhiteSpace(txtName.Text) Then
                MessageBox.Show("El nombre es obligatorio.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtName.Focus()
                Return
            End If

            If String.IsNullOrWhiteSpace(txtPhone.Text) Then
                MessageBox.Show("El teléfono es obligatorio.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtPhone.Focus()
                Return
            End If

            ' Validar email si se proporciona
            If Not String.IsNullOrWhiteSpace(txtEmail.Text) AndAlso Not IsValidEmail(txtEmail.Text) Then
                MessageBox.Show("El formato del email no es válido.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtEmail.Focus()
                Return
            End If

            ' Calcular puntos
            Dim purchaseAmount As Decimal = 0
            Decimal.TryParse(txtInitialPurchase.Text, purchaseAmount)
            Dim conversionRate As Integer = GetConversionRate()
            Dim points As Integer = CInt(purchaseAmount * conversionRate)

            ' Crear nuevo cliente
            Dim newCustomer As New Customer(txtName.Text.Trim(), txtPhone.Text.Trim(), txtEmail.Text.Trim(), points)

            ' Guardar en base de datos
            If DataAccess.AddCustomer(newCustomer) Then
                MessageBox.Show($"Cliente registrado exitosamente.{Environment.NewLine}Puntos otorgados: {points}", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.DialogResult = DialogResult.OK
                Me.Close()
            Else
                MessageBox.Show("Error al registrar el cliente. Por favor intente nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            Logger.Log(ex)
            MessageBox.Show("Ocurrió un error al registrar el cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Function IsValidEmail(email As String) As Boolean
        Try
            Dim addr As New System.Net.Mail.MailAddress(email)
            Return addr.Address = email
        Catch
            Return False
        End Try
    End Function

    Private Sub txtInitialPurchase_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtInitialPurchase.KeyPress
        ' Solo permitir números y punto decimal
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "."c Then
            e.Handled = True
        End If

        ' Solo permitir un punto decimal
        If e.KeyChar = "."c AndAlso DirectCast(sender, TextBox).Text.IndexOf("."c) > -1 Then
            e.Handled = True
        End If
    End Sub
End Class
