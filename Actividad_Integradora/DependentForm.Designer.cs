namespace Actividad_Integradora
{
    partial class DependentForm
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
            this.dependentListView = new System.Windows.Forms.ListView();
            this.nameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lastNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ageColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.relationshipColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addRelationshipButton = new System.Windows.Forms.Button();
            this.editRelationshipButton = new System.Windows.Forms.Button();
            this.deleteRelationshipButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dependentListView
            // 
            this.dependentListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameColumn,
            this.lastNameColumn,
            this.ageColumn,
            this.relationshipColumn});
            this.dependentListView.FullRowSelect = true;
            this.dependentListView.GridLines = true;
            this.dependentListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.dependentListView.Location = new System.Drawing.Point(76, 52);
            this.dependentListView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dependentListView.Name = "dependentListView";
            this.dependentListView.Size = new System.Drawing.Size(616, 280);
            this.dependentListView.TabIndex = 0;
            this.dependentListView.UseCompatibleStateImageBehavior = false;
            this.dependentListView.View = System.Windows.Forms.View.Details;
            this.dependentListView.SelectedIndexChanged += new System.EventHandler(this.dependentListView_SelectedIndexChanged);
            // 
            // nameColumn
            // 
            this.nameColumn.Text = "Name";
            this.nameColumn.Width = 115;
            // 
            // lastNameColumn
            // 
            this.lastNameColumn.Text = "Last Name";
            this.lastNameColumn.Width = 127;
            // 
            // ageColumn
            // 
            this.ageColumn.Text = "Age";
            // 
            // relationshipColumn
            // 
            this.relationshipColumn.Text = "Relationship";
            this.relationshipColumn.Width = 99;
            // 
            // addRelationshipButton
            // 
            this.addRelationshipButton.Location = new System.Drawing.Point(88, 401);
            this.addRelationshipButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addRelationshipButton.Name = "addRelationshipButton";
            this.addRelationshipButton.Size = new System.Drawing.Size(150, 50);
            this.addRelationshipButton.TabIndex = 1;
            this.addRelationshipButton.Text = "Add";
            this.addRelationshipButton.UseVisualStyleBackColor = true;
            this.addRelationshipButton.Click += new System.EventHandler(this.addRelationshipButton_Click);
            // 
            // editRelationshipButton
            // 
            this.editRelationshipButton.Enabled = false;
            this.editRelationshipButton.Location = new System.Drawing.Point(309, 401);
            this.editRelationshipButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.editRelationshipButton.Name = "editRelationshipButton";
            this.editRelationshipButton.Size = new System.Drawing.Size(150, 50);
            this.editRelationshipButton.TabIndex = 2;
            this.editRelationshipButton.Text = "Edit";
            this.editRelationshipButton.UseVisualStyleBackColor = true;
            this.editRelationshipButton.Click += new System.EventHandler(this.editRelationshipButton_Click);
            // 
            // deleteRelationshipButton
            // 
            this.deleteRelationshipButton.Enabled = false;
            this.deleteRelationshipButton.Location = new System.Drawing.Point(525, 401);
            this.deleteRelationshipButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deleteRelationshipButton.Name = "deleteRelationshipButton";
            this.deleteRelationshipButton.Size = new System.Drawing.Size(150, 50);
            this.deleteRelationshipButton.TabIndex = 3;
            this.deleteRelationshipButton.Text = "Delete";
            this.deleteRelationshipButton.UseVisualStyleBackColor = true;
            this.deleteRelationshipButton.Click += new System.EventHandler(this.deleteRelationshipButton_Click);
            // 
            // DependentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 518);
            this.Controls.Add(this.deleteRelationshipButton);
            this.Controls.Add(this.editRelationshipButton);
            this.Controls.Add(this.addRelationshipButton);
            this.Controls.Add(this.dependentListView);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DependentForm";
            this.Text = "DependentForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView dependentListView;
        private System.Windows.Forms.ColumnHeader nameColumn;
        private System.Windows.Forms.ColumnHeader lastNameColumn;
        private System.Windows.Forms.ColumnHeader ageColumn;
        private System.Windows.Forms.ColumnHeader relationshipColumn;
        private System.Windows.Forms.Button addRelationshipButton;
        private System.Windows.Forms.Button editRelationshipButton;
        private System.Windows.Forms.Button deleteRelationshipButton;
    }
}