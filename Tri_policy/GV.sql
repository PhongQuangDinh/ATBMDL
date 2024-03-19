alter session set current_schema = NV009;

select * from ad.nhansu;

select * from ad.sinhvien;

select * from ad.donvi;

select * from AD.hocphan;

select * from ad.khmo;

select * from ad.phancong;

SELECT SYS_CONTEXT('USERENV', 'SESSION_USER') FROM DUAL;
SELECT SYS_CONTEXT('USERENV', 'ISDBA') FROM DUAL;

UPDATE ad.PHANCONG
SET MACT = 'CLC'
WHERE MAGV = 'NV048' AND MAHP = 'HP04' AND HK = 1 AND NAM = 2020;

UPDATE ad.PHANCONG
SET MACT = 'CLC'
WHERE MAGV = 'NV012' AND MAHP = 'HP26' AND HK = 2 AND NAM = 2023;