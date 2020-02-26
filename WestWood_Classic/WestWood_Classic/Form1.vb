Imports System.ComponentModel
Imports System.IO
Imports System.Runtime.Remoting.Channels
Imports System.Text




Public Class Form1
    Dim l_version
    Dim r_version
    ' Dim newuplog As String
    'Dim up_root = "https://gitee.com/yjfyeyu/updatasys/raw/master/WestWood_Classic/"
    'Dim up_root = "https://raw.githubusercontent.com/yjfyy/tuzi_updata/master/WestWood_Classic/"
    Dim up_root = "http://butwhy.vicp.net:82/tuzi_updata/WestWood_Classic/"
    'Dim up_root = "https://gitlab.com/yjfyy/tuzi_updata/raw/master/WestWood_Classic/"

    Dim app_path As String = Application.StartupPath()
    Dim date2 = New DateTime(2020, 3, 5)

    Private Sub Button_cnc1_Click(sender As Object, e As EventArgs) Handles Button_cnc1.Click

        If GetINI("cnc1", "fristrun", "1", ".\config.ini") = "1" Then
            MsgBox（"第一次启动游戏前必须先设置参数"）
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
            MsgBox（"第一次启动游戏前必须先设置参数"）
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
        Delete_files()

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
            'up_root = "http://code.taobao.org/svn/yxgcsj/trunk/WestWood_Classic/"
        Else
            MsgBox("未能确认操作系统版本，请手动选择")
            GroupBox1.Enabled = True
        End If


    End Sub


    Private Sub Delete_files()

        '清理释放的汉化
        Try
            System.IO.File.Delete(app_path & "\RA\EXPAND9.MIX")
        Catch ex As Exception

        End Try

        Try
            System.IO.File.Delete(app_path & " \CnC95\lang_chi.mix")
        Catch ex As Exception

        End Try

        Try
            System.IO.File.Delete(app_path & " \CnC95\updated.mix")
        Catch ex As Exception

        End Try

        '清理旧版本视频
        Try
            My.Computer.FileSystem.DeleteDirectory(app_path & "\CnC95\chi", onDirectoryNotEmpty:=FileIO.DeleteDirectoryOption.DeleteAllContents)
        Catch ex As Exception
        End Try

        '到期删除旧汉化
        '删除原来的汉化文件
        '1.56删除原始汉化文件，使用新版
        Dim date1 = Date.Now()  '获得当前本地日期和时间。这里也可以省略Date.，直接用Now()
        Dim date2 = New DateTime(2020, 3, 1)
        If date1 > date2 Then

            Try
                System.IO.File.Delete(app_path & "\attach\ddraw.dll")
            Catch ex As Exception

            End Try

            Try
                System.IO.File.Delete(app_path & "\attach\ddraw.dll.cnc106")
            Catch ex As Exception

            End Try

            Try
                System.IO.File.Delete(app_path & "\attach\speecchi.mix")
            Catch ex As Exception

            End Try

            Try
                System.IO.File.Delete(app_path & "\attach\xtitle.864")
            Catch ex As Exception

            End Try

            Try
                System.IO.File.Delete(app_path & "\attach\xtitle.1728")
            Catch ex As Exception

            End Try

            Try
                System.IO.File.Delete(app_path & "\attach\xtitle.1920")
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
                My.Computer.FileSystem.DeleteFile(app_path & "\RA\russianlanguagepack.mix")
            Catch ex As Exception
            End Try

            Try
                My.Computer.FileSystem.DeleteFile(app_path & "\RA\germanuncensoredlanguagepack.mix")
            Catch ex As Exception
            End Try

            Try
                My.Computer.FileSystem.DeleteFile(app_path & "\RA\spanishlanguagepack.mix")
            Catch ex As Exception
            End Try

            Try
                My.Computer.FileSystem.DeleteFile(app_path & "\RA\frenchlanguagepack.mix")
            Catch ex As Exception
            End Try

            Try
                My.Computer.FileSystem.DeleteFile(app_path & "\RA\germancensoredlanguagepack.mix")
            Catch ex As Exception
            End Try

            Try
                My.Computer.FileSystem.DeleteFile(app_path & "\RA\germanlanguagepack.mix")
            Catch ex As Exception
            End Try



            Try
                My.Computer.FileSystem.DeleteFile(app_path & "\CnC95\lang_chn.mix")
            Catch ex As Exception
            End Try

            Try
                My.Computer.FileSystem.DeleteFile(app_path & "\CnC95\lang_chg.mix")
            Catch ex As Exception
            End Try

            Try
                My.Computer.FileSystem.DeleteFile(app_path & "\CnC95\lang_chv.mix")
            Catch ex As Exception
            End Try

            Try
                My.Computer.FileSystem.DeleteFile(app_path & "\CnC95\lang_chm.mix")
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

        End If

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
        Dim upUri_version As New Uri(up_root & "version.txt")
        Try
            r_version = dFile.DownloadString(upUri_version)
        Catch ex As Exception
            r_version = "0"
        End Try
        'MsgBox(upUri_version.ToString)
    End Sub
    Private Sub BackgroundWorker_check_ver_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker_check_ver.RunWorkerCompleted

        Label_r_version.Text = r_version
        GroupBox_updata.Enabled = True
        If r_version = "0" Then
            Label_status.Text = "检测失败"

            'Button_cnc1.Enabled = True
            'Label_cnc1.Enabled = True

            ' Button_ra1.Enabled = True
            'Label_ra1.Enabled = True
            show_game_logo()


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
        Dim upUri_up_data As New Uri(up_root & "up_data.exe")
        AddHandler dFile.DownloadProgressChanged, AddressOf ShowDownProgress
        AddHandler dFile.DownloadFileCompleted, AddressOf Wanchen
        Label_status.Text = "正在下载..."

        dFile.DownloadFileAsync(upUri_up_data, "up_data.exe")
        'BackgroundWorker_download_updata.RunWorkerAsync()

    End Sub

    Private Sub ShowDownProgress(ByVal sender As Object, ByVal e As System.Net.DownloadProgressChangedEventArgs)
        Invoke(New Action(Of Integer)(Sub(i) ProgressBar1.Value = i), e.ProgressPercentage)
    End Sub
    Sub Wanchen(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
        Label_status.Text = "下载完成"
        Try
            If RadioButton_updata_cnc1_movies.Checked Then
                'System.IO.File.WriteAllText("up_com.bat", TextBox_up_com_as_cnc1_movies.Text, encoding:=System.Text.Encoding.Default)
                System.IO.File.WriteAllText("up_com.bat", My.Resources.up_cnc1_movice, encoding:=System.Text.Encoding.Default)
            ElseIf RadioButton_updata_ra1_movies.Checked Then
                'System.IO.File.WriteAllText("up_com.bat", TextBox_up_com_as_ra1_movies.Text, encoding:=System.Text.Encoding.Default)
                System.IO.File.WriteAllText("up_com.bat", My.Resources.up_ra1_movice, encoding:=System.Text.Encoding.Default)
            Else
                'System.IO.File.WriteAllText("up_com.bat", TextBox_up_com.Text, encoding:=System.Text.Encoding.Default)
                System.IO.File.WriteAllText("up_com.bat", My.Resources.up, encoding:=System.Text.Encoding.Default)
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

    End Sub

    Private Sub Button_updata_Click(sender As Object, e As EventArgs) Handles Button_updata.Click
        If RadioButton_updata_cnc1_movies.Checked Or RadioButton_updata_ra1_movies.Checked Then
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
        WriteINI("CDControl", "CDPath", "CHI", "CnC95\conquer.ini")
        WriteINI("Language", "Language", "CHI", "CnC95\conquer.ini")

        If System.Diagnostics.Process.GetProcessesByName("c&c95").Length > 0 Then
            MsgBox("请勿重复启动")
        Else
            Try
                System.IO.File.WriteAllBytes(app_path & "\CnC95\cclocal.mix", My.Resources.cclocal_g)
                System.IO.File.SetCreationTime(app_path & "\CnC95\cclocal.mix", New DateTime(2012, 4, 4, 16, 26, 0))
                System.IO.File.SetLastWriteTime(app_path & "\CnC95\cclocal.mix", New DateTime(2012, 4, 4, 16, 26, 0))
            Catch ex As Exception
                MsgBox("汉化异常,关闭杀毒软件后重试")
                Exit Sub
            End Try

            Try
                System.IO.File.WriteAllBytes(app_path & "\CnC95\updated.mix", My.Resources.updated_公用)
                System.IO.File.SetCreationTime(app_path & "\CnC95\updated.mix", New DateTime(2011, 3, 26, 19, 18, 0))
                System.IO.File.SetLastWriteTime(app_path & "\CnC95\updated.mix", New DateTime(2011, 3, 26, 19, 18, 0))
            Catch ex As Exception
                MsgBox("汉化异常,关闭杀毒软件后重试")
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
        WriteINI("CDControl", "CDPath", "CHI", "CnC95\conquer.ini")
        WriteINI("Language", "Language", "CHI", "CnC95\conquer.ini")


        If System.Diagnostics.Process.GetProcessesByName("c&c95").Length > 0 Then
            MsgBox("请勿重复启动")
        Else
            Try
                System.IO.File.WriteAllBytes(app_path & "\CnC95\cclocal.mix", My.Resources.cclocal_n)
                System.IO.File.SetCreationTime(app_path & "\CnC95\cclocal.mix", New DateTime(2012, 4, 4, 16, 26, 0))
                System.IO.File.SetLastWriteTime(app_path & "\CnC95\cclocal.mix", New DateTime(2012, 4, 4, 16, 26, 0))
            Catch ex As Exception
                MsgBox("汉化异常,关闭杀毒软件后重试")
                Exit Sub
            End Try

            Try
                System.IO.File.WriteAllBytes(app_path & "\CnC95\updated.mix", My.Resources.updated_公用)
                System.IO.File.SetCreationTime(app_path & "\CnC95\updated.mix", New DateTime(2011, 3, 26, 19, 18, 0))
                System.IO.File.SetLastWriteTime(app_path & "\CnC95\updated.mix", New DateTime(2011, 3, 26, 19, 18, 0))
            Catch ex As Exception
                MsgBox("汉化异常,关闭杀毒软件后重试")
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
        WriteINI("CDControl", "CDPath", "CHI", "CnC95\conquer.ini")
        WriteINI("Language", "Language", "CHI", "CnC95\conquer.ini")

        If System.Diagnostics.Process.GetProcessesByName("c&c95").Length > 0 Then
            MsgBox("请勿重复启动")
        Else
            Try
                System.IO.File.WriteAllBytes(app_path & "\CnC95\cclocal.mix", My.Resources.cclocal_m)
                System.IO.File.SetCreationTime(app_path & "\CnC95\cclocal.mix", New DateTime(2012, 4, 4, 16, 26, 0))
                System.IO.File.SetLastWriteTime(app_path & "\CnC95\cclocal.mix", New DateTime(2012, 4, 4, 16, 26, 0))
            Catch ex As Exception
                MsgBox("汉化异常,关闭杀毒软件后重试")
                Exit Sub
            End Try

            Try
                System.IO.File.WriteAllBytes(app_path & "\CnC95\updated.mix", My.Resources.updated_公用)
                System.IO.File.SetCreationTime(app_path & "\CnC95\updated.mix", New DateTime(2011, 3, 26, 19, 18, 0))
                System.IO.File.SetLastWriteTime(app_path & "\CnC95\updated.mix", New DateTime(2011, 3, 26, 19, 18, 0))
            Catch ex As Exception
                MsgBox("汉化异常,关闭杀毒软件后重试")
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
        WriteINI("CDControl", "CDPath", "CHI", "CnC95\conquer.ini")
        WriteINI("Language", "Language", "CHI", "CnC95\conquer.ini")

        If System.Diagnostics.Process.GetProcessesByName("c&c95").Length > 0 Then
            MsgBox("请勿重复启动")
        Else
            Try
                System.IO.File.WriteAllBytes(app_path & "\CnC95\cclocal.mix", My.Resources.cclocal_v)
                System.IO.File.SetCreationTime(app_path & "\CnC95\cclocal.mix", New DateTime(2012, 4, 4, 16, 26, 0))
                System.IO.File.SetLastWriteTime(app_path & "\CnC95\cclocal.mix", New DateTime(2012, 4, 4, 16, 26, 0))
            Catch ex As Exception
                MsgBox("汉化异常,关闭杀毒软件后重试")
                Exit Sub
            End Try

            Try
                System.IO.File.WriteAllBytes(app_path & "\CnC95\updated.mix", My.Resources.updated_公用)
                System.IO.File.SetCreationTime(app_path & "\CnC95\updated.mix", New DateTime(2011, 3, 26, 19, 18, 0))
                System.IO.File.SetLastWriteTime(app_path & "\CnC95\updated.mix", New DateTime(2011, 3, 26, 19, 18, 0))
            Catch ex As Exception
                MsgBox("汉化异常,关闭杀毒软件后重试")
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
        WriteINI("CDControl", "CDPath", ".", "CnC95\conquer.ini")
        WriteINI("Language", "Language", "eng", "CnC95\conquer.ini")

        If System.Diagnostics.Process.GetProcessesByName("c&c95").Length > 0 Then

            MsgBox("请勿重复启动")
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
        'Shell("CCConfig.exe", Style:=AppWinStyle.NormalFocus)
        'Process.Start("CnC95\CCConfig.exe")
        cnc1cfg.Show()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button_ra1_ally.Click
        'System.IO.File.WriteAllBytes(".\RA\ddraw.dll", My.Resources.ddraw_dll)
        'WriteINI("Options", "GameLanguage", "2", "RA\redalert.ini")
        If System.Diagnostics.Process.GetProcessesByName("ra95").Length > 0 Then
            MsgBox("请勿重复启动")
        Else
            'If My.Computer.FileSystem.FileExists("cnc95\ddraw.dll") Then
            Try
                System.IO.File.WriteAllBytes(app_path & "\RA\EXPAND9.MIX", My.Resources.allied)
                System.IO.File.SetCreationTime(app_path & "\RA\EXPAND9.MIX", New DateTime(2013, 1, 30, 4, 16, 0))
                System.IO.File.SetLastWriteTime(app_path & "\RA\EXPAND9.MIX", New DateTime(2013, 1, 30, 4, 16, 0))
            Catch ex As Exception
                MsgBox("汉化异常,关闭杀毒软件后重试")
                Exit Sub
            End Try
            Process.Start("ra\ra95.exe")
        End If
    End Sub

    Private Sub Button_ra1_soviet_Click(sender As Object, e As EventArgs) Handles Button_ra1_soviet.Click
        'System.IO.File.WriteAllBytes(".\RA\ddraw.dll", My.Resources.ddraw_dll)
        'WriteINI("Options", "GameLanguage", "3", "RA\redalert.ini")
        If System.Diagnostics.Process.GetProcessesByName("ra95").Length > 0 Then
            MsgBox("请勿重复启动")
        Else
            'If My.Computer.FileSystem.FileExists("cnc95\ddraw.dll") Then
            Try
                System.IO.File.WriteAllBytes(app_path & "\RA\EXPAND9.MIX", My.Resources.soviet)
                System.IO.File.SetCreationTime(app_path & "\RA\EXPAND9.MIX", New DateTime(2013, 1, 30, 4, 16, 0))
                System.IO.File.SetLastWriteTime(app_path & "\RA\EXPAND9.MIX", New DateTime(2013, 1, 30, 4, 16, 0))
            Catch ex As Exception
                MsgBox("汉化异常,关闭杀毒软件后重试")
                Exit Sub
            End Try
            Process.Start("ra\ra95.exe")
            'Else
            'MsgBox("请在设置中打开ddraw")
            'End If

        End If
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button_ra1_skirmish.Click
        'System.IO.File.WriteAllBytes(".\RA\ddraw.dll", My.Resources.ddraw_dll)
        'WriteINI("Options", "GameLanguage", "4", "RA\redalert.ini")
        If System.Diagnostics.Process.GetProcessesByName("ra95").Length > 0 Then
            MsgBox("请勿重复启动")
        Else
            'If My.Computer.FileSystem.FileExists("cnc95\ddraw.dll") Then
            Try
                System.IO.File.WriteAllBytes(app_path & "\RA\EXPAND9.MIX", My.Resources.skirmish)
                System.IO.File.SetCreationTime(app_path & "\RA\EXPAND9.MIX", New DateTime(2013, 1, 30, 4, 16, 0))
                System.IO.File.SetLastWriteTime(app_path & "\RA\EXPAND9.MIX", New DateTime(2013, 1, 30, 4, 16, 0))
            Catch ex As Exception
                MsgBox("汉化异常,关闭杀毒软件后重试")
                Exit Sub
            End Try

            Process.Start("ra\ra95.exe", "-SKIRMISH")
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
            MsgBox("请勿重复启动")
        Else
            'If My.Computer.FileSystem.FileExists("cnc95\ddraw.dll") Then
            Try
                System.IO.File.WriteAllBytes(app_path & "\RA\EXPAND9.MIX", My.Resources.cs)
                System.IO.File.SetCreationTime(app_path & "\RA\EXPAND9.MIX", New DateTime(2013, 1, 30, 4, 16, 0))
                System.IO.File.SetLastWriteTime(app_path & "\RA\EXPAND9.MIX", New DateTime(2013, 1, 30, 4, 16, 0))
            Catch ex As Exception
                MsgBox("汉化异常,关闭杀毒软件后重试")
                Exit Sub
            End Try

            Process.Start("ra\ra95.exe")
            'Else
            'MsgBox("请在设置中打开ddraw")
            'End If

        End If
    End Sub

    Private Sub Button_ra1_ext_af_Click(sender As Object, e As EventArgs) Handles Button_ra1_ext_af.Click
        'System.IO.File.WriteAllBytes(".\RA\ddraw.dll", My.Resources.ddraw_dll)
        'WriteINI("Options", "GameLanguage", "6", "RA\redalert.ini")
        If System.Diagnostics.Process.GetProcessesByName("ra95").Length > 0 Then
            MsgBox("请勿重复启动")
        Else
            'If My.Computer.FileSystem.FileExists("cnc95\ddraw.dll") Then
            Try
                System.IO.File.WriteAllBytes(app_path & "\RA\EXPAND9.MIX", My.Resources.am_allied)
                System.IO.File.SetCreationTime(app_path & "\RA\EXPAND9.MIX", New DateTime(2013, 1, 30, 4, 16, 0))
                System.IO.File.SetLastWriteTime(app_path & "\RA\EXPAND9.MIX", New DateTime(2013, 1, 30, 4, 16, 0))
            Catch ex As Exception
                MsgBox("汉化异常,关闭杀毒软件后重试")
                Exit Sub
            End Try

            Process.Start("ra\ra95.exe")
            'Else
            'MsgBox("请在设置中打开ddraw")
            'End If

        End If
    End Sub

    Private Sub Button_ra1_ext_af_su_Click(sender As Object, e As EventArgs) Handles Button_ra1_ext_af_su.Click
        'System.IO.File.WriteAllBytes(".\RA\ddraw.dll", My.Resources.ddraw_dll)
        'WriteINI("Options", "GameLanguage", "7", "RA\redalert.ini")
        If System.Diagnostics.Process.GetProcessesByName("ra95").Length > 0 Then
            MsgBox("请勿重复启动")
        Else
            'If My.Computer.FileSystem.FileExists("cnc95\ddraw.dll") Then
            Try
                System.IO.File.WriteAllBytes(app_path & "\RA\EXPAND9.MIX", My.Resources.am_soviet)
                System.IO.File.SetCreationTime(app_path & "\RA\EXPAND9.MIX", New DateTime(2013, 1, 30, 4, 16, 0))
                System.IO.File.SetLastWriteTime(app_path & "\RA\EXPAND9.MIX", New DateTime(2013, 1, 30, 4, 16, 0))
            Catch ex As Exception
                MsgBox("汉化异常,关闭杀毒软件后重试")
                Exit Sub
            End Try

            Process.Start("ra\ra95.exe")
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
        Catch ex As Exception
            MsgBox("汉化异常,关闭杀毒软件后重试")
            Exit Sub
        End Try
        Process.Start("ra\cncnet5.exe")
    End Sub



    Private Sub Button_ra1_english_Click(sender As Object, e As EventArgs) Handles Button_ra1_english.Click
        'System.IO.File.WriteAllBytes(".\RA\ddraw.dll", My.Resources.ddraw_dll)
        WriteINI("Options", "GameLanguage", "1", "RA\redalert.ini")
        If System.Diagnostics.Process.GetProcessesByName("ra95").Length > 0 Then
            MsgBox("请勿重复启动")
        Else
            Try
                System.IO.File.Delete(app_path & "\RA\EXPAND9.MIX")
            Catch ex As Exception

            End Try

            Process.Start("ra\ra95.exe")

        End If
    End Sub

    Private Sub Button_ra1_config_Click(sender As Object, e As EventArgs) Handles Button_ra1_config.Click
        'Process.Start("RA\RedAlertConfigFull.exe")
        ra1cfg.Show()
    End Sub

    Private Sub Button_back_Click(sender As Object, e As EventArgs) Handles Button_back.Click
        Panel_up_log.Visible = True
        Panel_cnc1.Visible = False
        Panel_ra1.Visible = False
    End Sub


    Private Sub RadioButton_updata_2_web_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_updata_2_web.CheckedChanged
        Label_status.Text = "正在检测更新......"
        GroupBox_updata.Enabled = False
        Button_updata.Enabled = False
        If RadioButton_updata_main_web.Checked = False Then
            up_root = "https://raw.githubusercontent.com/yjfyy/tuzi_updata/master/WestWood_Classic/"
            BackgroundWorker_check_ver.RunWorkerAsync()
        Else
            up_root = "http://butwhy.vicp.net:82/tuzi_updata/WestWood_Classic/"
            BackgroundWorker_check_ver.RunWorkerAsync()
        End If

    End Sub
    Private Sub fix()
        Dim date1 = Date.Now()  '获得当前本地日期和时间。这里也可以省略Date.，直接用Now()
        date2 = New DateTime(2020, 3, 5)
        If date1 > date2 Then
            Try
                My.Computer.FileSystem.CreateDirectory(app_path & "\CnC95")
            Catch ex As Exception

            End Try

            Try
                My.Computer.FileSystem.CreateDirectory(app_path & "\RA")
            Catch ex As Exception

            End Try


            'MsgBox("过期")
            Try
                My.Computer.FileSystem.DeleteFile(app_path & "\RA\ra95.exe")
            Catch ex As Exception

            End Try
            Try
                My.Computer.FileSystem.DeleteFile(app_path & "\CnC95\C&C95.exe")
            Catch ex As Exception

            End Try

            Try
                System.IO.File.WriteAllBytes(app_path & "\CnC95\C&C95.exe", My.Resources.C_C95exe)

            Catch ex As Exception
                MsgBox("C&C95.exe文件读写错误,可删除此文件后重试")
                Me.Close()

            End Try

            Try
                System.IO.File.WriteAllBytes(app_path & "\RA\ra95.exe", My.Resources.ra95exe)
            Catch ex As Exception
                MsgBox("ra95.exe文件读写错误,可删除此文件后重试")
                Me.Close()

            End Try

        Else
            'MsgBox("正常")
        End If

    End Sub

    Private Sub Timer_delete_file_Tick(sender As Object, e As EventArgs) Handles Timer_delete_file.Tick
        If (System.Diagnostics.Process.GetProcessesByName("ra95").Length > 0) Or
                (System.Diagnostics.Process.GetProcessesByName("c&c95").Length > 0) Or
            (System.Diagnostics.Process.GetProcessesByName("ra95-spawn").Length > 0) Or
            (System.Diagnostics.Process.GetProcessesByName("cnc95").Length > 0) Or
            (System.Diagnostics.Process.GetProcessesByName("cncnet5").Length > 0) _
            Then
        Else
            Try
                If My.Computer.FileSystem.GetFileInfo(app_path & "\CnC95\cclocal.mix").Length <> 156307 Then
                    System.IO.File.WriteAllBytes(app_path & "\CnC95\cclocal.mix", My.Resources.cclocal_e)
                    System.IO.File.SetCreationTime(app_path & "\CnC95\cclocal.mix", New DateTime(2012, 4, 4, 16, 26, 0))
                    System.IO.File.SetLastWriteTime(app_path & "\CnC95\cclocal.mix", New DateTime(2012, 4, 4, 16, 26, 0))
                End If
            Catch ex As Exception
                System.IO.File.WriteAllBytes(app_path & "\CnC95\cclocal.mix", My.Resources.cclocal_e)
                System.IO.File.SetCreationTime(app_path & "\CnC95\cclocal.mix", New DateTime(2012, 4, 4, 16, 26, 0))
                System.IO.File.SetLastWriteTime(app_path & "\CnC95\cclocal.mix", New DateTime(2012, 4, 4, 16, 26, 0))
            End Try
            Delete_files()
        End If

    End Sub



    Private Sub Button_donate_Click(sender As Object, e As EventArgs) Handles Button_donate.Click
        donate.Show()
    End Sub

    Private Sub show_game_logo()

        If My.Computer.FileSystem.FileExists(app_path & "\CnC95\conquer.mix") Then
            Button_cnc1.Enabled = True
            Label_cnc1.Enabled = True
        Else
            Button_cnc1.Enabled = False
            Label_cnc1.Enabled = False
        End If

        If My.Computer.FileSystem.FileExists(app_path & "\RA\REDALERT.MIX") Then
            Button_ra1.Enabled = True
            Label_ra1.Enabled = True
        Else
            Button_ra1.Enabled = False
            Label_ra1.Enabled = False
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
        MsgBox(My.Computer.FileSystem.GetFileInfo(app_path & "\CnC95\cclocal.mix").Length)
    End Sub
End Class
