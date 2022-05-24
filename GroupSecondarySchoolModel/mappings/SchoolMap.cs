using FluentNHibernate.Mapping;
using GroupSecondarySchoolModel.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupSecondarySchoolModel.mappings
{
    public class SchoolMap : ClassMap<School>
    {
        public SchoolMap()
        {
            Id(x => x.Id);
            Map(x => x.Name);
            Map(x => x.Address);
            HasOne(x => x.Principal);
            HasMany(x => x.Teachers);
            HasMany(x => x.Students);

        }
    }
}
