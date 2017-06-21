CREATE FUNCTION TotaalAantalStemmen(@resultID int)
RETURNS int
AS
BEGIN;
DECLARE @totalVotes AS int;
DECLARE @tempVotes AS int;
DECLARE @cursor AS CURSOR;
 SET @cursor = CURSOR FOR
 SELECT PartijUitslag.Stemmen
 FROM Uitslag JOIN PartijUitslag ON Uitslag.ID = PartijUitslag.UitslagID
 WHERE Uitslag.ID = @resultID;
 OPEN @cursor;
 FETCH NEXT FROM @cursor INTO @tempVotes;
 WHILE @@FETCH_STATUS = 0
 BEGIN
	SET @totalVotes = @totalVotes + @tempVotes;
 FETCH NEXT FROM @cursor INTO @tempVotes;
 END;
 CLOSE @cursor;
 DEALLOCATE @cursor;
 RETURN @totalVotes;
END;
GO

CREATE PROCEDURE VoerPartijToeAanCoalitie(
@coalitienaam  nvarchar,
@partijnaam  nvarchar)
AS
BEGIN
DECLARE @coalitieID AS int;
DECLARE @partijID AS int;
	SET @coalitieID = (SELECT Coalitie.ID
						FROM Coalitie
						WHERE Coalitie.Naam = @coalitienaam);
	SET @partijID =(SELECT @partijID
					FROM Partij
					WHERE Partij.Naam = @partijnaam);
	INSERT INTO CoalitiePartij (CoalitieID, PartijID) VALUES (@coalitieID, @partijID);
END;

CREATE PROCEDURE VerwijderPartijUitCoalitie(
@coalitienaam  nvarchar,
@partijnaam  nvarchar)
AS
BEGIN
DECLARE @coalitieID AS int;
DECLARE @partijID AS int;
	SET @coalitieID = (SELECT Coalitie.ID
						FROM Coalitie
						WHERE Coalitie.Naam = @coalitienaam);
	SET @partijID =(SELECT @partijID
					FROM Partij
					WHERE Partij.Naam = @partijnaam);
	DELETE FROM CoalitiePartij WHERE CoalitieID = @coalitieID AND PartijID = @partijID;
END;