﻿using System;
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
    public partial class Form1 : Form
    {
        List<Discussion> discussions = new List<Discussion>();
        public Form1()
        {
            InitializeComponent();
        }

        private void start_Click(object sender, EventArgs e)
        {
            Post newP = new Post(this);
        }
        public void newDiscussion(Post curr)
        {
            
            discussions.Add(new Discussion(curr));
        }
    }
}
