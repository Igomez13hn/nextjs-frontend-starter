Public Class CustomerRedemptionForm
    Inherits Form
    Private currentCustomer As Customer = Nothing

    Private Sub InitializeComponent()
        Me.lblTitle = New Label()
        Me.lblSearch = New Label()
        Me.txtSearch = New TextBox()
        Me.btnSearch = New Button()
        Me.lstCustomers = New ListBox()
        Me.grpCustomerInfo = New GroupBox()
        Me.lblCustomerName = New Label()
        Me.lblCustomerPhone = New Label()
        Me.lblCustomerEmail = New Label()
        Me.lblCurrentPoints = New Label()
        Me.lblCurrentPointsValue = New Label()
        Me.lblRedeemAmount = New Label()
        Me.txtRedeemAmount = New TextBox()
        Me.btnRedeem = New Button()
        Me.btnCancel = New Button()
        Me.SuspendLayout()
        
        ' Form
        Me.Text = "Canje de Puntos"
        Me.Size = New Size(600, 500)
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.FormBorderStyle = FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.BackColor = Color.White
        Me.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular)
        
        ' lblTitle
        Me.lblTitle.Text = "CANJE DE PUNTOS DE FIDELIDAD"
        Me.lblTitle.Font = New Font("Segoe UI", 14.0F, FontStyle.Bold)
        Me.lblTitle.ForeColor = Color.FromArgb(64, 64, 64)
        Me.lblTitle.TextAlign = ContentAlignment.MiddleCenter
        Me.lblTitle.Location = New Point(50, 20)
        Me.lblTitle.Size = New Size(500, 25)
        
        ' lblSearch
        Me.lblSearch.Text = "Buscar Cliente:"
        Me.lblSearch.Font = New Font("Segoe UI", 10.0F, FontStyle.Regular)
        Me.lblSearch.Location = New Point(30, 60)
        Me.lblSearch.Size = New Size(100, 23)
        
        ' txtSearch
        Me.txtSearch.Font = New Font("Segoe UI", 10.0F)
        Me.txtSearch.Location = New Point(130, 57)
        Me.txtSearch.Size = New Size(300, 25)
        
        ' btnSearch
        Me.btnSearch.Text = "Buscar"
        Me.btnSearch.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        Me.btnSearch.BackColor = Color.FromArgb(0, 120, 215)
        Me.btnSearch.ForeColor = Color.White
        Me.btnSearch.FlatStyle = FlatStyle.Flat
        Me.btnSearch.FlatAppearance.BorderSize = 0
        Me.btnSearch.Location = New Point(440, 57)
        Me.btnSearch.Size = New Size(80, 25)
        Me.btnSearch.Cursor = Cursors.Hand
        
        ' lstCustomers
        Me.lstCustomers.Font = New Font("Segoe UI", 9.0F)
        Me.lstCustomers.Location = New Point(30, 90)
        Me.lstCustomers.Size = New Size(490, 80)
        Me.lstCustomers.DisplayMember = "Name"
        
        ' grpCustomerInfo
        Me.grpCustomerInfo.Text = "Información del Cliente"
        Me.grpCustomerInfo.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        Me.grpCustomerInfo.Location = New Point(30, 180)
        Me.grpCustomerInfo.Size = New Size(490, 200)
        Me.grpCustomerInfo.Enabled = False
        
        ' lblCustomerName
        Me.lblCustomerName.Text = "Nombre: "
        Me.lblCustomerName.Font = New Font("Segoe UI", 10.0F, FontStyle.Regular)
        Me.lblCustomerName.Location = New Point(20, 30)
        Me.lblCustomerName.Size = New Size(450, 23)
        
        ' lblCustomerPhone
        Me.lblCustomerPhone.Text = "Teléfono: "
        Me.lblCustomerPhone.Font = New Font("Segoe UI", 10.0F, FontStyle.Regular)
        Me.lblCustomerPhone.Location = New Point(20, 55)
        Me.lblCustomerPhone.Size = New Size(450, 23)
        
        ' lblCustomerEmail
        Me.lblCustomerEmail.Text = "Email: "
        Me.lblCustomerEmail.Font = New Font("Segoe UI", 10.0F, FontStyle.Regular)
        Me.lblCustomerEmail.Location = New Point(20, 80)
        Me.lblCustomerEmail.Size = New Size(450, 23)
        
        ' lblCurrentPoints
        Me.lblCurrentPoints.Text = "Puntos Disponibles:"
        Me.lblCurrentPoints.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        Me.lblCurrentPoints.Location = New Point(20, 110)
        Me.lblCurrentPoints.Size = New Size(150, 23)
        
        ' lblCurrentPointsValue
        Me.lblCurrentPointsValue.Text = "0"
        Me.lblCurrentPointsValue.Font = New Font("Segoe UI", 14.0F, FontStyle.Bold)
        Me.lblCurrentPointsValue.ForeColor = Color.FromArgb(0, 120, 215)
        Me.lblCurrentPointsValue.Location = New Point(170, 105)
        Me.lblCurrentPointsValue.Size = New Size(100, 30)
        
        ' lblRedeemAmount
        Me.lblRedeemAmount.Text = "Puntos a Canjear:"
        Me.lblRedeemAmount.Font = New Font("Segoe UI", 10.0F, FontStyle.Regular)
        Me.lblRedeemAmount.Location = New Point(20, 145)
        Me.lblRedeemAmount.Size = New Size(120, 23)
        
        ' txtRedeemAmount
        Me.txtRedeemAmount.Font = New Font("Segoe UI", 10.0F)
        Me.txtRedeemAmount.Location = New Point(150, 142)
        Me.txtRedeemAmount.Size = New Size(100, 25)
        
        ' btnRedeem
        Me.btnRedeem.Text = "Canjear Puntos"
        Me.btnRedeem.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        Me.btnRedeem.BackColor = Color.FromArgb(0, 120, 215)
        Me.btnRedeem.ForeColor = Color.White
        Me.btnRedeem.FlatStyle = FlatStyle.Flat
        Me.btnRedeem.FlatAppearance.BorderSize = 0
        Me.btnRedeem.Location = New Point(280, 140)
        Me.btnRedeem.Size = New Size(120, 30)
        Me.btnRedeem.Cursor = Cursors.Hand
        Me.btnRedeem.Enabled = False
        
        ' Add controls to group box
        Me.grpCustomerInfo.Controls.Add(Me.lblCustomerName)
        Me.grpCustomerInfo.Controls.Add(Me.lblCustomerPhone)
        Me.grpCustomerInfo.Controls.Add(Me.lblCustomerEmail)
        Me.grpCustomerInfo.Controls.Add(Me.lblCurrentPoints)
        Me.grpCustomerInfo.Controls.Add(Me.lblCurrentPointsValue)
        Me.grpCustomerInfo.Controls.Add(Me.lblRedeemAmount)
        Me.grpCustomerInfo.Controls.Add(Me.txtRedeemAmount)
        Me.grpCustomerInfo.Controls.Add(Me.btnRedeem)
        
        ' btnCancel
        Me.btnCancel.Text = "Cerrar"
        Me.btnCancel.Font = New Font("Segoe UI", 10.0F)
        Me.btnCancel.BackColor = Color.FromArgb(240, 240, 240)
        Me.btnCancel.ForeColor = Color.FromArgb(64, 64, 64)
        Me.btnCancel.FlatStyle = FlatStyle.Flat
        Me.btnCancel.FlatAppearance.BorderColor = Color.FromArgb(200, 200, 200)
        Me.btnCancel.Location = New Point(440, 400)
        Me.btnCancel.Size = New Size(80, 35)
        Me.btnCancel.Cursor = Cursors.Hand
        
        ' Add controls to form
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.lstCustomers)
        Me.Controls.Add(Me.grpCustomerInfo)
        Me.Controls.Add(Me.btnCancel)
        
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Private WithEvents lblTitle As Label
    Private WithEvents lblSearch As Label
    Private WithEvents txtSearch As TextBox
    Private WithEvents btnSearch As Button
    Private WithEvents lstCustomers As ListBox
    Private WithEvents grpCustomerInfo As GroupBox
    Private WithEvents lblCustomerName As Label
    Private WithEvents lblCustomerPhone As Label
    Private WithEvents lblCustomerEmail As Label
    Private WithEvents lblCurrentPoints As Label
    Private WithEvents lblCurrentPointsValue As Label
    Private WithEvents lblRedeemAmount As Label
    Private WithEvents txtRedeemAmount As TextBox
    Private WithEvents btnRedeem As Button
    Private WithEvents btnCancel As Button

    Public Sub New()
        InitializeComponent()
        AddHandler lstCustomers.SelectedIndexChanged, AddressOf lstCustomers_SelectedIndexChanged
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            If String.IsNullOrWhiteSpace(txtSearch.Text) Then
                MessageBox.Show("Por favor ingrese un nombre para buscar.", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtSearch.Focus()
                Return
            End If

            Dim customers As List(Of Customer) = DataAccess.SearchCustomersByName(txtSearch.Text.Trim())
            
            lstCustomers.DataSource = Nothing
            lstCustomers.DataSource = customers
            lstCustomers.DisplayMember = "Name"

            If customers.Count = 0 Then
                MessageBox.Show("No se encontraron clientes con ese nombre.", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            Logger.Log(ex)
            MessageBox.Show("Error al buscar clientes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub lstCustomers_SelectedIndexChanged(sender As Object, e As EventArgs)
        Try
            If lstCustomers.SelectedItem IsNot Nothing Then
                currentCustomer = DirectCast(lstCustomers.SelectedItem, Customer)
                LoadCustomerInfo()
                grpCustomerInfo.Enabled = True
                btnRedeem.Enabled = True
            Else
                grpCustomerInfo.Enabled = False
                btnRedeem.Enabled = False
            End If
        Catch ex As Exception
            Logger.Log(ex)
        End Try
    End Sub

    Private Sub LoadCustomerInfo()
        If currentCustomer IsNot Nothing Then
            lblCustomerName.Text = $"Nombre: {currentCustomer.Name}"
            lblCustomerPhone.Text = $"Teléfono: {currentCustomer.ContactNumber}"
            lblCustomerEmail.Text = $"Email: {currentCustomer.Email}"
            lblCurrentPointsValue.Text = currentCustomer.Points.ToString()
            txtRedeemAmount.Clear()
        End If
    End Sub

    Private Sub btnRedeem_Click(sender As Object, e As EventArgs) Handles btnRedeem.Click
        Try
            If currentCustomer Is Nothing Then
                MessageBox.Show("Por favor seleccione un cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim redeemPoints As Integer = 0
            If Not Integer.TryParse(txtRedeemAmount.Text, redeemPoints) OrElse redeemPoints <= 0 Then
                MessageBox.Show("Por favor ingrese una cantidad válida de puntos a canjear.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtRedeemAmount.Focus()
                Return
            End If

            If redeemPoints > currentCustomer.Points Then
                MessageBox.Show($"El cliente no tiene suficientes puntos.{Environment.NewLine}Puntos disponibles: {currentCustomer.Points}", "Puntos Insuficientes", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtRedeemAmount.Focus()
                Return
            End If

            ' Confirmar canje
            Dim result As DialogResult = MessageBox.Show($"¿Confirma el canje de {redeemPoints} puntos para {currentCustomer.Name}?", "Confirmar Canje", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            
            If result = DialogResult.Yes Then
                ' Actualizar puntos del cliente
                Dim newPoints As Integer = currentCustomer.Points - redeemPoints
                
                If DataAccess.UpdateCustomerPoints(currentCustomer.CustomerID, newPoints) Then
                    ' Registrar transacción
                    DataAccess.AddTransaction(currentCustomer.CustomerID, "REDEEM", redeemPoints, $"Canje de {redeemPoints} puntos")
                    
                    ' Actualizar objeto cliente local
                    currentCustomer.Points = newPoints
                    
                    ' Actualizar interfaz
                    LoadCustomerInfo()
                    
                    MessageBox.Show($"Canje realizado exitosamente.{Environment.NewLine}Puntos canjeados: {redeemPoints}{Environment.NewLine}Puntos restantes: {newPoints}", "Canje Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    
                    Logger.LogInfo($"Canje realizado - Cliente: {currentCustomer.Name}, Puntos: {redeemPoints}")
                Else
                    MessageBox.Show("Error al procesar el canje. Por favor intente nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If

        Catch ex As Exception
            Logger.Log(ex)
            MessageBox.Show("Ocurrió un error al procesar el canje.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub txtSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearch.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            btnSearch_Click(sender, e)
        End If
    End Sub

    Private Sub txtRedeemAmount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRedeemAmount.KeyPress
        ' Solo permitir números
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If

        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            btnRedeem_Click(sender, e)
        End If
    End Sub
End Class
