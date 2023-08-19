using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ReportApp_Server
{
    //add CD
    public partial class ReportApp_Server : Form
    {
        public string FolderPath { get; set; }
        public string CD { get; set; }
        public ReportApp_Server()
        {
            InitializeComponent();
        }
        //Name of file, path, fetching_date, isfetched, clientname, isGenerated, isPrinted, generation_datetime, printed_datetime
        List<string> NewFiles = new List<string>();
        
        string MyConnectionString = "Server=localhost;Database=ReportApp;Uid=root;Pwd=";
        List<string> getReportsData()
        {
            List<string> DBFiles = new List<string>();
            MySqlConnection con = new MySqlConnection(MyConnectionString);
            MySqlCommand cmd;
            MySqlDataReader dr;
            con.Open();
            try
            {
                status.Text = "Searching";
                //getting all file names form database
                cmd = con.CreateCommand();
                cmd.CommandText = "SELECT FileName FROM `reportfiles`";
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    //adding all files in list and return
                    DBFiles.Add(dr.GetString("FileName"));
                    Console.WriteLine(dr.GetString("FileName"));
                }
                dr.Close();
                //cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                status.Text = ex.ToString();
                //throw ex;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                    status.Text = "Files uploaded successfully";
                }
            }
            return DBFiles;
        }
        void insertData(string fileName, string path, string CD)
        {
            MySqlConnection con = new MySqlConnection(MyConnectionString);
            MySqlCommand cmd;
            con.Open();
            try
            {
                status.Text = "Files uploading";
                cmd = con.CreateCommand();
                cmd.CommandText = "INSERT INTO reportfiles (FileName, Path, CD) values (@FileName, @Path, @CD)";
                cmd.Parameters.AddWithValue("@FileName", fileName);
                cmd.Parameters.AddWithValue("@Path", path);
                cmd.Parameters.AddWithValue("@CD", CD);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                status.Text = ex.ToString();
                //throw ex;
            }
            finally
            {
                if(con.State == ConnectionState.Open)
                {
                    con.Close();
                    status.Text = "Files uploaded successfully";
                }
            }
        }
        

        //function to Fetch buttom
        private void FetchBtn_Click(object sender, EventArgs e)
        {
            ReportApp_Server form = new ReportApp_Server();
            List<string> DBFiles = form.getReportsData();
            List<string> DuplicateFiles = new List<string>();
            NewFiles.Clear();
            //list<string> = form.getReportsData();
            form.FolderPath = textBoxForPath.Text;
            Console.WriteLine(form.FolderPath);
            FolderPathView.Text = form.FolderPath;
            try
            {
                var list = Directory.GetFiles(form.FolderPath, "*.csv", SearchOption.AllDirectories);
                
                if (list.Length > 0)
                {
                    TotalFileCountLabel.Text = list.Length.ToString();
                    foreach (var item in list)
                    {
                        var fileName = getFileName(item);
                        if (!DBFiles.Contains(fileName))
                        {
                            //adding only new files
                            NewFiles.Add(fileName);
                            Console.WriteLine("new file : " + fileName);
                        }
                        else
                        {
                            DuplicateFiles.Add(fileName);
                        }
                    }
                    if (DuplicateFiles.Count > 0)
                    {
                        ViewDupBtn.Visible = true;
                    }
                    DuplicateFileCountLabel.Text = DuplicateFiles.Count.ToString();
                    NewFileCountLabel.Text = NewFiles.Count.ToString();
                    TotalFileCountLabel.Text = DBFiles.Count.ToString();
                    if (NewFiles.Count>0)
                    {
                        CDInpBox.Text = getCDName(form.FolderPath);
                        UploadBtn.Enabled = true;
                        CDInpBox.Enabled = true;
                        //FetchBtn.Enabled = false;
                    }
                    status.Text = "";
                }
                else
                {
                    TotalFileCountLabel.Text = "";
                    status.Text = "Folder Not have CSV files!";
                }
            }
            catch(Exception ex)
            {
                status.Text =  ex.ToString();
            }
        }


        //function to upload buttom
        private void UploadBtn_Click(object sender, EventArgs e)
        {
            ReportApp_Server form = new ReportApp_Server();
            form.FolderPath = textBoxForPath.Text;
            form.CD = CDInpBox.Text;
            try
            {
                status.Text = "Files uploading";
                FetchBtn.Enabled = false;
                NewFiles.ForEach(fn => form.insertData(fn, form.FolderPath+"\\"+fn, form.CD));
                //NewFiles.ForEach(fn => Console.WriteLine(fn+ form.FolderPath + "\\"+fn));
                NewFileCountLabel.Text = "0";
            }
            catch (Exception ex)
            {
                status.Text = ex.ToString();
            }
            finally
            {
                status.Text = "Files uploaded";
                FetchBtn.Enabled = true;
                UploadBtn.Enabled = false;
                CDInpBox.Enabled = false;
                NewFiles.Clear();
            }   
        }
        string getFileName(string path)
        {
            var filePathArray = path.Split('\\');
            return filePathArray[filePathArray.Length - 1].Split('.')[0];  
        }
        string getCDName(string path)
        {
            var filePathArray = path.Split('\\');
            return filePathArray[filePathArray.Length - 1];
        }

    }
}
