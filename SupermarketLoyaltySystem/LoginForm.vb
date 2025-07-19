Public Class LoginForm
    Inherits Form
    Private Sub InitializeComponent()
        Me.lblTitle = New Label()
        Me.lblUsername = New Label()
        Me.txtUsername = New TextBox()
        Me.lblPassword = New Label()
        Me.txtPassword = New TextBox()
        Me.btnLogin = New Button()
        Me.btnCancel = New Button()
        Me.SuspendLayout()
        
        ' Form
        Me.Text = "Sistema de Fidelidad - Login"
        Me.Size = New Size(400, 300)
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.FormBorderStyle = FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.BackColor = Color.White
        Me.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular)
        
        ' lblTitle
        Me.lblTitle.Text = "SUPERMERCADO EL AHORRO"
        Me.lblTitle.Font = New Font("Segoe UI", 16.0F, FontStyle.Bold)
        Me.lblTitle.ForeColor = Color.FromArgb(64, 64, 64)
        Me.lblTitle.TextAlign = ContentAlignment.MiddleCenter
        Me.lblTitle.Location = New Point(50, 30)
        Me.lblTitle.Size = New Size(300, 30)
        
        ' lblUsername
        Me.lblUsername.Text = "Usuario:"
        Me.lblUsername.Font = New Font("Segoe UI", 10.0F, FontStyle.Regular)
        Me.lblUsername.Location = New Point(50, 90)
        Me.lblUsername.Size = New Size(80, 23)
        
        ' txtUsername
        Me.txtUsername.Font = New Font("Segoe UI", 10.0F)
        Me.txtUsername.Location = New Point(140, 87)
        Me.txtUsername.Size = New Size(200, 25)
        Me.txtUsername.Text = "admin"
        
        ' lblPassword
        Me.lblPassword.Text = "Contraseña:"
        Me.lblPassword.Font = New Font("Segoe UI", 10.0F, FontStyle.Regular)
        Me.lblPassword.Location = New Point(50, 130)
        Me.lblPassword.Size = New Size(80, 23)
        
        ' txtPassword
        Me.txtPassword.Font = New Font("Segoe UI", 10.0F)
        Me.txtPassword.Location = New Point(140, 127)
        Me.txtPassword.Size = New Size(200, 25)
        Me.txtPassword.UseSystemPasswordChar = True
        Me.txtPassword.Text = "password"
        
        ' btnLogin
        Me.btnLogin.Text = "Iniciar Sesión"
        Me.btnLogin.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        Me.btnLogin.BackColor = Color.FromArgb(0, 120, 215)
        Me.btnLogin.ForeColor = Color.White
        Me.btnLogin.FlatStyle = FlatStyle.Flat
        Me.btnLogin.FlatAppearance.BorderSize = 0
        Me.btnLogin.Location = New Point(140, 180)
        Me.btnLogin.Size = New Size(120, 35)
        Me.btnLogin.Cursor = Cursors.Hand
        
        ' btnCancel
        Me.btnCancel.Text = "Cancelar"
        Me.btnCancel.Font = New Font("Segoe UI", 10.0F)
        Me.btnCancel.BackColor = Color.FromArgb(240, 240, 240)
        Me.btnCancel.ForeColor = Color.FromArgb(64, 64, 64)
        Me.btnCancel.FlatStyle = FlatStyle.Flat
        Me.btnCancel.FlatAppearance.BorderColor = Color.FromArgb(200, 200, 200)
        Me.btnCancel.Location = New Point(270, 180)
        Me.btnCancel.Size = New Size(80, 35)
        Me.btnCancel.Cursor = Cursors.Hand
        
        ' Add controls to form
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.btnCancel)
        
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Private WithEvents lblTitle As Label
    Private WithEvents lblUsername As Label
    Private WithEvents txtUsername As TextBox
    Private WithEvents lblPassword As Label
    Private WithEvents txtPassword As TextBox
    Private WithEvents btnLogin As Button
    Private WithEvents btnCancel As Button

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Try
            If String.IsNullOrWhiteSpace(txtUsername.Text) Then
                MessageBox.Show("Por favor ingrese el usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtUsername.Focus()
                Return
            End If

            If String.IsNullOrWhiteSpace(txtPassword.Text) Then
                MessageBox.Show("Por favor ingrese la contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtPassword.Focus()
                Return
            End If

            ' Credenciales de demostración
            If txtUsername.Text.Trim().ToLower() = "admin" AndAlso txtPassword.Text = "password" Then
                Logger.LogInfo($"Login exitoso para usuario: {txtUsername.Text}")
                Me.DialogResult = DialogResult.OK
                Me.Close()
            Else
                MessageBox.Show("Usuario o contraseña incorrectos.", "Error de Autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtPassword.Clear()
                txtUsername.Focus()
            End If
        Catch ex As Exception
            Logger.Log(ex)
            MessageBox.Show("Ocurrió un error durante el login.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub txtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPassword.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            btnLogin_Click(sender, e)
        End If
    End Sub

    Private Sub txtUsername_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUsername.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            txtPassword.Focus()
        End If
    End Sub
End Class
