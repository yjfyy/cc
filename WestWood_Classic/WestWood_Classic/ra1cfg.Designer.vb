<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ra1cfg
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ra1cfg))
        Me.RadioButton_gdi = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox_width = New System.Windows.Forms.TextBox()
        Me.TextBox_height = New System.Windows.Forms.TextBox()
        Me.RadioButton_test_resolution = New System.Windows.Forms.RadioButton()
        Me.RadioButton_auto = New System.Windows.Forms.RadioButton()
        Me.RadioButton_opengl = New System.Windows.Forms.RadioButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ComboBox_shader = New System.Windows.Forms.ComboBox()
        Me.RadioButton_direct3d9 = New System.Windows.Forms.RadioButton()
        Me.RadioButton_windows = New System.Windows.Forms.RadioButton()
        Me.RadioButton_full = New System.Windows.Forms.RadioButton()
        Me.RadioButton_640 = New System.Windows.Forms.RadioButton()
        Me.Button_ok = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.RadioButton_full_win = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.RadioButton_1280 = New System.Windows.Forms.RadioButton()
        Me.RadioButton_864 = New System.Windows.Forms.RadioButton()
        Me.RadioButton_1728 = New System.Windows.Forms.RadioButton()
        Me.CheckBox_dos_ratio = New System.Windows.Forms.CheckBox()
        Me.Label_height_800 = New System.Windows.Forms.Label()
        Me.Label_width_640 = New System.Windows.Forms.Label()
        Me.Label_height_540 = New System.Windows.Forms.Label()
        Me.Label_width_864 = New System.Windows.Forms.Label()
        Me.Label_width_1280 = New System.Windows.Forms.Label()
        Me.Label_width_1728 = New System.Windows.Forms.Label()
        Me.Label_height_400 = New System.Windows.Forms.Label()
        Me.Label_height_1080 = New System.Windows.Forms.Label()
        Me.Button_reset = New System.Windows.Forms.Button()
        Me.GroupBox_ddraw_resolution = New System.Windows.Forms.GroupBox()
        Me.CheckBox_ddraw_resolution = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox_ddraw_width = New System.Windows.Forms.TextBox()
        Me.TextBox_ddraw_height = New System.Windows.Forms.TextBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Button_reg_ddraw = New System.Windows.Forms.Button()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox_ddraw_resolution.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'RadioButton_gdi
        '
        Me.RadioButton_gdi.AutoSize = True
        Me.RadioButton_gdi.Location = New System.Drawing.Point(6, 147)
        Me.RadioButton_gdi.Name = "RadioButton_gdi"
        Me.RadioButton_gdi.Size = New System.Drawing.Size(179, 16)
        Me.RadioButton_gdi.TabIndex = 0
        Me.RadioButton_gdi.TabStop = True
        Me.RadioButton_gdi.Text = "软件（GDI,可避免滚屏过快）"
        Me.RadioButton_gdi.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(127, 192)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 12)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "高："
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 192)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 12)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "宽："
        '
        'TextBox_width
        '
        Me.TextBox_width.Enabled = False
        Me.TextBox_width.Location = New System.Drawing.Point(43, 188)
        Me.TextBox_width.Name = "TextBox_width"
        Me.TextBox_width.Size = New System.Drawing.Size(54, 21)
        Me.TextBox_width.TabIndex = 5
        '
        'TextBox_height
        '
        Me.TextBox_height.Enabled = False
        Me.TextBox_height.Location = New System.Drawing.Point(162, 188)
        Me.TextBox_height.Name = "TextBox_height"
        Me.TextBox_height.Size = New System.Drawing.Size(54, 21)
        Me.TextBox_height.TabIndex = 6
        '
        'RadioButton_test_resolution
        '
        Me.RadioButton_test_resolution.AutoSize = True
        Me.RadioButton_test_resolution.Location = New System.Drawing.Point(10, 163)
        Me.RadioButton_test_resolution.Name = "RadioButton_test_resolution"
        Me.RadioButton_test_resolution.Size = New System.Drawing.Size(191, 16)
        Me.RadioButton_test_resolution.TabIndex = 4
        Me.RadioButton_test_resolution.TabStop = True
        Me.RadioButton_test_resolution.Text = "自动检测并推荐（可手动更改）"
        Me.RadioButton_test_resolution.UseVisualStyleBackColor = True
        '
        'RadioButton_auto
        '
        Me.RadioButton_auto.AutoSize = True
        Me.RadioButton_auto.Location = New System.Drawing.Point(6, 20)
        Me.RadioButton_auto.Name = "RadioButton_auto"
        Me.RadioButton_auto.Size = New System.Drawing.Size(173, 16)
        Me.RadioButton_auto.TabIndex = 2
        Me.RadioButton_auto.TabStop = True
        Me.RadioButton_auto.Text = "自动(优先硬件,失败后软件)"
        Me.RadioButton_auto.UseVisualStyleBackColor = True
        '
        'RadioButton_opengl
        '
        Me.RadioButton_opengl.AutoSize = True
        Me.RadioButton_opengl.ForeColor = System.Drawing.Color.Red
        Me.RadioButton_opengl.Location = New System.Drawing.Point(6, 75)
        Me.RadioButton_opengl.Name = "RadioButton_opengl"
        Me.RadioButton_opengl.Size = New System.Drawing.Size(107, 16)
        Me.RadioButton_opengl.TabIndex = 1
        Me.RadioButton_opengl.TabStop = True
        Me.RadioButton_opengl.Text = "硬件（OpenGL）"
        Me.RadioButton_opengl.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.ComboBox_shader)
        Me.GroupBox4.Controls.Add(Me.RadioButton_direct3d9)
        Me.GroupBox4.Controls.Add(Me.RadioButton_auto)
        Me.GroupBox4.Controls.Add(Me.RadioButton_opengl)
        Me.GroupBox4.Controls.Add(Me.RadioButton_gdi)
        Me.GroupBox4.Location = New System.Drawing.Point(276, 16)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(193, 179)
        Me.GroupBox4.TabIndex = 10
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "渲染模式"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(6, 122)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(179, 12)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "滤镜可增强画质,必须使用OpenGL"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(6, 100)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(29, 12)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "滤镜"
        '
        'ComboBox_shader
        '
        Me.ComboBox_shader.Enabled = False
        Me.ComboBox_shader.FormattingEnabled = True
        Me.ComboBox_shader.Items.AddRange(New Object() {"无", "双线插值", "三线插值", "高亮", "模拟显像管", "模拟纯平显像管", "模拟扫描线", "xbr柔化", "xbrz柔化"})
        Me.ComboBox_shader.Location = New System.Drawing.Point(41, 97)
        Me.ComboBox_shader.Name = "ComboBox_shader"
        Me.ComboBox_shader.Size = New System.Drawing.Size(138, 20)
        Me.ComboBox_shader.TabIndex = 0
        '
        'RadioButton_direct3d9
        '
        Me.RadioButton_direct3d9.AutoSize = True
        Me.RadioButton_direct3d9.Location = New System.Drawing.Point(6, 46)
        Me.RadioButton_direct3d9.Name = "RadioButton_direct3d9"
        Me.RadioButton_direct3d9.Size = New System.Drawing.Size(119, 16)
        Me.RadioButton_direct3d9.TabIndex = 3
        Me.RadioButton_direct3d9.TabStop = True
        Me.RadioButton_direct3d9.Text = "硬件（Driect9x）"
        Me.RadioButton_direct3d9.UseVisualStyleBackColor = True
        '
        'RadioButton_windows
        '
        Me.RadioButton_windows.AutoSize = True
        Me.RadioButton_windows.Location = New System.Drawing.Point(6, 64)
        Me.RadioButton_windows.Name = "RadioButton_windows"
        Me.RadioButton_windows.Size = New System.Drawing.Size(47, 16)
        Me.RadioButton_windows.TabIndex = 1
        Me.RadioButton_windows.TabStop = True
        Me.RadioButton_windows.Text = "窗口"
        Me.RadioButton_windows.UseVisualStyleBackColor = True
        '
        'RadioButton_full
        '
        Me.RadioButton_full.AutoSize = True
        Me.RadioButton_full.Location = New System.Drawing.Point(6, 20)
        Me.RadioButton_full.Name = "RadioButton_full"
        Me.RadioButton_full.Size = New System.Drawing.Size(47, 16)
        Me.RadioButton_full.TabIndex = 0
        Me.RadioButton_full.TabStop = True
        Me.RadioButton_full.Text = "全屏"
        Me.RadioButton_full.UseVisualStyleBackColor = True
        '
        'RadioButton_640
        '
        Me.RadioButton_640.AutoSize = True
        Me.RadioButton_640.Location = New System.Drawing.Point(10, 48)
        Me.RadioButton_640.Name = "RadioButton_640"
        Me.RadioButton_640.Size = New System.Drawing.Size(65, 16)
        Me.RadioButton_640.TabIndex = 0
        Me.RadioButton_640.TabStop = True
        Me.RadioButton_640.Text = "640x480"
        Me.RadioButton_640.UseVisualStyleBackColor = True
        '
        'Button_ok
        '
        Me.Button_ok.Location = New System.Drawing.Point(429, 276)
        Me.Button_ok.Name = "Button_ok"
        Me.Button_ok.Size = New System.Drawing.Size(75, 23)
        Me.Button_ok.TabIndex = 11
        Me.Button_ok.Text = "确定"
        Me.Button_ok.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.RadioButton_full_win)
        Me.GroupBox3.Controls.Add(Me.RadioButton_windows)
        Me.GroupBox3.Controls.Add(Me.RadioButton_full)
        Me.GroupBox3.Location = New System.Drawing.Point(276, 201)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(125, 109)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "显示模式"
        '
        'RadioButton_full_win
        '
        Me.RadioButton_full_win.AutoSize = True
        Me.RadioButton_full_win.Location = New System.Drawing.Point(6, 42)
        Me.RadioButton_full_win.Name = "RadioButton_full_win"
        Me.RadioButton_full_win.Size = New System.Drawing.Size(71, 16)
        Me.RadioButton_full_win.TabIndex = 2
        Me.RadioButton_full_win.TabStop = True
        Me.RadioButton_full_win.Text = "全屏窗口"
        Me.RadioButton_full_win.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.RadioButton_1280)
        Me.GroupBox1.Controls.Add(Me.RadioButton_864)
        Me.GroupBox1.Controls.Add(Me.RadioButton_1728)
        Me.GroupBox1.Controls.Add(Me.CheckBox_dos_ratio)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TextBox_width)
        Me.GroupBox1.Controls.Add(Me.TextBox_height)
        Me.GroupBox1.Controls.Add(Me.RadioButton_test_resolution)
        Me.GroupBox1.Controls.Add(Me.RadioButton_640)
        Me.GroupBox1.Location = New System.Drawing.Point(21, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(249, 229)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "游戏分辨率："
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.ForeColor = System.Drawing.Color.Red
        Me.Label18.Location = New System.Drawing.Point(131, 137)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(95, 12)
        Me.Label18.TabIndex = 30
        Me.Label18.Text = "1080p显示器推荐"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.ForeColor = System.Drawing.Color.Red
        Me.Label16.Location = New System.Drawing.Point(131, 108)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(95, 12)
        Me.Label16.TabIndex = 28
        Me.Label16.Text = "1080p显示器推荐"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(113, 77)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(113, 12)
        Me.Label15.TabIndex = 27
        Me.Label15.Text = "基于原始分辨率推荐"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(137, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 12)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "游戏原始分辨率"
        '
        'RadioButton_1280
        '
        Me.RadioButton_1280.AutoSize = True
        Me.RadioButton_1280.Location = New System.Drawing.Point(10, 75)
        Me.RadioButton_1280.Name = "RadioButton_1280"
        Me.RadioButton_1280.Size = New System.Drawing.Size(71, 16)
        Me.RadioButton_1280.TabIndex = 22
        Me.RadioButton_1280.TabStop = True
        Me.RadioButton_1280.Text = "1280x800"
        Me.RadioButton_1280.UseVisualStyleBackColor = True
        '
        'RadioButton_864
        '
        Me.RadioButton_864.AutoSize = True
        Me.RadioButton_864.ForeColor = System.Drawing.Color.Red
        Me.RadioButton_864.Location = New System.Drawing.Point(10, 106)
        Me.RadioButton_864.Name = "RadioButton_864"
        Me.RadioButton_864.Size = New System.Drawing.Size(113, 16)
        Me.RadioButton_864.TabIndex = 14
        Me.RadioButton_864.TabStop = True
        Me.RadioButton_864.Text = "864x540（推荐）"
        Me.RadioButton_864.UseVisualStyleBackColor = True
        '
        'RadioButton_1728
        '
        Me.RadioButton_1728.AutoSize = True
        Me.RadioButton_1728.ForeColor = System.Drawing.Color.Red
        Me.RadioButton_1728.Location = New System.Drawing.Point(10, 135)
        Me.RadioButton_1728.Name = "RadioButton_1728"
        Me.RadioButton_1728.Size = New System.Drawing.Size(125, 16)
        Me.RadioButton_1728.TabIndex = 18
        Me.RadioButton_1728.TabStop = True
        Me.RadioButton_1728.Text = "1728x1080（推荐）"
        Me.RadioButton_1728.UseVisualStyleBackColor = True
        '
        'CheckBox_dos_ratio
        '
        Me.CheckBox_dos_ratio.AutoSize = True
        Me.CheckBox_dos_ratio.Checked = True
        Me.CheckBox_dos_ratio.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox_dos_ratio.ForeColor = System.Drawing.Color.Red
        Me.CheckBox_dos_ratio.Location = New System.Drawing.Point(10, 21)
        Me.CheckBox_dos_ratio.Name = "CheckBox_dos_ratio"
        Me.CheckBox_dos_ratio.Size = New System.Drawing.Size(132, 16)
        Me.CheckBox_dos_ratio.TabIndex = 10
        Me.CheckBox_dos_ratio.Text = "游戏原始比例(推荐)"
        Me.CheckBox_dos_ratio.UseVisualStyleBackColor = True
        '
        'Label_height_800
        '
        Me.Label_height_800.AutoSize = True
        Me.Label_height_800.Location = New System.Drawing.Point(475, 70)
        Me.Label_height_800.Name = "Label_height_800"
        Me.Label_height_800.Size = New System.Drawing.Size(23, 12)
        Me.Label_height_800.TabIndex = 24
        Me.Label_height_800.Text = "800"
        Me.Label_height_800.Visible = False
        '
        'Label_width_640
        '
        Me.Label_width_640.AutoSize = True
        Me.Label_width_640.Location = New System.Drawing.Point(449, 58)
        Me.Label_width_640.Name = "Label_width_640"
        Me.Label_width_640.Size = New System.Drawing.Size(23, 12)
        Me.Label_width_640.TabIndex = 11
        Me.Label_width_640.Text = "640"
        Me.Label_width_640.Visible = False
        '
        'Label_height_540
        '
        Me.Label_height_540.AutoSize = True
        Me.Label_height_540.ForeColor = System.Drawing.Color.Red
        Me.Label_height_540.Location = New System.Drawing.Point(475, 81)
        Me.Label_height_540.Name = "Label_height_540"
        Me.Label_height_540.Size = New System.Drawing.Size(23, 12)
        Me.Label_height_540.TabIndex = 16
        Me.Label_height_540.Text = "540"
        Me.Label_height_540.Visible = False
        '
        'Label_width_864
        '
        Me.Label_width_864.AutoSize = True
        Me.Label_width_864.ForeColor = System.Drawing.Color.Red
        Me.Label_width_864.Location = New System.Drawing.Point(447, 81)
        Me.Label_width_864.Name = "Label_width_864"
        Me.Label_width_864.Size = New System.Drawing.Size(23, 12)
        Me.Label_width_864.TabIndex = 15
        Me.Label_width_864.Text = "864"
        Me.Label_width_864.Visible = False
        '
        'Label_width_1280
        '
        Me.Label_width_1280.AutoSize = True
        Me.Label_width_1280.Location = New System.Drawing.Point(443, 69)
        Me.Label_width_1280.Name = "Label_width_1280"
        Me.Label_width_1280.Size = New System.Drawing.Size(29, 12)
        Me.Label_width_1280.TabIndex = 23
        Me.Label_width_1280.Text = "1280"
        Me.Label_width_1280.Visible = False
        '
        'Label_width_1728
        '
        Me.Label_width_1728.AutoSize = True
        Me.Label_width_1728.ForeColor = System.Drawing.Color.Red
        Me.Label_width_1728.Location = New System.Drawing.Point(441, 93)
        Me.Label_width_1728.Name = "Label_width_1728"
        Me.Label_width_1728.Size = New System.Drawing.Size(29, 12)
        Me.Label_width_1728.TabIndex = 19
        Me.Label_width_1728.Text = "1728"
        Me.Label_width_1728.Visible = False
        '
        'Label_height_400
        '
        Me.Label_height_400.AutoSize = True
        Me.Label_height_400.Location = New System.Drawing.Point(474, 58)
        Me.Label_height_400.Name = "Label_height_400"
        Me.Label_height_400.Size = New System.Drawing.Size(23, 12)
        Me.Label_height_400.TabIndex = 12
        Me.Label_height_400.Text = "400"
        Me.Label_height_400.Visible = False
        '
        'Label_height_1080
        '
        Me.Label_height_1080.AutoSize = True
        Me.Label_height_1080.ForeColor = System.Drawing.Color.Red
        Me.Label_height_1080.Location = New System.Drawing.Point(469, 93)
        Me.Label_height_1080.Name = "Label_height_1080"
        Me.Label_height_1080.Size = New System.Drawing.Size(29, 12)
        Me.Label_height_1080.TabIndex = 20
        Me.Label_height_1080.Text = "1080"
        Me.Label_height_1080.Visible = False
        '
        'Button_reset
        '
        Me.Button_reset.Location = New System.Drawing.Point(415, 240)
        Me.Button_reset.Name = "Button_reset"
        Me.Button_reset.Size = New System.Drawing.Size(102, 23)
        Me.Button_reset.TabIndex = 6
        Me.Button_reset.Text = "修复并重置设定"
        Me.Button_reset.UseVisualStyleBackColor = True
        '
        'GroupBox_ddraw_resolution
        '
        Me.GroupBox_ddraw_resolution.Controls.Add(Me.CheckBox_ddraw_resolution)
        Me.GroupBox_ddraw_resolution.Controls.Add(Me.Label4)
        Me.GroupBox_ddraw_resolution.Controls.Add(Me.Label5)
        Me.GroupBox_ddraw_resolution.Controls.Add(Me.TextBox_ddraw_width)
        Me.GroupBox_ddraw_resolution.Controls.Add(Me.TextBox_ddraw_height)
        Me.GroupBox_ddraw_resolution.Location = New System.Drawing.Point(21, 259)
        Me.GroupBox_ddraw_resolution.Name = "GroupBox_ddraw_resolution"
        Me.GroupBox_ddraw_resolution.Size = New System.Drawing.Size(249, 51)
        Me.GroupBox_ddraw_resolution.TabIndex = 12
        Me.GroupBox_ddraw_resolution.TabStop = False
        Me.GroupBox_ddraw_resolution.Text = "显示框架分辨率"
        '
        'CheckBox_ddraw_resolution
        '
        Me.CheckBox_ddraw_resolution.AutoSize = True
        Me.CheckBox_ddraw_resolution.Checked = True
        Me.CheckBox_ddraw_resolution.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox_ddraw_resolution.Location = New System.Drawing.Point(8, 21)
        Me.CheckBox_ddraw_resolution.Name = "CheckBox_ddraw_resolution"
        Me.CheckBox_ddraw_resolution.Size = New System.Drawing.Size(48, 16)
        Me.CheckBox_ddraw_resolution.TabIndex = 10
        Me.CheckBox_ddraw_resolution.Text = "自动"
        Me.CheckBox_ddraw_resolution.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(149, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 12)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "高："
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(61, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 12)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "宽："
        '
        'TextBox_ddraw_width
        '
        Me.TextBox_ddraw_width.Enabled = False
        Me.TextBox_ddraw_width.Location = New System.Drawing.Point(96, 19)
        Me.TextBox_ddraw_width.Name = "TextBox_ddraw_width"
        Me.TextBox_ddraw_width.Size = New System.Drawing.Size(40, 21)
        Me.TextBox_ddraw_width.TabIndex = 9
        Me.TextBox_ddraw_width.Text = "0"
        '
        'TextBox_ddraw_height
        '
        Me.TextBox_ddraw_height.Enabled = False
        Me.TextBox_ddraw_height.Location = New System.Drawing.Point(184, 19)
        Me.TextBox_ddraw_height.Name = "TextBox_ddraw_height"
        Me.TextBox_ddraw_height.Size = New System.Drawing.Size(42, 21)
        Me.TextBox_ddraw_height.TabIndex = 10
        Me.TextBox_ddraw_height.Text = "0"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(534, 352)
        Me.TabControl1.TabIndex = 25
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Button_reg_ddraw)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.Label_height_800)
        Me.TabPage1.Controls.Add(Me.Button_reset)
        Me.TabPage1.Controls.Add(Me.Label_width_1728)
        Me.TabPage1.Controls.Add(Me.GroupBox3)
        Me.TabPage1.Controls.Add(Me.Label_width_640)
        Me.TabPage1.Controls.Add(Me.Button_ok)
        Me.TabPage1.Controls.Add(Me.Label_height_1080)
        Me.TabPage1.Controls.Add(Me.Label_height_540)
        Me.TabPage1.Controls.Add(Me.Label_width_864)
        Me.TabPage1.Controls.Add(Me.GroupBox_ddraw_resolution)
        Me.TabPage1.Controls.Add(Me.Label_height_400)
        Me.TabPage1.Controls.Add(Me.Label_width_1280)
        Me.TabPage1.Controls.Add(Me.GroupBox4)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(526, 326)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "常规与图像"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(526, 326)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "游戏内置选项"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(526, 326)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "快捷键"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Button_reg_ddraw
        '
        Me.Button_reg_ddraw.Location = New System.Drawing.Point(409, 204)
        Me.Button_reg_ddraw.Name = "Button_reg_ddraw"
        Me.Button_reg_ddraw.Size = New System.Drawing.Size(111, 23)
        Me.Button_reg_ddraw.TabIndex = 31
        Me.Button_reg_ddraw.Text = "修复卡屏花屏死机"
        Me.Button_reg_ddraw.UseVisualStyleBackColor = True
        '
        'ra1cfg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(558, 371)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ra1cfg"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "红色警戒配置工具"
        Me.TopMost = True
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox_ddraw_resolution.ResumeLayout(False)
        Me.GroupBox_ddraw_resolution.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RadioButton_gdi As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox_width As TextBox
    Friend WithEvents TextBox_height As TextBox
    Friend WithEvents RadioButton_test_resolution As RadioButton
    Friend WithEvents RadioButton_auto As RadioButton
    Friend WithEvents RadioButton_opengl As RadioButton
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents RadioButton_windows As RadioButton
    Friend WithEvents RadioButton_full As RadioButton
    Friend WithEvents RadioButton_640 As RadioButton
    Friend WithEvents Button_ok As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button_reset As Button
    Friend WithEvents RadioButton_full_win As RadioButton
    Friend WithEvents GroupBox_ddraw_resolution As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox_ddraw_width As TextBox
    Friend WithEvents TextBox_ddraw_height As TextBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents CheckBox_ddraw_resolution As CheckBox
    Friend WithEvents Label_height_400 As Label
    Friend WithEvents Label_width_640 As Label
    Friend WithEvents CheckBox_dos_ratio As CheckBox
    Friend WithEvents Label_height_1080 As Label
    Friend WithEvents Label_width_1728 As Label
    Friend WithEvents RadioButton_1728 As RadioButton
    Friend WithEvents Label_height_540 As Label
    Friend WithEvents Label_width_864 As Label
    Friend WithEvents RadioButton_864 As RadioButton
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label_height_800 As Label
    Friend WithEvents Label_width_1280 As Label
    Friend WithEvents RadioButton_1280 As RadioButton
    Friend WithEvents Label18 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents ComboBox_shader As ComboBox
    Friend WithEvents RadioButton_direct3d9 As RadioButton
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Button_reg_ddraw As Button
End Class
