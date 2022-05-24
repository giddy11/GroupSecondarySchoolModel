using GroupSecondarySchoolModel.Repos.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupSecondarySchoolModel.models
{
    //has a name, belongs to one school , can teach many subjects
    public class Teacher : EntityBase
    {
        public virtual string FullName { get; set; }
        public virtual School School { get; set; }
        public virtual List<Subject> Subjects { get; set; }
    }
}
