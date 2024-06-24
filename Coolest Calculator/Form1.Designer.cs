namespace Coolest_Calculator
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
            button_1 = new Button();
            button_2 = new Button();
            button_3 = new Button();
            button_0 = new Button();
            button_4 = new Button();
            button_5 = new Button();
            button_6 = new Button();
            button_7 = new Button();
            button_8 = new Button();
            button_9 = new Button();
            Calculator = new Label();
            button_plus = new Button();
            Calculator_Container = new DataGridView();
            button_subtract = new Button();
            button_multiply = new Button();
            button_divide = new Button();
            Results = new TextBox();
            Clear = new Button();
            button_equals = new Button();
            ((System.ComponentModel.ISupportInitialize)Calculator_Container).BeginInit();
            SuspendLayout();
            // 
            // button_1
            // 
            button_1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_1.Location = new Point(49, 265);
            button_1.Name = "button_1";
            button_1.Size = new Size(37, 27);
            button_1.TabIndex = 4;
            button_1.Text = "1";
            button_1.UseVisualStyleBackColor = true;
            button_1.Click += button_1_Click;
            // 
            // button_2
            // 
            button_2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button_2.Location = new Point(92, 265);
            button_2.Name = "button_2";
            button_2.Size = new Size(37, 27);
            button_2.TabIndex = 4;
            button_2.Text = "2";
            button_2.UseVisualStyleBackColor = true;
            button_2.Click += button_2_Click;
            // 
            // button_3
            // 
            button_3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button_3.Location = new Point(135, 265);
            button_3.Name = "button_3";
            button_3.Size = new Size(37, 27);
            button_3.TabIndex = 4;
            button_3.Text = "3";
            button_3.UseVisualStyleBackColor = true;
            button_3.Click += button_3_Click;
            // 
            // button_0
            // 
            button_0.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button_0.Location = new Point(49, 298);
            button_0.Name = "button_0";
            button_0.Size = new Size(123, 27);
            button_0.TabIndex = 4;
            button_0.Text = "0";
            button_0.UseVisualStyleBackColor = true;
            button_0.Click += button_0_Click;
            // 
            // button_4
            // 
            button_4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button_4.Location = new Point(49, 232);
            button_4.Name = "button_4";
            button_4.Size = new Size(37, 27);
            button_4.TabIndex = 4;
            button_4.Text = "4";
            button_4.UseVisualStyleBackColor = true;
            button_4.Click += button_4_Click;
            // 
            // button_5
            // 
            button_5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button_5.Location = new Point(92, 232);
            button_5.Name = "button_5";
            button_5.Size = new Size(37, 27);
            button_5.TabIndex = 4;
            button_5.Text = "5";
            button_5.UseVisualStyleBackColor = true;
            button_5.Click += button_5_Click;
            // 
            // button_6
            // 
            button_6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button_6.Location = new Point(135, 232);
            button_6.Name = "button_6";
            button_6.Size = new Size(37, 27);
            button_6.TabIndex = 4;
            button_6.Text = "6";
            button_6.UseVisualStyleBackColor = true;
            button_6.Click += button_6_Click;
            // 
            // button_7
            // 
            button_7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button_7.Location = new Point(49, 199);
            button_7.Name = "button_7";
            button_7.Size = new Size(37, 27);
            button_7.TabIndex = 4;
            button_7.Text = "7";
            button_7.UseVisualStyleBackColor = true;
            button_7.Click += button_7_Click;
            // 
            // button_8
            // 
            button_8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button_8.Location = new Point(92, 199);
            button_8.Name = "button_8";
            button_8.Size = new Size(37, 27);
            button_8.TabIndex = 4;
            button_8.Text = "8";
            button_8.UseVisualStyleBackColor = true;
            button_8.Click += button_8_Click;
            // 
            // button_9
            // 
            button_9.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button_9.Location = new Point(135, 199);
            button_9.Name = "button_9";
            button_9.Size = new Size(37, 27);
            button_9.TabIndex = 4;
            button_9.Text = "9";
            button_9.UseVisualStyleBackColor = true;
            button_9.Click += button_9_Click;
            // 
            // Calculator
            // 
            Calculator.AutoSize = true;
            Calculator.Location = new Point(102, 77);
            Calculator.Name = "Calculator";
            Calculator.Size = new Size(61, 15);
            Calculator.TabIndex = 6;
            Calculator.Text = "Calculator";
            // 
            // button_plus
            // 
            button_plus.Location = new Point(178, 199);
            button_plus.Name = "button_plus";
            button_plus.Size = new Size(40, 27);
            button_plus.TabIndex = 7;
            button_plus.Text = "+";
            button_plus.UseVisualStyleBackColor = true;
            button_plus.Click += button_plus_Click;
            // 
            // Calculator_Container
            // 
            Calculator_Container.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Calculator_Container.Location = new Point(24, 62);
            Calculator_Container.Name = "Calculator_Container";
            Calculator_Container.Size = new Size(222, 300);
            Calculator_Container.TabIndex = 8;
            Calculator_Container.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button_subtract
            // 
            button_subtract.Location = new Point(178, 232);
            button_subtract.Name = "button_subtract";
            button_subtract.Size = new Size(40, 27);
            button_subtract.TabIndex = 7;
            button_subtract.Text = "-";
            button_subtract.UseVisualStyleBackColor = true;
            button_subtract.Click += button_subtract_Click;
            // 
            // button_multiply
            // 
            button_multiply.Location = new Point(178, 265);
            button_multiply.Name = "button_multiply";
            button_multiply.Size = new Size(40, 27);
            button_multiply.TabIndex = 7;
            button_multiply.Text = "x";
            button_multiply.UseVisualStyleBackColor = true;
            button_multiply.Click += button_multiply_Click;
            // 
            // button_divide
            // 
            button_divide.Location = new Point(178, 298);
            button_divide.Name = "button_divide";
            button_divide.Size = new Size(40, 27);
            button_divide.TabIndex = 7;
            button_divide.Text = "/";
            button_divide.UseVisualStyleBackColor = true;
            button_divide.Click += button_divide_Click;
            // 
            // Results
            // 
            Results.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Results.Location = new Point(92, 166);
            Results.Name = "Results";
            Results.Size = new Size(126, 29);
            Results.TabIndex = 10;
            Results.Text = "Piggy Bank";
            Results.TextChanged += Results_TextChanged;
            // 
            // Clear
            // 
            Clear.Location = new Point(49, 168);
            Clear.Name = "Clear";
            Clear.Size = new Size(40, 27);
            Clear.TabIndex = 7;
            Clear.Text = "CE";
            Clear.UseVisualStyleBackColor = true;
            Clear.Click += Clear_Click;
            // 
            // button_equals
            // 
            button_equals.Location = new Point(49, 327);
            button_equals.Name = "button_equals";
            button_equals.Size = new Size(169, 24);
            button_equals.TabIndex = 4;
            button_equals.Text = "Equals";
            button_equals.UseVisualStyleBackColor = true;
            button_equals.Click += button_equals_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(270, 422);
            Controls.Add(Results);
            Controls.Add(button_subtract);
            Controls.Add(button_divide);
            Controls.Add(button_multiply);
            Controls.Add(Clear);
            Controls.Add(button_plus);
            Controls.Add(Calculator);
            Controls.Add(button_equals);
            Controls.Add(button_0);
            Controls.Add(button_9);
            Controls.Add(button_6);
            Controls.Add(button_8);
            Controls.Add(button_5);
            Controls.Add(button_7);
            Controls.Add(button_3);
            Controls.Add(button_4);
            Controls.Add(button_2);
            Controls.Add(button_1);
            Controls.Add(Calculator_Container);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculator";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)Calculator_Container).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button2;
        private Button button5;
        private Button button7;
        private Button button9;
        private DataGridView dataGridView1;
        private Button button12;
        private TextBox textBox1;
        private Button button14;
        private Button C;
        public Button button_1;
        public Button button_2;
        public Button button_3;
        public Button button_4;
        public Button button_5;
        public Button button_6;
        public Button button_7;
        public Button button_8;
        public Button button_9;
        public Button Clear;
        public Button button_plus;
        public Button button_subtract;
        public Button button_multiply;
        public Button button_divide;
        public Button button_equals;
        public TextBox Results;
        public Label Calculator;
        public DataGridView Calculator_Container;
        public Button button_0;
    }
}
