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
	[Count] int ,				    --��ס����
	[YCount]int ,				    --��ס����
	[ACount] int ,			        --�ܼ���
    [Lount] int, 		          	--����¥��¥��
	[IMGF] image		        	--ͼƬ�����֤���û�ͷ��
)
GO--1

create table tb_Dormitory			--�����                     
(
	[ID] int primary key identity(1,1),
	[Did] int  foreign key references Dormitory	(ID),--��һ������¥
	[DonID]  nvarchar(20)not null ,				   --����
    [Dcount] int,				   --������ס������
)
go
 create table Neiwu  --�۷�
 (
 ID int primary  key identity(1,1),
 LID int foreign key references Dormitory(ID),--����¥��
 FNo int foreign key references tb_Dormitory(ID),--���᷿��
 FuZe varchar(20),--������
 Bed int ,--��
 Chair varchar(30),--����
 [Floor] varchar(30),--�ذ�
 WC varchar(30),--ϴ�ּ�
 yt varchar(20),--��̨
 fan varchar(20),--����
 AirConditionner varchar(20),--�յ�
 Light varchar(20),--��
 [date] datetime,--�۷�����
 Point int , --�ܷ�
 other nvarchar(50),--����
 Remark nvarchar(256),--��ע
 )
 go
 create table weixiuwu  --����
 (
 ID int primary key identity(1,1),
 LID int foreign key references Dormitory(ID),--����¥��
 FNo int foreign key references tb_Dormitory(ID),--���᷿��
 Bed varchar(20),--��
 AirConditionner varchar(20),--�յ�
 Light varchar(20),--��
 Wc varchar(20),--ϴ�ּ�
 Waterlog varchar(20),--ˮ��ͷ
 reShuiQi varchar(20),--��ˮ��
 Door varchar(20),--��
 Window varchar(20),--��
 UpFloor varchar(20),--�컨��
 fan varchar(20),--����
 other nvarchar(50),--����
 Remark varchar(256),--��ע
 Stata bit,--ά��״̬
 BaoXiuSheBei varchar(20),--���������豸
 [date] datetime,--��������
 )
 go
 
create table Grade 			            --�꼶��                   
(
	[ID] int primary key identity(1,1),
	[GName] nvarchar(30) not null,				--�꼶����
)
GO--3
create table Class			               --�༶��                
( 
	[ID] int primary key identity(1,1),
	[CName] nvarchar(30) not null,			--�༶����
	[Gid] int foreign key references Grade(ID)--�꼶����
)
GO--4
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
GO--5

GO--7
create table CollegeType 		--�������ͱ�                  
(
	[ID] int primary key identity(1,1),
	[TypeName] nvarchar(30) not null ,		--��������
)
GO--8
create table CollegePosition	--����ְλ��                   
(
	[ID] int primary key identity(1,1),
	[CPName] nvarchar(50)not null ,		--ְλ����
	
)
GO--9
create table CEmplnfo			--���ų�Ա��Ϣ��               
(
	[ID] int primary key identity(1,1),
	[TeacherID] int foreign key references Class(ID)  ,		--�༶
	[Name]nvarchar(30),--����
	[CollegeName] int foreign key references CollegeType(ID),--��������
	[CPNameID] int foreign key references CollegePosition(ID),--ְλ���� 
	[CJoinTime] datetime ,			--����ʱ��
	[sex]  nvarchar(2)--�Ա�
)
GO--10
create table CollegeCount		--����������                 
(
	[Count] int ,	--������
	[TypeName] int 	--������
)
GO--11
create table StuPosition         -- ѧ��ְλ                
(
	[ID] int primary key identity(1,1),
	[PName] nvarchar(50)unique not null,--ְλ����
	[pwd] 	nvarchar(50)		--��ס����
)
GO--12
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
create table TeaType		--��ʦ���ͱ�                     
(
	[ID] int primary key identity(1,1),
	[TypeName] nvarchar(30)not null 	--��������
)
GO--17
create table TeaPosition	--��ʦְλ��                      
(
	[ID] int primary key identity(1,1),
	[PName] nvarchar(30)not null	--ְλ����
)
GO--18
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
GO--19
create table EmpType	--Ա�����ͱ�                        
(
	[ID] int primary key identity(1,1),
	[Type] nvarchar(30) not null,		--��������
)
GO--20
create table EmpPosition			--Ա��ְλ��            
(
	[ID] int primary key identity(1,1),
	[PName] nvarchar(30)not null		--ְλ����
)  
GO--21
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
GO--22
create table AssociationType		--ѧ���Ჿ�ű�          
(
	[ID] int primary key identity(1,1),
	[TypeName] nvarchar(20)unique not null		--��������
)
GO--23
create table AssPName	--ѧ�����ڲ�ְλ����              
(
	[ID] int primary key identity(1,1),
	[PName] nvarchar(20)unique not null		--ְλ����
)
GO--24
create table AssEmpInfo		--ѧ�����Ա��Ϣ��           
(
	[ID] int primary key identity(1,1),
	[Name] nvarchar(20) not null,			--ѧ������
	[AssID] nvarchar(20) foreign key references Stulnfo(TeacherID),--ѧ��ѧ��
	[Tid] int references AssociationType(ID),	--��������
	[Pid] int  references AssPName(ID)		--����ְλ
)
GO--25
create table DisciplinType		--Υ�����ͱ�         
(
	[ID] int primary key identity(1,1),
	[Type] nvarchar(20) unique not null		--��������
)
GO--26
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
GO--27

GO--28

create table AdminInfo		--����Ա��Ϣ��                             
(
	[ID] int primary key identity(1,1),
	[Name] nvarchar(20) not null,			    --����
	[Sex] nvarchar(2)not null ,--�Ա�
	[Tid] nvarchar(15) not null,		--����
	[Uid] nvarchar(20) not null,			--�˺�
	[Pwd] nvarchar(64) not null,				--����
	[State] nvarchar(15) not null			    --״̬
)

GO--29