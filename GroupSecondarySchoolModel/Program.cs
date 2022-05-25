// See https://aka.ms/new-console-template for more information
using GroupSecondarySchoolModel.models;
using GroupSecondarySchoolModel.Repos.DataBaseManager;
using GroupSecondarySchoolModel.Repos.Helper;



Console.WriteLine("Object Relatonal Mapper Class");

FluentNHibernateHelper.OpenSession();

var school1 = new School();
var principal = new Principal();
var students = new List<Student>();
var classRooms = new List<ClassRoom>();
var teachers = new List<Teacher>();
var subjects = new List<Subject>();

#region Add School

school1 = new School(0, "Tarepet Secondary School", "Kpansia Bayelsa", principal);

DataBaseManager<School>.AddItem(school1);
#endregion

#region Add ClassRooms
var classes1 = new ClassRoom(0, "Junior Secondary School One", school1);
var classes2 = new ClassRoom(1, "Junior Secondary School Two", school1);
var classes3 = new ClassRoom(2, "Junior Secondary School Three", school1);
var classes4 = new ClassRoom(3, "Senior Secondary School One", school1);
var classes5 = new ClassRoom(4, "Senior Secondary School Two", school1);
var classes6 = new ClassRoom(5, "Senior Secondary School Three", school1);

classRooms = new List<ClassRoom>() { classes1, classes2, classes3, classes4, classes5, classes6 };
foreach (var item in classRooms)
{
    DataBaseManager<ClassRoom>.AddItem(item);
}
#endregion

#region Add Teachers
var teacher1 = new Teacher(0, "Mr.Abraham", school1);
var teacher2 = new Teacher(1, "Mr.Murphy", school1);
var teacher3 = new Teacher(2, "Mr.Ifeanyi", school1);
var teacher4 = new Teacher(3, "Mr.Giddy", school1);
var teacher5 = new Teacher(4, "Miss Felicia", school1);
var teacher6 = new Teacher(5, "Mr.David", school1);

teachers = new List<Teacher>() { teacher1, teacher2, teacher3, teacher4, teacher5, teacher6 };
foreach (var item in teachers)
{
    DataBaseManager<Teacher>.AddItem(item);
}
#endregion


#region Add Principal

principal = new Principal(0, "Mr Ebuka", school1);

DataBaseManager<Principal>.AddItem(principal);

#endregion


#region Add Students
var student1 = new Student (0, "Caroline Ogbara", school1, classes1);
var student2 = new Student (1, "Gideon Edoghotu", school1, classes1);

var student3 = new Student (2, "Iruoma Dear", school1, classes2);
var student4 = new Student (3, "Hyscient Boy", school1, classes2);

var student5 = new Student(4, "Samuel Ogbole", school1, classes3);
var student6 = new Student(5, "Osborn Guy", school1, classes3);

var student7 = new Student(6, "Dozie Gift", school1, classes4);
var student8 = new Student(7, "Victory Chiefson", school1, classes4);

var student9 = new Student(8, "Chuks Ebe", school1, classes5);
var student10 = new Student(9, "Dozie Eli", school1, classes5);

var student11 = new Student(10, "Caro Ben", school1, classes6);
var student12 = new Student(11, "Favour Levi", school1, classes6);

students = new List<Student>() { student1, student2, student3, student4, student5, student6, student7, student8, student9, student10, student11, student12 };

foreach (var item in students)
{
    DataBaseManager<Student>.AddItem(item);
}
#endregion

#region Add Subjects
var subject1 = new Subject(0, "Mathematics");
var subject2 = new Subject(1, "English");
var subject3 = new Subject(2, "Biology");
var subject4 = new Subject(3, "Chemistry");
var subject5 = new Subject(4, "Physics");
var subject6 = new Subject(5, "Business Study");
var subject7 = new Subject(6, "C.R.K");
var subject8 = new Subject(7, "Health Education");

subjects = new List<Subject>() { subject1, subject2, subject3, subject4, subject5, subject6, subject7, subject8 };

foreach (var item in subjects)
{
    DataBaseManager<Subject>.AddItem(item);
}
#endregion




Console.ReadLine();
