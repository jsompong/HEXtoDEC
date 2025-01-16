using System;
using CsvHelper;
using System.Globalization;
using static System.Console;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace WFAnet
   
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
         //    public static string ReadAllText(string path);
        InitializeComponent();
            
       
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           // var fs = new FileStream(@"D:\WFAnet\bin\Debug\sinewaveHEX.csv", FileMode.Open);
            var fs = new FileStream(@"D:\WFAnet\bin\Debug\sinewaveHEX1.csv", FileMode.Open);
            var xreader = new StreamReader(fs);
            while (!xreader.EndOfStream)
            {
                var line = xreader.ReadLine();
              //  WriteLine(line?.ToUpperInvariant());
                string hexdecim = line?.ToUpperInvariant();
             //   MessageBox.Show(hexdecim);                  // แสดง เป็น กลุ่ม
            }
            xreader.Close();

            //  จาก data :  อ่าน ฐาน 16 เป็น ฐาน 10            // Install-Package CsvHelper
           //  var reader = new StreamReader("sinewaveHEX.csv");
            var reader = new StreamReader("sinewaveHEX1.csv");

            var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
            var records = csv.GetRecords<dynamic>();                         // read CSV file
                                                                             // output
            foreach (var r in records)
            {
                //WriteLine($"{r.FirstName,-15}{r.LastName,-10}{r.JoinedDate,15}{r.Salary,15}{r.Active,5}");
                //WriteLine($"{r.HexValue,-15}");
                //string hexdecim = $"{r.HexValue,-15}";
                //   string hexdecim = $"{r.HexCol1}{r.HexCol2}{r.HexCol3}{r.HexCol4}";
                string hexdecim = $"{r.HexColumn}";
                //MessageBox.Show(hexdecim);
                HEXlistBox.Items.Add(hexdecim);
                int decValue = int.Parse(hexdecim, System.Globalization.NumberStyles.HexNumber);
                string decim = Convert.ToString(decValue);
                //  MessageBox.Show(decim);
                DEClistBox.Items.Add(decim);
            }
            reader.Close();
            //try
            //{
            //  Block of code to try
            //}
            //catch (Exception e)
            //{
            //  Block of code to handle errors
            //}


            try
            {
                //string contents = File.ReadAllText(@"C:\temp\readme1.txt");
                string contents = File.ReadAllText(@"D:\WFAnet\bin\Debug\sinewaveHEX.csv");
               // Console.WriteLine(contents);
               //  MessageBox.Show(contents);              // แสดง เป็นกลุ่ม
            }
         //   catch (FileNotFoundException e)
            catch (Exception)
            {
                //Console.WriteLine(e.Message);
            }

        }

        private void HEXlistBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DEClistBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
