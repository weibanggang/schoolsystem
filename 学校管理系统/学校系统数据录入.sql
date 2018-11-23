--1宿舍楼名
insert into Dormitory 
values('芙蓉园',200,'图片路径','程老师',50,5,500,600),
		('怡馨园',300,'图片路径','李老师',50,5,500,600),
		('湘欣苑',300,'图片路径','李老师',40,5,450,600),
		('若惜苑',300,'图片路径','李老师',40,5,500,600),
		('恩馨苑',400,'图片路径','陈老师',40,5,500,600),
		('宜和园',200,'图片路径','张老师',60,5,500,600),
		('怡香园',200,'图片路径','张老师',60,5,500,600),
		('花韵苑',200,'图片路径','张老师',60,5,500,600),
		('雅文苑',300,'图片路径','张老师',30,5,500,600),
		('彩音轩',300,'图片路径','朱老师',30,5,500,600),
		('玉琼苑',300,'图片路径','朱老师',30,5,500,600),
		('欣华苑',300,'图片路径','朱老师',30,5,500,600),
		('锦绣宫',300,'图片路径','朱老师',30,5,500,600)		
--2宿舍表						
insert into  tb_Dormitory
	 values (1,101,8,50,120),
			(2,102,8,50,120),
			(3,103,8,50,120),
			(4,104,8,50,130),
			(5,105,8,50,130),
			(6,106,8,50,130),
			(7,107,8,50,130),
			(7,108,8,50,130),
			(8,109,8,50,140),
			(9,110,8,50,140),
			(9,201,8,50,140),	
			(6,202,8,50,140),
			(101,1,8,50,100)
--3宿舍信息表
insert into Dormitory_information 
values 
(2,'郑文武',2017-06-24,'15007031871',1,1),	
(2,'赵进坤',2017-06-26,'13687560615',2,1),	
(2,'朱星宇',2017-06-26,'150870263708',3,1),	
(2,'张育威',2017-06-26,'13692191383',4,1),	 
(2,'梁光健',2017-06-26,'13481297235',5,1),	
(2,'丁火钦',2017-06-27,'13437536684',6,1),	
(2,'张优兰',2017-06-27,'15113839219',7,1),	
(2,'黄川川',2017-06-27,'13671462632',8,1),	
(2,'王精精',2017-06-28,'15875932802',1,1),	
(2,'罗立一',2017-06-28,'13926901506',2,1),	
(2,'任梦吉',2017-06-29,'13192191383',3,1),	 
(2,'何仙伟',2017-06-29,'12138467236',4,1),	
(2,'彭远东',2017-06-29,'13192191383',5,1),
(2,'韦邦杠',2017-06-26,'15192191383',2,1),	
(2,'张兰邓',2017-06-26,'13092191383',3,1),
(2,'杨万生',2017-06-26,'13692191383',4,1),
(2,'欧健平',2017-06-26,'13418389219',5,1),
(2,'韦奉豪',2017-06-27,'13592191383',6,1),
(2,'郭世棋',2017-06-27,'18992191383',7,1),
(2,'梅宇诚',2017-06-27,'1310559876',8,1),
(2,'韦秀丽',2017-06-28,'1288327473',1,1),
(2,'陈卓悦',2017-06-28,'1231726387',2,1),
(2,'吴旭权',2017-06-29,'13192191383',3,1),	
(2,'刘涛涛',2017-06-29,'12138467236',4,1),
(2,'黄佳豪',2017-06-29,'13192191383',5,1),
(2,'黎军基',2017-06-26,'15192191383',2,1),	
(2,'陈绍雄',2017-06-26,'13092191383',3,1),
(2,'刘地林',2017-06-26,'13692191383',4,1),
(2,'李小云',2017-06-26,'13418389219',5,1),
(2,'殷家日',2017-06-27,'13592191383',6,1),
(2,'林天波',2017-06-27,'18992191383',7,1),
(2,'叶昊亮',2017-06-27,'1310559876',8,1),
(2,'唐玉棋',2017-06-28,'1288327473',1,1),
(2,'张敏杰',2017-06-28,'1231726387',2,1),
(2,'韦庞杰',2017-06-29,'18176345589',3,1),	
(2,'夏同鑫',2017-06-29,'14796260692',4,1),
 
(2,'欧一乐',2017-06-26,'17807825776',4,1),
(2,'陈胜',2017-06-26,'13005768719',5,1),
(2,'龙家为',2017-06-27,'1827827132',6,1),
(2,'李泽望',2017-06-27,'13085803052',7,1),
(2,'李云清',2017-06-27,'18720791859',8,1),
(2,'覃欧',2017-06-28,'13016369289',1,1),
(2,'柒远强',2017-06-28,'18377519770',2,1),
(2,'杜京粤',2017-06-29,'13005274329',3,1),	
(2,'钟世杨',2017-06-29,'18170782574',4,1),
(2,'刘铭',2017-06-29,'17322964417',5,1),
 
(2,'刘枫',2017-06-29,'15986040383',5,1),
(2,'张东明',2017-06-29,'15768812162',5,1),
(2,'陈家豪',2017-06-29,'15073034644',5,1),   
(2,'刘志祥',2017-06-29,'13103961499',5,1),
(2,'畅嘉伟',2017-06-29,'13826114950',5,1),
(2,'吴文斌',2017-06-29,'13085803052',5,1)
         
--4水费
insert into shuifei 
 values (101,2016,100,150),
   (102,2016,110,154), 
	(103,2016,120,150),
	(104,2016,120,155),
	(105,2016,121,156),
	(106,2016,123,150),
	(107,2016,112,130),
	(108,2016,113,150), 
	(109,2016,110,150),
	(110,2016,115,140),
	(111,2016,121,150),
	(112,2016,121,128),
	(113,2016,123,145)
--5年级
insert into Grade 
	values('一学期'),
	('二学期'),
	('二学年')
--6班级
insert into Class 
	values ('141班',1),
	('143班',1),
	('143班',1),
	('145班',1),
	('146班',1),
	('147班',1),
	('148班',1),
	('131班',3),
	('132班',3),
	('133班',3),
	('134班',3)
--7社团类型 
insert into CollegeType 
		values('外语社'),
		('礼仪社'),
		('篮球社'),
		('漫研社'),
		('舞蹈社'),
		('书法社'),
		('羽毛球社'),
		('乒乓球社'),
		('摄影社')
--8社团职位
insert into CollegePosition
	 values('社长'),
	 ('副社长'),
	 ('普通成员')
--9社团成员信息
insert into CEmplnfo
		 values(1,'张优兰',1,1,'2017-09-10','女'),
		 (2,'张优兰',1,1,'2017-09-10','女'),
		 (1,'李达',1,1,'2017-09-11','男'),
		 (3,'李清',1,1,'2017-09-12','男'),
		 (3,'张永美',1,1,'2017-09-10','女'),
		 (4,'张丽',1,1,'2017-09-10','女'),
		 (1,'张峰',1,1,'2017-09-10','男'),
		 (3,'李峰',1,1,'2016-09-10','男'),
		 (3,'李丽',1,1,'2016-09-10','女')
