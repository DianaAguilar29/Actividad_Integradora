namespace Actividad_Integradora
{
    partial class ProfessorProfile
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
            this.components = new System.ComponentModel.Container();
            this.personalInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.colonyTextBox = new System.Windows.Forms.TextBox();
            this.numTextBox = new System.Windows.Forms.TextBox();
            this.colonyLabel = new System.Windows.Forms.Label();
            this.numLabel = new System.Windows.Forms.Label();
            this.streetLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.streetTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.editDependentButton = new System.Windows.Forms.Button();
            this.submitButton = new System.Windows.Forms.Button();
            this.browseButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.emailErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.letterErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.profilePictureBox = new System.Windows.Forms.PictureBox();
            this.changePassButton = new System.Windows.Forms.Button();
            this.personalInfoGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.emailErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.letterErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // personalInfoGroupBox
            // 
            this.personalInfoGroupBox.Controls.Add(this.colonyTextBox);
            this.personalInfoGroupBox.Controls.Add(this.numTextBox);
            this.personalInfoGroupBox.Controls.Add(this.colonyLabel);
            this.personalInfoGroupBox.Controls.Add(this.numLabel);
            this.personalInfoGroupBox.Controls.Add(this.streetLabel);
            this.personalInfoGroupBox.Controls.Add(this.emailLabel);
            this.personalInfoGroupBox.Controls.Add(this.phoneLabel);
            this.personalInfoGroupBox.Controls.Add(this.cityLabel);
            this.personalInfoGroupBox.Controls.Add(this.addressLabel);
            this.personalInfoGroupBox.Controls.Add(this.lastNameLabel);
            this.personalInfoGroupBox.Controls.Add(this.nameLabel);
            this.personalInfoGroupBox.Controls.Add(this.emailTextBox);
            this.personalInfoGroupBox.Controls.Add(this.phoneTextBox);
            this.personalInfoGroupBox.Controls.Add(this.cityTextBox);
            this.personalInfoGroupBox.Controls.Add(this.streetTextBox);
            this.personalInfoGroupBox.Controls.Add(this.lastNameTextBox);
            this.personalInfoGroupBox.Controls.Add(this.NameTextBox);
            this.personalInfoGroupBox.Location = new System.Drawing.Point(37, 66);
            this.personalInfoGroupBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.personalInfoGroupBox.Name = "personalInfoGroupBox";
            this.personalInfoGroupBox.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.personalInfoGroupBox.Size = new System.Drawing.Size(591, 733);
            this.personalInfoGroupBox.TabIndex = 0;
            this.personalInfoGroupBox.TabStop = false;
            this.personalInfoGroupBox.Text = "Personal Info";
            this.personalInfoGroupBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // colonyTextBox
            // 
            this.colonyTextBox.ForeColor = System.Drawing.SystemColors.MenuText;
            this.colonyTextBox.Location = new System.Drawing.Point(227, 393);
            this.colonyTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.colonyTextBox.Name = "colonyTextBox";
            this.colonyTextBox.Size = new System.Drawing.Size(223, 32);
            this.colonyTextBox.TabIndex = 18;
            // 
            // numTextBox
            // 
            this.numTextBox.ForeColor = System.Drawing.SystemColors.MenuText;
            this.numTextBox.Location = new System.Drawing.Point(227, 329);
            this.numTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numTextBox.Name = "numTextBox";
            this.numTextBox.Size = new System.Drawing.Size(80, 32);
            this.numTextBox.TabIndex = 17;
            this.numTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numTextBox_KeyPress);
            // 
            // colonyLabel
            // 
            this.colonyLabel.AutoSize = true;
            this.colonyLabel.Location = new System.Drawing.Point(91, 393);
            this.colonyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.colonyLabel.Name = "colonyLabel";
            this.colonyLabel.Size = new System.Drawing.Size(80, 23);
            this.colonyLabel.TabIndex = 16;
            this.colonyLabel.Text = "Colony";
            // 
            // numLabel
            // 
            this.numLabel.AutoSize = true;
            this.numLabel.Location = new System.Drawing.Point(82, 329);
            this.numLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.numLabel.Name = "numLabel";
            this.numLabel.Size = new System.Drawing.Size(89, 23);
            this.numLabel.TabIndex = 15;
            this.numLabel.Text = "Number";
            // 
            // streetLabel
            // 
            this.streetLabel.AutoSize = true;
            this.streetLabel.Location = new System.Drawing.Point(105, 259);
            this.streetLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.streetLabel.Name = "streetLabel";
            this.streetLabel.Size = new System.Drawing.Size(66, 23);
            this.streetLabel.TabIndex = 14;
            this.streetLabel.Text = "Street";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(109, 620);
            this.emailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(62, 23);
            this.emailLabel.TabIndex = 11;
            this.emailLabel.Text = "Email";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(14, 544);
            this.phoneLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(157, 23);
            this.phoneLabel.TabIndex = 10;
            this.phoneLabel.Text = "Phone Number";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(124, 466);
            this.cityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(47, 23);
            this.cityLabel.TabIndex = 9;
            this.cityLabel.Text = "City";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(312, 203);
            this.addressLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(88, 23);
            this.addressLabel.TabIndex = 8;
            this.addressLabel.Text = "Address";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(56, 144);
            this.lastNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(115, 23);
            this.lastNameLabel.TabIndex = 7;
            this.lastNameLabel.Text = "Last Name";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(100, 73);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(71, 23);
            this.nameLabel.TabIndex = 6;
            this.nameLabel.Text = "Name";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(227, 623);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(223, 32);
            this.emailTextBox.TabIndex = 5;
            this.emailTextBox.Leave += new System.EventHandler(this.emailTextBox_Leave);
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(227, 544);
            this.phoneTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(223, 32);
            this.phoneTextBox.TabIndex = 4;
            this.phoneTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phoneTextBox_KeyPress);
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(227, 466);
            this.cityTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(223, 32);
            this.cityTextBox.TabIndex = 3;
            this.cityTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cityTextBox_KeyPress);
            // 
            // streetTextBox
            // 
            this.streetTextBox.ForeColor = System.Drawing.SystemColors.MenuText;
            this.streetTextBox.Location = new System.Drawing.Point(227, 259);
            this.streetTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.streetTextBox.Name = "streetTextBox";
            this.streetTextBox.Size = new System.Drawing.Size(150, 32);
            this.streetTextBox.TabIndex = 2;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(227, 141);
            this.lastNameTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(223, 32);
            this.lastNameTextBox.TabIndex = 1;
            this.lastNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lastNameTextBox_KeyPress);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(227, 70);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(223, 32);
            this.NameTextBox.TabIndex = 0;
            this.NameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NameTextBox_KeyPress);
            // 
            // editDependentButton
            // 
            this.editDependentButton.Location = new System.Drawing.Point(890, 622);
            this.editDependentButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.editDependentButton.Name = "editDependentButton";
            this.editDependentButton.Size = new System.Drawing.Size(150, 87);
            this.editDependentButton.TabIndex = 13;
            this.editDependentButton.Text = "Edit Dependents";
            this.editDependentButton.UseVisualStyleBackColor = true;
            this.editDependentButton.Click += new System.EventHandler(this.editDependentButton_Click);
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(890, 749);
            this.submitButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(150, 50);
            this.submitButton.TabIndex = 12;
            this.submitButton.Text = "Save";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(890, 459);
            this.browseButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(150, 50);
            this.browseButton.TabIndex = 2;
            this.browseButton.Text = "Edit";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(698, 459);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(150, 50);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // emailErrorProvider
            // 
            this.emailErrorProvider.ContainerControl = this;
            // 
            // letterErrorProvider
            // 
            this.letterErrorProvider.ContainerControl = this;
            // 
            // profilePictureBox
            // 
            this.profilePictureBox.Image = global::Actividad_Integradora.Properties.Resources.default_profile;
            this.profilePictureBox.Location = new System.Drawing.Point(698, 101);
            this.profilePictureBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.profilePictureBox.Name = "profilePictureBox";
            this.profilePictureBox.Size = new System.Drawing.Size(342, 335);
            this.profilePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.profilePictureBox.TabIndex = 1;
            this.profilePictureBox.TabStop = false;
            // 
            // changePassButton
            // 
            this.changePassButton.Location = new System.Drawing.Point(698, 622);
            this.changePassButton.Name = "changePassButton";
            this.changePassButton.Size = new System.Drawing.Size(150, 87);
            this.changePassButton.TabIndex = 14;
            this.changePassButton.Text = "Change Password";
            this.changePassButton.UseVisualStyleBackColor = true;
            this.changePassButton.Click += new System.EventHandler(this.changePassButton_Click);
            // 
            // ProfessorProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 825);
            this.Controls.Add(this.changePassButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.profilePictureBox);
            this.Controls.Add(this.personalInfoGroupBox);
            this.Controls.Add(this.editDependentButton);
            this.Controls.Add(this.submitButton);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ProfessorProfile";
            this.Text = "ProfessorProfile";
            this.personalInfoGroupBox.ResumeLayout(false);
            this.personalInfoGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.emailErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.letterErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox personalInfoGroupBox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox streetTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.PictureBox profilePictureBox;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button editDependentButton;
        private System.Windows.Forms.ToolTip ToolTip;
        private System.Windows.Forms.TextBox colonyTextBox;
        private System.Windows.Forms.TextBox numTextBox;
        private System.Windows.Forms.Label colonyLabel;
        private System.Windows.Forms.Label numLabel;
        private System.Windows.Forms.Label streetLabel;
        private System.Windows.Forms.ErrorProvider emailErrorProvider;
        private System.Windows.Forms.ErrorProvider letterErrorProvider;
        private System.Windows.Forms.Button changePassButton;
    }
}