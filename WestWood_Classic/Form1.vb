Imports System.ComponentModel
Imports System.IO
Imports System.Text

Public Class Form_main
    Dim l_version
    Dim r_version
    Dim newuplog As String
    Dim up_root = "https://gitee.com/yjfyeyu/updatasys/raw/master/WestWood_Classic/"

    '声明INI配置文件读写API函数,lpApplicationName节名称， lpKeyName键名称，lpString是键值
    Private Declare Function GetPrivateProfileString Lib "kernel32" Alias "GetPrivateProfileStringA" (ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal lpDefault As String, ByVal lpReturnedString As String, ByVal nSize As Int32, ByVal lpFileName As String) As Int32
    Private Declare Function WritePrivateProfileString Lib "kernel32" Alias "WritePrivateProfileStringA" (ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal lpString As String, ByVal lpFileName As String) As Int32
    '定义读取配置文件函数
    Public Function GetINI(ByVal Section As String, ByVal AppName As String, ByVal lpDefault As String, ByVal FileName As String) As String
        Dim Str As String = LSet(Str, 256)
        GetPrivateProfileString(Section, AppName, lpDefault, Str, Len(Str), FileName)
        Return Microsoft.VisualBasic.Left(Str, InStr(Str, Chr(0)) - 1)
    End Function
    '定义写入配置文件函数
    Public Function WriteINI(ByVal Section As String, ByVal AppName As String, ByVal lpDefault As String, ByVal FileName As String) As Long
        WriteINI = WritePrivateProfileString(Section, AppName, lpDefault, FileName)
    End Function


    Private Sub Button_cnc1_Click(sender As Object, e As EventArgs) Handles Button_cnc1.Click
        Panel_up_log.Visible = False
        Panel_cnc1.Visible = True
        Panel_ra1.Visible = False
    End Sub

    Private Sub Button_ra1_Click(sender As Object, e As EventArgs) Handles Button_ra1.Click
        Panel_up_log.Visible = False
        Panel_cnc1.Visible = False
        Panel_ra1.Visible = True
    End Sub

    Private Sub Form_main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        delete_files()

        Try
            Using sr As New StreamReader("说明.txt")
                TextBox_up_log.Text = sr.ReadToEnd()
            End Using
        Catch ex As Exception
        End Try

        Try
            Using sr As New StreamReader("lver")
                Label_l_version.Text = sr.ReadToEnd()
            End Using
        Catch ex As Exception
        End Try

        Dim os As OperatingSystem = Environment.OSVersion
        If Mid(os.Version.ToString, 1, 3) = "6.2" Then
            RadioButton_win10.Checked = True
        ElseIf Mid(os.Version.ToString, 1, 3) = "6.1" Then
            RadioButton_win7.Checked = True
        ElseIf Mid(os.Version.ToString, 1, 3) = "5.1" Then
            RadioButton_winxp.Checked = True
        Else
            MsgBox("未能确认操作系统版本，请手动选择")
            GroupBox1.Enabled = True
        End If

    End Sub


    Private Sub delete_files()

        '删除更新残留
        If My.Computer.FileSystem.FileExists("up_com.bat") Then
            Try
                My.Computer.FileSystem.DeleteFile("up_com.bat")
            Catch ex As Exception

            End Try
        End If
        If My.Computer.FileSystem.FileExists("up_data.exe") Then
            Try
                My.Computer.FileSystem.DeleteFile("up_data.exe")
            Catch ex As Exception

            End Try
        End If

    End Sub

    Private Sub Form_main_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        'MsgBox("检查更新")
        Label_status.Text = "正在检测更新......"
        l_version = Label_l_version.Text
        BackgroundWorker_check_ver.RunWorkerAsync()
    End Sub

    Private Sub BackgroundWorker_check_ver_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker_check_ver.DoWork
        Dim dFile As New System.Net.WebClient
        Dim upUri_version As New Uri(up_root + "version.txt")
        Try
            r_version = dFile.DownloadString(upUri_version)
        Catch ex As Exception

            r_version = "0"
        End Try
    End Sub
    Private Sub BackgroundWorker_check_ver_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker_check_ver.RunWorkerCompleted
        Label_r_version.Text = r_version


        If r_version = "0" Then
            Label_status.Text = "检测失败"

        Else
            If l_version <> r_version Then
                Label_status.Text = "有新版,请更新。"
                Button_cnc1.Enabled = False
                Label_cnc1.Enabled = False

                Button_ra1.Enabled = False
                Label_ra1.Enabled = False

                Button_updata.Text = "更新"

                BackgroundWorker_load_up_log.RunWorkerAsync()
            Else
                Label_status.Text = "已是最新版!"
                Button_cnc1.Enabled = True
                Label_cnc1.Enabled = True

                Button_ra1.Enabled = True
                Label_ra1.Enabled = True
            End If
        End If
    End Sub

    Private Sub BackgroundWorker_load_uplog_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker_load_up_log.DoWork
        Dim dFile As New System.Net.WebClient
        Dim upUri_newuplog As New Uri(up_root + "newuplog.txt")
        Try
            dFile.Encoding = Encoding.UTF8
            newuplog = dFile.DownloadString(upUri_newuplog)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub BackgroundWorker_load_uplog_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker_load_up_log.RunWorkerCompleted
        TextBox_up_log.Text = Replace(newuplog, vbLf, vbCrLf)
    End Sub

    Private Sub Up_autoupdata()

        Button_updata.Enabled = False

        Dim dFile As New System.Net.WebClient
        Dim upUri_up_data As New Uri(up_root & "up_data.exe")
        AddHandler dFile.DownloadProgressChanged, AddressOf ShowDownProgress '这一句是在网上看到的，用这句来捕获下载进度变化事件，不知道对不对。
        AddHandler dFile.DownloadFileCompleted, AddressOf wanchen
        Label_status.Text = "正在下载..."

        'dFile.DownloadFileAsync(upUri, Environ("AppData") & "\Factorio\mods\" & modslist(8, mods_select))
        dFile.DownloadFileAsync(upUri_up_data, "up_data.exe")
        'BackgroundWorker_download_updata.RunWorkerAsync()

    End Sub

    Private Sub ShowDownProgress(ByVal sender As Object, ByVal e As System.Net.DownloadProgressChangedEventArgs)
        Invoke(New Action(Of Integer)(Sub(i) ProgressBar1.Value = i), e.ProgressPercentage)
    End Sub
    Sub wanchen(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
        Label_status.Text = "下载完成"
        Try
            If CheckBox_updata_movies.Checked Then
                System.IO.File.WriteAllText("up_com.bat", TextBox_up_com_as_movies.Text, encoding:=System.Text.Encoding.Default)
            Else
                System.IO.File.WriteAllText("up_com.bat", TextBox_up_com.Text, encoding:=System.Text.Encoding.Default)
            End If
            Label_status.Text = "升级完成后将自动重启。"
            'Shell("up_com.bat", Style:=AppWinStyle.NormalFocus)
            Process.Start("up_com.bat")
            Me.Close()
        Catch ex As Exception
            MsgBox（"升级错误，请手动执行 up_data.exe")
        End Try
    End Sub

    Private Sub Form_main_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        If My.Computer.FileSystem.FileExists("lang_chi.ini") Then
            Try
                My.Computer.FileSystem.DeleteFile("lang_chi.ini")
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub Button_updata_Click(sender As Object, e As EventArgs) Handles Button_updata.Click
        If CheckBox_updata_movies.Checked Then
            Dim message As String = "更新动画包将耗费更长时间，确定更新动画包?"
            Dim caption As String = "警告"
            Dim result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            ' If the no button was pressed ...
            If (result = DialogResult.No) Then
                ' cancel the closure of the form.
            Else
                Up_autoupdata()
            End If
        Else
            Up_autoupdata()
        End If
    End Sub

    Private Sub jianrongxing()
        Dim app_path As String

        app_path = Application.StartupPath()
        'MsgBox(cc1_path)
        If RadioButton_win10.Checked Then
            'Dim key As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("Software/Faxturer", True)
            Dim key As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("Software\Microsoft\Windows NT\CurrentVersion\AppCompatFlags", True)
            '[HKEY_CURRENT_USER\Software\Microsoft\Windows NT\CurrentVersion\AppCompatFlags\Layers]
            Dim subkey As Microsoft.Win32.RegistryKey
            subkey = key.CreateSubKey("Layers")
            subkey.SetValue(app_path & "\CnC95\C&C95.exe", "~ HIGHDPIAWARE WIN7RTM", Microsoft.Win32.RegistryValueKind.String)
            subkey.SetValue(app_path & "\RA\ra95.exe", "~ HIGHDPIAWARE WIN7RTM", Microsoft.Win32.RegistryValueKind.String)
            'reg.SetValue("path", New String() {"d:/software/sdf","dfdf"}, Microsoft.Win32.RegistryValueKind.MultiString)
            'WriteINI("ddraw", "Windowed", "False", ".\ddraw.ini")
        ElseIf RadioButton_win7.Checked Then
            Dim key As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("Software\Microsoft\Windows NT\CurrentVersion\AppCompatFlags", True)
            '[HKEY_CURRENT_USER\Software\Microsoft\Windows NT\CurrentVersion\AppCompatFlags\Layers]
            Dim subkey As Microsoft.Win32.RegistryKey
            subkey = key.CreateSubKey("Layers")
            subkey.SetValue(app_path & "\CnC95\C&C95.exe", "WIN95", Microsoft.Win32.RegistryValueKind.String)
            subkey.SetValue(app_path & "\RA\ra95.exe", "WIN95", Microsoft.Win32.RegistryValueKind.String)
        Else

        End If
        Threading.Thread.Sleep(100)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button_cnc1_GDI_miss.Click
        WriteINI("CDControl", "CDPath", "CHI", "CnC95\conquer.ini")
        WriteINI("Language", "Language", "CHG", "CnC95\conquer.ini")
        jianrongxing()

        If System.Diagnostics.Process.GetProcessesByName("c&c95").Length > 0 Then
            MsgBox("请勿重复启动")
        Else
            If My.Computer.FileSystem.FileExists("cnc95\ddraw.dll") Then
                Process.Start("cnc95\c&c95.exe")
            Else
                MsgBox("请在设置中打开ddraw")
            End If

        End If
        'process.star可以启动带有符号的exe，shell启动不了c&c95.exe

        'System.IO.File.WriteAllText("rungame.bat", TextBox_run_game_com.Text, encoding:=System.Text.Encoding.Default)
        'Shell("rungame.bat", Style:=AppWinStyle.MinimizedFocus)
        'Threading.Thread.Sleep(100)

        'If My.Computer.FileSystem.FileExists("rungame.bat") Then
        '    Try
        '        My.Computer.FileSystem.DeleteFile("rungame.bat")
        '    Catch ex As Exception

        '    End Try
        'End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button_cnc1_NOD_miss.Click
        WriteINI("CDControl", "CDPath", "CHI", "CnC95\conquer.ini")
        WriteINI("Language", "Language", "CHN", "CnC95\conquer.ini")
        jianrongxing()
        If System.Diagnostics.Process.GetProcessesByName("c&c95").Length > 0 Then
            MsgBox("请勿重复启动")
        Else
            If My.Computer.FileSystem.FileExists("CnC95\ddraw.dll") Then
                Process.Start("cnc95\c&c95.exe")
            Else
                MsgBox("请在设置中打开ddraw")
            End If

        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button_cnc1_ext.Click
        WriteINI("CDControl", "CDPath", "CHI", "CnC95\conquer.ini")
        WriteINI("Language", "Language", "CHM", "CnC95\conquer.ini")
        jianrongxing()
        If System.Diagnostics.Process.GetProcessesByName("c&c95").Length > 0 Then
            MsgBox("请勿重复启动")
        Else
            If My.Computer.FileSystem.FileExists("CnC95\ddraw.dll") Then
                Process.Start("cnc95\c&c95.exe")
            Else
                MsgBox("请在设置中打开ddraw")
            End If

        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button_cnc1_tv.Click
        WriteINI("CDControl", "CDPath", "CHI", "CnC95\conquer.ini")
        WriteINI("Language", "Language", "CHV", "CnC95\conquer.ini")
        jianrongxing()
        If System.Diagnostics.Process.GetProcessesByName("c&c95").Length > 0 Then
            MsgBox("请勿重复启动")
        Else
            If My.Computer.FileSystem.FileExists("CnC95\ddraw.dll") Then
                Process.Start("cnc95\c&c95.exe")
            Else
                MsgBox("请在设置中打开ddraw")
            End If

        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button_cnc1_english.Click
        WriteINI("CDControl", "CDPath", ".", "CnC95\conquer.ini")
        WriteINI("Language", "Language", "eng", "CnC95\conquer.ini")
        jianrongxing()
        If System.Diagnostics.Process.GetProcessesByName("c&c95").Length > 0 Then
            MsgBox("请勿重复启动")
        Else
            If My.Computer.FileSystem.FileExists("cnc95\ddraw.dll") Then
                Process.Start("cnc95\c&c95.exe")
            Else
                MsgBox("请在设置中打开ddraw")
            End If

        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs)
        Dim cc1_path As String
        cc1_path = Application.StartupPath()
        MsgBox(cc1_path)
        jianrongxing()
    End Sub





    Private Sub Button_cnc1_cncnet_Click(sender As Object, e As EventArgs) Handles Button_cnc1_cncnet.Click
        'Shell("cncnet5.exe", Style:=AppWinStyle.NormalFocus)
        Process.Start("CnC95\cncnet5.exe")
    End Sub

    Private Sub Button_cnc1_config_Click(sender As Object, e As EventArgs) Handles Button_cnc1_config.Click
        'Shell("CCConfig.exe", Style:=AppWinStyle.NormalFocus)
        Process.Start("CnC95\CCConfig.exe")
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If System.Diagnostics.Process.GetProcessesByName("ra95").Length > 0 Then
            MsgBox("请勿重复启动")
        Else
            'If My.Computer.FileSystem.FileExists("cnc95\ddraw.dll") Then
            jianrongxing()
            Process.Start("ra\ra95.exe")
            'Else
            'MsgBox("请在设置中打开ddraw")
            'End If

        End If
    End Sub

    Private Sub Button8_MouseUp(sender As Object, e As MouseEventArgs) Handles Button8.MouseUp

    End Sub

    Private Sub Button_ra1_config_Click(sender As Object, e As EventArgs) Handles Button_ra1_config.Click

        Process.Start("RA\RedAlertConfig")
    End Sub
End Class
