// See https://aka.ms/new-console-template for more information
using GroupSecondarySchoolModel.models;
using GroupSecondarySchoolModel.Repos.DataBaseManager;
using GroupSecondarySchoolModel.Repos.Helper;



Console.WriteLine("Object Relatonal Mapper Class");

FluentNHibernateHelper.OpenSession();

#region Add School
var school1 = new School {Name = "Tarepet Secondary School", Address = "Kpansia, Bayelsa State"};

DataBaseManager.AddSchool(school1);
#endregion

#region Add Principal

var principal = new Principal { FullName = "Mr Ebuka", School = school1 };

DataBaseManager.AddPrincipal(principal);

#endregion


#region Add ClassRooms
var Classes1 = new ClassRoom { Name = "Junior Secondary School One", School = school1 };
var Classes2 = new ClassRoom { Name = "Junior Secondary School Two", School = school1 };
var Classes3 = new ClassRoom { Name = "Junior Secondary School Three", School = school1 };
var Classes4 = new ClassRoom { Name = "Senior Secondary School One", School = school1 };
var Classes5 = new ClassRoom { Name = "Senior Secondary School Two", School = school1 };
var Classes6 = new ClassRoom { Name = "Senior Secondary School Three", School = school1 };

DataBaseManager.AddClasses(Classes1);
DataBaseManager.AddClasses(Classes2);
DataBaseManager.AddClasses(Classes3);
DataBaseManager.AddClasses(Classes4);
DataBaseManager.AddClasses(Classes5);
DataBaseManager.AddClasses(Classes6);
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


DataBaseManager.AddStudents(student1);
DataBaseManager.AddStudents(student2);
DataBaseManager.AddStudents(student3);
DataBaseManager.AddStudents(student4);
DataBaseManager.AddStudents(student5);
DataBaseManager.AddStudents(student6);
DataBaseManager.AddStudents(student7);
DataBaseManager.AddStudents(student8);
DataBaseManager.AddStudents(student9);
DataBaseManager.AddStudents(student10);
DataBaseManager.AddStudents(student11);
DataBaseManager.AddStudents(student12);

#endregion






Console.ReadLine();
