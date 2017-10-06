using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forum
{
    public partial class Post : Form
    {
        public Post(Form1 fo)
        {
            Form1 f = fo;
            Post previous;
            List<Post> next;
            InitializeComponent();
            Popup enter = new Popup(this, f);
            this.Show();
        }

        private void authorTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        public void setAuthor(String a)
        {
            authorTextBox.Text = a;
        }
        public void setMessage(String a)
        {
            messageTextBox.Text = a;
        }
        public bool getFilled()
        {
            if (authorTextBox.Text != "")
            {
                return true;
            } else
            {
                return false;
            }
        }
    }
}
