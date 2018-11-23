use master 
go
if exists(select * from sys.databases where name='SchSystem')		--�ж��Ƿ���ڴ����ݿ�
drop database SchSystem
go
create database SchSystem
go
use SchSystem
go
create table Dormitory				   --����¥��                          ��1
(
	ID int primary key identity(1,1),
	Name nvarchar(50) not null,			--��������
	[Count] int not null,				--����
	PKPath nvarchar(256) not null,		--ͼƬ·��
	ChName nvarchar(30) not null,		--����������
	ACount int not null,				--����¥��������
	Lount int not null				    --����¥��¥��
)
create table Grade 			            --�꼶��                             �� 2
(
	ID int primary key identity(1,1),
	GName nvarchar(30) not null,				--�꼶����
)
create table Class			               --�༶��                           �� 3
( 
	ID int primary key identity(1,1),
	CName nvarchar(30) not null,			--�༶����
	Gid int foreign key references Grade(ID)
)
create table Dormitory_information			--������Ϣ��                      �� 4
(
	ID int primary key identity(1,1),
	DormitoryNO int foreign key references Dormitory(ID),	--����
	Dleader nvarchar(30) not null,			            --���ҳ�
	Dcount int,				                  --������ס������
	Name nvarchar(30),		    --����
	RZtime datetime,	         --��סʱ��
	Tell nvarchar(50) not null,	--��ϵ��ʽ
	Waterfee money ,			--ˮ��
	Elcfee money,				--���
	BedNO int not null,			--����
	Class int foreign key references Class(ID)					--�༶
)
create table tb_Dormitory			--�����                                   �� 5
(
	ID int primary key identity(1,1),
	DonID int not null,				--����
	LeaderName nvarchar(30) not null		--���ҳ�����
)
create table BorrowBook			--�軹ͼ���                                    �� 6
(
	ID int primary key identity(1,1),
	IDT bit,				--1Ϊ��ʦ��0Ϊѧ��
	LenTime datetime,			--����ʱ��
	[Count] int not null,		--��������
	[Return] bit,				--1Ϊ�ѻ���0Ϊδ��
	ReturnTime datetime			--�黹ʱ��
)
create table Libraries			--ͼ������                                         �� 7
(
	ID int primary key identity(1,1),
	BID nvarchar(50) not null,		--����
	BName nvarchar(50) not null,		--����
	BCount int not null,			--�ִ���
	LCount int,						--�����
	Acount int not null,			--�������
	Leader nvarchar(30) not null	--������
)
create table CollegeType 		--�������ͱ�                                         �� 8
(
	ID int primary key identity(1,1),
	TypeName nvarchar(30) not null,		--��������
)
create table CollegePosition	--����ְλ��                                             ��9
(
	ID int primary key identity(1,1),
	PositionName nvarchar(50),		--ְλ����
)
create table CEmplnfo			--���ų�Ա��Ϣ��                             ��10
(
	ID int primary key identity(1,1),
	StuName nvarchar(30) not null,		--ѧ������
	CollegeName int foreign key references CollegeType(ID),		--��������
	PositionName int foreign key references CollegePosition(ID),		--ְλ����
	JoinTime datetime not null			--����ʱ��
)
create table CollegeCount		--����������                                      ��11
(
	ID int primary key identity(1,1),
	[Count] int foreign key references CollegeType(ID),			--����
	TypeName int foreign key references CollegeType(ID)			--������
)

