--PREDEFINED RECORDS--
INSERT INTO
    characters(charac_id,charac_name,charac_type,charac_desc)
VALUES
    (1,'Yuh Gie','Boy','Yuh Gie is one of the artist who colored the characters, entities and created layouts. He is known for his unyielding commitment to realism artworks.'),
    (2,'Baddey','Girl','Baddey is one of the artist who created, drew, and colored the maps, characters, and building designs. She is known for her skills in digital art and excelling to academics.');

INSERT INTO 
    items(item_id,item_name,item_price,item_desc,item_class)
VALUES
    (1001,'College Blouse',380.00,'School Uniform for Girls','Top'),
    (1002,'College Skirt',230.00,'School Uniform for Girls','Bottom'),
    (1003,'College Barong',365.00,'School Uniform for Boys','Top'),
    (1004,'College Pants',360.00,'School Uniform for Boys','Bottom'),
    (1005,'PE T-Shirt',175.00,'PE School Uniform for Any Gender','Top'),
    (1006,'PE Jogging Pants',270.00,'PE School Uniform for Any Gender','Bottom'),
    (1007,'School ID Lace',75.00,'Part of School Uniform for ID','Neck'),
    (1008,'Shoes',10.00,'A beautiful black shoes!','Shoes'),
    (1009,'Necklace Unisex',5.00,'Estetik Starter Pack','Neck'),
    (1010,'Crop Top',70.00,'Estetik Starter Pack for Girls Crop Top','Top'),
    (1011,'Short-Shorts',70.00,'Estetik Starter Pack for Girls Short Shorts','Bottom'),
    (1012,'Sando',70.00,'Estetik Starter Pack for Boys Sando','Top'),
    (1013,'Short-z',70.00,'Estetik Starter Pack for Boys Short','Bottom'),
    (1014,'CICS Org Shirt',500.00,'Org Shirt of AICSS (2022-2023) ','Top'),
    (1015,'Denim Pants',150.00,'Normal Unisex Pants','Bottom'),
    (1016,'Bluenelas', 20.00,'Estetik Starter Pack for Boys Shoes','Shoes'),
    (1017,'Pinkinelas', 20.00,'Estetik Starter Pack for Boys Shoes','Shoes'),
    (1018,'Wayt Shoes', 20.00,'White unisex rubber shoes','Shoes');

INSERT INTO
    day_tasks(day_task_id,day_name,day_task_clue,day_task_hint,day_garment_type)
VALUES
    (1,'Monday','Did you know that in room number, the Hundreds(100) indicate the floor, and the Ones(1) indicate the sequence','Hint: Go to the CECS building in the left side, navigate through the 4th floor in elevator then find your room.','Normal Day'),
    (2,'Tuesday','May these OLD treasures be considered as such, yet hold the HIGHEST esteem and regard of the university.','Hint: Head to the Old Building, specifically in the highest floor and find someone to speak with. Seek and you shall see!','Normal Day'),
    (3,'Wednesday','Did you know that in the elevator part of our school that is the entrance and the exit is front face of building. Use the proper entrance and exit, whether you are on the ground or FIFTH floor.','Hint: Head to the Left Building or CECS office in the Fifth floor!','Wash Day'),
    (4,'Thursday','As a first year, it is hard to navigate the offices but asking is not that hard right?','Hint: Go to the first floor of Cecs building near the elevator and you shall see what you are seeking.','Normal Day'),
    (5,'Friday','In the room for healing, where health stuffs are made, seek the answer where the Old echoes and Above the Ground unfolds.' ,'Hint: Head to the Old Building, and above the ground goes in the second floor where you shall find the clinic!','PE Day');

INSERT INTO
    achievements(achievement_id,ach_name,ach_desc)
VALUES
    (1,'First Step Journey','Successfully initiated your first day in the university.' ),
    (2,'Midweek Explorer','Embraced the freedom of a casual Wednesday.' ),
    (3,'Week‘s Triumph','Completed a rewarding week‘s journey.' ),
    (4,'Monday Seeker','Expertly navigated and sought the rooms of CECS Building.' ),
    (5,'Tuesday Wayfarer','Navigated, located, and accomplished the task to find the 3 Golden Treasures and the Library in the OLD Building.' ),
    (6,'Wednesday Finder','Mastered the art of navigating and seeking the rooms of CECS Building.' ),
    (7,'Thursday Trailblazer','Successfully asked, located, and navigated the registrar‘s office.' ),
    (8,'Friday Code Cracker','Unraveled the secrets and cracked the code to find the Clinic in OLD Building.' ),
    (9,'A True Red Spartan, Indeed!','Successfully accomplished all tasks!!!' ),
    (10,'Garments Collector','Buy all the garments available in the closet section' );

INSERT INTO 
    tasks(task_id,task_name,reward,day_task_id,achievement_id)
