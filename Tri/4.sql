alter session set current_schema = "4";

select * from ad.nhansu;

select * from ad.sinhvien;

SELECT TO_NUMBER(SYS_CONTEXT('USERENV', 'SESSION_USER')) FROM DUAL;

SELECT NVCB('ad', 'NHANSU') FROM DUAL;
