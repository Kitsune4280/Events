
----insert into any table
--create procedure [dbo].[SP_InsertRecord]
--	@P_tableName nvarchar(50) = null,
--	@P_columnString nvarchar(max) = null,
--	@P_propertiesString nvarchar(max) = null

--as
--begin
--	set nocount on;
--	declare @V_tabe nvarchar(50)  = null
--	if(@P_tableName is not null)
--		select @V_tabe = QUOTENAME( TABLE_NAME )
--		from INFORMATION_SCHEMA.TABLES
--		where TABLE_NAME = @P_tableName

--	declare @V_sql as nvarchar(max) = null
--	if(@V_tabe is not null and @P_columnString is not null and @P_propertiesString is not null)
--		select @V_sql = 'insert into ' + @V_tabe + ' ( ' + @P_columnString + ' ) values ( ' + @P_propertiesString + ' );
--		select cast(SCOPE_IDENTITY() as int);'

--	if(@V_sql is not null)
--		exec(@V_sql)
--	else
--		select -1;
--end
	
----delete from any table
--create procedure [dbo].[SP_DeleteRecord]
--	@P_tableName nvarchar(50) = null,
--	@P_Id int = null
--as
--begin
--	set nocount on;

--	declare @V_table nvarchar(50) = null
--	if(@P_tableName is not null)
--		select @V_table = QUOTENAME( TABLE_NAME )
--		from INFORMATION_SCHEMA.TABLES
--		where TABLE_NAME = @P_tableName

--	declare @V_sql as nvarchar(max) = null
--	if(@V_table is not null and @P_Id is not null)
--		select @V_sql = 'delete from ' + @V_table + ' where Id = ' + @P_Id + '; select 1;'

--		if(@V_sql is not null)
--			exec(@V_sql)
--		else
--			select -1;
--end

----get record by id from any table
--create procedure [dbo].[SP_GetRecordById]
--	@P_tableName nvarchar(50) = null,
--	@P_Id int = null

--as
--begin
--	set nocount on;

--	declare @V_table nvarchar(50) = null
--	if(@P_tableName is not null)
--		select @V_table = QUOTENAME( TABLE_NAME )
--		from INFORMATION_SCHEMA.TABLES
--		where TABLE_NAME = @P_tableName

--		declare @V_sql as nvarchar(max) = null
--		if(@V_table is not null and @P_Id is not null)
--			select @V_sql = 'select from table ' + @V_table + ' where Id = ' + @P_Id + ';'

--		if(@V_sql is not null)
--			exec(@V_sql)
--		else
--			select -1;
--end

--get all records from table
create procedure [dbo].[SP_GetAllRecords]
	@P_tableName nvarchar(50) null

as
begin
	set nocount on;

	declare @V_table nvarchar(50) = null
	if(@P_tableName is not null)
		select @V_table = QUOTENAME( TABLE_NAME )
		from INFORMATION_SCHEMA.TABLES
		where TABLE_NAME = @P_tableName

	declare @V_sql as nvarchar(max) = null
	if(@V_table is not null)
		select @V_sql = 'select * from ' + @V_table + ';'

	if(@V_sql is not null)
		exec(@V_sql)
	else
		select -1;
end