Public Class MainForm
    Inherits Form
    Private Sub InitializeComponent()
        Me.lblTitle = New Label()
        Me.pnlStats = New Panel()
        Me.lblTotalCustomers = New Label()
        Me.lblTotalCustomersValue = New Label()
        Me.lblTotalPoints = New Label()
        Me.lblTotalPointsValue = New Label()
        Me.lblTodayTransactions = New Label()
        Me.lblTodayTransactionsValue = New Label()
        Me.lblTodayRedeemed = New Label()
        Me.lblTodayRedeemedValue = New Label()
        Me.pnlNavigation = New Panel()
        Me.btnRegisterCustomer = New Button()
        Me.btnRedeemPoints = New Button()
        Me.btnViewCustomers = New Button()
        Me.btnRefresh = New Button()
        Me.lstRecentCustomers = New ListBox()
        Me.lblRecentCustomers = New Label()
        Me.SuspendLayout()
        
        ' Form
        Me.Text = "Sistema de Fidelidad - Supermercado El Ahorro"
        Me.Size = New Size(800, 600)
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.BackColor = Color.White
        Me.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular)
        Me.WindowState = FormWindowState.Maximized
        
        ' lblTitle
        Me.lblTitle.Text = "SISTEMA DE FIDELIDAD DE CLIENTES"
        Me.lblTitle.Font = New Font("Segoe UI", 18.0F, FontStyle.Bold)
        Me.lblTitle.ForeColor = Color.FromArgb(64, 64, 64)
        Me.lblTitle.TextAlign = ContentAlignment.MiddleCenter
        Me.lblTitle.Location = New Point(50, 20)
        Me.lblTitle.Size = New Size(700, 35)
        Me.lblTitle.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        
        ' pnlStats
        Me.pnlStats.BackColor = Color.FromArgb(248, 249, 250)
        Me.pnlStats.BorderStyle = BorderStyle.FixedSingle
        Me.pnlStats.Location = New Point(30, 70)
        Me.pnlStats.Size = New Size(740, 120)
        Me.pnlStats.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        
        ' Stats Labels
        Me.lblTotalCustomers.Text = "Total Clientes"
        Me.lblTotalCustomers.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        Me.lblTotalCustomers.ForeColor = Color.FromArgb(64, 64, 64)
        Me.lblTotalCustomers.Location = New Point(20, 20)
        Me.lblTotalCustomers.Size = New Size(150, 20)
        
        Me.lblTotalCustomersValue.Text = "0"
        Me.lblTotalCustomersValue.Font = New Font("Segoe UI", 16.0F, FontStyle.Bold)
        Me.lblTotalCustomersValue.ForeColor = Color.FromArgb(0, 120, 215)
        Me.lblTotalCustomersValue.Location = New Point(20, 45)
        Me.lblTotalCustomersValue.Size = New Size(150, 30)
        
        Me.lblTotalPoints.Text = "Total Puntos"
        Me.lblTotalPoints.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        Me.lblTotalPoints.ForeColor = Color.FromArgb(64, 64, 64)
        Me.lblTotalPoints.Location = New Point(200, 20)
        Me.lblTotalPoints.Size = New Size(150, 20)
        
        Me.lblTotalPointsValue.Text = "0"
        Me.lblTotalPointsValue.Font = New Font("Segoe UI", 16.0F, FontStyle.Bold)
        Me.lblTotalPointsValue.ForeColor = Color.FromArgb(40, 167, 69)
        Me.lblTotalPointsValue.Location = New Point(200, 45)
        Me.lblTotalPointsValue.Size = New Size(150, 30)
        
        Me.lblTodayTransactions.Text = "Transacciones Hoy"
        Me.lblTodayTransactions.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        Me.lblTodayTransactions.ForeColor = Color.FromArgb(64, 64, 64)
        Me.lblTodayTransactions.Location = New Point(380, 20)
        Me.lblTodayTransactions.Size = New Size(150, 20)
        
        Me.lblTodayTransactionsValue.Text = "0"
        Me.lblTodayTransactionsValue.Font = New Font("Segoe UI", 16.0F, FontStyle.Bold)
        Me.lblTodayTransactionsValue.ForeColor = Color.FromArgb(255, 193, 7)
        Me.lblTodayTransactionsValue.Location = New Point(380, 45)
        Me.lblTodayTransactionsValue.Size = New Size(150, 30)
        
        Me.lblTodayRedeemed.Text = "Puntos Canjeados Hoy"
        Me.lblTodayRedeemed.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        Me.lblTodayRedeemed.ForeColor = Color.FromArgb(64, 64, 64)
        Me.lblTodayRedeemed.Location = New Point(560, 20)
        Me.lblTodayRedeemed.Size = New Size(150, 20)
        
        Me.lblTodayRedeemedValue.Text = "0"
        Me.lblTodayRedeemedValue.Font = New Font("Segoe UI", 16.0F, FontStyle.Bold)
        Me.lblTodayRedeemedValue.ForeColor = Color.FromArgb(220, 53, 69)
        Me.lblTodayRedeemedValue.Location = New Point(560, 45)
        Me.lblTodayRedeemedValue.Size = New Size(150, 30)
        
        ' Add stats labels to panel
        Me.pnlStats.Controls.Add(Me.lblTotalCustomers)
        Me.pnlStats.Controls.Add(Me.lblTotalCustomersValue)
        Me.pnlStats.Controls.Add(Me.lblTotalPoints)
        Me.pnlStats.Controls.Add(Me.lblTotalPointsValue)
        Me.pnlStats.Controls.Add(Me.lblTodayTransactions)
        Me.pnlStats.Controls.Add(Me.lblTodayTransactionsValue)
        Me.pnlStats.Controls.Add(Me.lblTodayRedeemed)
        Me.pnlStats.Controls.Add(Me.lblTodayRedeemedValue)
        
        ' pnlNavigation
        Me.pnlNavigation.BackColor = Color.FromArgb(248, 249, 250)
        Me.pnlNavigation.BorderStyle = BorderStyle.FixedSingle
        Me.pnlNavigation.Location = New Point(30, 210)
        Me.pnlNavigation.Size = New Size(740, 80)
        Me.pnlNavigation.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        
        ' Navigation Buttons
        Me.btnRegisterCustomer.Text = "Registrar Cliente"
        Me.btnRegisterCustomer.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        Me.btnRegisterCustomer.BackColor = Color.FromArgb(0, 120, 215)
        Me.btnRegisterCustomer.ForeColor = Color.White
        Me.btnRegisterCustomer.FlatStyle = FlatStyle.Flat
        Me.btnRegisterCustomer.FlatAppearance.BorderSize = 0
        Me.btnRegisterCustomer.Location = New Point(20, 20)
        Me.btnRegisterCustomer.Size = New Size(150, 40)
        Me.btnRegisterCustomer.Cursor = Cursors.Hand
        
        Me.btnRedeemPoints.Text = "Canjear Puntos"
        Me.btnRedeemPoints.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        Me.btnRedeemPoints.BackColor = Color.FromArgb(40, 167, 69)
        Me.btnRedeemPoints.ForeColor = Color.White
        Me.btnRedeemPoints.FlatStyle = FlatStyle.Flat
        Me.btnRedeemPoints.FlatAppearance.BorderSize = 0
        Me.btnRedeemPoints.Location = New Point(190, 20)
        Me.btnRedeemPoints.Size = New Size(150, 40)
        Me.btnRedeemPoints.Cursor = Cursors.Hand
        
        Me.btnViewCustomers.Text = "Ver Clientes"
        Me.btnViewCustomers.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        Me.btnViewCustomers.BackColor = Color.FromArgb(255, 193, 7)
        Me.btnViewCustomers.ForeColor = Color.White
        Me.btnViewCustomers.FlatStyle = FlatStyle.Flat
        Me.btnViewCustomers.FlatAppearance.BorderSize = 0
        Me.btnViewCustomers.Location = New Point(360, 20)
        Me.btnViewCustomers.Size = New Size(150, 40)
        Me.btnViewCustomers.Cursor = Cursors.Hand
        
        Me.btnRefresh.Text = "Actualizar"
        Me.btnRefresh.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        Me.btnRefresh.BackColor = Color.FromArgb(108, 117, 125)
        Me.btnRefresh.ForeColor = Color.White
        Me.btnRefresh.FlatStyle = FlatStyle.Flat
        Me.btnRefresh.FlatAppearance.BorderSize = 0
        Me.btnRefresh.Location = New Point(530, 20)
        Me.btnRefresh.Size = New Size(150, 40)
        Me.btnRefresh.Cursor = Cursors.Hand
        
        ' Add navigation buttons to panel
        Me.pnlNavigation.Controls.Add(Me.btnRegisterCustomer)
        Me.pnlNavigation.Controls.Add(Me.btnRedeemPoints)
        Me.pnlNavigation.Controls.Add(Me.btnViewCustomers)
        Me.pnlNavigation.Controls.Add(Me.btnRefresh)
        
        ' lblRecentCustomers
        Me.lblRecentCustomers.Text = "CLIENTES REGISTRADOS"
        Me.lblRecentCustomers.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        Me.lblRecentCustomers.ForeColor = Color.FromArgb(64, 64, 64)
        Me.lblRecentCustomers.Location = New Point(30, 310)
        Me.lblRecentCustomers.Size = New Size(300, 25)
        
        ' lstRecentCustomers
        Me.lstRecentCustomers.Font = New Font("Segoe UI", 10.0F)
        Me.lstRecentCustomers.Location = New Point(30, 340)
        Me.lstRecentCustomers.Size = New Size(740, 200)
        Me.lstRecentCustomers.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        
        ' Add controls to form
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.pnlStats)
        Me.Controls.Add(Me.pnlNavigation)
        Me.Controls.Add(Me.lblRecentCustomers)
        Me.Controls.Add(Me.lstRecentCustomers)
        
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Private WithEvents lblTitle As Label
    Private WithEvents pnlStats As Panel
    Private WithEvents lblTotalCustomers As Label
    Private WithEvents lblTotalCustomersValue As Label
    Private WithEvents lblTotalPoints As Label
    Private WithEvents lblTotalPointsValue As Label
    Private WithEvents lblTodayTransactions As Label
    Private WithEvents lblTodayTransactionsValue As Label
    Private WithEvents lblTodayRedeemed As Label
    Private WithEvents lblTodayRedeemedValue As Label
    Private WithEvents pnlNavigation As Panel
    Private WithEvents btnRegisterCustomer As Button
    Private WithEvents btnRedeemPoints As Button
    Private WithEvents btnViewCustomers As Button
    Private WithEvents btnRefresh As Button
    Private WithEvents lstRecentCustomers As ListBox
    Private WithEvents lblRecentCustomers As Label

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ' Inicializar base de datos
            DataAccess.InitializeDatabase()
            
            ' Cargar estadísticas del dashboard
            LoadDashboardStats()
            
            ' Cargar lista de clientes
            LoadCustomersList()
            
            Logger.LogInfo("Sistema iniciado correctamente")
        Catch ex As Exception
            Logger.Log(ex)
            MessageBox.Show("Error al inicializar el sistema.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LoadDashboardStats()
        Try
            Dim stats As Dictionary(Of String, Object) = DataAccess.GetDashboardStats()
            
            lblTotalCustomersValue.Text = stats("TotalCustomers").ToString()
            lblTotalPointsValue.Text = stats("TotalPoints").ToString()
            lblTodayTransactionsValue.Text = stats("TodayTransactions").ToString()
            lblTodayRedeemedValue.Text = stats("TodayRedeemed").ToString()
            
        Catch ex As Exception
            Logger.Log(ex)
        End Try
    End Sub

    Private Sub LoadCustomersList()
        Try
            Dim customers As List(Of Customer) = DataAccess.GetAllCustomers()
            lstRecentCustomers.DataSource = Nothing
            lstRecentCustomers.DataSource = customers
            lstRecentCustomers.DisplayMember = "ToString"
        Catch ex As Exception
            Logger.Log(ex)
        End Try
    End Sub

    Private Sub btnRegisterCustomer_Click(sender As Object, e As EventArgs) Handles btnRegisterCustomer.Click
        Try
            Dim regForm As New CustomerRegistrationForm()
            If regForm.ShowDialog() = DialogResult.OK Then
                LoadDashboardStats()
                LoadCustomersList()
            End If
        Catch ex As Exception
            Logger.Log(ex)
            MessageBox.Show("Error al abrir el formulario de registro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnRedeemPoints_Click(sender As Object, e As EventArgs) Handles btnRedeemPoints.Click
        Try
            Dim redeemForm As New CustomerRedemptionForm()
            redeemForm.ShowDialog()
            LoadDashboardStats()
            LoadCustomersList()
        Catch ex As Exception
            Logger.Log(ex)
            MessageBox.Show("Error al abrir el formulario de canje.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnViewCustomers_Click(sender As Object, e As EventArgs) Handles btnViewCustomers.Click
        Try
            LoadCustomersList()
            MessageBox.Show($"Lista actualizada. Total de clientes: {lstRecentCustomers.Items.Count}", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            Logger.Log(ex)
            MessageBox.Show("Error al cargar la lista de clientes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Try
            LoadDashboardStats()
            LoadCustomersList()
            MessageBox.Show("Datos actualizados correctamente.", "Actualización", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            Logger.Log(ex)
            MessageBox.Show("Error al actualizar los datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
