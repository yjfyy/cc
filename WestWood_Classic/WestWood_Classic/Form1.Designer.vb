<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TextBox_up_com = New System.Windows.Forms.TextBox()
        Me.RadioButton_winxp = New System.Windows.Forms.RadioButton()
        Me.RadioButton_win7 = New System.Windows.Forms.RadioButton()
        Me.RadioButton_win10 = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BackgroundWorker_load_up_log = New System.ComponentModel.BackgroundWorker()
        Me.Button_test = New System.Windows.Forms.Button()
        Me.TextBox_up_com_as_movies = New System.Windows.Forms.TextBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label_r_version = New System.Windows.Forms.Label()
        Me.Label_l_version = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label_status = New System.Windows.Forms.Label()
        Me.CheckBox_updata_movies = New System.Windows.Forms.CheckBox()
        Me.BackgroundWorker_check_ver = New System.ComponentModel.BackgroundWorker()
        Me.TextBox_up_log = New System.Windows.Forms.TextBox()
        Me.Button_updata = New System.Windows.Forms.Button()
        Me.Panel_games_list = New System.Windows.Forms.Panel()
        Me.Label_ra1 = New System.Windows.Forms.Label()
        Me.Label_cnc1 = New System.Windows.Forms.Label()
        Me.Button_cnc1 = New System.Windows.Forms.Button()
        Me.Button_ra1 = New System.Windows.Forms.Button()
        Me.Panel_up_log = New System.Windows.Forms.Panel()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Panel_cnc1 = New System.Windows.Forms.Panel()
        Me.Button_cnc1_config = New System.Windows.Forms.Button()
        Me.Button_cnc1_english = New System.Windows.Forms.Button()
        Me.Button_cnc1_cncnet = New System.Windows.Forms.Button()
        Me.Button_cnc1_tv = New System.Windows.Forms.Button()
        Me.Button_cnc1_ext = New System.Windows.Forms.Button()
        Me.Button_cnc1_NOD_miss = New System.Windows.Forms.Button()
        Me.Button_cnc1_GDI_miss = New System.Windows.Forms.Button()
        Me.Panel_ra1 = New System.Windows.Forms.Panel()
        Me.Button_cncnet = New System.Windows.Forms.Button()
        Me.Button_ra1_config = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.Panel_games_list.SuspendLayout()
        Me.Panel_up_log.SuspendLayout()
        Me.Panel_cnc1.SuspendLayout()
        Me.Panel_ra1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox_up_com
        '
        Me.TextBox_up_com.Enabled = False
        Me.TextBox_up_com.Location = New System.Drawing.Point(11, 234)
        Me.TextBox_up_com.Multiline = True
        Me.TextBox_up_com.Name = "TextBox_up_com"
        Me.TextBox_up_com.Size = New System.Drawing.Size(216, 127)
        Me.TextBox_up_com.TabIndex = 21
        Me.TextBox_up_com.Text = "@echo off" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "echo 正在更新..." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "timeout 2 >nul" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "up_data.exe" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "timeout 2 > nul" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "del up_dat" &
    "a.exe" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "echo 更新完成" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "timeout 1 > nul" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "start 西木经典游戏汉化纪念版.exe"
        Me.TextBox_up_com.Visible = False
        '
        'RadioButton_winxp
        '
        Me.RadioButton_winxp.AutoSize = True
        Me.RadioButton_winxp.Location = New System.Drawing.Point(6, 57)
        Me.RadioButton_winxp.Name = "RadioButton_winxp"
        Me.RadioButton_winxp.Size = New System.Drawing.Size(35, 16)
        Me.RadioButton_winxp.TabIndex = 26
        Me.RadioButton_winxp.TabStop = True
        Me.RadioButton_winxp.Text = "XP"
        Me.RadioButton_winxp.UseVisualStyleBackColor = True
        '
        'RadioButton_win7
        '
        Me.RadioButton_win7.AutoSize = True
        Me.RadioButton_win7.Location = New System.Drawing.Point(6, 13)
        Me.RadioButton_win7.Name = "RadioButton_win7"
        Me.RadioButton_win7.Size = New System.Drawing.Size(47, 16)
        Me.RadioButton_win7.TabIndex = 24
        Me.RadioButton_win7.TabStop = True
        Me.RadioButton_win7.Text = "Win7"
        Me.RadioButton_win7.UseVisualStyleBackColor = True
        '
        'RadioButton_win10
        '
        Me.RadioButton_win10.AutoSize = True
        Me.RadioButton_win10.Location = New System.Drawing.Point(6, 35)
        Me.RadioButton_win10.Name = "RadioButton_win10"
        Me.RadioButton_win10.Size = New System.Drawing.Size(53, 16)
        Me.RadioButton_win10.TabIndex = 25
        Me.RadioButton_win10.TabStop = True
        Me.RadioButton_win10.Text = "Win10"
        Me.RadioButton_win10.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton_winxp)
        Me.GroupBox1.Controls.Add(Me.RadioButton_win7)
        Me.GroupBox1.Controls.Add(Me.RadioButton_win10)
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.Location = New System.Drawing.Point(10, 334)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(133, 79)
        Me.GroupBox1.TabIndex = 41
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "操作系统"
        '
        'BackgroundWorker_load_up_log
        '
        '
        'Button_test
        '
        Me.Button_test.Location = New System.Drawing.Point(478, 294)
        Me.Button_test.Name = "Button_test"
        Me.Button_test.Size = New System.Drawing.Size(75, 23)
        Me.Button_test.TabIndex = 24
        Me.Button_test.Text = "测试功能"
        Me.Button_test.UseVisualStyleBackColor = True
        Me.Button_test.Visible = False
        '
        'TextBox_up_com_as_movies
        '
        Me.TextBox_up_com_as_movies.Enabled = False
        Me.TextBox_up_com_as_movies.Location = New System.Drawing.Point(11, 12)
        Me.TextBox_up_com_as_movies.Multiline = True
        Me.TextBox_up_com_as_movies.Name = "TextBox_up_com_as_movies"
        Me.TextBox_up_com_as_movies.Size = New System.Drawing.Size(485, 216)
        Me.TextBox_up_com_as_movies.TabIndex = 23
        Me.TextBox_up_com_as_movies.Text = resources.GetString("TextBox_up_com_as_movies.Text")
        Me.TextBox_up_com_as_movies.Visible = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(542, 473)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(245, 12)
        Me.LinkLabel1.TabIndex = 37
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "意见、建议、问题欢迎发信 57832091@qq.com"
        '
        'Label_r_version
        '
        Me.Label_r_version.AutoSize = True
        Me.Label_r_version.Location = New System.Drawing.Point(391, 473)
        Me.Label_r_version.Name = "Label_r_version"
        Me.Label_r_version.Size = New System.Drawing.Size(11, 12)
        Me.Label_r_version.TabIndex = 40
        Me.Label_r_version.Text = "0"
        '
        'Label_l_version
        '
        Me.Label_l_version.AutoSize = True
        Me.Label_l_version.Location = New System.Drawing.Point(229, 473)
        Me.Label_l_version.Name = "Label_l_version"
        Me.Label_l_version.Size = New System.Drawing.Size(11, 12)
        Me.Label_l_version.TabIndex = 39
        Me.Label_l_version.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(320, 473)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 12)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "远端版本："
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(158, 473)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 12)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "本地版本："
        '
        'Label_status
        '
        Me.Label_status.AutoSize = True
        Me.Label_status.ForeColor = System.Drawing.Color.Red
        Me.Label_status.Location = New System.Drawing.Point(8, 473)
        Me.Label_status.Name = "Label_status"
        Me.Label_status.Size = New System.Drawing.Size(29, 12)
        Me.Label_status.TabIndex = 35
        Me.Label_status.Text = "状态"
        '
        'CheckBox_updata_movies
        '
        Me.CheckBox_updata_movies.AutoSize = True
        Me.CheckBox_updata_movies.Location = New System.Drawing.Point(108, 433)
        Me.CheckBox_updata_movies.Name = "CheckBox_updata_movies"
        Me.CheckBox_updata_movies.Size = New System.Drawing.Size(72, 16)
        Me.CheckBox_updata_movies.TabIndex = 34
        Me.CheckBox_updata_movies.Text = "更新动画"
        Me.CheckBox_updata_movies.UseVisualStyleBackColor = True
        '
        'BackgroundWorker_check_ver
        '
        '
        'TextBox_up_log
        '
        Me.TextBox_up_log.Location = New System.Drawing.Point(0, 0)
        Me.TextBox_up_log.Multiline = True
        Me.TextBox_up_log.Name = "TextBox_up_log"
        Me.TextBox_up_log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox_up_log.Size = New System.Drawing.Size(629, 402)
        Me.TextBox_up_log.TabIndex = 0
        '
        'Button_updata
        '
        Me.Button_updata.Location = New System.Drawing.Point(10, 429)
        Me.Button_updata.Name = "Button_updata"
        Me.Button_updata.Size = New System.Drawing.Size(92, 23)
        Me.Button_updata.TabIndex = 33
        Me.Button_updata.Text = "强制更新修复"
        Me.Button_updata.UseVisualStyleBackColor = True
        '
        'Panel_games_list
        '
        Me.Panel_games_list.Controls.Add(Me.Label_ra1)
        Me.Panel_games_list.Controls.Add(Me.Label_cnc1)
        Me.Panel_games_list.Controls.Add(Me.Button_cnc1)
        Me.Panel_games_list.Controls.Add(Me.Button_ra1)
        Me.Panel_games_list.Location = New System.Drawing.Point(10, 11)
        Me.Panel_games_list.Name = "Panel_games_list"
        Me.Panel_games_list.Size = New System.Drawing.Size(133, 317)
        Me.Panel_games_list.TabIndex = 29
        '
        'Label_ra1
        '
        Me.Label_ra1.AutoSize = True
        Me.Label_ra1.Enabled = False
        Me.Label_ra1.Location = New System.Drawing.Point(36, 182)
        Me.Label_ra1.Name = "Label_ra1"
        Me.Label_ra1.Size = New System.Drawing.Size(53, 12)
        Me.Label_ra1.TabIndex = 3
        Me.Label_ra1.Text = "红色警戒"
        '
        'Label_cnc1
        '
        Me.Label_cnc1.AutoSize = True
        Me.Label_cnc1.Enabled = False
        Me.Label_cnc1.Location = New System.Drawing.Point(32, 87)
        Me.Label_cnc1.Name = "Label_cnc1"
        Me.Label_cnc1.Size = New System.Drawing.Size(65, 12)
        Me.Label_cnc1.TabIndex = 2
        Me.Label_cnc1.Text = "命令与征服"
        '
        'Button_cnc1
        '
        Me.Button_cnc1.BackgroundImage = Global.WestWood_Classic.My.Resources.Resources._1
        Me.Button_cnc1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button_cnc1.Enabled = False
        Me.Button_cnc1.Location = New System.Drawing.Point(34, 28)
        Me.Button_cnc1.Name = "Button_cnc1"
        Me.Button_cnc1.Size = New System.Drawing.Size(58, 56)
        Me.Button_cnc1.TabIndex = 0
        Me.Button_cnc1.UseVisualStyleBackColor = True
        '
        'Button_ra1
        '
        Me.Button_ra1.BackgroundImage = Global.WestWood_Classic.My.Resources.Resources._93
        Me.Button_ra1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button_ra1.Enabled = False
        Me.Button_ra1.Location = New System.Drawing.Point(34, 125)
        Me.Button_ra1.Name = "Button_ra1"
        Me.Button_ra1.Size = New System.Drawing.Size(58, 54)
        Me.Button_ra1.TabIndex = 1
        Me.Button_ra1.UseVisualStyleBackColor = True
        '
        'Panel_up_log
        '
        Me.Panel_up_log.Controls.Add(Me.Button_test)
        Me.Panel_up_log.Controls.Add(Me.TextBox_up_com_as_movies)
        Me.Panel_up_log.Controls.Add(Me.TextBox_up_com)
        Me.Panel_up_log.Controls.Add(Me.TextBox_up_log)
        Me.Panel_up_log.Location = New System.Drawing.Point(149, 11)
        Me.Panel_up_log.Name = "Panel_up_log"
        Me.Panel_up_log.Size = New System.Drawing.Size(640, 402)
        Me.Panel_up_log.TabIndex = 42
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(186, 429)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(601, 23)
        Me.ProgressBar1.TabIndex = 32
        '
        'Panel_cnc1
        '
        Me.Panel_cnc1.BackgroundImage = Global.WestWood_Classic.My.Resources.Resources.htitle
        Me.Panel_cnc1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel_cnc1.Controls.Add(Me.Button_cnc1_config)
        Me.Panel_cnc1.Controls.Add(Me.Button_cnc1_english)
        Me.Panel_cnc1.Controls.Add(Me.Button_cnc1_cncnet)
        Me.Panel_cnc1.Controls.Add(Me.Button_cnc1_tv)
        Me.Panel_cnc1.Controls.Add(Me.Button_cnc1_ext)
        Me.Panel_cnc1.Controls.Add(Me.Button_cnc1_NOD_miss)
        Me.Panel_cnc1.Controls.Add(Me.Button_cnc1_GDI_miss)
        Me.Panel_cnc1.Location = New System.Drawing.Point(149, 11)
        Me.Panel_cnc1.Name = "Panel_cnc1"
        Me.Panel_cnc1.Size = New System.Drawing.Size(643, 402)
        Me.Panel_cnc1.TabIndex = 30
        '
        'Button_cnc1_config
        '
        Me.Button_cnc1_config.BackColor = System.Drawing.Color.Transparent
        Me.Button_cnc1_config.BackgroundImage = CType(resources.GetObject("Button_cnc1_config.BackgroundImage"), System.Drawing.Image)
        Me.Button_cnc1_config.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button_cnc1_config.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button_cnc1_config.ForeColor = System.Drawing.Color.LimeGreen
        Me.Button_cnc1_config.Location = New System.Drawing.Point(244, 206)
        Me.Button_cnc1_config.Name = "Button_cnc1_config"
        Me.Button_cnc1_config.Size = New System.Drawing.Size(160, 21)
        Me.Button_cnc1_config.TabIndex = 6
        Me.Button_cnc1_config.Text = "设置"
        Me.Button_cnc1_config.UseVisualStyleBackColor = False
        '
        'Button_cnc1_english
        '
        Me.Button_cnc1_english.BackColor = System.Drawing.Color.Transparent
        Me.Button_cnc1_english.BackgroundImage = CType(resources.GetObject("Button_cnc1_english.BackgroundImage"), System.Drawing.Image)
        Me.Button_cnc1_english.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button_cnc1_english.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button_cnc1_english.ForeColor = System.Drawing.Color.LimeGreen
        Me.Button_cnc1_english.Location = New System.Drawing.Point(244, 177)
        Me.Button_cnc1_english.Name = "Button_cnc1_english"
        Me.Button_cnc1_english.Size = New System.Drawing.Size(160, 21)
        Me.Button_cnc1_english.TabIndex = 5
        Me.Button_cnc1_english.Text = "英文版"
        Me.Button_cnc1_english.UseVisualStyleBackColor = False
        '
        'Button_cnc1_cncnet
        '
        Me.Button_cnc1_cncnet.BackColor = System.Drawing.Color.Transparent
        Me.Button_cnc1_cncnet.BackgroundImage = CType(resources.GetObject("Button_cnc1_cncnet.BackgroundImage"), System.Drawing.Image)
        Me.Button_cnc1_cncnet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button_cnc1_cncnet.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button_cnc1_cncnet.ForeColor = System.Drawing.Color.LimeGreen
        Me.Button_cnc1_cncnet.Location = New System.Drawing.Point(244, 148)
        Me.Button_cnc1_cncnet.Name = "Button_cnc1_cncnet"
        Me.Button_cnc1_cncnet.Size = New System.Drawing.Size(160, 21)
        Me.Button_cnc1_cncnet.TabIndex = 4
        Me.Button_cnc1_cncnet.Text = "CnCNet联机"
        Me.Button_cnc1_cncnet.UseVisualStyleBackColor = False
        '
        'Button_cnc1_tv
        '
        Me.Button_cnc1_tv.BackColor = System.Drawing.Color.Transparent
        Me.Button_cnc1_tv.BackgroundImage = CType(resources.GetObject("Button_cnc1_tv.BackgroundImage"), System.Drawing.Image)
        Me.Button_cnc1_tv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button_cnc1_tv.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button_cnc1_tv.ForeColor = System.Drawing.Color.LimeGreen
        Me.Button_cnc1_tv.Location = New System.Drawing.Point(244, 119)
        Me.Button_cnc1_tv.Name = "Button_cnc1_tv"
        Me.Button_cnc1_tv.Size = New System.Drawing.Size(160, 21)
        Me.Button_cnc1_tv.TabIndex = 3
        Me.Button_cnc1_tv.Text = "游戏主机独占任务"
        Me.Button_cnc1_tv.UseVisualStyleBackColor = False
        '
        'Button_cnc1_ext
        '
        Me.Button_cnc1_ext.BackColor = System.Drawing.Color.Transparent
        Me.Button_cnc1_ext.BackgroundImage = CType(resources.GetObject("Button_cnc1_ext.BackgroundImage"), System.Drawing.Image)
        Me.Button_cnc1_ext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button_cnc1_ext.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button_cnc1_ext.ForeColor = System.Drawing.Color.LimeGreen
        Me.Button_cnc1_ext.Location = New System.Drawing.Point(244, 90)
        Me.Button_cnc1_ext.Name = "Button_cnc1_ext"
        Me.Button_cnc1_ext.Size = New System.Drawing.Size(160, 21)
        Me.Button_cnc1_ext.TabIndex = 2
        Me.Button_cnc1_ext.Text = "隐秘行动资料片"
        Me.Button_cnc1_ext.UseVisualStyleBackColor = False
        '
        'Button_cnc1_NOD_miss
        '
        Me.Button_cnc1_NOD_miss.BackColor = System.Drawing.Color.Transparent
        Me.Button_cnc1_NOD_miss.BackgroundImage = CType(resources.GetObject("Button_cnc1_NOD_miss.BackgroundImage"), System.Drawing.Image)
        Me.Button_cnc1_NOD_miss.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button_cnc1_NOD_miss.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button_cnc1_NOD_miss.ForeColor = System.Drawing.Color.LimeGreen
        Me.Button_cnc1_NOD_miss.Location = New System.Drawing.Point(244, 61)
        Me.Button_cnc1_NOD_miss.Name = "Button_cnc1_NOD_miss"
        Me.Button_cnc1_NOD_miss.Size = New System.Drawing.Size(160, 21)
        Me.Button_cnc1_NOD_miss.TabIndex = 1
        Me.Button_cnc1_NOD_miss.Text = "诺德兄弟会任务(NOD)"
        Me.Button_cnc1_NOD_miss.UseVisualStyleBackColor = False
        '
        'Button_cnc1_GDI_miss
        '
        Me.Button_cnc1_GDI_miss.BackColor = System.Drawing.Color.Transparent
        Me.Button_cnc1_GDI_miss.BackgroundImage = CType(resources.GetObject("Button_cnc1_GDI_miss.BackgroundImage"), System.Drawing.Image)
        Me.Button_cnc1_GDI_miss.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button_cnc1_GDI_miss.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button_cnc1_GDI_miss.ForeColor = System.Drawing.Color.LimeGreen
        Me.Button_cnc1_GDI_miss.Location = New System.Drawing.Point(244, 32)
        Me.Button_cnc1_GDI_miss.Name = "Button_cnc1_GDI_miss"
        Me.Button_cnc1_GDI_miss.Size = New System.Drawing.Size(160, 21)
        Me.Button_cnc1_GDI_miss.TabIndex = 0
        Me.Button_cnc1_GDI_miss.Text = "全球防御组织任务(GDI)"
        Me.Button_cnc1_GDI_miss.UseVisualStyleBackColor = False
        '
        'Panel_ra1
        '
        Me.Panel_ra1.BackgroundImage = Global.WestWood_Classic.My.Resources.Resources.title
        Me.Panel_ra1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel_ra1.Controls.Add(Me.Button_cncnet)
        Me.Panel_ra1.Controls.Add(Me.Button_ra1_config)
        Me.Panel_ra1.Controls.Add(Me.Button8)
        Me.Panel_ra1.Location = New System.Drawing.Point(149, 11)
        Me.Panel_ra1.Name = "Panel_ra1"
        Me.Panel_ra1.Size = New System.Drawing.Size(640, 402)
        Me.Panel_ra1.TabIndex = 31
        '
        'Button_cncnet
        '
        Me.Button_cncnet.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button_cncnet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button_cncnet.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button_cncnet.FlatAppearance.BorderSize = 20
        Me.Button_cncnet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button_cncnet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy
        Me.Button_cncnet.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button_cncnet.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button_cncnet.Location = New System.Drawing.Point(244, 192)
        Me.Button_cncnet.Name = "Button_cncnet"
        Me.Button_cncnet.Size = New System.Drawing.Size(160, 21)
        Me.Button_cncnet.TabIndex = 2
        Me.Button_cncnet.Text = "CnCNet联机"
        Me.Button_cncnet.UseVisualStyleBackColor = False
        '
        'Button_ra1_config
        '
        Me.Button_ra1_config.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button_ra1_config.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button_ra1_config.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button_ra1_config.FlatAppearance.BorderSize = 20
        Me.Button_ra1_config.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button_ra1_config.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy
        Me.Button_ra1_config.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button_ra1_config.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button_ra1_config.Location = New System.Drawing.Point(244, 272)
        Me.Button_ra1_config.Name = "Button_ra1_config"
        Me.Button_ra1_config.Size = New System.Drawing.Size(160, 21)
        Me.Button_ra1_config.TabIndex = 1
        Me.Button_ra1_config.Text = "设置"
        Me.Button_ra1_config.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button8.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button8.FlatAppearance.BorderSize = 20
        Me.Button8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button8.Location = New System.Drawing.Point(244, 165)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(160, 21)
        Me.Button8.TabIndex = 0
        Me.Button8.Text = "中文版"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(801, 496)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label_r_version)
        Me.Controls.Add(Me.Label_l_version)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label_status)
        Me.Controls.Add(Me.CheckBox_updata_movies)
        Me.Controls.Add(Me.Button_updata)
        Me.Controls.Add(Me.Panel_games_list)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Panel_up_log)
        Me.Controls.Add(Me.Panel_ra1)
        Me.Controls.Add(Me.Panel_cnc1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "西木经典游戏汉化纪念版"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel_games_list.ResumeLayout(False)
        Me.Panel_games_list.PerformLayout()
        Me.Panel_up_log.ResumeLayout(False)
        Me.Panel_up_log.PerformLayout()
        Me.Panel_cnc1.ResumeLayout(False)
        Me.Panel_ra1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox_up_com As TextBox
    Friend WithEvents RadioButton_winxp As RadioButton
    Friend WithEvents RadioButton_win7 As RadioButton
    Friend WithEvents RadioButton_win10 As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BackgroundWorker_load_up_log As System.ComponentModel.BackgroundWorker
    Friend WithEvents Button_test As Button
    Friend WithEvents TextBox_up_com_as_movies As TextBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label_r_version As Label
    Friend WithEvents Label_l_version As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label_status As Label
    Friend WithEvents CheckBox_updata_movies As CheckBox
    Friend WithEvents BackgroundWorker_check_ver As System.ComponentModel.BackgroundWorker
    Friend WithEvents TextBox_up_log As TextBox
    Friend WithEvents Button_updata As Button
    Friend WithEvents Panel_games_list As Panel
    Friend WithEvents Label_ra1 As Label
    Friend WithEvents Label_cnc1 As Label
    Friend WithEvents Button_cnc1 As Button
    Friend WithEvents Button_ra1 As Button
    Friend WithEvents Panel_up_log As Panel
    Friend WithEvents Panel_ra1 As Panel
    Friend WithEvents Button_ra1_config As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Panel_cnc1 As Panel
    Friend WithEvents Button_cnc1_config As Button
    Friend WithEvents Button_cnc1_english As Button
    Friend WithEvents Button_cnc1_cncnet As Button
    Friend WithEvents Button_cnc1_tv As Button
    Friend WithEvents Button_cnc1_ext As Button
    Friend WithEvents Button_cnc1_NOD_miss As Button
    Friend WithEvents Button_cnc1_GDI_miss As Button
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Button_cncnet As Button
End Class
