USE Computers
GO

CREATE PROC usp_GetComputersWithRamBetween(@minMemory nvarchar(50), @maxMemory nvarchar(50))
AS
  SELECT c.Vendor, c.Model, c.Id
   FROM Computers c
   WHERE c.Memory BETWEEN CAST(LEFT(@minMemory, 2) AS int) AND CAST(LEFT(@maxMemory, 2) AS int)
GO

EXEC usp_GetComputersWithRamBetween '1 GB', '15 GB'
GO

CREATE PROC usp_GetComputersWithGpuAndRamBetween(@gpuId int, @minMemory nvarchar(50), @maxMemory nvarchar(50))
AS
  SELECT *
   FROM Computers c
   JOIN ComputersGpus cg ON cg.ComputerId = c.Id
   JOIN Gpus g ON g.Id = cg.GpuId
   WHERE (c.Memory BETWEEN CAST(LEFT(@minMemory, 2) AS int) AND CAST(LEFT(@maxMemory, 2) AS int)) AND g.Id = @gpuId
GO

EXEC usp_GetComputersWithGpuAndRamBetween 2, '1 GB', '15 GB'
GO

CREATE PROC usp_GetGpusForComputerType(@computerType nvarchar(50))
AS
  SELECT *
   FROM Gpus g
   JOIN ComputersGpus cg ON g.Id = cg.GpuId
   JOIN Computers c ON c.Id = cg.ComputerId
   WHERE c.Type = @computerType
GO

EXEC usp_GetGpusForComputerType 'Notebook'
GO