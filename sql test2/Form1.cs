﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sql_test2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'database1DataSet.Table' 資料表。您可以視需要進行移動或移除。
            this.tableTableAdapter.Fill(this.database1DataSet.Table);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tableTableAdapter.Insert(textBox1.Text, textBox2.Text, comboBox1.Text, textBox3.Text);
            this.tableTableAdapter.Fill(this.database1DataSet.Table);
        }
    }
}
