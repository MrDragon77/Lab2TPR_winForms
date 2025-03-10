using ConjTable.Demo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1TPR_winForms
{
    public partial class Form2 : Form
    {
        public DataSet datasetTemp;
        public Form2()
        {
            InitializeComponent();
            datasetTemp = new DataSet();
        }
        public Form2(DataSet dataset, int strategyNum)
        {
            InitializeComponent();
            this.datasetTemp = dataset;
            numericUpDown_tableID.Maximum = strategyNum;
            numericUpDown_tableID.Minimum = 1;
        }

        private void numericUpDown_tableID_ValueChanged(object sender, EventArgs e)
        {
            dataGridView_strategy.DataSource = datasetTemp.Tables["s" + numericUpDown_tableID.Value.ToString()];
            dataGridView_dohod.DataSource = datasetTemp.Tables["d" + numericUpDown_tableID.Value.ToString()];
            dataGridView_strategy.Update();
            dataGridView_dohod.Update();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dataGridView_strategy.DataSource = datasetTemp.Tables["s1"];
            dataGridView_dohod.DataSource = datasetTemp.Tables["d1"];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void dataGridView_strategy_SelectionChanged(object sender, EventArgs e)
        {
            dataGridView_strategy.Update();
        }

        private void dataGridView_dohod_SelectionChanged(object sender, EventArgs e)
        {
            dataGridView_dohod.Update();
        }

        private void button_Graph_Click(object sender, EventArgs e)
        {

            //Application.Run(new MainForm(datasetTemp.Tables["s" + numericUpDown_tableID.Value.ToString()]));
            MainForm GraphForm = new MainForm(datasetTemp.Tables["s" + numericUpDown_tableID.Value.ToString()]);
            GraphForm.ShowDialog();
        }
    }
}
