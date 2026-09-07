; Inno Setup Script for Aicbbuu Network Tools
; https://jrsoftware.org/isinfo.php

[Setup]
AppName=Aicbbuu Network Tools
AppVersion={#MyAppVersion}
AppPublisher=aicbbuu
AppPublisherURL=https://github.com/aicbbuu/aicbbuu-Network-tools
AppSupportURL=https://github.com/aicbbuu/aicbbuu-Network-tools/issues
DefaultDirName={autopf}\AicbbuuNetworkTools
DefaultGroupName=Aicbbuu Network Tools
DisableProgramGroupPage=yes
OutputBaseFilename=AicbbuuNetworkTools-Setup-{#MyAppVersion}
Compression=lzma2
SolidCompression=yes
PrivilegesRequired=lowest
PrivilegesRequiredOverridesAllowed=dialog
UninstallDisplayIcon={app}\AicbbuuNetworkTools.exe
ArchitecturesAllowed=x64compatible
ArchitecturesInstallIn64BitMode=x64compatible

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"

[Files]
Source: "..\publish\AicbbuuNetworkTools.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "..\publish\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs

[Icons]
Name: "{group}\Aicbbuu Network Tools"; Filename: "{app}\AicbbuuNetworkTools.exe"
Name: "{group}\Uninstall Aicbbuu Network Tools"; Filename: "{uninstallexe}"
Name: "{commondesktop}\Aicbbuu Network Tools"; Filename: "{app}\AicbbuuNetworkTools.exe"; Tasks: desktopicon

[Tasks]
Name: "desktopicon"; Description: "Create a desktop shortcut"; GroupDescription: "Additional shortcuts:"

[Run]
Filename: "{app}\AicbbuuNetworkTools.exe"; Description: "Launch Aicbbuu Network Tools"; Flags: nowait postinstall skipifsilent

[UninstallDelete]
Type: filesandordirs; Name: "{app}"
