@echo off
sqlcmd -S . -E -i "script.sql"
pause
