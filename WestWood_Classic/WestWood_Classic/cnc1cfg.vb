Public Class cnc1cfg

    Dim app_path As String = Application.StartupPath()

    Private Sub cnc1cfg_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Form1.Button_cnc1_GDI_miss.Enabled = False
        Form1.Button_cnc1_NOD_miss.Enabled = False
        Form1.Button_cnc1_ext.Enabled = False
        Form1.Button_cnc1_tv.Enabled = False
        Form1.Button_cnc1_cncnet.Enabled = False
        Form1.Button_cnc1_english.Enabled = False
        Read_ini()
    End Sub



    Private Sub Button_reset_Click(sender As Object, e As EventArgs) Handles Button_reset.Click
        Try
            FileSystem.MkDir("CnC95")
        Catch ex As Exception

        End Try
        System.IO.File.WriteAllBytes(app_path & "\CnC95\ddraw.dll", My.Resources.ddraw_dll)
        System.IO.File.WriteAllText(".\CnC95\conquer.ini", My.Resources.conquer)
        'System.IO.File.WriteAllText(".\CnC95\ddraw.ini", My.Resources.ddraw, System.Text.Encoding.UTF8)
        System.IO.File.WriteAllText(".\CnC95\ddraw.ini", My.Resources.ddraw_ini)
        Read_ini()
        'CheckBox_cc1_compat.Checked = False
        RadioButton_eva_chi.Checked = True
    End Sub

    Private Sub Read_ini()

        '游戏分辨率框架
        Dim width As String, height As String

        width = GetINI("Video", "width", "640", ".\CnC95\conquer.ini")
        height = GetINI("Video", "height", "480", ".\CnC95\conquer.ini")

        RadioButton_test_resolution.Checked = True
        CheckBox_dos_ratio.Checked = True

        If width = "640" Then
            Select Case height
                Case "400"
                    CheckBox_dos_ratio.Checked = True
                    RadioButton_640.Checked = True
                Case "480"
                    CheckBox_dos_ratio.Checked = False
                    RadioButton_640.Checked = True
                Case Else
                    RadioButton_test_resolution.Checked = True
                    TextBox_width.Text = width
                    TextBox_height.Text = height
            End Select
        End If

        If width = "1280" Then
            Select Case height
                Case "800"
                    CheckBox_dos_ratio.Checked = True
                    RadioButton_1280.Checked = True
                Case "960"
                    CheckBox_dos_ratio.Checked = False
                    RadioButton_1280.Checked = True
                Case Else
                    RadioButton_test_resolution.Checked = True
                    TextBox_width.Text = width
                    TextBox_height.Text = height
            End Select
        End If

        If height = "540" Then
            Select Case width
                Case "864"
                    CheckBox_dos_ratio.Checked = True
                    RadioButton_864.Checked = True
                Case "960"
                    CheckBox_dos_ratio.Checked = False
                    RadioButton_864.Checked = True
                Case Else
                    RadioButton_test_resolution.Checked = True
                    TextBox_width.Text = width
                    TextBox_height.Text = height
            End Select
        End If

        If height = "1080" Then
            Select Case width
                Case "1728"
                    CheckBox_dos_ratio.Checked = True
                    RadioButton_1728.Checked = True
                Case "1920"
                    CheckBox_dos_ratio.Checked = False
                    RadioButton_1728.Checked = True
                Case Else
                    RadioButton_test_resolution.Checked = True
                    TextBox_width.Text = width
                    TextBox_height.Text = height
            End Select
        End If

        'ddraw分辨率框架
        Dim ddraw_width As String, ddraw_height As String

        ddraw_width = GetINI("C&C95", "width", "0", ".\CnC95\ddraw.ini")
        ddraw_height = GetINI("C&C95", "height", "0", ".\CnC95\ddraw.ini")

        If (ddraw_width = "0") And (ddraw_height = "0") Then
            CheckBox_ddraw_resolution.Checked = True
        Else
            CheckBox_ddraw_resolution.Checked = False
            TextBox_ddraw_width.Text = ddraw_width
            TextBox_ddraw_height.Text = ddraw_height
        End If

        '渲染框架
        Dim renderer As String
        renderer = GetINI("ddraw", "renderer", "opengl", ".\CnC95\ddraw.ini")
        Select Case renderer
            Case "opengl"
                RadioButton_opengl.Checked = True
            Case "auto"
                RadioButton_auto.Checked = True
            Case "gdi"
                RadioButton_gdi.Checked = True
            Case "direct3d9"
                RadioButton_direct3d9.Checked = True
        End Select

        Dim shader As String
        shader = GetINI("ddraw", "shader", " ", ".\CnC95\ddraw.ini")
        Select Case shader
            Case "Shaders\bilinear.glsl"
                ComboBox_shader.SelectedIndex = 1
            Case "Shaders\bright.glsl"
                ComboBox_shader.SelectedIndex = 3
            Case "Shaders\crt-lottes-fast.glsl"
                ComboBox_shader.SelectedIndex = 4
            Case "Shaders\crt-lottes-fast-no-warp.glsl"
                ComboBox_shader.SelectedIndex = 5
            Case "Shaders\cubic.glsl"
                ComboBox_shader.SelectedIndex = 2
            Case "Shaders\scanline.glsl"
                ComboBox_shader.SelectedIndex = 6
            Case "Shaders\xbr-lv2.glsl"
                ComboBox_shader.SelectedIndex = 7
            Case "Shaders\xbrz-freescale.glsl"
                ComboBox_shader.SelectedIndex = 8
            Case Else
                ComboBox_shader.SelectedIndex = 0
        End Select

        '显示模式
        If GetINI("ddraw", "windowed", "false", ".\CnC95\ddraw.ini") = "false" Then
            RadioButton_full.Checked = True
        Else
            If GetINI("ddraw", "fullscreen", "true", ".\CnC95\ddraw.ini") = "true" Then
                RadioButton_full_win.Checked = True
            Else
                RadioButton_windows.Checked = True
            End If
        End If

        '设置兼容性
        'If GetINI("cnc1", "compatibility", "0", ".\config.ini") = "0" Then
        '    CheckBox_cc1_compat.Checked = False
        'Else
        '    CheckBox_cc1_compat.Checked = True
        'End If

        'eva语音
        If GetINI("cnc1", "eva", "chi", ".\config.ini") = "chi" Then
            RadioButton_eva_chi.Checked = True
        Else
            RadioButton_eva_eng.Checked = True
        End If

        '单核cpu
        If GetINI("C&C95", "singlecpu", "true", ".\CnC95\ddraw.ini") = "true" Then
            CheckBox_singlecpu.Checked = True
        Else
            CheckBox_singlecpu.Checked = False
        End If

    End Sub

    Private Sub save_ini()

        '保存游戏分辨率
        If RadioButton_640.Checked = True Then
            WriteINI("Video", "Width", Label_width_640.Text, ".\CnC95\conquer.ini")
            WriteINI("Video", "Height", Label_height_400.Text, ".\CnC95\conquer.ini")
        End If

        If RadioButton_1280.Checked = True Then
            WriteINI("Video", "Width", Label_width_1280.Text, ".\CnC95\conquer.ini")
            WriteINI("Video", "Height", Label_height_800.Text, ".\CnC95\conquer.ini")
        End If

        If RadioButton_864.Checked = True Then
            WriteINI("Video", "Width", Label_width_864.Text, ".\CnC95\conquer.ini")
            WriteINI("Video", "Height", Label_height_540.Text, ".\CnC95\conquer.ini")
        End If

        If RadioButton_1728.Checked = True Then
            WriteINI("Video", "Width", Label_width_1728.Text, ".\CnC95\conquer.ini")
            WriteINI("Video", "Height", Label_height_1080.Text, ".\CnC95\conquer.ini")
        End If

        If RadioButton_test_resolution.Checked = True Then
            WriteINI("Video", "Width", TextBox_width.Text, ".\CnC95\conquer.ini")
            WriteINI("Video", "Height", TextBox_height.Text, ".\CnC95\conquer.ini")
        End If

        '保存ddraw分辨率
        WriteINI("C&C95", "width", TextBox_ddraw_width.Text, ".\CnC95\ddraw.ini")
        WriteINI("C&C95", "height", TextBox_ddraw_height.Text, ".\CnC95\ddraw.ini")

        '渲染模式
        If RadioButton_auto.Checked = True Then
            WriteINI("ddraw", "renderer", "auto", ".\CnC95\ddraw.ini")
        End If

        If RadioButton_opengl.Checked = True Then
            WriteINI("ddraw", "renderer", "opengl", ".\CnC95\ddraw.ini")
        End If

        If RadioButton_gdi.Checked = True Then
            WriteINI("ddraw", "renderer", "gdi", ".\CnC95\ddraw.ini")
        End If

        If RadioButton_direct3d9.Checked = True Then
            WriteINI("ddraw", "renderer", "direct3d9", ".\CnC95\ddraw.ini")
        End If

        Select Case ComboBox_shader.SelectedIndex
            Case 1
                WriteINI("ddraw", "shader", "Shaders\bilinear.glsl", ".\CnC95\ddraw.ini")
            Case 2
                WriteINI("ddraw", "shader", "Shaders\cubic.glsl", ".\CnC95\ddraw.ini")
            Case 3
                WriteINI("ddraw", "shader", "Shaders\bright.glsl", ".\CnC95\ddraw.ini")
            Case 4
                WriteINI("ddraw", "shader", "Shaders\crt-lottes-fast.glsl", ".\CnC95\ddraw.ini")
            Case 5
                WriteINI("ddraw", "shader", "Shaders\crt-lottes-fast-no-warp.glsl", ".\CnC95\ddraw.ini")
            Case 6
                WriteINI("ddraw", "shader", "Shaders\scanline.glsl", ".\CnC95\ddraw.ini")
            Case 7
                WriteINI("ddraw", "shader", "Shaders\xbr-lv2.glsl", ".\CnC95\ddraw.ini")
            Case 8
                WriteINI("ddraw", "shader", "Shaders\xbrz-freescale.glsl", ".\CnC95\ddraw.ini")
            Case Else
                WriteINI("ddraw", "shader", "", ".\CnC95\ddraw.ini")
        End Select

        '显示模式
        If RadioButton_full.Checked = True Then
            WriteINI("ddraw", "windowed", "false", ".\CnC95\ddraw.ini")
            WriteINI("ddraw", "fullscreen", "true", ".\CnC95\ddraw.ini")
        End If

        If RadioButton_full_win.Checked = True Then
            WriteINI("ddraw", "windowed", "true", ".\CnC95\ddraw.ini")
            WriteINI("ddraw", "fullscreen", "true", ".\CnC95\ddraw.ini")
        End If

        If RadioButton_windows.Checked = True Then
            WriteINI("ddraw", "fullscreen", "false", ".\CnC95\ddraw.ini")
            WriteINI("ddraw", "windowed", "true", ".\CnC95\ddraw.ini")
        End If

        If RadioButton_eva_chi.Checked = True Then
            WriteINI("cnc1", "eva", "chi", ".\config.ini")
        Else
            WriteINI("cnc1", "eva", "eng", ".\config.ini")
        End If

        '已运行过
        WriteINI("cnc1", "fristrun", "0", ".\config.ini")

        '单核cpu
        If CheckBox_singlecpu.Checked = True Then
            WriteINI("C&C95", "singlecpu", "true", ".\CnC95\ddraw.ini")
        Else
            WriteINI("C&C95", "singlecpu", "false", ".\CnC95\ddraw.ini")
        End If


    End Sub

    Private Sub RadioButton_test_resolution_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_test_resolution.CheckedChanged, RadioButton_test_resolution.Click
        If RadioButton_test_resolution.Checked = True Then
            TextBox_height.Enabled = True
            TextBox_width.Enabled = True
            TextBox_height.Text = Screen.PrimaryScreen.Bounds.Height.ToString
            TextBox_width.Text = (Screen.PrimaryScreen.Bounds.Height * 1.6).ToString
        Else
            TextBox_height.Enabled = False
            TextBox_width.Enabled = False
        End If
    End Sub

    'Private Sub CheckBox_cc1_compat_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_cc1_compat.CheckedChanged
    '    If CheckBox_cc1_compat.Checked = True Then

    '        WriteINI("cnc1", "compatibility", "1", ".\config.ini")

    '        If Form1.RadioButton_win10.Checked Then
    '            Dim key As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("Software\Microsoft\Windows NT\CurrentVersion\AppCompatFlags", True)
    '            Dim subkey As Microsoft.Win32.RegistryKey
    '            subkey = key.CreateSubKey("Layers")
    '            subkey.SetValue(app_path & "\CnC95\C&C95.exe", "~ HIGHDPIAWARE WIN7RTM", Microsoft.Win32.RegistryValueKind.String)

    '        ElseIf Form1.RadioButton_win7.Checked Then
    '            Dim key As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("Software\Microsoft\Windows NT\CurrentVersion\AppCompatFlags", True)
    '            Dim subkey As Microsoft.Win32.RegistryKey
    '            subkey = key.CreateSubKey("Layers")
    '            subkey.SetValue(app_path & "\CnC95\C&C95.exe", "WIN98", Microsoft.Win32.RegistryValueKind.String)

    '        End If
    '    Else
    '        WriteINI("cnc1", "compatibility", "0", ".\config.ini")
    '        If Form1.RadioButton_winxp.Checked = False Then
    '            Dim key As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("Software\Microsoft\Windows NT\CurrentVersion\AppCompatFlags", True)
    '            Dim subkey As Microsoft.Win32.RegistryKey
    '            subkey = key.CreateSubKey("Layers")

    '            subkey.SetValue(app_path & "\CnC95\C&C95.exe", "", Microsoft.Win32.RegistryValueKind.String)
    '        End If
    '    End If
    'End Sub



    Private Sub Button_ok_Click(sender As Object, e As EventArgs) Handles Button_ok.Click

        '复制主界面背景

        If RadioButton_1728.Checked Then
            If CheckBox_dos_ratio.Checked = True Then
                System.IO.File.WriteAllBytes(app_path & "\CnC95\xtitle.pcx", My.Resources.xtitle_1728)
            Else
                System.IO.File.WriteAllBytes(app_path & "\CnC95\xtitle.pcx", My.Resources.xtitle_1920)
            End If

        End If

        If RadioButton_864.Checked Then
            If CheckBox_dos_ratio.Checked = True Then
                System.IO.File.WriteAllBytes(app_path & "\CnC95\xtitle.pcx", My.Resources.xtitle_864)
            Else
                System.IO.File.WriteAllBytes(app_path & "\CnC95\xtitle.pcx", My.Resources.xtitle_960)
            End If
        End If

        If RadioButton_1280.Checked Then
            If CheckBox_dos_ratio.Checked = True Then
                System.IO.File.WriteAllBytes(app_path & "\CnC95\xtitle.pcx", My.Resources.xtitle_1280)
            Else
                System.IO.File.WriteAllBytes(app_path & "\CnC95\xtitle.pcx", My.Resources.xtitle_1280x960)
            End If
        End If

        If RadioButton_test_resolution.Checked = True Then
            Try
                System.IO.File.Delete(app_path & "\CnC95\xtitle.pcx")
            Catch ex As Exception

            End Try
        End If


        '输出中文或英文语音
        If RadioButton_eva_chi.Checked = True Then
            'FileIO.FileSystem.CopyFile("attach\speecchi.mix", ".\CnC95\speecchi.mix", True)
            System.IO.File.WriteAllBytes(app_path & "\CnC95\speech.mix", My.Resources.speecchi)
        Else
            System.IO.File.WriteAllBytes(app_path & "\CnC95\speech.mix", My.Resources.speech)
            'FileIO.FileSystem.CopyFile("CnC95\speech.mix", ".\CnC95\speecchi.mix", True)
        End If

        '输出ddraw
        System.IO.File.WriteAllBytes(app_path & "\CnC95\ddraw.dll", My.Resources.ddraw_dll)

        '允许运行游戏
        Form1.Button_cnc1_GDI_miss.Enabled = True
        Form1.Button_cnc1_NOD_miss.Enabled = True
        Form1.Button_cnc1_ext.Enabled = True
        Form1.Button_cnc1_tv.Enabled = True
        Form1.Button_cnc1_cncnet.Enabled = True
        Form1.Button_cnc1_english.Enabled = True

        '保存
        save_ini()

        Me.Close()
    End Sub

    Private Sub RadioButton_1728_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_1728.CheckedChanged

    End Sub

    Private Sub RadioButton_1280_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_1280.CheckedChanged

    End Sub

    Private Sub CheckBox_dos_ratio_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_dos_ratio.CheckedChanged
        If CheckBox_dos_ratio.Checked = True Then
            '    CheckBox_ddraw_resolution.Checked = False
            RadioButton_640.Text = "640x400"
            Label_width_640.Text = 640
            Label_height_400.Text = 400

            RadioButton_1280.Text = "1280x800"
            Label_width_1280.Text = 1280
            Label_height_800.Text = 800

            RadioButton_864.Text = "864x540（推荐）"
            Label_width_864.Text = 864
            Label_height_540.Text = 540

            RadioButton_1728.Text = "1728x1080（推荐）"
            Label_width_1728.Text = 1728
            Label_height_1080.Text = 1080

        Else
            '   CheckBox_ddraw_resolution.Checked = True
            RadioButton_640.Text = "640x480"
            Label_width_640.Text = 640
            Label_height_400.Text = 480

            RadioButton_1280.Text = "1280x960"
            Label_width_1280.Text = 1280
            Label_height_800.Text = 960

            RadioButton_864.Text = "960x540（推荐）"
            Label_width_864.Text = 960
            Label_height_540.Text = 540

            RadioButton_1728.Text = "1920x1080（推荐）"
            Label_width_1728.Text = 1920
            Label_height_1080.Text = 1080
        End If
    End Sub

    Private Sub CheckBox_ddraw_resolution_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_ddraw_resolution.CheckedChanged
        If CheckBox_ddraw_resolution.Checked = True Then

            TextBox_ddraw_height.Enabled = False
            TextBox_ddraw_height.Text = 0
            TextBox_ddraw_width.Enabled = False
            TextBox_ddraw_width.Text = 0
        Else

            TextBox_ddraw_height.Enabled = True
            TextBox_ddraw_width.Enabled = True
            TextBox_ddraw_height.Text = Screen.PrimaryScreen.Bounds.Height.ToString
            TextBox_ddraw_width.Text = (Screen.PrimaryScreen.Bounds.Width).ToString

        End If
    End Sub

    Private Sub RadioButton_opengl_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_opengl.CheckedChanged
        If RadioButton_opengl.Checked = True Then
            ComboBox_shader.Enabled = True
        Else
            ComboBox_shader.Enabled = False
        End If
    End Sub

    Private Sub RadioButton_eva_eng_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_eva_eng.CheckedChanged

    End Sub

    Private Sub RadioButton_eva_chi_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_eva_chi.CheckedChanged

    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub cnc1cfg_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cnc1cfg_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        If GetINI("cnc1", "fristrun", "1", ".\config.ini") = "0" Then
            Form1.Button_cnc1_GDI_miss.Enabled = True
            Form1.Button_cnc1_NOD_miss.Enabled = True
            Form1.Button_cnc1_ext.Enabled = True
            Form1.Button_cnc1_tv.Enabled = True
            Form1.Button_cnc1_cncnet.Enabled = True
            Form1.Button_cnc1_english.Enabled = True
        End If

    End Sub


End Class