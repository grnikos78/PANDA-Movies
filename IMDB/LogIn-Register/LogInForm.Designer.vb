﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LogInForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
        Me.components = New System.ComponentModel.Container()
        Me.RememberMe = New System.Windows.Forms.CheckBox()
        Me.UserName = New System.Windows.Forms.TextBox()
        Me.XError = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.LogInPic = New System.Windows.Forms.PictureBox()
        Me.AppInfo = New System.Windows.Forms.Label()
        Me.AppLogo = New System.Windows.Forms.PictureBox()
        Me.UserPanel = New System.Windows.Forms.PictureBox()
        Me.PwsPanel = New System.Windows.Forms.PictureBox()
        Me.Password = New System.Windows.Forms.TextBox()
        Me.LogInButton = New System.Windows.Forms.PictureBox()
        Me.NewUser = New System.Windows.Forms.Label()
        Me.LogInInfo = New System.Windows.Forms.Label()
        Me.MovePanel = New System.Windows.Forms.Panel()
        Me.RegisterBtn = New System.Windows.Forms.LinkLabel()
        Me.ExitBtn = New System.Windows.Forms.PictureBox()
        CType(Me.XError, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LogInPic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AppLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PwsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LogInButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExitBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RememberMe
        '
        Me.RememberMe.Location = New System.Drawing.Point(588, 234)
        Me.RememberMe.Name = "RememberMe"
        Me.RememberMe.Size = New System.Drawing.Size(86, 19)
        Me.RememberMe.TabIndex = 3
        Me.RememberMe.Text = "Remember Me"
        Me.RememberMe.UseVisualStyleBackColor = True
        '
        'UserName
        '
        Me.UserName.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UserName.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.UserName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.UserName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.UserName.ForeColor = System.Drawing.Color.DarkGray
        Me.UserName.Location = New System.Drawing.Point(430, 137)
        Me.UserName.Name = "UserName"
        Me.UserName.Size = New System.Drawing.Size(223, 24)
        Me.UserName.TabIndex = 1
        Me.UserName.Text = "Username"
        Me.UserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'XError
        '
        Me.XError.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.XError.ContainerControl = Me
        '
        'LogInPic
        '
        Me.LogInPic.BackColor = System.Drawing.Color.Transparent
        Me.LogInPic.BackgroundImage = Global.IMDB.My.Resources.Resources.keyhole
        Me.LogInPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.LogInPic.Location = New System.Drawing.Point(496, 20)
        Me.LogInPic.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LogInPic.Name = "LogInPic"
        Me.LogInPic.Size = New System.Drawing.Size(88, 75)
        Me.LogInPic.TabIndex = 16
        Me.LogInPic.TabStop = False
        '
        'AppInfo
        '
        Me.AppInfo.AutoSize = True
        Me.AppInfo.BackColor = System.Drawing.Color.Transparent
        Me.AppInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.AppInfo.ForeColor = System.Drawing.Color.White
        Me.AppInfo.Location = New System.Drawing.Point(12, 225)
        Me.AppInfo.Name = "AppInfo"
        Me.AppInfo.Size = New System.Drawing.Size(300, 50)
        Me.AppInfo.TabIndex = 17
        Me.AppInfo.Text = "Welcome to PANDA movies" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "A project made with love." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'AppLogo
        '
        Me.AppLogo.BackColor = System.Drawing.Color.Transparent
        Me.AppLogo.BackgroundImage = Global.IMDB.My.Resources.Resources.Panda_movies
        Me.AppLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.AppLogo.Location = New System.Drawing.Point(51, 61)
        Me.AppLogo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.AppLogo.Name = "AppLogo"
        Me.AppLogo.Size = New System.Drawing.Size(207, 153)
        Me.AppLogo.TabIndex = 19
        Me.AppLogo.TabStop = False
        '
        'UserPanel
        '
        Me.UserPanel.BackgroundImage = Global.IMDB.My.Resources.Resources.bgtxt
        Me.UserPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.UserPanel.Location = New System.Drawing.Point(406, 129)
        Me.UserPanel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.UserPanel.Name = "UserPanel"
        Me.UserPanel.Size = New System.Drawing.Size(270, 40)
        Me.UserPanel.TabIndex = 20
        Me.UserPanel.TabStop = False
        '
        'PwsPanel
        '
        Me.PwsPanel.BackgroundImage = Global.IMDB.My.Resources.Resources.bgtxt
        Me.PwsPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PwsPanel.Location = New System.Drawing.Point(406, 183)
        Me.PwsPanel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PwsPanel.Name = "PwsPanel"
        Me.PwsPanel.Size = New System.Drawing.Size(270, 40)
        Me.PwsPanel.TabIndex = 21
        Me.PwsPanel.TabStop = False
        '
        'Password
        '
        Me.Password.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Password.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.Password.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Password.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Password.ForeColor = System.Drawing.Color.DarkGray
        Me.Password.Location = New System.Drawing.Point(430, 191)
        Me.Password.Name = "Password"
        Me.Password.Size = New System.Drawing.Size(223, 24)
        Me.Password.TabIndex = 2
        Me.Password.Text = "Password"
        Me.Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LogInButton
        '
        Me.LogInButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.LogInButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LogInButton.Image = Global.IMDB.My.Resources.Resources.btn2
        Me.LogInButton.Location = New System.Drawing.Point(406, 265)
        Me.LogInButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LogInButton.Name = "LogInButton"
        Me.LogInButton.Size = New System.Drawing.Size(270, 58)
        Me.LogInButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.LogInButton.TabIndex = 23
        Me.LogInButton.TabStop = False
        '
        'NewUser
        '
        Me.NewUser.AutoSize = True
        Me.NewUser.BackColor = System.Drawing.Color.Transparent
        Me.NewUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.NewUser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.NewUser.Location = New System.Drawing.Point(437, 350)
        Me.NewUser.Name = "NewUser"
        Me.NewUser.Size = New System.Drawing.Size(91, 18)
        Me.NewUser.TabIndex = 24
        Me.NewUser.Text = "New User?"
        '
        'LogInInfo
        '
        Me.LogInInfo.AutoSize = True
        Me.LogInInfo.BackColor = System.Drawing.Color.Transparent
        Me.LogInInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LogInInfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.LogInInfo.Location = New System.Drawing.Point(430, 100)
        Me.LogInInfo.Name = "LogInInfo"
        Me.LogInInfo.Size = New System.Drawing.Size(223, 20)
        Me.LogInInfo.TabIndex = 18
        Me.LogInInfo.Text = "Login below to get started." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'MovePanel
        '
        Me.MovePanel.BackColor = System.Drawing.Color.Transparent
        Me.MovePanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.MovePanel.Location = New System.Drawing.Point(0, 0)
        Me.MovePanel.Name = "MovePanel"
        Me.MovePanel.Size = New System.Drawing.Size(709, 20)
        Me.MovePanel.TabIndex = 26
        '
        'RegisterBtn
        '
        Me.RegisterBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.RegisterBtn.ForeColor = System.Drawing.Color.Orange
        Me.RegisterBtn.LinkColor = System.Drawing.Color.DarkOrange
        Me.RegisterBtn.Location = New System.Drawing.Point(534, 350)
        Me.RegisterBtn.Name = "RegisterBtn"
        Me.RegisterBtn.Size = New System.Drawing.Size(122, 18)
        Me.RegisterBtn.TabIndex = 27
        Me.RegisterBtn.TabStop = True
        Me.RegisterBtn.Text = "Register Now!"
        '
        'ExitBtn
        '
        Me.ExitBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ExitBtn.Image = Global.IMDB.My.Resources.Resources.Close1
        Me.ExitBtn.Location = New System.Drawing.Point(670, 12)
        Me.ExitBtn.Name = "ExitBtn"
        Me.ExitBtn.Size = New System.Drawing.Size(27, 27)
        Me.ExitBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ExitBtn.TabIndex = 28
        Me.ExitBtn.TabStop = False
        '
        'LogInForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.IMDB.My.Resources.Resources.images
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(709, 390)
        Me.ControlBox = False
        Me.Controls.Add(Me.ExitBtn)
        Me.Controls.Add(Me.RegisterBtn)
        Me.Controls.Add(Me.NewUser)
        Me.Controls.Add(Me.LogInButton)
        Me.Controls.Add(Me.Password)
        Me.Controls.Add(Me.UserName)
        Me.Controls.Add(Me.PwsPanel)
        Me.Controls.Add(Me.UserPanel)
        Me.Controls.Add(Me.AppLogo)
        Me.Controls.Add(Me.LogInInfo)
        Me.Controls.Add(Me.AppInfo)
        Me.Controls.Add(Me.LogInPic)
        Me.Controls.Add(Me.RememberMe)
        Me.Controls.Add(Me.MovePanel)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "LogInForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Log In"
        CType(Me.XError, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LogInPic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AppLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserPanel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PwsPanel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LogInButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExitBtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UserName As TextBox
    Friend WithEvents RememberMe As CheckBox
    Friend WithEvents XError As ErrorProvider
    Friend WithEvents AppInfo As Label
    Friend WithEvents LogInPic As PictureBox
    Friend WithEvents PwsPanel As PictureBox
    Friend WithEvents UserPanel As PictureBox
    Friend WithEvents AppLogo As PictureBox
    Friend WithEvents LogInButton As PictureBox
    Friend WithEvents Password As TextBox
    Friend WithEvents NewUser As Label
    Friend WithEvents LogInInfo As Label
    Friend WithEvents MovePanel As Panel
    Friend WithEvents RegisterBtn As LinkLabel
    Friend WithEvents ExitBtn As PictureBox
End Class
