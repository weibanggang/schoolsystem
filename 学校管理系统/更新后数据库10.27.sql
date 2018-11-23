use master 
go
if exists(select * from sys.databases where name='SchSystem')		--判断是否存在此数据库
drop database SchSystem
GO
create database SchSystem
GO
use SchSystem
GO
create table Dormitory				   --宿舍楼表                  
(
	[ID] int primary key identity(1,1),
	[Name] nvarchar(30) not null,	--楼名称
	[Count] int ,				    --可住人数
	[YCount]int ,				    --已住人数
	[ACount] int ,			        --总间数
    [Lount] int, 		          	--宿舍楼总楼层
	[IMGF] image		        	--图片，身份证或用户头像
)
GO--1

create table tb_Dormitory			--宿舍表                     
(
	[ID] int primary key identity(1,1),
	[Did] int  foreign key references Dormitory	(ID),--哪一个宿舍楼
	[DonID]  nvarchar(20)not null ,				   --房号
    [Dcount] int,				   --宿舍内住的人数
)
go
 create table Neiwu  --扣分
 (
 ID int primary  key identity(1,1),
 LID int foreign key references Dormitory(ID),--宿舍楼名
 FNo int foreign key references tb_Dormitory(ID),--宿舍房号
 FuZe varchar(20),--负责人
 Bed int ,--床
 Chair varchar(30),--椅子
 [Floor] varchar(30),--地板
 WC varchar(30),--洗手间
 yt varchar(20),--阳台
 fan varchar(20),--风扇
 AirConditionner varchar(20),--空调
 Light varchar(20),--灯
 [date] datetime,--扣分日期
 Point int , --总分
 other nvarchar(50),--其他
 Remark nvarchar(256),--备注
 )
 go
 create table weixiuwu  --报修
 (
 ID int primary key identity(1,1),
 LID int foreign key references Dormitory(ID),--宿舍楼名
 FNo int foreign key references tb_Dormitory(ID),--宿舍房号
 Bed varchar(20),--床
 AirConditionner varchar(20),--空调
 Light varchar(20),--灯
 Wc varchar(20),--洗手间
 Waterlog varchar(20),--水龙头
 reShuiQi varchar(20),--热水器
 Door varchar(20),--们
 Window varchar(20),--窗
 UpFloor varchar(20),--天花板
 fan varchar(20),--风扇
 other nvarchar(50),--其他
 Remark varchar(256),--备注
 Stata bit,--维修状态
 BaoXiuSheBei varchar(20),--报修日期设备
 [date] datetime,--报修日期
 )
 go
 
create table Grade 			            --年级表                   
(
	[ID] int primary key identity(1,1),
	[GName] nvarchar(30) not null,				--年级名称
)
GO--3
create table Class			               --班级表                
( 
	[ID] int primary key identity(1,1),
	[CName] nvarchar(30) not null,			--班级名称
	[Gid] int foreign key references Grade(ID)--年级类型
)
GO--4
create table Dormitory_information			--宿舍信息表           
(
	[ID] int primary key identity(1,1),
	[DormitoryNO] int  references tb_Dormitory(ID),	--房号
	[Did] int  foreign key references Dormitory	(ID),--哪一个宿舍楼
	[Name] nvarchar(30)not null,		    --姓名
	[RZtime] datetime,	         --入住时间
	[Tell] nvarchar(50) ,	--联系方式
	[BedNO] int not null,			--床号
	[Class] int foreign key references Class(ID)	--班级
)
GO--5

