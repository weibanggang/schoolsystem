 create table Neiwu
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
 [date] datetime,--日期
 Point int , --总分
 Remrk varchar(256),--备注
 )
 go
 create table weixiuwu
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
 fan varchar(20),--fengs
 other varchar(20),--其他
 Remark varchar(256),--备注
 )
 go
 create table BaoxiuBiao
 (
 ID int primary key  identity(1,1),
 LID int foreign key references Dormitory(ID),--楼名
 FNo int foreign key references tb_Dormitory(ID), --宿舍房号
 Stata bit,--维修状态
 BaoXiuSheBei varchar(20),--保修设备
 [date] datetime,--保修日期
 )
 go