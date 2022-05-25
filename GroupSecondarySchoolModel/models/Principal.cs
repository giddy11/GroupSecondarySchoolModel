using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupSecondarySchoolModel.models
{

    //has a name, belongs to one school
    public class Principal
    {
        public Principal()
        {
        }

        public Principal(int id, string fullName, School school)
        {
            Id = id;
            FullName = fullName;
            School = school;
        }

        public virtual int Id { get; set; }
        public virtual string FullName { get; set; }
        public virtual School School { get; set; }
    }
}
