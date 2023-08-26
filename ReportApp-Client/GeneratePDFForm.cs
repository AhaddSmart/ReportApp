using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ReportApp_Client.ReportApp_Client;
using static System.Windows.Forms.ListViewItem;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;
using FastReport;
using System.IO;
using FastReport.Preview;
using static System.Net.Mime.MediaTypeNames;
using FastReport.Utils;
using MySqlX.XDevAPI;

namespace ReportApp_Client
{
    public partial class GeneratePDFForm : Form
    {
        string clientName;
        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataReader dr;
        List<string> RecievedFiles = new List<string>();
        public GeneratePDFForm(string ClientName)
        {
            clientName = ClientName;
            InitializeComponent();
            con = new MySqlConnection(MyConnectionString);
            loadDownloadedFiles();
        }
        string MyConnectionString = "Server=localhost;Database=ReportApp;Uid=root;Pwd=";
        public void loadDownloadedFiles()
        {
                //GeneratelistView generatelistView = new GeneratelistView();
            //ListViewItem listViewItem = new ListViewItem();
            try
            {
                Console.WriteLine("function called : " + clientName);
                con.Open();
                cmd = con.CreateCommand();
                cmd.CommandText = "SELECT * FROM `reportfiles` where ClientName ='" + clientName + "' AND IsGenerated IS FALSE";
                dr = cmd.ExecuteReader();
                
                if (dr != null)
                {
                    while (dr.Read())
                    {
                        Console.WriteLine(dr.GetString("FileName"));
                        string fileName = dr.GetString("FileName");

                        RecievedFiles.Add(fileName);
                    }
                }
                dr.Close();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                con.Close();
            }
            GenenrateFileDataGridView.DataSource = RecievedFiles.Select(x => new { FileName = x }).ToList();

            DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
            btnColumn.HeaderText = "Action";
            btnColumn.Text = "Generate";
            btnColumn.UseColumnTextForButtonValue = true;
            GenenrateFileDataGridView.Columns.Insert(1, btnColumn);
        }
        private void GenenrateFileDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Console.WriteLine("Button clicked");
            if (GenenrateFileDataGridView.Columns[e.ColumnIndex].HeaderText == "Action")
            {
                string fileName = GenenrateFileDataGridView.Rows[e.RowIndex].Cells["FileName"].Value.ToString();
                Console.WriteLine("Button clicked for row: " + fileName);
                GeneratePDF(fileName);
            }
        }
        private void GeneratePDF(string fileName)
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable("myTable");
            dt.Columns.Add("col1");
            dt.Columns.Add("col2");
            for (int i = 0; i < 10; i++)
            {
                DataRow dr = dt.NewRow();
                dr[0] = (i + 1).ToString();
                dr[1] = "1.1";
                dt.Rows.Add(dr);
            }
            ds.Tables.Add(ConvertCSVtoDataTable("../../Resources/Downloads/"+ fileName));
            ds.Tables[0].TableName = "csv";
            Report rpt = new Report();
            rpt.Load("../../Report/KE_Bill_Print.frx");
            rpt.RegisterData(ds.Tables[0], "csv");
            rpt.Prepare();

            PreviewControl previewControl = new PreviewControl();
            previewControl.Size = new Size(800, 600); // Set the desired size
            previewControl.Location = new Point(10, 10); // Set the desired location
            previewControl.AddTab(rpt, "abc.csv");
            //previewControl.Load();
            // Add the preview control to your form's Controls collection
            GeneratePDFslabel.Visible = false;
            GenenrateFileDataGridView.Visible = false;
            Controls.Add(previewControl);

            //FastReport.Export.PdfSimple.PDFSimpleExport export = new FastReport.Export.PdfSimple.PDFSimpleExport();
            //rpt.Export(export, @"D:\Downloads\" + DateTime.Now.Ticks + ".pdf");
        }

        public static DataTable ConvertCSVtoDataTable(string strFilePath)
        {
            DataTable dt = new DataTable();
            using (StreamReader sr = new StreamReader(strFilePath))
            {
                string[] headers = sr.ReadLine().Split('|');
                foreach (string header in headers)
                {
                    if (!dt.Columns.Contains(header))
                        dt.Columns.Add(header);
                    else
                        dt.Columns.Add(DateTime.Now.Ticks.ToString());
                }
                while (!sr.EndOfStream)
                {
                    string[] rows = sr.ReadLine().Split('|');
                    DataRow dr = dt.NewRow();
                    for (int i = 0; i < headers.Length; i++)
                    {
                        dr[i] = rows[i];
                    }
                    dt.Rows.Add(dr);
                }
            }
            return dt;
        }

    }
}
 
