<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Button_NOD = New System.Windows.Forms.Button()
        Me.Button_run_ccconfig = New System.Windows.Forms.Button()
        Me.Label_status = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label_l_version = New System.Windows.Forms.Label()
        Me.Label_r_version = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.BackgroundWorker_check_ver = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundWorker_load_uplog = New System.ComponentModel.BackgroundWorker()
        Me.TextBox_up_com = New System.Windows.Forms.TextBox()
        Me.TextBox_run_game_com = New System.Windows.Forms.TextBox()
        Me.Button_run_cncnet = New System.Windows.Forms.Button()
        Me.Button_GDI = New System.Windows.Forms.Button()
        Me.Button_new_miss = New System.Windows.Forms.Button()
        Me.Button_updata = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button_NOD
        '
        Me.Button_NOD.Enabled = False
        Me.Button_NOD.Location = New System.Drawing.Point(464, 44)
        Me.Button_NOD.Name = "Button_NOD"
        Me.Button_NOD.Size = New System.Drawing.Size(110, 23)
        Me.Button_NOD.TabIndex = 1
        Me.Button_NOD.Text = "NOD任务"
        Me.Button_NOD.UseVisualStyleBackColor = True
        '
        'Button_run_ccconfig
        '
        Me.Button_run_ccconfig.Enabled = False
        Me.Button_run_ccconfig.Location = New System.Drawing.Point(464, 152)
        Me.Button_run_ccconfig.Name = "Button_run_ccconfig"
        Me.Button_run_ccconfig.Size = New System.Drawing.Size(110, 23)
        Me.Button_run_ccconfig.TabIndex = 3
        Me.Button_run_ccconfig.Text = "更改设置"
        Me.Button_run_ccconfig.UseVisualStyleBackColor = True
        '
        'Label_status
        '
        Me.Label_status.AutoSize = True
        Me.Label_status.ForeColor = System.Drawing.Color.Red
        Me.Label_status.Location = New System.Drawing.Point(12, 261)
        Me.Label_status.Name = "Label_status"
        Me.Label_status.Size = New System.Drawing.Size(29, 12)
        Me.Label_status.TabIndex = 2
        Me.Label_status.Text = "状态"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(340, 260)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 12)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "本地版本："
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(460, 260)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 12)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "远端版本："
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(14, 219)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(444, 23)
        Me.ProgressBar1.TabIndex = 5
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 12)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBox1.Size = New System.Drawing.Size(446, 201)
        Me.TextBox1.TabIndex = 9
        '
        'Label_l_version
        '
        Me.Label_l_version.AutoSize = True
        Me.Label_l_version.Location = New System.Drawing.Point(411, 260)
        Me.Label_l_version.Name = "Label_l_version"
        Me.Label_l_version.Size = New System.Drawing.Size(11, 12)
        Me.Label_l_version.TabIndex = 7
        Me.Label_l_version.Text = "0"
        '
        'Label_r_version
        '
        Me.Label_r_version.AutoSize = True
        Me.Label_r_version.Location = New System.Drawing.Point(531, 260)
        Me.Label_r_version.Name = "Label_r_version"
        Me.Label_r_version.Size = New System.Drawing.Size(11, 12)
        Me.Label_r_version.TabIndex = 8
        Me.Label_r_version.Text = "0"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(332, 280)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(245, 12)
        Me.LinkLabel1.TabIndex = 4
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "意见、建议、问题欢迎发信 57832091@qq.com"
        '
        'BackgroundWorker_check_ver
        '
        '
        'BackgroundWorker_load_uplog
        '
        '
        'TextBox_up_com
        '
        Me.TextBox_up_com.Enabled = False
        Me.TextBox_up_com.Location = New System.Drawing.Point(14, 14)
        Me.TextBox_up_com.Multiline = True
        Me.TextBox_up_com.Name = "TextBox_up_com"
        Me.TextBox_up_com.Size = New System.Drawing.Size(185, 161)
        Me.TextBox_up_com.TabIndex = 14
        Me.TextBox_up_com.Text = "@echo off" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "echo 正在更新..." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "timeout 2 >nul" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "up_data.exe" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "timeout 2 > nul" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "del up_dat" &
    "a.exe" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "echo 更新完成" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "timeout 1 > nul" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "start 命令与征服纪念版.exe"
        Me.TextBox_up_com.Visible = False
        '
        'TextBox_run_game_com
        '
        Me.TextBox_run_game_com.Enabled = False
        Me.TextBox_run_game_com.Location = New System.Drawing.Point(205, 14)
        Me.TextBox_run_game_com.Multiline = True
        Me.TextBox_run_game_com.Name = "TextBox_run_game_com"
        Me.TextBox_run_game_com.Size = New System.Drawing.Size(196, 102)
        Me.TextBox_run_game_com.TabIndex = 15
        Me.TextBox_run_game_com.Text = "start C""&""C95.exe"
        Me.TextBox_run_game_com.Visible = False
        '
        'Button_run_cncnet
        '
        Me.Button_run_cncnet.Enabled = False
        Me.Button_run_cncnet.Location = New System.Drawing.Point(464, 104)
        Me.Button_run_cncnet.Name = "Button_run_cncnet"
        Me.Button_run_cncnet.Size = New System.Drawing.Size(110, 23)
        Me.Button_run_cncnet.TabIndex = 2
        Me.Button_run_cncnet.Text = "多人游戏"
        Me.Button_run_cncnet.UseVisualStyleBackColor = True
        '
        'Button_GDI
        '
        Me.Button_GDI.Enabled = False
        Me.Button_GDI.Location = New System.Drawing.Point(464, 14)
        Me.Button_GDI.Name = "Button_GDI"
        Me.Button_GDI.Size = New System.Drawing.Size(110, 23)
        Me.Button_GDI.TabIndex = 16
        Me.Button_GDI.Text = "GDI任务"
        Me.Button_GDI.UseVisualStyleBackColor = True
        '
        'Button_new_miss
        '
        Me.Button_new_miss.Enabled = False
        Me.Button_new_miss.Location = New System.Drawing.Point(464, 74)
        Me.Button_new_miss.Name = "Button_new_miss"
        Me.Button_new_miss.Size = New System.Drawing.Size(110, 23)
        Me.Button_new_miss.TabIndex = 17
        Me.Button_new_miss.Text = "资料片及主机任务"
        Me.Button_new_miss.UseVisualStyleBackColor = True
        '
        'Button_updata
        '
        Me.Button_updata.Enabled = False
        Me.Button_updata.Location = New System.Drawing.Point(462, 219)
        Me.Button_updata.Name = "Button_updata"
        Me.Button_updata.Size = New System.Drawing.Size(110, 23)
        Me.Button_updata.TabIndex = 18
        Me.Button_updata.Text = "强制更新修复"
        Me.Button_updata.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(586, 305)
        Me.Controls.Add(Me.Button_updata)
        Me.Controls.Add(Me.Button_new_miss)
        Me.Controls.Add(Me.Button_GDI)
        Me.Controls.Add(Me.Button_run_cncnet)
        Me.Controls.Add(Me.TextBox_run_game_com)
        Me.Controls.Add(Me.TextBox_up_com)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label_r_version)
        Me.Controls.Add(Me.Label_l_version)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label_status)
        Me.Controls.Add(Me.Button_run_ccconfig)
        Me.Controls.Add(Me.Button_NOD)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "命令与征服 纪念版"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button_NOD As Button
    Friend WithEvents Button_run_ccconfig As Button
    Friend WithEvents Label_status As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label_l_version As Label
    Friend WithEvents Label_r_version As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents BackgroundWorker_check_ver As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundWorker_load_uplog As System.ComponentModel.BackgroundWorker
    Friend WithEvents TextBox_up_com As TextBox
    Friend WithEvents TextBox_run_game_com As TextBox
    Friend WithEvents Button_run_cncnet As Button
    Friend WithEvents Button_GDI As Button
    Friend WithEvents Button_new_miss As Button
    Friend WithEvents Button_updata As Button
End Class
