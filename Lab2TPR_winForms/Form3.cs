﻿
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2TPR_winForms
{
    //Form3 - форма вывода результатов (по сути вообще не менял с первой лабы, она просто принимает DataTable от этапа вычислений и выводит её)
    public partial class Form3 : Form
    {
        public DataTable datatableResult;

        public Form3()
        {
            InitializeComponent();
            datatableResult = new DataTable();
        }
        public Form3(DataTable datatable)
        {
            InitializeComponent();
            this.datatableResult = datatable;
        }


        private void Form3_Load(object sender, EventArgs e)
        {
            dataGridView_results.DataSource = datatableResult;
        }
    }
}
