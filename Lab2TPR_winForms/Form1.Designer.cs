namespace Lab1TPR_winForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            button_StartModelling = new Button();
            label2 = new Label();
            label3 = new Label();
            button_EditMatrix = new Button();
            button_LoadFromFile = new Button();
            button_SaveToFile = new Button();
            textBox_saveName = new TextBox();
            nud_StepNum = new NumericUpDown();
            nud_conditionNum = new NumericUpDown();
            nud_strategyNum = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)nud_StepNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_conditionNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_strategyNum).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 48);
            label1.Name = "label1";
            label1.Size = new Size(162, 20);
            label1.TabIndex = 0;
            label1.Text = "Количество стратегий";
            // 
            // button_StartModelling
            // 
            button_StartModelling.Location = new Point(512, 360);
            button_StartModelling.Name = "button_StartModelling";
            button_StartModelling.Size = new Size(216, 44);
            button_StartModelling.TabIndex = 1;
            button_StartModelling.Text = "Начать моделирование";
            button_StartModelling.UseVisualStyleBackColor = true;
            button_StartModelling.Click += button_StartModelling_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 117);
            label2.Name = "label2";
            label2.Size = new Size(167, 20);
            label2.TabIndex = 3;
            label2.Text = "Количество состояний";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 371);
            label3.Name = "label3";
            label3.Size = new Size(254, 20);
            label3.TabIndex = 5;
            label3.Text = "Количество шагов моделирования";
            // 
            // button_EditMatrix
            // 
            button_EditMatrix.Location = new Point(62, 204);
            button_EditMatrix.Name = "button_EditMatrix";
            button_EditMatrix.Size = new Size(294, 47);
            button_EditMatrix.TabIndex = 7;
            button_EditMatrix.Text = "Редактировать матрицу вероятностей";
            button_EditMatrix.UseVisualStyleBackColor = true;
            button_EditMatrix.Click += buttonEditMarix_Click;
            // 
            // button_LoadFromFile
            // 
            button_LoadFromFile.Location = new Point(512, 77);
            button_LoadFromFile.Name = "button_LoadFromFile";
            button_LoadFromFile.Size = new Size(150, 53);
            button_LoadFromFile.TabIndex = 8;
            button_LoadFromFile.Text = "Загрузка данных из файла";
            button_LoadFromFile.UseVisualStyleBackColor = true;
            button_LoadFromFile.Click += button3_Click;
            // 
            // button_SaveToFile
            // 
            button_SaveToFile.Location = new Point(667, 77);
            button_SaveToFile.Name = "button_SaveToFile";
            button_SaveToFile.Size = new Size(138, 53);
            button_SaveToFile.TabIndex = 9;
            button_SaveToFile.Text = "Сохранить данные в файл";
            button_SaveToFile.UseVisualStyleBackColor = true;
            button_SaveToFile.Click += buttonSave_Click;
            // 
            // textBox_saveName
            // 
            textBox_saveName.Location = new Point(512, 45);
            textBox_saveName.Name = "textBox_saveName";
            textBox_saveName.Size = new Size(294, 27);
            textBox_saveName.TabIndex = 10;
            // 
            // nud_StepNum
            // 
            nud_StepNum.Location = new Point(280, 370);
            nud_StepNum.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nud_StepNum.Name = "nud_StepNum";
            nud_StepNum.Size = new Size(97, 27);
            nud_StepNum.TabIndex = 11;
            nud_StepNum.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // nud_conditionNum
            // 
            nud_conditionNum.Location = new Point(190, 117);
            nud_conditionNum.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nud_conditionNum.Name = "nud_conditionNum";
            nud_conditionNum.Size = new Size(97, 27);
            nud_conditionNum.TabIndex = 12;
            nud_conditionNum.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // nud_strategyNum
            // 
            nud_strategyNum.Location = new Point(190, 46);
            nud_strategyNum.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nud_strategyNum.Name = "nud_strategyNum";
            nud_strategyNum.Size = new Size(97, 27);
            nud_strategyNum.TabIndex = 13;
            nud_strategyNum.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(873, 571);
            Controls.Add(nud_strategyNum);
            Controls.Add(nud_conditionNum);
            Controls.Add(nud_StepNum);
            Controls.Add(textBox_saveName);
            Controls.Add(button_SaveToFile);
            Controls.Add(button_LoadFromFile);
            Controls.Add(button_EditMatrix);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button_StartModelling);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Ввод параметров модуляции";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)nud_StepNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_conditionNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_strategyNum).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button_StartModelling;
        private Label label2;
        private Label label3;
        private Button button_EditMatrix;
        private Button button_LoadFromFile;
        private Button button_SaveToFile;
        private TextBox textBox_saveName;
        private NumericUpDown nud_StepNum;
        private NumericUpDown nud_conditionNum;
        private NumericUpDown nud_strategyNum;
    }
}