alter session set current_schema = ad;

ALTER SESSION SET "_ORACLE_SCRIPT" = TRUE;

create user "4" IDENTIFIED by 4;
GRANT CREATE SESSION TO "4" container = all;

drop user tmp;

create role C##RL_NVCB;

select * from dba_roles;

grant C##RL_NVCB to "4";

--drop user c##4;
grant select on c##ad.NHANSU to tmp;
grant select on c##test.BH_DONHANG to C##RL_KHCN;

CREATE OR REPLACE PROCEDURE USP_CREATEUSER AS
    CURSOR CUR IS 
        SELECT MANV
        FROM NHANSU
        WHERE MANV NOT IN (SELECT TO_NUMBER(USERNAME) FROM ALL_USERS);
    STRSQL VARCHAR2(2000);
    USR NUMBER;
BEGIN
    OPEN CUR;
    
    -- Set Oracle script mode to true for creating users
    STRSQL := 'ALTER SESSION SET "_ORACLE_SCRIPT" = TRUE';
    EXECUTE IMMEDIATE STRSQL;
    
    LOOP
    FETCH CUR INTO USR;
    EXIT WHEN CUR%NOTFOUND;
    
    -- Create user directly using the number value
    STRSQL := 'CREATE USER "' || USR || '" IDENTIFIED BY "' || USR || '"';
    EXECUTE IMMEDIATE STRSQL;
    
    -- Grant connect privileges to the newly created user
    STRSQL := 'GRANT CONNECT TO "' || USR || '"';
    EXECUTE IMMEDIATE STRSQL;
    END LOOP;

    STRSQL := 'ALTER SESSION SET "_ORACLE_SCRIPT" = FALSE';
    EXECUTE IMMEDIATE STRSQL;
    
    CLOSE CUR;
END;

EXEC USP_CREATEUSER;

SELECT * FROM ALL_USERS ORDER BY USERNAME;


CREATE OR REPLACE FUNCTION NVCB1(schema_var IN VARCHAR2, table_name IN VARCHAR2)
RETURN VARCHAR2
AS
    v_session_user VARCHAR2(20);
    v_vaitro NHANSU.VAITRO%TYPE; 
BEGIN
    v_session_user := SYS_CONTEXT('USERENV', 'SESSION_USER');
    SELECT VAITRO INTO v_vaitro
    FROM NHANSU
    WHERE TO_NUMBER(MANV) = TO_NUMBER(v_session_user);

  IF v_vaitro = 'Trưởng đơn vị' THEN
    RETURN '1 = 1'; 
  ELSE
    RETURN '1 = 0'; 
  END IF;
END;

CREATE OR REPLACE FUNCTION NVCB(schema_var IN VARCHAR2, table_name IN VARCHAR2)
RETURN VARCHAR2
AS
    v_session_user varchar2(38);
    v_vaitro NVARCHAR2(20); 
BEGIN
    IF SYS_CONTEXT('USERENV', 'ISDBA') THEN
        RETURN ' ';
    ELSE
        v_session_user := SYS_CONTEXT('USERENV', 'SESSION_USER');
        SELECT VAITRO INTO v_vaitro
        FROM NHANSU
        WHERE MANV = 4;
        return 'MANV = ' || v_session_user;    
    END IF;
END;
/
SELECT VAITRO 
FROM NHANSU

SELECT NVCB('ad', 'NHANSU') FROM DUAL;

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
 POLICY_NAME =>'NVCB1',
 FUNCTION_SCHEMA => 'ad',
 POLICY_FUNCTION=>'NVCB1',
 STATEMENT_TYPES=>'SELECT'
 );
END;

grant select on ad.NHANSU to "4";
grant select on ad.SINHVIEN to "4";
GRANT EXECUTE ON NVCB TO "4";

BEGIN
 DBMS_RLS.DROP_POLICY(
 'ad','SINHVIEN','NVCB1'
 );
END;

BEGIN
 DBMS_RLS.DROP_POLICY(
 'ad','NHANSU','NVCB'
 );
END;

SELECT (SYS_CONTEXT('USERENV', 'SESSION_USER')) FROM DUAL;

SELECT * FROM ad.NHANSU;