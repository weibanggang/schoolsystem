use master 
go
if exists(select * from sys.databases where name='SchSystem')		--判断是否存在此数据库
drop database SchSystem
go
create database SchSystem
go
use SchSystem
go
create table Dormitory				   --宿舍楼表                          表1
(
	ID int primary key identity(1,1),
	Name nvarchar(50) not null,			--宿舍名称
	[Count] int not null,				--人数
	PKPath nvarchar(256) not null,		--图片路径
	ChName nvarchar(30) not null,		--负责人名字
	ACount int not null,				--宿舍楼总宿舍数
	Lount int not null				    --宿舍楼总楼层
)
create table Grade 			            --年级表                             表 2
(
	ID int primary key identity(1,1),
	GName nvarchar(30) not null,				--年级名称
)
create table Class			               --班级表                           表 3
( 
	ID int primary key identity(1,1),
	CName nvarchar(30) not null,			--班级名称
	Gid int foreign key references Grade(ID)
)
create table Dormitory_information			--宿舍信息表                      表 4
(
	ID int primary key identity(1,1),
	DormitoryNO int foreign key references Dormitory(ID),	--房号
	Dleader nvarchar(30) not null,			            --寝室长
	Dcount int,				                  --宿舍内住的人数
	Name nvarchar(30),		    --姓名
	RZtime datetime,	         --入住时间
	Tell nvarchar(50) not null,	--联系方式
	Waterfee money ,			--水费
	Elcfee money,				--电费
	BedNO int not null,			--床号
	Class int foreign key references Class(ID)					--班级
)
create table tb_Dormitory			--宿舍表                                   表 5
(
	ID int primary key identity(1,1),
	DonID int not null,				--房号
	LeaderName nvarchar(30) not null		--寝室长姓名
)
create table BorrowBook			--借还图书表                                    表 6
(
	ID int primary key identity(1,1),
	IDT bit,				--1为教师，0为学生
	LenTime datetime,			--借书时间
	[Count] int not null,		--借书数量
	[Return] bit,				--1为已还，0为未还
	ReturnTime datetime			--归还时间
)
create table Libraries			--图书管理表                                         表 7
(
	ID int primary key identity(1,1),
	BID nvarchar(50) not null,		--书编号
	BName nvarchar(50) not null,		--书名
	BCount int not null,			--现存量
	LCount int,						--借出量
	Acount int not null,			--书的总量
	Leader nvarchar(30) not null	--负责人
)
create table CollegeType 		--社团类型表                                         表 8
(
	ID int primary key identity(1,1),
	TypeName nvarchar(30) not null,		--类型名字
)
create table CollegePosition	--社团职位表                                             表9
(
	ID int primary key identity(1,1),
	PositionName nvarchar(50),		--职位名称
)
create table CEmplnfo			--社团成员信息表                             表10
(
	ID int primary key identity(1,1),
	StuName nvarchar(30) not null,		--学生姓名
	CollegeName int foreign key references CollegeType(ID),		--社团名称
	PositionName int foreign key references CollegePosition(ID),		--职位名称
	JoinTime datetime not null			--入团时间
)
create table CollegeCount		--社团数量表                                      表11
(
	ID int primary key identity(1,1),
	[Count] int foreign key references CollegeType(ID),			--数量
	TypeName int foreign key references CollegeType(ID)			--类型名
)

