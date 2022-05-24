using FluentNHibernate.Mapping;
using GroupSecondarySchoolModel.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupSecondarySchoolModel.mappings
{
    public class PrincipalMap : ClassMap<Principal>
    {
        public PrincipalMap()
        {
            Id(x => x.Id);
            Map(x => x.FullName);
            References(x => x.School);
        }
    }
}
