#define MyAppName="Command & Conquer Gold 1.06c XXXX language addon"
#define MyAppPublisher "Nyerguds"
#define MyAppURL "http://nyerguds.arsaneus-design.com/cnc95upd/cc95p106/"

[Setup]
AppId={#REGENERATETHIS}
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
Name: XXX; MessagesFile: compiler:Languages\XXXX.isl; InfoBeforeFile: readme_XXX.rtf

[Files]
Source: ccconfigXXX.lan; DestDir: {app}; Flags: ignoreversion
Source: deseiXXX.mix; DestDir: {app}; Flags: ignoreversion
Source: tempiXXX.mix; DestDir: {app}; Flags: ignoreversion
Source: wintiXXX.mix; DestDir: {app}; Flags: ignoreversion
Source: snowiXXX.mix; DestDir: {app}; Flags: ignoreversion
Source: speecXXX.mix; DestDir: {app}; Flags: ignoreversion
Source: talkXXX.mix; DestDir: {app}; Flags: ignoreversion
Source: lang_XXX.mix; DestDir: {app}; Flags: ignoreversion

[Messages]
eng.WelcomeLabel1=Welcome to the C&C95 XXXX Language Pack Setup Wizard!
eng.WelcomeLabel2=This program will install the XXXX language pack on your C&C.
XXX.WelcomeLabel1=XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
XXX.WelcomeLabel2=XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX

[CustomMessages]
eng.AppName=Command & Conquer Gold 1.06c XXXX language addon
XXX.AppName=Command & Conquer Gold 1.06c XXXXXXXXXXXXXXXXXX

GameReg=SOFTWARE\Westwood\Command & Conquer Windows 95 Edition
TFDReg=SOFTWARE\Electronic Arts\EA Games\Command and Conquer The First Decade
TFDDir={pf}\EA Games\Command & Conquer The First Decade\Command & Conquer(tm)
DefaultGamePath=C:\Westwood\C&C95
INIFile=conquer.ini
CheckFile=update.mix
eng.nogame=ERROR: The game was not found in the selected directory.%nPlease select the directory where Command & Conquer is installed.
XXX.nogame=ERROR: XXXXXXXXXXXXXXXXXXXXX%nXXXXXXXXXXXXXXXXXXXXXXXX.
eng.EnableLanguage=Enable XXXX language
XXX.EnableLanguage=XXXXXXXXXXXXXXXXXXXXXXXX

[Tasks]
Name: enablelanguage; Description: {cm:EnableLanguage}

[INI]
Filename: {app}\{cm:INIFile}; Section: Language; Key: Language; String: XXX; Tasks: enablelanguage

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
