﻿Imports System.ComponentModel
Imports System.IO
Imports System.Runtime.Remoting.Channels
Imports System.Text




Public Class Form1
    Dim l_version
    Dim r_version
    ' Dim newuplog As String
    'Dim up_root = "https://gitee.com/yjfyeyu/updatasys/raw/master/WestWood_Classic/"
    'Dim up_root = "https://raw.githubusercontent.com/yjfyy/tuzi_updata/master/WestWood_Classic/"
    'Dim up_root = "http://butwhy.vicp.net:82/tuzi_updata/WestWood_Classic/"
    'Dim up_root = "https://gitlab.com/yjfyy/tuzi_updata/raw/master/WestWood_Classic/"
    Dim up_root

    Dim app_path As String = Application.StartupPath()
    'Dim date2 = New DateTime(2020, 3, 5)

    Private Sub Button_cnc1_Click(sender As Object, e As EventArgs) Handles Button_cnc1.Click

        If GetINI("cnc1", "fristrun", "1", ".\config.ini") = "1" Then
            MsgBox（"第一次启动游戏前,必须先设置参数",, "提示"）
            Button_cnc1_GDI_miss.Enabled = False
            Button_cnc1_NOD_miss.Enabled = False
            Button_cnc1_ext.Enabled = False
            Button_cnc1_tv.Enabled = False
            Button_cnc1_cncnet.Enabled = False
            Button_cnc1_english.Enabled = False
        End If


        Panel_up_log.Visible = False
        Panel_cnc1.Visible = True
        Panel_ra1.Visible = False
    End Sub

    Private Sub Button_ra1_Click(sender As Object, e As EventArgs) Handles Button_ra1.Click
        If GetINI("ra1", "fristrun", "1", ".\config.ini") = "1" Then
            MsgBox（"第一次启动游戏前,必须先设置参数",, "提示"）
            Button_ra1_ally.Enabled = False
            Button_ra1_soviet.Enabled = False
            Button_ra1_ext_cs.Enabled = False
            Button_ra1_skirmish.Enabled = False
            Button_ra1_cncnet.Enabled = False
            Button_ra1_english.Enabled = False
            Button_ra1_ext_af.Enabled = False
            Button_ra1_ext_af_su.Enabled = False
            ra1cfg.Button_reset.PerformClick()
        End If

        Panel_up_log.Visible = False
        Panel_cnc1.Visible = False
        Panel_ra1.Visible = True
    End Sub

    Private Sub Form_main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fix()
        'show_game_logo()
        'WebBrowser1.Url = New Uri(Application.StartupPath & "/readme.htm")
        WebBrowser1.ScriptErrorsSuppressed = True
        WebBrowser1.Url = New Uri("http://yjfyeyu.gitee.io/cnc_chi_readme/readme.htm")
        up_1delete()
        'Try
        'Using sr As New StreamReader("lver")
        ' Label_l_version.Text = sr.ReadToEnd()
        ' End Using
        ' Catch ex As Exception
        ' End Try

        'Dim os As OperatingSystem = Environment.OSVersion

        'If Mid(os.Version.ToString, 1, 3) = "6.2" Then
        '    RadioButton_win10.Checked = True
        'ElseIf Mid(os.Version.ToString, 1, 3) = "6.1" Then
        '    RadioButton_win7.Checked = True
        'ElseIf Mid(os.Version.ToString, 1, 3) = "5.1" Then
        '    RadioButton_winxp.Checked = True
        '    'up_root = "http://code.taobao.org/svn/yxgcsj/trunk/WestWood_Classic/"
        'Else
        '    MsgBox("未能确认操作系统版本，请手动选择")
        '    GroupBox1.Enabled = True
        'End If


    End Sub

    Private Sub up_1delete()
        '删除更新残留
        Try
            My.Computer.FileSystem.DeleteFile("up_com.bat")
        Catch ex As Exception
        End Try

        Try
            My.Computer.FileSystem.DeleteFile("up_data.exe")
        Catch ex As Exception
        End Try

        Try
            My.Computer.FileSystem.DeleteFile("up_data.part01.exe")
        Catch ex As Exception
        End Try
        Try
            My.Computer.FileSystem.DeleteFile("up_data.part02.rar")
        Catch ex As Exception
        End Try
        Try
            My.Computer.FileSystem.DeleteFile("up_data.part03.rar")
        Catch ex As Exception
        End Try
        Try
            My.Computer.FileSystem.DeleteFile("up_data.part04.rar")
        Catch ex As Exception
        End Try
        Try
            My.Computer.FileSystem.DeleteFile("up_data.part05.rar")
        Catch ex As Exception
        End Try
        Try
            My.Computer.FileSystem.DeleteFile("up_data.part06.rar")
        Catch ex As Exception
        End Try
        Try
            My.Computer.FileSystem.DeleteFile("up_data.part07.rar")
        Catch ex As Exception
        End Try
        Try
            My.Computer.FileSystem.DeleteFile("up_data.part08.rar")
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Delete_files()

        '删除当前版本汉化
        Try
            System.IO.File.Delete(app_path & "\CnC95\updated.mix.mix")
        Catch ex As Exception
        End Try

        Try
            System.IO.File.Delete(app_path & "\RA\EXPAND9.MIX")
        Catch ex As Exception
        End Try

        Try
            System.IO.File.Delete(app_path & "\RA\campaign.mix")
        Catch ex As Exception
        End Try

        '1.56之前汉化文件
        '命令与征服
        '文字
        Try
            System.IO.File.Delete(app_path & "\CnC95\lang_chg.mix")
        Catch ex As Exception
        End Try

        Try
            System.IO.File.Delete(app_path & "\CnC95\lang_chm.mix")
        Catch ex As Exception
        End Try

        Try
            System.IO.File.Delete(app_path & "\CnC95\lang_chn.mix")
        Catch ex As Exception
        End Try

        Try
            System.IO.File.Delete(app_path & "\CnC95\lang_chv.mix")
        Catch ex As Exception
        End Try

        Try
            My.Computer.FileSystem.DeleteFile(app_path & "\CnC95\ccconfigchg.lan")
        Catch ex As Exception
        End Try

        Try
            My.Computer.FileSystem.DeleteFile(app_path & "\CnC95\ccconfigchm.lan")
        Catch ex As Exception
        End Try

        Try
            My.Computer.FileSystem.DeleteFile(app_path & "\CnC95\ccconfigchn.lan")
        Catch ex As Exception
        End Try

        Try
            My.Computer.FileSystem.DeleteFile(app_path & "\CnC95\ccconfigchv.lan")
        Catch ex As Exception
        End Try

        Try
            My.Computer.FileSystem.DeleteFile("lang_chi.ini")
        Catch ex As Exception
        End Try

        Try
            My.Computer.FileSystem.DeleteFile("\CnC95\lang_chi.ini")
        Catch ex As Exception
        End Try

        '图标
        Try
            System.IO.File.Delete(app_path & "\CnC95\deseichi.mix")
        Catch ex As Exception
        End Try

        Try
            System.IO.File.Delete(app_path & "\CnC95\snowichi.mix")
        Catch ex As Exception
        End Try

        Try
            System.IO.File.Delete(app_path & "\CnC95\tempichi.mix")
        Catch ex As Exception
        End Try

        Try
            System.IO.File.Delete(app_path & "\CnC95\wintichi.mix")
        Catch ex As Exception
        End Try

        '语音
        Try
            System.IO.File.Delete(app_path & "\CnC95\speecchi.mix")
        Catch ex As Exception
        End Try

        '动画
        Try
            My.Computer.FileSystem.DeleteDirectory(app_path & "\CnC95\chi", onDirectoryNotEmpty:=FileIO.DeleteDirectoryOption.DeleteAllContents)
        Catch ex As Exception
        End Try

        '红警
        '文字和图标
        Try
            System.IO.File.Delete(app_path & "\RA\frenchlanguagepack.mix")
        Catch ex As Exception
        End Try

        Try
            System.IO.File.Delete(app_path & "\RA\germancensoredlanguagepack.mix")
        Catch ex As Exception
        End Try

        Try
            System.IO.File.Delete(app_path & "\RA\germanlanguagepack.mix")
        Catch ex As Exception
        End Try

        Try
            System.IO.File.Delete(app_path & "\RA\germanuncensoredlanguagepack.mix")
        Catch ex As Exception
        End Try

        Try
            System.IO.File.Delete(app_path & "\RA\russianlanguagepack.mix")
        Catch ex As Exception
        End Try

        Try
            System.IO.File.Delete(app_path & "\RA\spanishlanguagepack.mix")
        Catch ex As Exception
        End Try

        '语音
        Try
            System.IO.File.Delete(app_path & "\RA\speech.mix")
        Catch ex As Exception
        End Try

        Try
            System.IO.File.Delete(app_path & "\RA\spanishlanguagepack.mix")
        Catch ex As Exception
        End Try

        '动画
        Try
            My.Computer.FileSystem.DeleteFile(app_path & "\RA\movies-1.mix")
        Catch ex As Exception
        End Try

        Try
            My.Computer.FileSystem.DeleteFile(app_path & "\RA\movies-2.mix")
        Catch ex As Exception
        End Try

        Try
            My.Computer.FileSystem.DeleteFile(app_path & "\RA\movies-3.mix")
        Catch ex As Exception
        End Try

        Try
            My.Computer.FileSystem.DeleteFile(app_path & "\RA\movies-4.mix")
        Catch ex As Exception
        End Try

        Try
            My.Computer.FileSystem.DeleteFile(app_path & "\RA\movies-5.mix")
        Catch ex As Exception
        End Try

        Try
            My.Computer.FileSystem.DeleteFile(app_path & "\RA\movies-6.mix")
        Catch ex As Exception
        End Try

        Try
            My.Computer.FileSystem.DeleteFile(app_path & "\RA\movies-7.mix")
        Catch ex As Exception
        End Try

        Try
            My.Computer.FileSystem.DeleteFile(app_path & "\RA\movies-8.mix")
        Catch ex As Exception
        End Try

        Try
            My.Computer.FileSystem.DeleteFile(app_path & "\RA\movies-9.mix")
        Catch ex As Exception
        End Try

        '1.56-57临时汉化
        Try
            System.IO.File.Delete(app_path & "\RA\EXPAND4.MIX")
        Catch ex As Exception
        End Try
        Try
            System.IO.File.Delete(app_path & "\RA\EXPAND5.MIX")
        Catch ex As Exception
        End Try
        Try
            System.IO.File.Delete(app_path & "\RA\EXPAND6.MIX")
        Catch ex As Exception
        End Try
        Try
            System.IO.File.Delete(app_path & "\RA\EXPAND7.MIX")
        Catch ex As Exception
        End Try
        Try
            System.IO.File.Delete(app_path & "\RA\EXPAND8.MIX")
        Catch ex As Exception
        End Try

        '其他
        Try
            My.Computer.FileSystem.DeleteDirectory(app_path & "\attach", onDirectoryNotEmpty:=FileIO.DeleteDirectoryOption.DeleteAllContents)
        Catch ex As Exception
        End Try

        '1.27使用语言包方式，删除1.27以下红警汉化文件。
        Try
            My.Computer.FileSystem.DeleteFile(app_path & "\RA\conquer.eng")
        Catch ex As Exception
        End Try
        Try
            My.Computer.FileSystem.DeleteFile(app_path & "\RA\hires.mix")
        Catch ex As Exception
        End Try
        Try
            My.Computer.FileSystem.DeleteFile(app_path & "\RA\mission.ini")
        Catch ex As Exception
        End Try
        Try
            My.Computer.FileSystem.DeleteFile(app_path & "\RA\tutorial.ini")
        Catch ex As Exception
        End Try
        Try
            My.Computer.FileSystem.DeleteFile(app_path & "\RA\local.mix")
        Catch ex As Exception
        End Try

        '1.21 使用readme.htm 删除说明.txt
        Try
            My.Computer.FileSystem.DeleteFile("说明.txt")
        Catch ex As Exception

        End Try




    End Sub

    Private Sub BackgroundWorker_check_ver_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker_check_ver.DoWork
        Dim dFile As New System.Net.WebClient
        Dim upUri_version As New Uri(up_root & "version.txt")
        Label_status.Text = "正在检测更新......"
        Try
            r_version = dFile.DownloadString(upUri_version)
        Catch ex As Exception
            r_version = "0"
        End Try
        'MsgBox(upUri_version.ToString)
    End Sub
    Private Sub BackgroundWorker_check_ver_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker_check_ver.RunWorkerCompleted
        Label_r_version.Text = r_version
        l_version = Label_l_version.Text
        GroupBox_updata.Enabled = True
        If r_version = "0" Then
            Label_status.Text = "检测失败"

            'Button_cnc1.Enabled = True
            'Label_cnc1.Enabled = True

            ' Button_ra1.Enabled = True
            'Label_ra1.Enabled = True
            'show_game_logo()


            GroupBox_updata.Enabled = True


        Else
            If l_version <> r_version Then
                Label_status.Text = "有新版,请更新。"
                Button_cnc1.Enabled = False
                Label_cnc1.Enabled = False

                Button_ra1.Enabled = False
                Label_ra1.Enabled = False

                Button_updata.Text = "更新"

                WebBrowser1.Url = New Uri(up_root + "newuplog.txt")

                Button_updata.Enabled = True

                'WebBrowser1.Url = New Uri("https://gitee.com/yjfyeyu/cnc_chi/raw/master/%E6%9C%80%E6%96%B0%E4%BF%AE%E6%94%B9%E5%86%85%E5%AE%B9.txt")
                'BackgroundWorker_load_up_log.RunWorkerAsync()
            Else
                Label_status.Text = "已是最新版!"
                show_game_logo()
                'Button_cnc1.Enabled = True
                'Label_cnc1.Enabled = True

                'Button_ra1.Enabled = True
                'Label_ra1.Enabled = True

                Button_updata.Enabled = True
            End If
        End If
    End Sub

    Private Sub Up_autoupdata()
        Button_updata.Enabled = False
        Dim dFile As New System.Net.WebClient
        'AddHandler dFile.DownloadProgressChanged, AddressOf ShowDownProgress
        AddHandler dFile.DownloadFileCompleted, AddressOf Up_autoupdata1
        Label_status.Text = "正在下载..."
        dFile.DownloadFileAsync(New Uri(up_root & "up_data.exe"), "up_data.exe")
        ProgressBar1.Value = 2
    End Sub
    Private Sub Up_autoupdata1()

        Dim dFile As New System.Net.WebClient
        'AddHandler dFile.DownloadProgressChanged, AddressOf ShowDownProgress
        AddHandler dFile.DownloadFileCompleted, AddressOf Up_autoupdata2

        dFile.DownloadFileAsync(New Uri(up_root & "up_data.part01.exe"), "up_data.part01.exe")
        ProgressBar1.Value = 30
    End Sub
    Private Sub Up_autoupdata2()

        Dim dFile As New System.Net.WebClient
        'AddHandler dFile.DownloadProgressChanged, AddressOf ShowDownProgress
        AddHandler dFile.DownloadFileCompleted, AddressOf Up_autoupdata3

        dFile.DownloadFileAsync(New Uri(up_root & "up_data.part02.rar"), "up_data.part02.rar")
        ProgressBar1.Value = 40
    End Sub
    Private Sub Up_autoupdata3()

        Dim dFile As New System.Net.WebClient
        'AddHandler dFile.DownloadProgressChanged, AddressOf ShowDownProgress
        AddHandler dFile.DownloadFileCompleted, AddressOf Up_autoupdata4

        dFile.DownloadFileAsync(New Uri(up_root & "up_data.part03.rar"), "up_data.part03.rar")
        ProgressBar1.Value = 50
    End Sub
    Private Sub Up_autoupdata4()

        Dim dFile As New System.Net.WebClient
        'AddHandler dFile.DownloadProgressChanged, AddressOf ShowDownProgress
        AddHandler dFile.DownloadFileCompleted, AddressOf Up_autoupdata5

        dFile.DownloadFileAsync(New Uri(up_root & "up_data.part04.rar"), "up_data.part04.rar")
        ProgressBar1.Value = 60
    End Sub
    Private Sub Up_autoupdata5()

        Dim dFile As New System.Net.WebClient
        'AddHandler dFile.DownloadProgressChanged, AddressOf ShowDownProgress
        AddHandler dFile.DownloadFileCompleted, AddressOf Up_autoupdata6

        dFile.DownloadFileAsync(New Uri(up_root & "up_data.part05.rar"), "up_data.part05.rar")
        ProgressBar1.Value = 70
    End Sub
    Private Sub Up_autoupdata6()

        Dim dFile As New System.Net.WebClient
        'AddHandler dFile.DownloadProgressChanged, AddressOf ShowDownProgress
        AddHandler dFile.DownloadFileCompleted, AddressOf Up_autoupdata7

        dFile.DownloadFileAsync(New Uri(up_root & "up_data.part06.rar"), "up_data.part06.rar")
        ProgressBar1.Value = 80
    End Sub
    Private Sub Up_autoupdata7()

        Dim dFile As New System.Net.WebClient
        'AddHandler dFile.DownloadProgressChanged, AddressOf ShowDownProgress
        AddHandler dFile.DownloadFileCompleted, AddressOf Up_autoupdata8

        dFile.DownloadFileAsync(New Uri(up_root & "up_data.part07.rar"), "up_data.part07.rar")
        ProgressBar1.Value = 90
    End Sub
    Private Sub Up_autoupdata8()

        Dim dFile As New System.Net.WebClient
        'AddHandler dFile.DownloadProgressChanged, AddressOf ShowDownProgress
        AddHandler dFile.DownloadFileCompleted, AddressOf Wanchen

        dFile.DownloadFileAsync(New Uri(up_root & "up_data.part08.rar"), "up_data.part08.rar")
        ProgressBar1.Value = 100
    End Sub



    Private Sub ShowDownProgress(ByVal sender As Object, ByVal e As System.Net.DownloadProgressChangedEventArgs)
        Invoke(New Action(Of Integer)(Sub(i) ProgressBar1.Value = i / 6), e.ProgressPercentage)
    End Sub
    Sub Wanchen(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
        Label_status.Text = "下载完成"
        Try
            'If RadioButton_updata_cnc1_movies.Checked Then
            'System.IO.File.WriteAllText("up_com.bat", TextBox_up_com_as_cnc1_movies.Text, encoding:=System.Text.Encoding.Default)
            ' System.IO.File.WriteAllText("up_com.bat", My.Resources.up_cnc1_movice, encoding:=System.Text.Encoding.Default)
            'ElseIf RadioButton_updata_ra1_movies.Checked Then
            'System.IO.File.WriteAllText("up_com.bat", TextBox_up_com_as_ra1_movies.Text, encoding:=System.Text.Encoding.Default)
            ' System.IO.File.WriteAllText("up_com.bat", My.Resources.up_ra1_movice, encoding:=System.Text.Encoding.Default)
            ' Else
            'System.IO.File.WriteAllText("up_com.bat", TextBox_up_com.Text, encoding:=System.Text.Encoding.Default)
            System.IO.File.WriteAllText("up_com.bat", My.Resources.up, encoding:=System.Text.Encoding.Default)
            ' End If
            Label_status.Text = "升级完成后将自动重启。"
            'Shell("up_com.bat", Style:=AppWinStyle.NormalFocus)
            Process.Start("up_com.bat")
            Me.Close()
        Catch ex As Exception
            MsgBox（"升级错误，请手动执行 up_data.exe",, "提示")
        End Try
    End Sub


    Private Sub Button_updata_Click(sender As Object, e As EventArgs) Handles Button_updata.Click
        'If RadioButton_updata_cnc1_movies.Checked Or RadioButton_updata_ra1_movies.Checked Then
        'Dim message As String = "更新动画包将耗费更长时间，确定更新动画包?"
        'Dim caption As String = "警告"
        'Dim result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        ' If the no button was pressed ...
        'If (result = DialogResult.No) Then
        ' cancel the closure of the form.
        'Else
        ' Up_autoupdata()
        ' End If
        ' Else
        Up_autoupdata()
        'End If
    End Sub

    'Private Sub jianrongxing()

    '    'MsgBox(cc1_path)
    '    If RadioButton_win10.Checked Then
    '        'Dim key As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("Software/Faxturer", True)
    '        Dim key As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("Software\Microsoft\Windows NT\CurrentVersion\AppCompatFlags", True)
    '        '[HKEY_CURRENT_USER\Software\Microsoft\Windows NT\CurrentVersion\AppCompatFlags\Layers]
    '        Dim subkey As Microsoft.Win32.RegistryKey
    '        subkey = key.CreateSubKey("Layers")
    '        subkey.SetValue(app_path & "\CnC95\C&C95.exe", "~ HIGHDPIAWARE WIN7RTM", Microsoft.Win32.RegistryValueKind.String)
    '        subkey.SetValue(app_path & "\RA\ra95.exe", "~ HIGHDPIAWARE WIN7RTM", Microsoft.Win32.RegistryValueKind.String)
    '        'reg.SetValue("path", New String() {"d:/software/sdf","dfdf"}, Microsoft.Win32.RegistryValueKind.MultiString)
    '        'WriteINI("ddraw", "Windowed", "False", ".\ddraw.ini")
    '    ElseIf RadioButton_win7.Checked Then
    '        Dim key As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("Software\Microsoft\Windows NT\CurrentVersion\AppCompatFlags", True)
    '        '[HKEY_CURRENT_USER\Software\Microsoft\Windows NT\CurrentVersion\AppCompatFlags\Layers]
    '        Dim subkey As Microsoft.Win32.RegistryKey
    '        subkey = key.CreateSubKey("Layers")
    '        subkey.SetValue(app_path & "\CnC95\C&C95.exe", "WIN95", Microsoft.Win32.RegistryValueKind.String)
    '        subkey.SetValue(app_path & "\RA\ra95.exe", "WIN95", Microsoft.Win32.RegistryValueKind.String)
    '    Else

    '    End If
    '    Threading.Thread.Sleep(100)
    'End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button_cnc1_GDI_miss.Click
        'WriteINI("CDControl", "CDPath", "CHI", "CnC95\conquer.ini")
        'WriteINI("Language", "Language", "CHI", "CnC95\conquer.ini")

        If System.Diagnostics.Process.GetProcessesByName("c&c95").Length > 0 Then
            MsgBox("请勿重复启动",, "提示")
        Else
            Try
                System.IO.File.WriteAllBytes(app_path & "\CnC95\cclocal.mix", My.Resources.cclocal_g)
                System.IO.File.SetCreationTime(app_path & "\CnC95\cclocal.mix", New DateTime(2012, 4, 4, 16, 26, 0))
                System.IO.File.SetLastWriteTime(app_path & "\CnC95\cclocal.mix", New DateTime(2012, 4, 4, 16, 26, 0))
            Catch ex As Exception
                MsgBox("汉化异常,关闭杀毒软件后重试",, "提示")
                Exit Sub
            End Try

            Try
                System.IO.File.WriteAllBytes(app_path & "\CnC95\updated.mix", My.Resources.updated_公用)
                System.IO.File.SetCreationTime(app_path & "\CnC95\updated.mix", New DateTime(2011, 3, 26, 19, 18, 0))
                System.IO.File.SetLastWriteTime(app_path & "\CnC95\updated.mix", New DateTime(2011, 3, 26, 19, 18, 0))
            Catch ex As Exception
                MsgBox("汉化异常,关闭杀毒软件后重试",, "提示")
                Exit Sub
            End Try

            ' If My.Computer.FileSystem.FileExists("cnc95\ddraw.dll") Then
            Process.Start("cnc95\c&c95.exe") 'process.star可以启动带有符号的exe，shell启动不了c&c95.exe
            'Else
            'MsgBox("请在设置中点""修复并重置""按钮")
            'End If

        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button_cnc1_NOD_miss.Click
        'WriteINI("CDControl", "CDPath", "CHI", "CnC95\conquer.ini")
        'WriteINI("Language", "Language", "CHI", "CnC95\conquer.ini")


        If System.Diagnostics.Process.GetProcessesByName("c&c95").Length > 0 Then
            MsgBox("请勿重复启动",, "提示")
        Else
            Try
                System.IO.File.WriteAllBytes(app_path & "\CnC95\cclocal.mix", My.Resources.cclocal_n)
                System.IO.File.SetCreationTime(app_path & "\CnC95\cclocal.mix", New DateTime(2012, 4, 4, 16, 26, 0))
                System.IO.File.SetLastWriteTime(app_path & "\CnC95\cclocal.mix", New DateTime(2012, 4, 4, 16, 26, 0))
            Catch ex As Exception
                MsgBox("汉化异常,关闭杀毒软件后重试",, "提示")
                Exit Sub
            End Try

            Try
                System.IO.File.WriteAllBytes(app_path & "\CnC95\updated.mix", My.Resources.updated_公用)
                System.IO.File.SetCreationTime(app_path & "\CnC95\updated.mix", New DateTime(2011, 3, 26, 19, 18, 0))
                System.IO.File.SetLastWriteTime(app_path & "\CnC95\updated.mix", New DateTime(2011, 3, 26, 19, 18, 0))
            Catch ex As Exception
                MsgBox("汉化异常,关闭杀毒软件后重试",, "提示")
                Exit Sub
            End Try

            ' If My.Computer.FileSystem.FileExists("cnc95\ddraw.dll") Then
            Process.Start("cnc95\c&c95.exe") 'process.star可以启动带有符号的exe，shell启动不了c&c95.exe
            'Else
            'MsgBox("请在设置中点""修复并重置""按钮")
            'End If

        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button_cnc1_ext.Click
        'WriteINI("CDControl", "CDPath", "CHI", "CnC95\conquer.ini")
        ' WriteINI("Language", "Language", "CHI", "CnC95\conquer.ini")

        If System.Diagnostics.Process.GetProcessesByName("c&c95").Length > 0 Then
            MsgBox("请勿重复启动",, "提示")
        Else
            Try
                System.IO.File.WriteAllBytes(app_path & "\CnC95\cclocal.mix", My.Resources.cclocal_m)
                System.IO.File.SetCreationTime(app_path & "\CnC95\cclocal.mix", New DateTime(2012, 4, 4, 16, 26, 0))
                System.IO.File.SetLastWriteTime(app_path & "\CnC95\cclocal.mix", New DateTime(2012, 4, 4, 16, 26, 0))
            Catch ex As Exception
                MsgBox("汉化异常,关闭杀毒软件后重试",, "提示")
                Exit Sub
            End Try

            Try
                System.IO.File.WriteAllBytes(app_path & "\CnC95\updated.mix", My.Resources.updated_公用)
                System.IO.File.SetCreationTime(app_path & "\CnC95\updated.mix", New DateTime(2011, 3, 26, 19, 18, 0))
                System.IO.File.SetLastWriteTime(app_path & "\CnC95\updated.mix", New DateTime(2011, 3, 26, 19, 18, 0))
            Catch ex As Exception
                MsgBox("汉化异常,关闭杀毒软件后重试",, "提示")
                Exit Sub
            End Try

            ' If My.Computer.FileSystem.FileExists("cnc95\ddraw.dll") Then
            Process.Start("cnc95\c&c95.exe") 'process.star可以启动带有符号的exe，shell启动不了c&c95.exe
            'Else
            'MsgBox("请在设置中点""修复并重置""按钮")
            'End If

        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button_cnc1_tv.Click
        'WriteINI("CDControl", "CDPath", "CHI", "CnC95\conquer.ini")
        ' WriteINI("Language", "Language", "CHI", "CnC95\conquer.ini")

        If System.Diagnostics.Process.GetProcessesByName("c&c95").Length > 0 Then
            MsgBox("请勿重复启动",, "提示")
        Else
            Try
                System.IO.File.WriteAllBytes(app_path & "\CnC95\cclocal.mix", My.Resources.cclocal_v)
                System.IO.File.SetCreationTime(app_path & "\CnC95\cclocal.mix", New DateTime(2012, 4, 4, 16, 26, 0))
                System.IO.File.SetLastWriteTime(app_path & "\CnC95\cclocal.mix", New DateTime(2012, 4, 4, 16, 26, 0))
            Catch ex As Exception
                MsgBox("汉化异常,关闭杀毒软件后重试",, "提示")
                Exit Sub
            End Try

            Try
                System.IO.File.WriteAllBytes(app_path & "\CnC95\updated.mix", My.Resources.updated_公用)
                System.IO.File.SetCreationTime(app_path & "\CnC95\updated.mix", New DateTime(2011, 3, 26, 19, 18, 0))
                System.IO.File.SetLastWriteTime(app_path & "\CnC95\updated.mix", New DateTime(2011, 3, 26, 19, 18, 0))
            Catch ex As Exception
                MsgBox("汉化异常,关闭杀毒软件后重试",, "提示")
                Exit Sub
            End Try

            ' If My.Computer.FileSystem.FileExists("cnc95\ddraw.dll") Then
            Process.Start("cnc95\c&c95.exe") 'process.star可以启动带有符号的exe，shell启动不了c&c95.exe
            'Else
            'MsgBox("请在设置中点""修复并重置""按钮")
            'End If

        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button_cnc1_english.Click
        'WriteINI("CDControl", "CDPath", ".", "CnC95\conquer.ini")
        'WriteINI("Language", "Language", "eng", "CnC95\conquer.ini")

        If System.Diagnostics.Process.GetProcessesByName("c&c95").Length > 0 Then

            MsgBox("请勿重复启动",, "提示")
        Else
            Try
                System.IO.File.WriteAllBytes(app_path & "\CnC95\cclocal.mix", My.Resources.cclocal_e)
                System.IO.File.SetCreationTime(app_path & "\CnC95\cclocal.mix", New DateTime(2012, 4, 4, 16, 26, 0))
                System.IO.File.SetLastWriteTime(app_path & "\CnC95\cclocal.mix", New DateTime(2012, 4, 4, 16, 26, 0))
            Catch ex As Exception

            End Try

            Try
                My.Computer.FileSystem.DeleteFile(app_path & "\CnC95\updated.mix")
            Catch ex As Exception

            End Try

            ' If My.Computer.FileSystem.FileExists("cnc95\ddraw.dll") Then
            Process.Start("cnc95\c&c95.exe") 'process.star可以启动带有符号的exe，shell启动不了c&c95.exe
            'Else
            'MsgBox("请在设置中点""修复并重置""按钮")
            'End If

        End If
    End Sub

    Private Sub Button_cnc1_cncnet_Click(sender As Object, e As EventArgs) Handles Button_cnc1_cncnet.Click
        'Shell("cncnet5.exe", Style:=AppWinStyle.NormalFocus)
        Process.Start("CnC95\cncnet5.exe")
    End Sub

    Private Sub Button_cnc1_config_Click(sender As Object, e As EventArgs) Handles Button_cnc1_config.Click
        If (System.Diagnostics.Process.GetProcessesByName("ra95").Length > 0) Or
                (System.Diagnostics.Process.GetProcessesByName("ra95p").Length > 0) Or
            (System.Diagnostics.Process.GetProcessesByName("ra95-spawn").Length > 0) Or
            (System.Diagnostics.Process.GetProcessesByName("c&c95").Length > 0) Or
             (System.Diagnostics.Process.GetProcessesByName("cnc95").Length > 0) Or
            (System.Diagnostics.Process.GetProcessesByName("cncnet5").Length > 0) Then

            MsgBox("退出游戏后,再进行设置",, "提示")
        Else
            cnc1cfg.Show()
        End If

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button_ra1_ally.Click
        'System.IO.File.WriteAllBytes(".\RA\ddraw.dll", My.Resources.ddraw_dll)
        'WriteINI("Options", "GameLanguage", "2", "RA\redalert.ini")
        If System.Diagnostics.Process.GetProcessesByName("ra95").Length > 0 Then
            MsgBox("请勿重复启动",, "提示")
        Else
            'If My.Computer.FileSystem.FileExists("cnc95\ddraw.dll") Then

            Try
                System.IO.File.WriteAllBytes(app_path & "\RA\EXPAND9.MIX", My.Resources.allied)
                System.IO.File.SetCreationTime(app_path & "\RA\EXPAND9.MIX", New DateTime(2013, 1, 30, 4, 16, 0))
                System.IO.File.SetLastWriteTime(app_path & "\RA\EXPAND9.MIX", New DateTime(2013, 1, 30, 4, 16, 0))

                If GetINI("ra95", "eva", "chi", ".\config.ini") = "chi" Then
                    Try
                        System.IO.File.WriteAllBytes(app_path & "\ra\speech.mix", My.Resources.raspeechchi)
                    Catch ex As Exception

                    End Try

                Else
                    Try
                        My.Computer.FileSystem.DeleteFile(app_path & "\RA\speech.mix")
                    Catch ex As Exception

                    End Try

                End If
            Catch ex As Exception
                MsgBox("汉化异常,关闭杀毒软件后重试",, "提示")
                Exit Sub
            End Try
            'Process.Start("ra\ra95.exe")
            Dim p = New System.Diagnostics.Process()
            p.StartInfo.WorkingDirectory = app_path & "\ra\"
            p.StartInfo.FileName = "ra95.exe"
            p.Start()
        End If
    End Sub

    Private Sub Button_ra1_soviet_Click(sender As Object, e As EventArgs) Handles Button_ra1_soviet.Click
        'System.IO.File.WriteAllBytes(".\RA\ddraw.dll", My.Resources.ddraw_dll)
        'WriteINI("Options", "GameLanguage", "3", "RA\redalert.ini")
        If System.Diagnostics.Process.GetProcessesByName("ra95").Length > 0 Then
            MsgBox("请勿重复启动",, "提示")
        Else
            'If My.Computer.FileSystem.FileExists("cnc95\ddraw.dll") Then
            Try
                System.IO.File.WriteAllBytes(app_path & "\RA\EXPAND9.MIX", My.Resources.soviet)
                System.IO.File.SetCreationTime(app_path & "\RA\EXPAND9.MIX", New DateTime(2013, 1, 30, 4, 16, 0))
                System.IO.File.SetLastWriteTime(app_path & "\RA\EXPAND9.MIX", New DateTime(2013, 1, 30, 4, 16, 0))
                If GetINI("ra95", "eva", "chi", ".\config.ini") = "chi" Then
                    Try
                        System.IO.File.WriteAllBytes(app_path & "\ra\speech.mix", My.Resources.raspeechchi)
                    Catch ex As Exception

                    End Try

                Else
                    Try
                        My.Computer.FileSystem.DeleteFile(app_path & "\RA\speech.mix")
                    Catch ex As Exception

                    End Try

                End If
            Catch ex As Exception
                MsgBox("汉化异常,关闭杀毒软件后重试",, "提示")
                Exit Sub
            End Try
            'Process.Start("ra\ra95.exe")
            Dim p = New System.Diagnostics.Process()
            p.StartInfo.WorkingDirectory = app_path & "\ra\"
            p.StartInfo.FileName = "ra95.exe"
            p.Start()
            'Else
            'MsgBox("请在设置中打开ddraw")
            'End If

        End If
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button_ra1_skirmish.Click
        'System.IO.File.WriteAllBytes(".\RA\ddraw.dll", My.Resources.ddraw_dll)
        'WriteINI("Options", "GameLanguage", "4", "RA\redalert.ini")
        If System.Diagnostics.Process.GetProcessesByName("ra95").Length > 0 Then
            MsgBox("请勿重复启动",, "提示")
        Else
            'If My.Computer.FileSystem.FileExists("cnc95\ddraw.dll") Then
            Try
                System.IO.File.WriteAllBytes(app_path & "\RA\EXPAND9.MIX", My.Resources.skirmish)
                System.IO.File.SetCreationTime(app_path & "\RA\EXPAND9.MIX", New DateTime(2013, 1, 30, 4, 16, 0))
                System.IO.File.SetLastWriteTime(app_path & "\RA\EXPAND9.MIX", New DateTime(2013, 1, 30, 4, 16, 0))
                If GetINI("ra95", "eva", "chi", ".\config.ini") = "chi" Then
                    Try
                        System.IO.File.WriteAllBytes(app_path & "\ra\speech.mix", My.Resources.raspeechchi)
                    Catch ex As Exception

                    End Try

                Else
                    Try
                        My.Computer.FileSystem.DeleteFile(app_path & "\RA\speech.mix")
                    Catch ex As Exception

                    End Try

                End If
            Catch ex As Exception
                MsgBox("汉化异常,关闭杀毒软件后重试",, "提示")
                Exit Sub
            End Try
            'Process.Start("ra\ra95", "-SKIRMISH")
            'Process.Start("ra\ra.bat")
            Dim p = New System.Diagnostics.Process()
            p.StartInfo.WorkingDirectory = app_path & "\ra\"
            p.StartInfo.FileName = "ra95.exe"
            p.StartInfo.Arguments = "-SKIRMISH"
            p.Start()

            'Process.Start("ra\ra95", "-SKIRMISH")
            'Else
            'MsgBox("请在设置中打开ddraw")
            'End If

        End If
        'Process.Start("ra\ra95.exe", "-SKIRMISH")
    End Sub

    Private Sub Button_ra1_ext_Click(sender As Object, e As EventArgs) Handles Button_ra1_ext_cs.Click
        'System.IO.File.WriteAllBytes(".\RA\ddraw.dll", My.Resources.ddraw_dll)
        'WriteINI("Options", "GameLanguage", "5", "RA\redalert.ini")
        If System.Diagnostics.Process.GetProcessesByName("ra95").Length > 0 Then
            MsgBox("请勿重复启动",, "提示")
        Else
            'If My.Computer.FileSystem.FileExists("cnc95\ddraw.dll") Then
            Try
                System.IO.File.WriteAllBytes(app_path & "\RA\campaign.mix", My.Resources.cs)
                System.IO.File.SetCreationTime(app_path & "\RA\campaign.mix", New DateTime(2013, 1, 30, 4, 16, 0))
                System.IO.File.SetLastWriteTime(app_path & "\RA\campaign.mix", New DateTime(2013, 1, 30, 4, 16, 0))
                If GetINI("ra95", "eva", "chi", ".\config.ini") = "chi" Then
                    Try
                        System.IO.File.WriteAllBytes(app_path & "\ra\speech.mix", My.Resources.raspeechchi)
                    Catch ex As Exception

                    End Try

                Else
                    Try
                        My.Computer.FileSystem.DeleteFile(app_path & "\RA\speech.mix")
                    Catch ex As Exception

                    End Try

                End If
            Catch ex As Exception
                MsgBox("汉化异常,关闭杀毒软件后重试",, "提示")
                Exit Sub
            End Try
            Dim p = New System.Diagnostics.Process()
            p.StartInfo.WorkingDirectory = app_path & "\ra\"
            p.StartInfo.FileName = "ra95.exe"
            p.Start()
            'Process.Start("ra\ra95.exe")
            'Else
            'MsgBox("请在设置中打开ddraw")
            'End If

        End If
    End Sub

    Private Sub Button_ra1_ext_af_Click(sender As Object, e As EventArgs) Handles Button_ra1_ext_af.Click
        'System.IO.File.WriteAllBytes(".\RA\ddraw.dll", My.Resources.ddraw_dll)
        'WriteINI("Options", "GameLanguage", "6", "RA\redalert.ini")
        If System.Diagnostics.Process.GetProcessesByName("ra95").Length > 0 Then
            MsgBox("请勿重复启动",, "提示")
        Else
            'If My.Computer.FileSystem.FileExists("cnc95\ddraw.dll") Then
            Try
                System.IO.File.WriteAllBytes(app_path & "\RA\campaign.mix", My.Resources.am_allied)
                System.IO.File.SetCreationTime(app_path & "\RA\campaign.mix", New DateTime(2013, 1, 30, 4, 16, 0))
                System.IO.File.SetLastWriteTime(app_path & "\RA\campaign.mix", New DateTime(2013, 1, 30, 4, 16, 0))
                If GetINI("ra95", "eva", "chi", ".\config.ini") = "chi" Then
                    Try
                        System.IO.File.WriteAllBytes(app_path & "\ra\speech.mix", My.Resources.raspeechchi)
                    Catch ex As Exception

                    End Try

                Else
                    Try
                        My.Computer.FileSystem.DeleteFile(app_path & "\RA\speech.mix")
                    Catch ex As Exception

                    End Try

                End If
            Catch ex As Exception
                MsgBox("汉化异常,关闭杀毒软件后重试",, "提示")
                Exit Sub
            End Try
            Dim p = New System.Diagnostics.Process()
            p.StartInfo.WorkingDirectory = app_path & "\ra\"
            p.StartInfo.FileName = "ra95.exe"
            p.Start()
            'Process.Start("ra\ra95.exe")
            'Else
            'MsgBox("请在设置中打开ddraw")
            'End If

        End If
    End Sub

    Private Sub Button_ra1_ext_af_su_Click(sender As Object, e As EventArgs) Handles Button_ra1_ext_af_su.Click
        'System.IO.File.WriteAllBytes(".\RA\ddraw.dll", My.Resources.ddraw_dll)
        'WriteINI("Options", "GameLanguage", "7", "RA\redalert.ini")
        If System.Diagnostics.Process.GetProcessesByName("ra95").Length > 0 Then
            MsgBox("请勿重复启动",, "提示")
        Else
            'If My.Computer.FileSystem.FileExists("cnc95\ddraw.dll") Then
            Try
                System.IO.File.WriteAllBytes(app_path & "\RA\campaign.mix", My.Resources.am_soviet)
                System.IO.File.SetCreationTime(app_path & "\RA\campaign.mix", New DateTime(2013, 1, 30, 4, 16, 0))
                System.IO.File.SetLastWriteTime(app_path & "\RA\campaign.mix", New DateTime(2013, 1, 30, 4, 16, 0))
                If GetINI("ra95", "eva", "chi", ".\config.ini") = "chi" Then
                    Try
                        System.IO.File.WriteAllBytes(app_path & "\ra\speech.mix", My.Resources.raspeechchi)
                    Catch ex As Exception

                    End Try

                Else
                    Try
                        My.Computer.FileSystem.DeleteFile(app_path & "\RA\speech.mix")
                    Catch ex As Exception

                    End Try

                End If
            Catch ex As Exception
                MsgBox("汉化异常,关闭杀毒软件后重试",, "提示")
                Exit Sub
            End Try
            Dim p = New System.Diagnostics.Process()
            p.StartInfo.WorkingDirectory = app_path & "\ra\"
            p.StartInfo.FileName = "ra95.exe"
            p.Start()
            'Process.Start("ra\ra95.exe")
            'Else
            'MsgBox("请在设置中打开ddraw")
            'End If

        End If
    End Sub

    Private Sub Button_cncnet_Click(sender As Object, e As EventArgs) Handles Button_ra1_cncnet.Click
        'System.IO.File.WriteAllBytes(".\RA\ddraw.dll", My.Resources.ddraw_dll)
        'WriteINI("Options", "GameLanguage", "4", "RA\redalert.ini")
        Try
            System.IO.File.WriteAllBytes(app_path & "\RA\EXPAND9.MIX", My.Resources.skirmish)
            System.IO.File.SetCreationTime(app_path & "\RA\EXPAND9.MIX", New DateTime(2013, 1, 30, 4, 16, 0))
            System.IO.File.SetLastWriteTime(app_path & "\RA\EXPAND9.MIX", New DateTime(2013, 1, 30, 4, 16, 0))
            If GetINI("ra95", "eva", "chi", ".\config.ini") = "chi" Then
                Try
                    System.IO.File.WriteAllBytes(app_path & "\ra\speech.mix", My.Resources.raspeechchi)
                Catch ex As Exception

                End Try

            Else
                Try
                    My.Computer.FileSystem.DeleteFile(app_path & "\RA\speech.mix")
                Catch ex As Exception

                End Try

            End If
        Catch ex As Exception
            MsgBox("汉化异常,关闭杀毒软件后重试",, "提示")
            Exit Sub
        End Try
        Dim p = New System.Diagnostics.Process()
        p.StartInfo.WorkingDirectory = app_path & "\ra\"
        p.StartInfo.FileName = "cncnet5.exe"
        p.Start()
        'Process.Start("ra\cncnet5.exe")
    End Sub



    Private Sub Button_ra1_english_Click(sender As Object, e As EventArgs) Handles Button_ra1_english.Click
        'System.IO.File.WriteAllBytes(".\RA\ddraw.dll", My.Resources.ddraw_dll)
        WriteINI("Options", "GameLanguage", "1", "RA\redalert.ini")
        If System.Diagnostics.Process.GetProcessesByName("ra95").Length > 0 Then
            MsgBox("请勿重复启动",, "提示")
        Else
            Try
                System.IO.File.Delete(app_path & "\RA\EXPAND9.MIX")
                System.IO.File.Delete(app_path & "\RA\campaign.mix")
                System.IO.File.Delete(app_path & "\RA\speech.mix")

                Try
                    My.Computer.FileSystem.DeleteFile(app_path & "\RA\speech.mix")
                Catch ex As Exception

                End Try


            Catch ex As Exception

            End Try
            Dim p = New System.Diagnostics.Process()
            p.StartInfo.WorkingDirectory = app_path & "\ra\"
            p.StartInfo.FileName = "ra95.exe"
            p.Start()
            'Process.Start("ra\ra95.exe")

        End If
    End Sub

    Private Sub Button_ra1_config_Click(sender As Object, e As EventArgs) Handles Button_ra1_config.Click
        If (System.Diagnostics.Process.GetProcessesByName("ra95").Length > 0) Or
           (System.Diagnostics.Process.GetProcessesByName("ra95p").Length > 0) Or
           (System.Diagnostics.Process.GetProcessesByName("ra95-spawn").Length > 0) Or
           (System.Diagnostics.Process.GetProcessesByName("c&c95").Length > 0) Or
           (System.Diagnostics.Process.GetProcessesByName("cnc95").Length > 0) Or
           (System.Diagnostics.Process.GetProcessesByName("cncnet5").Length > 0) Then
            MsgBox("退出游戏后,再进行设置",, "提示")
        Else
            ra1cfg.Show()
        End If


    End Sub

    Private Sub Button_back_Click(sender As Object, e As EventArgs) Handles Button_back.Click
        Panel_up_log.Visible = True
        Panel_cnc1.Visible = False
        Panel_ra1.Visible = False
        WebBrowser1.Url = New Uri("http://yjfyeyu.gitee.io/cnc_chi_readme/readme.htm")
    End Sub


    Private Sub fix()

        'fix 启动运行一次.imer_delete_file,只要不运行游戏就运行
        If My.Computer.FileSystem.FileExists(app_path & "\CnC95\conquer.mix") Then
            Try
                My.Computer.FileSystem.DeleteFile(app_path & "\CnC95\C&C95.exe")
            Catch ex As Exception

            End Try

            Try
                System.IO.File.WriteAllBytes(app_path & "\CnC95\C&C95.exe", My.Resources.C_C95exe)
                System.IO.File.SetCreationTime(app_path & "\CnC95\C&C95.exe", New DateTime(2019, 2, 2, 15, 27, 0))
                System.IO.File.SetLastWriteTime(app_path & "\CnC95\C&C95.exe", New DateTime(2019, 2, 2, 15, 27, 0))
            Catch ex As Exception
                MsgBox("C&C95.exe文件读写错误,可删除此文件后重试",, "提示")
                Me.Close()
            End Try
        End If

        If My.Computer.FileSystem.FileExists(app_path & "\RA\REDALERT.MIX") Then
            Try
                My.Computer.FileSystem.DeleteFile(app_path & "\RA\ra95.exe")
            Catch ex As Exception

            End Try

            Try
                System.IO.File.WriteAllBytes(app_path & "\RA\ra95.exe", My.Resources.ra95exe)
                System.IO.File.SetCreationTime(app_path & "\RA\ra95.exe", New DateTime(2019, 4, 30, 22, 9, 0))
                System.IO.File.SetLastWriteTime(app_path & "\RA\ra95.exe", New DateTime(2019, 4, 30, 22, 9, 0))
            Catch ex As Exception
                MsgBox("ra95.exe文件读写错误,可删除此文件后重试",, "提示")
                Me.Close()
            End Try

        End If

    End Sub

    Private Sub Timer_delete_file_Tick(sender As Object, e As EventArgs) Handles Timer_delete_file.Tick
        If (System.Diagnostics.Process.GetProcessesByName("ra95").Length > 0) Or
           (System.Diagnostics.Process.GetProcessesByName("ra95p").Length > 0) Or
           (System.Diagnostics.Process.GetProcessesByName("ra95-spawn").Length > 0) Or
           (System.Diagnostics.Process.GetProcessesByName("c&c95").Length > 0) Or
           (System.Diagnostics.Process.GetProcessesByName("cnc95").Length > 0) Or
           (System.Diagnostics.Process.GetProcessesByName("cncnet5").Length > 0) Then
        Else
            Try
                If My.Computer.FileSystem.GetFileInfo(app_path & "\CnC95\cclocal.mix").Length <> 156307 Then
                    System.IO.File.WriteAllBytes(app_path & "\CnC95\cclocal.mix", My.Resources.cclocal_e)
                    System.IO.File.SetCreationTime(app_path & "\CnC95\cclocal.mix", New DateTime(2012, 4, 4, 16, 26, 0))
                    System.IO.File.SetLastWriteTime(app_path & "\CnC95\cclocal.mix", New DateTime(2012, 4, 4, 16, 26, 0))
                End If
            Catch ex As Exception

            End Try
            Delete_files()
        End If

    End Sub



    Private Sub Button_donate_Click(sender As Object, e As EventArgs) Handles Button_donate.Click
        donate.Show()
    End Sub

    Private Sub show_game_logo()
        Dim b_p As Point, l_p As Point
        b_p = Button_cnc1.Location
        l_p = Label_cnc1.Location

        If My.Computer.FileSystem.FileExists(app_path & "\CnC95\conquer.mix") Then
            Button_cnc1.Visible = True
            Button_cnc1.Enabled = True
            Label_cnc1.Visible = True
            Label_cnc1.Enabled = True
            b_p.Y = b_p.Y + 100
            l_p.Y = l_p.Y + 100
        Else
            Button_cnc1.Visible = False
            Label_cnc1.Visible = False
        End If

        If My.Computer.FileSystem.FileExists(app_path & "\RA\REDALERT.MIX") Then
            l_p.X = l_p.X + 4
            Button_ra1.Location = b_p
            Label_ra1.Location = l_p
            Button_ra1.Visible = True
            Button_ra1.Enabled = True
            Label_ra1.Visible = True
            Label_ra1.Enabled = True
            b_p.Y = b_p.Y + 100
            l_p.Y = l_p.Y + 100
        Else
            Button_ra1.Visible = False
            Label_ra1.Visible = False
        End If

        If My.Computer.FileSystem.FileExists(app_path & "\dune2000\dune2000.exe") Then
            l_p.X = l_p.X + 4
            Button_ra1.Location = b_p
            Label_ra1.Location = l_p
            Button_d2k.Visible = True
            Button_d2k.Enabled = True
            Label_d2k.Visible = True
            Label_d2k.Enabled = True
            b_p.Y = b_p.Y + 100
            l_p.Y = l_p.Y + 100
        Else
            Button_d2k.Visible = False
            Label_d2k.Visible = False
        End If

        If My.Computer.FileSystem.FileExists(app_path & "\ts\game.exe") Then
            l_p.X = l_p.X + 4
            Button_ts.Location = b_p
            Label_ts.Location = l_p
            Button_ts.Visible = True
            Button_ts.Enabled = True
            Label_ts.Visible = True
            Label_ts.Enabled = True
            b_p.Y = b_p.Y + 100
            l_p.Y = l_p.Y + 100
        Else
            Button_ts.Visible = False
            Label_ts.Visible = False
        End If

    End Sub

    Private Sub Button_cnc1_GDI_miss_MouseMove(sender As Object, e As MouseEventArgs) Handles Button_cnc1_GDI_miss.MouseMove, Button_cnc1_NOD_miss.MouseMove,
              Button_cnc1_ext.MouseMove, Button_cnc1_tv.MouseMove, Button_cnc1_cncnet.MouseMove, Button_cnc1_english.MouseMove, Button_cnc1_config.MouseMove

        sender.ForeColor = Color.FromArgb(84， 252， 84)
    End Sub

    Private Sub Button_cnc1_GDI_miss_MouseLeave(sender As Object, e As EventArgs) Handles Button_cnc1_GDI_miss.MouseLeave, Button_cnc1_NOD_miss.MouseLeave,
            Button_cnc1_ext.MouseLeave, Button_cnc1_tv.MouseLeave, Button_cnc1_cncnet.MouseLeave, Button_cnc1_config.MouseLeave, Button_cnc1_english.MouseLeave

        sender.ForeColor = Color.FromArgb(84， 176， 36)
    End Sub

    Private Sub Button_ra1_ally_MouseMove(sender As Object, e As MouseEventArgs) Handles Button_ra1_ally.MouseMove, Button_ra1_soviet.MouseMove,
    Button_ra1_ext_cs.MouseMove, Button_ra1_ext_af.MouseMove, Button_ra1_ext_af_su.MouseMove, Button_ra1_skirmish.MouseMove, Button_ra1_cncnet.MouseMove,
    Button_ra1_english.MouseMove, Button_ra1_config.MouseMove

        sender.ForeColor = Color.FromArgb(252， 244， 220)

    End Sub

    Private Sub Button_ra1_ally_Mouseleave(sender As Object, e As EventArgs) Handles Button_ra1_ally.MouseLeave, Button_ra1_soviet.MouseLeave,
    Button_ra1_ext_cs.MouseLeave, Button_ra1_ext_af.MouseLeave, Button_ra1_ext_af_su.MouseLeave, Button_ra1_skirmish.MouseLeave, Button_ra1_cncnet.MouseLeave,
    Button_ra1_english.MouseLeave, Button_ra1_config.MouseLeave

        sender.ForeColor = Color.FromArgb(204， 0， 0)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

        ' MsgBox(My.Computer.FileSystem.GetFileInfo(app_path & "\CnC95\cclocal.mix").Length)
    End Sub

    Private Sub RadioButton_updata_gitee_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_updata_gitee.CheckedChanged
        Label_status.Text = "正在检测更新......"
        Button_cnc1.Enabled = False
        Label_cnc1.Enabled = False
        Button_ra1.Enabled = False
        Label_ra1.Enabled = False
        GroupBox_updata.Enabled = False
        Button_updata.Enabled = False
        If RadioButton_updata_gitee.Checked = True Then
            up_root = "https://gitee.com/yjfyeyu/updatasys/raw/master/WestWood_Classic/"
            BackgroundWorker_check_ver.RunWorkerAsync()
        End If
    End Sub

    Private Sub RadioButton_updata_butwhy_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_updata_butwhy.CheckedChanged
        Label_status.Text = "正在检测更新......"
        Button_cnc1.Enabled = False
        Label_cnc1.Enabled = False
        Button_ra1.Enabled = False
        Label_ra1.Enabled = False
        GroupBox_updata.Enabled = False
        Button_updata.Enabled = False
        If RadioButton_updata_butwhy.Checked = True Then
            up_root = "http://butwhy.vicp.net:82/tuzi_updata/WestWood_Classic/"
            BackgroundWorker_check_ver.RunWorkerAsync()
        End If
    End Sub

    Private Sub RadioButton_updata_2_web_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_updata_github.CheckedChanged
        Label_status.Text = "正在检测更新......"
        Button_cnc1.Enabled = False
        Label_cnc1.Enabled = False
        Button_ra1.Enabled = False
        Label_ra1.Enabled = False
        GroupBox_updata.Enabled = False
        Button_updata.Enabled = False
        If RadioButton_updata_github.Checked = True Then
            up_root = "https://raw.githubusercontent.com/yjfyy/tuzi_updata/master/WestWood_Classic/"
            BackgroundWorker_check_ver.RunWorkerAsync()
        End If

    End Sub

    Private Sub Button_reg_ddraw_Click(sender As Object, e As EventArgs) Handles Button_reg_ddraw.Click
        Microsoft.Win32.Registry.SetValue("HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Session Manager", "ExcludeFromKnownDlls", "ddraw.dll")
        MsgBox("修复成功,请重启电脑",, "提示")
    End Sub
End Class