create table StuPosition         -- ѧ��ְλ                                           ��12
(
	ID int primary key identity(1,1),
	PName nvarchar(50) not null,			--ְλ����
)
create table Stulnfo		--ѧ����Ϣ��                                           ��13
(
	ID int primary key identity(1,1),
	SStudentName nvarchar(16),			--����
	[TeacherID] AS 'N'+right(REPLICATE('0',6)+isnull(CONVERT(VARCHAR,ID),''),4),	--ѧ��
	StudentSex bit not null,					--�Ա�
	Pid int foreign key references StuPosition(ID),	--ְλ
	Gid int foreign key references Grade(ID),		--�꼶
	Cid int foreign key references Class(ID),		--�༶
	StudentUid nvarchar(64) not null,				--�˺�
	StudentPwd nvarchar(64) not null,				--����
	StudentFName nvarchar(16) unique not null,		--��������
	StudentFPhone char(11),				--���׵绰
	StudentMName nvarchar(16) unique not null,		--ĸ������
	StudenMPhone char(11),				--ĸ�׵绰
	StudentID char(18) not null unique,				--���֤
	StudentHome nvarchar(256) not null,				--��ͥסַ
	StudentCS datetime,								--��������
	StudentFace nvarchar(30),						--������ò
	StudentState bit default(1),					--�Ƿ��뵳
	StudentPhone char(11),							--�绰
	StudentTimeRZ  datetime,						--��Уʱ��
	StudentNation nvarchar(20),						--����
	StudentQQMailbox int,							--ѧ��QQ����
	StudentRemarks nvarchar(256),					--��ע
	StudentJG nvarchar(50),							--����
	StudentSS nvarchar(50),							--����
	StudentImg varchar(50)							--ͼƬ�����֤���û�ͷ��
)
create table GradeScore		--�꼶�ɼ���                                           ��14
(
	ID int primary key identity(1,1),
	Grade int foreign key references Grade(ID),	--�꼶
	Class int foreign key references Class(ID),	--�༶
	ClassScore int foreign key references Class(ID)	--�༶�ɼ�
)
create table ClassScore			--�༶�ɼ���                                       ��15
(
	ID int primary key identity(1,1),
	StuName nvarchar(30) not null,		--ѧ������
	Gid int foreign key references Grade(ID),	--ѧ�������꼶
	Cid int foreign key references Class(ID),	--ѧ�����ڰ༶
	Score int not null		--�ɼ�
)
create table StuScore		--ѧ�����˳ɼ���                                         ��16
(
	ID int primary key identity(1,1),
	StuNo int foreign key references GradeScore(ID),	--ѧ��
	StuName nvarchar(50) not null,		--ѧ������
	ExamName varchar(200) not null,		--��������
	ExamTime datetime not null,			--����ʱ��
	Mark nvarchar(256)					--˵��
)
create table TeaType		--��ʦ���ͱ�                                 ��17
(
	ID int primary key identity(1,1),
	TypeName nvarchar(30) not null,			--��������
)
create table TeaPosition	--��ʦְλ��                                  ��18
(
	ID int primary key identity(1,1),
	PName nvarchar(30) not null		--ְλ����
)
create table TeaInfo	--��ʦ������Ϣ��                           ��19
(
	ID int primary key identity(1,1),
	TeaName nvarchar(30) not null,		--��ʦ����
	TeacherSex bit not null,			--�Ա�
	TeacherUid nvarchar(64) not null,	--�˺�
	TeacherPwd nvarchar(64) not null,	--����
	[Type] int foreign key references TeaType(ID),	--��������
	Position int foreign key references TeaPosition(ID),	--����ְλ
	Class int foreign key references Class(ID),		--�����༶
	TeacherID char(18) not null unique,				--�������֤
	TeacharHoome nvarchar(256) not null,			--��ͥסַ
	StudentCS datetime,								--��������
	TeacherFace nvarchar(30),						--������ò
	TeacherPhone char(11),							--�绰
	TeacherGrade int ,							--רҵ�����ȼ�
	TeacherTimeRZ datetime,						--��ְʱ��
	TeacherTimeLZ datetime,						--��ְʱ��
	TeacherLZReason nvarchar(256),				--��ְԭ��
	TeacherJTPhone char(11),					--��ͥ�绰
	TeacherNation nvarchar(20),					--����
	TeacherQQMailbox int ,						--��ʦQQ����
	TeacherRemarks nvarchar(256),				--��ע
	TeacherJG nvarchar(50),						--����
	TeacherImg varchar(50)						--ͼƬ�����֤���û�ͷ��
)
create table EmpType	--Ա�����ͱ�                                           ��20
(
	ID int primary key identity(1,1),
	[Type] nvarchar(30) not null,		--��������
)
create table EmpPosition			--Ա��ְλ��                                 ��21
(
	ID int primary key identity(1,1),
	PName nvarchar(30) not null		--ְλ����
)  
create table EmpInfo	--Ա��������Ϣ��                                          ��22
(
	ID int primary key identity(1,1),
	Name nvarchar(30) not null,		--Ա������
	Tid int foreign key references EmpType(ID),		--����
	Pid int foreign key references EmpPosition(ID),	--ְλ
)
create table AssocliationType		--ѧ�������ͱ�                             ��23
(
	ID int primary key identity(1,1),
	TypeName nvarchar(50) not null		--��������
)
create table AssPName	--ѧ�����ڲ�ְλ����                        ��24
(
	ID int primary key identity(1,1),
	PName nvarchar(50) not null		--ְλ����
)
create table AssEmpInfo		--ѧ�����Ա��Ϣ��                         ��25
(
	ID int primary key identity(1,1),
	Name nvarchar(50) not null,			--ѧ������
	Tid int foreign key references AssocliationType(ID),	--��������
	Pid int foreign key references AssPName(ID)		--����ְλ
)
create table DisciplinType		--Υ�����ͱ�                            ��26
(
	ID int primary key identity(1,1),
	[Type] nvarchar(50) not null		--��������
)
create table StuDisciplin		--ѧ��Υ�ͱ�                             ��27
(
	ID int primary key identity(1,1),
	StuName nvarchar not null,			--Υ��������
	Class int foreign key references Class(ID),		--Υ�������ڰ༶
	DisTime datetime not null,				--Υ��ʱ��
	DisType int foreign key references DisciplinType(ID),	--Υ������
	[State] bit,				--1Ϊ��ȡ�����֣�0Ϊδȡ��
	Mark nvarchar(256)			--˵�� 
)
create table AdminType		--����Ա���ͱ�                        ��28  
(
	ID int primary key identity(1,1),
	TypeName nvarchar(50) not null		--��������
)
create table AdminInfo		--����Ա��Ϣ��                             ��29
(
	ID int primary key identity(1,1),
	Name nvarchar(50) not null,			--����
	Tid int foreign key references AdminType(ID),		--����
	[Uid] nvarchar(50) not null,			--�˺�
	Pwd Nvarchar(50) not null,				--����
	[State] bit								--״̬
)