namespace WinFormsApp1
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
            btnYes = new Button();
            btnNo = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnYes
            // 
            btnYes.Location = new Point(58, 36);
            btnYes.Name = "btnYes";
            btnYes.Size = new Size(85, 21);
            btnYes.TabIndex = 0;
            btnYes.Text = "Да";
            btnYes.UseVisualStyleBackColor = true;
            btnYes.Click += btnYes_Click;
            // 
            // btnNo
            // 
            btnNo.Location = new Point(189, 37);
            btnNo.Name = "btnNo";
            btnNo.Size = new Size(85, 21);
            btnNo.TabIndex = 1;
            btnNo.Text = "Нет";
            btnNo.UseVisualStyleBackColor = true;
            btnNo.Click += btnNo_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(106, 7);
            label1.Name = "label1";
            label1.Size = new Size(125, 21);
            label1.TabIndex = 2;
            label1.Text = "Открыть дверь?";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(315, 64);
            Controls.Add(label1);
            Controls.Add(btnNo);
            Controls.Add(btnYes);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnYes;
        private Button btnNo;
        private Label label1;
    }
}