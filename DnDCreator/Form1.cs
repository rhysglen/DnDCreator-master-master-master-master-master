﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DnDCreator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Form f = this.FindForm();
            f.Controls.Remove(this);
            charScreen1 cs1 = new charScreen1();
            f.Controls.Add(cs1);

        }
    }
}
