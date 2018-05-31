#define MyAppName="命令与征服黄金版 1.06c 中文语言包"
#define MyAppPublisher "Nyerguds"
#define MyAppURL "http://nyerguds.arsaneus-design.com/cnc95upd/cc95p106/"

[Setup]
AppId={{4F61B281-AC15-4868-97AA-9655839F0A31}
AppName={cm:AppName}
AppVerName={#MyAppName}
VersionInfoDescription={#MyAppName} Setup
VersionInfoProductName={#MyAppName}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppURL}
AppUpdatesURL={#MyAppURL}
DefaultDirName={code:GetInstallPath}
UsePreviousAppDir=no
DirExistsWarning=no
Uninstallable=yes
CreateUninstallRegKey=yes
DisableProgramGroupPage=yes
Compression=lzma
SolidCompression=yes
SourceDir=.
OutputDir=.
OutputBaseFilename=cc95v106c_XXXX
SetupIconFile=node.ico
WizardImageFile=insert.bmp
WizardImageStretch=no
WizardImageBackColor=$000000
WizardSmallImageFile=smallimage.bmp
AppendDefaultDirName=no

[Languages]
Name: eng; MessagesFile: compiler:Default.isl; InfoBeforeFile: readme.rtf
Name: chi; MessagesFile: compiler:Languages\ChineseSimplified.isl; InfoBeforeFile: readme_chi.rtf

[Files]
Source: ccconfigchg.lan; DestDir: {app}; Flags: ignoreversion
Source: ccconfigchm.lan; DestDir: {app}; Flags: ignoreversion
Source: ccconfigchn.lan; DestDir: {app}; Flags: ignoreversion
Source: ccconfigchv.lan; DestDir: {app}; Flags: ignoreversion
Source: deseichi.mix; DestDir: {app}; Flags: ignoreversion
Source: tempichi.mix; DestDir: {app}; Flags: ignoreversion
Source: wintichi.mix; DestDir: {app}; Flags: ignoreversion
Source: snowichi.mix; DestDir: {app}; Flags: ignoreversion
Source: speecchi.mix; DestDir: {app}; Flags: ignoreversion
Source: lang_chg.mix; DestDir: {app}; Flags: ignoreversion
Source: lang_chm.mix; DestDir: {app}; Flags: ignoreversion
Source: lang_chn.mix; DestDir: {app}; Flags: ignoreversion
Source: lang_chv.mix; DestDir: {app}; Flags: ignoreversion
Source: lver; DestDir: {app}; Flags: ignoreversion
Source: 命令与征服纪念版.exe; DestDir: {app}; Flags: ignoreversion
Source: 说明.txt; DestDir: {app}; Flags: ignoreversion

[Messages]
eng.WelcomeLabel1=Welcome to the C&C95 XXXX Language Pack Setup Wizard!
eng.WelcomeLabel2=This program will install the XXXX language pack on your C&C.
chi.WelcomeLabel1=欢迎来到C&C95中文语言包安装向导！
chi.WelcomeLabel2=此程序将在您的C&C上安装中文语言包。

[CustomMessages]
eng.AppName=Command & Conquer Gold 1.06c XXXX language addon
chi.AppName=命令与征服黄金版 1.06c 中文语言包

GameReg=SOFTWARE\Westwood\Command & Conquer Windows 95 Edition
TFDReg=SOFTWARE\Electronic Arts\EA Games\Command and Conquer The First Decade
TFDDir={pf}\EA Games\Command & Conquer The First Decade\Command & Conquer(tm)
DefaultGamePath=C:\Westwood\C&C95
INIFile=conquer.ini
CheckFile=update.mix
eng.nogame=ERROR: The game was not found in the selected directory.%nPlease select the directory where Command & Conquer is installed.
chi.nogame=ERROR: 在选定目录中找不到游戏%n请选择命令和征服的安装目录。
eng.EnableLanguage=Enable XXXX language
chi.EnableLanguage=选择中文语言包

[Tasks]
Name: enablelanguage; Description: {cm:EnableLanguage}
Name: "DesktopIcon"; Description: "创建桌面快捷方式图标"
[INI]
Filename: {app}\{cm:INIFile}; Section: Language; Key: Language; String: chg; Tasks: enablelanguage

[Icons]  
Name: "{commondesktop}\命令与征服纪念版"; Filename: "{app}\命令与征服纪念版.exe"; WorkingDir: "{app}"; Tasks: DesktopIcon 

[Code]
////////////////////////////////////////////////////
// The wpSelectDir check doesn't allow the setup to continue if the game
// files are missing in the target directory
//
function NextButtonClick(CurPage: Integer): Boolean;
begin
    if (CurPage = wpSelectDir) then
     begin
        if (FileExists(WizardDirValue()+ExpandConstant('\{cm:CheckFile}')) and
            FileExists(WizardDirValue()+ExpandConstant('\{cm:INIFile}'))
           ) then
         begin
             Result:=true;
         end
        else
         begin
             if (not WizardSilent()) then MsgBox(ExpandConstant('{cm:nogame}'), mbInformation, MB_OK);
             Result:=false;
         end
     end
    else Result:=true;
end;


function GetInstallPath(Param: String): String;
var
  gamepath: String;
begin
    gamepath:=ExtractFilePath(ExpandConstant('{reg:HKLM\{cm:GameReg},InstallPath|{cm:DefaultGamePath}}'));
    if (not FileExists(gamepath+ExpandConstant('\{cm:CheckFile}')))
     then
         gamepath:=ExpandConstant('{reg:HKLM\{cm:TFDReg},cc_folder|{cm:TFDDir}}\{cm:CheckFile}');
    if (not FileExists(gamepath+ExpandConstant('\{cm:CheckFile}')))
     then
         gamepath:=ExpandConstant('{cm:DefaultGamePath}');
    Result := gamepath;
end;
