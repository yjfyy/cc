Imports System.ComponentModel
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
        Else
            Label_status.Text = "检测完成"
        End If

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
            Button_run_cncnet.Enabled = True

            Button_run_ccconfig.Enabled = True
            Button_updata.Enabled = True

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


    End Sub

    Private Sub Up_autoupdata()
        Button_NOD.Enabled = False
        Button_GDI.Enabled = False
        Button_new_miss.Enabled = False
        Button_run_cncnet.Enabled = False

        Button_run_ccconfig.Enabled = False
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
            System.IO.File.WriteAllText("up_com.bat", TextBox_up_com.Text, encoding:=System.Text.Encoding.Default)
            Label_status.Text = "升级完成后将自动重启。"
            Shell("up_com.bat", Style:=AppWinStyle.NormalFocus)
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
        Shell("CCConfig.exe", Style:=AppWinStyle.NormalFocus)
    End Sub

    Private Sub Button_run_cncnet_Click(sender As Object, e As EventArgs) Handles Button_run_cncnet.Click
        Shell("cncnet5.exe", Style:=AppWinStyle.NormalFocus)
    End Sub

    Private Sub Form1_Closed(sender As Object, e As EventArgs) Handles Me.Closed
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
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button_updata.Click
        Up_autoupdata()
    End Sub



    Private Sub Button_GDI_Click(sender As Object, e As EventArgs) Handles Button_GDI.Click
        WriteINI("Language", "Language", "CHG", ".\conquer.ini")
        System.IO.File.WriteAllText("rungame.bat", TextBox_run_game_com.Text, encoding:=System.Text.Encoding.Default)
        Shell("rungame.bat", Style:=AppWinStyle.MinimizedFocus)
        Threading.Thread.Sleep(100)

        If My.Computer.FileSystem.FileExists("rungame.bat") Then
            Try
                My.Computer.FileSystem.DeleteFile("rungame.bat")
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub Button_NOD_Click(sender As Object, e As EventArgs) Handles Button_NOD.Click
        WriteINI("Language", "Language", "CHN", ".\conquer.ini")

        'MsgBox(Application.StartupPath & "\C&C95.exe")
        System.IO.File.WriteAllText("rungame.bat", TextBox_run_game_com.Text, encoding:=System.Text.Encoding.Default)
        Shell("rungame.bat", Style:=AppWinStyle.MinimizedFocus)
        Threading.Thread.Sleep(100)

        If My.Computer.FileSystem.FileExists("rungame.bat") Then
            Try
                My.Computer.FileSystem.DeleteFile("rungame.bat")
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub Button_new_miss_Click(sender As Object, e As EventArgs) Handles Button_new_miss.Click
        WriteINI("Language", "Language", "CHM", ".\conquer.ini")

        'MsgBox(Application.StartupPath & "\C&C95.exe")
        System.IO.File.WriteAllText("rungame.bat", TextBox_run_game_com.Text, encoding:=System.Text.Encoding.Default)
        Shell("rungame.bat", Style:=AppWinStyle.MinimizedFocus)
        Threading.Thread.Sleep(100)

        If My.Computer.FileSystem.FileExists("rungame.bat") Then
            Try
                My.Computer.FileSystem.DeleteFile("rungame.bat")
            Catch ex As Exception

            End Try
        End If
    End Sub

End Class
