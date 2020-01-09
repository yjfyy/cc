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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox_width = New System.Windows.Forms.TextBox()
        Me.TextBox_height = New System.Windows.Forms.TextBox()
        Me.RadioButton_test_resolution = New System.Windows.Forms.RadioButton()
        Me.RadioButton_1920 = New System.Windows.Forms.RadioButton()
        Me.RadioButton_1728 = New System.Windows.Forms.RadioButton()
        Me.RadioButton_864 = New System.Windows.Forms.RadioButton()
        Me.RadioButton_auto = New System.Windows.Forms.RadioButton()
        Me.RadioButton_opengl = New System.Windows.Forms.RadioButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.RadioButton_windows = New System.Windows.Forms.RadioButton()
        Me.RadioButton_full = New System.Windows.Forms.RadioButton()
        Me.RadioButton_640 = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.RadioButton_full_win = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button_reset = New System.Windows.Forms.Button()
        Me.CheckBox_ra1_compat = New System.Windows.Forms.CheckBox()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'RadioButton_gdi
        '
        Me.RadioButton_gdi.AutoSize = True
        Me.RadioButton_gdi.Location = New System.Drawing.Point(6, 42)
        Me.RadioButton_gdi.Name = "RadioButton_gdi"
        Me.RadioButton_gdi.Size = New System.Drawing.Size(179, 16)
        Me.RadioButton_gdi.TabIndex = 0
        Me.RadioButton_gdi.TabStop = True
        Me.RadioButton_gdi.Text = "软件（GDI,可避免滚屏过快）"
        Me.RadioButton_gdi.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 194)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 24)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "推荐基于1920x1080" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "桌面分辨率"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 173)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 12)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "高："
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 146)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 12)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "宽："
        '
        'TextBox_width
        '
        Me.TextBox_width.Enabled = False
        Me.TextBox_width.Location = New System.Drawing.Point(41, 143)
        Me.TextBox_width.Name = "TextBox_width"
        Me.TextBox_width.Size = New System.Drawing.Size(72, 21)
        Me.TextBox_width.TabIndex = 5
        '
        'TextBox_height
        '
        Me.TextBox_height.Enabled = False
        Me.TextBox_height.Location = New System.Drawing.Point(40, 170)
        Me.TextBox_height.Name = "TextBox_height"
        Me.TextBox_height.Size = New System.Drawing.Size(72, 21)
        Me.TextBox_height.TabIndex = 6
        '
        'RadioButton_test_resolution
        '
        Me.RadioButton_test_resolution.AutoSize = True
        Me.RadioButton_test_resolution.Location = New System.Drawing.Point(6, 108)
        Me.RadioButton_test_resolution.Name = "RadioButton_test_resolution"
        Me.RadioButton_test_resolution.Size = New System.Drawing.Size(107, 28)
        Me.RadioButton_test_resolution.TabIndex = 4
        Me.RadioButton_test_resolution.TabStop = True
        Me.RadioButton_test_resolution.Text = "自动检测并推荐" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "（可手动更改）"
        Me.RadioButton_test_resolution.UseVisualStyleBackColor = True
        '
        'RadioButton_1920
        '
        Me.RadioButton_1920.AutoSize = True
        Me.RadioButton_1920.Location = New System.Drawing.Point(6, 86)
        Me.RadioButton_1920.Name = "RadioButton_1920"
        Me.RadioButton_1920.Size = New System.Drawing.Size(77, 16)
        Me.RadioButton_1920.TabIndex = 3
        Me.RadioButton_1920.TabStop = True
        Me.RadioButton_1920.Text = "1920x1080"
        Me.RadioButton_1920.UseVisualStyleBackColor = True
        '
        'RadioButton_1728
        '
        Me.RadioButton_1728.AutoSize = True
        Me.RadioButton_1728.ForeColor = System.Drawing.Color.Red
        Me.RadioButton_1728.Location = New System.Drawing.Point(6, 64)
        Me.RadioButton_1728.Name = "RadioButton_1728"
        Me.RadioButton_1728.Size = New System.Drawing.Size(119, 16)
        Me.RadioButton_1728.TabIndex = 2
        Me.RadioButton_1728.TabStop = True
        Me.RadioButton_1728.Text = "1728x1080(推荐）"
        Me.RadioButton_1728.UseVisualStyleBackColor = True
        '
        'RadioButton_864
        '
        Me.RadioButton_864.AutoSize = True
        Me.RadioButton_864.ForeColor = System.Drawing.Color.Red
        Me.RadioButton_864.Location = New System.Drawing.Point(6, 42)
        Me.RadioButton_864.Name = "RadioButton_864"
        Me.RadioButton_864.Size = New System.Drawing.Size(101, 16)
        Me.RadioButton_864.TabIndex = 1
        Me.RadioButton_864.TabStop = True
        Me.RadioButton_864.Text = "864x540(推荐)"
        Me.RadioButton_864.UseVisualStyleBackColor = True
        '
        'RadioButton_auto
        '
        Me.RadioButton_auto.AutoSize = True
        Me.RadioButton_auto.Location = New System.Drawing.Point(6, 20)
        Me.RadioButton_auto.Name = "RadioButton_auto"
        Me.RadioButton_auto.Size = New System.Drawing.Size(191, 16)
        Me.RadioButton_auto.TabIndex = 2
        Me.RadioButton_auto.TabStop = True
        Me.RadioButton_auto.Text = "自动（优先OpenGL,失败后GDI）"
        Me.RadioButton_auto.UseVisualStyleBackColor = True
        '
        'RadioButton_opengl
        '
        Me.RadioButton_opengl.AutoSize = True
        Me.RadioButton_opengl.Location = New System.Drawing.Point(6, 64)
        Me.RadioButton_opengl.Name = "RadioButton_opengl"
        Me.RadioButton_opengl.Size = New System.Drawing.Size(107, 16)
        Me.RadioButton_opengl.TabIndex = 1
        Me.RadioButton_opengl.TabStop = True
        Me.RadioButton_opengl.Text = "硬件（OpenGL）"
        Me.RadioButton_opengl.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.RadioButton_auto)
        Me.GroupBox4.Controls.Add(Me.RadioButton_opengl)
        Me.GroupBox4.Controls.Add(Me.RadioButton_gdi)
        Me.GroupBox4.Location = New System.Drawing.Point(175, 12)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(202, 92)
        Me.GroupBox4.TabIndex = 10
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "渲染模式"
        '
        'RadioButton_windows
        '
        Me.RadioButton_windows.AutoSize = True
        Me.RadioButton_windows.Location = New System.Drawing.Point(3, 61)
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
        Me.RadioButton_full.Location = New System.Drawing.Point(3, 17)
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
        Me.RadioButton_640.Location = New System.Drawing.Point(6, 20)
        Me.RadioButton_640.Name = "RadioButton_640"
        Me.RadioButton_640.Size = New System.Drawing.Size(65, 16)
        Me.RadioButton_640.TabIndex = 0
        Me.RadioButton_640.TabStop = True
        Me.RadioButton_640.Text = "640x480"
        Me.RadioButton_640.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(165, 260)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "确定"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.RadioButton_full_win)
        Me.GroupBox3.Controls.Add(Me.RadioButton_windows)
        Me.GroupBox3.Controls.Add(Me.RadioButton_full)
        Me.GroupBox3.Location = New System.Drawing.Point(175, 110)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(95, 93)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "显示模式"
        '
        'RadioButton_full_win
        '
        Me.RadioButton_full_win.AutoSize = True
        Me.RadioButton_full_win.Location = New System.Drawing.Point(3, 39)
        Me.RadioButton_full_win.Name = "RadioButton_full_win"
        Me.RadioButton_full_win.Size = New System.Drawing.Size(71, 16)
        Me.RadioButton_full_win.TabIndex = 2
        Me.RadioButton_full_win.TabStop = True
        Me.RadioButton_full_win.Text = "全屏窗口"
        Me.RadioButton_full_win.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TextBox_width)
        Me.GroupBox1.Controls.Add(Me.TextBox_height)
        Me.GroupBox1.Controls.Add(Me.RadioButton_test_resolution)
        Me.GroupBox1.Controls.Add(Me.RadioButton_1920)
        Me.GroupBox1.Controls.Add(Me.RadioButton_1728)
        Me.GroupBox1.Controls.Add(Me.RadioButton_864)
        Me.GroupBox1.Controls.Add(Me.RadioButton_640)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(129, 227)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "游戏分辨率："
        '
        'Button_reset
        '
        Me.Button_reset.Location = New System.Drawing.Point(32, 260)
        Me.Button_reset.Name = "Button_reset"
        Me.Button_reset.Size = New System.Drawing.Size(93, 23)
        Me.Button_reset.TabIndex = 6
        Me.Button_reset.Text = "重置全部设定"
        Me.Button_reset.UseVisualStyleBackColor = True
        '
        'CheckBox_ra1_compat
        '
        Me.CheckBox_ra1_compat.AutoSize = True
        Me.CheckBox_ra1_compat.Location = New System.Drawing.Point(178, 213)
        Me.CheckBox_ra1_compat.Name = "CheckBox_ra1_compat"
        Me.CheckBox_ra1_compat.Size = New System.Drawing.Size(108, 16)
        Me.CheckBox_ra1_compat.TabIndex = 7
        Me.CheckBox_ra1_compat.Text = "自动设置兼容性"
        Me.CheckBox_ra1_compat.UseVisualStyleBackColor = True
        '
        'ra1cfg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(399, 307)
        Me.Controls.Add(Me.CheckBox_ra1_compat)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button_reset)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ra1cfg"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "红色警戒配置工具"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RadioButton_gdi As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox_width As TextBox
    Friend WithEvents TextBox_height As TextBox
    Friend WithEvents RadioButton_test_resolution As RadioButton
    Friend WithEvents RadioButton_1920 As RadioButton
    Friend WithEvents RadioButton_1728 As RadioButton
    Friend WithEvents RadioButton_864 As RadioButton
    Friend WithEvents RadioButton_auto As RadioButton
    Friend WithEvents RadioButton_opengl As RadioButton
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents RadioButton_windows As RadioButton
    Friend WithEvents RadioButton_full As RadioButton
    Friend WithEvents RadioButton_640 As RadioButton
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button_reset As Button
    Friend WithEvents CheckBox_ra1_compat As CheckBox
    Friend WithEvents RadioButton_full_win As RadioButton
End Class
