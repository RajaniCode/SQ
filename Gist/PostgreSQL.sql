-- PostgreSQL


Port:
5432


/*
-- Command
>psql -- version
psql (PostgreSQL) 10.5
>psql -V
psql (PostgreSQL) 10.5
> psql -U postgres

-- Git Bash
$ psql -- version
psql (PostgreSQL) 10.5
$ psql -V
psql (PostgreSQL) 10.5
$ psql -U postgres
\list 
\l
\dt
\connect postgres

-- Version
SELECT version();

-- Databases
SELECT datname FROM pg_database
WHERE datistemplate = false;
-- OR
SELECT d.datname as "Name",
       pg_catalog.pg_get_userbyid(d.datdba) as "Owner",
       pg_catalog.pg_encoding_to_char(d.encoding) as "Encoding",
       d.datcollate as "Collate",
       d.datctype as "Ctype",
       pg_catalog.array_to_string(d.datacl, E'\n') AS "Access privileges"
FROM pg_catalog.pg_database d
ORDER BY 1;

-- Current Database
SELECT current_database();

-- Tables in Current Database
SELECT table_name FROM information_schema.tables WHERE table_schema = 'public';
-- OR
SELECT table_schema, table_name
FROM information_schema.tables
ORDER BY table_schema DESC, table_name

-- Columns
SELECT column_name FROM information_schema.columns
WHERE table_name = 'customer';
-- OR
SELECT column_name, udt_name FROM information_schema.columns
WHERE table_name = 'customer';
-- OR
SELECT * FROM information_schema.columns
WHERE table_name = 'customer';

-- In PostgreSQL, close one database connection to use another database

CREATE DATABASE testdb;

SELECT pg_terminate_backend(pg_stat_activity.pid)
FROM pg_stat_activity
WHERE pg_stat_activity.datname = 'testdb'
AND pid <> pg_backend_pid();

DROP DATABASE IF EXISTS testdb;

DROP DATABASE testdb;

-- Note:
-- COMMIT; 
-- ROLLBACK;

\q



-- psql -U postgres
-- postgres=# \connect postgres;
-- postgres=# DROP DATABASE IF EXISTS sampledb;

CREATE DATABASE sampledb;

-- \connect sampledb;

DROP TABLE IF EXISTS users;
CREATE TABLE users
(
    id SERIAL NOT NULL,
    username VARCHAR(50) NOT NULL, 
    login_date DATE NOT NULL DEFAULT CURRENT_DATE,
    login_time TIME NOT NULL DEFAULT CURRENT_TIME,
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    updated_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP,    
    CONSTRAINT pk_id PRIMARY KEY(id),
    CONSTRAINT idx_username UNIQUE(username)    
);

SELECT * FROM users;

INSERT INTO users(username, login_date, login_time, created_at, updated_at)
VALUES('Foo', '2016-11-06', '10:49:35', '2016-11-06 10:49:35.0', '2016-11-06 10:49:35.0');

SELECT * FROM users;
*/


/*
-- SEQUENCE
DROP SEQUENCE IF EXISTS test_seq;

-- START value (0) cannot be less than MINVALUE (1)
CREATE SEQUENCE test_seq START 1 INCREMENT 2;

DROP TABLE  IF EXISTS test;

CREATE TABLE test (
  id integer DEFAULT nextval('test_seq') NOT NULL,
  value VARCHAR(32)
);

-- INSERT INTO test (value) VALUES ('foo');
-- INSERT INTO test (value) VALUES ('bar');

-- ALTER SEQUENCE test_seq RESTART WITH 100;

-- Workaround for START value (0) cannot be less than MINVALUE (1)
-- INSERT INTO test VALUES (0, 'foo');

INSERT INTO test (value) VALUES ('baz');
INSERT INTO test (value) VALUES ('qux');

SELECT * FROM test;
*/


-- Function

CREATE OR REPLACE FUNCTION add_em(x integer, y integer) RETURNS integer AS $$
    SELECT x + y;
$$ LANGUAGE SQL;

SELECT add_em(1, 2) AS answer;

-- Function

CREATE OR REPLACE FUNCTION count_customer() RETURNS bigint AS $$
    SELECT count(*) from customer;
