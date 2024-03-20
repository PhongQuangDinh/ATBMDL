-- Role Sinh vien
create role SinhVien;
grant select,update (DCHI, DT) on SINHVIEN to SinhVien;
grant select on KHMO to SinhVien;
grant select on HOCPHAN to SinhVien;
grant select,insert,delete on DANGKY to SinhVien; -- need trigger for insert




create role TruongKhoa;
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

select * from DBA_POLICIES;

BEGIN
    DBMS_RLS.DROP_POLICY(
        object_schema => 'project_sys',  -- replace with your schema name
        object_name => 'NHANSU',  -- replace with your table name
        policy_name => 'TruongKhoa'  -- replace with your policy name
    );
END;

-- CS#6
create or replace function SinhVienFunc
 (P_SCHEMA varchar2, P_OBJ varchar2)
return varchar2
as
    user varchar(100);
    is_dba VARCHAR2(5);
begin
    is_dba := SYS_CONTEXT('USERENV', 'ISDBA');
    IF is_dba = 'TRUE' THEN
        RETURN '';
    end if;
    user := sys_context('userenv','session_user');
    -- user := SUBSTR(user, 4);
    return 'MASV = ''' || user || '''';
end;
/

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
    policy_name     => 'SinhVien',
    function_schema => 'project_sys',
    policy_function => 'SinhVienFunc',
    statement_types => 'SELECT,UPDATE',
    update_check    => TRUE,
    enable          => TRUE);
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

select * from SINHVIEN;