use Premium_DeisiTest
go

select * from sysobjects where name like 'spu_inv_rep%' and xtype = 'P'
select    IN07CODDOC, IN07MM, SUM(IN07CANART)   from dbo.in07movi where IN07CODEMP = '01' and IN07AA = '2016' and IN07TIPDOC = '31' and IN07CODALM = '06'
group by IN07CODDOC, IN07MM
--Hecho por Ivan Atanacio
