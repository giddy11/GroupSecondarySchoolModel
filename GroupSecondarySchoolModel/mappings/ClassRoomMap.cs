using FluentNHibernate.Mapping;
using GroupSecondarySchoolModel.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupSecondarySchoolModel.mappings
{
    public class ClassRoomMap : ClassMap<ClassRoom>
    {
        public ClassRoomMap()
        {
            Id(x => x.Id);
            Map(x => x.Name);
            HasMany(x => x.Students);
            HasOne(x => x.Teacher);
            References(x => x.School);
        }
    }
}