create table StuPosition         -- 学生职位                                           表12
(
	ID int primary key identity(1,1),
	PName nvarchar(50) not null,			--职位名称
)
create table Stulnfo		--学生信息表                                           表13
(
	ID int primary key identity(1,1),
	SStudentName nvarchar(16),			--姓名
	[TeacherID] AS 'N'+right(REPLICATE('0',6)+isnull(CONVERT(VARCHAR,ID),''),4),	--学号
	StudentSex bit not null,					--性别
	Pid int foreign key references StuPosition(ID),	--职位
	Gid int foreign key references Grade(ID),		--年级
	Cid int foreign key references Class(ID),		--班级
	StudentUid nvarchar(64) not null,				--账号
	StudentPwd nvarchar(64) not null,				--密码
	StudentFName nvarchar(16) unique not null,		--父亲姓名
	StudentFPhone char(11),				--父亲电话
	StudentMName nvarchar(16) unique not null,		--母亲姓名
	StudenMPhone char(11),				--母亲电话
	StudentID char(18) not null unique,				--身份证
	StudentHome nvarchar(256) not null,				--家庭住址
	StudentCS datetime,								--出生日期
	StudentFace nvarchar(30),						--政治面貌
	StudentState bit default(1),					--是否入党
	StudentPhone char(11),							--电话
	StudentTimeRZ  datetime,						--入校时间
	StudentNation nvarchar(20),						--民族
	StudentQQMailbox int,							--学生QQ邮箱
	StudentRemarks nvarchar(256),					--备注
	StudentJG nvarchar(50),							--籍贯
	StudentSS nvarchar(50),							--宿舍
	StudentImg varchar(50)							--图片，身份证或用户头像
)
create table GradeScore		--年级成绩表                                           表14
(
	ID int primary key identity(1,1),
	Grade int foreign key references Grade(ID),	--年级
	Class int foreign key references Class(ID),	--班级
	ClassScore int foreign key references Class(ID)	--班级成绩
)
create table ClassScore			--班级成绩表                                       表15
(
	ID int primary key identity(1,1),
	StuName nvarchar(30) not null,		--学生姓名
	Gid int foreign key references Grade(ID),	--学生所在年级
	Cid int foreign key references Class(ID),	--学生所在班级
	Score int not null		--成绩
)
create table StuScore		--学生个人成绩表                                         表16
(
	ID int primary key identity(1,1),
	StuNo int foreign key references GradeScore(ID),	--学号
	StuName nvarchar(50) not null,		--学生姓名
	ExamName varchar(200) not null,		--考试名称
	ExamTime datetime not null,			--考试时间
	Mark nvarchar(256)					--说明
)
create table TeaType		--教师类型表                                 表17
(
	ID int primary key identity(1,1),
	TypeName nvarchar(30) not null,			--类型名称
)
create table TeaPosition	--教师职位表                                  表18
(
	ID int primary key identity(1,1),
	PName nvarchar(30) not null		--职位名称
)
create table TeaInfo	--教师个人信息表                           表19
(
	ID int primary key identity(1,1),
	TeaName nvarchar(30) not null,		--教师名字
	TeacherSex bit not null,			--性别
	TeacherUid nvarchar(64) not null,	--账号
	TeacherPwd nvarchar(64) not null,	--密码
	[Type] int foreign key references TeaType(ID),	--所属类型
	Position int foreign key references TeaPosition(ID),	--所在职位
	Class int foreign key references Class(ID),		--所带班级
	TeacherID char(18) not null unique,				--教室身份证
	TeacharHoome nvarchar(256) not null,			--家庭住址
	StudentCS datetime,								--出生日期
	TeacherFace nvarchar(30),						--政治面貌
	TeacherPhone char(11),							--电话
	TeacherGrade int ,							--专业技术等级
	TeacherTimeRZ datetime,						--入职时间
	TeacherTimeLZ datetime,						--离职时间
	TeacherLZReason nvarchar(256),				--离职原因
	TeacherJTPhone char(11),					--家庭电话
	TeacherNation nvarchar(20),					--民族
	TeacherQQMailbox int ,						--教师QQ邮箱
	TeacherRemarks nvarchar(256),				--备注
	TeacherJG nvarchar(50),						--籍贯
	TeacherImg varchar(50)						--图片，身份证或用户头像
)
create table EmpType	--员工类型表                                           表20
(
	ID int primary key identity(1,1),
	[Type] nvarchar(30) not null,		--类型名称
)
create table EmpPosition			--员工职位表                                 表21
(
	ID int primary key identity(1,1),
	PName nvarchar(30) not null		--职位名称
)  
create table EmpInfo	--员工个人信息表                                          表22
(
	ID int primary key identity(1,1),
	Name nvarchar(30) not null,		--员工姓名
	Tid int foreign key references EmpType(ID),		--类型
	Pid int foreign key references EmpPosition(ID),	--职位
)
create table AssocliationType		--学生会类型表                             表23
(
	ID int primary key identity(1,1),
	TypeName nvarchar(50) not null		--类型名称
)
create table AssPName	--学生会内部职位名称                        表24
(
	ID int primary key identity(1,1),
	PName nvarchar(50) not null		--职位名称
)
create table AssEmpInfo		--学生会成员信息表                         表25
(
	ID int primary key identity(1,1),
	Name nvarchar(50) not null,			--学生姓名
	Tid int foreign key references AssocliationType(ID),	--所属类型
	Pid int foreign key references AssPName(ID)		--所属职位
)
create table DisciplinType		--违纪类型表                            表26
(
	ID int primary key identity(1,1),
	[Type] nvarchar(50) not null		--类型名称
)
create table StuDisciplin		--学生违纪表                             表27
(
	ID int primary key identity(1,1),
	StuName nvarchar not null,			--违纪人名字
	Class int foreign key references Class(ID),		--违纪人所在班级
	DisTime datetime not null,				--违纪时间
	DisType int foreign key references DisciplinType(ID),	--违纪类型
	[State] bit,				--1为已取消处分，0为未取消
	Mark nvarchar(256)			--说明 
)
create table AdminType		--管理员类型表                        表28  
(
	ID int primary key identity(1,1),
	TypeName nvarchar(50) not null		--类型名称
)
create table AdminInfo		--管理员信息表                             表29
(
	ID int primary key identity(1,1),
	Name nvarchar(50) not null,			--姓名
	Tid int foreign key references AdminType(ID),		--类型
	[Uid] nvarchar(50) not null,			--账号
	Pwd Nvarchar(50) not null,				--密码
	[State] bit								--状态
)