USE master
GO

DROP DATABASE IF EXISTS Links
GO

CREATE DATABASE Links
GO

USE Links
GO

CREATE TABLE VideoLinks
(
	 LinkId		tinyint			PRIMARY KEY IDENTITY
	,URL		varchar(1000)	NOT NULL UNIQUE	
	,Title		varchar(1000)	NOT NULL
)

INSERT INTO VideoLinks ( Title, URL)
		VALUES('Revenge', 'https://www.youtube.com/watch?v=cPJUBQd-PNM')