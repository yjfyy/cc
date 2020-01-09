Public Class ra1cfg

    Dim app_path As String = Application.StartupPath()

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FileIO.FileSystem.CopyFile(".\attach\ddraw.dll", ".\RA\ddraw.dll", True)

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
        System.IO.File.WriteAllText(".\RA\redalert.ini", My.Resources.redalert)
        System.IO.File.WriteAllText(".\RA\ddraw.ini", My.Resources.ddraw)
        read_ini()
        CheckBox_ra1_compat.Checked = False
    End Sub

    Private Sub read_ini()

        Select Case GetINI("Options", "Width", "864", ".\RA\redalert.ini")
            Case "864"
                RadioButton_864.Checked = True
            Case "1728"
                RadioButton_1728.Checked = True
            Case "1920"
                RadioButton_1920.Checked = True
            Case "640"
                RadioButton_640.Checked = True
            Case Else
                RadioButton_test_resolution.Checked = True
                TextBox_width.Text = GetINI("Options", "Width", "640", ".\RA\redalert.ini")
                TextBox_height.Text = GetINI("Options", "Height", "480", ".\RA\redalert.ini")
        End Select

        If GetINI("ddraw", "renderer", "auto", ".\RA\ddraw.ini") = "auto" Then
            RadioButton_auto.Checked = True
        ElseIf GetINI("ddraw", "renderer", "auto", ".\RA\ddraw.ini") = "opengl" Then
            RadioButton_opengl.Checked = True
        Else
            RadioButton_gdi.Checked = True
        End If


        If GetINI("ddraw", "windowed", "false", ".\RA\ddraw.ini") = "true" Then
            If GetINI("ddraw", "fullscreen", "true", ".\RA\ddraw.ini") = "true" Then
                RadioButton_full_win.Checked = True
            Else
                RadioButton_windows.Checked = True
            End If

        Else
            RadioButton_full.Checked = True
        End If

        If GetINI("ra1", "compatibility", "1", ".\config.ini") = "1" Then
            CheckBox_ra1_compat.Checked = True
        Else
            CheckBox_ra1_compat.Checked = False
        End If

    End Sub

    Private Sub save_ini()

        'If RadioButton_full.Checked = True Then
        'WriteINI("ddraw", "width", Screen.PrimaryScreen.Bounds.Width.ToString, ".\RA\ddraw.ini")
        'WriteINI("ddraw", "height", Screen.PrimaryScreen.Bounds.Height.ToString, ".\RA\ddraw.ini")
        'Else
        'WriteINI("ddraw", "width", "0", ".\RA\ddraw.ini")
        'WriteINI("ddraw", "height", "0", ".\RA\ddraw.ini")
        'End If

        If RadioButton_864.Checked = True Then
            WriteINI("Options", "Width", "864", ".\RA\redalert.ini")
            WriteINI("Options", "Height", "540", ".\RA\redalert.ini")
        ElseIf RadioButton_1728.Checked = True Then
            WriteINI("Options", "Width", "1728", ".\RA\redalert.ini")
            WriteINI("Options", "Height", "1080", ".\RA\redalert.ini")
        ElseIf RadioButton_640.Checked = True Then
            WriteINI("Options", "Width", "640", ".\RA\redalert.ini")
            WriteINI("Options", "Height", "480", ".\RA\redalert.ini")
        ElseIf RadioButton_1920.Checked = True Then
            WriteINI("Options", "Width", "1920", ".\RA\redalert.ini")
            WriteINI("Options", "Height", "1080", ".\RA\redalert.ini")
        Else
            WriteINI("Options", "Width", TextBox_width.Text, ".\RA\redalert.ini")
            WriteINI("Options", "Height", TextBox_height.Text, ".\RA\redalert.ini")
        End If

        If RadioButton_auto.Checked = True Then
            WriteINI("ddraw", "renderer", "auto", ".\RA\ddraw.ini")
        ElseIf RadioButton_opengl.Checked = True Then
            WriteINI("ddraw", "renderer", "opengl", ".\RA\ddraw.ini")
        Else
            WriteINI("ddraw", "renderer", "gdi", ".\RA\ddraw.ini")
        End If

        If RadioButton_full.Checked = True Then
            WriteINI("ddraw", "windowed", "false", ".\RA\ddraw.ini")
        End If

        If RadioButton_full_win.Checked = True Then
            WriteINI("ddraw", "fullscreen", "true", ".\RA\ddraw.ini")
            WriteINI("ddraw", "windowed", "true", ".\RA\ddraw.ini")
        End If

        If RadioButton_windows.Checked = True Then
            WriteINI("ddraw", "fullscreen", "false", ".\RA\ddraw.ini")
            WriteINI("ddraw", "windowed", "true", ".\RA\ddraw.ini")
        End If




        WriteINI("ra1", "fristrun", "0", ".\config.ini")

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

    Private Sub ra1cfg_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
End Class