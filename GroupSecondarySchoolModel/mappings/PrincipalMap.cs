using FluentNHibernate.Mapping;
using GroupSecondarySchoolModel.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupSecondarySchoolModel.mappings
{
    public class PrincipalMap : EntityBaseMap<Principal>
    {
        public PrincipalMap()
        {
            Map(x => x.FullName);
            References(x => x.School);
        }
    }
}