$$ LANGUAGE SQL;

SELECT count_customer() AS answer;

-- Function

CREATE OR REPLACE FUNCTION hi_lo(
 a NUMERIC, 
 b NUMERIC,
 c NUMERIC, 
        OUT hi NUMERIC,
 OUT lo NUMERIC)
AS $$
BEGIN
 hi := GREATEST(a,b,c);
 lo := LEAST(a,b,c);
END; $$
LANGUAGE plpgsql;

SELECT hi_lo(10,20,30);

-- Function

CREATE OR REPLACE FUNCTION square(
 INOUT a NUMERIC)
AS $$
BEGIN
 a := a * a;
END; $$
LANGUAGE plpgsql;

SELECT square(4);

-- Function

create table department(id int primary key, name text);
insert into department values (1, 'Management');
insert into department values (2, 'IT');
select * from department;

create table employee(id int primary key, name text, salary int, departmentid int references department);
insert into employee values (1, 'John Smith', 30000, 1);
insert into employee values (2, 'Jane Doe', 50000, 1);
insert into employee values (3, 'Jack Jackson', 60000, 2);
select * from employee;

create or replace function GetEmployees() returns setof employee as 'select * from employee;' language 'sql';
select * from GetEmployees() where id > 2;
create type holder as (departmentid int, totalsalary int8);

create function SqlDepartmentSalaries() returns setof holder as
'
select departmentid, sum(salary) as totalsalary from GetEmployees() group by departmentid
'
language 'sql';
create or replace function PLpgSQLDepartmentSalaries() returns setof holder as
'
declare
r holder%rowtype;
begin
for r in select departmentid, sum(salary) as totalsalary from GetEmployees() group by departmentid loop
return next r;
end loop;
return;
end
'
language 'plpgsql';
select * from PLpgSQLDepartmentSalaries();


# Backup # [SQL dump]

$ pg_dump -U postgres -f "E:\Working\SQL\PostgreSQL\PostgreSQL-Queries\pg_dump\SQL-dump\employeedb_backup.sql" employeedb

# Backup # [Compressed dump]

$ pg_dump -U postgres employeedb | gzip > "E:\Working\SQL\PostgreSQL\PostgreSQL-Queries\pg_dump\Compressed-dump\employeedb.gz"

# Restore 

$ psql -U postgres

postgres=# SELECT version();

postgres=# \l

postgres=# DROP DATABASE IF EXISTS employeedb;

postgres=# \l

postgres=# CREATE DATABASE employeedb;

postgres=# \l

postgres=# \q

# psql # [SQL dump]

$ psql -U postgres -d employeedb -f "E:\Working\SQL\PostgreSQL\PostgreSQL-Queries\pg_dump\SQL-dump\employeedb_backup.sql"

# psql # [Compressed dump]

$ gunzip "E:\Working\SQL\PostgreSQL\PostgreSQL-Queries\pg_dump\Compressed-dump\employeedb.gz"

$ psql -U postgres -d employeedb -f "E:\Working\SQL\PostgreSQL\PostgreSQL-Queries\pg_dump\Compressed-dump\employeedb"

# pg_restore # [Compressed dump] [vide pg_restore.txt]

$ psql -U postgres

postgres=# \connect employeedb

postgres=# SELECT * FROM employee;

postgres=# \q


# https://www.postgresql.org/docs/current/static/app-psql.html#APP-PSQL-META-COMMANDS-COPY

$ mkdir "C:/Users/Aspire/Desktop/CSV"

$ psql -U postgres

\connect sample

\copy (SELECT * FROM customer) to 'C:/Users/Aspire/Desktop/CSV/customer.csv' with csv

SELECT customer_id, store_id, first_name, last_name, email, address_id, activebool::integer, create_date, last_update, active FROM customer;

\copy (SELECT customer_id, store_id, first_name, last_name, email, address_id, activebool::integer, create_date, last_update, active FROM customer) to 'C:/Users/Aspire/Desktop/CSV/customer.csv' with csv

\q

$ cat 'C:/Users/Aspire/Desktop/CSV/customer.csv'


-- Credit
/*
https://postgresql.org/
*/