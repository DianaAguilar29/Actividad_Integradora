namespace Actividad_Integradora
{
    partial class AddDependentForm
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
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.relationshipLabel = new System.Windows.Forms.Label();
            this.relationshipComboBox = new System.Windows.Forms.ComboBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.birthdateTextBox = new System.Windows.Forms.TextBox();
            this.bithdateLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(237, 41);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(223, 32);
            this.nameTextBox.TabIndex = 0;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(237, 97);
            this.lastNameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(223, 32);
            this.lastNameTextBox.TabIndex = 1;
            this.lastNameTextBox.TextChanged += new System.EventHandler(this.lastNameTextBox_TextChanged);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(85, 41);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(71, 23);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "Name";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(41, 97);
            this.lastNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(115, 23);
            this.lastNameLabel.TabIndex = 5;
            this.lastNameLabel.Text = "Last Name";
            // 
            // relationshipLabel
            // 
            this.relationshipLabel.AutoSize = true;
            this.relationshipLabel.Location = new System.Drawing.Point(30, 151);
            this.relationshipLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.relationshipLabel.Name = "relationshipLabel";
            this.relationshipLabel.Size = new System.Drawing.Size(126, 23);
            this.relationshipLabel.TabIndex = 7;
            this.relationshipLabel.Text = "Relationship";
            // 
            // relationshipComboBox
            // 
            this.relationshipComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.relationshipComboBox.FormattingEnabled = true;
            this.relationshipComboBox.Items.AddRange(new object[] {
            "Spouse",
            "Child",
            "Father",
            "Mother"});
            this.relationshipComboBox.Location = new System.Drawing.Point(237, 151);
            this.relationshipComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.relationshipComboBox.Name = "relationshipComboBox";
            this.relationshipComboBox.Size = new System.Drawing.Size(223, 31);
            this.relationshipComboBox.TabIndex = 8;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(69, 592);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(150, 50);
            this.cancelButton.TabIndex = 14;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // addButton
            // 
            this.addButton.Enabled = false;
            this.addButton.Location = new System.Drawing.Point(279, 592);
            this.addButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(150, 50);
            this.addButton.TabIndex = 15;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(98, 303);
            this.monthCalendar.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.monthCalendar.MaxDate = new System.DateTime(2100, 1, 1, 0, 0, 0, 0);
            this.monthCalendar.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.ShowTodayCircle = false;
            this.monthCalendar.TabIndex = 17;
            this.monthCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // birthdateTextBox
            // 
            this.birthdateTextBox.Enabled = false;
            this.birthdateTextBox.Location = new System.Drawing.Point(240, 245);
            this.birthdateTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.birthdateTextBox.Name = "birthdateTextBox";
            this.birthdateTextBox.Size = new System.Drawing.Size(148, 32);
            this.birthdateTextBox.TabIndex = 20;
            // 
            // bithdateLabel
            // 
            this.bithdateLabel.AutoSize = true;
            this.bithdateLabel.Location = new System.Drawing.Point(122, 245);
            this.bithdateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bithdateLabel.Name = "bithdateLabel";
            this.bithdateLabel.Size = new System.Drawing.Size(97, 23);
            this.bithdateLabel.TabIndex = 12;
            this.bithdateLabel.Text = "Birthdate";
            // 
            // AddDependentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 676);
            this.Controls.Add(this.birthdateTextBox);
            this.Controls.Add(this.monthCalendar);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.bithdateLabel);
            this.Controls.Add(this.relationshipComboBox);
            this.Controls.Add(this.relationshipLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddDependentForm";
            this.Text = "        ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label relationshipLabel;
        private System.Windows.Forms.ComboBox relationshipComboBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.TextBox birthdateTextBox;
        private System.Windows.Forms.Label bithdateLabel;
    }
}