--10社团数量
insert into CollegeCount
	 values (8,20),
	 (8,20),
	 (8,23),
	 (8,13),
	 (8,21),
	(8,15)
insert into StuPosition values('班长','123456'),('副班长','123456')
,('学习委员','123456'),('体育委员','123456'),('生活委员','123456')
,('班级成员','123456'),('组织委员','123456')


insert into Stulnfo(SStudentName,TeacherID,StudentSex,Pid,Cid,SPwd,SFName,SFPhone,SMName,SMPhone,[SID],SHome,SCS,SFace,SPhone,STimeRZ,SNation,SQQMailbox,SRemarks,SJG)
 values('韦邦杠','14301','男',6,3,'123456','老爸','13152624559','老妈','13152624559','452226199811022115','广西省来宾市南泗乡平田村','1998-11-02','团员','18776203778','2017-07-01','壮族','761273133','','中国')
insert into Stulnfo(SStudentName,TeacherID,StudentSex,Pid,Cid,SPwd,SFName,SFPhone,SMName,SMPhone,[SID],SHome,SCS,SFace,SPhone,STimeRZ,SNation,SQQMailbox,SRemarks,SJG)
 values('梁光健','14302','男',6,3,'123456','老爸','18675195667','老妈','18675195667','452226199909022115','广西省来宾市来宾区陶邓乡五同村民委山梁村','1999-09-02','团员','13481297235','2017-07-01','壮族','2361928131','','中国')
insert into Stulnfo(SStudentName,TeacherID,StudentSex,Pid,Cid,SPwd,SFName,SFPhone,SMName,SMPhone,[SID],SHome,SCS,SFace,SPhone,STimeRZ,SNation,SQQMailbox,SRemarks,SJG)
 values('张兰邓','14303','男',6,2,'123456','老爸','13481964460','老妈','13481964460','452226199704032115','广西省武宣县通挽镇大昌村民委大昌村7队692号','1997-04-03','团员','18878254325','2017-07-01','壮族','2539039829','','中国')
insert into Stulnfo(SStudentName,TeacherID,StudentSex,Pid,Cid,SPwd,SFName,SFPhone,SMName,SMPhone,[SID],SHome,SCS,SFace,SPhone,STimeRZ,SNation,SQQMailbox,SRemarks,SJG)
 values('刘志翔','14304','男',6,2,'123456','老爸','13923533128','老妈','13923533128','45222619960311211X','广东省揭阳市皮凝视池尾街道塔峰','1997-03-11','团员','13103961499','2017-07-01','壮族','193660821','','中国')
insert into Stulnfo(SStudentName,TeacherID,StudentSex,Pid,Cid,SPwd,SFName,SFPhone,SMName,SMPhone,[SID],SHome,SCS,SFace,SPhone,STimeRZ,SNation,SQQMailbox,SRemarks,SJG)
 values('吴文斌','14305','男',6,1,'123456','老爸','13790436396','老妈','13790436396','452226199709172115','广东省信宜市城中','1997-09-17','团员','13075699576','2017-07-01','壮族','964947876','','中国')
insert into Stulnfo(SStudentName,TeacherID,StudentSex,Pid,Cid,SPwd,SFName,SFPhone,SMName,SMPhone,[SID],SHome,SCS,SFace,SPhone,STimeRZ,SNation,SQQMailbox,SRemarks,SJG)
 values('畅嘉伟','14306','男',6,1,'123456','老爸','13824132245','老妈','13824132245','452226199711172115','珠海市金湾区金山花园','1997-11-17','团员','13826114950','2017-07-01','壮族','','','中国')
insert into Stulnfo(SStudentName,TeacherID,StudentSex,Pid,Cid,SPwd,SFName,SFPhone,SMName,SMPhone,[SID],SHome,SCS,SFace,SPhone,STimeRZ,SNation,SQQMailbox,SRemarks,SJG)
 values('陈佳豪','14307','男',6,2,'123456','老爸','13532229162','老妈','13532229162','452226199712152115','珠海市金湾区金山花园','1997-12-15','团员','15073034644','2017-07-01','壮族','','','中国')
insert into Stulnfo(SStudentName,TeacherID,StudentSex,Pid,Cid,SPwd,SFName,SFPhone,SMName,SMPhone,[SID],SHome,SCS,SFace,SPhone,STimeRZ,SNation,SQQMailbox,SRemarks,SJG)
 values('张东明','14308','男',1,2,'123456','老爸','15986033428','老妈','15986033428','452226199711112115','珠海香洲前山梅溪村82号','1997-11-11','团员','15768812162','2017-07-01','壮族','1920098158','','中国')
insert into Stulnfo(SStudentName,TeacherID,StudentSex,Pid,Cid,SPwd,SFName,SFPhone,SMName,SMPhone,[SID],SHome,SCS,SFace,SPhone,STimeRZ,SNation,SQQMailbox,SRemarks,SJG)
 values('刘风','14309','男',2,3,'123456','老爸','15322777511','老妈','15322777511','452226199709212115','广东省紫金县紫城镇','1997-09-21','团员','15986040383','2017-07-01','壮族','1293434420','','中国')
insert into Stulnfo(SStudentName,TeacherID,StudentSex,Pid,Cid,SPwd,SFName,SFPhone,SMName,SMPhone,[SID],SHome,SCS,SFace,SPhone,STimeRZ,SNation,SQQMailbox,SRemarks,SJG)
 values('刘铭','14310','男',6,2,'123456','老爸','15170746497','老妈','15170746497','452226199706272115','广东省紫金县紫城镇二中路9号','1997-06-27','团员','17322964417','2017-07-01','壮族','2671626752','','中国')
insert into Stulnfo(SStudentName,TeacherID,StudentSex,Pid,Cid,SPwd,SFName,SFPhone,SMName,SMPhone,[SID],SHome,SCS,SFace,SPhone,STimeRZ,SNation,SQQMailbox,SRemarks,SJG)
 values('钟世杨','14311','男',6,3,'123456','老爸','13979748040','老妈','13979748040','452226199707302115','江西省干赣州市寻乌县','1997-07-30','团员','18170782574','2017-07-01','壮族','1171332001','','中国')
insert into Stulnfo(SStudentName,TeacherID,StudentSex,Pid,Cid,SPwd,SFName,SFPhone,SMName,SMPhone,[SID],SHome,SCS,SFace,SPhone,STimeRZ,SNation,SQQMailbox,SRemarks,SJG)
 values('杜京粤','14312','男',6,1,'123456','老爸','13602169073','老妈','13602169073','452226199701132115','江西省干赣州市寻乌县文峰乡岗背村','1997-01-13','团员','13005274329','2017-07-01','壮族','563918504','','中国')
