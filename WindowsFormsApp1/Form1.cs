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
        private BindingList<User> userList = new BindingList<User>();


        public Form1()
        {
            InitializeComponent();
            listBox.DataSource = userList;
            listBox.DisplayMember = "Name";
        }

        private void add_Click(object sender, EventArgs e)
        {
            var text1 = String.Format("{0}の住所は{1}年齢は{2}です",
                name.Text,
                address.Text,
                age.Text);
            MessageBox.Show(text1);

            var text2 = $"{name.Text}の住所は{address.Text}年齢は{age.Text}です";
            MessageBox.Show(text2);

            var user = new User(name.Text, address.Text, int.Parse(age.Text));
            userList.Add(user);
            ClearInput();
        }

        private void ClearInput()
        {
            name.Text = "";
            address.Text = "";
            age.Text = "";
        }

        private void listBox_Click(object sender, EventArgs e)
        {
            var user = listBox.SelectedItem as User;
            if (user != null)
            {
                var text = $"{user.Name}の住所は{user.Address}年齢は{user.Age}です";
                MessageBox.Show(text);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            new DicSample().Show();
        }
    }
}
