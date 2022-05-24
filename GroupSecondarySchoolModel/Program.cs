// See https://aka.ms/new-console-template for more information
using GroupSecondarySchoolModel.models;
using GroupSecondarySchoolModel.Repos.DataBaseManager;
using GroupSecondarySchoolModel.Repos.Helper;



Console.WriteLine("Object Relatonal Mapper Class");

FluentNHibernateHelper.OpenSession();

#region Add School
var school1 = new School {Name = "Tarepet Secondary School", Address = "Kpansia, Bayelsa State"};

DataBaseManager<School>.AddItem(school1);
#endregion

#region Add Principal

var principal = new Principal { FullName = "Mr Ebuka", School = school1 };

DataBaseManager<Principal>.AddItem(principal);

#endregion

#region Add Teachers

var teacher1 = new Teacher { FullName = "Mr.Abraham", School = school1};
var teacher2 = new Teacher { FullName = "Mr.Murphy", School = school1 };
var teacher3 = new Teacher { FullName = "Mr.Ifeanyi", School = school1 };
var teacher4 = new Teacher { FullName = "Mr.Giddy", School = school1 };
var teacher5 = new Teacher { FullName = "Miss Felicia", School = school1 };
var teacher6 = new Teacher { FullName = "Mr.David", School = school1 };

DataBaseManager<Teacher>.AddItem(teacher1);
DataBaseManager<Teacher>.AddItem(teacher2);
DataBaseManager<Teacher>.AddItem(teacher3);
DataBaseManager<Teacher>.AddItem(teacher4);
DataBaseManager<Teacher>.AddItem(teacher5);
DataBaseManager<Teacher>.AddItem(teacher6);

#endregion

#region Add ClassRooms
var Classes1 = new ClassRoom { Name = "Junior Secondary School One", School = school1 };
var Classes2 = new ClassRoom { Name = "Junior Secondary School Two", School = school1 };
var Classes3 = new ClassRoom { Name = "Junior Secondary School Three", School = school1 };
var Classes4 = new ClassRoom { Name = "Senior Secondary School One", School = school1 };
var Classes5 = new ClassRoom { Name = "Senior Secondary School Two", School = school1 };
var Classes6 = new ClassRoom { Name = "Senior Secondary School Three", School = school1 };

DataBaseManager<ClassRoom>.AddItem(Classes1);
DataBaseManager<ClassRoom>.AddItem(Classes2);
DataBaseManager<ClassRoom>.AddItem(Classes3);
DataBaseManager<ClassRoom>.AddItem(Classes4);
DataBaseManager<ClassRoom>.AddItem(Classes5);
DataBaseManager<ClassRoom>.AddItem(Classes6);

#endregion

#region Add Students

var student1 = new Student { FullName = "Caroline Ogbara", Class = Classes1, School = school1 };
var student2 = new Student { FullName = "Gideon Edoghotu", Class = Classes1, School = school1 };

var student3 = new Student { FullName = "Iruoma Dear", Class = Classes2, School = school1 };
var student4 = new Student { FullName = "Hyscient Boy", Class = Classes2, School = school1 };

var student5 = new Student { FullName = "Samuel Ogbole", Class = Classes3, School = school1 };
var student6 = new Student { FullName = "Osborn Guy", Class = Classes3, School = school1 };

var student7 = new Student { FullName = "Dozie Gift", Class = Classes4, School = school1 };
var student8 = new Student { FullName = "Victory Chiefson", Class = Classes4, School = school1 };

var student9 = new Student { FullName = "Chuks Ebe", Class = Classes5, School = school1 };
var student10 = new Student { FullName = "Dozie Eli", Class = Classes5, School = school1 };

var student11 = new Student { FullName = "Caro Ben", Class = Classes6, School = school1 };
var student12 = new Student { FullName = "Favour Levi", Class = Classes6, School = school1 };


DataBaseManager<Student>.AddItem(student1);
DataBaseManager<Student>.AddItem(student2);
DataBaseManager<Student>.AddItem(student3);
DataBaseManager<Student>.AddItem(student4);
DataBaseManager<Student>.AddItem(student5);
DataBaseManager<Student>.AddItem(student6);
DataBaseManager<Student>.AddItem(student7);
DataBaseManager<Student>.AddItem(student8);
DataBaseManager<Student>.AddItem(student9);
DataBaseManager<Student>.AddItem(student10);
DataBaseManager<Student>.AddItem(student11);
DataBaseManager<Student>.AddItem(student12);

#endregion

#region Add Subjects

var subject1 = new Subject { Name = "Mathematics", };
var subject2 = new Subject { Name = "English"};
var subject3 = new Subject { Name = "Biology" };
var subject4 = new Subject { Name = "Chemistry" };
var subject5 = new Subject { Name = "Physics" };
var subject6 = new Subject { Name = "Business Study" };
var subject7 = new Subject { Name = "C.R.K"};
var subject8 = new Subject { Name = "Health Education" };

DataBaseManager<Subject>.AddItem(subject1);
DataBaseManager<Subject>.AddItem(subject2);
DataBaseManager<Subject>.AddItem(subject3);
DataBaseManager<Subject>.AddItem(subject4);
DataBaseManager<Subject>.AddItem(subject5);
DataBaseManager<Subject>.AddItem(subject6);
DataBaseManager<Subject>.AddItem(subject7);
DataBaseManager<Subject>.AddItem(subject8);


#endregion




Console.ReadLine();
