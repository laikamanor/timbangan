USE [master]
GO
/****** Object:  Database [abc_formula]    Script Date: 05/19/2020 10:45:12 AM ******/
CREATE DATABASE [abc_formula]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'abc_formula', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\abc_formula.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'abc_formula_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\abc_formula_log.ldf' , SIZE = 3840KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [abc_formula] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [abc_formula].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [abc_formula] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [abc_formula] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [abc_formula] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [abc_formula] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [abc_formula] SET ARITHABORT OFF 
GO
ALTER DATABASE [abc_formula] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [abc_formula] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [abc_formula] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [abc_formula] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [abc_formula] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [abc_formula] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [abc_formula] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [abc_formula] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [abc_formula] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [abc_formula] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [abc_formula] SET  DISABLE_BROKER 
GO
ALTER DATABASE [abc_formula] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [abc_formula] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [abc_formula] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [abc_formula] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [abc_formula] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [abc_formula] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [abc_formula] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [abc_formula] SET RECOVERY FULL 
GO
ALTER DATABASE [abc_formula] SET  MULTI_USER 
GO
ALTER DATABASE [abc_formula] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [abc_formula] SET DB_CHAINING OFF 
GO
ALTER DATABASE [abc_formula] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [abc_formula] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
EXEC sys.sp_db_vardecimal_storage_format N'abc_formula', N'ON'
GO
USE [abc_formula]
GO
/****** Object:  StoredProcedure [dbo].[createModuleAccess]    Script Date: 05/19/2020 10:45:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[createModuleAccess]
@userid int
AS
BEGIN
BEGIN TRY
BEGIN TRANSACTION
INSERT INTO modules(module,description,userid,datecreated,status)
VALUES ('Access','To Allow User to Block and Unblock Modules',@userid,(SELECT GETDATE()),1)
INSERT INTO access(moduleid,workgroupid,datecreated,dateactive,status)
VALUES ((SELECT moduleid FROM modules WHERE module='Access'), (SELECT workgroup_id FROM users WHERE userid=@userid),
(SELECT GETDATE()),(SELECT GETDATE()),1)

INSERT INTO modules(module,description,userid,datecreated,status)
VALUES ('Modules','Modules',@userid,(SELECT GETDATE()),1)
INSERT INTO access(moduleid,workgroupid,datecreated,dateactive,status)
VALUES ((SELECT moduleid FROM modules WHERE module='Modules'), (SELECT workgroup_id FROM users WHERE userid=@userid),
(SELECT GETDATE()),(SELECT GETDATE()),1)

INSERT INTO modules(module,description,userid,datecreated,status)
VALUES ('Add New','Add New',@userid,(SELECT GETDATE()),1)
INSERT INTO access(moduleid,workgroupid,datecreated,dateactive,status)
VALUES ((SELECT moduleid FROM modules WHERE module='Add New'), (SELECT workgroup_id FROM users WHERE userid=@userid),
(SELECT GETDATE()),(SELECT GETDATE()),1)

INSERT INTO modules(module,description,userid,datecreated,status)
VALUES ('Edit','Edit',@userid,(SELECT GETDATE()),1)
INSERT INTO access(moduleid,workgroupid,datecreated,dateactive,status)
VALUES ((SELECT moduleid FROM modules WHERE module='Edit'), (SELECT workgroup_id FROM users WHERE userid=@userid),
(SELECT GETDATE()),(SELECT GETDATE()),1)
COMMIT TRANSACTION
END TRY
BEGIN CATCH
ROLLBACK TRANSACTION
END CATCH
END

GO
/****** Object:  StoredProcedure [dbo].[insertCategory]    Script Date: 05/19/2020 10:45:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[insertCategory]
@createdby int,
@catname varchar(255),
@status int
AS
BEGIN
BEGIN TRY
BEGIN TRANSACTION
INSERT INTO categories (category,status,datecreated,userid) VALUES (@catname,@status,(SELECT GETDATE()),@createdby)
COMMIT TRANSACTION
END TRY
BEGIN CATCH
ROLLBACK TRANSACTION
END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[insertFormula]    Script Date: 05/19/2020 10:45:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[insertFormula]
@formnum varchar(255),
@product varchar(255),
@price float,
@basewt float,
@tdw float,
@unbaked float,
@baked float,
@yield float,
@userid int
AS BEGIN
INSERT INTO formulas (formula_number,productid,price,basewt,tdw,unbaked,baked,yield,userid,datecreated,status)
VALUES (@formnum,(SELECT productid FROM products WHERE product=@product),@price,@basewt,@tdw,@unbaked,@baked,@yield,@userid,
(SELECT GETDATE()),1)
END
GO
/****** Object:  StoredProcedure [dbo].[insertFormulaItems]    Script Date: 05/19/2020 10:45:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[insertFormulaItems]
@item varchar(255),
@value float,
@userid int
AS BEGIN
INSERT INTO formula_items (formulaid,itemid,value,userid,datecreated,status)
VALUES ((SELECT TOP 1 formulaid FROM formulas ORDER BY formulaid DESC),(SELECT itemid FROM items WHERE itemname=@item),
@value,@userid,(SELECT GETDATE()),1)
END
GO
/****** Object:  StoredProcedure [dbo].[insertFormulaPalaman]    Script Date: 05/19/2020 10:45:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[insertFormulaPalaman]
@palaman varchar(255),
@item varchar(255),
@value float,
@userid float
AS BEGIN
INSERT INTO formula_palaman_items (formula_itemid,formulaid,itemid,value,userid,datecreated,userid_modified,datemodified,status)
VALUES ((SELECT itemid FROM items WHERE itemname=@palaman),(SELECT TOP 1 formulaid FROM formulas ORDER BY formulaid DESC),(SELECT itemid FROM items WHERE itemname=@item),@value,
@userid,(SELECT GETDATE()),@userid,(SELECT GETDATE()),1)
END
GO
/****** Object:  StoredProcedure [dbo].[insertItem]    Script Date: 05/19/2020 10:45:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[insertItem]
@catid int,
@itemname varchar(255),
@description varchar(255),
@uom varchar(255),
@status int
AS
BEGIN
BEGIN TRY
BEGIN TRANSACTION
INSERT into items (catid,itemname,description,uom,datecreated,userid,status)
VALUES (@catid,@itemname,@description,@uom,(SELECT GETDATE()), 1,@status)
COMMIT TRANSACTION
END TRY
BEGIN CATCH
ROLLBACK TRANSACTION
END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[insertModule]    Script Date: 05/19/2020 10:45:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[insertModule]
@module varchar(255),
@description varchar(255),
@userid int,
@status int
AS
BEGIN
BEGIN TRY
BEGIN TRANSACTION
INSERT INTO modules (module,description,userid,status,datecreated)
VALUES (@module,@description,@userid,@status,(SELECT GETDATE()))
COMMIT TRANSACTION
END TRY
BEGIN CATCH
ROLLBACK TRANSACTION
END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[insertProduct]    Script Date: 05/19/2020 10:45:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[insertProduct]
@category varchar(255),
@product varchar(255),
@description varchar(255),
@userid int,
@status int
AS BEGIN
BEGIN TRY
BEGIN TRANSACTION
INSERT INTO products (catid,product,description,status,userid,datecreated)
VALUES ((SELECT catid FROM categories WHERE category=@category),@product,@description,@status,@userid,(SELECT GETDATE()))
COMMIT TRANSACTION
END TRY
BEGIN CATCH
ROLLBACK TRANSACTION
END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[insertStep1]    Script Date: 05/19/2020 10:45:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[insertStep1]
@step1num varchar(255),
@formulaid int,
@quantity float,
@basewt float,
@userid int,
@status int,
@product varchar(255)
AS
BEGIN
INSERT INTO step1 (step1num,formulaid,productid,quantity,basewt,userid,datecreated,status) VALUES
(@step1num,@formulaid,(SELECT productid FROM products WHERE product=@product),
@quantity,@basewt,@userid,(SELECT GETDATE()),@status)
END
GO
/****** Object:  StoredProcedure [dbo].[insertStep1Item]    Script Date: 05/19/2020 10:45:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[insertStep1Item]
@itemid int,
@value float,
@actual float,
@userid int,
@status int,
@formula_itemid int
AS BEGIN
INSERT INTO step1_items (formula_itemid,itemid,step1id,value,actual,userid,datecreated,status)
VALUES (@formula_itemid,@itemid,(SELECT TOP 1 step1id FROM step1 ORDER BY step1id DESC),@value,
@actual,@userid,(SELECT GETDATE()),@status)
END
GO
/****** Object:  StoredProcedure [dbo].[insertStep1Palaman]    Script Date: 05/19/2020 10:45:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[insertStep1Palaman]
@itemid int,
@value int,
@actual int,
@userid int,
@status int,
@formula_itemid int
AS BEGIN
INSERT INTO step1_palaman (formula_itemid,itemid,step1id,value,actual,userid,datecreated,status)
VALUES (@formula_itemid,@itemid,(SELECT ISNULL(MAX(step1id),1) FROM step1),@value,
@actual,@userid,(SELECT GETDATE()),@status)
END	
GO
/****** Object:  StoredProcedure [dbo].[insertStep2]    Script Date: 05/19/2020 10:45:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[insertStep2]
@step2num varchar(255),
@step1id int,
@formulaid int,
@product varchar(255),
@quantity float,
@userid int,
@status int
AS BEGIN
INSERT INTO step2 (step2num,step1id,formulaid,productid,quantity,userid,datecreated,status)
VALUES (@step2num,@step1id,@formulaid,(SELECT productid FROM products WHERE product=@product),
@quantity,@userid,(SELECT GETDATE()),@status)
END
GO
/****** Object:  StoredProcedure [dbo].[insertStep2Item]    Script Date: 05/19/2020 10:45:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[insertStep2Item]
@step1_itemid int,
@formula_itemid int,
@itemid int,
@value float,
@actual float,
@userid int,
@status int
AS BEGIN
INSERT INTO step2_items(step2id,step1_itemid,formula_itemid,itemid,value,actual,userid,datecreated,status)
VALUES ((SELECT TOP 1 step2id FROM step2 ORDER BY step2id DESC),@step1_itemid,@formula_itemid,@itemid,
@value,@actual,@userid,(SELECT GETDATE()),@status)
END
GO
/****** Object:  StoredProcedure [dbo].[insertStep3]    Script Date: 05/19/2020 10:45:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[insertStep3]
@step3num varchar(255),
@step1id int,
@formulaid int,
@product varchar(255),
@tdw float,
@quantity float,
@userid int,
@status int
AS BEGIN
INSERT INTO step3 (step3num,step1id,formulaid,productid,tdw,quantity,userid,datecreated,status)
VALUES (@step3num,@step1id,@formulaid,(SELECT productid FROM products WHERE product=@product),
@tdw,@quantity,@userid,(SELECT GETDATE()),@status)
END



GO
/****** Object:  StoredProcedure [dbo].[insertUser]    Script Date: 05/19/2020 10:45:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[insertUser]
@username varchar(255),
@workgroup varchar(255),
@fullname varchar(255),
@password varchar(255),
@status int,
@userid int
AS 
BEGIN
BEGIN TRY
BEGIN TRANSACTION
INSERT INTO users(username,password,fullname,workgroup_id,createdby,datecreated,modifiedby,
datemodified,status) VALUES (@username,@password,@fullname,(SELECT workgroupid FROM workgroups WHERE name=@workgroup),
@userid,(SELECT GETDATE()),@userid,(SELECT GETDATE()),@status)
COMMIT TRANSACTION
END TRY
BEGIN CATCH
ROLLBACK TRANSACTION
END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[insertUserIcon]    Script Date: 05/19/2020 10:45:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[insertUserIcon]
@userid int,
@img image
AS BEGIN
BEGIN TRY
BEGIN TRANSACTION
INSERT INTO users_icon (userid,picture,date_uploaded) VALUES (@userid,@img,(SELECT GETDATE()))
COMMIT TRANSACTION
END TRY
BEGIN CATCH
ROLLBACK TRANSACTION
END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[insertWorkgroup]    Script Date: 05/19/2020 10:45:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[insertWorkgroup]
@workgroup varchar(255),
@description varchar(255),
@userid int,
@status int
AS
BEGIN
BEGIN TRY
BEGIN TRANSACTION
INSERT INTO workgroups(name,description,datecreated,userid,status) VALUES (@workgroup,@description,(SELECT GETDATE()),@userid,@status)
if @workgroup='Developer'
BEGIN
INSERT INTO access (moduleid,workgroupid,datecreated,dateactive,status) VALUES
(1,(SELECT workgroupid FROM workgroups WHERE name=@workgroup),(SELECT GETDATE()),(SELECT GETDATE()),1)
END
COMMIT TRANSACTION
END TRY
BEGIN CATCH
ROLLBACK TRANSACTION
END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[loggedIn]    Script Date: 05/19/2020 10:45:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[loggedIn]
@username varchar(255)
AS
BEGIN
BEGIN TRY
BEGIN TRANSACTION
INSERT INTO login_logs (userid,login,logout) values ((SELECT userid FROM users WHERE username=@username),(SELECT GETDATE()),(SELECT GETDATE()))
COMMIT TRANSACTION
END TRY
BEGIN CATCH
ROLLBACK TRANSACTION
END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[loggedOut]    Script Date: 05/19/2020 10:45:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[loggedOut]
@logid INT
AS
BEGIN
BEGIN TRY
BEGIN TRANSACTION
UPDATE login_logs SET logout=(SELECT GETDATE()) WHERE logid=@logid
COMMIT TRANSACTION
END TRY
BEGIN CATCH
ROLLBACK TRANSACTION
END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[updateCategory]    Script Date: 05/19/2020 10:45:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[updateCategory]
@current_category varchar(255),
@category varchar(255),
@status int
AS
BEGIN
BEGIN TRY
BEGIN TRANSACTION
UPDATE categories SET category=@category,status=@status WHERE catid=(SELECT catid FROM categories WHERE category=@current_category)
COMMIT TRANSACTION
END TRY
BEGIN CATCH
ROLLBACK TRANSACTION
END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[updateItem]    Script Date: 05/19/2020 10:45:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[updateItem]
@catid int,
@current_itemname varchar(255),
@itemname varchar(255),
@description varchar(255),
@uom varchar(255),
@status int
AS
BEGIN
BEGIN TRY
BEGIN TRANSACTION
UPDATE items SET catid=@catid,itemname=@itemname,description=@description,uom=@uom,status=@status WHERE
itemid=(SELECT itemid FROM items WHERE itemname=@current_itemname)
COMMIT TRANSACTION
END TRY
BEGIN CATCH
ROLLBACK TRANSACTION
END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[updateModule]    Script Date: 05/19/2020 10:45:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[updateModule]
@current_module varchar(255),
@module varchar(255),
@description varchar(255),
@status int
AS BEGIN
BEGIN TRY
BEGIN TRANSACTION
UPDATE modules SET module=@module,description=@description,status=@status WHERE module=@current_module
COMMIT TRANSACTION
END TRY
BEGIN CATCH
ROLLBACK TRANSACTION
END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[updateProduct]    Script Date: 05/19/2020 10:45:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[updateProduct]
@category varchar(255),
@current_product varchar(255),
@product varchar(255),
@description varchar(255),
@status int
AS BEGIN
BEGIN TRY
BEGIN TRANSACTION
UPDATE products SET catid=(SELECT catid FROM categories WHERE category=@category),product=@product,description=@description,
status=@status WHERE product=@current_product
COMMIT TRANSACTION
END TRY
BEGIN CATCH
ROLLBACK TRANSACTION
END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[updateUser]    Script Date: 05/19/2020 10:45:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[updateUser]
@current_username varchar(255),
@username varchar(255),
@password varchar(255),
@fullname varchar(255),
@workgroup varchar(255),
@status int
AS
BEGIN
BEGIN TRY
BEGIN TRANSACTION
UPDATE users SET username=@username,password=@password,fullname=@fullname,
workgroup_id=(SELECT workgroupid FROM workgroups WHERE name=@workgroup),status=@status
WHERE username=@current_username
COMMIT TRANSACTION
END TRY
BEGIN CATCH
ROLLBACK TRANSACTION
END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[updateUserIcon]    Script Date: 05/19/2020 10:45:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[updateUserIcon]
@userid int,
@img image
AS BEGIN
BEGIN TRY
BEGIN TRANSACTION
UPDATE users_icon SET picture=@img,date_uploaded=(SELECT GETDATE()) WHERE userid=@userid
COMMIT TRANSACTION
END TRY
BEGIN CATCH
ROLLBACK TRANSACTION
END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[updateWorkgroup]    Script Date: 05/19/2020 10:45:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[updateWorkgroup]
@workgroup varchar(255),
@description varchar(255),
@status int,
@workgroupid int
AS
BEGIN
BEGIN TRY
BEGIN TRANSACTION
UPDATE workgroups SET name=@workgroup,description=@description,status=@status WHERE workgroupid=@workgroupid
COMMIT TRANSACTION
END TRY
BEGIN CATCH
ROLLBACK TRANSACTION
END CATCH
END
GO
/****** Object:  UserDefinedFunction [dbo].[checkCategory]    Script Date: 05/19/2020 10:45:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[checkCategory](@category varchar(255))
RETURNS INT
AS
BEGIN
DECLARE @result int
SET @result= (SELECT ISNULL(COUNT(catid),0) FROM categories WHERE category=@category)
IF @result = 1
RETURN 1;
RETURN 0;
END
GO
/****** Object:  UserDefinedFunction [dbo].[checkItem]    Script Date: 05/19/2020 10:45:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[checkItem](@item varchar(255),@category varchar(255))
RETURNS INT
AS
BEGIN
DECLARE @result int
SET @result= (SELECT ISNULL(COUNT(itemid),0) FROM items WHERE itemname=@item AND catid=(SELECT catid FROM categories
WHERE category=@category))
IF @result = 1
RETURN 1;
RETURN 0;
END
GO
/****** Object:  UserDefinedFunction [dbo].[checkModuleAccess]    Script Date: 05/19/2020 10:45:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[checkModuleAccess]()
RETURNS INT
AS
BEGIN
DECLARE @result int
SET @result= (SELECT ISNULL(COUNT(moduleid),0) FROM modules WHERE module='Access')
IF @result = 1
RETURN 1;
RETURN 0;
END
GO
/****** Object:  UserDefinedFunction [dbo].[checkModuleName]    Script Date: 05/19/2020 10:45:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[checkModuleName](@module varchar(255))
RETURNS INT
AS
BEGIN
DECLARE @result int
SET @result= (SELECT ISNULL(COUNT(moduleid),0) FROM modules WHERE module=@module)
IF @result = 1
RETURN 1;
RETURN 0;
END
GO
/****** Object:  UserDefinedFunction [dbo].[checkPassword]    Script Date: 05/19/2020 10:45:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[checkPassword](@username varchar(255),@password varchar(255))
RETURNS INT
AS
BEGIN
DECLARE @result int
SET @result= (SELECT ISNULL(COUNT(userid),0) FROM users WHERE username=@username AND password=@password)
IF @result = 1
RETURN 1;
RETURN 0;
END
GO
/****** Object:  UserDefinedFunction [dbo].[checkProductFormula]    Script Date: 05/19/2020 10:45:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[checkProductFormula](@product varchar(255),@status int)
RETURNS INT
AS
BEGIN
DECLARE @result int
SET @result= (SELECT ISNULL(COUNT(formulaid),0) FROM formulas WHERE productid=(SELECT productid FROM products
WHERE product=@product) AND status=@status)
IF @result = 1
RETURN 1;
RETURN 0;
END
GO
/****** Object:  UserDefinedFunction [dbo].[checkUsernameStatus]    Script Date: 05/19/2020 10:45:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[checkUsernameStatus](@username varchar(255))
RETURNS INT
AS
BEGIN
DECLARE @result int
SET @result= (SELECT ISNULL(COUNT(a.userid),0) FROM users a WHERE a.username=@username AND a.status=1)
IF @result = 1
RETURN 1;
RETURN 0;
END
GO
/****** Object:  UserDefinedFunction [dbo].[checkWorkgroup]    Script Date: 05/19/2020 10:45:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[checkWorkgroup](@workgroup varchar(255))
RETURNS INT
AS
BEGIN
DECLARE @result int
SET @result= (SELECT ISNULL(COUNT(workgroupid),0) FROM workgroups WHERE name=@workgroup)
IF @result = 1
RETURN 1;
RETURN 0;
END
GO
/****** Object:  UserDefinedFunction [dbo].[checkWorkgroupUsername]    Script Date: 05/19/2020 10:45:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[checkWorkgroupUsername](@username varchar(255))
RETURNS INT
AS
BEGIN
DECLARE @result int
SET @result= (SELECT ISNULL(COUNT(a.userid),0) FROM users a INNER JOIN workgroups b ON a.workgroup_id = b.workgroupid 
WHERE a.username=@username AND b.status=1)
IF @result = 1
RETURN 1;
RETURN 0;
END
GO
/****** Object:  UserDefinedFunction [dbo].[funcgetFormulaActiveStatus]    Script Date: 05/19/2020 10:45:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[funcgetFormulaActiveStatus](@itemname varchar(255))
RETURNS INT
AS BEGIN
DECLARE @result float
SET @result= (SELECT ISNULL(a.formulaid,0) FROM formulas a INNER JOIN products b 
ON a.productid = b.productid AND a.status=1 AND b.product='P(1) 10 IN 1 Bigdesal')
RETURN @result;
END
GO
/****** Object:  UserDefinedFunction [dbo].[funcStep1]    Script Date: 05/19/2020 10:45:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[funcStep1](@status int,
@category varchar(255),@product varchar(255),@id int)
RETURNS @result TABLE (formulaid int,step1id int,step1num varchar(255),category varchar(255),
product varchar(255),quantity float,batch float,basewt float)
AS
BEGIN

IF @id !=0
INSERT INTO @result

SELECT a.formulaid,a.step1id,a.step1num,a.category,a.product,a.quantity,x.batch, basewt FROM vStep1 a
OUTER APPLY(
SELECT ISNULL(SUM(b.quantity),0)[batch] FROM step2 b
WHERE a.step1id = b.step1id AND b.status=1
)x
WHERE a.status=@status AND a.step1id=@id
GROUP BY a.basewt,a.category,a.datecreated,a.formulaid,a.product,a.quantity,a.status,a.step1id,a.step1num
,x.batch
HAVING a.quantity > SUM(x.batch)


ELSE IF @category = 'All' OR @category = ''
INSERT INTO @result

SELECT a.formulaid,a.step1id,a.step1num,a.category,a.product,a.quantity,x.batch, basewt FROM vStep1 a
OUTER APPLY(
SELECT ISNULL(SUM(b.quantity),0)[batch] FROM step2 b
WHERE a.step1id = b.step1id AND b.status=1
)x
WHERE a.status=@status AND a.product LIKE '%' + @product + '%'
GROUP BY a.basewt,a.category,a.datecreated,a.formulaid,a.product,a.quantity,a.status,a.step1id,a.step1num
,x.batch
HAVING a.quantity > SUM(x.batch)


ELSE
INSERT INTO @result
SELECT a.formulaid,a.step1id,a.step1num,a.category,a.product,a.quantity,x.batch, basewt FROM vStep1 a
OUTER APPLY(
SELECT ISNULL(SUM(b.quantity),0)[batch] FROM step2 b
WHERE a.step1id = b.step1id AND b.status=1
)x
WHERE a.status=@status AND a.product LIKE '%' + @product + '%' AND a.category=@category
GROUP BY a.basewt,a.category,a.datecreated,a.formulaid,a.product,a.quantity,a.status,a.step1id,a.step1num
,x.batch
HAVING a.quantity > SUM(x.batch)
RETURN;
end
GO
/****** Object:  UserDefinedFunction [dbo].[funcStep2]    Script Date: 05/19/2020 10:45:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[funcStep2](@status int,
@category varchar(255),@product varchar(255),@id int)
RETURNS @result TABLE (formulaid int,step1id int,step1num varchar(255),category varchar(255),
product varchar(255),quantity float,batch float,basewt float)
AS
BEGIN

IF @id !=0
INSERT INTO @result

SELECT a.formulaid,a.step1id,a.step1num,a.category,a.product,a.quantity,x.batch, basewt FROM vStep1 a
OUTER APPLY(
SELECT ISNULL(SUM(b.quantity),0)[batch],b.step3id  FROM step2 b
WHERE a.step1id = b.step1id AND b.status=1
GROUP BY b.step3id
)x

OUTER APPLY (
SELECT COUNT(step3id)[counts] FROM step3 c WHERE c.step3id = x.step3id
)xx

WHERE a.status=@status AND a.step1id=@id
GROUP BY a.basewt,a.category,a.datecreated,a.formulaid,a.product,a.quantity,a.status,a.step1id,a.step1num
,x.batch,xx.counts
HAVING a.quantity <= SUM(x.batch) AND xx.counts <= 0

ELSE IF @category = 'All' OR @category = ''
INSERT INTO @result

SELECT a.formulaid,a.step1id,a.step1num,a.category,a.product,a.quantity,x.batch, basewt FROM vStep1 a
OUTER APPLY(
SELECT ISNULL(SUM(b.quantity),0)[batch],b.step3id FROM step2 b
WHERE a.step1id = b.step1id AND b.status=1
GROUP BY b.step3id
)x

OUTER APPLY (
SELECT COUNT(step3id)[counts] FROM step3 c WHERE c.step3id = x.step3id
)xx

WHERE a.status=@status AND a.product LIKE '%' + @product + '%'
GROUP BY a.basewt,a.category,a.datecreated,a.formulaid,a.product,a.quantity,a.status,a.step1id,a.step1num
,x.batch,xx.counts
HAVING a.quantity <= SUM(x.batch) AND xx.counts <= 0


ELSE
INSERT INTO @result
SELECT a.formulaid,a.step1id,a.step1num,a.category,a.product,a.quantity,x.batch, basewt FROM vStep1 a
OUTER APPLY(
SELECT ISNULL(SUM(b.quantity),0)[batch],b.step3id FROM step2 b
WHERE a.step1id = b.step1id AND b.status=1
GROUP BY b.step3id
)x

OUTER APPLY (
SELECT COUNT(step3id)[counts] FROM step3 c WHERE c.step3id = x.step3id
)xx 

WHERE a.status=@status AND a.product LIKE '%' + @product + '%' AND a.category=@category
GROUP BY a.basewt,a.category,a.datecreated,a.formulaid,a.product,a.quantity,a.status,a.step1id,a.step1num
,x.batch,xx.counts
HAVING a.quantity <= SUM(x.batch) AND xx.counts <= 0
RETURN;
end
GO
/****** Object:  UserDefinedFunction [dbo].[funcSystemDate]    Script Date: 05/19/2020 10:45:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[funcSystemDate]()
RETURNs datetime
AS
BEGIN
DECLARE @result datetime
SET @result= (SELECT GETDATE())
RETURN @result;
end
GO
/****** Object:  UserDefinedFunction [dbo].[returnLogID]    Script Date: 05/19/2020 10:45:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[returnLogID](@username varchar(255))
RETURNS INT
AS
BEGIN
DECLARE @result int
SET @result= (SELECT TOP 1 logid FROM login_logs WHERE userid=(SELECT userid FROM users WHERE username='gords') ORDER BY logid DESC)
RETURN @result
END

GO
/****** Object:  Table [dbo].[access]    Script Date: 05/19/2020 10:45:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[access](
	[accessid] [int] IDENTITY(1,1) NOT NULL,
	[moduleid] [int] NULL,
	[workgroupid] [int] NULL,
	[datecreated] [datetime] NULL,
	[dateactive] [datetime] NULL,
	[datedeactivate] [datetime] NULL,
	[status] [int] NULL,
 CONSTRAINT [PK_access] PRIMARY KEY CLUSTERED 
(
	[accessid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[categories]    Script Date: 05/19/2020 10:45:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[categories](
	[catid] [int] IDENTITY(1,1) NOT NULL,
	[category] [varchar](255) NULL,
	[status] [int] NULL,
	[datecreated] [datetime] NULL,
	[userid] [int] NULL,
 CONSTRAINT [PK_categories] PRIMARY KEY CLUSTERED 
(
	[catid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[formula_items]    Script Date: 05/19/2020 10:45:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[formula_items](
	[formula_itemid] [int] IDENTITY(1,1) NOT NULL,
	[formulaid] [int] NULL,
	[itemid] [int] NULL,
	[value] [float] NULL,
	[userid] [int] NULL,
	[datecreated] [datetime] NULL,
	[userid_modified] [int] NULL,
	[datemodified] [datetime] NULL,
	[status] [int] NULL,
 CONSTRAINT [PK_formula_items] PRIMARY KEY CLUSTERED 
(
	[formula_itemid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[formula_palaman_items]    Script Date: 05/19/2020 10:45:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[formula_palaman_items](
	[formula_palamanid] [int] IDENTITY(1,1) NOT NULL,
	[formula_itemid] [int] NULL,
	[formulaid] [int] NULL,
	[itemid] [int] NULL,
	[value] [float] NULL,
	[userid] [int] NULL,
	[datecreated] [datetime] NULL,
	[userid_modified] [int] NULL,
	[datemodified] [datetime] NULL,
	[status] [nchar](10) NULL,
 CONSTRAINT [PK_formulas_palaman_items] PRIMARY KEY CLUSTERED 
(
	[formula_palamanid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[formulas]    Script Date: 05/19/2020 10:45:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[formulas](
	[formulaid] [int] IDENTITY(1,1) NOT NULL,
	[formula_number] [varchar](255) NULL,
	[productid] [int] NULL,
	[price] [float] NULL,
	[basewt] [float] NULL,
	[tdw] [float] NULL,
	[unbaked] [float] NULL,
	[baked] [float] NULL,
	[yield] [float] NULL,
	[userid] [int] NULL,
	[datecreated] [datetime] NULL,
	[userid_modified] [int] NULL,
	[datemodified] [datetime] NULL,
	[status] [int] NULL,
 CONSTRAINT [PK_formulas] PRIMARY KEY CLUSTERED 
(
	[formulaid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[items]    Script Date: 05/19/2020 10:45:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[items](
	[itemid] [int] IDENTITY(1,1) NOT NULL,
	[catid] [int] NULL,
	[itemname] [varchar](255) NULL,
	[description] [varchar](255) NULL,
	[uom] [varchar](255) NULL,
	[datecreated] [datetime] NULL,
	[userid] [int] NULL,
	[status] [int] NULL,
 CONSTRAINT [PK_items] PRIMARY KEY CLUSTERED 
(
	[itemid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[login_logs]    Script Date: 05/19/2020 10:45:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[login_logs](
	[logid] [int] IDENTITY(1,1) NOT NULL,
	[userid] [int] NULL,
	[login] [datetime] NULL,
	[logout] [datetime] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[modules]    Script Date: 05/19/2020 10:45:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[modules](
	[moduleid] [int] IDENTITY(1,1) NOT NULL,
	[module] [varchar](255) NULL,
	[description] [varchar](255) NULL,
	[userid] [int] NULL,
	[datecreated] [datetime] NULL,
	[status] [int] NULL,
 CONSTRAINT [PK_modules] PRIMARY KEY CLUSTERED 
(
	[moduleid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[products]    Script Date: 05/19/2020 10:45:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[products](
	[productid] [int] IDENTITY(1,1) NOT NULL,
	[catid] [int] NULL,
	[product] [varchar](255) NULL,
	[description] [varchar](255) NULL,
	[status] [int] NULL,
	[userid] [int] NULL,
	[datecreated] [datetime] NULL,
 CONSTRAINT [PK_products] PRIMARY KEY CLUSTERED 
(
	[productid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[step1]    Script Date: 05/19/2020 10:45:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[step1](
	[step1id] [int] IDENTITY(1,1) NOT NULL,
	[formulaid] [float] NULL,
	[step1num] [varchar](255) NULL,
	[productid] [int] NULL,
	[quantity] [float] NULL,
	[basewt] [float] NULL,
	[userid] [int] NULL,
	[datecreated] [datetime] NULL,
	[usermodified] [int] NULL,
	[datemodified] [datetime] NULL,
	[status] [int] NULL,
 CONSTRAINT [PK_step1] PRIMARY KEY CLUSTERED 
(
	[step1id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[step1_items]    Script Date: 05/19/2020 10:45:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[step1_items](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[step1id] [int] NULL,
	[formula_itemid] [int] NULL,
	[itemid] [int] NULL,
	[value] [float] NULL,
	[actual] [float] NULL,
	[userid] [int] NULL,
	[datecreated] [datetime] NULL,
	[usermodified] [int] NULL,
	[datemodified] [datetime] NULL,
	[status] [int] NULL,
 CONSTRAINT [PK_step1_items] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[step1_palaman]    Script Date: 05/19/2020 10:45:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[step1_palaman](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[step1id] [int] NULL,
	[formula_itemid] [int] NULL,
	[itemid] [int] NULL,
	[value] [float] NULL,
	[actual] [float] NULL,
	[userid] [int] NULL,
	[datecreated] [datetime] NULL,
	[usermodified] [int] NULL,
	[datemodified] [datetime] NULL,
	[status] [int] NULL,
 CONSTRAINT [PK_step1_palaman] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[step2]    Script Date: 05/19/2020 10:45:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[step2](
	[step2id] [int] IDENTITY(1,1) NOT NULL,
	[step2num] [varchar](255) NULL,
	[step1id] [int] NULL,
	[formulaid] [int] NULL,
	[step3id] [int] NULL,
	[productid] [int] NULL,
	[quantity] [float] NULL,
	[userid] [int] NULL,
	[datecreated] [datetime] NULL,
	[usermodified] [int] NULL,
	[datemodified] [datetime] NULL,
	[status] [int] NULL,
 CONSTRAINT [PK_step2] PRIMARY KEY CLUSTERED 
(
	[step2id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[step2_items]    Script Date: 05/19/2020 10:45:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[step2_items](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[step2id] [int] NULL,
	[step1_itemid] [int] NULL,
	[formula_itemid] [int] NULL,
	[itemid] [int] NULL,
	[value] [float] NULL,
	[actual] [float] NULL,
	[userid] [int] NULL,
	[datecreated] [datetime] NULL,
	[usermodified] [int] NULL,
	[datemodified] [datetime] NULL,
	[status] [int] NULL,
 CONSTRAINT [PK_step2_items] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[step2_palaman]    Script Date: 05/19/2020 10:45:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[step2_palaman](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[step2id] [int] NULL,
	[step1_itemid] [int] NULL,
	[formula_itemid] [int] NULL,
	[itemid] [int] NULL,
	[value] [float] NULL,
	[actual] [float] NULL,
	[userid] [int] NULL,
	[datecreated] [datetime] NULL,
	[usermodified] [int] NULL,
	[datemodified] [datetime] NULL,
	[status] [int] NULL,
 CONSTRAINT [PK_step2_palaman] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[step3]    Script Date: 05/19/2020 10:45:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[step3](
	[step3id] [int] IDENTITY(1,1) NOT NULL,
	[step3num] [varchar](255) NULL,
	[step1id] [int] NULL,
	[formulaid] [int] NULL,
	[productid] [int] NULL,
	[tdw] [float] NULL,
	[quantity] [float] NULL,
	[userid] [int] NULL,
	[datecreated] [datetime] NULL,
	[usermodified] [int] NULL,
	[datemodified] [datetime] NULL,
	[status] [int] NULL,
 CONSTRAINT [PK_step3] PRIMARY KEY CLUSTERED 
(
	[step3id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[users]    Script Date: 05/19/2020 10:45:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[users](
	[userid] [int] IDENTITY(1,1) NOT NULL,
	[username] [varchar](255) NULL,
	[password] [varchar](255) NULL,
	[fullname] [varchar](255) NULL,
	[workgroup_id] [int] NULL,
	[createdby] [int] NULL,
	[datecreated] [datetime] NULL,
	[modifiedby] [int] NULL,
	[datemodified] [datetime] NULL,
	[status] [int] NULL,
 CONSTRAINT [PK_users] PRIMARY KEY CLUSTERED 
(
	[userid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[users_icon]    Script Date: 05/19/2020 10:45:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[users_icon](
	[imageid] [int] IDENTITY(1,1) NOT NULL,
	[userid] [int] NULL,
	[picture] [image] NULL,
	[date_uploaded] [datetime] NULL,
 CONSTRAINT [PK_users_icon] PRIMARY KEY CLUSTERED 
(
	[imageid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[workgroups]    Script Date: 05/19/2020 10:45:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[workgroups](
	[workgroupid] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](255) NULL,
	[description] [text] NULL,
	[datecreated] [datetime] NULL,
	[userid] [int] NULL,
	[status] [int] NULL,
 CONSTRAINT [PK_workgroups] PRIMARY KEY CLUSTERED 
(
	[workgroupid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  View [dbo].[vStep1]    Script Date: 05/19/2020 10:45:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vStep1]
AS
SELECT a.formulaid,a.step1id,a.step1num,c.category,b.product,
a.quantity,a.basewt,a.status,a.datecreated
FROM step1 a INNER JOIN products b ON a.productid = b.productid
INNER JOIN categories c ON b.catid = c.catid
GO
/****** Object:  View [dbo].[vStep1Items]    Script Date: 05/19/2020 10:45:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vStep1Items]
AS
select a.id,a.formula_itemid,b.itemid, a.step1id,c.category,b.itemname,a.actual,a.userid,a.datecreated from step1_items a INNER JOIN items b ON a.itemid = b.itemid
INNER JOIN categories c ON b.catid = c.catid
GO
/****** Object:  View [dbo].[vStep1Palaman]    Script Date: 05/19/2020 10:45:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vStep1Palaman]
AS
select a.id,a.formula_itemid,b.itemid, a.step1id,c.category,b.itemname,a.actual,a.userid,a.datecreated from step1_palaman a INNER JOIN items b ON a.itemid = b.itemid
INNER JOIN categories c ON b.catid = c.catid
GO
USE [master]
GO
ALTER DATABASE [abc_formula] SET  READ_WRITE 
GO