VALUES
    (1,'Seek Day, Monday!',200.00,1,4),
    (2,'Navigate, Locate, and Ask this Tuesday Ahu!',200.00,2,5),
    (3,'Seek Day, Wednesday!',200.00,3,6),
    (4,'Ask, Locate, and Navigate this Thursday Ahu!',200.00,4,7),
    (5,'Crack the code, cuz its Friday!',200.00,5,8),
    (6,'Your First day Starts Now.',400.00,1,1),
    (7,'Wednesday is a Free Day.',200.00,3,2),
    (8,'Embark on a rewarding week‘s journey.',100.00,5,3),
    (9,'Complete all tasks',100.00,5,9),
    (10,'Unlock all Garments',100.00,null,10);
    
--EXAMPLE USER INPUT RECORDS--
INSERT INTO 
students(sr_code,password,in_game_name,first_name,last_name,gender,current_money,charac_id)
VALUES
('22-32542','d','razecc29','John Razec','Agno','Male',560.00,1),
('22-35492','ddd','auclinn','Bernadette','Awatin','Female',560.00,2),
('22-37394','@cr001k1','crls.brk','Carlos Yajie','Fetizanan','Male',840.00,1),
('23-33787','aaaaa','AAguilar','Angelika','Aguila','Female',755.00,2),
('22-31258','m213!@#kd','jeyy','Jos','Hua','Male',755.00,1),
('22-35120','001ko#4','melvin','Daryl','Alo','Male',755.00,1),
('22-38748','ap','april_','Aprill','Aprril','Female',655.00,2),
('22-35628','arQuil0','Sheena','She','Na','Female',655.00,1),
('22-35610','d','rochelle','Achinza','Rochille','Male',560.00,1),
('22-34005','helloworld','Awit','La','Theo','Male',560.00,1);

INSERT INTO student_items(sr_code,item_id,is_owned) 
VALUES
 ('22-32542',1003,true),
 ('22-32542',1004,true),
 ('22-32542',1005,true),
 ('22-32542',1006,true),
 ('22-32542',1007,true),
 ('22-32542',1008,true),
 ('22-32542',1009,true),
 ('22-32542',1012,true),
 ('22-32542',1013,true),
 ('22-32542',1014,true),
 ('22-32542',1015,true),
 ('22-32542',1016,true),
 ('22-32542',1018,true),
 
 ('22-35492',1001,true),
 ('22-35492',1002,true),
 ('22-35492',1005,true),
 ('22-35492',1006,true),
 ('22-35492',1007,true),
 ('22-35492',1008,true),
 ('22-35492',1009,true),
 ('22-35492',1010,true),
 ('22-35492',1011,true),
 ('22-35492',1014,true),
 ('22-35492',1015,true),
 ('22-35492',1017,false),
 ('22-35492',1018,true),

 ('22-37394',1003,true),
 ('22-37394',1004,true),
 ('22-37394',1005,false),
 ('22-37394',1006,false),
 ('22-37394',1007,true),
 ('22-37394',1008,true),
 ('22-37394',1009,false),
 ('22-37394',1012,false),
 ('22-37394',1013,false),
 ('22-37394',1014,true),
 ('22-37394',1015,true),
 ('22-37394',1016,false),
 ('22-37394',1018,true),

('23-33787',1001,true),
('23-33787',1002,true),
('23-33787',1005,false),
('23-33787',1006,false),
('23-33787',1007,true),
('23-33787',1008,true),
('23-33787',1009,false),
('23-33787',1010,false),
('23-33787',1011,false),
('23-33787',1014,false),
('23-33787',1015,false),
('23-33787',1017,false),
('23-33787',1018,false),

('22-31258',1003,true),
('22-31258',1004,true),
('22-31258',1005,false),
('22-31258',1006,false),
('22-31258',1007,true),
('22-31258',1008,true),
('22-31258',1009,false),
('22-31258',1012,false),
('22-31258',1013,false),
('22-31258',1014,false),
('22-31258',1015,false),
('22-31258',1016,false),
('22-31258',1018,false),

('22-35120',1003,true),
('22-35120',1004,true),
('22-35120',1005,false),
('22-35120',1006,false),
('22-35120',1007,true),
('22-35120',1008,true),
('22-35120',1009,false),
('22-35120',1012,false),
('22-35120',1013,false),
('22-35120',1014,false),
('22-35120',1015,false),
('22-35120',1016,false),
('22-35120',1018,false),

('22-38748',1001,true),
('22-38748',1002,true),
('22-38748',1005,false),
('22-38748',1006,false),
('22-38748',1007,true),
('22-38748',1008,true),
('22-38748',1009,false),
('22-38748',1010,false),
('22-38748',1011,false),
('22-38748',1014,true),
('22-38748',1015,true),
('22-38748',1017,false),
('22-38748',1018,true),

('22-35628',1003,true),
('22-35628',1004,true),
('22-35628',1005,false),
('22-35628',1006,false),
('22-35628',1007,true),
('22-35628',1008,true),
('22-35628',1009,false),
('22-35628',1012,false),
('22-35628',1013,false),
('22-35628',1014,true),
('22-35628',1015,true),
('22-35628',1016,false),
('22-35628',1018,true),

