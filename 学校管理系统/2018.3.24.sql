use master 
go
if exists(select * from sys.databases where name='SchSystem')		--�ж��Ƿ���ڴ����ݿ�
drop database SchSystem
GO
create database SchSystem
GO
use SchSystem
GO

create table Dormitory				   --����¥��                  
(
	[ID] int primary key identity(1,1),
	[Name] nvarchar(30) not null,	--¥����
	[DName] nvarchar(30) not null,	--¥����
	[Count] int ,				    --��ס����
	[YCount]int default(0),			--��ס����
	[ZZACount] int ,			    --�ܼ���
    [Lount] int, 		          	--����¥��¥��
    [TypeLount] nvarchar(30), 		        --��������
	[IMGF] image		        	--ͼƬ�����֤���û�ͷ��
)
GO--1
create table tb_Dormitory			--�����                     
(
	[ID] int primary key identity(1,1),
	[Did] int  foreign key references Dormitory	(ID),--��һ������¥
	[DonID]  nvarchar(20)not null ,				   --����
	[Count] int ,				    --��ס����
	[YCount]int default(0),			--��ס����
	[BCount]  nvarchar(20) default(0), --�༶
	zt bit default(0)               --״̬
)
go--2
create table weixiuwu  --����
 (
 ID int primary key identity(1,1),
 LID int foreign key references Dormitory(ID),--����¥��
 FNo int foreign key references tb_Dormitory(ID),--���᷿��
 other nvarchar(256),--ά����Ŀ
 Remark varchar(256),--�����˱�ע
  WRemark varchar(256),--ά���˱�ע
 Stata varchar(20) Default('δ��'),--ά��״̬
 BaoXiuSheBei datetime,--��������
 [date] datetime ,--ά������
 weixhou datetime,--ά�޺�ȷ��ʱ��
 bxname varchar(20),--������
 weixname varchar(20),--ά����
 renwei varchar(20),--��Ϊ��Ȼ
 hx varchar(10),--�Ƿ���
 bh int --���
 )
 go--3
create table Grade 			            --�꼶��                   
(
	[ID] int primary key identity(1,1),
	[GName] nvarchar(30) not null,				--�꼶����
	[Cclass] int,--�༶����
	[CCount] int ,				    --������
)
GO--4
create table Class			               --�༶��                
( 
	[ID] int primary key identity(1,1),
	[CName] nvarchar(30) not null,			--�༶����
	[Gid] int foreign key references Grade(ID),--�꼶����
	[CsCount] int ,				    --������
	[bzrname]nvarchar(30) not null,--����������
	[TTell] nvarchar(50) ,	--��������ϵ��ʽ
	[czt]bit  default(1)
)
GO--5
create table Dormitory_information			--������Ϣ��           
(
	[ID] int primary key identity(1,1),
	[DormitoryNO] int  references tb_Dormitory(ID),	--����
	[Did] int  foreign key references Dormitory	(ID),--��һ������¥
	[Name] nvarchar(30)not null,		    --����
	[RZtime] datetime,	         --��סʱ��
	[Tell] nvarchar(50) ,	--��ϵ��ʽ
	[BedNO] int not null,			--����
	[Class] int foreign key references Class(ID)	--�༶
)
GO--6
create table sfinto																		--��ӵ�ˮ�ѱ�
(	
		sfintoID int primary key identity(1,1),									        --��ˮ��ID									
		[Did] int  foreign key references Dormitory	(ID),	--¥��							--��һ������¥
     	[DormitoryNO] nvarchar(30) ,--����
		dateFee datetime,			--����											    	--��ס����
		electricstart varchar(10),		--�������										        --�������
		electricend varchar(10),			--���ֹ��												--���ֹ��
		electriccharg decimal(18, 0),		--�Ʒѵ���												--�Ʒѵ���
		electricunit varchar(10),			--����											--��ѵ���
		electricprice decimal(18, 0),		--���												--����ܼ�
		waterstart varchar(10),			--ˮ������												--ˮ������
		waterend varchar(10),				--ˮ��ֹ��											--ˮ��ֹ��
		watercharg decimal(18, 0),			--�Ʒѵ���											--�Ʒ�ˮ��
		waterunit varchar(10),			--����												--ˮ�ѵ���
		waterprice decimal(18, 0)			--ˮ��												--ˮ���ܼ�
)
go--7
create table electricAndWater
(
	 electricPrice float,--��ĵ���
	 WaterPrice float--ˮ�ĵ���
)
GO--8
create table CollegeType 		--�������ͱ�                  
(
	[ID] int primary key identity(1,1),
	[TypeName] nvarchar(30) not null		--��������
)
GO--9

create table CollegePosition	--����ְλ��                   
(
	[ID] int primary key identity(1,1),
	[CPName] nvarchar(50)not null ,		--ְλ����
	
)
GO--10

