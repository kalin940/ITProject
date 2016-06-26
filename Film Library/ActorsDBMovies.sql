CREATE TABLE ActorsDBMovies
(
	[IdMovie] INT NOT NULL, 
    [IDActor] INT NOT NULL, 
    FOREIGN KEY ([IdMovie]) REFERENCES [Movies]([IDMovie]), 
    CONSTRAINT [IDActor] FOREIGN KEY ([IDActor]) REFERENCES [Actors]([IDActor]) 
)
