
alter session set current_schema = ad;

-- CS#5:
-- Như một người dùng có vai trò “Giảng viên”  
-- Thêm, Xóa, Cập nhật dữ liệu trên quan hệ PHANCONG đối với các học phần quản lý bởi đơn vị “Văn phòng khoa”. 
-- Được quyền Xem, Thêm, Xóa, Cập nhật trên quan hệ NHANSU. 
-- Được quyền Xem (không giới hạn) dữ liệu trên toàn bộ lược đồ CSDL. 

GRANT SELECT ON VIEW_GV_PC TO RL_TK;
GRANT SELECT ON VIEW_GV_DK TO RL_TK;
GRANT UPDATE(DIEMTH, DIEMQT, DIEMCK, DIEMTK) ON VIEW_GV_DK TO RL_TK;


grant select on SINHVIEN to RL_TK;
grant select on DONVI to RL_TK;
grant select on HOCPHAN to RL_TK;
grant select on KHMO to RL_TK;
GRANT SELECT ON VIEW_THONGTIN_NVCB TO RL_TK;
GRANT UPDATE(DT) ON VIEW_THONGTIN_NVCB TO RL_TK;

-- Thêm, Xóa, Cập nhật dữ liệu trên quan hệ PHANCONG đối với các học phần quản lý bởi đơn vị “Văn phòng khoa”. 
CREATE OR REPLACE VIEW VIEW_TK_PC AS
SELECT PC.*
FROM DONVI DV JOIN HOCPHAN HP ON hp.madv = dv.madv JOIN PHANCONG PC ON pc.mahp = hp.mahp
WHERE dv.tendv = 'VĂN PHÒNG KHOA' AND dv.trgdv = SYS_CONTEXT('USERENV', 'SESSION_USER');

-- Được quyền Xem, Thêm, Xóa, Cập nhật trên quan hệ NHANSU. 
GRANT SELECT, DELETE, UPDATE, INSERT ON VIEW_TK_PC TO RL_TK;

grant select, update, delete on NHANSU to RL_TK;


-- Được quyền Xem (không giới hạn) dữ liệu trên toàn bộ lược đồ CSDL.
grant select on SINHVIEN to TruongKhoa;
grant select on DANGKY to TruongKhoa;
grant select on KHMO to TruongKhoa;
grant select on HOCPHAN to TruongKhoa;
grant select on DONVI to TruongKhoa;


-- CS#6: Người dùng có VAITRO là “Sinh viên”
-- Trên quan hệ SINHVIEN, sinh viên chỉ được xem thông tin của chính mình, được 
-- Chỉnh sửa thông tin địa chỉ (ĐCHI) và số điện thoại liên lạc (ĐT) của chính sinh viên. 
-- Xem danh sách tất cả học phần (HOCPHAN), kế hoạch mở môn (KHMO) của chương trình đào tạo mà sinh viên đang theo học. 
-- Thêm, Xóa các dòng dữ liệu đăng ký học phần (ĐANGKY) liên quan đến chính sinh viên đó trong học kỳ của năm học hiện tại (nếu thời điểm hiệu chỉnh đăng ký còn hợp lệ).  
-- Sinh viên không được chỉnh sửa trên các trường liên quan đến điểm.  

create or replace function FUNC_SV_SV (P_SCHEMA varchar2, P_OBJ varchar2)
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
        IF ROLE = 'SV' THEN
            RETURN 'MASV = ''' || USER ||'''';
        else
            return '';
        end if;
    end if;
end;
/

BEGIN
  DBMS_RLS.ADD_POLICY (
    object_schema   => 'AD',
    object_name     => 'SINHVIEN',
    policy_name     => 'SV_SV',
    function_schema => 'AD',
    policy_function => 'FUNC_SV_SV',
    statement_types => 'SELECT'
    );
END;
/

BEGIN
  DBMS_RLS.ADD_POLICY (
    object_schema   => 'AD',
    object_name     => 'SINHVIEN',
    policy_name     => 'SV_SV_DC',
    function_schema => 'AD',
    policy_function => 'FUNC_SV_SV',
    statement_types => 'UPDATE',
    sec_relevant_cols=> 'DCHI',
    update_check    => TRUE
    );
END;
/

create or replace function FUNC_SV_KHMO (P_SCHEMA varchar2, P_OBJ varchar2)
return varchar2
as
    user varchar(100);
    is_dba VARCHAR2(5);
    role VARCHAR(2);
    MA VARCHAR2(4);
    STRSQL VARCHAR2(20000);
    CURSOR CUR IS (SELECT MAHP FROM ad.KHMO WHERE NAM = EXTRACT(YEAR FROM SYSDATE) and  MACT = (SELECT MACT FROM ad.SINHVIEN WHERE upper(MASV) = sys_context('userenv','session_user')));
begin
    is_dba := SYS_CONTEXT('USERENV', 'ISDBA');
    IF is_dba = 'TRUE' THEN
        RETURN '';
    else
        user := sys_context('userenv','session_user');
        role := substr(user,1,2);
        IF ROLE = 'SV' THEN
            OPEN CUR;
            LOOP 
                FETCH CUR INTO MA;
                EXIT WHEN CUR%NOTFOUND;
                
                IF (STRSQL IS NOT NULL) THEN 
                    STRSQL := STRSQL ||''', '''; 
                END IF; 
                
                STRSQL := STRSQL || upper(MA);
            END LOOP;
            CLOSE CUR;
            RETURN 'MAHP IN ('''|| STRSQL||''');';
        else
            return '';
        end if;
    end if;
end;
/

SELECT * FROM ad.KHMO WHERE NAM = EXTRACT(YEAR FROM SYSDATE) and MACT = (SELECT MACT FROM ad.SINHVIEN WHERE MASV = 'SV0001');

SELECT EXTRACT(YEAR FROM SYSDATE);

SELECT MACT FROM ad.SINHVIEN WHERE MASV = 'SV0002';

select * from sinhvien;

BEGIN
  DBMS_RLS.ADD_POLICY (
    object_schema   => 'AD',
    object_name     => 'HOCPHAN',
    policy_name     => 'SV_HP',
    function_schema => 'AD',
    policy_function => 'FUNC_SV_KHMO',
    statement_types => 'SELECT'
    );
END;
/

GRANT SELECT ON AD.SINHVIEN TO RL_SV;
GRANT UPDATE ON AD.SINHVIEN TO RL_SV;
GRANT RL_SV TO SV0001;

GRANT SELECT ON KHMO TO RL_SV;
GRANT SELECT ON HOCPHAN TO RL_SV;

SELECT * FROM SINHVIEN;

BEGIN
  DBMS_RLS.ADD_POLICY (
    object_schema   => 'AD',
    object_name     => 'KHMO',
    policy_name     => 'SV_KHMO',
    function_schema => 'AD',
    policy_function => 'FUNC_SV_KHMO',
    statement_types => 'SELECT'
    );
END;
/

--select s.sid,s.serial#,s.audsid,s.username,s.osuser, s.client_identifier, s.sql_trace,s.action, p.spid, p.TRACEFILE
--from v$session s,v$process p
--where s.paddr=p.addr
--and s.username is not null;


select * from DBA_POLICIES;

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

--BEGIN
--    DBMS_RLS.DROP_POLICY(
--        object_schema => 'project_sys',  -- replace with your schema name
--        object_name => 'SINHVIEN',  -- replace with your table name
--        policy_name => 'SINHVIENXEM'  -- replace with your policy name
--    );
--END;
