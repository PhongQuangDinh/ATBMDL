alter session set current_schema = ad;

ALTER SESSION SET "_ORACLE_SCRIPT" = TRUE;

create user NV001 IDENTIFIED by 1;
GRANT CREATE SESSION TO NV001 container = all;
create user NV009 IDENTIFIED by 9;
GRANT CREATE SESSION TO NV009 container = all;

create role RL_NVCB;

grant select,UPDATE(DT) on ad.NHANSU to RL_NVCB;
grant select on ad.SINHVIEN to RL_NVCB;
grant select on ad.DONVI to RL_NVCB;
grant select on ad.HOCPHAN to RL_NVCB;
grant select on ad.KHMO to RL_NVCB;

grant RL_NVCB to NV001;

create role RL_GV;

grant select,UPDATE(DT) on ad.NHANSU to RL_GV;
grant select,insert,update on ad.SINHVIEN to RL_GV;
grant select,insert,update on ad.DONVI to RL_GV;
grant select,insert,update on ad.HOCPHAN to RL_GV;
grant select,insert,update on ad.KHMO to RL_GV;
grant select,UPDATE on ad.PHANCONG to RL_GV;

grant RL_GV to NV009;

--CREATE OR REPLACE PROCEDURE USP_CREATEUSER AS
--    CURSOR CUR IS 
--        SELECT MANV
--        FROM NHANSU
--        WHERE MANV NOT IN (SELECT TO_NUMBER(USERNAME) FROM ALL_USERS);
--    STRSQL VARCHAR2(2000);
--    USR NUMBER;
--BEGIN
--    OPEN CUR;
--    
--    -- Set Oracle script mode to true for creating users
--    STRSQL := 'ALTER SESSION SET "_ORACLE_SCRIPT" = TRUE';
--    EXECUTE IMMEDIATE STRSQL;
--    
--    LOOP
--    FETCH CUR INTO USR;
--    EXIT WHEN CUR%NOTFOUND;
--    
--    -- Create user directly using the number value
--    STRSQL := 'CREATE USER "' || USR || '" IDENTIFIED BY "' || USR || '"';
--    EXECUTE IMMEDIATE STRSQL;
--    
--    -- Grant connect privileges to the newly created user
--    STRSQL := 'GRANT CONNECT TO "' || USR || '"';
--    EXECUTE IMMEDIATE STRSQL;
--    END LOOP;
--
--    STRSQL := 'ALTER SESSION SET "_ORACLE_SCRIPT" = FALSE';
--    EXECUTE IMMEDIATE STRSQL;
--    
--    CLOSE CUR;
--END;

EXEC USP_CREATEUSER;

CREATE OR REPLACE FUNCTION NVCB1(schema_var IN VARCHAR2, table_name IN VARCHAR2)
RETURN VARCHAR2
AS
    v_session_user VARCHAR2(20);
    v_vaitro NHANSU.VAITRO%TYPE; 
    is_dba VARCHAR2(5);
BEGIN
    is_dba := SYS_CONTEXT('USERENV', 'ISDBA');
    IF is_dba = 'TRUE' THEN
        RETURN '1 = 1';
    ELSE
        v_session_user := SYS_CONTEXT('USERENV', 'SESSION_USER');
        SELECT VAITRO INTO v_vaitro
        FROM NHANSU
        WHERE MANV = v_session_user;   
    END IF;

  IF v_vaitro = N'Nhân viên cơ bản' OR v_vaitro = N'Giáo vụ' THEN
    RETURN '1 = 1'; 
  ELSE
    RETURN '1 = 0'; 
  END IF;
END;

CREATE OR REPLACE FUNCTION NVCB(schema_var IN VARCHAR2, table_name IN VARCHAR2)
RETURN VARCHAR2
AS
    v_session_user VARCHAR2(20);
    is_dba VARCHAR2(5);