insert into Stulnfo(SStudentName,TeacherID,StudentSex,Pid,Cid,SPwd,SFName,SFPhone,SMName,SMPhone,[SID],SHome,SCS,SFace,SPhone,STimeRZ,SNation,SQQMailbox,SRemarks,SJG)
 values('柒远强','14313','男',6,1,'123456','老爸','18278578248','老妈','18278578248','452226199702182115','广东省普宁市流沙西街道南平里119栋4号','1997-02-18','团员','18377519770','2017-07-01','壮族','1454854695','','中国')
insert into Stulnfo(SStudentName,TeacherID,StudentSex,Pid,Cid,SPwd,SFName,SFPhone,SMName,SMPhone,[SID],SHome,SCS,SFace,SPhone,STimeRZ,SNation,SQQMailbox,SRemarks,SJG)
 values('覃欧','14314','男',6,1,'123456','老爸','13677722156','老妈','13677722156','452226199703132115','广西省桂平市西山镇西长村竹姑山屯20号','1997-03-13','团员','13016369289','2017-07-01','壮族','404344656','','中国')
insert into Stulnfo(SStudentName,TeacherID,StudentSex,Pid,Cid,SPwd,SFName,SFPhone,SMName,SMPhone,[SID],SHome,SCS,SFace,SPhone,STimeRZ,SNation,SQQMailbox,SRemarks,SJG)
 values('李云清','14315','男',6,2,'123456','老爸','13979794335','老妈','13979794335','452226199706162115','广西来宾市城厢乡','1997-06-16','团员','18879578325','2017-07-01','壮族','1013084720','','中国')
insert into Stulnfo(SStudentName,TeacherID,StudentSex,Pid,Cid,SPwd,SFName,SFPhone,SMName,SMPhone,[SID],SHome,SCS,SFace,SPhone,STimeRZ,SNation,SQQMailbox,SRemarks,SJG)
 values('李泽望','14316','男',4,2,'123456','老爸','15978096593','老妈','15978096593','452226199709302115','江西省石城县琴江镇温坊村老虎坑','1997-09-30','团员','18720791859','2017-07-01','壮族','1650441540','','中国')
insert into Stulnfo(SStudentName,TeacherID,StudentSex,Pid,Cid,SPwd,SFName,SFPhone,SMName,SMPhone,[SID],SHome,SCS,SFace,SPhone,STimeRZ,SNation,SQQMailbox,SRemarks,SJG)
 values('龙家为','14317','男',6,2,'123456','老爸','13737207873','老妈','13737207873','452226199707252115','广西乐业县幼平乡','1997-07-25','团员','13085803052','2017-07-01','壮族','1440203176','','中国')
insert into Stulnfo(SStudentName,TeacherID,StudentSex,Pid,Cid,SPwd,SFName,SFPhone,SMName,SMPhone,[SID],SHome,SCS,SFace,SPhone,STimeRZ,SNation,SQQMailbox,SRemarks,SJG)
 values('陈胜','14318','男',6,3,'123456','老爸','18177622976','老妈','18177622976','452226199703282115','广西省象州县运红镇水寨村民委龙塘村118号','1997-03-28','团员','1827827132','2017-07-01','壮族','2517778384','','中国')
insert into Stulnfo(SStudentName,TeacherID,StudentSex,Pid,Cid,SPwd,SFName,SFPhone,SMName,SMPhone,[SID],SHome,SCS,SFace,SPhone,STimeRZ,SNation,SQQMailbox,SRemarks,SJG)
 values('欧一乐','14319','男',6,3,'123456','老爸','13660804719','老妈','13660804719','452226199711222115','广西田阳县坡洪镇新景村','1997-11-22','团员','13005768719','2017-07-01','壮族','2668697130','','中国')
insert into Stulnfo(SStudentName,TeacherID,StudentSex,Pid,Cid,SPwd,SFName,SFPhone,SMName,SMPhone,[SID],SHome,SCS,SFace,SPhone,STimeRZ,SNation,SQQMailbox,SRemarks,SJG)
 values('夏同鑫','14320','男',6,3,'123456','老爸','18777927469','老妈','18777927469','452226199712252115','广西省来宾市兴宾区五山乡六欠村委欧村36-1号','1997-12-25','团员','17807825776','2017-07-01','壮族','2862519348','','中国')
insert into Stulnfo(SStudentName,TeacherID,StudentSex,Pid,Cid,SPwd,SFName,SFPhone,SMName,SMPhone,[SID],SHome,SCS,SFace,SPhone,STimeRZ,SNation,SQQMailbox,SRemarks,SJG)
 values('韦庞杰','14321','男',6,3,'123456','老爸','13481785008','老妈','13481785008','452226199702242115','广西壮族自治区北海市海城区石子里三巷9号','1997-02-24','团员','14796260692','2017-07-01','壮族','1152615589','','中国')
insert into Stulnfo(SStudentName,TeacherID,StudentSex,Pid,Cid,SPwd,SFName,SFPhone,SMName,SMPhone,[SID],SHome,SCS,SFace,SPhone,STimeRZ,SNation,SQQMailbox,SRemarks,SJG)
 values('陶非凡','14322','男',6,3,'123456','老爸','15070491309','老妈','15070491309','452226199710282115','广西省象州县大乐镇中和街9-2号','1997-10-28','团员','18176345589','2017-07-01','壮族','1403264271','','中国')
insert into Stulnfo(SStudentName,TeacherID,StudentSex,Pid,Cid,SPwd,SFName,SFPhone,SMName,SMPhone,[SID],SHome,SCS,SFace,SPhone,STimeRZ,SNation,SQQMailbox,SRemarks,SJG)
 values('张敏杰','14323','男',6,3,'123456','老爸','13928389292','老妈','13928389292','452226199701272115','金溪镇秀谷镇','1997-01-27','团员','18379484289','2017-07-01','壮族','435524709','','中国')
insert into Stulnfo(SStudentName,TeacherID,StudentSex,Pid,Cid,SPwd,SFName,SFPhone,SMName,SMPhone,[SID],SHome,SCS,SFace,SPhone,STimeRZ,SNation,SQQMailbox,SRemarks,SJG)
 values('唐玉棋','14324','男',7,3,'123456','老爸','15777463501','老妈','15777463501','452226199710262115','广东省龙门县马榨镇下龙山口34号','1997-10-26','团员','13126326565','2017-07-01','壮族','1561172137','','中国')
insert into Stulnfo(SStudentName,TeacherID,StudentSex,Pid,Cid,SPwd,SFName,SFPhone,SMName,SMPhone,[SID],SHome,SCS,SFace,SPhone,STimeRZ,SNation,SQQMailbox,SRemarks,SJG)
 values('叶昊亮','14325','男',6,3,'123456','老爸','13737218672','老妈','13737218672','452226199712292115','广西桂平市栋镇开发区83号','1997-12-29','团员','13075670798','2017-07-01','壮族','570375827','','中国')
