alter session set current_schema = NV001;

select * from ad.V_NVCB;
update ad.V_NVCB
set PHUCAP = 4;

select * from ad.sinhvien;

select * from ad.donvi;

select * from AD.hocphan;

select * from ad.khmo;

SELECT SYS_CONTEXT('USERENV', 'SESSION_USER') FROM DUAL;
SELECT SYS_CONTEXT('USERENV', 'ISDBA') FROM DUAL;
