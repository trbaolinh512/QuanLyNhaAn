@echo off
sqlcmd -S LAPTOP-LCELLU17\MSSQLSERVER03 -E -i "script.sql"
pause
