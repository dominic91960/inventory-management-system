namespace WindowsFormsApp5
{
    partial class frmCategories
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCategories));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtError = new System.Windows.Forms.TextBox();
            this.txtExit = new System.Windows.Forms.TextBox();
            this.txtEmployees = new System.Windows.Forms.TextBox();
            this.txtProducts = new System.Windows.Forms.TextBox();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtDescription = new WindowsFormsApp5.roundTxt();
            this.txtNewName = new WindowsFormsApp5.roundTxt();
            this.lblEmployees = new System.Windows.Forms.Label();
            this.lblCategories = new System.Windows.Forms.Label();
            this.dgvOne = new System.Windows.Forms.DataGridView();
            this.btnPrint = new System.Windows.Forms.Button();
            this.printPDOne = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocOne = new System.Drawing.Printing.PrintDocument();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOne)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.panel1.Controls.Add(this.txtError);
            this.panel1.Controls.Add(this.txtExit);
            this.panel1.Controls.Add(this.txtEmployees);
            this.panel1.Controls.Add(this.txtProducts);
            this.panel1.Controls.Add(this.txtCategory);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 847);
            this.panel1.TabIndex = 0;
            // 
            // txtError
            // 
            this.txtError.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.txtError.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtError.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtError.Font = new System.Drawing.Font("JetBrains Mono", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtError.ForeColor = System.Drawing.Color.Red;
            this.txtError.Location = new System.Drawing.Point(43, 434);
            this.txtError.Multiline = true;
            this.txtError.Name = "txtError";
            this.txtError.ReadOnly = true;
            this.txtError.Size = new System.Drawing.Size(228, 55);
            this.txtError.TabIndex = 4;
            this.txtError.Text = "*ONLY ADMINS CAN VIEW THIS TABLE";
            this.txtError.Visible = false;
            // 
            // txtExit
            // 
            this.txtExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.txtExit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtExit.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtExit.Font = new System.Drawing.Font("Jura", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExit.ForeColor = System.Drawing.Color.DarkGray;
            this.txtExit.Location = new System.Drawing.Point(43, 532);
            this.txtExit.Multiline = true;
            this.txtExit.Name = "txtExit";
            this.txtExit.ReadOnly = true;
            this.txtExit.Size = new System.Drawing.Size(173, 42);
            this.txtExit.TabIndex = 3;
            this.txtExit.Text = "EXIT";
            this.txtExit.Click += new System.EventHandler(this.txtExit_Click);
            // 
            // txtEmployees
            // 
            this.txtEmployees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.txtEmployees.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmployees.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtEmployees.Font = new System.Drawing.Font("Jura", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployees.ForeColor = System.Drawing.Color.DarkGray;
            this.txtEmployees.Location = new System.Drawing.Point(43, 386);
            this.txtEmployees.Multiline = true;
            this.txtEmployees.Name = "txtEmployees";
            this.txtEmployees.ReadOnly = true;
            this.txtEmployees.Size = new System.Drawing.Size(205, 42);
            this.txtEmployees.TabIndex = 2;
            this.txtEmployees.Text = "EMPLOYEES";
            this.txtEmployees.Click += new System.EventHandler(this.txtEmployees_Click);
            // 
            // txtProducts
            // 
            this.txtProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.txtProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProducts.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtProducts.Font = new System.Drawing.Font("Jura", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProducts.ForeColor = System.Drawing.Color.DarkGray;
            this.txtProducts.Location = new System.Drawing.Point(43, 241);
            this.txtProducts.Multiline = true;
            this.txtProducts.Name = "txtProducts";
            this.txtProducts.ReadOnly = true;
            this.txtProducts.Size = new System.Drawing.Size(165, 41);
            this.txtProducts.TabIndex = 1;
            this.txtProducts.Text = "PRODUCTS";
            this.txtProducts.Click += new System.EventHandler(this.txtProducts_Click);
            // 
            // txtCategory
            // 
            this.txtCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.txtCategory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCategory.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtCategory.Font = new System.Drawing.Font("Jura", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategory.ForeColor = System.Drawing.Color.Yellow;
            this.txtCategory.Location = new System.Drawing.Point(43, 76);
            this.txtCategory.Multiline = true;
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.ReadOnly = true;
            this.txtCategory.Size = new System.Drawing.Size(205, 78);
            this.txtCategory.TabIndex = 0;
            this.txtCategory.Text = "PRODUCT CATEGORIES";
            this.txtCategory.Click += new System.EventHandler(this.txtCategory_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.btnPrint);
            this.panel2.Controls.Add(this.cmbCategory);
            this.panel2.Controls.Add(this.btnRefresh);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.txtDescription);
            this.panel2.Controls.Add(this.txtNewName);
            this.panel2.Controls.Add(this.lblEmployees);
            this.panel2.Controls.Add(this.lblCategories);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1046, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(336, 847);
            this.panel2.TabIndex = 1;
            // 
            // cmbCategory
            // 
            this.cmbCategory.BackColor = System.Drawing.Color.Black;
            this.cmbCategory.DropDownHeight = 50;
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCategory.Font = new System.Drawing.Font("Jura SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategory.ForeColor = System.Drawing.Color.DimGray;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.IntegralHeight = false;
            this.cmbCategory.Location = new System.Drawing.Point(22, 44);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(272, 35);
            this.cmbCategory.Sorted = true;
            this.cmbCategory.TabIndex = 57;
            this.cmbCategory.DropDown += new System.EventHandler(this.cmbCategory_DropDown);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Black;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Jura", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.Silver;
            this.btnRefresh.Location = new System.Drawing.Point(22, 775);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(272, 55);
            this.btnRefresh.TabIndex = 30;
            this.btnRefresh.Text = "REFRESH GRID";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Black;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Jura", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Silver;
            this.btnDelete.Location = new System.Drawing.Point(22, 612);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(272, 55);
            this.btnDelete.TabIndex = 29;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Black;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Jura", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Silver;
            this.btnUpdate.Location = new System.Drawing.Point(22, 549);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(272, 55);
            this.btnUpdate.TabIndex = 28;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Black;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Jura", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Silver;
            this.btnAdd.Location = new System.Drawing.Point(22, 486);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(272, 55);
            this.btnAdd.TabIndex = 27;
            this.btnAdd.Text = "ADD CATEGORY";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Black;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Jura", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Silver;
            this.btnSearch.Location = new System.Drawing.Point(22, 86);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(272, 55);
            this.btnSearch.TabIndex = 26;
            this.btnSearch.Text = "SEARCH BY NAME";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.Black;
            this.txtDescription.BorderColor = System.Drawing.Color.DimGray;
            this.txtDescription.BorderSize = 2;
            this.txtDescription.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.ForeColor = System.Drawing.Color.DimGray;
            this.txtDescription.Location = new System.Drawing.Point(22, 334);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Padding = new System.Windows.Forms.Padding(9);
            this.txtDescription.PasswordChar = false;
            this.txtDescription.Size = new System.Drawing.Size(272, 138);
            this.txtDescription.TabIndex = 25;
            this.txtDescription.Text_ = "";
            this.txtDescription.UnderlinedStyle = false;
            // 
            // txtNewName
            // 
            this.txtNewName.BackColor = System.Drawing.Color.Black;
            this.txtNewName.BorderColor = System.Drawing.Color.DimGray;
            this.txtNewName.BorderSize = 2;
            this.txtNewName.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewName.ForeColor = System.Drawing.Color.DimGray;
            this.txtNewName.Location = new System.Drawing.Point(22, 236);
            this.txtNewName.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.txtNewName.Multiline = false;
            this.txtNewName.Name = "txtNewName";
            this.txtNewName.Padding = new System.Windows.Forms.Padding(9);
            this.txtNewName.PasswordChar = false;
            this.txtNewName.Size = new System.Drawing.Size(272, 41);
            this.txtNewName.TabIndex = 24;
            this.txtNewName.Text_ = "";
            this.txtNewName.UnderlinedStyle = false;
            // 
            // lblEmployees
            // 
            this.lblEmployees.AutoSize = true;
            this.lblEmployees.BackColor = System.Drawing.Color.Transparent;
            this.lblEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEmployees.Font = new System.Drawing.Font("Jura", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployees.ForeColor = System.Drawing.Color.DarkGray;
            this.lblEmployees.Location = new System.Drawing.Point(15, 287);
            this.lblEmployees.Name = "lblEmployees";
            this.lblEmployees.Size = new System.Drawing.Size(193, 37);
            this.lblEmployees.TabIndex = 23;
            this.lblEmployees.Text = "DESCRIPTION";
            this.lblEmployees.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCategories
            // 
            this.lblCategories.AutoSize = true;
            this.lblCategories.BackColor = System.Drawing.Color.Transparent;
            this.lblCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCategories.Font = new System.Drawing.Font("Jura", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategories.ForeColor = System.Drawing.Color.DarkGray;
            this.lblCategories.Location = new System.Drawing.Point(15, 189);
            this.lblCategories.Name = "lblCategories";
            this.lblCategories.Size = new System.Drawing.Size(288, 37);
            this.lblCategories.TabIndex = 22;
            this.lblCategories.Text = "NEW/EDIT CATEGORY";
            this.lblCategories.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvOne
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOne.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvOne.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOne.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvOne.BackgroundColor = System.Drawing.Color.Black;
            this.dgvOne.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvOne.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Jura", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOne.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvOne.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOne.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvOne.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOne.Location = new System.Drawing.Point(290, 0);
            this.dgvOne.Name = "dgvOne";
            this.dgvOne.RowHeadersVisible = false;
            this.dgvOne.RowHeadersWidth = 51;
            this.dgvOne.RowTemplate.Height = 24;
            this.dgvOne.Size = new System.Drawing.Size(756, 847);
            this.dgvOne.TabIndex = 71;
            this.dgvOne.SelectionChanged += new System.EventHandler(this.dgvOne_SelectionChanged);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.Black;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Jura", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.Silver;
            this.btnPrint.Location = new System.Drawing.Point(22, 712);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(272, 55);
            this.btnPrint.TabIndex = 71;
            this.btnPrint.Text = "PRINT";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // printPDOne
            // 
            this.printPDOne.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPDOne.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPDOne.ClientSize = new System.Drawing.Size(400, 300);
            this.printPDOne.Enabled = true;
            this.printPDOne.Icon = ((System.Drawing.Icon)(resources.GetObject("printPDOne.Icon")));
            this.printPDOne.Name = "printPDOne";
            this.printPDOne.Visible = false;
            // 
            // printDocOne
            // 
            this.printDocOne.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocOne_PrintPage);
            // 
            // frmCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::WindowsFormsApp5.Properties.Resources.LOGIN_TEMPLATE3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1382, 847);
            this.Controls.Add(this.dgvOne);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCategories";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Categories";
            this.MouseHover += new System.EventHandler(this.frmCategories_MouseHover);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOne)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtExit;
        private System.Windows.Forms.TextBox txtEmployees;
        private System.Windows.Forms.TextBox txtProducts;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.TextBox txtError;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSearch;
        private roundTxt txtDescription;
        private roundTxt txtNewName;
        private System.Windows.Forms.Label lblEmployees;
        private System.Windows.Forms.Label lblCategories;
        private System.Windows.Forms.DataGridView dgvOne;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.PrintPreviewDialog printPDOne;
        private System.Drawing.Printing.PrintDocument printDocOne;
    }
}