namespace Banking_management_system
{
    partial class UserHomePage
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
            AccountNumTextBox = new TextBox();
            UserDataGridView1 = new DataGridView();
            label2 = new Label();
            userNametTextBox = new TextBox();
            emailTextBox = new TextBox();
            label3 = new Label();
            label4 = new Label();
            pwTextBox = new TextBox();
            emailUpdateButton = new Button();
            pwUpdateButton = new Button();
            userTransactionbutton = new Button();
            depositButton = new Button();
            label5 = new Label();
            AmountTextBox = new TextBox();
            withdrawButton = new Button();
            label6 = new Label();
            RecipientAccNumTextBox = new TextBox();
            transferButton = new Button();
            button1 = new Button();
            viewUserDetailsButton = new Button();
            ((System.ComponentModel.ISupportInitialize)UserDataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(64, 80);
            label1.Name = "label1";
            label1.Size = new Size(98, 20);
            label1.TabIndex = 0;
            label1.Text = "User A/C No.";
            // 
            // AccountNumTextBox
            // 
            AccountNumTextBox.Location = new Point(253, 73);
            AccountNumTextBox.Name = "AccountNumTextBox";
            AccountNumTextBox.Size = new Size(125, 27);
            AccountNumTextBox.TabIndex = 1;
            // 
            // UserDataGridView1
            // 
            UserDataGridView1.BackgroundColor = SystemColors.ButtonFace;
            UserDataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            UserDataGridView1.Location = new Point(588, 196);
            UserDataGridView1.Name = "UserDataGridView1";
            UserDataGridView1.RowHeadersWidth = 51;
            UserDataGridView1.Size = new Size(587, 97);
            UserDataGridView1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(64, 141);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 3;
            label2.Text = "Name";
            // 
            // userNametTextBox
            // 
            userNametTextBox.Location = new Point(253, 134);
            userNametTextBox.Name = "userNametTextBox";
            userNametTextBox.Size = new Size(125, 27);
            userNametTextBox.TabIndex = 4;
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(253, 201);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(125, 27);
            emailTextBox.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(64, 201);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 6;
            label3.Text = "Email ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(64, 273);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
            label4.TabIndex = 7;
            label4.Text = "Password";
            // 
            // pwTextBox
            // 
            pwTextBox.Location = new Point(253, 266);
            pwTextBox.Name = "pwTextBox";
            pwTextBox.Size = new Size(125, 27);
            pwTextBox.TabIndex = 8;
            // 
            // emailUpdateButton
            // 
            emailUpdateButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            emailUpdateButton.Location = new Point(407, 201);
            emailUpdateButton.Name = "emailUpdateButton";
            emailUpdateButton.Size = new Size(94, 29);
            emailUpdateButton.TabIndex = 10;
            emailUpdateButton.Text = "Update";
            emailUpdateButton.UseVisualStyleBackColor = true;
            emailUpdateButton.Click += emailUpdateButton_Click;
            // 
            // pwUpdateButton
            // 
            pwUpdateButton.BackColor = Color.White;
            pwUpdateButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pwUpdateButton.Location = new Point(407, 264);
            pwUpdateButton.Name = "pwUpdateButton";
            pwUpdateButton.Size = new Size(94, 29);
            pwUpdateButton.TabIndex = 11;
            pwUpdateButton.Text = "Update";
            pwUpdateButton.UseVisualStyleBackColor = false;
            pwUpdateButton.Click += pwUpdateButton_Click;
            // 
            // userTransactionbutton
            // 
            userTransactionbutton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            userTransactionbutton.Location = new Point(986, 338);
            userTransactionbutton.Name = "userTransactionbutton";
            userTransactionbutton.Size = new Size(189, 29);
            userTransactionbutton.TabIndex = 12;
            userTransactionbutton.Text = "View transaction history";
            userTransactionbutton.UseVisualStyleBackColor = true;
            userTransactionbutton.Click += userTransactionButton_Click;
            // 
            // depositButton
            // 
            depositButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            depositButton.Location = new Point(900, 57);
            depositButton.Name = "depositButton";
            depositButton.Size = new Size(123, 29);
            depositButton.TabIndex = 13;
            depositButton.Text = "Deposit money";
            depositButton.UseVisualStyleBackColor = true;
            depositButton.Click += depositButton_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(588, 66);
            label5.Name = "label5";
            label5.Size = new Size(64, 20);
            label5.TabIndex = 14;
            label5.Text = "Amount";
            // 
            // AmountTextBox
            // 
            AmountTextBox.Location = new Point(746, 59);
            AmountTextBox.Name = "AmountTextBox";
            AmountTextBox.Size = new Size(125, 27);
            AmountTextBox.TabIndex = 15;
            // 
            // withdrawButton
            // 
            withdrawButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            withdrawButton.Location = new Point(1052, 57);
            withdrawButton.Name = "withdrawButton";
            withdrawButton.Size = new Size(141, 29);
            withdrawButton.TabIndex = 16;
            withdrawButton.Text = "Withdraw money";
            withdrawButton.UseVisualStyleBackColor = true;
            withdrawButton.Click += withdrawButton_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(588, 125);
            label6.Name = "label6";
            label6.Size = new Size(134, 20);
            label6.TabIndex = 17;
            label6.Text = "Recipient A/C No. ";
            // 
            // RecipientAccNumTextBox
            // 
            RecipientAccNumTextBox.Location = new Point(746, 118);
            RecipientAccNumTextBox.Name = "RecipientAccNumTextBox";
            RecipientAccNumTextBox.Size = new Size(125, 27);
            RecipientAccNumTextBox.TabIndex = 18;
            // 
            // transferButton
            // 
            transferButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            transferButton.Location = new Point(900, 116);
            transferButton.Name = "transferButton";
            transferButton.Size = new Size(134, 29);
            transferButton.TabIndex = 19;
            transferButton.Text = "Transfer money";
            transferButton.UseVisualStyleBackColor = true;
            transferButton.Click += transferButton_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.Location = new Point(64, 428);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 20;
            button1.Text = "logout";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // viewUserDetailsButton
            // 
            viewUserDetailsButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            viewUserDetailsButton.Location = new Point(407, 70);
            viewUserDetailsButton.Name = "viewUserDetailsButton";
            viewUserDetailsButton.Size = new Size(135, 29);
            viewUserDetailsButton.TabIndex = 21;
            viewUserDetailsButton.Text = "View A/C details";
            viewUserDetailsButton.UseVisualStyleBackColor = true;
            viewUserDetailsButton.Click += viewUserDetailsButton_Click;
            // 
            // UserHomePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(1223, 487);
            Controls.Add(viewUserDetailsButton);
            Controls.Add(button1);
            Controls.Add(transferButton);
            Controls.Add(RecipientAccNumTextBox);
            Controls.Add(label6);
            Controls.Add(withdrawButton);
            Controls.Add(AmountTextBox);
            Controls.Add(label5);
            Controls.Add(depositButton);
            Controls.Add(userTransactionbutton);
            Controls.Add(pwUpdateButton);
            Controls.Add(emailUpdateButton);
            Controls.Add(pwTextBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(emailTextBox);
            Controls.Add(userNametTextBox);
            Controls.Add(label2);
            Controls.Add(UserDataGridView1);
            Controls.Add(AccountNumTextBox);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "UserHomePage";
            Text = "User Home Page";
            ((System.ComponentModel.ISupportInitialize)UserDataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox AccountNumTextBox;
        private DataGridView UserDataGridView1;
        private Label label2;
        private TextBox userNametTextBox;
        private TextBox emailTextBox;
        private Label label3;
        private Label label4;
        private TextBox pwTextBox;
        private Button emailUpdateButton;
        private Button pwUpdateButton;
        private Button userTransactionbutton;
        private Button depositButton;
        private Label label5;
        private TextBox AmountTextBox;
        private Button withdrawButton;
        private Label label6;
        private TextBox RecipientAccNumTextBox;
        private Button transferButton;
        private Button button1;
        private Button viewUserDetailsButton;
    }
}