insert into Stulnfo(SStudentName,TeacherID,StudentSex,Pid,Cid,SPwd,SFName,SFPhone,SMName,SMPhone,[SID],SHome,SCS,SFace,SPhone,STimeRZ,SNation,SQQMailbox,SRemarks,SJG)
 values('林添波','14326','男',6,3,'123456','老爸','13686711810','老妈','13686711810','452226199711222115','广西省来宾市裕达中央城水漾人家','1997-11-22','团员','13005782563','2017-07-01','壮族','937643274','','中国')
insert into Stulnfo(SStudentName,TeacherID,StudentSex,Pid,Cid,SPwd,SFName,SFPhone,SMName,SMPhone,[SID],SHome,SCS,SFace,SPhone,STimeRZ,SNation,SQQMailbox,SRemarks,SJG)
 values('殷家日','14327','男',6,3,'123456','老爸','18289720867','老妈','18289720867','452226199701132115','广东省信宜市北界镇','1997-01-13','团员','18218071181','2017-07-01','壮族','1662666486','','中国')
insert into Stulnfo(SStudentName,TeacherID,StudentSex,Pid,Cid,SPwd,SFName,SFPhone,SMName,SMPhone,[SID],SHome,SCS,SFace,SPhone,STimeRZ,SNation,SQQMailbox,SRemarks,SJG)
 values('李小云','14328','男',6,3,'123456','老爸','18379708359','老妈','18379708359','452226199702182115','江西省丰城市张巷镇殷家村','1997-02-18','团员','17763827328','2017-07-01','壮族','1303322464','','中国')
insert into Stulnfo(SStudentName,TeacherID,StudentSex,Pid,Cid,SPwd,SFName,SFPhone,SMName,SMPhone,[SID],SHome,SCS,SFace,SPhone,STimeRZ,SNation,SQQMailbox,SRemarks,SJG)
 values('刘地林','14329','男',6,3,'123456','老爸','13724771756','老妈','13724771756','452226199709162115','江西省赣州市于都县罗江乡','1997-09-16','团员','13192287851','2017-07-01','壮族','3269983308','','中国')
insert into Stulnfo(SStudentName,TeacherID,StudentSex,Pid,Cid,SPwd,SFName,SFPhone,SMName,SMPhone,[SID],SHome,SCS,SFace,SPhone,STimeRZ,SNation,SQQMailbox,SRemarks,SJG)
 values('陈绍雄','14330','男',6,1,'123456','老爸','13724771756','老妈','13724771756','452226199707082115','遂溪县昌洋村','1997-07-08','团员','18170675139','2017-07-01','壮族','649689087','','中国')
insert into Stulnfo(SStudentName,TeacherID,StudentSex,Pid,Cid,SPwd,SFName,SFPhone,SMName,SMPhone,[SID],SHome,SCS,SFace,SPhone,STimeRZ,SNation,SQQMailbox,SRemarks,SJG)
 values('黎军基','14331','男',6,4,'123456','老爸','13507775423','老妈','13507775423','452226199705052115','广西省灵山县丰塘镇潭龙村','1997-05-05','团员','18312727657','2017-07-01','壮族','450983626','','中国')
insert into Stulnfo(SStudentName,TeacherID,StudentSex,Pid,Cid,SPwd,SFName,SFPhone,SMName,SMPhone,[SID],SHome,SCS,SFace,SPhone,STimeRZ,SNation,SQQMailbox,SRemarks,SJG)
 values('黄佳豪','14332','男',6,2,'123456','老爸','13724485802','老妈','13724485802','45222619970103115','广东省江门市开平赤水镇冲口13巷11号','1997-01-03','团员','18777769585','2017-07-01','壮族','2861688468','','中国')
insert into Stulnfo(SStudentName,TeacherID,StudentSex,Pid,Cid,SPwd,SFName,SFPhone,SMName,SMPhone,[SID],SHome,SCS,SFace,SPhone,STimeRZ,SNation,SQQMailbox,SRemarks,SJG)
 values('刘涛涛','14333','男',6,2,'123456','老爸','13267046414','老妈','13267046414','452226199702022115','江西省樟树市药都路5号1栋1单元301室','1997-02-02','团员','17674023936','2017-07-01','壮族','2585881917','','中国')
insert into Stulnfo(SStudentName,TeacherID,StudentSex,Pid,Cid,SPwd,SFName,SFPhone,SMName,SMPhone,[SID],SHome,SCS,SFace,SPhone,STimeRZ,SNation,SQQMailbox,SRemarks,SJG)
 values('吴旭权','14334','男',6,3,'123456','老爸','13977587770','老妈','13977587770','452226199709072115','广东省连平县忠信镇拓坡村李坝1号','1997-09-07','团员','13075681729','2017-07-01','壮族','1319272035','','中国')
insert into Stulnfo(SStudentName,TeacherID,StudentSex,Pid,Cid,SPwd,SFName,SFPhone,SMName,SMPhone,[SID],SHome,SCS,SFace,SPhone,STimeRZ,SNation,SQQMailbox,SRemarks,SJG)
 values('陈卓悦','14335','男',6,3,'123456','老爸','13977587770','老妈','13977587770','452226199708062115','广西省玉林北流','1997-08-06','团员','13192720350','2017-07-01','壮族','949861884','','中国')
insert into Stulnfo(SStudentName,TeacherID,StudentSex,Pid,Cid,SPwd,SFName,SFPhone,SMName,SMPhone,[SID],SHome,SCS,SFace,SPhone,STimeRZ,SNation,SQQMailbox,SRemarks,SJG)
 values('韦秀丽','14336','男',6,3,'123456','老爸','13481812271','老妈','13481812271','452226199706092115','广西河池市凤山县三门海镇弄仁村杂孟屯','1997-06-09','团员','15278320521','2017-07-01','壮族','2913923936','','中国')
insert into Stulnfo(SStudentName,TeacherID,StudentSex,Pid,Cid,SPwd,SFName,SFPhone,SMName,SMPhone,[SID],SHome,SCS,SFace,SPhone,STimeRZ,SNation,SQQMailbox,SRemarks,SJG)
 values('梅宇诚','14337','男',6,3,'123456','老爸','15398852223','老妈','15398852223','452226199703012115','广东省云浮市郁南县都城镇桂圩罗顺镇罗顺村39号','1997-03-01','团员','18775814709','2017-07-01','壮族','1147562174','','中国')


insert into BorrowBook values('1','2017-09-10','1','2017-09-20','14301','J001')
,('1','2017-10-02','1','2017-10-12','14302','J003')
,('1','2017-09-10','1','2017-09-20','14303','J002')
,('1','2017-09-12','1','2017-09-23','14301','J003')
,('1','2017-08-20','1','2017-09-02','14302','J002')
,('1','2017-10-10','1','2017-10-20','14303','J001')
,('1','2017-08-10','1','2017-08-20','14302','J001')




insert into TeaType values('教师'),('财务部'),('辅导部门'),('接待部门')


insert into TeaPosition values('班主任'),('数学老师'),('语文老师'),('英语老师'),('专业老师'),('体育老师'),('财务员'),('辅导员'),('接待老师')

