using FluentNHibernate.Mapping;
using GroupSecondarySchoolModel.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupSecondarySchoolModel.mappings
{
    public class TeacherMap : EntityBaseMap<Teacher>
    {
        public TeacherMap()
        {
            Map(x => x.FullName);
            References(x => x.School);
            HasManyToMany(x => x.Subjects);
        }
    }
}
