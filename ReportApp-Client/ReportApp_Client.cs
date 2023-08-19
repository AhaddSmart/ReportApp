using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;
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
        public class Item
        {
            public Item() { }
            //public string Value { set; get; }
            public string Text { set; get; }
        }
        string MyConnectionString = "Server=localhost;Database=ReportApp;Uid=root;Pwd=";
        void loadCDs()
        {
            List<Item> items = new List<Item>();
            items.Add(new Item() { Text = "displayText1" });
            items.Add(new Item() { Text = "displayText2"});
            CDDropDown.DataSource = items;
            CDDropDown.DisplayMember = "Text";
            CDDropDown.ValueMember = "Text";
        }
        private void SendRequestBtn_Click(object sender, EventArgs e)
        {
            int RequestNumOfFile = (int)Math.Round(NumOfFileBox.Value);
            string ClientName = "TestName";
            List<string> RecievedFiles = new List<string>();
            try
            {
                con.Open();
                cmd = con.CreateCommand();
                cmd.CommandText = "SELECT * FROM `reportfiles` WHERE IsGenerated = false and ClientName IS NULL LIMIT " + RequestNumOfFile;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine( "file id : "+dr.GetInt16("Id"));
                    //adding all files in list and return
                    RecievedFiles.Add(dr.GetString("Path"));
                    //dr.GetString("FileName"),
                    Console.WriteLine("path: " + dr.GetString("Path"));
                }
                dr.Close();
                //cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                //throw ex;
                StatusBox.Text = ex.ToString();
            }
            finally
            {
                con.Close();
            }
            if (UpdateClient(RecievedFiles, ClientName))
            {
                RecievedFileCount.Text = RecievedFiles.Count.ToString();
            }
            else
            {
                RecievedFiles.Clear();
            }
        }
        bool UpdateClient(List<string> RecievedFiles, string clientName)
        {
            //MySqlConnection con = new MySqlConnection(MyConnectionString);
            foreach(var filePath in RecievedFiles)
            {
                if (!UpdateClientHelper(filePath, clientName))
                {
                    return false;
                }
            }
            return true;
        }
        bool UpdateClientHelper(string filePath, string clientName)
        {
            try
            {
                con.Open();
                cmd = con.CreateCommand();
                cmd.CommandText = "UPDATE `reportfiles` SET `ClientName` = @ClientName, `IsGenerated` = '1' WHERE `reportfiles`.`Path` = @Path";
                cmd.Parameters.AddWithValue("@Path", filePath);
                cmd.Parameters.AddWithValue("@ClientName", clientName);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                return false;
            } catch(Exception ex){
                StatusBox.Text = ex.ToString();
                return false;
            }
            finally
            {
                con.Close();
            }
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
