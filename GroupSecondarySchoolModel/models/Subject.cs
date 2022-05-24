using GroupSecondarySchoolModel.Repos.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupSecondarySchoolModel.models
{
    //has a name, many teachers can handle that particular subject
    public class Subject : EntityBase
    {
        public virtual string Name { get; set; }
        public virtual List<Teacher> Teachers { get; set; }
    }
}
