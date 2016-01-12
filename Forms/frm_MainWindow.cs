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
using BibleProject.Classes;
using BibleProject.Classes.Text;
using BibleProject.Classes.Objects;
using BibleProject.Forms.FormExtensions;
using BibleProject.Classes.Database;

namespace BibleProject.Forms
{
    public partial class frm_MainWindow : Form
    {
        public frm_MainWindow()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Uses the LoadBookData(int) method to display the HTML content in the web browser. 
        /// </summary>
        /// <param name="id"></param>
        /*private void GetBookDataForDisplaying(int id)
        {
            string FullBookName = TextConverters.GetFullBookNameFromId(id);
            wb_BibleBrowserWindow.Navigate("about:blank");
            if (wb_BibleBrowserWindow.Document != null)
            {
            wb_BibleBrowserWindow.Document.Write(String.Empty);
            }
            wb_BibleBrowserWindow.DocumentText = MemoryStorage.BibleLoaderClass.LoadBookData(id);
            this.Text = TextConverters.GetDisplayString(FullBookName) + " — King James Version";
        }*/

        Usercontrols.MySQL mySql = new Usercontrols.MySQL();
        Usercontrols.SQLServer sqlServer = new Usercontrols.SQLServer();


        private void frm_MainWindow_Load(object sender, EventArgs e)
        {
            MemoryStorage.Bible = new List<BibleCollection>();
            MemoryStorage.BookList = new List<BookCollection>();
            MemoryStorage.FullDataCollection = new List<FullCollection>();
            MemoryStorage.BibleLoaderClass = new FlatFileLoader();
            MemoryStorage.BibleLoaderClass.LoadBibleIntoMemory();
            //Loader.LoadMemoryContentsIntoDatabase();
            this.cb_DatabaseType.SelectedIndex = 0;

        }

        /*
        private void cb_BibleBookList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int cItem = ((ComboBoxExtension)((ComboBox)sender).SelectedItem).ComboId;
            GetBookDataForDisplaying(cItem);
        }*/

        private void cb_DatabaseType_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.p_Contents.Controls.Clear();
            switch (cb_DatabaseType.SelectedItem.ToString())
            {
                case "MySQL":
                    {
                        this.p_Contents.Controls.Add(mySql);
                    }
                    break;
                case "SQL Server":
                    {
                        this.p_Contents.Controls.Add(sqlServer);
                    }
                    break;
                default:
                    {
                        MessageBox.Show("Incorrect option selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;
            }
        }


        public void SetProgressBar()
        {
            this.pbar_CurrentInsertionProgress.Async(a => { a.PerformStep(); });
        }

        private async void btn_Create_Click(object sender, EventArgs e)
        {
            switch (cb_DatabaseType.SelectedItem.ToString())
            {
                case "MySQL":
                    {
                        string username = mySql.GetUsername();
                        string password = mySql.GetPassword();
                        string server = mySql.GetServerName();
                        string database = mySql.GetDatabase();

                        this.btn_Create.Enabled = false;
                        this.pbar_CurrentInsertionProgress.Maximum = MemoryStorage.FullDataCollection[0].BibleCollection.Count();

                        await Task.Run(() =>
                        {
                            DatabaseConnection.Open(this, server, database, username, password);
                        });
                        this.btn_Create.Enabled = true;
                        MessageBox.Show("Finished uploading to the MySQL database.", "Yay!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;
                case "SQL Server":
                    {
                        string connectionString = sqlServer.GetConnectionString();

                        this.pbar_CurrentInsertionProgress.Maximum = MemoryStorage.FullDataCollection[0].BibleCollection.Count();

                        this.btn_Create.Enabled = false;
                        await Task.Run(() =>
                        {
                            DatabaseConnection.Open(this, connectionString);
                        });

                        this.btn_Create.Enabled = true;
                        MessageBox.Show("Finished uploading to the SQL Server database.", "Yay!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;
                default:
                    {
                        MessageBox.Show("Incorrect option selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;
            }
        }
    }
}