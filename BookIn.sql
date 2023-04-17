CREATE DATABASE BOOKIN;
USE BOOKIN;

CREATE TABLE BOOK
(
	ISBN INT NOT NULL PRIMARY KEY,
    AUTHOR VARCHAR(100) NOT NULL,
    TITLE VARCHAR(100) NOT NULL,
    PUBLISHER VARCHAR(100),
    PUBLICATION_YEAR INT,
    RETAIL_PRICE INT,
    STOCKS INT
);
    
INSERT INTO BOOK VALUES
	(1234567890, 'Franklin D. Lewis', 'Rumi', 'Oneworld Publications', 2003, 100, 5),
	(1234567891, 'Kristina Mahr', "Say It's the Sea", 'Independent', 2020, 200, 10),
	(1234567892, 'Noor Shirazie', 'Into the Wildfire', NULL, 2016, 300, 15),
	(1234567893, 'Margaret Atwood', 'In Other Worlds', 'Knopf Doubleday Publishing Group', 2011, 400, 50),
	(1234567894, 'Michael Faudet', 'Smoke & Mirrors', 'Andrews McMeel Publishing', 2017, 400, 30),
	(1234567895, 'John Keats', 'Complete Poems', 'Random House Publishing Group', 2009, 210, 20),
    (1234567896, 'Mary Oliver', 'Felicity', 'Penguin Press', 2015, 500, 25),
    (1234567897, 'Allen Gisnberg', 'Howl and Other Poems', 'City Lights Books', 1979, 255, 35),
    (1234567898, 'Trista Mateer', 'Honeybee', 'Central Avenue Publishing', 2018, 560, 40),
    (1234567899, 'Atticus', 'The Dark Between Stars', 'Atria Books', 2018, 600, 65),
    (1234567880, 'Pablo Neruda', 'Love Poems', 'New Directions', 2008, 525, 70);

Update BOOK set title = 'Rumi' where isbn = 1234567890;
Update BOOK set title = "Say It's the Sea" where isbn = 1234567891;
Update BOOK set title = 'Into the Wildfire' where isbn = 1234567892;
Update BOOK set title = 'In Other Worlds' where isbn = 1234567893;
Update BOOK set title = 'Smoke & Mirrors' where isbn = 1234567894;
Update BOOK set title = 'Complete Poems' where isbn = 1234567895;
Update BOOK set title = 'Felicity' where isbn = 1234567896;
Update BOOK set title = 'Howl and Other Poems' where isbn = 1234567897;
Update BOOK set title = 'Honeybee' where isbn = 1234567898;
Update BOOK set title = 'The Dark Between Stars' where isbn = 1234567899;
Update BOOK set title = 'Love Poems' where isbn = 1234567880;
Update BOOK set title = 'I Would Leave Me If I Could' where isbn = 1234567870;


CREATE TABLE PUBLISHER SELECT PUBLISHER FROM BOOK WHERE PUBLISHER IS NOT NULL;

CREATE TABLE AUTHOR SELECT AUTHOR FROM BOOK WHERE AUTHOR IS NOT NULL;

CREATE TABLE ORDER_LINE
(
	ID INT PRIMARY KEY AUTO_INCREMENT,
    ISBN INT NOT NULL,
    ORDER_ID INT,
    QUANTITY INT,
    COST_EACH INT NOT NULL,
    COST_LINE INT NOT NULL
);

INSERT INTO ORDER_LINE (ISBN, ORDER_ID, QUANTITY, COST_EACH, COST_LINE) VALUES
	(1234567890, 1, 1, 100, 100),
	(1234567891, 1, 2, 200, 400),
	(1234567892, 2, 3, 300, 900),
	(1234567893, 3, 1, 400, 400),
	(1234567894, 4, 2, 400, 800),
	(1234567895, 5, 3, 210, 630),
    (1234567896, 6, 4, 500, 2000),
    (1234567897, 7, 1, 255, 255),
    (1234567898, 7, 2, 560, 1120),
    (1234567899, 8, 3, 600, 1800),
    (1234567880, 8, 4, 525, 2100),
    (1234567890, 9, 1, 100, 100),
    (1234567891, 10, 1, 100, 100),
    (1234567896, 11, 1, 500, 500),
    (1234567896, 12, 2, 500, 1000),
    (1234567897, 13, 2, 255, 510);