('22-35610',1003,true),
('22-35610',1004,true),
('22-35610',1005,true),
('22-35610',1006,true),
('22-35610',1007,true),
('22-35610',1008,true),
('22-35610',1009,true),
('22-35610',1012,true),
('22-35610',1013,true),
('22-35610',1014,true),
('22-35610',1015,false),
('22-35610',1016,true),
('22-35610',1018,true),

('22-34005',1003,true),
('22-34005',1004,true),
('22-34005',1005,true),
('22-34005',1006,true),
('22-34005',1007,true),
('22-34005',1008,true),
('22-34005',1009,true),
('22-34005',1012,true),
('22-34005',1013,true),
('22-34005',1014,true),
('22-34005',1015,true),
('22-34005',1016,true),
('22-34005',1018,true);

INSERT INTO 
  gameplay_records(gameplay_id,sr_code,status,task_id, date_finished)
VALUES
  (1,'22-32542',TRUE,1,'2023-11-20'),
  (2,'22-32542',TRUE,6,'2023-11-20'),
  (3,'22-32542',TRUE,2,'2023-11-20'),
  (4,'22-32542',TRUE,3,'2023-11-20'),
  (5,'22-32542',TRUE,7,'2023-11-20'),
  (6,'22-32542',TRUE,4,'2023-11-20'),
  (7,'22-32542',TRUE,5,'2023-11-20'),
  (8,'22-32542',TRUE,8,'2023-11-20'),
  (9,'22-32542',TRUE,9,'2023-11-20'),
  (10,'22-32542',TRUE,10,'2023-11-20'),

  (11,'22-35492',TRUE,1,'2023-11-21'),
  (12,'22-35492',TRUE,6,'2023-11-21'),
  (13,'22-35492',TRUE,2,'2023-11-21'),
  (14,'22-35492',TRUE,3,'2023-11-21'),
  (15,'22-35492',TRUE,7,'2023-11-21'),
  (16,'22-35492',TRUE,4,'2023-11-21'),
  (17,'22-35492',FALSE,5,'2023-11-21'),

  (18,'22-37394',TRUE,1,'2023-12-02'),
  (19,'22-37394',TRUE,6,'2023-12-02'),
  (20,'22-37394',TRUE,2,'2023-12-02'),
  (21,'22-37394',FALSE,3,'2023-12-02'),

  (22,'23-33787',TRUE,1,'2023-12-02'),
  (23,'23-33787',TRUE,6,'2023-12-03'),
  (24,'23-33787',FALSE,2,null),

  (25,'22-31258',TRUE,1,'2023-12-04'),
  (26,'22-31258',TRUE,6,'2023-12-04'),
  (27,'22-31258',FALSE,2,null),
  
  (28,'22-35120',TRUE,1,'2023-12-05'),
  (29,'22-35120',TRUE,6,'2023-12-10'),
  (30,'22-35120',FALSE,2,null),

  (31,'22-38748',TRUE,1,'2023-12-10'),
  (32,'22-38748',TRUE,6,'2023-12-10'),
  (33,'22-38748',TRUE,2,'2023-12-10'),
  (34,'22-38748',TRUE,3,'2023-12-10'),
  (35,'22-38748',FALSE,7,null),

  (36,'22-35628',TRUE,1,'2023-12-10'),
  (37,'22-35628',TRUE,6,'2023-12-10'),
  (38,'22-35628',TRUE,2,'2023-12-10'),
  (39,'22-35628',TRUE,3,'2023-12-10'),
  (40,'22-35628',TRUE,7,'2023-12-10'),
  (41,'22-35628',FALSE,4,null),

  (42,'22-35610',TRUE,1,'2023-12-10'),
  (43,'22-35610',TRUE,6,'2023-12-10'),
  (44,'22-35610',TRUE,2,'2023-12-10'),
  (45,'22-35610',TRUE,3,'2023-12-10'),
  (46,'22-35610',TRUE,7,'2023-12-10'),
  (47,'22-35610',TRUE,4,'2023-12-10'),
  (48,'22-35610',FALSE,5,null),

  (49,'22-34005',TRUE,1,'2023-12-10'),
  (50,'22-34005',TRUE,6,'2023-12-10'),
  (51,'22-34005',TRUE,2,'2023-12-10'),
  (52,'22-34005',TRUE,3,'2023-12-10'),
  (53,'22-34005',TRUE,7,'2023-12-10'),
  (54,'22-34005',TRUE,4,'2023-12-10'),
  (55,'22-34005',TRUE,5,'2023-12-10'),
  (56,'22-34005',TRUE,8,'2023-12-10'),
  (57,'22-34005',TRUE,9,'2023-12-10'),
  (58,'22-34005',TRUE,10,'2023-12-10');