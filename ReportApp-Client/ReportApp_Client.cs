using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static ReportApp_Client.ReportApp_Client;
using System.Linq;
using MySqlX.XDevAPI;
using ReportApp_Client.Properties;
//using FastReport;

namespace ReportApp_Client
{
    public partial class ReportApp_Client : Form
    {
        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataReader dr;
        public ReportApp_Client()
        {
            InitializeComponent();
            con = new MySqlConnection(MyConnectionString);
            loadCDs();
        }
        public class Files
        {
            public Files() { }
            public string Id { set; get; }
            public string FileName { set; get; }
            public string Path { set; get; }

        }
        public class Item
        {
            public Item() { }
            public string Text { set; get; }
            public int Value { set; get; }
        }
        string MyConnectionString = "Server=localhost;Database=ReportApp;Uid=root;Pwd=";
        void loadCDs()
        {
            List<Item> items = new List<Item>();
            try
            {
                con.Open();
                cmd = con.CreateCommand();
                cmd.CommandText = "SELECT DISTINCT(CD) FROM `reportfiles`";
                dr = cmd.ExecuteReader();
                var count = 1;
                while (dr.Read())
                {
                    items.Add(new Item() { Text = dr.GetString("CD"), Value = count });
                    count++;
                }
                count = 0;
                dr.Close();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                con.Close();
            }
            CDDropDown.DataSource = items;
            CDDropDown.DisplayMember = "Text";
            CDDropDown.ValueMember = "Value";
        }
        List<Files> RecievedFiles = new List<Files>();
        private void SendRequestBtn_Click(object sender, EventArgs e)
        {
            RecievedFiles.Clear();
            //int RequestNumOfFile = (int)Math.Round(NumOfFileBox.Value);
            Item RequestedCD = (Item)CDDropDown.SelectedItem;
            string ClientName = "TestName";
            List<string> FilesToDownload = new List<string>();
            CheckedListForRecivedFile.Items.Clear();
            //listViewForRecivedFile.Columns.Add("File Name");

            try
            {
                con.Open();
                cmd = con.CreateCommand();
                //cmd.CommandText = "SELECT * FROM `reportfiles` WHERE CD = '@CD' and ClientName IS NULL LIMIT @RequestNumOfFile";
                cmd.CommandText = "SELECT * FROM `reportfiles` WHERE CD = '" + RequestedCD.Text + "' AND ClientName IS NULL AND IsFetched IS FALSE";
                Console.WriteLine(cmd.CommandText);

                //cmd.Parameters.AddWithValue("@CD", RequestedCD.Text);
                //cmd.Parameters.AddWithValue("@RequestNumOfFile", RequestNumOfFile);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine( "file id : "+dr.GetInt16("Id"));
                    //adding all files in list and return
                    RecievedFiles.Add(new Files { Id = dr.GetString("Id"), FileName = dr.GetString("FileName"), Path = dr.GetString("Path") });
                    Console.WriteLine("path: " + dr.GetString("Path"));
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                StatusBox.Text = ex.ToString();
            }
            finally
            {
                con.Close();
            }
            if (UpdateClient(RecievedFiles, ClientName))
            {
                RecievedFileCount.Text = RecievedFiles.Count.ToString();
                if (RecievedFiles.Count>0)
                {
                    FileDownloadBtn.Enabled = true;
                }
                foreach (var file in RecievedFiles)
                {
                    string[] item = {file.FileName, file.Path};
                    //listViewForRecivedFile.Items.Add(new ListViewItem(item));
                    CheckedListForRecivedFile.Items.Add(file.FileName);
                    FilesToDownload.Add(file.Path);
                }
            }
            else
            {
                RecievedFiles.Clear();
                FilesToDownload.Clear();
            }
        }
        bool UpdateClient(List<Files> RecievedFiles, string clientName)
        {
            return true;
        }

