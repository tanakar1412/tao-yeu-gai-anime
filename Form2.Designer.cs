namespace asmc_2
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            panel1 = new Panel();
            txtPublisher = new TextBox();
            txtGerne = new TextBox();
            txtYear = new TextBox();
            txtTitle = new TextBox();
            txtAuthors = new TextBox();
            txtID = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            label8 = new Label();
            menuStrip1 = new MenuStrip();
            bookMaToolStripMenuItem = new ToolStripMenuItem();
            bookManagementToolStripMenuItem = new ToolStripMenuItem();
            readerManagementToolStripMenuItem = new ToolStripMenuItem();
            borrowBookMngToolStripMenuItem = new ToolStripMenuItem();
            totalReportToolStripMenuItem = new ToolStripMenuItem();
            panel2 = new Panel();
            label9 = new Label();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnRemove = new Button();
            btnRefresh = new Button();
            panel3 = new Panel();
            label10 = new Label();
            txtSearch = new TextBox();
            btnFind = new Button();
            label11 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label11);
            panel1.Controls.Add(txtPublisher);
            panel1.Controls.Add(txtGerne);
            panel1.Controls.Add(txtYear);
            panel1.Controls.Add(txtTitle);
            panel1.Controls.Add(txtAuthors);
            panel1.Controls.Add(txtID);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(73, 120);
            panel1.Name = "panel1";
            panel1.Size = new Size(1232, 229);
            panel1.TabIndex = 0;
            // 
            // txtPublisher
            // 
            txtPublisher.Location = new Point(905, 119);
            txtPublisher.Name = "txtPublisher";
            txtPublisher.Size = new Size(125, 27);
            txtPublisher.TabIndex = 12;
            // 
            // txtGerne
            // 
            txtGerne.Location = new Point(905, 67);
            txtGerne.Name = "txtGerne";
            txtGerne.Size = new Size(125, 27);
            txtGerne.TabIndex = 11;
            // 
            // txtYear
            // 
            txtYear.Location = new Point(523, 119);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(125, 27);
            txtYear.TabIndex = 10;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(523, 67);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(125, 27);
            txtTitle.TabIndex = 9;
            // 
            // txtAuthors
            // 
            txtAuthors.Location = new Point(112, 116);
            txtAuthors.Name = "txtAuthors";
            txtAuthors.Size = new Size(125, 27);
            txtAuthors.TabIndex = 8;
            // 
            // txtID
            // 
            txtID.Location = new Point(112, 67);
            txtID.Name = "txtID";
            txtID.Size = new Size(125, 27);
            txtID.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(796, 119);
            label7.Name = "label7";
            label7.Size = new Size(69, 20);
            label7.TabIndex = 6;
            label7.Text = "Publisher";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(796, 67);
            label6.Name = "label6";
            label6.Size = new Size(48, 20);
            label6.TabIndex = 5;
            label6.Text = "Genre";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(366, 119);
            label5.Name = "label5";
            label5.Size = new Size(112, 20);
            label5.TabIndex = 4;
            label5.Text = "Year Of Release";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(366, 67);
            label4.Name = "label4";
            label4.Size = new Size(76, 20);
            label4.TabIndex = 3;
            label4.Text = "Book Title";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 119);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 2;
            label3.Text = "Authors";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 67);
            label2.Name = "label2";
            label2.Size = new Size(24, 20);
            label2.TabIndex = 1;
            label2.Text = "ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(-423, 59);
            label1.Name = "label1";
            label1.Size = new Size(126, 20);
            label1.TabIndex = 0;
            label1.Text = "Books Infomation";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dataGridView1.Location = new Point(73, 378);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1232, 241);
            dataGridView1.TabIndex = 1;
            // 
            // Column1
            // 
            Column1.HeaderText = "ID";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Book Title";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Genre";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Authors";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Year Of Release";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.HeaderText = "Publisher";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(73, 355);
            label8.Name = "label8";
            label8.Size = new Size(54, 20);
            label8.TabIndex = 2;
            label8.Text = "Da List";
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.AppWorkspace;
            menuStrip1.GripStyle = ToolStripGripStyle.Visible;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { bookMaToolStripMenuItem, bookManagementToolStripMenuItem, readerManagementToolStripMenuItem, borrowBookMngToolStripMenuItem, totalReportToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1373, 28);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // bookMaToolStripMenuItem
            // 
            bookMaToolStripMenuItem.Name = "bookMaToolStripMenuItem";
            bookMaToolStripMenuItem.Size = new Size(149, 24);
            bookMaToolStripMenuItem.Text = "book management";
            bookMaToolStripMenuItem.Click += bookMaToolStripMenuItem_Click;
            // 
            // bookManagementToolStripMenuItem
            // 
            bookManagementToolStripMenuItem.Name = "bookManagementToolStripMenuItem";
            bookManagementToolStripMenuItem.Size = new Size(167, 24);
            bookManagementToolStripMenuItem.Text = "account management";
            // 
            // readerManagementToolStripMenuItem
            // 
            readerManagementToolStripMenuItem.Name = "readerManagementToolStripMenuItem";
            readerManagementToolStripMenuItem.Size = new Size(158, 24);
            readerManagementToolStripMenuItem.Text = "reader management";
            // 
            // borrowBookMngToolStripMenuItem
            // 
            borrowBookMngToolStripMenuItem.Name = "borrowBookMngToolStripMenuItem";
            borrowBookMngToolStripMenuItem.Size = new Size(143, 24);
            borrowBookMngToolStripMenuItem.Text = "borrow book mng";
            // 
            // totalReportToolStripMenuItem
            // 
            totalReportToolStripMenuItem.Name = "totalReportToolStripMenuItem";
            totalReportToolStripMenuItem.Size = new Size(105, 24);
            totalReportToolStripMenuItem.Text = "Total Report";
            // 
            // panel2
            // 
            panel2.Controls.Add(btnRefresh);
            panel2.Controls.Add(btnRemove);
            panel2.Controls.Add(btnUpdate);
            panel2.Controls.Add(btnAdd);
            panel2.Controls.Add(label9);
            panel2.Location = new Point(73, 641);
            panel2.Name = "panel2";
            panel2.Size = new Size(530, 86);
            panel2.TabIndex = 4;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(0, 0);
            label9.Name = "label9";
            label9.Size = new Size(44, 20);
            label9.TabIndex = 5;
            label9.Text = "Tools";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(23, 40);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(143, 40);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(263, 40);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(94, 29);
            btnRemove.TabIndex = 8;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(384, 40);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(94, 29);
            btnRefresh.TabIndex = 9;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnFind);
            panel3.Controls.Add(txtSearch);
            panel3.Controls.Add(label10);
            panel3.Location = new Point(648, 641);
            panel3.Name = "panel3";
            panel3.Size = new Size(657, 85);
            panel3.TabIndex = 5;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(3, 0);
            label10.Name = "label10";
            label10.Size = new Size(82, 20);
            label10.TabIndex = 6;
            label10.Text = "Search Box";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(18, 29);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(482, 27);
            txtSearch.TabIndex = 7;
            // 
            // btnFind
            // 
            btnFind.Location = new Point(523, 29);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(94, 29);
            btnFind.TabIndex = 8;
            btnFind.Text = "Find";
            btnFind.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(0, 0);
            label11.Name = "label11";
            label11.Size = new Size(120, 20);
            label11.TabIndex = 13;
            label11.Text = "Book Infomation";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1373, 722);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(label8);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Form2";
            Text = "Library";
            Load += Form2_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label3;
        private Label label2;
        private TextBox txtID;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox txtPublisher;
        private TextBox txtGerne;
        private TextBox txtYear;
        private TextBox txtTitle;
        private TextBox txtAuthors;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private Label label8;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem bookMaToolStripMenuItem;
        private ToolStripMenuItem bookManagementToolStripMenuItem;
        private ToolStripMenuItem readerManagementToolStripMenuItem;
        private ToolStripMenuItem borrowBookMngToolStripMenuItem;
        private ToolStripMenuItem totalReportToolStripMenuItem;
        private Panel panel2;
        private Button btnRefresh;
        private Button btnRemove;
        private Button btnUpdate;
        private Button btnAdd;
        private Label label9;
        private Panel panel3;
        private Label label11;
        private Button btnFind;
        private TextBox txtSearch;
        private Label label10;
    }
}