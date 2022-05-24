// See https://aka.ms/new-console-template for more information
using GroupSecondarySchoolModel.models;
using GroupSecondarySchoolModel.Repos.DataBaseManager;
using GroupSecondarySchoolModel.Repos.Helper;



Console.WriteLine("Object Relatonal Mapper Class");

FluentNHibernateHelper.OpenSession();

var school1 = new School
{
    ID = 1,
    Name = "Tarepet Secondary School",
    Address = "Kpansia, Bayelsa State"
};

DataBaseManager.AddSchool(school1);



Console.ReadLine();
