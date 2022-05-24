using FluentNHibernate.Mapping;
using GroupSecondarySchoolModel.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupSecondarySchoolModel.mappings
{
    public class SchoolMap : EntityBaseMap<School>
    {
        public SchoolMap()
        {
            Map(x => x.Name);
            Map(x => x.Address);
            HasMany(x => x.Teachers);
            HasMany(x => x.Students);

        }
    }
}
