using NHibernate;
using NHibernate.Cfg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBLib.Utils
{
    public class MyHiberate
    {
        private static readonly ISessionFactory sessionFactory;

        private static string HibernateHbmXmlFileName = "hibernate.cfg.xml";

        //private static ISession session

        static MyHiberate()

        {

            sessionFactory = new Configuration().Configure().BuildSessionFactory();

        }

        public static ISessionFactory getSessionFactory()

        {

            return sessionFactory;

        }

        public static ISession getSession()

        {

            return sessionFactory.OpenSession();

        }

        public static void closeSessionFactory()

        {



        }
    }
}
