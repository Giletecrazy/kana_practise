using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Collections.Specialized.BitVector32;
using System.Data.SqlClient;
using System.Threading;

namespace kanji_learner
{
    public partial class SQLInstall : Form
    {
        public SQLInstall()
        {
            InitializeComponent();
            backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                Thread.Sleep(1000);
                string connectionString = "Server=(LocalDb)\\MSSQLLocalDB;Integrated Security=true;";
                string scriptPath = Environment.CurrentDirectory + "\\SQLQuery1.sql";

                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Read and execute the entire script
                    string script = File.ReadAllText(scriptPath);
                    var createdb = new SqlCommand("Create Database bdJPWRITINGSYSTEM", connection);
                    createdb.ExecuteNonQuery();
                    Thread.Sleep(1000);
                    using (var command = new SqlCommand(script, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }

                this.Invoke(new MethodInvoker(delegate { label1.Text = "First app setup done"; }));
                Thread.Sleep(5000);
                Application.Restart();
            }
            catch (Exception ex)
            {
                
            }
        }
    }
}
