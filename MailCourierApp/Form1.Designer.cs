namespace MailCourierApp
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
            components = new System.ComponentModel.Container();
            btnListTasks = new Button();
            btnClearTheList = new Button();
            listBox1 = new ListBox();
            dataGridView1 = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            taskNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            isRunningDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            isStartedDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            secondDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nextRunningDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            mailTaskBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mailTaskBindingSource).BeginInit();
            SuspendLayout();
            // 
            // btnListTasks
            // 
            btnListTasks.Dock = DockStyle.Top;
            btnListTasks.Location = new Point(0, 0);
            btnListTasks.Name = "btnListTasks";
            btnListTasks.Size = new Size(786, 39);
            btnListTasks.TabIndex = 0;
            btnListTasks.Text = "List Mail Tasks";
            btnListTasks.UseVisualStyleBackColor = true;
            btnListTasks.Click += button1_Click;
            // 
            // btnClearTheList
            // 
            btnClearTheList.Dock = DockStyle.Bottom;
            btnClearTheList.Location = new Point(0, 428);
            btnClearTheList.Name = "btnClearTheList";
            btnClearTheList.Size = new Size(786, 41);
            btnClearTheList.TabIndex = 1;
            btnClearTheList.Text = "Clear the list.";
            btnClearTheList.UseVisualStyleBackColor = true;
            btnClearTheList.Click += btnClearTheList_Click;
            // 
            // listBox1
            // 
            listBox1.Dock = DockStyle.Bottom;
            listBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            listBox1.ItemHeight = 17;
            listBox1.Location = new Point(0, 469);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(786, 208);
            listBox1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, taskNameDataGridViewTextBoxColumn, isRunningDataGridViewCheckBoxColumn, isStartedDataGridViewCheckBoxColumn, secondDataGridViewTextBoxColumn, nextRunningDataGridViewTextBoxColumn });
            dataGridView1.DataSource = mailTaskBindingSource;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 39);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(786, 389);
            dataGridView1.TabIndex = 2;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "id";
            idDataGridViewTextBoxColumn.HeaderText = "id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Width = 42;
            // 
            // taskNameDataGridViewTextBoxColumn
            // 
            taskNameDataGridViewTextBoxColumn.DataPropertyName = "taskName";
            taskNameDataGridViewTextBoxColumn.HeaderText = "taskName";
            taskNameDataGridViewTextBoxColumn.Name = "taskNameDataGridViewTextBoxColumn";
            taskNameDataGridViewTextBoxColumn.ReadOnly = true;
            taskNameDataGridViewTextBoxColumn.Width = 85;
            // 
            // isRunningDataGridViewCheckBoxColumn
            // 
            isRunningDataGridViewCheckBoxColumn.DataPropertyName = "isRunning";
            isRunningDataGridViewCheckBoxColumn.HeaderText = "isRunning";
            isRunningDataGridViewCheckBoxColumn.Name = "isRunningDataGridViewCheckBoxColumn";
            isRunningDataGridViewCheckBoxColumn.ReadOnly = true;
            isRunningDataGridViewCheckBoxColumn.Width = 66;
            // 
            // isStartedDataGridViewCheckBoxColumn
            // 
            isStartedDataGridViewCheckBoxColumn.DataPropertyName = "isStarted";
            isStartedDataGridViewCheckBoxColumn.HeaderText = "isStarted";
            isStartedDataGridViewCheckBoxColumn.Name = "isStartedDataGridViewCheckBoxColumn";
            isStartedDataGridViewCheckBoxColumn.ReadOnly = true;
            isStartedDataGridViewCheckBoxColumn.Width = 58;
            // 
            // secondDataGridViewTextBoxColumn
            // 
            secondDataGridViewTextBoxColumn.DataPropertyName = "second";
            secondDataGridViewTextBoxColumn.HeaderText = "second";
            secondDataGridViewTextBoxColumn.Name = "secondDataGridViewTextBoxColumn";
            secondDataGridViewTextBoxColumn.ReadOnly = true;
            secondDataGridViewTextBoxColumn.Width = 70;
            // 
            // nextRunningDataGridViewTextBoxColumn
            // 
            nextRunningDataGridViewTextBoxColumn.DataPropertyName = "NextRunning";
            nextRunningDataGridViewTextBoxColumn.HeaderText = "NextRunning";
            nextRunningDataGridViewTextBoxColumn.Name = "nextRunningDataGridViewTextBoxColumn";
            nextRunningDataGridViewTextBoxColumn.ReadOnly = true;
            nextRunningDataGridViewTextBoxColumn.Width = 102;
            // 
            // mailTaskBindingSource
            // 
            mailTaskBindingSource.DataSource = typeof(MailTask);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(786, 677);
            Controls.Add(dataGridView1);
            Controls.Add(btnClearTheList);
            Controls.Add(btnListTasks);
            Controls.Add(listBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)mailTaskBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnListTasks;
        private Button btnClearTheList;
        private ListBox listBox1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn myPropertyDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn taskNameDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn isRunningDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn isStartedDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn secondDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nextRunningDataGridViewTextBoxColumn;
        private BindingSource mailTaskBindingSource;
    }
}