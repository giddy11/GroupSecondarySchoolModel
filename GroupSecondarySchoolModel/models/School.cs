using GroupSecondarySchoolModel.Repos.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupSecondarySchoolModel.models
{
    //a school has a name,address, list of teachers and students
    public class School : EntityBase
    {
        public virtual string Name { get; set; }
        public virtual string Address { get; set; }
        public virtual List<Teacher> Teachers { get; set; }
        public virtual List<Student> Students { get; set; }
    }
}