insert into TeaInfo(TName,TSex,TUid,TPwd,[Type],Position,TID,THoome,TCS,TFace,TPhone,TTimeRZ,TTimeLZ,TLZReason,TJTPhone,TNation,TQQMailbox,TRemarks,TJG)
values('张婷','女','123456','123456',1,1,'452226198512032115','广东珠海','1985-12-03','党员','15247453733','2013-10-03','','','13457356342','壮族','3334634234','','中国')
insert into TeaInfo(TName,TSex,TUid,TPwd,[Type],Position,TID,THoome,TCS,TFace,TPhone,TTimeRZ,TTimeLZ,TLZReason,TJTPhone,TNation,TQQMailbox,TRemarks,TJG)
values('陈永光','男','2345678','123456',1,5,'452226198510282115','广东珠海','1985-10-28','党员','15236728463','2013-06-01','','','15374847692','壮族','242412312','','中国')
insert into TeaInfo(TName,TSex,TUid,TPwd,[Type],Position,TID,THoome,TCS,TFace,TPhone,TTimeRZ,TTimeLZ,TLZReason,TJTPhone,TNation,TQQMailbox,TRemarks,TJG)
values('Juli','女','3456721','123456',1,4,'452226198704122125','广东珠海','1987-04-12','党员','15378374363','2013-11-02','','','13734635268','壮族','522342342','','中国')
insert into TeaInfo(TName,TSex,TUid,TPwd,[Type],Position,TID,THoome,TCS,TFace,TPhone,TTimeRZ,TTimeLZ,TLZReason,TJTPhone,TNation,TQQMailbox,TRemarks,TJG)
values('梁光健','男','124345','123545',2,4,'452226198605072125','广东佛山','1986-05-07','非党员','13481297235','2015-12-03','','','14684704544','壮族','64335324','','中国')
insert into TeaInfo(TName,TSex,TUid,TPwd,[Type],Position,TID,THoome,TCS,TFace,TPhone,TTimeRZ,TTimeLZ,TLZReason,TJTPhone,TNation,TQQMailbox,TRemarks,TJG)
values('韦邦杠','男','345645','454342',1,3,'452226198212162115','广西来宾','1982-12-16','非党员','15236346454','2016-09-13','','','14545456734','壮族','12344534','','中国')
insert into TeaInfo(TName,TSex,TUid,TPwd,[Type],Position,TID,THoome,TCS,TFace,TPhone,TTimeRZ,TTimeLZ,TLZReason,TJTPhone,TNation,TQQMailbox,TRemarks,TJG)
values('张兰邓','男','123434','343534',3,1,'452226198509172125','福建','1985-09-17','非党员','13367745755','2015-10-03','','','13566445352','壮族','4353434','','中国')
insert into TeaInfo(TName,TSex,TUid,TPwd,[Type],Position,TID,THoome,TCS,TFace,TPhone,TTimeRZ,TTimeLZ,TLZReason,TJTPhone,TNation,TQQMailbox,TRemarks,TJG)
values('李泽望','男','123435','3143345',2,2,'452226199307232125','湖南','1993-08-23','党员','14563267356','2008-04-03','','','13623252784','壮族','1231442','','中国')
insert into TeaInfo(TName,TSex,TUid,TPwd,[Type],Position,TID,THoome,TCS,TFace,TPhone,TTimeRZ,TTimeLZ,TLZReason,TJTPhone,TNation,TQQMailbox,TRemarks,TJG)
values('张优兰','女','125435','3133345',2,3,'452226199203132125','广东珠海','1992-03-13','党员','13523267356','2012-02-13','','','13623532784','壮族','1232432','','中国')
insert into TeaInfo(TName,TSex,TUid,TPwd,[Type],Position,TID,THoome,TCS,TFace,TPhone,TTimeRZ,TTimeLZ,TLZReason,TJTPhone,TNation,TQQMailbox,TRemarks,TJG)
values('刘志翔','男','623435','3143125',2,4,'452226199602262125','广东深圳','1996-02-26','非党员','13566227356','2011-07-21','','','13623652184','壮族','1221432','','中国')
insert into TeaInfo(TName,TSex,TUid,TPwd,[Type],Position,TID,THoome,TCS,TFace,TPhone,TTimeRZ,TTimeLZ,TLZReason,TJTPhone,TNation,TQQMailbox,TRemarks,TJG)
values('覃浩','男','354235','3323345',2,2,'452226199411252125','湖南','1994-11-25','党员','15366267356','2013-03-28','','','13675452784','壮族','1235242','','中国')
insert into TeaInfo(TName,TSex,TUid,TPwd,[Type],Position,TID,THoome,TCS,TFace,TPhone,TTimeRZ,TTimeLZ,TLZReason,TJTPhone,TNation,TQQMailbox,TRemarks,TJG)
values('魏国强','男','123436','2146345',3,4,'452226199201272125','湖南','1992-01-27','党员','15623269356','2009-12-27','','','13623572784','壮族','1237492','','中国')
insert into TeaInfo(TName,TSex,TUid,TPwd,[Type],Position,TID,THoome,TCS,TFace,TPhone,TTimeRZ,TTimeLZ,TLZReason,TJTPhone,TNation,TQQMailbox,TRemarks,TJG)
values('张宇杰','男','126135','3243545',2,5,'452226199107222125','湖南','1991-07-22','非党员','15823267356','2015-01-20','','','13643652724','壮族','1281463','','中国')
insert into TeaInfo(TName,TSex,TUid,TPwd,[Type],Position,TID,THoome,TCS,TFace,TPhone,TTimeRZ,TTimeLZ,TLZReason,TJTPhone,TNation,TQQMailbox,TRemarks,TJG)
values('魏宗帅','男','153735','3153345',1,2,'452226198912182125','黑龙江','1989-12-18','党员','13729567356','2001-12-29','','','13676352784','壮族','1273742','','中国')
insert into TeaInfo(TName,TSex,TUid,TPwd,[Type],Position,TID,THoome,TCS,TFace,TPhone,TTimeRZ,TTimeLZ,TLZReason,TJTPhone,TNation,TQQMailbox,TRemarks,TJG)
values('福安','男','186235','3197245',4,5,'452226199302282125','东北','1993-02-28','党员','18563253656','2012-01-29','','','13623201784','壮族','1239752','','中国')
insert into TeaInfo(TName,TSex,TUid,TPwd,[Type],Position,TID,THoome,TCS,TFace,TPhone,TTimeRZ,TTimeLZ,TLZReason,TJTPhone,TNation,TQQMailbox,TRemarks,TJG)
values('斯凯奇','女','145435','3193345',2,4,'452226198703222125','湖南','1987-03-22','党员','18374267356','2016-01-04','','','13636473784','壮族','1295242','','中国')
insert into TeaInfo(TName,TSex,TUid,TPwd,[Type],Position,TID,THoome,TCS,TFace,TPhone,TTimeRZ,TTimeLZ,TLZReason,TJTPhone,TNation,TQQMailbox,TRemarks,TJG)
values('欧一乐','男','142435','3142845',2,3,'452226199402132125','河南','1994-02-13','党员','14663267356','2008-06-15','','','13625275784','壮族','1293042','','中国')
insert into TeaInfo(TName,TSex,TUid,TPwd,[Type],Position,TID,THoome,TCS,TFace,TPhone,TTimeRZ,TTimeLZ,TLZReason,TJTPhone,TNation,TQQMailbox,TRemarks,TJG)
values('夏同鑫','男','125235','3142835',1,2,'452226198503172125','云南','1985-03-17','党员','14574963356','2008-02-18','','','13629676784','壮族','1201442','','中国')
insert into TeaInfo(TName,TSex,TUid,TPwd,[Type],Position,TID,THoome,TCS,TFace,TPhone,TTimeRZ,TTimeLZ,TLZReason,TJTPhone,TNation,TQQMailbox,TRemarks,TJG)
values('韦庞杰','男','127235','3143745',2,6,'452226199209122125','四川','1992-09-12','党员','14568592356','2008-06-18','','','13629563784','壮族','1205842','','中国')
insert into TeaInfo(TName,TSex,TUid,TPwd,[Type],Position,TID,THoome,TCS,TFace,TPhone,TTimeRZ,TTimeLZ,TLZReason,TJTPhone,TNation,TQQMailbox,TRemarks,TJG)
values('陶非凡','男','127135','3143845',2,3,'452226198205212125','广东信宜','1982-05-21','党员','14560573356','2012-03-14','','','13629265784','壮族','1205842','','中国')
insert into TeaInfo(TName,TSex,TUid,TPwd,[Type],Position,TID,THoome,TCS,TFace,TPhone,TTimeRZ,TTimeLZ,TLZReason,TJTPhone,TNation,TQQMailbox,TRemarks,TJG)
values('张敏杰','男','128435','3143925',2,3,'452226198507272125','河北','1985-07-27','党员','14565037356','2008-11-17','','','13620957784','壮族','1209242','','中国')
insert into TeaInfo(TName,TSex,TUid,TPwd,[Type],Position,TID,THoome,TCS,TFace,TPhone,TTimeRZ,TTimeLZ,TLZReason,TJTPhone,TNation,TQQMailbox,TRemarks,TJG)
values('唐玉棋',' 女','127235','3143925',1,3,'452226199405292125','广西贵港','1994-05-29','党员','14565930356','2010-06-13','','','13620363784','壮族','1280242','','中国')
insert into TeaInfo(TName,TSex,TUid,TPwd,[Type],Position,TID,THoome,TCS,TFace,TPhone,TTimeRZ,TTimeLZ,TLZReason,TJTPhone,TNation,TQQMailbox,TRemarks,TJG)
values('叶昊亮','男','128235','3143955',4,2,'452226199102232125','广西桂林','1991-02-23','党员','14568572356','2009-05-27','','','13620269784','壮族','1202642','','中国')
insert into TeaInfo(TName,TSex,TUid,TPwd,[Type],Position,TID,THoome,TCS,TFace,TPhone,TTimeRZ,TTimeLZ,TLZReason,TJTPhone,TNation,TQQMailbox,TRemarks,TJG)
values('林添波','男','127335','3143925',4,1,'452226199401262125','广东东莞','1994-01-26','党员','14569687356','2011-09-29','','','13628360784','壮族','1285242','','中国')
insert into TeaInfo(TName,TSex,TUid,TPwd,[Type],Position,TID,THoome,TCS,TFace,TPhone,TTimeRZ,TTimeLZ,TLZReason,TJTPhone,TNation,TQQMailbox,TRemarks,TJG)
values('殷家日','男','128335','3143425',2,3,'452226199604272125','广东广州','1996-04-27','党员','14560684356','2010-12-23','','','13628503784','壮族','1295642','','中国')
insert into TeaInfo(TName,TSex,TUid,TPwd,[Type],Position,TID,THoome,TCS,TFace,TPhone,TTimeRZ,TTimeLZ,TLZReason,TJTPhone,TNation,TQQMailbox,TRemarks,TJG)
values('李小云','男','122135','3143535',2,5,'452226199809262125','河南','1998-09-26','党员','14560683356','2014-11-23','','','13629470784','壮族','1295242','','中国')
insert into TeaInfo(TName,TSex,TUid,TPwd,[Type],Position,TID,THoome,TCS,TFace,TPhone,TTimeRZ,TTimeLZ,TLZReason,TJTPhone,TNation,TQQMailbox,TRemarks,TJG)
values('刘地林','男','123555','3142345',2,2,'452226199406282125','重庆','1994-06-28','党员','14560634556','2014-06-24','','','13628403784','壮族','1205642','','中国')
insert into TeaInfo(TName,TSex,TUid,TPwd,[Type],Position,TID,THoome,TCS,TFace,TPhone,TTimeRZ,TTimeLZ,TLZReason,TJTPhone,TNation,TQQMailbox,TRemarks,TJG)
values('陈绍雄','男','128435','3143245',3,1,'452226199406282125','南京','1983-07-27','党员','14569075356','2012-07-26','','','13629092784','壮族','1283542','','中国')
insert into TeaInfo(TName,TSex,TUid,TPwd,[Type],Position,TID,THoome,TCS,TFace,TPhone,TTimeRZ,TTimeLZ,TLZReason,TJTPhone,TNation,TQQMailbox,TRemarks,TJG)
values('黎军基','男','126235','3152345',4,2,'452226198205212125','北京','1982-05-21','党员','14560083556','2010-02-26','','','13625482784','壮族','1285542','','中国')
insert into TeaInfo(TName,TSex,TUid,TPwd,[Type],Position,TID,THoome,TCS,TFace,TPhone,TTimeRZ,TTimeLZ,TLZReason,TJTPhone,TNation,TQQMailbox,TRemarks,TJG)
values('黄佳豪','男','126335','3195245',3,2,'452226199510222125','甘肃','1995-10-22','党员','14560687356','2011-07-23','','','13629573784','壮族','1287642','','中国')
insert into TeaInfo(TName,TSex,TUid,TPwd,[Type],Position,TID,THoome,TCS,TFace,TPhone,TTimeRZ,TTimeLZ,TLZReason,TJTPhone,TNation,TQQMailbox,TRemarks,TJG)
values('刘涛涛','男','126235','3148545',1,2,'452226199711272125','东北','1997-11-27','党员','14569856356','2012-04-22','','','13628280784','壮族','1282642','','中国')
insert into TeaInfo(TName,TSex,TUid,TPwd,[Type],Position,TID,THoome,TCS,TFace,TPhone,TTimeRZ,TTimeLZ,TLZReason,TJTPhone,TNation,TQQMailbox,TRemarks,TJG)
values('吴旭权','男','128235','3158345',1,2,'452226198712232125','福建','1987-12-23','党员','14563027556','2008-02-04','','','13629476784','壮族','1257342','','中国')
insert into TeaInfo(TName,TSex,TUid,TPwd,[Type],Position,TID,THoome,TCS,TFace,TPhone,TTimeRZ,TTimeLZ,TLZReason,TJTPhone,TNation,TQQMailbox,TRemarks,TJG)
values('陈卓悦','男','127335','3152445',2,2,'452226198309282125','湖南','1983-09-28','党员','14563956356','2008-10-13','','','13629573784','壮族','1229542','','中国')
insert into TeaInfo(TName,TSex,TUid,TPwd,[Type],Position,TID,THoome,TCS,TFace,TPhone,TTimeRZ,TTimeLZ,TLZReason,TJTPhone,TNation,TQQMailbox,TRemarks,TJG)
values('韦秀丽','女','127235','3195345',3,2,'452226198207182125','广西柳州','1982-07-18','党员','14560753656','2008-11-10','','','13620587784','壮族','1295642','','中国')
insert into TeaInfo(TName,TSex,TUid,TPwd,[Type],Position,TID,THoome,TCS,TFace,TPhone,TTimeRZ,TTimeLZ,TLZReason,TJTPhone,TNation,TQQMailbox,TRemarks,TJG)
values('梅宇诚','男','128335','3149245',1,2,'452226199401182125','广东珠海','1994-01-18','党员','14563905756','2014-08-20','','','13620683784','壮族','1292742','','中国')
insert into TeaInfo(TName,TSex,TUid,TPwd,[Type],Position,TID,THoome,TCS,TFace,TPhone,TTimeRZ,TTimeLZ,TLZReason,TJTPhone,TNation,TQQMailbox,TRemarks,TJG)
values('吴文斌','男','129335','3140345',4,2,'452226190402192125','广东珠海','1904-02-19','党员','14563057356','2011-07-29','','','13620743784','壮族','1572442','','中国')
insert into TeaInfo(TName,TSex,TUid,TPwd,[Type],Position,TID,THoome,TCS,TFace,TPhone,TTimeRZ,TTimeLZ,TLZReason,TJTPhone,TNation,TQQMailbox,TRemarks,TJG)
values('畅嘉伟','男','123835','3140545',3,2,'452226197304102125','湖南','1973-04-10','党员','14563057856','2010-06-21','','','13620573784','壮族','1582442','','中国')
insert into TeaInfo(TName,TSex,TUid,TPwd,[Type],Position,TID,THoome,TCS,TFace,TPhone,TTimeRZ,TTimeLZ,TLZReason,TJTPhone,TNation,TQQMailbox,TRemarks,TJG)
values('陈佳豪','男','128765','3140645',3,2,'452226198407162125','河南','1984-07-16','党员','14563095756','2009-02-22','','','13629573784','壮族','1231846','','中国')
insert into TeaInfo(TName,TSex,TUid,TPwd,[Type],Position,TID,THoome,TCS,TFace,TPhone,TTimeRZ,TTimeLZ,TLZReason,TJTPhone,TNation,TQQMailbox,TRemarks,TJG)
values('张东明','男','123265','3147245',1,2,'452226198804112125','广东佛山','1988-04-11','党员','14563957356','2008-01-31','','','13629673784','壮族','1231843','','中国')
insert into TeaInfo(TName,TSex,TUid,TPwd,[Type],Position,TID,THoome,TCS,TFace,TPhone,TTimeRZ,TTimeLZ,TLZReason,TJTPhone,TNation,TQQMailbox,TRemarks,TJG)
values('陈胜','男','126245','3149545',1,6,'452226199102172125','湖南','1991-02-17','党员','14563095756','2010-04-30','','','13620967784','壮族','1268242','','中国')




