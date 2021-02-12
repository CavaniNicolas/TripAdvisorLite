-- Create Userr table
CREATE TABLE Userr
(
    UserId INT IDENTITY PRIMARY KEY,
    Username NVARCHAR(128) NOT NULL
)

-- Create Service table
CREATE TABLE Service
(
    ServiceId INT IDENTITY PRIMARY KEY,
    Adress NVARCHAR(128) NOT NULL,
	Name NVARCHAR(128) NOT NULL
)

-- Create Review table
CREATE TABLE Review
(
    ReviewId INT IDENTITY PRIMARY KEY,
	UserId INT REFERENCES User (UserId) NOT NULL,
	ServiceId INT REFERENCES Service (ServiceId) NOT NULL,
	Note INT NOT NULL,
	Text NVARCHAR(128),
	Date NVARCHAR(128)
)
