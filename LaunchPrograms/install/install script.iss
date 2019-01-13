; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

#define MyAppName "Launch Programs"
#define MyAppVersion "1.1"
#define MyAppPublisher "SCR"
#define MyAppExeName "LaunchPrograms.exe"

[Setup]
; NOTE: The value of AppId uniquely identifies this application.
; Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{FB6221D7-DC43-4644-828F-817E6E236705}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
;AppVerName={#MyAppName} {#MyAppVersion}
AppPublisher={#MyAppPublisher}
DefaultDirName={pf}\{#MyAppName}
DefaultGroupName={#MyAppName}
OutputBaseFilename=setup
Compression=lzma
SolidCompression=yes

[Languages]
Name: "spanish"; MessagesFile: "compiler:Languages\Spanish.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: "D:\Documentos Sergio\Desarrollo\VB projects\LaunchPrograms\LaunchPrograms\bin\Release\LaunchPrograms.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Documentos Sergio\Desarrollo\VB projects\LaunchPrograms\LaunchPrograms\bin\Release\LaunchPrograms.exe.config"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Documentos Sergio\Desarrollo\VB projects\LaunchPrograms\LaunchPrograms\bin\Release\LaunchPrograms.pdb"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Documentos Sergio\Desarrollo\VB projects\LaunchPrograms\LaunchPrograms\bin\Release\LaunchPrograms.xml"; DestDir: "{app}"; Flags: ignoreversion
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Icons]
Name: "{group}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{commondesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent

