namespace EmployeeManagement
{
    partial class MainForm
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
            label1 = new Label();
            IdTextBox = new TextBox();
            label2 = new Label();
            nameTextBox = new TextBox();
            label3 = new Label();
            departmentTextBox = new TextBox();
            label4 = new Label();
            phoneTextBox = new TextBox();
            groupBox1 = new GroupBox();
            insertButton = new Button();
            empDataGridView = new DataGridView();
            deleteButton = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)empDataGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 45);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 0;
            label1.Text = "Id";
            // 
            // IdTextBox
            // 
            IdTextBox.Location = new Point(94, 42);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.Size = new Size(100, 23);
            IdTextBox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 79);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 2;
            label2.Text = "Name";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(94, 76);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(100, 23);
            nameTextBox.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 116);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 4;
            label3.Text = "Department";
            // 
            // departmentTextBox
            // 
            departmentTextBox.Location = new Point(94, 116);
            departmentTextBox.Name = "departmentTextBox";
            departmentTextBox.Size = new Size(100, 23);
            departmentTextBox.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 158);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 6;
            label4.Text = "Phone";
            // 
            // phoneTextBox
            // 
            phoneTextBox.Location = new Point(94, 155);
            phoneTextBox.Name = "phoneTextBox";
            phoneTextBox.Size = new Size(100, 23);
            phoneTextBox.TabIndex = 7;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(insertButton);
            groupBox1.Controls.Add(IdTextBox);
            groupBox1.Controls.Add(phoneTextBox);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(departmentTextBox);
            groupBox1.Controls.Add(nameTextBox);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(27, 61);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(224, 253);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Employee Information";
            // 
            // insertButton
            // 
            insertButton.Location = new Point(94, 204);
            insertButton.Name = "insertButton";
            insertButton.Size = new Size(100, 23);
            insertButton.TabIndex = 8;
            insertButton.Text = "Insert";
            insertButton.UseVisualStyleBackColor = true;
            insertButton.Click += insertButton_Click;
            // 
            // empDataGridView
            // 
            empDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            empDataGridView.Location = new Point(278, 74);
            empDataGridView.MultiSelect = false;
            empDataGridView.Name = "empDataGridView";
            empDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            empDataGridView.Size = new Size(445, 240);
            empDataGridView.TabIndex = 9;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(634, 320);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(89, 31);
            deleteButton.TabIndex = 10;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(776, 363);
            Controls.Add(deleteButton);
            Controls.Add(empDataGridView);
            Controls.Add(groupBox1);
            Name = "MainForm";
            Text = "Main Form";
            Load += MainForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)empDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox IdTextBox;
        private Label label2;
        private TextBox nameTextBox;
        private Label label3;
        private TextBox departmentTextBox;
        private Label label4;
        private TextBox phoneTextBox;
        private GroupBox groupBox1;
        private Button insertButton;
        private DataGridView empDataGridView;
        private Button deleteButton;
    }
}
