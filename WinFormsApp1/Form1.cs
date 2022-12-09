using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        Excel.Application xlApp;
        Excel.Workbook xlWB;
        Excel.Worksheet xlSheet;
         
    void CreateTable()
        {
            string[] fejl�cek = new string[] {
        "K�rd�s",
        "1. v�lasz",
        "2. v�laszl",
        "3. v�lasz",
        "Helyes v�lasz",
        "k�p"};
        }

        void CreateExcel()
        {
            try
            {
               
                xlApp = new Excel.Application();

              
                xlWB = xlApp.Workbooks.Add(Missing.Value);

                
                xlSheet = xlWB.ActiveSheet;

                
                CreateTable(); 

               
                xlApp.Visible = true;
                xlApp.UserControl = true;
            }
            catch (Exception ex) 
            {
                string errMsg = string.Format("Error: {0}\nLine: {1}", ex.Message, ex.Source);
                MessageBox.Show(errMsg, "Error");

             
                xlWB.Close(false, Type.Missing, Type.Missing);
                xlApp.Quit();
                xlWB = null;
                xlApp = null;
            }
        }
       

}
    

}