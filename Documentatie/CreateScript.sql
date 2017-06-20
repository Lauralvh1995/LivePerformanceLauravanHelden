CREATE TABLE Partij(
ID int PRIMARY KEY,
Naam nvarchar(255) NOT NULL,
Lijsttrekker nvarchar(255) NOT NULL,
AantalLeden int
)

CREATE TABLE Coalitie(
ID int PRIMARY KEY,
Naam nvarchar(255) NOT NULL,
Premier nvarchar(255) NOT NULL,
Zetels int NOT NULL
)

CREATE TABLE CoalitiePartij(
CoalitieID int FOREIGN KEY REFERENCES Coalitie(ID),
PartijID int FOREIGN KEY REFERENCES Partij(ID),

CONSTRAINT PK_CoalitiePartij PRIMARY KEY(CoalitieID, PartijID)
)

CREATE TABLE Verkiezing(
ID int PRIMARY KEY,
Naam nvarchar(255) NOT NULL,
AantalZetels int NOT NULL,
MeerderheidBij int,
)

CREATE TABLE Uitslag(
ID int PRIMARY KEY,
VerkiezingID int FOREIGN KEY REFERENCES Verkiezing(ID),
Naam nvarchar(255),
TotaalStemmen int
)

CREATE TABLE PartijUitslag(
UitslagID int FOREIGN KEY REFERENCES Uitslag(ID),
PartijID int FOREIGN KEY REFERENCES Partij(ID),
Stemmen int,
Zetels int,
)