create table CEmplnfo			--���ų�Ա��Ϣ��               
(
	[ID] int primary key identity(1,1),
	[SID] nvarchar(20),--ѧ��
	[TeacherID] nvarchar(20) ,		--�༶
	[Name]nvarchar(30),--����
	[CollegeName] int foreign key references CollegeType(ID),--��������
	[CPNameID] int foreign key references CollegePosition(ID),--ְλ���� 
	[CJoinTime] datetime ,			--����ʱ��
)
GO--11
create table CollegeCount		--����������                 
(
	[Count] int ,	--������
	[TypeName] int 	--������
)
GO--12
create table StuPosition         -- ѧ��ְλ                
(
	[ID] int primary key identity(1,1),
	[PName] nvarchar(50)unique not null,--ְλ����
	[pwd] 	nvarchar(50)		--��ס����
)
GO--13

create table Stulnfo		--ѧ����Ϣ��                    
(
	[ID] int identity(1,1),
	[SStudentName] nvarchar(20) not null,			--����
	[TeacherID] nvarchar(20) primary key ,	--ѧ��
	[StudentSex] nvarchar(2)not null ,					--�Ա�
	[Pid] int foreign key references StuPosition(ID),	--ְλ
	[Cid] int foreign key references Class(ID),		--�༶
	[SPwd] nvarchar(64) not null,				--����
	[SFName] nvarchar(16)  ,		--��������
	[SFPhone] char(11),				             --���׵绰
	[SMName] nvarchar(16)  ,		--ĸ������
	[SMPhone] char(11),				            --ĸ�׵绰
	[SID] char(18) not null ,				--���֤
	[SHome] nvarchar(256) ,				--��ͥסַ
	[SCS] datetime,								--��������
	[SFace] nvarchar(20),						--������ò
	[SPhone] char(11),							--�ֻ�����
	[STimeRZ]  datetime,						--��Уʱ��
	[SNation] nvarchar(20),						--����
	[SQQMailbox] nvarchar(20),							--ѧ��QQ����
	[SRemarks] nvarchar(256),					--��ע
	[SJG] nvarchar(20),							--����
	[IMGF] image							--ͼƬ�����֤���û�ͷ��
)
go--14
create table BorrowBook			--�軹ͼ���                     
(
	[ID] int primary key identity(1,1),
	[IDT] nvarchar(15),				--1Ϊ��ʦ��0Ϊѧ��
	[LenTime] datetime,			--����ʱ��
	[huihuan] bit,				--1Ϊ�ѻ���0Ϊδ��
	[ReturnTime] datetime,			--�黹ʱ��
	[xuehao] nvarchar(20)not null,   --ѧ��
	[BID] nvarchar(50)not null ,		--����
	
)
go--15
create table TeaType		--��ʦ���ͱ�                     
(
	[ID] int primary key identity(1,1),
	[TypeName] nvarchar(30)not null 	--��������
)
GO--16
create table TeaPosition	--��ʦְλ��                      
(
	[ID] int primary key identity(1,1),
	[PName] nvarchar(30)not null	--ְλ����
)
GO--17
create table TeaInfo	--��ʦ������Ϣ��                     
(
	[ID] int primary key identity(1,1),
	[TName] nvarchar(20) not null,		--��ʦ����
	[TSex] nvarchar(2)not null ,			--�Ա�
	[TUid] nvarchar(20) not null,	--����
	[TPwd] nvarchar(64)not null ,	--����
	[Type] int foreign key references TeaType(ID),	--��������
	[Position] int foreign key references TeaPosition(ID),	--����ְλ
	[TID] char(18)not null ,				--��ʦ���֤
	[THoome] nvarchar(256) ,			--��ͥסַ
	[TCS] datetime,								--��������
	[TFace] nvarchar(20),						--������ò
	[TPhone] char(11),							--�ֻ�����
	[TTimeRZ] datetime,						--��ְʱ��
	[TTimeLZ] datetime,						--��ְʱ��
	[TLZReason] nvarchar(256),				--��ְԭ��
	[TJTPhone] char(11),					--��ͥ�绰
	[TNation] nvarchar(20),					--����
	[TQQMailbox] nvarchar(30) ,						--��ʦQQ����
	[TRemarks] nvarchar(256),				--��ע
	[TJG] nvarchar(20),						--����
	[IMGF] image					--ͼƬ�����֤���û�ͷ��
)
GO--18
create table EmpType	--Ա�����ͱ�                        
(
	[ID] int primary key identity(1,1),
	[Type] nvarchar(30) not null,		--��������
)
GO--19
create table EmpPosition			--Ա��ְλ��            
(
	[ID] int primary key identity(1,1),
	[PName] nvarchar(30)not null		--ְλ����
)  
GO--20
create table EmpInfo	--Ա��������Ϣ��                    
(
	[ID] int primary key identity(1,1),
	[EUid] nvarchar(64),	--����
	[EPwd] nvarchar(64)not null,	--����
	[EName] nvarchar(15) ,		--Ա������
	[ESet] nvarchar(1)not null ,  --�Ա�
	[EBirthday] datetime ,   --��������
	[Tid] int foreign key references EmpType(ID),		--����
	[Pid] int foreign key references EmpPosition(ID),	--ְλ
	[EmpNation] nvarchar(10) ,  --����
	[EmpFace]  nvarchar(10) ,  --������ò
	[EmpIDT] char(18) not null,    --���֤����
	[EmpEducate] nvarchar(10) ,  --ѧ��
	[EWedding] nvarchar(5) ,  --����״̬
	[ETell] char(11) , --�ֻ�����
	[EPhone] char(11)  ,--�̻�
	[EIDAd] nvarchar(256) ,  --��ͥסַ
	[EJG] nvarchar(20),	--����
	[IMGF] image,	--ͼƬ�����֤���û�ͷ��
	[TRemarks] nvarchar(256),				--��ע
)
GO--21
create table AssociationType		--ѧ���Ჿ�ű�          
(
	[ID] int primary key identity(1,1),
	[TypeName] nvarchar(20)unique not null		--��������
)
GO--22
create table AssPName	--ѧ�����ڲ�ְλ����              
(
	[ID] int primary key identity(1,1),
	[PName] nvarchar(20)unique not null		--ְλ����
)
GO--23
create table AssEmpInfo		--ѧ�����Ա��Ϣ��           
(
	[ID] int primary key identity(1,1),
	[Name] nvarchar(20) not null,			--ѧ������
	[AssID] nvarchar(20) ,--ѧ��ѧ��
	[bj]nvarchar(15) not null,--�༶
	[Tid] int references AssociationType(ID),	--��������
	[Pid] int  references AssPName(ID)		--����ְλ
)
GO--24
create table DisciplinType		--Υ�����ͱ�         
(
	[ID] int primary key identity(1,1),
	[Type] nvarchar(20) unique not null		--��������
)
GO--25
create table StuDisciplin		--ѧ��Υ�ͱ�        
(
	[ID] int primary key identity(1,1),
	[StuName] nvarchar not null,			--Υ��������
	[AssID] nvarchar(20) foreign key references Stulnfo(TeacherID),--ѧ��ѧ��
	[DisTime] datetime not null,				--Υ��ʱ��
	[DisType] int  references DisciplinType(ID),	--Υ������
	[State] bit default(1),				--1Ϊ��ȡ�����֣�0Ϊδȡ��
	[Mark] nvarchar(256)			--��ע 
)
GO--26
create table AdminInfo		--����Ա��Ϣ��                             
(
	[ID] int primary key identity(1,1),
	[Name] nvarchar(20) not null,			    --����
	Sex nvarchar(2) not null,	--�Ա�
	[Tid] nvarchar(15) not null,		--����
	[Uid] nvarchar(20) not null,			--�˺�
	[Pwd] nvarchar(64) not null,				--����
	[State] nvarchar(64) not null,				    --״̬
)

