create user c##ad IDENTIFIED by 123;
GRANT CREATE SESSION TO c##ad;
CONNECT c##ad/123; 

Grant DBA TO c##ad container = all;
GRANT ALL PRIVILEGES TO c##ad;
SHOW CON_NAME;
