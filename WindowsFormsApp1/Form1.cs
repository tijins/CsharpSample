using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private List<String> nameList = new List<String>();


        public Form1()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            var text1 = String.Format("{0}の住所は{1}です",
                name.Text,
                address.Text);
            MessageBox.Show(text1);

            var text2 = $"{name.Text}の住所は{address.Text}です";
            MessageBox.Show(text2);

            nameList.Add(name.Text);
            showList();
        }

        private void showList()
        {
            var sb = new StringBuilder();
            foreach(var text in nameList)
            {
                sb.AppendLine(text);
            }
            list.Text = sb.ToString();

        }
    }
}
