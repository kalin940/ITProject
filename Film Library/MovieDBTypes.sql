CREATE TABLE MovieDBTypes
(
	[IDMovie] INT NOT NULL, 
    CONSTRAINT [IDMovie] FOREIGN KEY ([IDMovie]) REFERENCES [Movies]([IDMovie]) 
)
