 create table Neiwu
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
 [date] datetime,--����
 Point int , --�ܷ�
 Remrk varchar(256),--��ע
 )
 go
 create table weixiuwu
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
 fan varchar(20),--fengs
 other varchar(20),--����
 Remark varchar(256),--��ע
 )
 go
 create table BaoxiuBiao
 (
 ID int primary key  identity(1,1),
 LID int foreign key references Dormitory(ID),--¥��
 FNo int foreign key references tb_Dormitory(ID), --���᷿��
 Stata bit,--ά��״̬
 BaoXiuSheBei varchar(20),--�����豸
 [date] datetime,--��������
 )
 go