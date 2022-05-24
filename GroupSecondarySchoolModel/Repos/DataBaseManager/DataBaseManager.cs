using GroupSecondarySchoolModel.models;
using GroupSecondarySchoolModel.Repos.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupSecondarySchoolModel.Repos.DataBaseManager
{
    internal class DataBaseManager<T>
    {
        public static void AddItem(T item)
        {
            try
            {
                using (var session = FluentNHibernateHelper.OpenSession())
                {
                    using var transaction = session.BeginTransaction();
                    session.Save(item);
                    transaction.Commit();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                FluentNHibernateHelper.CloseSession();
            }
        }

        public static void DeleteItem(T item)
        {
            try
            {
                using (var session = FluentNHibernateHelper.OpenSession())
                {
                    using var transaction = session.BeginTransaction();
                    session.Save(item);
                    transaction.Commit();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                FluentNHibernateHelper.CloseSession();
            }
        }

        public static T ReadItem(T item)
        {
            try
            {
                using (var session = FluentNHibernateHelper.OpenSession())
                {
                    var item1 = session.Get<T>(item);
                    return item1;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return default;
            }
            finally
            {
                FluentNHibernateHelper.CloseSession();
            }
        }

        public static void UpdateItem(T item)
        {
            try
            {
                using (var session = FluentNHibernateHelper.OpenSession())
                {
                    using var transaction = session.BeginTransaction();
                    session.Update(item);
                    transaction.Commit();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                FluentNHibernateHelper.CloseSession();
            }
        }
        }
    }
