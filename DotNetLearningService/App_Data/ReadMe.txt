Entity Framework Migration Commands:
From Package Manager Console
	to Enable Migrations :  enable-migrations
	to Add Migrations :		add-migration InitialCreate (here, InitialCreate is the name of migration)
	to Update Migrations:	update-database


-- Delete data from table
DELETE FROM technologytype

-- Reset PK identity to zero, so that the insertion after 
--the delete operation will start from 1
DBCC CHECKIDENT (technologytype,RESEED, 0)