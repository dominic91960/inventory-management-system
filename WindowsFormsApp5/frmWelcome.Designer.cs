namespace WindowsFormsApp5
{
    partial class frmWelcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWelcome));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblLoading = new System.Windows.Forms.Label();
            this.lblCategories = new System.Windows.Forms.Label();
            this.lblProducts = new System.Windows.Forms.Label();
            this.lblEmployees = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImage = global::WindowsFormsApp5.Properties.Resources.bravo6;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(1252, 772);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 62);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // lblLoading
            // 
            this.lblLoading.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblLoading.AutoSize = true;
            this.lblLoading.BackColor = System.Drawing.Color.Transparent;
            this.lblLoading.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblLoading.Font = new System.Drawing.Font("Nunito", 35.99999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoading.ForeColor = System.Drawing.Color.LightGray;
            this.lblLoading.Location = new System.Drawing.Point(462, 91);
            this.lblLoading.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(431, 83);
            this.lblLoading.TabIndex = 4;
            this.lblLoading.Text = "W E L C O M E";
            this.lblLoading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCategories
            // 
            this.lblCategories.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblCategories.AutoSize = true;
            this.lblCategories.BackColor = System.Drawing.Color.Transparent;
            this.lblCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCategories.Font = new System.Drawing.Font("Jura", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategories.ForeColor = System.Drawing.Color.DarkGray;
            this.lblCategories.Location = new System.Drawing.Point(350, 455);
            this.lblCategories.Name = "lblCategories";
            this.lblCategories.Size = new System.Drawing.Size(359, 37);
            this.lblCategories.TabIndex = 7;
            this.lblCategories.Text = "♦ PRODUCT CATEGORIES";
            this.lblCategories.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCategories.Click += new System.EventHandler(this.lblCategories_Click);
            this.lblCategories.MouseLeave += new System.EventHandler(this.lblCategories_MouseLeave);
            this.lblCategories.MouseHover += new System.EventHandler(this.lblCategories_MouseHover);
            // 
            // lblProducts
            // 
            this.lblProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblProducts.AutoSize = true;
            this.lblProducts.BackColor = System.Drawing.Color.Transparent;
            this.lblProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblProducts.Font = new System.Drawing.Font("Jura", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducts.ForeColor = System.Drawing.Color.DarkGray;
            this.lblProducts.Location = new System.Drawing.Point(350, 509);
            this.lblProducts.Name = "lblProducts";
            this.lblProducts.Size = new System.Drawing.Size(208, 37);
            this.lblProducts.TabIndex = 8;
            this.lblProducts.Text = "♦ PRODUCTS";
            this.lblProducts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblProducts.Click += new System.EventHandler(this.lblProducts_Click);
            this.lblProducts.MouseLeave += new System.EventHandler(this.lblProducts_MouseLeave);
            this.lblProducts.MouseHover += new System.EventHandler(this.lblProducts_MouseHover);
            // 
            // lblEmployees
            // 
            this.lblEmployees.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblEmployees.AutoSize = true;
            this.lblEmployees.BackColor = System.Drawing.Color.Transparent;
            this.lblEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEmployees.Font = new System.Drawing.Font("Jura", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployees.ForeColor = System.Drawing.Color.DarkGray;
            this.lblEmployees.Location = new System.Drawing.Point(350, 564);
            this.lblEmployees.Name = "lblEmployees";
            this.lblEmployees.Size = new System.Drawing.Size(214, 37);
            this.lblEmployees.TabIndex = 9;
            this.lblEmployees.Text = "♦ EMPLOYEES";
            this.lblEmployees.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEmployees.Click += new System.EventHandler(this.lblEmployees_Click);
            this.lblEmployees.MouseLeave += new System.EventHandler(this.lblEmployees_MouseLeave);
            this.lblEmployees.MouseHover += new System.EventHandler(this.lblEmployees_MouseHover);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Jura", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkGray;
            this.label4.Location = new System.Drawing.Point(349, 376);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(642, 44);
            this.label4.TabIndex = 12;
            this.label4.Text = "PLEASE SELECT A TABLE TO VIEW OR EDIT";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtError
            // 
            this.txtError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtError.AutoSize = true;
            this.txtError.BackColor = System.Drawing.Color.Transparent;
            this.txtError.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtError.Font = new System.Drawing.Font("JetBrains Mono", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtError.ForeColor = System.Drawing.Color.Red;
            this.txtError.Location = new System.Drawing.Point(349, 613);
            this.txtError.Name = "txtError";
            this.txtError.Size = new System.Drawing.Size(643, 30);
            this.txtError.TabIndex = 13;
            this.txtError.Text = "*ONLY ADMINS ARE ALLOWED TO ACCESS THIS TABLE";
            this.txtError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtError.Visible = false;
            // 
            // frmWelcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.BackgroundImage = global::WindowsFormsApp5.Properties.Resources.LOGIN_TEMPLATE3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1382, 847);
            this.Controls.Add(this.txtError);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblEmployees);
            this.Controls.Add(this.lblProducts);
            this.Controls.Add(this.lblCategories);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblLoading);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmWelcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmWelcome";
            this.Load += new System.EventHandler(this.frmWelcome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblLoading;
        private System.Windows.Forms.Label lblProducts;
        private System.Windows.Forms.Label lblEmployees;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCategories;
        private System.Windows.Forms.Label txtError;
    }
}