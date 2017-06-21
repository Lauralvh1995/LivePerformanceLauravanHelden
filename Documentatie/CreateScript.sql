USE dbi337797;

DROP TABLE PartijUitslag;
DROP TABLE CoalitiePartij;
DROP TABLE Partij;
DROP TABLE Coalitie;
DROP TABLE Uitslag;
DROP TABLE Verkiezing;


CREATE TABLE Partij(
ID int PRIMARY KEY IDENTITY(1,1),
Naam nvarchar(255) NOT NULL,
Lijsttrekker nvarchar(255) NOT NULL,
AantalLeden int
)

CREATE TABLE Coalitie(
ID int PRIMARY KEY IDENTITY(1,1),
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
ID int PRIMARY KEY IDENTITY(1,1),
Naam nvarchar(255) NOT NULL,
AantalZetels int NOT NULL,
MeerderheidBij int,
)

CREATE TABLE Uitslag(
ID int PRIMARY KEY IDENTITY(1,1),
VerkiezingID int FOREIGN KEY REFERENCES Verkiezing(ID),
Naam nvarchar(255),
TotaalStemmen int
)

CREATE TABLE PartijUitslag(
UitslagID int FOREIGN KEY REFERENCES Uitslag(ID),
PartijID int FOREIGN KEY REFERENCES Partij(ID),
Stemmen int,
Zetels int,

CONSTRAINT PK_CoalitiePartij PRIMARY KEY(UitslagID, PartijID)
)


INSERT INTO Partij (Naam, Lijsttrekker, AantalLeden) VALUES ('VVD','Mark Rutte',31241);
INSERT INTO Partij (Naam, Lijsttrekker, AantalLeden) VALUES ('PVV','Geert Wilders',31241);
INSERT INTO Partij (Naam, Lijsttrekker, AantalLeden) VALUES ('CDA','Sybrand van Haersma Buma',31241);
INSERT INTO Partij (Naam, Lijsttrekker, AantalLeden) VALUES ('D66','Alexander Pechtold',31241);
INSERT INTO Partij (Naam, Lijsttrekker, AantalLeden) VALUES ('GL','Jesse Klaver',31241);
INSERT INTO Partij (Naam, Lijsttrekker, AantalLeden) VALUES ('SP','Emile Roemer',31241);
INSERT INTO Partij (Naam, Lijsttrekker, AantalLeden) VALUES ('PvdA','Lodewijk Asscher',31241);
INSERT INTO Partij (Naam, Lijsttrekker, AantalLeden) VALUES ('CU','Gert-Jan Segers',31241);
INSERT INTO Partij (Naam, Lijsttrekker, AantalLeden) VALUES ('PvdD','Marianne Thieme',31241);
INSERT INTO Partij (Naam, Lijsttrekker, AantalLeden) VALUES ('50Plus','Henk Krol',31241);
INSERT INTO Partij (Naam, Lijsttrekker, AantalLeden) VALUES ('SGP','Kees van der Staaj',31241);
INSERT INTO Partij (Naam, Lijsttrekker, AantalLeden) VALUES ('DENK','Tunahan Kuzu',31241);
INSERT INTO Partij (Naam, Lijsttrekker, AantalLeden) VALUES ('FvD','Thierry Baudet',31241);

INSERT INTO Verkiezing (Naam, AantalZetels) VALUES ('Tweede Kamerverkiezing 2017', 150);

INSERT INTO Uitslag (VerkiezingID, Naam) VALUES (1, 'Uitslag Tweede Kamerverkiezing 2017');

INSERT INTO PartijUitslag (UitslagID, PartijID, Stemmen, Zetels) VALUES (1, 1, 2238351, 33);
INSERT INTO PartijUitslag (UitslagID, PartijID, Stemmen, Zetels) VALUES (1, 2, 1372941, 20);
INSERT INTO PartijUitslag (UitslagID, PartijID, Stemmen, Zetels) VALUES (1, 3, 1301796, 19);
INSERT INTO PartijUitslag (UitslagID, PartijID, Stemmen, Zetels) VALUES (1, 4, 1285819, 19);
INSERT INTO PartijUitslag (UitslagID, PartijID, Stemmen, Zetels) VALUES (1, 5, 959600, 14);
INSERT INTO PartijUitslag (UitslagID, PartijID, Stemmen, Zetels) VALUES (1, 6, 955633, 14);
INSERT INTO PartijUitslag (UitslagID, PartijID, Stemmen, Zetels) VALUES (1, 7, 599699, 9);
INSERT INTO PartijUitslag (UitslagID, PartijID, Stemmen, Zetels) VALUES (1, 8, 356271, 5);
INSERT INTO PartijUitslag (UitslagID, PartijID, Stemmen, Zetels) VALUES (1, 9, 335214, 5);
INSERT INTO PartijUitslag (UitslagID, PartijID, Stemmen, Zetels) VALUES (1, 10, 327131, 4);
INSERT INTO PartijUitslag (UitslagID, PartijID, Stemmen, Zetels) VALUES (1, 11, 218950, 3);
INSERT INTO PartijUitslag (UitslagID, PartijID, Stemmen, Zetels) VALUES (1, 12, 216147, 3);
INSERT INTO PartijUitslag (UitslagID, PartijID, Stemmen, Zetels) VALUES (1, 13, 187162, 2);
