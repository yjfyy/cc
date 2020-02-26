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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.RadioButton_winxp = New System.Windows.Forms.RadioButton()
        Me.RadioButton_win7 = New System.Windows.Forms.RadioButton()
        Me.RadioButton_win10 = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label_r_version = New System.Windows.Forms.Label()
        Me.Label_l_version = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label_status = New System.Windows.Forms.Label()
        Me.BackgroundWorker_check_ver = New System.ComponentModel.BackgroundWorker()
        Me.Button_updata = New System.Windows.Forms.Button()
        Me.Panel_games_list = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button_back = New System.Windows.Forms.Button()
        Me.Label_ra1 = New System.Windows.Forms.Label()
        Me.Label_cnc1 = New System.Windows.Forms.Label()
        Me.Button_cnc1 = New System.Windows.Forms.Button()
        Me.Button_ra1 = New System.Windows.Forms.Button()
        Me.Panel_up_log = New System.Windows.Forms.Panel()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
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
        Me.Button_ra1_ext_af_su = New System.Windows.Forms.Button()
        Me.Button_ra1_ext_af = New System.Windows.Forms.Button()
        Me.Button_ra1_english = New System.Windows.Forms.Button()
        Me.Button_ra1_skirmish = New System.Windows.Forms.Button()
        Me.Button_ra1_ext_cs = New System.Windows.Forms.Button()
        Me.Button_ra1_soviet = New System.Windows.Forms.Button()
        Me.Button_ra1_cncnet = New System.Windows.Forms.Button()
        Me.Button_ra1_config = New System.Windows.Forms.Button()
        Me.Button_ra1_ally = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton_updata_ra1_movies = New System.Windows.Forms.RadioButton()
        Me.RadioButton_updata_cnc1_movies = New System.Windows.Forms.RadioButton()
        Me.Button_donate = New System.Windows.Forms.Button()
        Me.RadioButton_updata_main_web = New System.Windows.Forms.RadioButton()
        Me.RadioButton_updata_2_web = New System.Windows.Forms.RadioButton()
        Me.GroupBox_updata = New System.Windows.Forms.GroupBox()
        Me.Timer_delete_file = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.Panel_games_list.SuspendLayout()
        Me.Panel_up_log.SuspendLayout()
        Me.Panel_cnc1.SuspendLayout()
        Me.Panel_ra1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox_updata.SuspendLayout()
        Me.SuspendLayout()
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
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(468, 473)
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
        'BackgroundWorker_check_ver
        '
        '
        'Button_updata
        '
        Me.Button_updata.Enabled = False
        Me.Button_updata.Location = New System.Drawing.Point(12, 433)
        Me.Button_updata.Name = "Button_updata"
        Me.Button_updata.Size = New System.Drawing.Size(92, 23)
        Me.Button_updata.TabIndex = 33
        Me.Button_updata.Text = "强制更新修复"
        Me.Button_updata.UseVisualStyleBackColor = True
        '
        'Panel_games_list
        '
        Me.Panel_games_list.Controls.Add(Me.Button1)
        Me.Panel_games_list.Controls.Add(Me.Button_back)
        Me.Panel_games_list.Controls.Add(Me.Label_ra1)
        Me.Panel_games_list.Controls.Add(Me.Label_cnc1)
        Me.Panel_games_list.Controls.Add(Me.Button_cnc1)
        Me.Panel_games_list.Controls.Add(Me.Button_ra1)
        Me.Panel_games_list.Location = New System.Drawing.Point(10, 11)
        Me.Panel_games_list.Name = "Panel_games_list"
        Me.Panel_games_list.Size = New System.Drawing.Size(133, 317)
        Me.Panel_games_list.TabIndex = 29
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(22, 255)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 49
        Me.Button1.Text = "test"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'Button_back
        '
        Me.Button_back.Location = New System.Drawing.Point(34, 12)
        Me.Button_back.Name = "Button_back"
        Me.Button_back.Size = New System.Drawing.Size(58, 23)
        Me.Button_back.TabIndex = 4
        Me.Button_back.Text = "返回"
        Me.Button_back.UseVisualStyleBackColor = True
        '
        'Label_ra1
        '
        Me.Label_ra1.AutoSize = True
        Me.Label_ra1.Enabled = False
        Me.Label_ra1.Location = New System.Drawing.Point(36, 204)
        Me.Label_ra1.Name = "Label_ra1"
        Me.Label_ra1.Size = New System.Drawing.Size(53, 12)
        Me.Label_ra1.TabIndex = 3
        Me.Label_ra1.Text = "红色警戒"
        '
        'Label_cnc1
        '
        Me.Label_cnc1.AutoSize = True
        Me.Label_cnc1.Enabled = False
        Me.Label_cnc1.Location = New System.Drawing.Point(32, 109)
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
        Me.Button_cnc1.Location = New System.Drawing.Point(34, 50)
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
        Me.Button_ra1.Location = New System.Drawing.Point(34, 147)
        Me.Button_ra1.Name = "Button_ra1"
        Me.Button_ra1.Size = New System.Drawing.Size(58, 54)
        Me.Button_ra1.TabIndex = 1
        Me.Button_ra1.UseVisualStyleBackColor = True
        '
        'Panel_up_log
        '
        Me.Panel_up_log.Controls.Add(Me.WebBrowser1)
        Me.Panel_up_log.Location = New System.Drawing.Point(149, 11)
        Me.Panel_up_log.Name = "Panel_up_log"
        Me.Panel_up_log.Size = New System.Drawing.Size(640, 400)
        Me.Panel_up_log.TabIndex = 42
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(0, 0)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.ScriptErrorsSuppressed = True
        Me.WebBrowser1.Size = New System.Drawing.Size(628, 396)
        Me.WebBrowser1.TabIndex = 1
        Me.WebBrowser1.Url = New System.Uri("http://yjfyeyu.gitee.io/cnc_chi_readme/readme.htm", System.UriKind.Absolute)
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(519, 436)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(268, 23)
        Me.ProgressBar1.TabIndex = 32
        '
        'Panel_cnc1
        '
        Me.Panel_cnc1.BackgroundImage = Global.WestWood_Classic.My.Resources.Resources.htitle
        Me.Panel_cnc1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel_cnc1.Controls.Add(Me.Button_cnc1_config)
        Me.Panel_cnc1.Controls.Add(Me.Button_cnc1_english)
        Me.Panel_cnc1.Controls.Add(Me.Button_cnc1_cncnet)
        Me.Panel_cnc1.Controls.Add(Me.Button_cnc1_tv)
        Me.Panel_cnc1.Controls.Add(Me.Button_cnc1_ext)
        Me.Panel_cnc1.Controls.Add(Me.Button_cnc1_NOD_miss)
        Me.Panel_cnc1.Controls.Add(Me.Button_cnc1_GDI_miss)
        Me.Panel_cnc1.Location = New System.Drawing.Point(149, 11)
        Me.Panel_cnc1.Name = "Panel_cnc1"
        Me.Panel_cnc1.Size = New System.Drawing.Size(640, 400)
        Me.Panel_cnc1.TabIndex = 30
        '
        'Button_cnc1_config
        '
        Me.Button_cnc1_config.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_cnc1_config.BackColor = System.Drawing.Color.Transparent
        Me.Button_cnc1_config.BackgroundImage = CType(resources.GetObject("Button_cnc1_config.BackgroundImage"), System.Drawing.Image)
        Me.Button_cnc1_config.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button_cnc1_config.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button_cnc1_config.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.Button_cnc1_config.Location = New System.Drawing.Point(239, 218)
        Me.Button_cnc1_config.Name = "Button_cnc1_config"
        Me.Button_cnc1_config.Size = New System.Drawing.Size(167, 22)
        Me.Button_cnc1_config.TabIndex = 6
        Me.Button_cnc1_config.Text = "设置"
        Me.Button_cnc1_config.UseVisualStyleBackColor = False
        '
        'Button_cnc1_english
        '
        Me.Button_cnc1_english.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_cnc1_english.BackColor = System.Drawing.Color.Transparent
        Me.Button_cnc1_english.BackgroundImage = CType(resources.GetObject("Button_cnc1_english.BackgroundImage"), System.Drawing.Image)
        Me.Button_cnc1_english.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button_cnc1_english.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button_cnc1_english.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.Button_cnc1_english.Location = New System.Drawing.Point(239, 187)
        Me.Button_cnc1_english.Name = "Button_cnc1_english"
        Me.Button_cnc1_english.Size = New System.Drawing.Size(167, 22)
        Me.Button_cnc1_english.TabIndex = 5
        Me.Button_cnc1_english.Text = "英文版"
        Me.Button_cnc1_english.UseVisualStyleBackColor = False
        '
        'Button_cnc1_cncnet
        '
        Me.Button_cnc1_cncnet.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_cnc1_cncnet.BackColor = System.Drawing.Color.Transparent
        Me.Button_cnc1_cncnet.BackgroundImage = CType(resources.GetObject("Button_cnc1_cncnet.BackgroundImage"), System.Drawing.Image)
        Me.Button_cnc1_cncnet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button_cnc1_cncnet.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button_cnc1_cncnet.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.Button_cnc1_cncnet.Location = New System.Drawing.Point(239, 156)
        Me.Button_cnc1_cncnet.Name = "Button_cnc1_cncnet"
        Me.Button_cnc1_cncnet.Size = New System.Drawing.Size(167, 22)
        Me.Button_cnc1_cncnet.TabIndex = 4
        Me.Button_cnc1_cncnet.Text = "CnCNet 联机"
        Me.Button_cnc1_cncnet.UseVisualStyleBackColor = False
        '
        'Button_cnc1_tv
        '
        Me.Button_cnc1_tv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_cnc1_tv.BackColor = System.Drawing.Color.Transparent
        Me.Button_cnc1_tv.BackgroundImage = CType(resources.GetObject("Button_cnc1_tv.BackgroundImage"), System.Drawing.Image)
        Me.Button_cnc1_tv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button_cnc1_tv.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button_cnc1_tv.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.Button_cnc1_tv.Location = New System.Drawing.Point(239, 125)
        Me.Button_cnc1_tv.Name = "Button_cnc1_tv"
        Me.Button_cnc1_tv.Size = New System.Drawing.Size(167, 22)
        Me.Button_cnc1_tv.TabIndex = 3
        Me.Button_cnc1_tv.Text = "游戏主机独占任务"
        Me.Button_cnc1_tv.UseVisualStyleBackColor = False
        '
        'Button_cnc1_ext
        '
        Me.Button_cnc1_ext.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_cnc1_ext.BackColor = System.Drawing.Color.Transparent
        Me.Button_cnc1_ext.BackgroundImage = CType(resources.GetObject("Button_cnc1_ext.BackgroundImage"), System.Drawing.Image)
        Me.Button_cnc1_ext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button_cnc1_ext.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button_cnc1_ext.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.Button_cnc1_ext.Location = New System.Drawing.Point(239, 94)
        Me.Button_cnc1_ext.Name = "Button_cnc1_ext"
        Me.Button_cnc1_ext.Size = New System.Drawing.Size(167, 22)
        Me.Button_cnc1_ext.TabIndex = 2
        Me.Button_cnc1_ext.Text = "隐秘行动资料片任务"
        Me.Button_cnc1_ext.UseVisualStyleBackColor = False
        '
        'Button_cnc1_NOD_miss
        '
        Me.Button_cnc1_NOD_miss.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_cnc1_NOD_miss.BackColor = System.Drawing.Color.Transparent
        Me.Button_cnc1_NOD_miss.BackgroundImage = CType(resources.GetObject("Button_cnc1_NOD_miss.BackgroundImage"), System.Drawing.Image)
        Me.Button_cnc1_NOD_miss.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button_cnc1_NOD_miss.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button_cnc1_NOD_miss.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.Button_cnc1_NOD_miss.Location = New System.Drawing.Point(239, 63)
        Me.Button_cnc1_NOD_miss.Name = "Button_cnc1_NOD_miss"
        Me.Button_cnc1_NOD_miss.Size = New System.Drawing.Size(167, 22)
        Me.Button_cnc1_NOD_miss.TabIndex = 1
        Me.Button_cnc1_NOD_miss.Text = "诺德兄弟会剧情任务(NOD)"
        Me.Button_cnc1_NOD_miss.UseVisualStyleBackColor = False
        '
        'Button_cnc1_GDI_miss
        '
        Me.Button_cnc1_GDI_miss.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_cnc1_GDI_miss.BackColor = System.Drawing.Color.Transparent
        Me.Button_cnc1_GDI_miss.BackgroundImage = CType(resources.GetObject("Button_cnc1_GDI_miss.BackgroundImage"), System.Drawing.Image)
        Me.Button_cnc1_GDI_miss.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button_cnc1_GDI_miss.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button_cnc1_GDI_miss.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.Button_cnc1_GDI_miss.Location = New System.Drawing.Point(239, 36)
        Me.Button_cnc1_GDI_miss.Name = "Button_cnc1_GDI_miss"
        Me.Button_cnc1_GDI_miss.Size = New System.Drawing.Size(167, 22)
        Me.Button_cnc1_GDI_miss.TabIndex = 0
        Me.Button_cnc1_GDI_miss.Text = "全球防御组织剧情任务(GDI)"
        Me.Button_cnc1_GDI_miss.UseVisualStyleBackColor = False
        '
        'Panel_ra1
        '
        Me.Panel_ra1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel_ra1.BackgroundImage = Global.WestWood_Classic.My.Resources.Resources.title
        Me.Panel_ra1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel_ra1.Controls.Add(Me.Button_ra1_ext_af_su)
        Me.Panel_ra1.Controls.Add(Me.Button_ra1_ext_af)
        Me.Panel_ra1.Controls.Add(Me.Button_ra1_english)
        Me.Panel_ra1.Controls.Add(Me.Button_ra1_skirmish)
        Me.Panel_ra1.Controls.Add(Me.Button_ra1_ext_cs)
        Me.Panel_ra1.Controls.Add(Me.Button_ra1_soviet)
        Me.Panel_ra1.Controls.Add(Me.Button_ra1_cncnet)
        Me.Panel_ra1.Controls.Add(Me.Button_ra1_config)
        Me.Panel_ra1.Controls.Add(Me.Button_ra1_ally)
        Me.Panel_ra1.Location = New System.Drawing.Point(149, 11)
        Me.Panel_ra1.Name = "Panel_ra1"
        Me.Panel_ra1.Size = New System.Drawing.Size(640, 400)
        Me.Panel_ra1.TabIndex = 31
        '
        'Button_ra1_ext_af_su
        '
        Me.Button_ra1_ext_af_su.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_ra1_ext_af_su.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button_ra1_ext_af_su.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button_ra1_ext_af_su.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button_ra1_ext_af_su.FlatAppearance.BorderSize = 20
        Me.Button_ra1_ext_af_su.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button_ra1_ext_af_su.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy
        Me.Button_ra1_ext_af_su.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button_ra1_ext_af_su.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button_ra1_ext_af_su.Location = New System.Drawing.Point(236, 270)
        Me.Button_ra1_ext_af_su.Name = "Button_ra1_ext_af_su"
        Me.Button_ra1_ext_af_su.Size = New System.Drawing.Size(170, 22)
        Me.Button_ra1_ext_af_su.TabIndex = 8
        Me.Button_ra1_ext_af_su.Text = "余生资料片苏军任务"
        Me.Button_ra1_ext_af_su.UseVisualStyleBackColor = False
        '
        'Button_ra1_ext_af
        '
        Me.Button_ra1_ext_af.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_ra1_ext_af.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button_ra1_ext_af.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button_ra1_ext_af.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button_ra1_ext_af.FlatAppearance.BorderSize = 20
        Me.Button_ra1_ext_af.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button_ra1_ext_af.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy
        Me.Button_ra1_ext_af.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button_ra1_ext_af.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button_ra1_ext_af.Location = New System.Drawing.Point(236, 246)
        Me.Button_ra1_ext_af.Name = "Button_ra1_ext_af"
        Me.Button_ra1_ext_af.Size = New System.Drawing.Size(170, 22)
        Me.Button_ra1_ext_af.TabIndex = 7
        Me.Button_ra1_ext_af.Text = "余生资料片盟军任务"
        Me.Button_ra1_ext_af.UseVisualStyleBackColor = False
        '
        'Button_ra1_english
        '
        Me.Button_ra1_english.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_ra1_english.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button_ra1_english.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button_ra1_english.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button_ra1_english.FlatAppearance.BorderSize = 20
        Me.Button_ra1_english.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button_ra1_english.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy
        Me.Button_ra1_english.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button_ra1_english.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button_ra1_english.Location = New System.Drawing.Point(237, 318)
        Me.Button_ra1_english.Name = "Button_ra1_english"
        Me.Button_ra1_english.Size = New System.Drawing.Size(170, 22)
        Me.Button_ra1_english.TabIndex = 6
        Me.Button_ra1_english.Text = "英文版"
        Me.Button_ra1_english.UseVisualStyleBackColor = False
        '
        'Button_ra1_skirmish
        '
        Me.Button_ra1_skirmish.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_ra1_skirmish.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button_ra1_skirmish.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button_ra1_skirmish.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button_ra1_skirmish.FlatAppearance.BorderSize = 20
        Me.Button_ra1_skirmish.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button_ra1_skirmish.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy
        Me.Button_ra1_skirmish.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button_ra1_skirmish.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button_ra1_skirmish.Location = New System.Drawing.Point(236, 198)
        Me.Button_ra1_skirmish.Name = "Button_ra1_skirmish"
        Me.Button_ra1_skirmish.Size = New System.Drawing.Size(170, 22)
        Me.Button_ra1_skirmish.TabIndex = 5
        Me.Button_ra1_skirmish.Text = "遭遇战"
        Me.Button_ra1_skirmish.UseVisualStyleBackColor = False
        '
        'Button_ra1_ext_cs
        '
        Me.Button_ra1_ext_cs.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_ra1_ext_cs.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button_ra1_ext_cs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button_ra1_ext_cs.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button_ra1_ext_cs.FlatAppearance.BorderSize = 20
        Me.Button_ra1_ext_cs.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button_ra1_ext_cs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy
        Me.Button_ra1_ext_cs.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button_ra1_ext_cs.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button_ra1_ext_cs.Location = New System.Drawing.Point(236, 222)
        Me.Button_ra1_ext_cs.Name = "Button_ra1_ext_cs"
        Me.Button_ra1_ext_cs.Size = New System.Drawing.Size(170, 22)
        Me.Button_ra1_ext_cs.TabIndex = 4
        Me.Button_ra1_ext_cs.Text = "反击资料片任务"
        Me.Button_ra1_ext_cs.UseVisualStyleBackColor = False
        '
        'Button_ra1_soviet
        '
        Me.Button_ra1_soviet.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_ra1_soviet.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button_ra1_soviet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button_ra1_soviet.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button_ra1_soviet.FlatAppearance.BorderSize = 20
        Me.Button_ra1_soviet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button_ra1_soviet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy
        Me.Button_ra1_soviet.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button_ra1_soviet.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button_ra1_soviet.Location = New System.Drawing.Point(237, 174)
        Me.Button_ra1_soviet.Name = "Button_ra1_soviet"
        Me.Button_ra1_soviet.Size = New System.Drawing.Size(170, 22)
        Me.Button_ra1_soviet.TabIndex = 3
        Me.Button_ra1_soviet.Text = "苏军剧情任务"
        Me.Button_ra1_soviet.UseVisualStyleBackColor = False
        '
        'Button_ra1_cncnet
        '
        Me.Button_ra1_cncnet.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_ra1_cncnet.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button_ra1_cncnet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button_ra1_cncnet.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button_ra1_cncnet.FlatAppearance.BorderSize = 20
        Me.Button_ra1_cncnet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button_ra1_cncnet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy
        Me.Button_ra1_cncnet.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button_ra1_cncnet.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button_ra1_cncnet.Location = New System.Drawing.Point(237, 294)
        Me.Button_ra1_cncnet.Name = "Button_ra1_cncnet"
        Me.Button_ra1_cncnet.Size = New System.Drawing.Size(170, 22)
        Me.Button_ra1_cncnet.TabIndex = 2
        Me.Button_ra1_cncnet.Text = "CnCNet 联机"
        Me.Button_ra1_cncnet.UseVisualStyleBackColor = False
        '
        'Button_ra1_config
        '
        Me.Button_ra1_config.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_ra1_config.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button_ra1_config.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button_ra1_config.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button_ra1_config.FlatAppearance.BorderSize = 20
        Me.Button_ra1_config.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button_ra1_config.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy
        Me.Button_ra1_config.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button_ra1_config.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button_ra1_config.Location = New System.Drawing.Point(237, 342)
        Me.Button_ra1_config.Name = "Button_ra1_config"
        Me.Button_ra1_config.Size = New System.Drawing.Size(170, 22)
        Me.Button_ra1_config.TabIndex = 1
        Me.Button_ra1_config.Text = "设置"
        Me.Button_ra1_config.UseVisualStyleBackColor = False
        '
        'Button_ra1_ally
        '
        Me.Button_ra1_ally.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_ra1_ally.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button_ra1_ally.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button_ra1_ally.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button_ra1_ally.FlatAppearance.BorderSize = 20
        Me.Button_ra1_ally.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button_ra1_ally.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy
        Me.Button_ra1_ally.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button_ra1_ally.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button_ra1_ally.Location = New System.Drawing.Point(237, 150)
        Me.Button_ra1_ally.Name = "Button_ra1_ally"
        Me.Button_ra1_ally.Size = New System.Drawing.Size(170, 22)
        Me.Button_ra1_ally.TabIndex = 0
        Me.Button_ra1_ally.Text = "盟军剧情任务"
        Me.Button_ra1_ally.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RadioButton1)
        Me.GroupBox2.Controls.Add(Me.RadioButton_updata_ra1_movies)
        Me.GroupBox2.Controls.Add(Me.RadioButton_updata_cnc1_movies)
        Me.GroupBox2.Enabled = False
        Me.GroupBox2.Location = New System.Drawing.Point(297, 420)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(216, 45)
        Me.GroupBox2.TabIndex = 44
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "包括动画"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(6, 20)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(35, 16)
        Me.RadioButton1.TabIndex = 2
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "无"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton_updata_ra1_movies
        '
        Me.RadioButton_updata_ra1_movies.AutoSize = True
        Me.RadioButton_updata_ra1_movies.Location = New System.Drawing.Point(136, 20)
        Me.RadioButton_updata_ra1_movies.Name = "RadioButton_updata_ra1_movies"
        Me.RadioButton_updata_ra1_movies.Size = New System.Drawing.Size(71, 16)
        Me.RadioButton_updata_ra1_movies.TabIndex = 1
        Me.RadioButton_updata_ra1_movies.Text = "红色警戒"
        Me.RadioButton_updata_ra1_movies.UseVisualStyleBackColor = True
        '
        'RadioButton_updata_cnc1_movies
        '
        Me.RadioButton_updata_cnc1_movies.AutoSize = True
        Me.RadioButton_updata_cnc1_movies.Location = New System.Drawing.Point(47, 20)
        Me.RadioButton_updata_cnc1_movies.Name = "RadioButton_updata_cnc1_movies"
        Me.RadioButton_updata_cnc1_movies.Size = New System.Drawing.Size(83, 16)
        Me.RadioButton_updata_cnc1_movies.TabIndex = 0
        Me.RadioButton_updata_cnc1_movies.Text = "命令与征服"
        Me.RadioButton_updata_cnc1_movies.UseVisualStyleBackColor = True
        '
        'Button_donate
        '
        Me.Button_donate.Location = New System.Drawing.Point(741, 468)
        Me.Button_donate.Name = "Button_donate"
        Me.Button_donate.Size = New System.Drawing.Size(48, 23)
        Me.Button_donate.TabIndex = 45
        Me.Button_donate.Text = "捐助"
        Me.Button_donate.UseVisualStyleBackColor = True
        '
        'RadioButton_updata_main_web
        '
        Me.RadioButton_updata_main_web.AutoSize = True
        Me.RadioButton_updata_main_web.Checked = True
        Me.RadioButton_updata_main_web.Location = New System.Drawing.Point(6, 20)
        Me.RadioButton_updata_main_web.Name = "RadioButton_updata_main_web"
        Me.RadioButton_updata_main_web.Size = New System.Drawing.Size(71, 16)
        Me.RadioButton_updata_main_web.TabIndex = 46
        Me.RadioButton_updata_main_web.TabStop = True
        Me.RadioButton_updata_main_web.Text = "主更新点"
        Me.RadioButton_updata_main_web.UseVisualStyleBackColor = True
        '
        'RadioButton_updata_2_web
        '
        Me.RadioButton_updata_2_web.AutoSize = True
        Me.RadioButton_updata_2_web.Location = New System.Drawing.Point(83, 20)
        Me.RadioButton_updata_2_web.Name = "RadioButton_updata_2_web"
        Me.RadioButton_updata_2_web.Size = New System.Drawing.Size(71, 16)
        Me.RadioButton_updata_2_web.TabIndex = 47
        Me.RadioButton_updata_2_web.Text = "备更新点"
        Me.RadioButton_updata_2_web.UseVisualStyleBackColor = True
        '
        'GroupBox_updata
        '
        Me.GroupBox_updata.Controls.Add(Me.RadioButton_updata_2_web)
        Me.GroupBox_updata.Controls.Add(Me.RadioButton_updata_main_web)
        Me.GroupBox_updata.Enabled = False
        Me.GroupBox_updata.Location = New System.Drawing.Point(114, 420)
        Me.GroupBox_updata.Name = "GroupBox_updata"
        Me.GroupBox_updata.Size = New System.Drawing.Size(161, 45)
        Me.GroupBox_updata.TabIndex = 48
        Me.GroupBox_updata.TabStop = False
        Me.GroupBox_updata.Text = "更新站点"
        '
        'Timer_delete_file
        '
        Me.Timer_delete_file.Enabled = True
        Me.Timer_delete_file.Interval = 1000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(801, 496)
        Me.Controls.Add(Me.GroupBox_updata)
        Me.Controls.Add(Me.Button_donate)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label_r_version)
        Me.Controls.Add(Me.Label_l_version)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label_status)
        Me.Controls.Add(Me.Button_updata)
        Me.Controls.Add(Me.Panel_games_list)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.LinkLabel1)
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
        Me.Panel_cnc1.ResumeLayout(False)
        Me.Panel_ra1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox_updata.ResumeLayout(False)
        Me.GroupBox_updata.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RadioButton_winxp As RadioButton
    Friend WithEvents RadioButton_win7 As RadioButton
    Friend WithEvents RadioButton_win10 As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label_r_version As Label
    Friend WithEvents Label_l_version As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label_status As Label
    Friend WithEvents BackgroundWorker_check_ver As System.ComponentModel.BackgroundWorker
    Friend WithEvents Button_updata As Button
    Friend WithEvents Panel_games_list As Panel
    Friend WithEvents Label_ra1 As Label
    Friend WithEvents Label_cnc1 As Label
    Friend WithEvents Button_cnc1 As Button
    Friend WithEvents Button_ra1 As Button
    Friend WithEvents Panel_up_log As Panel
    Friend WithEvents Panel_ra1 As Panel
    Friend WithEvents Button_ra1_config As Button
    Friend WithEvents Button_ra1_ally As Button
    Friend WithEvents Panel_cnc1 As Panel
    Friend WithEvents Button_cnc1_config As Button
    Friend WithEvents Button_cnc1_english As Button
    Friend WithEvents Button_cnc1_cncnet As Button
    Friend WithEvents Button_cnc1_tv As Button
    Friend WithEvents Button_cnc1_ext As Button
    Friend WithEvents Button_cnc1_NOD_miss As Button
    Friend WithEvents Button_cnc1_GDI_miss As Button
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Button_ra1_cncnet As Button
    Friend WithEvents WebBrowser1 As WebBrowser
    Friend WithEvents Button_ra1_skirmish As Button
    Friend WithEvents Button_ra1_ext_cs As Button
    Friend WithEvents Button_ra1_soviet As Button
    Friend WithEvents Button_back As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents RadioButton_updata_ra1_movies As RadioButton
    Friend WithEvents RadioButton_updata_cnc1_movies As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents Button_ra1_english As Button
    Friend WithEvents Button_donate As Button
    Friend WithEvents Button_ra1_ext_af As Button
    Friend WithEvents Button_ra1_ext_af_su As Button
    Friend WithEvents RadioButton_updata_main_web As RadioButton
    Friend WithEvents RadioButton_updata_2_web As RadioButton
    Friend WithEvents GroupBox_updata As GroupBox
    Friend WithEvents Timer_delete_file As Timer
    Friend WithEvents Button1 As Button
End Class
