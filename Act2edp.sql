CREATE DATABASE EDP_ACT2;
USE EDP_ACT2;

CREATE TABLE EMPLOYEE
(
	SSN int PRIMARY KEY,
	FNAME varchar(25),
    LNAME varchar(25),
    SALARY int,
    DNO int
);

CREATE TABLE DEPARTMENT
(
	DNUMBER int PRIMARY KEY auto_increment,
    DNAME varchar(25),
    MGRSSN int,
    FOREIGN KEY (MGRSSN) REFERENCES EMPLOYEE (SSN)
);

ALTER TABLE EMPLOYEE ADD FOREIGN KEY (DNO) REFERENCES DEPARTMENT (DNUMBER);

INSERT INTO EMPLOYEE (SSN, FNAME, LNAME, SALARY) VALUES
	(1234567890, 'Menchie', 'Belarmino', 30000),
	(1234567891, 'Emily', 'Dickinson', 40000),
    (1234567892, 'Edgar', 'Poe', 50000),
    (1234567893, 'Kahlil', 'Gibran', 60000),
    (1234567894, 'Tim', 'Berners-Lee', 70000),
    (1234567895, 'Allan', 'Turing', 80000),
    (1234567896, 'Ada', 'Lovelace', 90000),
    (1234567897, 'Noor', 'Shirazie', 20000),
    (1234567898, 'Pablo', 'Neruda', 25000),
    (1234567899, 'Sylvia', 'Plath', 28000)
;

INSERT INTO DEPARTMENT (DNAME, MGRSSN) VALUES
	('IT', 1234567890),
    ('Marketing', 1234567894),
    ('Finance', 1234567897),
    ('Production', 1234567896)
;

UPDATE `edp_act2`.`employee` SET `DNO` = '1' WHERE (`SSN` = '1234567890');
UPDATE `edp_act2`.`employee` SET `DNO` = '2' WHERE (`SSN` = '1234567891');
UPDATE `edp_act2`.`employee` SET `DNO` = '3' WHERE (`SSN` = '1234567892');
UPDATE `edp_act2`.`employee` SET `DNO` = '2' WHERE (`SSN` = '1234567894');
UPDATE `edp_act2`.`employee` SET `DNO` = '2' WHERE (`SSN` = '1234567895');
UPDATE `edp_act2`.`employee` SET `DNO` = '4' WHERE (`SSN` = '1234567896');
UPDATE `edp_act2`.`employee` SET `DNO` = '3' WHERE (`SSN` = '1234567897');
UPDATE `edp_act2`.`employee` SET `DNO` = '1' WHERE (`SSN` = '1234567898');
UPDATE `edp_act2`.`employee` SET `DNO` = '1' WHERE (`SSN` = '1234567899');
UPDATE `edp_act2`.`employee` SET `DNO` = '4' WHERE (`SSN` = '1234567893');

CREATE VIEW MANAGER AS
	SELECT FNAME, LNAME, DName, Dnumber, SALARY
	FROM EMPLOYEE, DEPARTMENT
	WHERE SSN=MGRSSN AND DNO=DNUMBER;
    
-- Employees with higher salaries than their manager
SELECT E.FNAME, E.LNAME
	FROM EMPLOYEE E, MANAGER M
    WHERE E.DNO=M.DNUMBER AND E.SALARY > M.SALARY;
    
UPDATE MANAGER 
	SET SALARY = 1.1*SALARY
    WHERE DNAME = 'Research';
    
    
-- Stored Procedures 
    
CREATE TABLE DEPTSAL AS
	SELECT DNUMBER, 0 AS TOTALSALARY FROM DEPARTMENT
    
DELIMITER //

CREATE PROCEDURE updateSalary (IN PARAML int)
	begin
		UPDATE DEPSTAL
			SET TOTALSALARY = (SELECT SUM(SALARY) FROM EMPLOYEE WHERE DNO = PARAML)
            WHERE DNUMBER = PARAML;
    end; //
    
DELIMITER ;