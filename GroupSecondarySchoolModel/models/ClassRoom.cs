using GroupSecondarySchoolModel.Repos.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupSecondarySchoolModel.models
{
    //has an id, a name, list of students and handled by one teacher
    public class ClassRoom : EntityBase
    {
        public virtual string Name { get; set; }
        public virtual List<Student> Students { get; set; }
        public virtual Teacher Teacher { get; set; }
        public virtual School School { get; set; }
    }
}