GO--27
create table Neiwu  --�۷�
 (
 ID int primary  key identity(1,1),--1
[Did] varchar(30),								--��һ������¥
[DormitoryNO] varchar(30) ,--����
class varchar(20),--�༶
FuZe varchar(20),--�����	
 Point decimal(18, 0)  , --�ܷ�5
 KPiont decimal(18, 0) ,--�ܿ۷�6
 [Floor] varchar(20) ,--����7
LJ varchar(20),--���� 8
 yt varchar(20),--��̨9
 Desk varchar(20),--����10
 beizi varchar(20),--����11
 Cloth Varchar(20),--����12
Chair varchar(30),--����13
AirConditionner varchar(20),--�յ�14
Shoes varchar(20),--Ь��15
WashRoom varchar(20),--������16
WC varchar(30),--ϴ�ּ�17
Botton varchar(30),--Ͱ18
Drinking varchar(30),--��ˮ��19
Light varchar(20),--������20
WaterLog varchar(30),--ˮ��ͷ21
INelcet varchar(30),--Υ�����22
LiveTool varchar(30),--ë����ˢ23
CleanTool varchar(30),--��๤��24
SthPlay  varchar(30),--��Ʒ�ڷ�25
EmptyBed varchar(30),--�մ���Ʒ 26
Others varchar(50),--����27
Remark varchar(256),--��ע28
times datetime--ʱ��29
 )
 go--28

 create table lc--¥��
(
ID int identity(1,1),
[name] varchar(20)
)
go--29
create table gk  --���
(
ID int identity(1,1),
[gname] nvarchar(256)
)
go--30
create table denglu--��¼
(
ID int identity(1,1),
times datetime, --ʱ��
AMID int  ,--�������
Uids nvarchar(20) ,--�˺�
us nvarchar(20)--�������
)
go--31
create table fangui--������
(
ID int identity(1,1),
times datetime, --����ʱ��
zhiti nvarchar(256),--����
Name nvarchar(20),--������
neir nvarchar(256),--��������
)
go--32

