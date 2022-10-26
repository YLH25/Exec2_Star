using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exec2_Star
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //取得列數
            string input = GetRow();
            //    //列數是否<=0或整數
            int row = 0;
            try
            {
               row = CanBeCount(input);
            }
            catch (Exception ex) 
            { 
                MessageBox.Show(ex.Message);
            }
            //    //星號三角生成
            string result=BecomeStarAnya(row);



            //顯示三角形
            textShow.Text = result;
            labelShow.Text = result;

        }
        private string GetRow()
        {
            string input = textRow.Text;
            return input;
        }
        private int CanBeCount(string input)
        {
            bool isInt = int.TryParse(input, out int row);
            if (row <= 0)
            {
                throw new Exception("列數需大於0");
            }
            if (isInt = false)
            {
                throw new Exception("列數必須整數");
            }
            else
            {
                return row;
            }
        }
        private string BecomeLeftTNO(int row) 
        {
            string result = string.Empty;
            for (int i = 1; i <= row; i++)
            {
                result += new string('*', i) + "\r\n";
            }
            return result;
        }
       

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
