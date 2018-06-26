Public Class cnc1cfg
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

    'GetINI("Options", "HardwareFills", "0", "CnC95\conquer.ini")
    'WriteINI("CDControl", "CDPath", "CHI", "CnC95\conquer.ini")

    Private Sub cnc1cfg_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        read_ini()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton_1728.Checked Then
            FileIO.FileSystem.CopyFile("attach\xtitle.1728", "CnC95\xtitle.pcx", True)
        ElseIf RadioButton_864.Checked Then
            FileIO.FileSystem.CopyFile("attach\xtitle.864", "CnC95\xtitle.pcx", True)
        ElseIf RadioButton_1920.Checked Then
            FileIO.FileSystem.CopyFile("attach\xtitle.1920", "CnC95\xtitle.pcx", True)
        Else
            Try
                FileIO.FileSystem.DeleteFile("CnC95\xtitle.pcx")
            Catch ex As Exception

            End Try

        End If

        If RadioButton_eva_chi.Checked = True Then
            FileIO.FileSystem.CopyFile("attach\speecchi.mix", "CnC95\speecchi.mix", True)
        Else
            FileIO.FileSystem.CopyFile("CnC95\speech.mix", "CnC95\speecchi.mix", True)
        End If
        FileIO.FileSystem.CopyFile("attach\ddraw.dll", "CnC95\ddraw.dll", True)
        save_ini()
        Me.Close()
    End Sub

    Private Sub Button_reset_Click(sender As Object, e As EventArgs) Handles Button_reset.Click
        System.IO.File.WriteAllText("CnC95\conquer.ini", My.Resources.conquer)
        System.IO.File.WriteAllText("CnC95\ddraw.ini", My.Resources.ddrawcnc1)
        read_ini()
    End Sub

    Private Sub read_ini()

        Select Case GetINI("Video", "Width", "864", "CnC95\conquer.ini")
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
                TextBox_width.Text = GetINI("Video", "Width", "640", "CnC95\conquer.ini")
                TextBox_height.Text = GetINI("Video", "Height", "480", "CnC95\conquer.ini")
        End Select

        If GetINI("ddraw", "renderer", "auto", "CnC95\ddraw.ini") = "auto" Then
            RadioButton_auto.Checked = True
        ElseIf GetINI("ddraw", "renderer", "auto", "CnC95\ddraw.ini") = "opengl" Then
            RadioButton_opengl.Checked = True
        Else
            RadioButton_gdi.Checked = True
        End If


        If GetINI("ddraw", "windowed", "false", "CnC95\ddraw.ini") = "true" Then
            RadioButton_windows.Checked = True
        Else
            RadioButton_full.Checked = True
        End If

    End Sub

    Private Sub save_ini()

        If RadioButton_full.Checked = True Then
            WriteINI("ddraw", "width", Screen.PrimaryScreen.Bounds.Width.ToString, "CnC95\ddraw.ini")
            WriteINI("ddraw", "height", Screen.PrimaryScreen.Bounds.Height.ToString, "CnC95\ddraw.ini")
        Else
            WriteINI("ddraw", "width", "0", "CnC95\ddraw.ini")
            WriteINI("ddraw", "height", "0", "CnC95\ddraw.ini")
        End If

        If RadioButton_864.Checked = True Then
            WriteINI("Video", "Width", "864", "CnC95\conquer.ini")
            WriteINI("Video", "Height", "540", "CnC95\conquer.ini")
        ElseIf RadioButton_1728.Checked = True Then
            WriteINI("Video", "Width", "1728", "CnC95\conquer.ini")
            WriteINI("Video", "Height", "1080", "CnC95\conquer.ini")
        ElseIf RadioButton_640.Checked = True Then
            WriteINI("Video", "Width", "640", "CnC95\conquer.ini")
            WriteINI("Video", "Height", "480", "CnC95\conquer.ini")
        ElseIf RadioButton_1920.Checked = True Then
            WriteINI("Video", "Width", "1920", "CnC95\conquer.ini")
            WriteINI("Video", "Height", "1080", "CnC95\conquer.ini")
        Else
            WriteINI("Video", "Width", TextBox_width.Text, "CnC95\conquer.ini")
            WriteINI("Video", "Height", TextBox_height.Text, "CnC95\conquer.ini")
        End If

        If RadioButton_auto.Checked = True Then
            WriteINI("ddraw", "renderer", "auto", "CnC95\ddraw.ini")
        ElseIf RadioButton_opengl.Checked = True Then
            WriteINI("ddraw", "renderer", "opengl", "CnC95\ddraw.ini")
        Else
            WriteINI("ddraw", "renderer", "gdi", "CnC95\ddraw.ini")
        End If

        If RadioButton_full.Checked = True Then
            WriteINI("ddraw", "windowed", "false", "CnC95\ddraw.ini")
        Else
            WriteINI("ddraw", "windowed", "true", "CnC95\ddraw.ini")
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

    Private Sub cnc1cfg_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class