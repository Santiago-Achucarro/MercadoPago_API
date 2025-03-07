cd Actions
"C:\Program Files\WinRAR\WinRAR.exe" a -r ..\Actions.rar *.dll *.exe *.xml *.config *.xslt *.ico *.rdlc
cd ..
if [%1] == [] pause