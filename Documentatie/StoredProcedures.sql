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

CREATE PROCEDURE BerekenAantalZetels