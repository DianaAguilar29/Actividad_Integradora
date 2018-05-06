namespace Actividad_Integradora
{
    partial class PrincipalMenuForm
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
            this.menuLabel = new System.Windows.Forms.Label();
            this.profileButton = new System.Windows.Forms.Button();
            this.tutorialsButton = new System.Windows.Forms.Button();
            this.workDevButton = new System.Windows.Forms.Button();
            this.subjectsButton = new System.Windows.Forms.Button();
            this.schoolingButton = new System.Windows.Forms.Button();
            this.viewButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // menuLabel
            // 
            this.menuLabel.AutoSize = true;
            this.menuLabel.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuLabel.ForeColor = System.Drawing.Color.Maroon;
            this.menuLabel.Location = new System.Drawing.Point(256, 38);
            this.menuLabel.Name = "menuLabel";
            this.menuLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuLabel.Size = new System.Drawing.Size(194, 70);
            this.menuLabel.TabIndex = 1;
            this.menuLabel.Text = "Menu";
            // 
            // profileButton
            // 
            this.profileButton.Location = new System.Drawing.Point(103, 164);
            this.profileButton.Name = "profileButton";
            this.profileButton.Size = new System.Drawing.Size(200, 100);
            this.profileButton.TabIndex = 2;
            this.profileButton.Text = "Profile";
            this.profileButton.UseVisualStyleBackColor = true;
            this.profileButton.Click += new System.EventHandler(this.profileButton_Click);
            // 
            // tutorialsButton
            // 
            this.tutorialsButton.Location = new System.Drawing.Point(103, 310);
            this.tutorialsButton.Name = "tutorialsButton";
            this.tutorialsButton.Size = new System.Drawing.Size(200, 100);
            this.tutorialsButton.TabIndex = 3;
            this.tutorialsButton.Text = "Tutorias";
            this.tutorialsButton.UseVisualStyleBackColor = true;
            // 
            // workDevButton
            // 
            this.workDevButton.Location = new System.Drawing.Point(103, 454);
            this.workDevButton.Name = "workDevButton";
            this.workDevButton.Size = new System.Drawing.Size(200, 100);
            this.workDevButton.TabIndex = 4;
            this.workDevButton.Text = "Your Work";
            this.workDevButton.UseVisualStyleBackColor = true;
            // 
            // subjectsButton
            // 
            this.subjectsButton.Location = new System.Drawing.Point(409, 164);
            this.subjectsButton.Name = "subjectsButton";
            this.subjectsButton.Size = new System.Drawing.Size(200, 100);
            this.subjectsButton.TabIndex = 5;
            this.subjectsButton.Text = "Subjects";
            this.subjectsButton.UseVisualStyleBackColor = true;
            this.subjectsButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // schoolingButton
            // 
            this.schoolingButton.Location = new System.Drawing.Point(409, 310);
            this.schoolingButton.Name = "schoolingButton";
            this.schoolingButton.Size = new System.Drawing.Size(200, 100);
            this.schoolingButton.TabIndex = 6;
            this.schoolingButton.Text = "Schooling";
            this.schoolingButton.UseVisualStyleBackColor = true;
            // 
            // viewButton
            // 
            this.viewButton.Location = new System.Drawing.Point(409, 454);
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(200, 100);
            this.viewButton.TabIndex = 7;
            this.viewButton.Text = "View";
            this.viewButton.UseVisualStyleBackColor = true;
            // 
            // PrincipalMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 593);
            this.Controls.Add(this.viewButton);
            this.Controls.Add(this.schoolingButton);
            this.Controls.Add(this.subjectsButton);
            this.Controls.Add(this.workDevButton);
            this.Controls.Add(this.tutorialsButton);
            this.Controls.Add(this.profileButton);
            this.Controls.Add(this.menuLabel);
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "PrincipalMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PrincipalMenuForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label menuLabel;
        private System.Windows.Forms.Button profileButton;
        private System.Windows.Forms.Button tutorialsButton;
        private System.Windows.Forms.Button workDevButton;
        private System.Windows.Forms.Button subjectsButton;
        private System.Windows.Forms.Button schoolingButton;
        private System.Windows.Forms.Button viewButton;
    }
}