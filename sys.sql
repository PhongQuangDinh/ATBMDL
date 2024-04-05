alter session set current_schema = sys;
ALTER SESSION SET "_ORACLE_SCRIPT" = TRUE;

create user ad IDENTIFIED by 123;
GRANT CREATE SESSION TO ad container = all;
CONNECT ad/123; 

GRANT ALL privileges TO AD;

Grant SYSDBA TO ad;