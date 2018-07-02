Public Class ra1cfg

    ''声明INI配置文件读写API函数,lpApplicationName节名称， lpKeyName键名称，lpString是键值
    'Private Declare Function GetPrivateProfileString Lib "kernel32" Alias "GetPrivateProfileStringA" (ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal lpDefault As String, ByVal lpReturnedString As String, ByVal nSize As Int32, ByVal lpFileName As String) As Int32
    'Private Declare Function WritePrivateProfileString Lib "kernel32" Alias "WritePrivateProfileStringA" (ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal lpString As String, ByVal lpFileName As String) As Int32
    ''定义读取配置文件函数
    'Public Function GetINI(ByVal Section As String, ByVal AppName As String, ByVal lpDefault As String, ByVal FileName As String) As String
    '    Dim Str As String = LSet(Str, 256)
    '    GetPrivateProfileString(Section, AppName, lpDefault, Str, Len(Str), FileName)
    '    Return Microsoft.VisualBasic.Left(Str, InStr(Str, Chr(0)) - 1)
    'End Function
    ''定义写入配置文件函数
    'Public Function WriteINI(ByVal Section As String, ByVal AppName As String, ByVal lpDefault As String, ByVal FileName As String) As Long
    '    WriteINI = WritePrivateProfileString(Section, AppName, lpDefault, FileName)
    'End Function

    ''GetINI("Options", "HardwareFills", "0", "CnC95\conquer.ini")
    ''WriteINI("CDControl", "CDPath", "CHI", "CnC95\conquer.ini")

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FileIO.FileSystem.CopyFile("attach\ddraw.dll", "RA\ddraw.dll", True)
        save_ini()
        Me.Close()
    End Sub

    Private Sub ra1cfg_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        read_ini()
    End Sub

    Private Sub Button_reset_Click(sender As Object, e As EventArgs) Handles Button_reset.Click
        System.IO.File.WriteAllText("RA\redalert.ini", My.Resources.redalert)
        System.IO.File.WriteAllText("RA\ddraw.ini", My.Resources.ddrawra1)
        read_ini()
    End Sub

    Private Sub read_ini()

        Select Case GetINI("Options", "Width", "864", "RA\redalert.ini")
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
                TextBox_width.Text = GetINI("Options", "Width", "640", "RA\redalert.ini")
                TextBox_height.Text = GetINI("Options", "Height", "480", "RA\redalert.ini")
        End Select

        If GetINI("ddraw", "renderer", "auto", "RA\ddraw.ini") = "auto" Then
            RadioButton_auto.Checked = True
        ElseIf GetINI("ddraw", "renderer", "auto", "RA\ddraw.ini") = "opengl" Then
            RadioButton_opengl.Checked = True
        Else
            RadioButton_gdi.Checked = True
        End If


        If GetINI("ddraw", "windowed", "false", "RA\ddraw.ini") = "true" Then
            RadioButton_windows.Checked = True
        Else
            RadioButton_full.Checked = True
        End If

    End Sub

    Private Sub save_ini()

        If RadioButton_full.Checked = True Then
            WriteINI("ddraw", "width", Screen.PrimaryScreen.Bounds.Width.ToString, "RA\ddraw.ini")
            WriteINI("ddraw", "height", Screen.PrimaryScreen.Bounds.Height.ToString, "RA\ddraw.ini")
        Else
            WriteINI("ddraw", "width", "0", "RA\ddraw.ini")
            WriteINI("ddraw", "height", "0", "RA\ddraw.ini")
        End If

        If RadioButton_864.Checked = True Then
            WriteINI("Options", "Width", "864", "RA\redalert.ini")
            WriteINI("Options", "Height", "540", "RA\redalert.ini")
        ElseIf RadioButton_1728.Checked = True Then
            WriteINI("Options", "Width", "1728", "RA\redalert.ini")
            WriteINI("Options", "Height", "1080", "RA\redalert.ini")
        ElseIf RadioButton_640.Checked = True Then
            WriteINI("Options", "Width", "640", "RA\redalert.ini")
            WriteINI("Options", "Height", "480", "RA\redalert.ini")
        ElseIf RadioButton_1920.Checked = True Then
            WriteINI("Options", "Width", "1920", "RA\redalert.ini")
            WriteINI("Options", "Height", "1080", "RA\redalert.ini")
        Else
            WriteINI("Options", "Width", TextBox_width.Text, "RA\redalert.ini")
            WriteINI("Options", "Height", TextBox_height.Text, "RA\redalert.ini")
        End If

        If RadioButton_auto.Checked = True Then
            WriteINI("ddraw", "renderer", "auto", "RA\ddraw.ini")
        ElseIf RadioButton_opengl.Checked = True Then
            WriteINI("ddraw", "renderer", "opengl", "RA\ddraw.ini")
        Else
            WriteINI("ddraw", "renderer", "gdi", "RA\ddraw.ini")
        End If

        If RadioButton_full.Checked = True Then
            WriteINI("ddraw", "windowed", "false", "RA\ddraw.ini")
        Else
            WriteINI("ddraw", "windowed", "true", "RA\ddraw.ini")
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

    Private Sub ra1cfg_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class