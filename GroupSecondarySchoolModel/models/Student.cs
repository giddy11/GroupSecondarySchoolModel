using GroupSecondarySchoolModel.Repos.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupSecondarySchoolModel.models
{
    //Students has an Id, name, offers many subjects and belongs to a classroom
    public class Student : EntityBase
    {
        public virtual string FullName { get; set; }
        public virtual List<Subject> Subjects { get; set; }
        public virtual School School { get; set; }
        public virtual ClassRoom Class { get; set; }
    }
}
