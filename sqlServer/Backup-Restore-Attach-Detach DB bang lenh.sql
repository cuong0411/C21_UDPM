--Backup DB:
backup database QUANLYBANHANG
to disk = 'D:\QUANLYBANHANG.bak'
with password = '12345'
--Restore DB:
restore database QUANLYBANHANG
from disk = 'D:\QUANLYBANHANG.bak'
with password = '12345',replace --Nếu muốn đè lên DB cũ

--Detach DB:
SP_DETACH_DB QUANLYBANHANG
--Attach DB:
CREATE DATABASE QUANLYBANHANG
ON(FILENAME='C:\HeQTCSDL\QUANLYBANHANG.MDF')
FOR ATTACH