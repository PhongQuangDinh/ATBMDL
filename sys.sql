alter session set current_schema = sys;
ALTER SESSION SET "_ORACLE_SCRIPT" = TRUE;
create user ad IDENTIFIED by 123;
GRANT CREATE SESSION TO ad container = all;
CONNECT ad/123; 

Grant DBA TO ad container = all;

--GRANT ALL PRIVILEGES TO ad;

SHOW CON_NAME;

SELECT SYS_CONTEXT('USERENV', 'CON_NAME') from dual;

SELECT * FROM ALL_USERS ORDER BY USERNAME;


select value
from nls_database_parameters
where parameter = 'NLS_CHARACTERSET';
