using FluentNHibernate.Mapping;
using GroupSecondarySchoolModel.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupSecondarySchoolModel.mappings
{
    public class StudentMap : EntityBaseMap<Student>
    {
        public StudentMap()
        {
            Map(x => x.FullName);
            HasMany(x => x.Subjects);
            References(x => x.School);
            References(x => x.Class);
        }
    }
}
