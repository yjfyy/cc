﻿'------------------------------------------------------------------------------
' <auto-generated>
'     此代码由工具生成。
'     运行时版本:4.0.30319.42000
'
'     对此文件的更改可能会导致不正确的行为，并且如果
'     重新生成代码，这些更改将会丢失。
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    '此类是由 StronglyTypedResourceBuilder
    '类通过类似于 ResGen 或 Visual Studio 的工具自动生成的。
    '若要添加或移除成员，请编辑 .ResX 文件，然后重新运行 ResGen
    '(以 /str 作为命令选项)，或重新生成 VS 项目。
    '''<summary>
    '''  一个强类型的资源类，用于查找本地化的字符串等。
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()>  _
    Friend Module Resources
        
        Private resourceMan As Global.System.Resources.ResourceManager
        
        Private resourceCulture As Global.System.Globalization.CultureInfo
        
        '''<summary>
        '''  返回此类使用的缓存的 ResourceManager 实例。
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("WestWood_Classic.Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  使用此强类型资源类，为所有资源查找
        '''  重写当前线程的 CurrentUICulture 属性。
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  查找 System.Drawing.Bitmap 类型的本地化资源。
        '''</summary>
        Friend ReadOnly Property _1() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("1", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  查找 System.Drawing.Bitmap 类型的本地化资源。
        '''</summary>
        Friend ReadOnly Property _93() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("93", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  查找类似 [Options]
        '''HardwareFills=0
        '''VideoBackBuffer=1
        '''FreeScrolling=0
        '''AutoScroll=1
        '''SlowPalette=1
        '''ScoreVolume=112
        '''Volume=113
        '''ScrollRate=3
        '''GameSpeed=1
        '''Compatibility=0
        '''DeathAnnounce=No
        '''Socket=0
        '''DestNet=00.00.00.00
        '''SafeScrolling=No
        '''
        '''[Video]
        '''Width=640
        '''Height=480
        '''Brightness=128
        '''Contrast=128
        '''Tint=128
        '''Color=128
        '''VerticalVideoStretch=i  ; [S]canlines, [D]uplicate, [I]nterpolate
        '''StretchAttract=Yes
        '''
        '''[Music]
        '''IsScoreShuffle=0
        '''IsScoreRepeat=0
        '''UseCreditsMusic=Yes
        '''RemixScores=Yes         ; Enable music r [字符串的其余部分被截断]&quot;; 的本地化字符串。
        '''</summary>
        Friend ReadOnly Property conquer() As String
            Get
                Return ResourceManager.GetString("conquer", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  查找类似 ; cnc-ddraw - https://github.com/CnCNet/cnc-ddraw - https://cncnet.org
        '''
        '''[ddraw]
        '''; ### Optional settings ###
        '''; Use the following settings to adjust the look and feel to your liking
        '''
        '''
        '''; Stretch to custom resolution, 0 = defaults to the size game requests
        '''width=0
        '''height=0
        '''
        '''; Override the width/height settings shown above and always stretch to fullscreen
        '''; Note: Can be combined with &apos;windowed=true&apos; to get windowed-fullscreen aka borderless mode
        '''fullscreen=true
        '''
        '''; Run in windowed mode rather than  [字符串的其余部分被截断]&quot;; 的本地化字符串。
        '''</summary>
        Friend ReadOnly Property ddraw() As String
            Get
                Return ResourceManager.GetString("ddraw", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  查找 System.Drawing.Bitmap 类型的本地化资源。
        '''</summary>
        Friend ReadOnly Property htitle() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("htitle", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  查找类似 [Options]
        '''ScrollFix=Yes
        '''LimitCpuUsage=Yes
        '''SlowerScrollrate=No
        '''HardwareFills=No
        '''VideoBackBuffer=Yes
        '''Resolution=0
        '''Width=640
        '''Height=480
        '''ShowAllMusic=Yes
        '''PlayEnglishIntro=Yes
        '''VideoInterlaceMode=2
        '''SkipScoreScreen=No
        '''RandomStartingSong=No
        '''GameLanguage=1
        '''Show640x480BlackBars=false
        '''MouseWheelScrolling=Yes
        '''DisplayOriginalMultiplayerMaps=Yes
        '''DisplayCounterstrikeMultiplayerMaps=Yes
        '''DisplayAftermathMultiplayerMaps=Yes
        '''UseSmallInfantry=No
        '''NoCD=Yes
        '''CounterstrikeEnabled=Yes
        '''AftermathEnabled=Yes
        '''For [字符串的其余部分被截断]&quot;; 的本地化字符串。
        '''</summary>
        Friend ReadOnly Property redalert() As String
            Get
                Return ResourceManager.GetString("redalert", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  查找 System.Drawing.Bitmap 类型的本地化资源。
        '''</summary>
        Friend ReadOnly Property title() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("title", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  查找类似 @echo off
        '''echo 正在更新...
        '''ping -n 4 127.0.0.1&gt;nul
        '''up_data.exe
        '''ping -n 4 127.0.0.1&gt;nul
        '''del up_data.exe /q
        '''echo 更新完成
        '''ping -n 2 127.0.0.1&gt;nul
        '''start 西木经典游戏汉化纪念版.exe 的本地化字符串。
        '''</summary>
        Friend ReadOnly Property up() As String
            Get
                Return ResourceManager.GetString("up", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  查找类似 @echo off
        '''echo 正在更新...
        '''timeout 2 &gt;nul
        '''up_data.exe
        '''echo 开始更新动画包
        '''cd cnc95\chi
        '''del *.vqa /q
        '''del *.vqp /q
        '''wget -ivqalist.txt --no-check-certificate -Bhttps://github.com/yjfyy/cc1_database/raw/master/movies/ -c --no-check-certificate
        '''cd ..\..
        '''timeout 2 &gt; nul
        '''del up_data.exe /q
        '''echo 更新完成
        '''timeout 1 &gt; nul
        '''start 西木经典游戏汉化纪念版.exe 的本地化字符串。
        '''</summary>
        Friend ReadOnly Property up_cnc1_movice() As String
            Get
                Return ResourceManager.GetString("up_cnc1_movice", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  查找类似 @echo off
        '''echo 正在更新...
        '''timeout 3 &gt;nul
        '''up_data.exe
        '''echo 开始更新动画包
        '''cd RA
        '''del movies-2.mix /q
        '''del movies-2.part1.exe /q
        '''del movies-2.part2.rar /q
        '''del movies-2.part3.rar /q
        '''wget -iramolist.txt --no-check-certificate -Bhttps://github.com/yjfyy/ra1_database/raw/master/movies/ -c --no-check-certificate
        '''movies-2.part1.exe
        '''del movies-2.part1.exe /q
        '''del movies-2.part2.rar /q
        '''del movies-2.part3.rar /q
        '''cd ..
        '''timeout 3 &gt; nul
        '''del up_data.exe /q
        '''echo 更新完成
        '''timeout 1 &gt; nul
        '''start 西木经典游戏汉化纪念版.exe 的本地化字符串。
        '''</summary>
        Friend ReadOnly Property up_ra1_movice() As String
            Get
                Return ResourceManager.GetString("up_ra1_movice", resourceCulture)
            End Get
        End Property
    End Module
End Namespace
