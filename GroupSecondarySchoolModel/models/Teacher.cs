
namespace GroupSecondarySchoolModel.models
{
    //has a name, belongs to one school , can teach many subjects
    public class Teacher
    {
        public Teacher()
        {
        }
        public Teacher(int id, string fullName, School school)
        {
            Id = id;
            FullName = fullName;
            School = school;
        }

        public virtual int Id { get; set; }
        public virtual string FullName { get; set; }
        public virtual School School { get; set; }
        public virtual List<Subject> Subjects { get; set; }
    }
}