CREATE TABLE `ORDER`
(
	ORDER_ID INT,
    CUSTOMER_ID INT NOT NULL,
    ORDER_DATE DATE,
    ORDER_FILLED BOOL NOT NULL
);

INSERT INTO `ORDER` VALUES
	(1, 1, '2023-01-01', true),
    (2, 2, '2023-01-02', true),
    (3, 3, '2023-01-03', true),
    (4, 4, '2023-01-06', true),
    (5, 5, '2023-01-06', true),
    (6, 6, '2023-01-08', true),
    (7, 7, '2023-01-12', true),
    (8, 8, '2023-01-18', true),
    (9, 9, '2023-01-25', true),
    (10, 10, '2023-02-02', true),
    (11, 1, '2023-02-06', true),
    (12, 2, '2023-02-14', false),
    (13, 3, '2023-02-16', false);
    

CREATE TABLE CUSTOMER
(
	ID INT PRIMARY KEY auto_increment,
    FIRST_NAME VARCHAR(50),
    LAST_NAME VARCHAR(50),
    CITY VARCHAR(50),
    PROVINCE VARCHAR(50),
    ZIP INT,
    PHONE VARCHAR(50),
	EMAIL VARCHAR(50)
);

INSERT INTO CUSTOMER (FIRST_NAME, LAST_NAME, CITY, PROVINCE, ZIP, PHONE, EMAIL) VALUES
	('Menchie', 'Belarmino', 'Tabaco City', 'Albay', 4511, '09001122334', 'mench@email.com'),
    ('Jane', 'Doe', 'Legazpi City', 'Albay', 4500, '09012345678', 'janedoe@email.com'),
    ('John', 'Doe', 'Legazpi City', 'Albay', 4500, '09123456789', 'johndoe@email.com'),
    ('John', 'Smith', 'Sorsogon City', 'Sorsogon', 4700, '09234567891', 'johnsmith@email.com'),
    ('Jane', 'Smith', 'Sorsogon City', 'Sorsogon', 4700, '09345678912', 'janesmith@email.com'),
    ('Juan', 'Delacruz', 'Camalig', 'Albay', 4502, '09456789123', 'juandelacruz@email.com'),
    ('Juanita', 'Delacruz', 'Bato', 'Camarines Sur', 4435, '09567891234', 'juanitadelacruz@email.com'),
    ('James', 'Potter', 'Daet', 'Camarines Norte', 4600, '09678901234', 'jamespotter@email.com'),
	('Lily', 'Potter', 'Daet', 'Camarines Norte', 4600, '09001112222', 'lilypotter@email.com'),
    ('Harry', 'Potter', 'Daet', 'Camarines Norte', 4600, 09112223333, 'harrypotter@gmail.com');
    
-- VIEWS NA YAY
CREATE VIEW BESTSELLERS_BY_REVENUE AS
	SELECT
		TITLE,
        SUM(COST_LINE) AS REVENUE
	FROM BOOK, ORDER_LINE
    WHERE BOOK.ISBN = ORDER_LINE.ISBN
	GROUP BY ORDER_LINE.ISBN
    ORDER BY REVENUE DESC
    LIMIT 5;

CREATE VIEW BESTSELLERS_BY_ORDER AS
	SELECT
		TITLE,
        SUM(QUANTITY) AS TOTAL_ORDERS
	FROM BOOK, ORDER_LINE
    WHERE BOOK.ISBN = ORDER_LINE.ISBN
    GROUP BY ORDER_LINE.ISBN
    ORDER BY TOTAL_ORDERS DESC
    LIMIT 5;
    
CREATE VIEW ORDERS_TO_SHIP AS
	SELECT `ORDER`.ORDER_ID, `ORDER`.ORDER_FILLED, BOOK.TITLE, ORDER_LINE.QUANTITY, CUSTOMER.*
    FROM `ORDER`
    INNER JOIN ORDER_LINE ON ORDER_LINE.ORDER_ID = `ORDER`.ORDER_ID
    INNER JOIN BOOK ON BOOK.ISBN = ORDER_LINE.ISBN
    INNER JOIN CUSTOMER ON CUSTOMER.ID = CUSTOMER_ID
    WHERE ORDER_FILLED = FALSE;

