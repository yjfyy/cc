﻿Imports System.ComponentModel
Imports System.IO
Imports System.Text
'Imports System.Text

Public Class Form1
    Dim l_version
    Dim r_version
    Dim newuplog As String
    Dim up_root = "https://gitee.com/yjfyeyu/updatasys/raw/master/cnc1/patch/"

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

    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown
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
            Button_GDI.Enabled = True
            Button_NOD.Enabled = True
            Button_new_miss.Enabled = True
            Button_n64_ps_m.Enabled = True
            Button_run_cncnet.Enabled = True
            Button_eng.Enabled = True


            Button_run_ccconfig.Enabled = True
        Else
            If l_version <> r_version Then
                Label_status.Text = "有新版,请更新。"
                BackgroundWorker_load_uplog.RunWorkerAsync()
                Button_updata.Enabled = True
                Button_updata.Text = "更新"
            Else
                Label_status.Text = "已是最新版!"
                Button_GDI.Enabled = True
                Button_NOD.Enabled = True
                Button_new_miss.Enabled = True
                Button_n64_ps_m.Enabled = True
                Button_run_cncnet.Enabled = True
                Button_eng.Enabled = True


                Button_run_ccconfig.Enabled = True
                Button_updata.Enabled = True

            End If
        End If



    End Sub

    Private Sub BackgroundWorker_load_uplog_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker_load_uplog.DoWork
        Dim dFile As New System.Net.WebClient
        Dim upUri_newuplog As New Uri(up_root + "newuplog.txt")
        Try
            dFile.Encoding = Encoding.UTF8
            newuplog = dFile.DownloadString(upUri_newuplog)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub BackgroundWorker_load_uplog_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker_load_uplog.RunWorkerCompleted
        TextBox1.Text = Replace(newuplog, vbLf, vbCrLf)
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Computer.FileSystem.FileExists("C&C95.exe") Then
        Else
            MsgBox("错误,请安装到命令与征服游戏目录中")
            Me.Close()
        End If

        delete_files()

        Try
            Using sr As New StreamReader("说明.txt")
                TextBox1.Text = sr.ReadToEnd()
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
        Else
            RadioButton_win7.Checked = True
        End If


    End Sub

    Private Sub Up_autoupdata()
        Button_NOD.Enabled = False
        Button_GDI.Enabled = False
        Button_new_miss.Enabled = False
        Button_run_cncnet.Enabled = False
        Button_n64_ps_m.Enabled = False
        Button_eng.Enabled = False

        Button_run_ccconfig.Enabled = False

        CheckBox_up_movies.Enabled = False
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
            If CheckBox_up_movies.Checked Then
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
        If My.Computer.FileSystem.FileExists("lang_chi.ini") Then
            Try
                My.Computer.FileSystem.DeleteFile("lang_chi.ini")
            Catch ex As Exception

            End Try
        End If
        If My.Computer.FileSystem.FileExists("rungame.bat") Then
            Try
                My.Computer.FileSystem.DeleteFile("rungame.bat")
            Catch ex As Exception

            End Try
        End If

        If My.Computer.FileSystem.FileExists("lang_chi.mix") Then
            Try
                My.Computer.FileSystem.DeleteFile("lang_chi.mix")
            Catch ex As Exception

            End Try
        End If

        If My.Computer.FileSystem.FileExists("ccconfigchi.lan") Then
            Try
                My.Computer.FileSystem.DeleteFile("ccconfigchi.lan")
            Catch ex As Exception

            End Try
        End If

    End Sub

    Private Sub Button_run_ccconfig_Click(sender As Object, e As EventArgs) Handles Button_run_ccconfig.Click
        'Shell("CCConfig.exe", Style:=AppWinStyle.NormalFocus)
        Process.Start("CCConfig.exe")
    End Sub

    Private Sub Button_run_cncnet_Click(sender As Object, e As EventArgs) Handles Button_run_cncnet.Click
        'Shell("cncnet5.exe", Style:=AppWinStyle.NormalFocus)
        Process.Start("cncnet5.exe")
    End Sub

    Private Sub Form1_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        If My.Computer.FileSystem.FileExists("lang_chi.ini") Then
            Try
                My.Computer.FileSystem.DeleteFile("lang_chi.ini")
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button_updata.Click
        If CheckBox_up_movies.Checked Then
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



    Private Sub Button_GDI_Click(sender As Object, e As EventArgs) Handles Button_GDI.Click
        WriteINI("CDControl", "CDPath", "CHI", ".\conquer.ini")
        WriteINI("Language", "Language", "CHG", ".\conquer.ini")
        jianrongxing()

        If System.Diagnostics.Process.GetProcessesByName("c&c95").Length > 0 Then
            MsgBox("请勿重复启动")
        Else
            If My.Computer.FileSystem.FileExists("ddraw.dll") Then
                Process.Start("c&c95.exe")
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

    Private Sub Button_NOD_Click(sender As Object, e As EventArgs) Handles Button_NOD.Click
        WriteINI("CDControl", "CDPath", "CHI", ".\conquer.ini")
        WriteINI("Language", "Language", "CHN", ".\conquer.ini")
        jianrongxing()
        If System.Diagnostics.Process.GetProcessesByName("c&c95").Length > 0 Then
            MsgBox("请勿重复启动")
        Else
            If My.Computer.FileSystem.FileExists("ddraw.dll") Then
                Process.Start("c&c95.exe")
            Else
                MsgBox("请在设置中打开ddraw")
            End If

        End If
    End Sub

    Private Sub Button_new_miss_Click(sender As Object, e As EventArgs) Handles Button_new_miss.Click
        WriteINI("CDControl", "CDPath", "CHI", ".\conquer.ini")
        WriteINI("Language", "Language", "CHM", ".\conquer.ini")
        jianrongxing()
        If System.Diagnostics.Process.GetProcessesByName("c&c95").Length > 0 Then
            MsgBox("请勿重复启动")
        Else
            If My.Computer.FileSystem.FileExists("ddraw.dll") Then
                Process.Start("c&c95.exe")
            Else
                MsgBox("请在设置中打开ddraw")
            End If

        End If
    End Sub

    Private Sub Button_n64_ps_m_Click(sender As Object, e As EventArgs) Handles Button_n64_ps_m.Click
        WriteINI("CDControl", "CDPath", "CHI", ".\conquer.ini")
        WriteINI("Language", "Language", "CHV", ".\conquer.ini")
        jianrongxing()
        If System.Diagnostics.Process.GetProcessesByName("c&c95").Length > 0 Then
            MsgBox("请勿重复启动")
        Else
            If My.Computer.FileSystem.FileExists("ddraw.dll") Then
                Process.Start("c&c95.exe")
            Else
                MsgBox("请在设置中打开ddraw")
            End If

        End If
    End Sub

    Private Sub Button_eng_Click(sender As Object, e As EventArgs) Handles Button_eng.Click
        WriteINI("CDControl", "CDPath", ".", ".\conquer.ini")
        WriteINI("Language", "Language", "eng", ".\conquer.ini")
        jianrongxing()
        If System.Diagnostics.Process.GetProcessesByName("c&c95").Length > 0 Then
            MsgBox("请勿重复启动")
        Else
            If My.Computer.FileSystem.FileExists("ddraw.dll") Then
                Process.Start("c&c95.exe")
            Else
                MsgBox("请在设置中打开ddraw")
            End If

        End If
    End Sub

    Private Sub jianrongxing()
        Dim cc1_path As String
        cc1_path = Application.StartupPath()
        'MsgBox(cc1_path)
        If RadioButton_win10.Checked Then
            'Dim key As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("Software/Faxturer", True)
            Dim key As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("Software\Microsoft\Windows NT\CurrentVersion\AppCompatFlags", True)
            '[HKEY_CURRENT_USER\Software\Microsoft\Windows NT\CurrentVersion\AppCompatFlags\Layers]
            Dim subkey As Microsoft.Win32.RegistryKey
            subkey = key.CreateSubKey("Layers")
            subkey.SetValue(cc1_path & "\C&C95.exe", "~ HIGHDPIAWARE WIN7RTM", Microsoft.Win32.RegistryValueKind.String)
            'reg.SetValue("path", New String() {"d:/software/sdf","dfdf"}, Microsoft.Win32.RegistryValueKind.MultiString)
            'WriteINI("ddraw", "Windowed", "False", ".\ddraw.ini")
        Else
            Dim key As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("Software\Microsoft\Windows NT\CurrentVersion\AppCompatFlags", True)
            '[HKEY_CURRENT_USER\Software\Microsoft\Windows NT\CurrentVersion\AppCompatFlags\Layers]
            Dim subkey As Microsoft.Win32.RegistryKey
            subkey = key.CreateSubKey("Layers")
            subkey.SetValue(cc1_path & "\C&C95.exe", "WIN95", Microsoft.Win32.RegistryValueKind.String)

        End If
        Threading.Thread.Sleep(100)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cc1_path As String
        cc1_path = Application.StartupPath()
        MsgBox(cc1_path)
        jianrongxing()

    End Sub
End Class
