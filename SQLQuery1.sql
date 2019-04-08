BULK
INSERT [dbo].[Emission]
FROM 'C:\Users\Administrator\Desktop\Test190demo\NPI2.csv'
WITH
(
FirstRow = 2,
FIELDTERMINATOR = ',',
ROWTERMINATOR = '\n'
)

--drop table [dbo].[Emission]
