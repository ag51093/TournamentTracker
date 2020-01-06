namespace TrackerUI
{
    partial class CreateTeamForm
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
            this.teamNameValue = new System.Windows.Forms.TextBox();
            this.teamNameLabel = new System.Windows.Forms.Label();
            this.headerLabel = new System.Windows.Forms.Label();
            this.addMemberButton = new System.Windows.Forms.Button();
            this.selectMemberDropDown = new System.Windows.Forms.ComboBox();
            this.selectMemberLabel = new System.Windows.Forms.Label();
            this.cellphoneValue = new System.Windows.Forms.GroupBox();
            this.firstNameValue = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameValue = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.emaiLabel = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.cellphoneLabel = new System.Windows.Forms.Label();
            this.createMemberButton = new System.Windows.Forms.Button();
            this.deleteSelectedMemberButton = new System.Windows.Forms.Button();
            this.membersLabel = new System.Windows.Forms.Label();
            this.membersListBox = new System.Windows.Forms.ListBox();
            this.createTeamButton = new System.Windows.Forms.Button();
            this.cellphoneValue.SuspendLayout();
            this.SuspendLayout();
            // 
            // teamNameValue
            // 
            this.teamNameValue.Location = new System.Drawing.Point(36, 138);
            this.teamNameValue.Name = "teamNameValue";
            this.teamNameValue.Size = new System.Drawing.Size(308, 35);
            this.teamNameValue.TabIndex = 13;
            // 
            // teamNameLabel
            // 
            this.teamNameLabel.AutoSize = true;
            this.teamNameLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamNameLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.teamNameLabel.Location = new System.Drawing.Point(29, 98);
            this.teamNameLabel.Name = "teamNameLabel";
            this.teamNameLabel.Size = new System.Drawing.Size(157, 37);
            this.teamNameLabel.TabIndex = 12;
            this.teamNameLabel.Text = "Team Name";
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.headerLabel.Location = new System.Drawing.Point(27, 27);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(213, 50);
            this.headerLabel.TabIndex = 11;
            this.headerLabel.Text = "Create Team";
            // 
            // addMemberButton
            // 
            this.addMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.addMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.addMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.addMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addMemberButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMemberButton.ForeColor = System.Drawing.Color.DodgerBlue;
            this.addMemberButton.Location = new System.Drawing.Point(170, 269);
            this.addMemberButton.Name = "addMemberButton";
            this.addMemberButton.Size = new System.Drawing.Size(174, 43);
            this.addMemberButton.TabIndex = 19;
            this.addMemberButton.Text = "Add Member";
            this.addMemberButton.UseVisualStyleBackColor = true;
            // 
            // selectMemberDropDown
            // 
            this.selectMemberDropDown.FormattingEnabled = true;
            this.selectMemberDropDown.Location = new System.Drawing.Point(36, 225);
            this.selectMemberDropDown.Name = "selectMemberDropDown";
            this.selectMemberDropDown.Size = new System.Drawing.Size(308, 38);
            this.selectMemberDropDown.TabIndex = 18;
            // 
            // selectMemberLabel
            // 
            this.selectMemberLabel.AutoSize = true;
            this.selectMemberLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectMemberLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.selectMemberLabel.Location = new System.Drawing.Point(29, 185);
            this.selectMemberLabel.Name = "selectMemberLabel";
            this.selectMemberLabel.Size = new System.Drawing.Size(194, 37);
            this.selectMemberLabel.TabIndex = 17;
            this.selectMemberLabel.Text = "Select Member";
            // 
            // cellphoneValue
            // 
            this.cellphoneValue.Controls.Add(this.createMemberButton);
            this.cellphoneValue.Controls.Add(this.textBox2);
            this.cellphoneValue.Controls.Add(this.cellphoneLabel);
            this.cellphoneValue.Controls.Add(this.textBox1);
            this.cellphoneValue.Controls.Add(this.emaiLabel);
            this.cellphoneValue.Controls.Add(this.lastNameValue);
            this.cellphoneValue.Controls.Add(this.lastNameLabel);
            this.cellphoneValue.Controls.Add(this.firstNameValue);
            this.cellphoneValue.Controls.Add(this.firstNameLabel);
            this.cellphoneValue.ForeColor = System.Drawing.Color.DodgerBlue;
            this.cellphoneValue.Location = new System.Drawing.Point(36, 318);
            this.cellphoneValue.Name = "cellphoneValue";
            this.cellphoneValue.Size = new System.Drawing.Size(490, 330);
            this.cellphoneValue.TabIndex = 20;
            this.cellphoneValue.TabStop = false;
            this.cellphoneValue.Text = "Add New Member";
            // 
            // firstNameValue
            // 
            this.firstNameValue.Location = new System.Drawing.Point(188, 40);
            this.firstNameValue.Name = "firstNameValue";
            this.firstNameValue.Size = new System.Drawing.Size(286, 35);
            this.firstNameValue.TabIndex = 10;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.firstNameLabel.Location = new System.Drawing.Point(6, 40);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(150, 37);
            this.firstNameLabel.TabIndex = 9;
            this.firstNameLabel.Text = "First Name:";
            // 
            // lastNameValue
            // 
            this.lastNameValue.Location = new System.Drawing.Point(188, 96);
            this.lastNameValue.Name = "lastNameValue";
            this.lastNameValue.Size = new System.Drawing.Size(286, 35);
            this.lastNameValue.TabIndex = 12;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lastNameLabel.Location = new System.Drawing.Point(6, 96);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(148, 37);
            this.lastNameLabel.TabIndex = 11;
            this.lastNameLabel.Text = "Last Name:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(188, 153);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(286, 35);
            this.textBox1.TabIndex = 14;
            // 
            // emaiLabel
            // 
            this.emaiLabel.AutoSize = true;
            this.emaiLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emaiLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.emaiLabel.Location = new System.Drawing.Point(6, 153);
            this.emaiLabel.Name = "emaiLabel";
            this.emaiLabel.Size = new System.Drawing.Size(88, 37);
            this.emaiLabel.TabIndex = 13;
            this.emaiLabel.Text = "Email:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(188, 206);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(286, 35);
            this.textBox2.TabIndex = 16;
            // 
            // cellphoneLabel
            // 
            this.cellphoneLabel.AutoSize = true;
            this.cellphoneLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cellphoneLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.cellphoneLabel.Location = new System.Drawing.Point(6, 206);
            this.cellphoneLabel.Name = "cellphoneLabel";
            this.cellphoneLabel.Size = new System.Drawing.Size(144, 37);
            this.cellphoneLabel.TabIndex = 15;
            this.cellphoneLabel.Text = "Cellphone:";
            // 
            // createMemberButton
            // 
            this.createMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.createMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.createMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createMemberButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createMemberButton.ForeColor = System.Drawing.Color.DodgerBlue;
            this.createMemberButton.Location = new System.Drawing.Point(134, 257);
            this.createMemberButton.Name = "createMemberButton";
            this.createMemberButton.Size = new System.Drawing.Size(214, 49);
            this.createMemberButton.TabIndex = 20;
            this.createMemberButton.Text = "Create Member";
            this.createMemberButton.UseVisualStyleBackColor = true;
            // 
            // deleteSelectedMemberButton
            // 
            this.deleteSelectedMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.deleteSelectedMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.deleteSelectedMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.deleteSelectedMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteSelectedMemberButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteSelectedMemberButton.ForeColor = System.Drawing.Color.DodgerBlue;
            this.deleteSelectedMemberButton.Location = new System.Drawing.Point(1048, 362);
            this.deleteSelectedMemberButton.Name = "deleteSelectedMemberButton";
            this.deleteSelectedMemberButton.Size = new System.Drawing.Size(165, 85);
            this.deleteSelectedMemberButton.TabIndex = 23;
            this.deleteSelectedMemberButton.Text = "Delete Selected";
            this.deleteSelectedMemberButton.UseVisualStyleBackColor = true;
            // 
            // membersLabel
            // 
            this.membersLabel.AutoSize = true;
            this.membersLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.membersLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.membersLabel.Location = new System.Drawing.Point(629, 43);
            this.membersLabel.Name = "membersLabel";
            this.membersLabel.Size = new System.Drawing.Size(128, 37);
            this.membersLabel.TabIndex = 22;
            this.membersLabel.Text = "Members";
            // 
            // membersListBox
            // 
            this.membersListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.membersListBox.FormattingEnabled = true;
            this.membersListBox.ItemHeight = 30;
            this.membersListBox.Location = new System.Drawing.Point(636, 83);
            this.membersListBox.Name = "membersListBox";
            this.membersListBox.Size = new System.Drawing.Size(386, 542);
            this.membersListBox.TabIndex = 21;
            // 
            // createTeamButton
            // 
            this.createTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.createTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.createTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTeamButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createTeamButton.ForeColor = System.Drawing.Color.DodgerBlue;
            this.createTeamButton.Location = new System.Drawing.Point(423, 677);
            this.createTeamButton.Name = "createTeamButton";
            this.createTeamButton.Size = new System.Drawing.Size(477, 49);
            this.createTeamButton.TabIndex = 25;
            this.createTeamButton.Text = "Create Team";
            this.createTeamButton.UseVisualStyleBackColor = true;
            // 
            // CreateTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1276, 749);
            this.Controls.Add(this.createTeamButton);
            this.Controls.Add(this.deleteSelectedMemberButton);
            this.Controls.Add(this.membersLabel);
            this.Controls.Add(this.membersListBox);
            this.Controls.Add(this.cellphoneValue);
            this.Controls.Add(this.addMemberButton);
            this.Controls.Add(this.selectMemberDropDown);
            this.Controls.Add(this.selectMemberLabel);
            this.Controls.Add(this.teamNameValue);
            this.Controls.Add(this.teamNameLabel);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "CreateTeamForm";
            this.Text = "Create Team";
            this.cellphoneValue.ResumeLayout(false);
            this.cellphoneValue.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox teamNameValue;
        private System.Windows.Forms.Label teamNameLabel;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Button addMemberButton;
        private System.Windows.Forms.ComboBox selectMemberDropDown;
        private System.Windows.Forms.Label selectMemberLabel;
        private System.Windows.Forms.GroupBox cellphoneValue;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label cellphoneLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label emaiLabel;
        private System.Windows.Forms.TextBox lastNameValue;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox firstNameValue;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Button createMemberButton;
        private System.Windows.Forms.Button deleteSelectedMemberButton;
        private System.Windows.Forms.Label membersLabel;
        private System.Windows.Forms.ListBox membersListBox;
        private System.Windows.Forms.Button createTeamButton;
    }
}