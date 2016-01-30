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
using BibleProject.Classes.Text.Loader;
using BibleProject.Classes.Database.Queries;
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
        Usercontrols.FileLoading fileLoading = new Usercontrols.FileLoading();
        
        private async void frm_MainWindow_Load(object sender, EventArgs e)
        {
            MemoryStorage.EnglishKjv = new List<BibleCollection>();
            MemoryStorage.ChineseSimplified = new List<BibleCollection>();
            MemoryStorage.ChineseTraditional = new List<BibleCollection>();

            MemoryStorage.BookList = new List<BookCollection>();
            MemoryStorage.FullDataCollection = new List<FullCollection>();

            this.p_Contents.Controls.Clear();
            this.p_Contents.Controls.Add(fileLoading);


            int curFile = 0;

            fileLoading.SetProgressMaximum(2);


            await Task.Run(() =>
            {
                List<IFlatFile> file = new List<IFlatFile>();

                file.Add(new EnglishKjv());
                file.Add(new ChineseSimplified());
                file.Add(new ChineseTraditional());

                foreach (var f in file)
                {
                    f.LoadIntoMemory();
                    // Delegate the control as 'c', activate c's Method asynchronously without causing illegal cross-thread call.
                    fileLoading.Async(c => { c.IncrementProgress(); });
                    curFile++;
                }
            });

            MessageBox.Show("Successfully loaded all files into memory");
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


        public void ResetButtons()
        {
            this.btn_Create.Async(c => { c.Enabled = true; });
            this.pbar_CurrentInsertionProgress.Async(c => { c.Value = 0; });
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

                        int MaximumEntries = 0;

                        foreach (var fdc in MemoryStorage.FullDataCollection)
                        {
                            MaximumEntries += fdc.BibleCollection.Count();
                        }

                        this.pbar_CurrentInsertionProgress.Maximum = MaximumEntries;

                        await Task.Run(() =>
                        {
                            for (int i = 0; i < MemoryStorage.FullDataCollection.Count(); i++)
                            {
                                DatabaseConnection.Open(this, server, database, username, password, (QueryLanguage)i);
                            }
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

                            for (int i = 0; i < MemoryStorage.FullDataCollection.Count(); i++)
                            {
                                DatabaseConnection.Open(this, connectionString, (QueryLanguage)i);
                            }
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