insert into EmpType values('员工'),('人事部'),('财务部'),('高层管理')

insert into EmpPosition values('董事长'),('总经理'),('副总经理'),('组长'),('员工')


insert into EmpInfo(EUid,EPwd,EName,ESet,EBirthday,Tid,Pid,EmpNation,EmpFace,EmpIDT,EmpEducate,EWedding,ETell,EPhone,EIDAd,EJG,TRemarks)
 values('1001','123456','张三','男','1992-01-20',4,1,'壮族','党员','452226199201202115','大学毕业','未婚','15235557242','12464745343','广东佛山','中国',''),
('1002','123456','李四','男','1993-10-20',4,2,'壮族','党员','452226199310202115','大学毕业','已婚','15747836353','15366332843','广西来宾','中国',''),
('1003','123456','王五','男','1994-05-13',4,2,'壮族','党员','452226199405132115','大学毕业','已婚','14683675573','15366764457','广东珠海','中国',''),
('1004','123456','艾维诺','男','1994-05-13',4,2,'壮族','党员','452226199405132115','大学毕业','未婚','14680184573','15367443457','广东东莞','中国',''),
('1005','123456','叶明祖','男','1994-07-23',4,2,'壮族','党员','452226199405132115','大学毕业','未婚','14685927573','15366631457','广东广州','中国',''),
('1006','123456','覃贵长','男','1992-04-12',4,2,'汉族','党员','452226199204122115','大学毕业','未婚','14680543573','15368743457','广东深圳','中国',''),
('1007','123456','韦桂荣','女','1993-05-12',4,2,'汉族','党员','452226199305122115','大学毕业','未婚','14680583573','15368321457','广东珠海','中国',''),
('1008','123456','蔡泳潮','男','1989-07-11',1,5,'汉族','党员','452226198907112115','大学毕业','已婚','14686938573','15368323457','湖南','中国',''),
('1009','123456','朱德斌','男','1994-08-16',1,5,'汉族','党员','452226199408162115','大学毕业','未婚','14680583573','15369422457','湖南','中国',''),
('1010','123456','梁立皓','男','1996-01-13',1,5,'汉族','党员','452226199601132115','大学毕业','已婚','14680285573','15368442457','广西桂林','中国',''),
('1011','123456','黄欣','女','1991-04-13',1,5,'壮族','党员','452226199104132115','大学毕业','已婚','14683053573','15365217457','广西贵港','中国',''),
('1012','123456','黄明娜','女','1995-07-13',1,5,'壮族','党员','452226199507132115','大学毕业','未婚','14683927473','15366246457','东北','中国',''),
('1013','123456','林鑫','男','1998-09-13',1,5,'汉族','非党员','452226199809132115','大学毕业','未婚','14683853773','15366267457','广东珠海','中国',''),
('1014','123456','覃浩','男','1996-03-16',1,5,'苗族','党员','452226199603162115','大学毕业','未婚','14683675373','15364563457','广东珠海','中国',''),
('1015','123456','苏倩薇','女','1994-01-25',1,5,'苗族','非党员','452226199401252115','大学毕业','已婚','14683578473','15364446457','广东珠海','中国',''),
('1016','123456','秦婷婷','女','1992-02-28',1,5,'汉族','非党员','452226199202282115','大学毕业','未婚','14680573573','15363336457','福建','中国',''),
('1017','123456','谭艳红','女','1993-11-29',1,5,'壮族','党员','452226199311292115','大学毕业','已婚','14682745573','15366642457','四川','中国',''),
('1018','123456','郑广荣','男','1991-10-23',1,5,'壮族','党员','452226199110232115','大学毕业','已婚','14685037573','15367778457','四川','中国',''),
('1019','123456','周志光','男','1987-12-18',1,5,'汉族','党员','452226198712182115','大学毕业','已婚','14684201573','15367774457','河南','中国',''),
('1020','123456','邓天文','男','1988-09-19',1,5,'壮族','非党员','452226198809192115','大学毕业','未婚','14681038573','15363456457','湖南','中国',''),
('1021','123456','冯超','男','1986-07-10',1,5,'壮族','党员','452226198607102115','大学毕业','已婚','14681480573','15362573457','广西来宾','中国',''),
('1022','123456','王若峰 ','男','1985-08-11',1,5,'壮族','非党员','452226198508112115','大学毕业','已婚','14683185573','15366466457','广西来宾','中国',''),
('1023','123456','王丹青','男','1984-04-12',1,5,'汉族','党员','452226198404122115','大学毕业','已婚','14682184573','15367488457','广东佛山','中国',''),
('1024','123456','徐晨曦','男','1983-03-15',1,5,'汉族','党员','452226198303152115','大学毕业','未婚','14683914573','15367738457','广东佛山','中国',''),
('1025','123456','任娟娟','女','1987-06-10',1,5,'壮族','非党员','452226198706102115','大学毕业','未婚','14680174573','15368890457','广东珠海','中国',''),
('1026','123456','王鹏飞','男','1990-01-19',1,5,'汉族','非党员','452226199001192115','大学毕业','未婚','14683947573','15360654457','广东珠海','中国',''),
('1027','123456','尹姗姗 ','女','1994-09-18',1,5,'汉族','非党员','452226199409182115','大学毕业','已婚','14685826573','15369794457','广东东莞','中国',''),
('1028','123456','薛丽娜','女','1992-10-17',1,4,'壮族','党员','452226199210172115','大学毕业','已婚','14685965573','15360734457','广东深圳','中国',''),
('1029','123456','徐振方','男','1996-11-17',1,4,'壮族','非党员','452226199611172115','大学毕业','已婚','14680917573','15368990457','东北','中国',''),
('1030','123456','刘世晓','男','1997-12-12',1,4,'壮族','党员','452226199712122115','大学毕业','已婚','14685737573','15365788457','黑龙江','中国',''),
('1031','123456','梁峰','男','1998-12-11',1,4,'壮族','非党员','452226199812112115','大学毕业','未婚','14689472573','15363689457','广西南宁','中国',''),
('1032','123456','李作健','男','1994-11-10',4,4,'汉族','党员','452226199411102115','大学毕业','未婚','14684038573','15369707457','广西南宁','中国',''),
('1033','123456','周彦楠','男','1996-04-20',4,4,'汉族','非党员','452226199604202115','大学毕业','已婚','14689012573','15360084457','湖南','中国',''),
('1034','123456','李志刚','男','1993-03-31',4,5,'壮族','党员','452226199303312115','大学毕业','已婚','14683802573','15360854457','广东珠海','中国',''),
('1035','123456','李超然','男','1990-11-30',2,5,'壮族','非党员','452226199011302115','大学毕业','已婚','14683482573','15369702457','广东珠海','中国',''),
('1036','123456','李晓曦','女','1991-12-30',2,5,'壮族','党员','452226199112302115','大学毕业','已婚','14683598573','15360285457','广东珠海','中国',''),
('1037','123456','张依然','女','1993-09-21',2,5,'苗族','党员','452226199309212115','大学毕业','未婚','14685937573','15360683457','广东珠海','中国',''),
('1038','123456','李天竹','男','1997-07-29',2,5,'壮族','非党员','452226199707292115','大学毕业','未婚','14685038573','15360862457','湖南','中国',''),
('1039','123456',' 卢家辉','男','1994-06-28',2,5,'壮族','党员','452226199406282115','大学毕业','未婚','14683084573','15360482457','福建','中国',''),
('1040','123456','王君凯','男','1992-05-21',2,5,'壮族','党员','452226199205212115','大学毕业','未婚','14683648773','15369524457','福建','中国',''),
('1041','123456','李刚 ','男','1991-07-25',2,5,'汉族','党员','452226199107252115','大学毕业','已婚','14683603573','15367489457','四川','中国',''),
('1042','123456','蔡芸菲','女','1989-04-27',2,5,'汉族','党员','452226198904272115','大学毕业','已婚','14683065873','15360275457','湖南','中国',''),
('1043','123456','孙海燕','女','1988-02-25',2,5,'汉族','党员','452226198802252115','大学毕业','已婚','14683585573','15360227457','黑龙江','中国',''),
('1044','123456','刘琪琛','女','1987-01-22',2,5,'汉族','非党员','452226198701222115','大学毕业','未婚','14685937573','15366693457','福建','中国',''),
('1045','123456','贺若龙','男','1986-01-23',2,5,'汉族','非党员','452226198601232115','大学毕业','已婚','14687038573','15366865457','广东珠海','中国',''),
('1046','123456','刘璇','男','1984-02-14',2,5,'壮族','党员','452226198402142115','大学毕业','未婚','14680582573','15364479457','广东珠海','中国',''),
('1047','123456','曹光辉','男','1986-03-21',4,2,'壮族','党员','452226198603212115','大学毕业','已婚','14685038573','15362689457','广东珠海','中国','')






