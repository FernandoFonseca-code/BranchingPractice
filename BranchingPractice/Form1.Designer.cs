namespace BranchingPractice
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
            txtName = new TextBox();
            btnDisplayGreeting = new Button();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(74, 61);
            txtName.Name = "txtName";
            txtName.Size = new Size(204, 31);
            txtName.TabIndex = 0;
            // 
            // btnDisplayGreeting
            // 
            btnDisplayGreeting.Location = new Point(74, 159);
            btnDisplayGreeting.Name = "btnDisplayGreeting";
            btnDisplayGreeting.Size = new Size(204, 61);
            btnDisplayGreeting.TabIndex = 1;
            btnDisplayGreeting.Text = "Display Greeting";
            btnDisplayGreeting.UseVisualStyleBackColor = true;
            btnDisplayGreeting.Click += btnDisplayGreeting_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(375, 281);
            Controls.Add(btnDisplayGreeting);
            Controls.Add(txtName);
            Name = "Form1";
            Text = "Branching Practice";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private Button btnDisplayGreeting;
    }
}
