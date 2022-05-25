using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupSecondarySchoolModel.models
{
    //has an id, a name, list of students and handled by one teacher
    public class ClassRoom
    {
        public ClassRoom()
        {
        }

        public ClassRoom(int id, string name, School school)
        {
            Id = id;
            Name = name;
            School = school;
        }
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual List<Student> Students { get; set; }
        public virtual Teacher Teacher { get; set; }
        public virtual School School { get; set; }
    }
}