BEGIN
  is_dba := SYS_CONTEXT('USERENV', 'ISDBA');
  IF is_dba = 'TRUE' THEN
    RETURN '1 = 1';
  ELSE
    v_session_user := SYS_CONTEXT('USERENV', 'SESSION_USER');
    RETURN 'MANV = ''' || v_session_user || '''';  
  END IF;
END;

BEGIN
 DBMS_RLS.ADD_POLICY(
 OBJECT_SCHEMA =>'ad',
 OBJECT_NAME=>'NHANSU',
 POLICY_NAME =>'NVCB',
 FUNCTION_SCHEMA => 'ad',
 POLICY_FUNCTION=>'NVCB',
 STATEMENT_TYPES=>'SELECT'
 );
END;

BEGIN
 DBMS_RLS.ADD_POLICY(
 OBJECT_SCHEMA =>'ad',
 OBJECT_NAME=>'SINHVIEN',
 POLICY_NAME =>'NVCB',
 FUNCTION_SCHEMA => 'ad',
 POLICY_FUNCTION=>'NVCB1',
 STATEMENT_TYPES=>'SELECT'
 );
END;

BEGIN
 DBMS_RLS.ADD_POLICY(
 OBJECT_SCHEMA =>'ad',
 OBJECT_NAME=>'DONVI',
 POLICY_NAME =>'NVCB',
 FUNCTION_SCHEMA => 'ad',
 POLICY_FUNCTION=>'NVCB1',
 STATEMENT_TYPES=>'SELECT'
 );
END;

BEGIN
 DBMS_RLS.ADD_POLICY(
 OBJECT_SCHEMA =>'ad',
 OBJECT_NAME=>'HOCPHAN',
 POLICY_NAME =>'NVCB',
 FUNCTION_SCHEMA => 'ad',
 POLICY_FUNCTION=>'NVCB1',
 STATEMENT_TYPES=>'SELECT'
 );
END;

BEGIN
 DBMS_RLS.ADD_POLICY(
 OBJECT_SCHEMA =>'ad',
 OBJECT_NAME=>'KHMO',
 POLICY_NAME =>'NVCB',
 FUNCTION_SCHEMA => 'ad',
 POLICY_FUNCTION=>'NVCB1',
 STATEMENT_TYPES=>'SELECT'
 );
END;

BEGIN
 DBMS_RLS.DROP_POLICY(
 'ad','NHANSU','NVCB'
 );
END;

CREATE OR REPLACE FUNCTION GV
  (P_SCHEMA VARCHAR2, P_OBJ VARCHAR2)
RETURN VARCHAR2
AS
  MA ad.HOCPHAN.MAHP%TYPE;
  STRSQL VARCHAR2(2000);
  CURSOR CUR IS 
     SELECT MAHP 
     FROM ad.HOCPHAN hp JOIN ad.DONVI dv ON hp.MADV = dv.MADV JOIN ad.NHANSU ns ON dv.TRGDV = ns.MANV 
     WHERE ns.VAITRO = 'Trưởng khoa';
BEGIN
  STRSQL := '';
  OPEN CUR;
  LOOP
     FETCH CUR INTO MA;
     EXIT WHEN CUR%NOTFOUND;
     IF (STRSQL IS NOT NULL AND STRSQL != '') THEN
        STRSQL := STRSQL ||','''|| MA ||'''';
     ELSE
        STRSQL := ''''|| MA ||'''';
     END IF;
  END LOOP;
  CLOSE CUR;
  RETURN 'MAHP IN ('||STRSQL||')';
END;

select GV('AD','PHANCONG') from dual;


BEGIN
 DBMS_RLS.ADD_POLICY(
 OBJECT_SCHEMA =>'ad',
 OBJECT_NAME=>'PHANCONG',
 POLICY_NAME =>'GV',
 FUNCTION_SCHEMA => 'ad',
 POLICY_FUNCTION=>'GV',
 STATEMENT_TYPES=>'UPDATE',
 UPDATE_CHECK => TRUE 
 );
END;

BEGIN
 DBMS_RLS.DROP_POLICY(
 'ad','PHANCONG','GV'
 );
END;

--BEGIN
-- DBMS_RLS.ADD_POLICY(
-- OBJECT_SCHEMA =>'ad',
-- OBJECT_NAME=>'NHANSU',
-- POLICY_NAME =>'NVCB_DT',
-- FUNCTION_SCHEMA => 'ad',
-- POLICY_FUNCTION =>'NVCB',
-- statement_types   => 'UPDATE',
-- update_check => TRUE,
-- sec_relevant_cols => 'DT'
-- );
--END;