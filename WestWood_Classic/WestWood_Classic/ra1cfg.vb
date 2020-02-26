Public Class ra1cfg

    Dim app_path As String = Application.StartupPath()

    Private Sub Button_ok_Click(sender As Object, e As EventArgs) Handles Button_ok.Click
        'FileIO.FileSystem.CopyFile(".\attach\ddraw.dll", ".\RA\ddraw.dll", True)
        System.IO.File.WriteAllBytes(app_path & "\RA\ddraw.dll", My.Resources.ddraw_dll)
        Form1.Button_ra1_ally.Enabled = True
        Form1.Button_ra1_soviet.Enabled = True
        Form1.Button_ra1_ext_cs.Enabled = True
        Form1.Button_ra1_skirmish.Enabled = True
        Form1.Button_ra1_cncnet.Enabled = True
        Form1.Button_ra1_english.Enabled = True
        Form1.Button_ra1_ext_af.Enabled = True
        Form1.Button_ra1_ext_af_su.Enabled = True

        save_ini()
        Me.Close()
    End Sub

    Private Sub ra1cfg_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        read_ini()
    End Sub

    Private Sub Button_reset_Click(sender As Object, e As EventArgs) Handles Button_reset.Click
        Try
            FileSystem.MkDir("RA")
        Catch ex As Exception

        End Try
        System.IO.File.WriteAllBytes(app_path & "\RA\ddraw.dll", My.Resources.ddraw_dll)
        System.IO.File.WriteAllText(".\RA\redalert.ini", My.Resources.redalert)
        'System.IO.File.WriteAllText(".\RA\ddraw.ini", My.Resources.ddraw, System.Text.Encoding.UTF8)
        System.IO.File.WriteAllText(".\RA\ddraw.ini", My.Resources.ddraw_ini)
        read_ini()
        CheckBox_ra1_compat.Checked = False
    End Sub

    Private Sub read_ini()

        '游戏分辨率框架
        Dim width As String, height As String

        width = GetINI("Options", "width", "640", ".\RA\redalert.ini")
        height = GetINI("Options", "height", "480", ".\RA\redalert.ini")

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

        ddraw_width = GetINI("ra95", "width", "0", ".\RA\ddraw.ini")
        ddraw_height = GetINI("ra95", "height", "0", ".\RA\ddraw.ini")

        If (ddraw_width = "0") And (ddraw_height = "0") Then
            CheckBox_ddraw_resolution.Checked = True
        Else
            CheckBox_ddraw_resolution.Checked = False
            TextBox_ddraw_width.Text = ddraw_width
            TextBox_ddraw_height.Text = ddraw_height
        End If

        '渲染框架
        Dim renderer As String
        renderer = GetINI("ddraw", "renderer", "opengl", ".\RA\ddraw.ini")
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
        shader = GetINI("ddraw", "shader", " ", ".\RA\ddraw.ini")
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
        If GetINI("ddraw", "windowed", "false", ".\RA\ddraw.ini") = "false" Then
            RadioButton_full.Checked = True
        Else
            If GetINI("ddraw", "fullscreen", "true", ".\RA\ddraw.ini") = "true" Then
                RadioButton_full_win.Checked = True
            Else
                RadioButton_windows.Checked = True
            End If
        End If

        '设置兼容性
        If GetINI("ra1", "compatibility", "0", ".\config.ini") = "0" Then
            CheckBox_ra1_compat.Checked = False
        Else
            CheckBox_ra1_compat.Checked = True
        End If

    End Sub

    Private Sub save_ini()

        '保存游戏分辨率
        If RadioButton_640.Checked = True Then
            WriteINI("Options", "Width", Label_width_640.Text, ".\RA\redalert.ini")
            WriteINI("Options", "Height", Label_height_400.Text, ".\RA\redalert.ini")
        End If

        If RadioButton_1280.Checked = True Then
            WriteINI("Options", "Width", Label_width_1280.Text, ".\RA\redalert.ini")
            WriteINI("Options", "Height", Label_height_800.Text, ".\RA\redalert.ini")
        End If

        If RadioButton_864.Checked = True Then
            WriteINI("Options", "Width", Label_width_864.Text, ".\RA\redalert.ini")
            WriteINI("Options", "Height", Label_height_540.Text, ".\RA\redalert.ini")
        End If

        If RadioButton_1728.Checked = True Then
            WriteINI("Options", "Width", Label_width_1728.Text, ".\RA\redalert.ini")
            WriteINI("Options", "Height", Label_height_1080.Text, ".\RA\redalert.ini")
        End If

        If RadioButton_test_resolution.Checked = True Then
            WriteINI("Options", "Width", TextBox_width.Text, ".\RA\redalert.ini")
            WriteINI("Options", "Height", TextBox_height.Text, ".\RA\redalert.ini")
        End If

        '保存ddraw分辨率

        WriteINI("ra95", "width", TextBox_ddraw_width.Text, ".\RA\ddraw.ini")
        WriteINI("ra95", "height", TextBox_ddraw_height.Text, ".\RA\ddraw.ini")

        '渲染模式
        If RadioButton_auto.Checked = True Then
            WriteINI("ddraw", "renderer", "auto", ".\RA\ddraw.ini")
        End If

        If RadioButton_opengl.Checked = True Then
            WriteINI("ddraw", "renderer", "opengl", ".\RA\ddraw.ini")
        End If

        If RadioButton_gdi.Checked = True Then
            WriteINI("ddraw", "renderer", "gdi", ".\RA\ddraw.ini")
        End If

        If RadioButton_direct3d9.Checked = True Then
            WriteINI("ddraw", "renderer", "direct3d9", ".\RA\ddraw.ini")
        End If

        Select Case ComboBox_shader.SelectedIndex
            Case 1
                WriteINI("ddraw", "shader", "Shaders\bilinear.glsl", ".\RA\ddraw.ini")
            Case 2
                WriteINI("ddraw", "shader", "Shaders\cubic.glsl", ".\RA\ddraw.ini")
            Case 3
                WriteINI("ddraw", "shader", "Shaders\bright.glsl", ".\RA\ddraw.ini")
            Case 4
                WriteINI("ddraw", "shader", "Shaders\crt-lottes-fast.glsl", ".\RA\ddraw.ini")
            Case 5
                WriteINI("ddraw", "shader", "Shaders\crt-lottes-fast-no-warp.glsl", ".\RA\ddraw.ini")
            Case 6
                WriteINI("ddraw", "shader", "Shaders\scanline.glsl", ".\RA\ddraw.ini")
            Case 7
                WriteINI("ddraw", "shader", "Shaders\xbr-lv2.glsl", ".\RA\ddraw.ini")
            Case 8
                WriteINI("ddraw", "shader", "Shaders\xbrz-freescale.glsl", ".\RA\ddraw.ini")
            Case Else
                WriteINI("ddraw", "shader", "", ".\RA\ddraw.ini")
        End Select


        '显示模式

        If RadioButton_full.Checked = True Then
            WriteINI("ddraw", "windowed", "false", ".\RA\ddraw.ini")
            WriteINI("ddraw", "fullscreen", "true", ".\RA\ddraw.ini")
        End If

        If RadioButton_full_win.Checked = True Then
            WriteINI("ddraw", "fullscreen", "true", ".\RA\ddraw.ini")
            WriteINI("ddraw", "windowed", "true", ".\RA\ddraw.ini")
        End If

        If RadioButton_windows.Checked = True Then
            WriteINI("ddraw", "fullscreen", "false", ".\RA\ddraw.ini")
            WriteINI("ddraw", "windowed", "true", ".\RA\ddraw.ini")
        End If

        '兼容性在兼容性调整中保存

        '已运行过
        WriteINI("ra1", "fristrun", "0", ".\config.ini")

    End Sub

    Private Sub RadioButton_test_resolution_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_test_resolution.CheckedChanged, RadioButton_test_resolution.Click
        Dim width As Integer, height As Integer
        width = Screen.PrimaryScreen.Bounds.Width
        height = Screen.PrimaryScreen.Bounds.Height

        If height / 0.625 < width Then
            width = Int(height / 0.625)

        Else
            height = width / 1.6
        End If

        If RadioButton_test_resolution.Checked = True Then
            TextBox_width.Enabled = True
            TextBox_height.Enabled = True

            TextBox_width.Text = width
            TextBox_height.Text = height

        Else
            TextBox_width.Enabled = False
            TextBox_height.Enabled = False
        End If
    End Sub


    Private Sub CheckBox_ra1_compat_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_ra1_compat.CheckedChanged
        If CheckBox_ra1_compat.Checked = True Then

            WriteINI("ra1", "compatibility", "1", ".\config.ini")

            If Form1.RadioButton_win10.Checked Then
                Dim key As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("Software\Microsoft\Windows NT\CurrentVersion\AppCompatFlags", True)
                Dim subkey As Microsoft.Win32.RegistryKey
                subkey = key.CreateSubKey("Layers")
                subkey.SetValue(app_path & "\RA\RA95.exe", "~ WIN7RTM", Microsoft.Win32.RegistryValueKind.String)

            ElseIf Form1.RadioButton_win7.Checked Then
                Dim key As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("Software\Microsoft\Windows NT\CurrentVersion\AppCompatFlags", True)
                Dim subkey As Microsoft.Win32.RegistryKey
                subkey = key.CreateSubKey("Layers")
                subkey.SetValue(app_path & "\RA\RA95.exe", "", Microsoft.Win32.RegistryValueKind.String)
            Else

            End If
        Else
            WriteINI("ra1", "compatibility", "0", ".\config.ini")
            If Form1.RadioButton_winxp.Checked = False Then

                Dim key As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("Software\Microsoft\Windows NT\CurrentVersion\AppCompatFlags", True)
                Dim subkey As Microsoft.Win32.RegistryKey
                subkey = key.CreateSubKey("Layers")

                subkey.SetValue(app_path & "\RA\RA95.exe", "", Microsoft.Win32.RegistryValueKind.String)
            End If


        End If
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


End Class