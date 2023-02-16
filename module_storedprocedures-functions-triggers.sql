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
	SELECT DNUMBER, 0 AS TOTALSALARY FROM DEPARTMENT;
    

DELIMITER //

CREATE PROCEDURE updateSalary (IN PARAML int)
	begin
		UPDATE DEPTSAL
			SET TOTALSALARY = (SELECT SUM(SALARY) FROM EMPLOYEE WHERE DNO = PARAML)
            WHERE DNUMBER = PARAML;
    end; //
    
DELIMITER ; -- apparently di gumana query to change delimeter, idk why. note to search about this later

call updateSalary(1);
call updateSalary(2);
call updateSalary(3);
call updateSalary(4);

DROP PROCEDURE updateSalary;

DELIMITER $$

CREATE PROCEDURE updateSalary()
	begin
		declare done int default 0;
        declare current_dnum int;
        declare dnumcur cursor for select dnumber from deptsal;
        declare continue handler for not found set done = 1;
        
        open dnumcur;
        
        repeat
			fetch dnumcur into current_dnum;
            update deptsal
				set totalsalary = (select sum(salary) from employee
									where dno = current_dnum)
				where dnumber = current_dnum;
		until done
        end repeat;
        
        close dnumcur;
        
    end$$
    
DELIMITER ;

UPDATE DEPTSAL SET  TOTALSALARY = 0;

CALL UPDATESALARY;

DELIMITER |

CREATE PROCEDURE GIVERAISE (IN AMOUNT DOUBLE)
	BEGIN
		DECLARE DONE INT DEFAULT 0;
        DECLARE ID INT;
        DECLARE SAL INT;
        DECLARE EMPREC CURSOR FOR SELECT SSN, SALARY FROM EMPLOYEE;
        DECLARE CONTINUE HANDLER FOR NOT FOUND SET DONE = 1;
        
        OPEN EMPREC;
        REPEAT
			FETCH EMPREC INTO ID, SAL;
            UPDATE EMPLOYEE SET SALARY = SAL + ROUND(SAL * AMOUNT)
            WHERE ID = SSN;
		UNTIL DONE
        END REPEAT;
    END |
    
DELIMITER ;

DROP PROCEDURE GIVERAISE;

CALL GIVERAISE(0.1);

-- FUNCTIOOOOOOOOONSSS YAAAAAAAAAYY
-- NOTES: Need admin privileges 

DELIMITER |

CREATE FUNCTION GIVERAISE (OLDVAL DOUBLE, AMOUNT DOUBLE)
	RETURNS DOUBLE
    DETERMINISTIC
    BEGIN
		DECLARE NEWVAL DOUBLE;
        SET NEWVAL = OLDVAL  * (1 + AMOUNT);
        RETURN NEWVAL;
    END|
    
DELIMITER ;
    
SELECT SSN, SALARY, GIVERAISE(SALARY, 0.1) AS NEWSAL
	FROM EMPLOYEE;
    
SELECT * FROM EMPLOYEE;
   
DELIMITER |

CREATE TRIGGER UPDATE_SALARY
	AFTER INSERT ON EMPLOYEE
    FOR EACH ROW
    BEGIN
		IF NEW.DNO IS NOT NULL THEN
			UPDATE DEPTSAL
            SET TOTALSALARY = TOTALSALARY + NEW.SALARY
            WHERE DNUMBER = NEW.DNO;
		END IF;
	END |
    
DELIMITER ;

SELECT * FROM EMPLOYEE;

INSERT INTO EMPLOYEE VALUES (1234567880, 'Rupi', 'Kaur', 30000, 4);

DELIMITER |

CREATE TRIGGER UPDATE_SALARY2
	AFTER UPDATE ON EMPLOYEE
    FOR EACH ROW
    BEGIN
		IF OLD.DNO IS NOT NULL THEN
			UPDATE DEPTSAL
            SET TOTALSALARY = TOTALSALARY - OLD.SALARY
            WHERE DNUMBER = OLD.DNO;
		END IF;
        IF NEW.DNO IS NOT NULL THEN
			UPDATE DEPTSAL
            SET TOTALSALARY = TOTALSALARY + NEW.SALARY
            WHERE DNUMBER = NEW.DNO;
		END IF;
	END |
    
DELIMITER ;

UPDATE EMPLOYEE SET SALARY = 100000 WHERE SSN = 1234567890;

DELIMITER |

CREATE TRIGGER UPDATE_SALARY3
	BEFORE DELETE ON EMPLOYEE
    FOR EACH ROW
    BEGIN
		IF (OLD.DNO IS NOT NULL) THEN
			UPDATE DEPTSAL
            SET TOTALSALARY = TOTALSALARY - OLD.SALARY
            WHERE DNUMBER = OLD.DNO;
		END IF;
	END |
    
DELIMITER ;

-- DELETE FROM EMPLOYEE WHERE SSN = 1234567897;
-- This did not work pala dahil manager siya. Naka foreign key.

DELETE FROM EMPLOYEE WHERE SSN = 1234567899;

SHOW TRIGGERS;



