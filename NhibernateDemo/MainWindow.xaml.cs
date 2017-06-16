using DBLib;
using DBLib.Model;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NhibernateDemo
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// 简单的NHibernate实例 运行app实现插入一条数据
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            My();
        }

        private void My()
        {
            TestSaveUser();
        }
        public void TestSaveUser()

        {

            try
            {
                User user = new User();
                //"james","123",'m',20,"00544"
                user.Password = "123";
                user.Username = "Tommy";
                user.Phone = "110";
                user.Gender = 'm';
                user.Age = 1;


                ISession session = DBLib.Utils.MyHiberate.getSession();

                ITransaction tx = session.BeginTransaction();

                session.Save(user);

                tx.Commit();

                session.Close();
                MessageBox.Show("Insert Success:"+user.ToString());
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
