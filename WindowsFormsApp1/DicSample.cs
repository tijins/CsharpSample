using System;
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
    public partial class DicSample : Form
    {
        private Dictionary<String, User> dic = new Dictionary<string, User>();

        public DicSample()
        {
            InitializeComponent();
            dic.Add("鈴木", new User("鈴木", "東京", 1));
            dic.Add("田中", new User("田中", "大阪", 2));
            dic.Add("山田", new User("山田", "名古屋", 3));
        }

        private void yamada_Click(object sender, EventArgs e)
        {
            var user = dic["山田"];
            ShowUser(user);
        }

        private void tanaka_Click(object sender, EventArgs e)
        {
            var user = dic["田中"];
            ShowUser(user);
        }

        private void suzuki_Click(object sender, EventArgs e)
        {
            var user = dic["鈴木"];
            ShowUser(user);
        }

        private void ShowUser(User user)
        {
            var text = $"{user.Name}の住所は{user.Address}年齢は{user.Age}です";
            MessageBox.Show(text);
        }
    }
}
