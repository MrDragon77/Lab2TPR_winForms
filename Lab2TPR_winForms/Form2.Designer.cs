namespace Lab1TPR_winForms
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            dataGridView_strategy = new DataGridView();
            dataGridView_dohod = new DataGridView();
            numericUpDown_tableID = new NumericUpDown();
            button_SaveChanges = new Button();
            label2 = new Label();
            button_Graph = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView_strategy).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_dohod).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_tableID).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(69, 73);
            label1.Name = "label1";
            label1.Size = new Size(168, 20);
            label1.TabIndex = 0;
            label1.Text = "Таблица вероятностей";
            // 
            // dataGridView_strategy
            // 
            dataGridView_strategy.AllowUserToAddRows = false;
            dataGridView_strategy.AllowUserToDeleteRows = false;
            dataGridView_strategy.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_strategy.Location = new Point(69, 96);
            dataGridView_strategy.Name = "dataGridView_strategy";
            dataGridView_strategy.RowHeadersWidth = 51;
            dataGridView_strategy.RowTemplate.Height = 29;
            dataGridView_strategy.Size = new Size(753, 324);
            dataGridView_strategy.TabIndex = 1;
            dataGridView_strategy.SelectionChanged += dataGridView_strategy_SelectionChanged;
            // 
            // dataGridView_dohod
            // 
            dataGridView_dohod.AllowUserToAddRows = false;
            dataGridView_dohod.AllowUserToDeleteRows = false;
            dataGridView_dohod.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_dohod.Location = new Point(69, 475);
            dataGridView_dohod.Name = "dataGridView_dohod";
            dataGridView_dohod.RowHeadersWidth = 51;
            dataGridView_dohod.RowTemplate.Height = 29;
            dataGridView_dohod.Size = new Size(753, 324);
            dataGridView_dohod.TabIndex = 2;
            dataGridView_dohod.SelectionChanged += dataGridView_dohod_SelectionChanged;
            // 
            // numericUpDown_tableID
            // 
            numericUpDown_tableID.Location = new Point(571, 55);
            numericUpDown_tableID.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown_tableID.Name = "numericUpDown_tableID";
            numericUpDown_tableID.Size = new Size(185, 27);
            numericUpDown_tableID.TabIndex = 3;
            numericUpDown_tableID.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown_tableID.ValueChanged += numericUpDown_tableID_ValueChanged;
            // 
            // button_SaveChanges
            // 
            button_SaveChanges.Location = new Point(661, 816);
            button_SaveChanges.Name = "button_SaveChanges";
            button_SaveChanges.Size = new Size(201, 29);
            button_SaveChanges.TabIndex = 4;
            button_SaveChanges.Text = "Сохранить изменения";
            button_SaveChanges.UseVisualStyleBackColor = true;
            button_SaveChanges.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(69, 452);
            label2.Name = "label2";
            label2.Size = new Size(153, 20);
            label2.TabIndex = 5;
            label2.Text = "Таблица доходности";
            // 
            // button_Graph
            // 
            button_Graph.Location = new Point(69, 816);
            button_Graph.Name = "button_Graph";
            button_Graph.Size = new Size(201, 29);
            button_Graph.TabIndex = 6;
            button_Graph.Text = "Показать граф состояний";
            button_Graph.UseVisualStyleBackColor = true;
            button_Graph.Click += button_Graph_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 875);
            Controls.Add(button_Graph);
            Controls.Add(label2);
            Controls.Add(button_SaveChanges);
            Controls.Add(numericUpDown_tableID);
            Controls.Add(dataGridView_dohod);
            Controls.Add(dataGridView_strategy);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Редактирование матрицы вероятностей";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_strategy).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_dohod).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_tableID).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView_strategy;
        private DataGridView dataGridView_dohod;
        private NumericUpDown numericUpDown_tableID;
        private Button button_SaveChanges;
        private Label label2;
        private Button button_Graph;
    }
}