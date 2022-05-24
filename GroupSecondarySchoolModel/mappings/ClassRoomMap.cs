using FluentNHibernate.Mapping;
using GroupSecondarySchoolModel.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupSecondarySchoolModel.mappings
{
    public class ClassRoomMap : EntityBaseMap<ClassRoom>
    {
        public ClassRoomMap()
        {
            Map(x => x.Name);
            HasMany(x => x.Students);
            HasOne(x => x.Teacher);
            References(x => x.School);
        }
    }
}
