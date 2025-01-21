namespace Banking_management_system
{
    partial class AdminTransactions
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
            adminDataGridView2 = new DataGridView();
            exportDataGridButton = new Button();
            button1 = new Button();
            adminDataGridView3 = new DataGridView();
            adminComboBox2 = new ComboBox();
            viewUserTransacButton = new Button();
            ((System.ComponentModel.ISupportInitialize)adminDataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)adminDataGridView3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(72, 31);
            label1.Name = "label1";
            label1.Size = new Size(286, 38);
            label1.TabIndex = 0;
            label1.Text = "All user transactions..";
            // 
            // adminDataGridView2
            // 
            adminDataGridView2.BackgroundColor = SystemColors.ButtonFace;
            adminDataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            adminDataGridView2.Location = new Point(72, 101);
            adminDataGridView2.Name = "adminDataGridView2";
            adminDataGridView2.RowHeadersWidth = 51;
            adminDataGridView2.Size = new Size(532, 265);
            adminDataGridView2.TabIndex = 1;
            // 
            // exportDataGridButton
            // 
            exportDataGridButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exportDataGridButton.Location = new Point(1128, 40);
            exportDataGridButton.Name = "exportDataGridButton";
            exportDataGridButton.Size = new Size(94, 29);
            exportDataGridButton.TabIndex = 3;
            exportDataGridButton.Text = "Export";
            exportDataGridButton.UseVisualStyleBackColor = true;
            exportDataGridButton.Click += exportDataGridButton_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.Location = new Point(25, 409);
            button1.Name = "button1";
            button1.Size = new Size(178, 29);
            button1.TabIndex = 4;
            button1.Text = "Back to Home Page";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // adminDataGridView3
            // 
            adminDataGridView3.BackgroundColor = SystemColors.ButtonFace;
            adminDataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            adminDataGridView3.Location = new Point(671, 101);
            adminDataGridView3.Name = "adminDataGridView3";
            adminDataGridView3.RowHeadersWidth = 51;
            adminDataGridView3.Size = new Size(551, 265);
            adminDataGridView3.TabIndex = 5;
            // 
            // adminComboBox2
            // 
            adminComboBox2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            adminComboBox2.FormattingEnabled = true;
            adminComboBox2.Location = new Point(671, 39);
            adminComboBox2.Name = "adminComboBox2";
            adminComboBox2.Size = new Size(212, 28);
            adminComboBox2.TabIndex = 6;
            // 
            // viewUserTransacButton
            // 
            viewUserTransacButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            viewUserTransacButton.Location = new Point(909, 40);
            viewUserTransacButton.Name = "viewUserTransacButton";
            viewUserTransacButton.Size = new Size(142, 29);
            viewUserTransacButton.TabIndex = 7;
            viewUserTransacButton.Text = "View transaction";
            viewUserTransacButton.UseVisualStyleBackColor = true;
            viewUserTransacButton.Click += viewUserTransacButton_Click;
            // 
            // AdminTransactions
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(1274, 459);
            Controls.Add(viewUserTransacButton);
            Controls.Add(adminComboBox2);
            Controls.Add(adminDataGridView3);
            Controls.Add(button1);
            Controls.Add(exportDataGridButton);
            Controls.Add(adminDataGridView2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "AdminTransactions";
            Text = "Admin Transactions";
            Load += AdminTransactions_Load;
            ((System.ComponentModel.ISupportInitialize)adminDataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)adminDataGridView3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView adminDataGridView2;
        private Button exportDataGridButton;
        private Button button1;
        private DataGridView adminDataGridView3;
        private ComboBox adminComboBox2;
        private Button viewUserTransacButton;
    }
}