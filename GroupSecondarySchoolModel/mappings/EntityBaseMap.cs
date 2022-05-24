using FluentNHibernate.Mapping;
using GroupSecondarySchoolModel.Repos.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupSecondarySchoolModel.mappings
{
    public class EntityBaseMap<T> : ClassMap<T> where T : EntityBase
    {
        public EntityBaseMap()
        {
            Id(x => x.ID);
        }
    }
}
