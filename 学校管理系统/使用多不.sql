select * from Dormitory
select * from tb_Dormitory where Did=1
select COUNT(*) from Dormitory_information
insert into Dormitory_information( [Name])values('s')
select * from tb_Dormitory
select * from Grade
select * from Dormitory_information
insert into Dormitory_information(DormitoryNO) Values(4)

select COUNT(*) from Dormitory_information where DormitoryNO=1
select COUNT(*) from Dormitory_information
select * from Dormitory_information
select D.[Name],RZtime,Tell,BedNo,C.[CName] from Dormitory_information D join  Class C on C.ID=D.Class where DormitoryNO=1
select I.[ID],[Name],[Uid],[State], T.[TypeName] from AdminInfo I inner join AdminType T on I.ID = T.ID
select D.[Name],RZtime,Tell,BedNo,C.[CName], T.DonID  from Dormitory_information D join  Class C   on C.ID=D.Class join tb_Dormitory T  on D.DormitoryNO=T.ID where DormitoryNO=1
delete

select COUNT(*) from Dormitory_information where DormitoryNO
delete from BorrowBook
select * from BorrowBook
 
if exists(select * from sys.table where name='SchSystem')		--判断是否存在此数据库
update tb_Dormitory set Dcount=0 on 
select X.[ID],[DonID],Y.[Fhao] ,Waterfee ,Elcfee ,Y.[Yfen]   from tb_Dormitory X join suifei Y on Y.ID=X.ID 
update tb_Dormitory 
set [Return]=0