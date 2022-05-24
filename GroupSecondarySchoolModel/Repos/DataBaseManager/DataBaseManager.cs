using GroupSecondarySchoolModel.models;
using GroupSecondarySchoolModel.Repos.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupSecondarySchoolModel.Repos.DataBaseManager
{
    internal class DataBaseManager
    {
        public static void AddSchool(School school)
        {
            using (var session = FluentNHibernateHelper.OpenSession())
            {
                using var transaction = session.BeginTransaction();
                session.Save(school);
                transaction.Commit();
            }
        }

        public static void DeleteSchool(School school)
        {
            using (var session = FluentNHibernateHelper.OpenSession())
            {
                using var transaction = session.BeginTransaction();
                session.Delete(school);
                transaction.Commit();
            }
        }

        public static School ReadSchool(int id)
        {
            using (var session = FluentNHibernateHelper.OpenSession())
            {
                var school = session.Get<School>(id);
                return school;
            }
        }

        public static List<ClassRoom> ReadAllClass()
        {
            using (var session = FluentNHibernateHelper.OpenSession())
            {
                var classRooms = session.Query<ClassRoom>().ToList();
                return classRooms;
            }
        }

        public static List<ClassRoom> ReadAllClassBySchoolId(int schoolId)
        {
            using (var session = FluentNHibernateHelper.OpenSession())
            {
                var classRooms = session.Query<ClassRoom>().Where(x => x.School.ID == schoolId);
                return classRooms.ToList();
            }
        }

        public static List<Teacher> ReadAllTeacherBySchoolId(int schoolId)
        {
            using (var session = FluentNHibernateHelper.OpenSession())
            {
                var teachers = session.Query<Teacher>().Where(x => x.School.ID == schoolId);
                return teachers.ToList();
            }
        }
    }
}
