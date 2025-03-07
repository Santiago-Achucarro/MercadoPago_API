@echo off
set rars=""
set empresa=""

if exist config.info set /p rars=<config.info
pause
for /f "tokens=9 delims=;" %%a in ("%rars%") do (
  set rutasitio=%%a
)
for /f "tokens=8 delims=;" %%a in ("%rars%") do (
  set nombreservicio=%%a
)
for /f "tokens=7 delims=;" %%a in ("%rars%") do (
  set rutaprod=%%a
)
for /f "tokens=6 delims=;" %%a in ("%rars%") do (
  set pass=%%a
)
for /f "tokens=5 delims=;" %%a in ("%rars%") do (
  set user=%%a
)
for /f "tokens=4 delims=;" %%a in ("%rars%") do (
  set base=%%a
)
for /f "tokens=3 delims=;" %%a in ("%rars%") do (
  set server=%%a
)
for /f "tokens=2 delims=;" %%a in ("%rars%") do (
  set scriptsempresa=%%a
)
for /f "tokens=1 delims=;" %%a in ("%rars%") do (
  set scripts=%%a
)

sc query %nombreservicio% |find "STATE" >> tmp.txt
set /p estado=<tmp.txt
rem del tmp.txt
echo %scripts%;%scriptsempresa%;%server%;%base%;%user%;%pass%;%rutaprod%;%nombreservicio%;%rutasitio%;%estado%;
pause

:menu
cd C:\SummaAdvancedQ
cls
ECHO ...............................................
ECHO.
ECHO 1 - ActualizarTodo
ECHO 2 - ActualizarBD
ECHO 3 - ActualizarDLLs
echo Estado Servicio: %estado%
ECHO 4 - DetenerServicio(%nombreservicio%)
ECHO 5 - IniciarServico(%nombreservicio%)
echo 9 - Configurar
echo 0 - fin
ECHO.

SET /P M=Opcion: 
IF %M%==1 GOTO actualizartodo
IF %M%==2 goto bdupdate
IF %M%==3 goto copiadlls
IF %M%==4 goto detener
IF %M%==5 GOTO iniciar
IF %M%==9 goto config
IF %M%==0 goto salir
echo Opcion Invalida
pause
goto menu

:actualizartodo
cls
net stop %nombreservicio%
pause
cls
start .\Actions\UpdateCli.exe %server% %base% %user% %pass% %scripts% %scriptsempresa%
pause
cls
xcopy /S /D /Y Actions\* %rutaprod%
pause
cls
xcopy /D /D /Y SummaWeb\* %rutasitio%
pause
cls
set input=""
set /P input=Iniciar Servicio?(y/N)=
if %input%=="y" net start %servicio%
if %input%=="Y" net start %servicio%
set input=""
pause
cls
goto menu

:iniciar
net start %servicio%
goto menu

:detener
net stop %servicio%
goto menu

:bdupdate
start cmd /k C:\SummaAdvancedFwk\Wizards\BDUpdate\UpdateCli\bin\Debug\UpdateCli.exe %server% %base% %user% %pass% C:\SummaAdvanced\Scripts ""
goto menu

:config
rem configuracion= scripts; scriptsempresa; server; base; user; pass; rutaprod; nombreservicio;
set input=""

cls
set /P input=Ruta Scripts (%scripts%)=
if not %input%=="" set scripts=%input%
set input=""

cls
set /P input=Scripts Empresa (%scriptsempresa%)=
if not %input%=="" set scriptsempresa=%input%
set input=""

cls
set /P input=Server (%server%)=
if not %input%=="" set base=%input%
set input=""

cls
set /P input=Base (%base%)=
if not %input%=="" set base=%input%
set input=""

cls
set /P input=Usuario (%user%)=
if not %input%=="" set user=%input%
set input=""

cls
set /P input=Password (%pass%)=
if not %input%=="" set pass=%input%
set input=""

cls
set /P input=Ruta DLLs Produccion (%rutaprod%)=
if not %input%=="" set rutaprod=%input%
set input=""

cls
set /P input=Servicio QBI (%nombreservicio%)=
if not %input%=="" set nombreservicio=%input%
set input=""

cls
set /P input=Sitio Web (%rutasitio%)=
if not %input%=="" set rutasitio=%input%
set input=""

if exist ruta.info del ruta.info
echo %scripts%;%scriptsempresa%;%server%;%base%;%user%;%pass%;%rutaprod%;%nombreservicio%;%rutasitio%;>>config.info

sc query %nombreservicio% > tmp.txt|find "STATE"
set /p estado=<tmp.txt
del tmp.txt
goto menu

:bdupdateesp
start cmd /k C:\SummaAdvancedFwk\Wizards\BDUpdate\UpdateCli\bin\Debug\UpdateCli.exe %server% %base% %user% %pass% C:\SummaAdvanced\Scripts C:\SummaAdvancedQ\Empresas\%empresa%\Scripts
goto menu

:fin
exit 
