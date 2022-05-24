using FluentNHibernate.Mapping;
using GroupSecondarySchoolModel.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupSecondarySchoolModel.mappings
{
    public class SubjectMap : EntityBaseMap<Subject>
    {
        public SubjectMap()
        {
            Map(x => x.Name);
            HasManyToMany(x => x.Teachers);
        }
    }
}
