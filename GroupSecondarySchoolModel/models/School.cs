using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupSecondarySchoolModel.models
{
    //a school has a name,address, list of teachers and students
    public class School
    {
        public School()
        {

        }

        public School(int id, string name, string address, Principal principal)
        {
            Id = id;
            Name = name;
            Address = address;
            Principal = principal;
            //Teachers = teachers;
            //Students = students;
        }
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string Address { get; set; }
        public virtual Principal Principal { get; set; }
        public virtual List<Teacher> Teachers { get; set; }
        public virtual List<Student> Students { get; set; }
    }
}
