CREATE TABLE Movies
(
	[IDMovie] INT NOT NULL PRIMARY KEY, 
    [MovieName] VARCHAR(50) NULL, 
    [Director] VARCHAR(50) NULL, 
    [ReleasedDate] DATETIME NULL, 
    [Country] VARCHAR(50) NULL, 
    [Poster] IMAGE NULL
)
