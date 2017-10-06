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
    public partial class Popup : Form
    {
        Post origin;
        Form1 f;
        public Popup(Post p, Form1 fo)
        {
            origin = p;
            InitializeComponent();
            this.Show();
            f = fo;
        }

        private void Popup_Load(object sender, EventArgs e)
        {

        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            origin.setAuthor(authorEntry.Text);
            origin.setMessage(messageEntry.Text);
            this.Hide();
            f.addDiscussion(origin);
        }
    }
}
