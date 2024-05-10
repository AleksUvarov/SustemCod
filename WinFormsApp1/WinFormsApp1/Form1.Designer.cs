namespace WinFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            ohrana = new Button();
            codDostup = new Button();
            codControl = new Button();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            n_1 = new Button();
            n_3 = new Button();
            n_2 = new Button();
            n_5 = new Button();
            n_6 = new Button();
            n_4 = new Button();
            n_8 = new Button();
            n_9 = new Button();
            n_7 = new Button();
            n_0 = new Button();
            bEnter = new Button();
            b_del = new Button();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // ohrana
            // 
            ohrana.Location = new Point(466, 112);
            ohrana.Name = "ohrana";
            ohrana.Size = new Size(140, 40);
            ohrana.TabIndex = 0;
            ohrana.Text = "Вызов охраника";
            ohrana.UseVisualStyleBackColor = true;
            ohrana.Click += ohrana_Click;
            // 
            // codDostup
            // 
            codDostup.Location = new Point(466, 178);
            codDostup.Name = "codDostup";
            codDostup.Size = new Size(140, 40);
            codDostup.TabIndex = 1;
            codDostup.Text = "Сменить код-доступа";
            codDostup.UseVisualStyleBackColor = true;
            codDostup.Click += codDostup_Click;
            // 
            // codControl
            // 
            codControl.Location = new Point(466, 247);
            codControl.Name = "codControl";
            codControl.Size = new Size(140, 40);
            codControl.TabIndex = 2;
            codControl.Text = "Сменить код контроля";
            codControl.UseVisualStyleBackColor = true;
            codControl.Click += codControl_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(484, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(102, 85);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(77, 64);
            textBox1.MaxLength = 5;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(161, 23);
            textBox1.TabIndex = 4;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // n_1
            // 
            n_1.Location = new Point(77, 112);
            n_1.Name = "n_1";
            n_1.Size = new Size(70, 40);
            n_1.TabIndex = 5;
            n_1.Text = "1";
            n_1.UseVisualStyleBackColor = true;
            n_1.Click += n_1_Click;
            // 
            // n_3
            // 
            n_3.Location = new Point(260, 112);
            n_3.Name = "n_3";
            n_3.Size = new Size(70, 40);
            n_3.TabIndex = 6;
            n_3.Text = "3";
            n_3.UseVisualStyleBackColor = true;
            n_3.Click += n_3_Click;
            // 
            // n_2
            // 
            n_2.Location = new Point(168, 112);
            n_2.Name = "n_2";
            n_2.Size = new Size(70, 40);
            n_2.TabIndex = 7;
            n_2.Text = "2";
            n_2.UseVisualStyleBackColor = true;
            n_2.Click += n_2_Click;
            // 
            // n_5
            // 
            n_5.Location = new Point(168, 165);
            n_5.Name = "n_5";
            n_5.Size = new Size(70, 40);
            n_5.TabIndex = 10;
            n_5.Text = "5";
            n_5.UseVisualStyleBackColor = true;
            n_5.Click += n_5_Click;
            // 
            // n_6
            // 
            n_6.Location = new Point(260, 165);
            n_6.Name = "n_6";
            n_6.Size = new Size(70, 40);
            n_6.TabIndex = 9;
            n_6.Text = "6";
            n_6.UseVisualStyleBackColor = true;
            n_6.Click += n_6_Click;
            // 
            // n_4
            // 
            n_4.Location = new Point(77, 165);
            n_4.Name = "n_4";
            n_4.Size = new Size(70, 40);
            n_4.TabIndex = 8;
            n_4.Text = "4";
            n_4.UseVisualStyleBackColor = true;
            n_4.Click += n_4_Click;
            // 
            // n_8
            // 
            n_8.Location = new Point(168, 218);
            n_8.Name = "n_8";
            n_8.Size = new Size(70, 40);
            n_8.TabIndex = 13;
            n_8.Text = "8";
            n_8.UseVisualStyleBackColor = true;
            n_8.Click += n_8_Click;
            // 
            // n_9
            // 
            n_9.Location = new Point(260, 218);
            n_9.Name = "n_9";
            n_9.Size = new Size(70, 40);
            n_9.TabIndex = 12;
            n_9.Text = "9";
            n_9.UseVisualStyleBackColor = true;
            n_9.Click += n_9_Click;
            // 
            // n_7
            // 
            n_7.Location = new Point(77, 218);
            n_7.Name = "n_7";
            n_7.Size = new Size(70, 40);
            n_7.TabIndex = 11;
            n_7.Text = "7";
            n_7.UseVisualStyleBackColor = true;
            n_7.Click += n_7_Click;
            // 
            // n_0
            // 
            n_0.Location = new Point(77, 275);
            n_0.Name = "n_0";
            n_0.Size = new Size(165, 40);
            n_0.TabIndex = 14;
            n_0.Text = "0";
            n_0.UseVisualStyleBackColor = true;
            n_0.Click += n_0_Click;
            // 
            // bEnter
            // 
            bEnter.Location = new Point(260, 275);
            bEnter.Name = "bEnter";
            bEnter.Size = new Size(70, 40);
            bEnter.TabIndex = 15;
            bEnter.Text = "Enter";
            bEnter.UseVisualStyleBackColor = true;
            bEnter.Click += bEnter_Click;
            // 
            // b_del
            // 
            b_del.Location = new Point(260, 64);
            b_del.Name = "b_del";
            b_del.Size = new Size(70, 23);
            b_del.TabIndex = 16;
            b_del.Text = "Delete";
            b_del.UseVisualStyleBackColor = true;
            b_del.Click += b_del_Click;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(58, 34);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(292, 290);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(651, 336);
            Controls.Add(b_del);
            Controls.Add(bEnter);
            Controls.Add(n_0);
            Controls.Add(n_8);
            Controls.Add(n_9);
            Controls.Add(n_7);
            Controls.Add(n_5);
            Controls.Add(n_6);
            Controls.Add(n_4);
            Controls.Add(n_2);
            Controls.Add(n_3);
            Controls.Add(n_1);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Controls.Add(codControl);
            Controls.Add(codDostup);
            Controls.Add(ohrana);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ohrana;
        private Button codDostup;
        private Button codControl;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private Button n_1;
        private Button n_3;
        private Button n_2;
        private Button n_5;
        private Button n_6;
        private Button n_4;
        private Button n_8;
        private Button n_9;
        private Button n_7;
        private Button n_0;
        private Button bEnter;
        private Button b_del;
        private GroupBox groupBox1;
    }
}