DELIMITER |

CREATE FUNCTION OFFER_DISCOUNT (OLD_PRICE INT, PERCENT DOUBLE)
	RETURNS DOUBLE
    DETERMINISTIC
    BEGIN
		DECLARE NEW_PRICE DOUBLE;
        SET NEW_PRICE = OLD_PRICE - (OLD_PRICE * PERCENT);
        RETURN NEW_PRICE;
    END |
    
DELIMITER ;
    
SELECT TITLE, RETAIL_PRICE, OFFER_DISCOUNT(RETAIL_PRICE, .2) AS DISCOUNTED_PRICE
	FROM BOOK;

ALTER TABLE CUSTOMER ADD COLUMN TOTAL_SPENT DOUBLE;

DELIMITER |

CREATE PROCEDURE UPDATE_CUSTOMER_SPENT()
	BEGIN
		DECLARE DONE INT DEFAULT 0;
		DECLARE CURRENT_CUST_ID INT;
		DECLARE CUST_ID_CUR CURSOR FOR SELECT ID FROM CUSTOMER;
		DECLARE CONTINUE HANDLER FOR NOT FOUND SET DONE = 1;
		
		OPEN CUST_ID_CUR;
		REPEAT
			FETCH CUST_ID_CUR INTO CURRENT_CUST_ID;
			UPDATE CUSTOMER
			SET TOTAL_SPENT = (SELECT SUM(COST_LINE) FROM ORDER_LINE, `ORDER`
								WHERE ORDER_LINE.ORDER_ID = `ORDER`.ORDER_ID  AND `ORDER`.CUSTOMER_ID = CURRENT_CUST_ID AND `ORDER`.ORDER_FILLED = 1)
			WHERE ID = CURRENT_CUST_ID;
		UNTIL DONE
		END REPEAT;
		CLOSE CUST_ID_CUR;
	END |

DELIMITER ;

CALL UPDATE_CUSTOMER_SPENT;

-- Setting the foreign keys

ALTER TABLE `ORDER` ADD FOREIGN KEY (CUSTOMER_ID) REFERENCES CUSTOMER (ID);
ALTER TABLE `ORDER` ADD PRIMARY KEY (ORDER_ID);
ALTER TABLE ORDER_LINE ADD FOREIGN KEY (ISBN) REFERENCES BOOK (ISBN);
ALTER TABLE ORDER_LINE ADD FOREIGN KEY (ORDER_ID) REFERENCES `ORDER` (ORDER_ID) ON DELETE CASCADE;

ALTER TABLE AUTHOR ADD COLUMN ID INT PRIMARY KEY AUTO_INCREMENT;
ALTER TABLE AUTHOR CHANGE AUTHOR AUTHOR_NAME VARCHAR(50);
ALTER TABLE BOOK ADD COLUMN AUTHOR_ID INT, ADD FOREIGN KEY (AUTHOR_ID) REFERENCES AUTHOR (ID);
UPDATE BOOK SET AUTHOR_ID = (SELECT ID FROM AUTHOR WHERE AUTHOR.AUTHOR_NAME = BOOK.AUTHOR);
ALTER TABLE BOOK DROP COLUMN AUTHOR;

ALTER TABLE PUBLISHER ADD COLUMN ID INT PRIMARY KEY AUTO_INCREMENT;
ALTER TABLE PUBLISHER CHANGE PUBLISHER PUBLISHER_NAME VARCHAR(50);    
ALTER TABLE BOOK ADD COLUMN PUBLISHER_ID INT, ADD FOREIGN KEY (PUBLISHER_ID) REFERENCES PUBLISHER (ID);
UPDATE BOOK SET PUBLISHER_ID = (SELECT ID FROM PUBLISHER WHERE PUBLISHER.PUBLISHER_NAME = BOOK.PUBLISHER);
ALTER TABLE BOOK DROP COLUMN PUBLISHER;

