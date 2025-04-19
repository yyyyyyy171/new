using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace 图书管理系统
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            string connectionString = "Server=localhost;Database=library;Uid=root;Pwd=123456;";

            try
            {
                // 创建数据库连接对象
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    // 打开数据库连接
                    connection.Open();
                    Console.WriteLine("数据库连接成功！");

                    // 执行简单的 SQL 查询
                    string query = "SELECT 1";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // 执行查询并获取结果
                        object result = command.ExecuteScalar();
                        Console.WriteLine("查询结果: " + result);
                    }
                }
            }
            catch (Exception ex)
            {
                // 处理异常
                Console.WriteLine("数据库连接失败: " + ex.Message);
            }

            if (Environment.OSVersion.Version.Major >= 6)
            {
                SetProcessDPIAware();
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();

           
    }
}
