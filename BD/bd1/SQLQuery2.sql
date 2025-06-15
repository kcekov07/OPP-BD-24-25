USE Diablo
GO
ALTER DATABASE Diablo SET  READ_WRITE 
GO


SELECT i.Name,ity.Name AS 'Item Type', Price, st.Strength, st.Defence, Mind, st.Speed, st.Luck FROM Items AS i

LEFT OUTER JOIN [Statistics] AS st

ON i.StatisticId = st.Id

LEFT OUTER JOIN ItemTypes AS ity
ON i.ItemTypeId = ity.Id

ORDER BY -st.Strength, -st.Defence, -st.Mind, -st.Speed, -st.Luck



--Excersise 1.
SELECT i.Name AS 'ItemName', CONCAT (u.FirstName, u.LastName) AS 'UserName', i.Name 'ItemName',s.Strength, s.Defence, s.Mind, s.Speed, s.Luck FROM Items AS i

INNER JOIN UserGameItems AS ugi
ON i.Id=ugi.ItemId

INNER JOIN UsersGames AS ug
ON ugi.UserGameId=ug.Id

INNER JOIN Users AS u
ON ug.UserId=u.Id

INNER JOIN [Statistics] AS s
ON i.StatisticId=s.Id

WHERE u.Id=13
ORDER BY s.Strength DESC
--Excersise 2.

SELECT TOP 1 us.FirstName,us.LastName
FROM Users us

LEFT OUTER JOIN UsersGames AS ugk
ON us.Id = ugk.UserId

LEFT OUTER JOIN UserGameItems AS uga
ON ugk.Id = uga.UserGameId

LEFT OUTER JOIN Items as it
ON uga.ItemId = it.Id

LEFT OUTER JOIN [Statistics] AS st
ON it.StatisticId = st.Id

ORDER BY  -st.Strength, -st.Defence,Username

--Excersise 3.



SELECT us.Username, i.Name, st.Luck

FROM Users us

INNER JOIN UsersGames AS ug
ON us.Id = ug.UserId

INNER JOIN Games AS ga
ON ug.GameId=ga.Id

INNER JOIN GameTypes AS gt
ON ga.Id=gt.Id

INNER JOIN GameTypeForbiddenItems AS gtfi
ON gt.Id=gtfi.ItemId


INNER JOIN Items AS i
ON gtfi.ItemId=i.Id

INNER JOIN[Statistics] AS st
ON i.StatisticId = st.Id
ORDER BY -st.Luck









--Excersise 4.


SELECT i.Name AS 'ItemName', CONCAT (u.FirstName, u.LastName) AS 'UserName', i.Name 'ItemName',s.Strength, s.Defence, s.Mind, s.Speed, s.Luck FROM Items AS i

LEFT OUTER JOIN UserGameItems AS ugi
ON i.Id=ugi.ItemId

INNER JOIN UsersGames AS ug
ON ugi.UserGameId=ug.Id

INNER JOIN Users AS u
ON ug.UserId=u.Id

INNER JOIN [Statistics] AS s
ON i.StatisticId=s.Id

WHERE u.Id=null
ORDER BY s.Strength DESC



--Excersise 5.

SELECT * FROM Games

ORDER BY  Duration DESC, [START]


