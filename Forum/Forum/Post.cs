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
        Form1 f;
        Post previous;
        List<Post> next;
        public Post(Form1 fo, bool t)
        {
            f = fo;
            InitializeComponent();
            if (t == true)
            {
                Popup enter = new Popup(this, f);
            }
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

        private void replyButton_Click(object sender, EventArgs e)
        {
            Popup newPopup = new Popup(new Post(f, false), f);
        }
    }
}
