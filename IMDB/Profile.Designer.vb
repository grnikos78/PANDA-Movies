﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Profile
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ProfilePL = New System.Windows.Forms.Label()
        Me.UploadB = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Na = New System.Windows.Forms.Label()
        Me.Su = New System.Windows.Forms.Label()
        Me.EL = New System.Windows.Forms.Label()
        Me.PasswordL = New System.Windows.Forms.Label()
        Me.EditB = New System.Windows.Forms.Button()
        Me.NameL = New System.Windows.Forms.Label()
        Me.Surname = New System.Windows.Forms.Label()
        Me.Email = New System.Windows.Forms.Label()
        Me.Password = New System.Windows.Forms.Label()
        Me.UpdateB = New System.Windows.Forms.Button()
        Me.NameTB = New System.Windows.Forms.TextBox()
        Me.SurnameTB = New System.Windows.Forms.TextBox()
        Me.EmailTB = New System.Windows.Forms.TextBox()
        Me.NewPasswordTB = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProfilePL
        '
        Me.ProfilePL.AutoSize = True
        Me.ProfilePL.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ProfilePL.Location = New System.Drawing.Point(202, 147)
        Me.ProfilePL.Name = "ProfilePL"
        Me.ProfilePL.Size = New System.Drawing.Size(143, 25)
        Me.ProfilePL.TabIndex = 1
        Me.ProfilePL.Text = "Profile Picture :"
        '
        'UploadB
        '
        Me.UploadB.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.UploadB.Location = New System.Drawing.Point(399, 149)
        Me.UploadB.Name = "UploadB"
        Me.UploadB.Size = New System.Drawing.Size(74, 23)
        Me.UploadB.TabIndex = 2
        Me.UploadB.Text = "Upload"
        Me.UploadB.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(38, 112)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 99)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Na
        '
        Me.Na.AutoSize = True
        Me.Na.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Na.Location = New System.Drawing.Point(202, 269)
        Me.Na.Name = "Na"
        Me.Na.Size = New System.Drawing.Size(72, 25)
        Me.Na.TabIndex = 4
        Me.Na.Text = "Name :"
        '
        'Su
        '
        Me.Su.AutoSize = True
        Me.Su.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Su.Location = New System.Drawing.Point(202, 326)
        Me.Su.Name = "Su"
        Me.Su.Size = New System.Drawing.Size(97, 25)
        Me.Su.TabIndex = 5
        Me.Su.Text = "Surname :"
        '
        'EL
        '
        Me.EL.AutoSize = True
        Me.EL.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.EL.Location = New System.Drawing.Point(202, 386)
        Me.EL.Name = "EL"
        Me.EL.Size = New System.Drawing.Size(75, 25)
        Me.EL.TabIndex = 6
        Me.EL.Text = "E-mail :"
        '
        'PasswordL
        '
        Me.PasswordL.AutoSize = True
        Me.PasswordL.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.PasswordL.Location = New System.Drawing.Point(202, 443)
        Me.PasswordL.Name = "PasswordL"
        Me.PasswordL.Size = New System.Drawing.Size(145, 25)
        Me.PasswordL.TabIndex = 7
        Me.PasswordL.Text = "New Password :"
        '
        'EditB
        '
        Me.EditB.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.EditB.Location = New System.Drawing.Point(202, 516)
        Me.EditB.Name = "EditB"
        Me.EditB.Size = New System.Drawing.Size(75, 23)
        Me.EditB.TabIndex = 8
        Me.EditB.Text = "Edit"
        Me.EditB.UseVisualStyleBackColor = True
        '
        'NameL
        '
        Me.NameL.AutoSize = True
        Me.NameL.Location = New System.Drawing.Point(399, 275)
        Me.NameL.Name = "NameL"
        Me.NameL.Size = New System.Drawing.Size(41, 15)
        Me.NameL.TabIndex = 9
        Me.NameL.Text = "Label1"
        '
        'Surname
        '
        Me.Surname.AutoSize = True
        Me.Surname.Location = New System.Drawing.Point(399, 336)
        Me.Surname.Name = "Surname"
        Me.Surname.Size = New System.Drawing.Size(41, 15)
        Me.Surname.TabIndex = 10
        Me.Surname.Text = "Label2"
        '
        'Email
        '
        Me.Email.AutoSize = True
        Me.Email.Location = New System.Drawing.Point(399, 392)
        Me.Email.Name = "Email"
        Me.Email.Size = New System.Drawing.Size(41, 15)
        Me.Email.TabIndex = 11
        Me.Email.Text = "Label3"
        '
        'Password
        '
        Me.Password.AutoSize = True
        Me.Password.Location = New System.Drawing.Point(399, 453)
        Me.Password.Name = "Password"
        Me.Password.Size = New System.Drawing.Size(41, 15)
        Me.Password.TabIndex = 12
        Me.Password.Text = "Label4"
        '
        'UpdateB
        '
        Me.UpdateB.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.UpdateB.Location = New System.Drawing.Point(365, 516)
        Me.UpdateB.Name = "UpdateB"
        Me.UpdateB.Size = New System.Drawing.Size(75, 23)
        Me.UpdateB.TabIndex = 13
        Me.UpdateB.Text = "Update"
        Me.UpdateB.UseVisualStyleBackColor = True
        Me.UpdateB.Visible = False
        '
        'NameTB
        '
        Me.NameTB.Location = New System.Drawing.Point(381, 272)
        Me.NameTB.Name = "NameTB"
        Me.NameTB.Size = New System.Drawing.Size(100, 23)
        Me.NameTB.TabIndex = 14
        Me.NameTB.Visible = False
        '
        'SurnameTB
        '
        Me.SurnameTB.Location = New System.Drawing.Point(381, 329)
        Me.SurnameTB.Name = "SurnameTB"
        Me.SurnameTB.Size = New System.Drawing.Size(100, 23)
        Me.SurnameTB.TabIndex = 15
        Me.SurnameTB.Visible = False
        '
        'EmailTB
        '
        Me.EmailTB.Location = New System.Drawing.Point(381, 389)
        Me.EmailTB.Name = "EmailTB"
        Me.EmailTB.Size = New System.Drawing.Size(100, 23)
        Me.EmailTB.TabIndex = 16
        Me.EmailTB.Visible = False
        '
        'NewPasswordTB
        '
        Me.NewPasswordTB.Location = New System.Drawing.Point(381, 446)
        Me.NewPasswordTB.Name = "NewPasswordTB"
        Me.NewPasswordTB.Size = New System.Drawing.Size(100, 23)
        Me.NewPasswordTB.TabIndex = 17
        Me.NewPasswordTB.Visible = False
        '
        'Profile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(600, 702)
        Me.Controls.Add(Me.NewPasswordTB)
        Me.Controls.Add(Me.EmailTB)
        Me.Controls.Add(Me.SurnameTB)
        Me.Controls.Add(Me.NameTB)
        Me.Controls.Add(Me.UpdateB)
        Me.Controls.Add(Me.Password)
        Me.Controls.Add(Me.Email)
        Me.Controls.Add(Me.Surname)
        Me.Controls.Add(Me.NameL)
        Me.Controls.Add(Me.EditB)
        Me.Controls.Add(Me.PasswordL)
        Me.Controls.Add(Me.EL)
        Me.Controls.Add(Me.Su)
        Me.Controls.Add(Me.Na)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.UploadB)
        Me.Controls.Add(Me.ProfilePL)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Profile"
        Me.Text = "Profile"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ProfilePL As Label
    Friend WithEvents UploadB As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Na As Label
    Friend WithEvents Su As Label
    Friend WithEvents EL As Label
    Friend WithEvents PasswordL As Label
    Friend WithEvents EditB As Button
    Friend WithEvents NameL As Label
    Friend WithEvents Surname As Label
    Friend WithEvents Email As Label
    Friend WithEvents Password As Label
    Friend WithEvents UpdateB As Button
    Friend WithEvents NameTB As TextBox
    Friend WithEvents SurnameTB As TextBox
    Friend WithEvents EmailTB As TextBox
    Friend WithEvents NewPasswordTB As TextBox
End Class
