using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupSecondarySchoolModel.Repos.Helper
{
    public static class FluentNHibernateHelper
    {
        private static ISessionFactory _sessionFactory;
        private static ISessionFactory SessionFactory
        {
            get
            {
                if (_sessionFactory is null)
                {
                    InitialiseSessionFactory();
                }
                return _sessionFactory;
            }
        }

        public static void InitialiseSessionFactory()
        {
            _sessionFactory = Fluently.Configure() //Initialise session factory
                .Database(MsSqlConfiguration.MsSql2012.ConnectionString(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\GroupSchoolModel.mdf;Integrated Security=True;Connect Timeout=30"))
                .Mappings(map => map.FluentMappings.AddFromAssemblyOf<Program>())
                .ExposeConfiguration(cfg => new SchemaExport(cfg).Create(true, true))
                .BuildSessionFactory();
        }

        public static ISession OpenSession()
        {
            return SessionFactory.OpenSession();
        }

        public static ISession CloseSession()
        {
            return null;
        }
    }
}
