
alter session set current_schema = project_sys;

-- Role Sinh vien
create role SinhVien;
grant select,update (DCHI, DT) on SINHVIEN to SinhVien;
grant select on KHMO to SinhVien;
grant select on HOCPHAN to SinhVien;
grant select,insert,delete on DANGKY to SinhVien; -- need trigger for insert

-- revoke select on DANGKY from SinhVien;
select ROLE from DBA_ROLES where role = 'SINHVIEN'; -- list of roles
select * from dba_users where username = UPPER('whatthefuck');
select * from DBA_SYS_PRIVS; -- list of people and their privileges
select * from DBA_ROLE_PRIVS; -- list of people and their roles
SELECT NAME FROM SYSTEM_PRIVILEGE_MAP; -- list of system privileges
select * from all_tables where owner = upper('project_sys');

select * from DBA_SYS_PRIVS where grantee = upper('whatthefuck') union all select * from DBA_ROLE_PRIVS  where GRANTEE = UPPER('whatthefuck');

create role TruongKhoa;

-- grant create table to TruongKhoa;
-- revoke create table from TruongKhoa;

grant select, update, delete on NHANSU to TruongKhoa;
grant select on SINHVIEN to TruongKhoa;
grant select on DANGKY to TruongKhoa;
grant select on KHMO to TruongKhoa;
grant select on HOCPHAN to TruongKhoa;
grant select on DONVI to TruongKhoa;
grant select,update,delete on PHANCONG to TruongKhoa;

-- CS#5
-- Ham dac biet cua Truong Khoa

CREATE OR REPLACE FUNCTION TruongKhoaFunc(schema_var IN VARCHAR2, table_name IN VARCHAR2)
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

  IF v_vaitro = N'Trưởng khoa' THEN
    RETURN '1 = 1'; 
  ELSE
    RETURN '1 = 0'; 
  END IF;
END;
/

BEGIN
  DBMS_RLS.ADD_POLICY (
    object_schema   => 'project_sys',
    object_name     => 'NHANSU',
    policy_name     => 'TruongKhoa',
    function_schema => 'project_sys',
    policy_function => 'TruongKhoaFunc',
    statement_types => 'SELECT',
    enable          => TRUE);
END;
/
BEGIN
  DBMS_RLS.ADD_POLICY (
    object_schema   => 'project_sys',
    object_name     => 'SINHVIEN',
    policy_name     => 'TruongKhoa',
    function_schema => 'project_sys',
    policy_function => 'TruongKhoaFunc',
    statement_types => 'SELECT',
    enable          => TRUE);
END;
/

BEGIN
    DBMS_RLS.DROP_POLICY(
        object_schema => 'project_sys',  -- replace with your schema name
        object_name => 'SINHVIEN',  -- replace with your table name
        policy_name => 'SINHVIENXEM'  -- replace with your policy name
    );
END;

-- CS#6
create or replace function SinhVienFunc (P_SCHEMA varchar2, P_OBJ varchar2)
return varchar2
as
    user varchar(100);
    is_dba VARCHAR2(5);
    role VARCHAR(2);
begin
    is_dba := SYS_CONTEXT('USERENV', 'ISDBA');
    IF is_dba = 'TRUE' THEN
        RETURN '';
    else
        user := sys_context('userenv','session_user');
        role := substr(user,1,2);
        if role = 'NV' then 
            return '1=1';
        elsif role = 'SV' then
            return 'MASV = ' || user;
        else
            return '1=1';
        end if;
        -- user := SUBSTR(user, 4);
        -- return 'MASV = ''' || user || '''';
    end if;
end;
/

select * from DBA_POLICIES;

BEGIN
    DBMS_RLS.DROP_POLICY(
        object_schema => 'project_sys',  -- replace with your schema name
        object_name => 'SINHVIEN',  -- replace with your table name
        policy_name => 'SINHVIENXEM'  -- replace with your policy name
    );
END;

create or replace function SinhVien_HP_KHMO
 (P_SCHEMA varchar2, P_OBJ varchar2)
return varchar2
as
    user varchar(100);
begin
    user := sys_context('userenv','session_user');
    -- user := SUBSTR(user, 4);
    return 'MASV = ''' || user || '''';
end;
/

BEGIN
  DBMS_RLS.ADD_POLICY (
    object_schema   => 'project_sys',
    object_name     => 'SINHVIEN',
    policy_name     => 'SinhVienXem',
    function_schema => 'project_sys',
    policy_function => 'SinhVienFunc',
    statement_types => 'SELECT'
    -- update_check    => TRUE
    );
END;
/

BEGIN
  DBMS_RLS.ADD_POLICY (
    object_schema   => 'project_sys',
    object_name     => 'DANGKY',
    policy_name     => 'SinhVien',
    function_schema => 'project_sys',
    policy_function => 'SinhVienFunc',
    statement_types => 'SELECT,INSERT,DELETE',
    update_check    => TRUE,
    enable          => TRUE);
END;
/

select * from project_sys.NHANSU;
select * from project_sys.SINHVIEN;
select * from DANGKY;

select sys_context('USERENV','ISDBA') from dual;

