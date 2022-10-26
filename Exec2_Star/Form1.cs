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
            //列數是否<=0或整數
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
            string result= BecomeLeftTriangle(row);



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

			if (isInt != true)
			{
				throw new Exception("列數必須整數");
			}
			if (row <= 0)
			{
				throw new Exception("列數需大於0");
			}
			if (row > 11 || row < 0)
			{
				throw new Exception("只能輸入1~10");
			}
			else
			{
				return row;
			}
		}
        private string BecomeLeftTriangle(int row) 
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
			
			string input = GetRow();

			int row = 0;
			try
			{
				row = CanBeCount(input);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			
			string result = BecomeRightTriangle(row);

			textShow.Text = result;
			labelShow.Text = result;
		}
		private string BecomeRightTriangle(int row)
		{
			string result = string.Empty;
			for (int i = 1; i <= row; i++)
			{
				result += new string(' ', row-i)+new string('*', i) + "\r\n";
			}
			return result;
		}
		private void button3_Click(object sender, EventArgs e)
        {

			
			string input = GetRow();
			
			int row = 0;
			try
			{
				row = CanBeCount(input);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			
			string result = BecomeTriangle(row);

			textShow.Text = result;
			labelShow.Text = result;

		}
		private string BecomeTriangle(int row)
		{
			string result = string.Empty;
			for (int i = row; i >0; i--)
			{
                result += new string(' ', i-1) + new string('*', row - i) + "*\r\n";
			}
			return result;
		}
    }
}
