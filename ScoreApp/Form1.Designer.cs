namespace ScoreApp
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
            listBox1 = new ListBox();
            AddButton = new Button();
            UpdateButton = new Button();
            DeleteButton = new Button();
            label1 = new Label();
            TotalTextBox = new TextBox();
            label2 = new Label();
            AvgTextBox = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button1 = new Button();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(30, 41);
            listBox1.Margin = new Padding(4);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(206, 504);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(258, 41);
            AddButton.Margin = new Padding(4);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(96, 31);
            AddButton.TabIndex = 1;
            AddButton.Text = "추가하기";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // UpdateButton
            // 
            UpdateButton.Location = new Point(258, 80);
            UpdateButton.Margin = new Padding(4);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(96, 31);
            UpdateButton.TabIndex = 2;
            UpdateButton.Text = "수정하기";
            UpdateButton.UseVisualStyleBackColor = true;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(258, 119);
            DeleteButton.Margin = new Padding(4);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(96, 31);
            DeleteButton.TabIndex = 3;
            DeleteButton.Text = "삭제하기";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(258, 204);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(39, 20);
            label1.TabIndex = 4;
            label1.Text = "총점";
            // 
            // TotalTextBox
            // 
            TotalTextBox.Location = new Point(258, 241);
            TotalTextBox.Margin = new Padding(4);
            TotalTextBox.Name = "TotalTextBox";
            TotalTextBox.Size = new Size(127, 27);
            TotalTextBox.TabIndex = 5;
            TotalTextBox.TextChanged += TotalTextBox_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(258, 302);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 6;
            label2.Text = "평균";
            // 
            // AvgTextBox
            // 
            AvgTextBox.Location = new Point(260, 341);
            AvgTextBox.Name = "AvgTextBox";
            AvgTextBox.Size = new Size(125, 27);
            AvgTextBox.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(527, 60);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 8;
            label3.Text = "총 학생 수";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(680, 60);
            label4.Name = "label4";
            label4.Size = new Size(37, 20);
            label4.TabIndex = 9;
            label4.Text = "0 명";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(527, 325);
            label5.Name = "label5";
            label5.Size = new Size(39, 20);
            label5.TabIndex = 10;
            label5.Text = "이름";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(527, 358);
            label6.Name = "label6";
            label6.Size = new Size(39, 20);
            label6.TabIndex = 11;
            label6.Text = "국어";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(527, 391);
            label7.Name = "label7";
            label7.Size = new Size(39, 20);
            label7.TabIndex = 12;
            label7.Text = "수학";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(527, 424);
            label8.Name = "label8";
            label8.Size = new Size(39, 20);
            label8.TabIndex = 13;
            label8.Text = "영어";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(572, 322);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 14;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(572, 355);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 15;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(572, 388);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 16;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(572, 421);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 17;
            // 
            // button1
            // 
            button1.Location = new Point(603, 454);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 18;
            button1.Text = "추가";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(527, 80);
            label9.Name = "label9";
            label9.Size = new Size(109, 20);
            label9.TabIndex = 19;
            label9.Text = "국어 점수 평균";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(680, 80);
            label10.Name = "label10";
            label10.Size = new Size(17, 20);
            label10.TabIndex = 20;
            label10.Text = "0";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(527, 100);
            label11.Name = "label11";
            label11.Size = new Size(109, 20);
            label11.TabIndex = 21;
            label11.Text = "수학 점수 평균";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(527, 120);
            label12.Name = "label12";
            label12.Size = new Size(109, 20);
            label12.TabIndex = 22;
            label12.Text = "영어 점수 평균";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(527, 140);
            label13.Name = "label13";
            label13.Size = new Size(144, 20);
            label13.TabIndex = 23;
            label13.Text = "국어 최고 점수 학생";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(680, 100);
            label14.Name = "label14";
            label14.Size = new Size(17, 20);
            label14.TabIndex = 24;
            label14.Text = "0";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(680, 120);
            label15.Name = "label15";
            label15.Size = new Size(17, 20);
            label15.TabIndex = 25;
            label15.Text = "0";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(680, 140);
            label16.Name = "label16";
            label16.Size = new Size(17, 20);
            label16.TabIndex = 26;
            label16.Text = "0";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(527, 160);
            label17.Name = "label17";
            label17.Size = new Size(102, 20);
            label17.TabIndex = 27;
            label17.Text = "전교 1등 학생";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(680, 160);
            label18.Name = "label18";
            label18.Size = new Size(17, 20);
            label18.TabIndex = 28;
            label18.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(799, 600);
            Controls.Add(label18);
            Controls.Add(label17);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(AvgTextBox);
            Controls.Add(label2);
            Controls.Add(TotalTextBox);
            Controls.Add(label1);
            Controls.Add(DeleteButton);
            Controls.Add(UpdateButton);
            Controls.Add(AddButton);
            Controls.Add(listBox1);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "W";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Button AddButton;
        private Button UpdateButton;
        private Button DeleteButton;
        private Label label1;
        private TextBox TotalTextBox;
        private Label label2;
        private TextBox AvgTextBox;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button1;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
    }
}