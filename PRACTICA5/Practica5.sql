USE libraryDB
GO

INSERT INTO Books
VALUES ('El principito', 'Antoine de Saint-Exepery',1999),
	   ('Bajo la misma estrella', 'John Green',1943),
	   ('Eso', 'Stephen King',1986),
	   ('El alquimista', 'Paulo Coelho',1988)
GO

SELECT * FROM Books WHERE PublishedYear = 1988
GO

SELECT * FROM Books

UPDATE Books
SET Title = 'Coraline', Author = 'Anonimo'
WHERE BookID = 1


DELETE FROM Books WHERE BookID = 2
GO



/*OTRA TABLA Members*/

INSERT INTO Members VALUES ('Orlando Zuniga', '2024-09-11', 'orlzuzu@gmailcom'),
						   ('None Non', '2024-09-11', 'lolzu@gmail.com'),
						   ('Nonmius KU', '2024-09-11', 'paidu@gmail.com'),
						   ('Gatyum Ku', '2024-09-11', 'probeta@gmail.com'),
						   ('Dudu Zuzu', '2024-09-11', 'practica@gmail.com')
Go

SELECT * FROM Members
GO
UPDATE Members SET FullName = 'Tanjiro Kamado' WHERE MemberID = 1
GO
DELETE FROM Members WHERE MemberID = 3
GO




/*OTRA TABLA Loans*/
INSERT INTO Loans
VALUES ('2024-09-11', 3, 2)
GO

SELECT * FROM Loans
GO

UPDATE Loans SET BookID = 4 WHERE LoanID = 2
GO

SELECT * FROM Books