GO--7
create table CollegeType 		--社团类型表                  
(
	[ID] int primary key identity(1,1),
	[TypeName] nvarchar(30) not null ,		--类型名字
)
GO--8
create table CollegePosition	--社团职位表                   
(
	[ID] int primary key identity(1,1),
	[CPName] nvarchar(50)not null ,		--职位名称
	
)
GO--9
create table CEmplnfo			--社团成员信息表               
(
	[ID] int primary key identity(1,1),
	[TeacherID] int foreign key references Class(ID)  ,		--班级
	[Name]nvarchar(30),--姓名
	[CollegeName] int foreign key references CollegeType(ID),--社团名称
	[CPNameID] int foreign key references CollegePosition(ID),--职位名称 
	[CJoinTime] datetime ,			--入团时间
	[sex]  nvarchar(2)--性别
)
GO--10
create table CollegeCount		--社团数量表                 
(
	[Count] int ,	--社团量
	[TypeName] int 	--总人数
)
GO--11
create table StuPosition         -- 学生职位                
(
	[ID] int primary key identity(1,1),
	[PName] nvarchar(50)unique not null,--职位名称
	[pwd] 	nvarchar(50)		--记住密码
)
GO--12
create table Stulnfo		--学生信息表                    
(
	[ID] int identity(1,1),
	[SStudentName] nvarchar(20) not null,			--姓名
	[TeacherID] nvarchar(20) primary key ,	--学号
	[StudentSex] nvarchar(2)not null ,					--性别
	[Pid] int foreign key references StuPosition(ID),	--职位
	[Cid] int foreign key references Class(ID),		--班级
	[SPwd] nvarchar(64) not null,				--密码
	[SFName] nvarchar(16)  ,		--父亲姓名
	[SFPhone] char(11),				             --父亲电话
	[SMName] nvarchar(16)  ,		--母亲姓名
	[SMPhone] char(11),				            --母亲电话
	[SID] char(18) not null ,				--身份证
	[SHome] nvarchar(256) ,				--家庭住址
	[SCS] datetime,								--出生日期
	[SFace] nvarchar(20),						--政治面貌
	[SPhone] char(11),							--手机号码
	[STimeRZ]  datetime,						--入校时间
	[SNation] nvarchar(20),						--民族
	[SQQMailbox] nvarchar(20),							--学生QQ邮箱
	[SRemarks] nvarchar(256),					--备注
	[SJG] nvarchar(20),							--籍贯
	[IMGF] image							--图片，身份证或用户头像
)
create table BorrowBook			--借还图书表                     
(
	[ID] int primary key identity(1,1),
	[IDT] nvarchar(15),				--1为教师，0为学生
	[LenTime] datetime,			--借书时间
	[huihuan] bit,				--1为已还，0为未还
	[ReturnTime] datetime,			--归还时间
	[xuehao] nvarchar(20)not null,   --学号
	[BID] nvarchar(50)not null ,		--书编号
	
)
create table TeaType		--教师类型表                     
(
	[ID] int primary key identity(1,1),
	[TypeName] nvarchar(30)not null 	--类型名称
)
GO--17
create table TeaPosition	--教师职位表                      
(
	[ID] int primary key identity(1,1),
	[PName] nvarchar(30)not null	--职位名称
)
GO--18
create table TeaInfo	--教师个人信息表                     
(
	[ID] int primary key identity(1,1),
	[TName] nvarchar(20) not null,		--教师名字
	[TSex] nvarchar(2)not null ,			--性别
	[TUid] nvarchar(20) not null,	--工号
	[TPwd] nvarchar(64)not null ,	--密码
	[Type] int foreign key references TeaType(ID),	--所属类型
	[Position] int foreign key references TeaPosition(ID),	--所在职位
	[TID] char(18)not null ,				--教师身份证
	[THoome] nvarchar(256) ,			--家庭住址
	[TCS] datetime,								--出生日期
	[TFace] nvarchar(20),						--政治面貌
	[TPhone] char(11),							--手机号码
	[TTimeRZ] datetime,						--入职时间
	[TTimeLZ] datetime,						--离职时间
	[TLZReason] nvarchar(256),				--离职原因
	[TJTPhone] char(11),					--家庭电话
	[TNation] nvarchar(20),					--民族
	[TQQMailbox] nvarchar(30) ,						--教师QQ邮箱
	[TRemarks] nvarchar(256),				--备注
	[TJG] nvarchar(20),						--籍贯
	[IMGF] image					--图片，身份证或用户头像
)
GO--19
create table EmpType	--员工类型表                        
(
	[ID] int primary key identity(1,1),
	[Type] nvarchar(30) not null,		--类型名称
)
GO--20
create table EmpPosition			--员工职位表            
(
	[ID] int primary key identity(1,1),
	[PName] nvarchar(30)not null		--职位名称
)  
GO--21
create table EmpInfo	--员工个人信息表                    
(
	[ID] int primary key identity(1,1),
	[EUid] nvarchar(64),	--工号
	[EPwd] nvarchar(64)not null,	--密码
	[EName] nvarchar(15) ,		--员工姓名
	[ESet] nvarchar(1)not null ,  --性别
	[EBirthday] datetime ,   --出生日期
	[Tid] int foreign key references EmpType(ID),		--类型
	[Pid] int foreign key references EmpPosition(ID),	--职位
	[EmpNation] nvarchar(10) ,  --民族
	[EmpFace]  nvarchar(10) ,  --政治面貌
	[EmpIDT] char(18) not null,    --身份证号码
	[EmpEducate] nvarchar(10) ,  --学历
	[EWedding] nvarchar(5) ,  --婚姻状态
	[ETell] char(11) , --手机号码
	[EPhone] char(11)  ,--固话
	[EIDAd] nvarchar(256) ,  --家庭住址
	[EJG] nvarchar(20),	--籍贯
	[IMGF] image,	--图片，身份证或用户头像
	[TRemarks] nvarchar(256),				--备注
)
GO--22
create table AssociationType		--学生会部门表          
(
	[ID] int primary key identity(1,1),
	[TypeName] nvarchar(20)unique not null		--部门名称
)
GO--23
create table AssPName	--学生会内部职位名称              
(
	[ID] int primary key identity(1,1),
	[PName] nvarchar(20)unique not null		--职位名称
)
GO--24
create table AssEmpInfo		--学生会成员信息表           
(
	[ID] int primary key identity(1,1),
	[Name] nvarchar(20) not null,			--学生姓名
	[AssID] nvarchar(20) foreign key references Stulnfo(TeacherID),--学生学号
	[Tid] int references AssociationType(ID),	--所属类型
	[Pid] int  references AssPName(ID)		--所属职位
)
GO--25
create table DisciplinType		--违纪类型表         
(
	[ID] int primary key identity(1,1),
	[Type] nvarchar(20) unique not null		--类型名称
)
GO--26
create table StuDisciplin		--学生违纪表        
(
	[ID] int primary key identity(1,1),
	[StuName] nvarchar not null,			--违纪人名字
	[AssID] nvarchar(20) foreign key references Stulnfo(TeacherID),--学生学号
	[DisTime] datetime not null,				--违纪时间
	[DisType] int  references DisciplinType(ID),	--违纪类型
	[State] bit default(1),				--1为已取消处分，0为未取消
	[Mark] nvarchar(256)			--备注 
)
GO--27

GO--28

create table AdminInfo		--管理员信息表                             
(
	[ID] int primary key identity(1,1),
	[Name] nvarchar(20) not null,			    --姓名
	[Sex] nvarchar(2)not null ,--性别
	[Tid] nvarchar(15) not null,		--类型
	[Uid] nvarchar(20) not null,			--账号
	[Pwd] nvarchar(64) not null,				--密码
	[State] nvarchar(15) not null			    --状态
)

GO--29