DELIMITER |
CREATE TRIGGER UPDATE_TOTAL_SPENT
AFTER INSERT ON ORDER_LINE
FOR EACH ROW
BEGIN
	IF NEW.ORDER_ID IS NOT NULL AND (SELECT ORDER_FILLED FROM `ORDER` WHERE ORDER_ID = NEW.ORDER_ID) = 1 THEN
		UPDATE CUSTOMER
		SET TOTAL_SPENT = TOTAL_SPENT + NEW.COST_LINE
        WHERE CUSTOMER.ID = (SELECT CUSTOMER_ID 
										FROM `ORDER`
										WHERE NEW.ORDER_ID = `ORDER`.ORDER_ID);
	END IF;
END |

DELIMITER ;

DROP TRIGGER UPDATE_TOTAL_SPENT;

INSERT INTO `ORDER` VALUES (14, 1, '2023-02-20', 0);
INSERT INTO ORDER_LINE VALUES (17, 1234567890, 14, 100, 100, 1);
INSERT INTO ORDER_LINE VALUES (18, 1234567890, 14, 100, 100, 1);
INSERT INTO ORDER_LINE VALUES (19, 1234567890, 14, 100, 100, 1);
DELETE FROM ORDER_LINE WHERE ID = 17;

CALL UPDATE_CUSTOMER_SPENT;

SELECT * FROM `ORDER`;
SELECT * FROM ORDER_LINE; 
SELECT * FROM CUSTOMER;
SELECT * FROM BOOK;

DELIMITER |
-- UPDATE CUSTOMER SPENT WHEN ORDER IS FILLED (PAID)
CREATE TRIGGER UPDATE_TOTAL_SPENT2
AFTER UPDATE ON `ORDER`
FOR EACH ROW
BEGIN
	IF OLD.ORDER_FILLED = 0 AND NEW.ORDER_FILLED = 1 THEN
		UPDATE CUSTOMER
		SET TOTAL_SPENT = TOTAL_SPENT + (SELECT SUM(COST_LINE)
											FROM ORDER_LINE
											WHERE NEW.ORDER_ID = ORDER_LINE.ORDER_ID)
		WHERE NEW.ORDER_FILLED = 1 AND NEW.CUSTOMER_ID = CUSTOMER.ID; 
	END IF;
END |

DELIMITER ;

UPDATE `ORDER` SET ORDER_FILLED = 1 WHERE ORDER_ID = 12;

-- Trigger for delete
-- Subtract book quantity from stocks when order is filled/delivered
SELECT * FROM CUSTOMER;

DELIMITER |
CREATE TRIGGER DEL_ORDER
BEFORE DELETE ON ORDER_LINE
FOR EACH ROW
BEGIN
	IF (SELECT COUNT(*) FROM ORDER_LINE WHERE ORDER_ID = OLD.ORDER_ID) = 1 THEN
		DELETE FROM `ORDER`
		WHERE `ORDER`.ORDER_ID = OLD.ORDER_ID;
	END IF;
END |

DELIMITER ;


DROP TRIGGER DEL_ORDER;

INSERT INTO `ORDER` VALUES (13, 3, '2023-02-25', 0);
INSERT INTO `ORDER_LINE` VALUES
	(16, 1234567896, 13, 500, 500, 1),
    (17, 1234567891, 13, 100, 100, 1);
        
DELETE FROM ORDER_LINE WHERE ID = 17;

use bookin;

Create table user
(
	username varchar (25) not null primary key,
    password varchar(126)
);

insert into user values ('menchie', md5('menchie'));

-- alter table `user` add column id 

describe `order`;

SELECT default_character_set_name FROM information_schema.SCHEMATA 
WHERE schema_name = "bookin";

SELECT CCSA.character_set_name FROM information_schema.`TABLES` T,
       information_schema.`COLLATION_CHARACTER_SET_APPLICABILITY` CCSA
WHERE CCSA.collation_name = T.table_collation
  AND T.table_schema = "bookin"
  AND T.table_name = "book";

SELECT character_set_name FROM information_schema.`COLUMNS` 
WHERE table_schema = "bookin"
  AND table_name = "book"
  AND column_name = "isbn";

use bookin;
select * into outfile
'C:/ProgramData/MySQL/MySQL Server 8.0/Uploads/export.csv'
fields terminated by ',' lines terminated by '\r\n' from book;

select * from `order_line`;

select * from `order`;
describe `order`;
select md5("user3");