namespace Banking_management_system
{
    partial class AdminHomePage
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            nameTextBox = new TextBox();
            emailTextBox = new TextBox();
            depositTextBox = new TextBox();
            createAccountButton = new Button();
            emailUpdateButton = new Button();
            label4 = new Label();
            label5 = new Label();
            accTypeTextBox = new TextBox();
            pwTextBox = new TextBox();
            passwordUpdateButton = new Button();
            accountDeleteButton = new Button();
            AdminComboBox1 = new ComboBox();
            adminUserDataView = new DataGridView();
            viewTransactionsButton = new Button();
            adminLogoutButton = new Button();
            nameUpdateButton = new Button();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)adminUserDataView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(73, 105);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(73, 212);
            label2.Name = "label2";
            label2.Size = new Size(120, 20);
            label2.TabIndex = 1;
            label2.Text = "Deposit Amount";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(73, 268);
            label3.Name = "label3";
            label3.Size = new Size(101, 20);
            label3.TabIndex = 2;
            label3.Text = "Account Type";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(253, 98);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(125, 27);
            nameTextBox.TabIndex = 3;
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(253, 152);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(125, 27);
            emailTextBox.TabIndex = 4;
            // 
            // depositTextBox
            // 
            depositTextBox.Location = new Point(253, 205);
            depositTextBox.Name = "depositTextBox";
            depositTextBox.Size = new Size(125, 27);
            depositTextBox.TabIndex = 5;
            // 
            // createAccountButton
            // 
            createAccountButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            createAccountButton.Location = new Point(253, 377);
            createAccountButton.Name = "createAccountButton";
            createAccountButton.Size = new Size(125, 29);
            createAccountButton.TabIndex = 6;
            createAccountButton.Text = "Create Account";
            createAccountButton.UseVisualStyleBackColor = true;
            createAccountButton.Click += createAccountButton_Click;
            // 
            // emailUpdateButton
            // 
            emailUpdateButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            emailUpdateButton.Location = new Point(436, 152);
            emailUpdateButton.Name = "emailUpdateButton";
            emailUpdateButton.Size = new Size(94, 29);
            emailUpdateButton.TabIndex = 7;
            emailUpdateButton.Text = "Update";
            emailUpdateButton.UseVisualStyleBackColor = true;
            emailUpdateButton.Click += emailUpdateButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(73, 159);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 9;
            label4.Text = "Email ID";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(73, 325);
            label5.Name = "label5";
            label5.Size = new Size(73, 20);
            label5.TabIndex = 10;
            label5.Text = "Password";
            // 
            // accTypeTextBox
            // 
            accTypeTextBox.Location = new Point(253, 261);
            accTypeTextBox.Name = "accTypeTextBox";
            accTypeTextBox.Size = new Size(125, 27);
            accTypeTextBox.TabIndex = 11;
            // 
            // pwTextBox
            // 
            pwTextBox.Location = new Point(253, 318);
            pwTextBox.Name = "pwTextBox";
            pwTextBox.Size = new Size(125, 27);
            pwTextBox.TabIndex = 12;
            // 
            // passwordUpdateButton
            // 
            passwordUpdateButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            passwordUpdateButton.Location = new Point(436, 316);
            passwordUpdateButton.Name = "passwordUpdateButton";
            passwordUpdateButton.Size = new Size(94, 29);
            passwordUpdateButton.TabIndex = 14;
            passwordUpdateButton.Text = "Update";
            passwordUpdateButton.UseVisualStyleBackColor = true;
            passwordUpdateButton.Click += passwordUpdateButton_Click;
            // 
            // accountDeleteButton
            // 
            accountDeleteButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            accountDeleteButton.Location = new Point(1027, 36);
            accountDeleteButton.Name = "accountDeleteButton";
            accountDeleteButton.Size = new Size(134, 29);
            accountDeleteButton.TabIndex = 15;
            accountDeleteButton.Text = "Delete Account";
            accountDeleteButton.UseVisualStyleBackColor = true;
            accountDeleteButton.Click += accountDeleteButton_Click;
            // 
            // AdminComboBox1
            // 
            AdminComboBox1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AdminComboBox1.FormattingEnabled = true;
            AdminComboBox1.Location = new Point(253, 37);
            AdminComboBox1.Name = "AdminComboBox1";
            AdminComboBox1.Size = new Size(305, 28);
            AdminComboBox1.TabIndex = 17;
            // 
            // adminUserDataView
            // 
            adminUserDataView.BackgroundColor = SystemColors.ButtonFace;
            adminUserDataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            adminUserDataView.Location = new Point(610, 98);
            adminUserDataView.Name = "adminUserDataView";
            adminUserDataView.RowHeadersWidth = 51;
            adminUserDataView.Size = new Size(551, 247);
            adminUserDataView.TabIndex = 18;
            // 
            // viewTransactionsButton
            // 
            viewTransactionsButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            viewTransactionsButton.Location = new Point(997, 377);
            viewTransactionsButton.Name = "viewTransactionsButton";
            viewTransactionsButton.Size = new Size(164, 29);
            viewTransactionsButton.TabIndex = 19;
            viewTransactionsButton.Text = "View all transactions";
            viewTransactionsButton.UseVisualStyleBackColor = true;
            viewTransactionsButton.Click += viewTransactionsButton_Click;
            // 
            // adminLogoutButton
            // 
            adminLogoutButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            adminLogoutButton.Location = new Point(73, 446);
            adminLogoutButton.Name = "adminLogoutButton";
            adminLogoutButton.Size = new Size(94, 29);
            adminLogoutButton.TabIndex = 22;
            adminLogoutButton.Text = "Logout";
            adminLogoutButton.UseVisualStyleBackColor = true;
            adminLogoutButton.Click += adminLogoutButton_Click;
            // 
            // nameUpdateButton
            // 
            nameUpdateButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nameUpdateButton.Location = new Point(436, 98);
            nameUpdateButton.Name = "nameUpdateButton";
            nameUpdateButton.Size = new Size(94, 29);
            nameUpdateButton.TabIndex = 23;
            nameUpdateButton.Text = "Update";
            nameUpdateButton.UseVisualStyleBackColor = true;
            nameUpdateButton.Click += nameUpdateButton_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(71, 42);
            label6.Name = "label6";
            label6.Size = new Size(109, 20);
            label6.TabIndex = 24;
            label6.Text = "Select from list";
            // 
            // AdminHomePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(1236, 500);
            Controls.Add(label6);
            Controls.Add(nameUpdateButton);
            Controls.Add(adminLogoutButton);
            Controls.Add(viewTransactionsButton);
            Controls.Add(adminUserDataView);
            Controls.Add(AdminComboBox1);
            Controls.Add(accountDeleteButton);
            Controls.Add(passwordUpdateButton);
            Controls.Add(pwTextBox);
            Controls.Add(accTypeTextBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(emailUpdateButton);
            Controls.Add(createAccountButton);
            Controls.Add(depositTextBox);
            Controls.Add(emailTextBox);
            Controls.Add(nameTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "AdminHomePage";
            Text = "Admin Home Page";
            ((System.ComponentModel.ISupportInitialize)adminUserDataView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox nameTextBox;
        private TextBox emailTextBox;
        private TextBox depositTextBox;
        private Button createAccountButton;
        private Button emailUpdateButton;
        private Label label4;
        private Label label5;
        private TextBox accTypeTextBox;
        private TextBox pwTextBox;
        private Button passwordUpdateButton;
        private Button accountDeleteButton;
        private ComboBox AdminComboBox1;
        private DataGridView adminUserDataView;
        private Button viewTransactionsButton;
        private Button adminLogoutButton;
        private Button nameUpdateButton;
        private Label label6;
    }
}