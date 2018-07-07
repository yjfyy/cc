Public Class cnc1cfg

    Dim app_path As String = Application.StartupPath()

    Private Sub cnc1cfg_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Read_ini()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If RadioButton_1728.Checked Then
            FileIO.FileSystem.CopyFile("attach\xtitle.1728", ".\CnC95\xtitle.pcx", True)
        ElseIf RadioButton_864.Checked Then
            FileIO.FileSystem.CopyFile("attach\xtitle.864", ".\CnC95\xtitle.pcx", True)
        ElseIf RadioButton_1920.Checked Then
            FileIO.FileSystem.CopyFile("attach\xtitle.1920", ".\CnC95\xtitle.pcx", True)
        Else
            Try
                FileIO.FileSystem.DeleteFile(".\CnC95\xtitle.pcx")
            Catch ex As Exception

            End Try
        End If

        If RadioButton_eva_chi.Checked = True Then
            FileIO.FileSystem.CopyFile("attach\speecchi.mix", ".\CnC95\speecchi.mix", True)
        Else
            FileIO.FileSystem.CopyFile("CnC95\speech.mix", ".\CnC95\speecchi.mix", True)
        End If
        FileIO.FileSystem.CopyFile("attach\ddraw.dll", ".\CnC95\ddraw.dll", True)
        save_ini()
        Me.Close()
    End Sub

    Private Sub Button_reset_Click(sender As Object, e As EventArgs) Handles Button_reset.Click
        System.IO.File.WriteAllText(".\CnC95\conquer.ini", My.Resources.conquer)
        System.IO.File.WriteAllText(".\CnC95\ddraw.ini", My.Resources.ddrawcnc1)
        Read_ini()
        CheckBox_cc1_compat.Checked = True
    End Sub

    Private Sub Read_ini()

        Select Case GetINI("Video", "Width", "864", ".\CnC95\conquer.ini")
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
                TextBox_width.Text = GetINI("Video", "Width", "640", ".\CnC95\conquer.ini")
                TextBox_height.Text = GetINI("Video", "Height", "480", ".\CnC95\conquer.ini")
        End Select

        If GetINI("ddraw", "renderer", "auto", ".\CnC95\ddraw.ini") = "auto" Then
            RadioButton_auto.Checked = True
        ElseIf GetINI("ddraw", "renderer", "auto", ".\CnC95\ddraw.ini") = "opengl" Then
            RadioButton_opengl.Checked = True
        Else
            RadioButton_gdi.Checked = True
        End If


        If GetINI("ddraw", "windowed", "false", ".\CnC95\ddraw.ini") = "true" Then
            RadioButton_windows.Checked = True
        Else
            RadioButton_full.Checked = True
        End If

        If GetINI("cnc1", "compatibility", "1", ".\config.ini") = "1" Then
            CheckBox_cc1_compat.Checked = True
        Else
            CheckBox_cc1_compat.Checked = False
        End If

    End Sub

    Private Sub save_ini()

        If RadioButton_full.Checked = True Then
            WriteINI("ddraw", "width", Screen.PrimaryScreen.Bounds.Width.ToString, ".\CnC95\ddraw.ini")
            WriteINI("ddraw", "height", Screen.PrimaryScreen.Bounds.Height.ToString, ".\CnC95\ddraw.ini")
        Else
            WriteINI("ddraw", "width", "0", ".\CnC95\ddraw.ini")
            WriteINI("ddraw", "height", "0", ".\CnC95\ddraw.ini")
        End If

        If RadioButton_864.Checked = True Then
            WriteINI("Video", "Width", "864", ".\CnC95\conquer.ini")
            WriteINI("Video", "Height", "540", ".\CnC95\conquer.ini")
        ElseIf RadioButton_1728.Checked = True Then
            WriteINI("Video", "Width", "1728", ".\CnC95\conquer.ini")
            WriteINI("Video", "Height", "1080", ".\CnC95\conquer.ini")
        ElseIf RadioButton_640.Checked = True Then
            WriteINI("Video", "Width", "640", ".\CnC95\conquer.ini")
            WriteINI("Video", "Height", "480", ".\CnC95\conquer.ini")
        ElseIf RadioButton_1920.Checked = True Then
            WriteINI("Video", "Width", "1920", ".\CnC95\conquer.ini")
            WriteINI("Video", "Height", "1080", ".\CnC95\conquer.ini")
        Else
            WriteINI("Video", "Width", TextBox_width.Text, ".\CnC95\conquer.ini")
            WriteINI("Video", "Height", TextBox_height.Text, ".\CnC95\conquer.ini")
        End If

        If RadioButton_auto.Checked = True Then
            WriteINI("ddraw", "renderer", "auto", ".\CnC95\ddraw.ini")
        ElseIf RadioButton_opengl.Checked = True Then
            WriteINI("ddraw", "renderer", "opengl", ".\CnC95\ddraw.ini")
        Else
            WriteINI("ddraw", "renderer", "gdi", ".\CnC95\ddraw.ini")
        End If

        If RadioButton_full.Checked = True Then
            WriteINI("ddraw", "windowed", "false", ".\CnC95\ddraw.ini")
        Else
            WriteINI("ddraw", "windowed", "true", ".\CnC95\ddraw.ini")
        End If


        Dim key As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("Software\Microsoft\Windows NT\CurrentVersion\AppCompatFlags", True)
        Dim subkey As Microsoft.Win32.RegistryKey
        subkey = key.CreateSubKey("Layers")
        If CheckBox_cc1_compat.Checked = True Then

            WriteINI("cnc1", "compatibility", "1", ".\config.ini")

            If Form1.RadioButton_win10.Checked Then
                subkey.SetValue(app_path & "\CnC95\C&C95.exe", "~ HIGHDPIAWARE WIN7RTM", Microsoft.Win32.RegistryValueKind.String)

            ElseIf Form1.RadioButton_win7.Checked Then
                subkey.SetValue(app_path & "\CnC95\C&C95.exe", "WIN98", Microsoft.Win32.RegistryValueKind.String)
            Else

            End If
        Else
            WriteINI("cnc1", "compatibility", "0", ".\config.ini")
            subkey.SetValue(app_path & "\CnC95\C&C95.exe", "", Microsoft.Win32.RegistryValueKind.String)
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

    'Private Sub jianrongxing()

    '    'MsgBox(cc1_path)
    '    If Form1.RadioButton_win10.Checked Then
    '        'Dim key As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("Software/Faxturer", True)
    '        Dim key As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("Software\Microsoft\Windows NT\CurrentVersion\AppCompatFlags", True)
    '        '[HKEY_CURRENT_USER\Software\Microsoft\Windows NT\CurrentVersion\AppCompatFlags\Layers]
    '        Dim subkey As Microsoft.Win32.RegistryKey
    '        subkey = key.CreateSubKey("Layers")
    '        subkey.SetValue(app_path & "\CnC95\C&C95.exe", "~ HIGHDPIAWARE WIN7RTM", Microsoft.Win32.RegistryValueKind.String)
    '        'subkey.SetValue(app_path & "\RA\ra95.exe", "~ HIGHDPIAWARE WIN7RTM", Microsoft.Win32.RegistryValueKind.String)
    '        'reg.SetValue("path", New String() {"d:/software/sdf","dfdf"}, Microsoft.Win32.RegistryValueKind.MultiString)
    '        'WriteINI("ddraw", "Windowed", "False", ".\ddraw.ini")
    '    ElseIf form1.RadioButton_win7.Checked Then
    '        Dim key As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("Software\Microsoft\Windows NT\CurrentVersion\AppCompatFlags", True)
    '        '[HKEY_CURRENT_USER\Software\Microsoft\Windows NT\CurrentVersion\AppCompatFlags\Layers]
    '        Dim subkey As Microsoft.Win32.RegistryKey
    '        subkey = key.CreateSubKey("Layers")
    '        subkey.SetValue(app_path & "\CnC95\C&C95.exe", "WIN95", Microsoft.Win32.RegistryValueKind.String)
    '        'subkey.SetValue(app_path & "\RA\ra95.exe", "WIN95", Microsoft.Win32.RegistryValueKind.String)
    '    Else

    '    End If
    '    Threading.Thread.Sleep(100)
    'End Sub

End Class