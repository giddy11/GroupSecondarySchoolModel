using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupSecondarySchoolModel.models
{
    //has a name, many teachers can handle that particular subject
    public class Subject
    {
        public Subject()
        {
        }
        public Subject(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual List<Teacher> Teachers { get; set; }
        public virtual List<Student> Students { get; set; }
    }
}
