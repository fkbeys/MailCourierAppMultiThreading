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
            panel1 = new Panel();
            btnRun = new Button();
            btnStop = new Button();
            btnStart = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mailTaskBindingSource).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnListTasks
            // 
            btnListTasks.Location = new Point(3, 3);
            btnListTasks.Name = "btnListTasks";
            btnListTasks.Size = new Size(360, 34);
            btnListTasks.TabIndex = 0;
            btnListTasks.Text = "List Mail Tasks";
            btnListTasks.UseVisualStyleBackColor = true;
            btnListTasks.Click += button1_Click;
            // 
            // btnClearTheList
            // 
            btnClearTheList.Dock = DockStyle.Bottom;
            btnClearTheList.Location = new Point(0, 128);
            btnClearTheList.Name = "btnClearTheList";
            btnClearTheList.Size = new Size(786, 35);
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
            listBox1.Location = new Point(0, 163);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(786, 514);
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
            dataGridView1.Location = new Point(0, 49);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(786, 79);
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
            mailTaskBindingSource.CurrentItemChanged += mailTaskBindingSource_CurrentItemChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnRun);
            panel1.Controls.Add(btnStop);
            panel1.Controls.Add(btnStart);
            panel1.Controls.Add(btnListTasks);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(786, 49);
            panel1.TabIndex = 3;
            // 
            // btnRun
            // 
            btnRun.BackColor = Color.Green;
            btnRun.Enabled = false;
            btnRun.ForeColor = Color.Black;
            btnRun.Location = new Point(624, 3);
            btnRun.Name = "btnRun";
            btnRun.Size = new Size(150, 34);
            btnRun.TabIndex = 3;
            btnRun.Text = "Run";
            btnRun.UseVisualStyleBackColor = true;
            btnRun.Click += btnRun_Click;
            // 
            // btnStop
            // 
            btnStop.BackColor = Color.Red;
            btnStop.Enabled = false;
            btnStop.ForeColor = Color.Black;
            btnStop.Location = new Point(369, 3);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(130, 34);
            btnStop.TabIndex = 2;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.Yellow;
            btnStart.Enabled = false;
            btnStart.ForeColor = Color.Black;
            btnStart.Location = new Point(505, 3);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(113, 34);
            btnStart.TabIndex = 1;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(786, 677);
            Controls.Add(dataGridView1);
            Controls.Add(btnClearTheList);
            Controls.Add(listBox1);
            Controls.Add(panel1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)mailTaskBindingSource).EndInit();
            panel1.ResumeLayout(false);
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
        private Panel panel1;
        private Button btnStop;
        private Button btnStart;
        private Button btnRun;
    }
}