insert into AdminInfo values('韦邦杠','宿舍管理','1234567','123456',1),
('韦邦杠','图书管理','1234567','123456',1),
('李天赐','图书管理','1234567','123456',1),
('陆佳慧','教师管理','1234567','123456',1),
('李刚','宿舍管理','1234567','123456',1),
('孙海燕','宿舍管理','1234567','123456',1),
('李云飞','宿舍管理','1234567','123456',1),
('王群凯','宿舍管理','1234567','123456',1),
('贺若龙','宿舍管理','1234567','123456',1),
('刘世巧','宿舍管理','1234567','123456',1),
('王鹏飞','宿舍管理','1234567','123456',1),
('冯超','宿舍管理','1234567','123456',1),
('邓天文','宿舍管理','1234567','123456',1),
('李作健','宿舍管理','1234567','123456',1),
('薛丽娜','宿舍管理','1234567','123456',1),
('秦婷婷','宿舍管理','1234567','123456',1),
('苏倩薇','宿舍管理','1234567','123456',1),
('王若峰','宿舍管理','1234567','123456',1),
('艾维诺','宿舍管理','1234567','123456',1),
('李志刚','宿舍管理','1234567','123456',1),
('徐振方','宿舍管理','1234567','123456',1),
('尹姗姗','宿舍管理','1234567','123456',1),
('郑广荣','宿舍管理','1234567','123456',1),
('徐振方','宿舍管理','1234567','123456',1),
('李晓曦','宿舍管理','1234567','123456',1),
('蔡芸菲','宿舍管理','1234567','123456',1),
('张依然','宿舍管理','1234567','123456',1),
('李超然','宿舍管理','1234567','123456',1)	 