        private void FileDownloadBtn_Click(object sender, EventArgs e)
        {
            foreach (var file in CheckedListForRecivedFile.CheckedItems)
            {
                DownloadFile(file.ToString());
            }
        }
        void DownloadFile(string fileName)
        {
            Console.WriteLine(fileName);
            foreach (var file in this.RecievedFiles)
            {
                if(file.FileName == fileName)
                {   if(UpdateStatus(fileName, "IsFetched", "Fetched_On"))
                    {
                        File.Copy(file.Path, "C:\\Users\\dSMART-PC-16\\source\\repos\\ReportApp\\ReportApp-Client\\Resources\\Downloads\\" + Path.GetFileName(fileName));
                    }
                }
            }
            
        }
        bool UpdateStatus(string fileName, string StatusName, string updateTime)
        {
            string ClientName = "TestName";
            try
            {
                DateTime now = DateTime.Now;
                var date = now.Date.ToString().Split(' ');
                //2023 - 08 - 22 17:06:28
                var formateDate = date[0].Split('/');
                var dateTime = formateDate[2]+"-"+ formateDate[1] +"-"+ formateDate[0] + " " + date[1];
                //var dateTime = SqlDbType.DateTime;
                Console.WriteLine(dateTime);
                con.Open();
                cmd = con.CreateCommand();
                cmd.CommandText = "UPDATE `reportfiles` SET `" + updateTime + "` = '" + dateTime + "', `" + StatusName + "` = '1', `ClientName` = '" + ClientName + "' WHERE `reportfiles`.`FileName` = '" + fileName + "'";
                if(cmd.ExecuteNonQuery()>0){
                  return true;
                }
            } catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return false;
        }

        private void GenerateBtn_Click(object sender, EventArgs e)
        {
            GeneratePDFForm generatePDFForm = new GeneratePDFForm("TestName");
            generatePDFForm.Show();

        }


        //generating PDF

        //private void btnGeneratePDF_Click(object sender, EventArgs e)
        //{
        //    DataSet ds = new DataSet();
        //    DataTable dt = new DataTable("myTable");
        //    dt.Columns.Add("col1");
        //    dt.Columns.Add("col2");
        //    for (int i = 0; i < 10; i++)
        //    {
        //        DataRow dr = dt.NewRow();
        //        dr[0] = (i + 1).ToString();
        //        dr[1] = "1.1";
        //        dt.Rows.Add(dr);
        //    }
        //    ds.Tables.Add(ConvertCSVtoDataTable("../../Resources/book1_csv.csv"));
        //    ds.Tables[0].TableName = "csv";

        //    Report rpt = new Report();
        //    rpt.Load("../../Report/KE_Bill_Print.frx");
        //    rpt.RegisterData(ds.Tables[0], "csv");
        //    rpt.Prepare();
        //    FastReport.Export.PdfSimple.PDFSimpleExport export = new FastReport.Export.PdfSimple.PDFSimpleExport();
        //    rpt.Export(export, @"D:\Downloads\" + DateTime.Now.Ticks + ".pdf");
        //}

        //public static DataTable ConvertCSVtoDataTable(string strFilePath)
        //{
        //    DataTable dt = new DataTable();
        //    using (StreamReader sr = new StreamReader(strFilePath))
        //    {
        //        string[] headers = sr.ReadLine().Split('|');
        //        foreach (string header in headers)
        //        {
        //            if (!dt.Columns.Contains(header))
        //                dt.Columns.Add(header);
        //            else
        //                dt.Columns.Add(DateTime.Now.Ticks.ToString());
        //        }
        //        while (!sr.EndOfStream)
        //        {
        //            string[] rows = sr.ReadLine().Split('|');
        //            DataRow dr = dt.NewRow();
        //            for (int i = 0; i < headers.Length; i++)
        //            {
        //                dr[i] = rows[i];
        //            }
        //            dt.Rows.Add(dr);
        //        }
        //    }
        //    return dt;
        //}
    }
}
