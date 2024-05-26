namespace WindowsFormsApp5
{
    partial class frmLoading
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoading));
            this.lblLoading = new System.Windows.Forms.Label();
            this.cpbOne = new CircularProgressBar.CircularProgressBar();
            this.tmrOne = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblLoading
            // 
            this.lblLoading.AutoSize = true;
            this.lblLoading.BackColor = System.Drawing.Color.Transparent;
            this.lblLoading.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblLoading.Font = new System.Drawing.Font("Nunito", 35.99999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoading.ForeColor = System.Drawing.Color.DimGray;
            this.lblLoading.Location = new System.Drawing.Point(144, 106);
            this.lblLoading.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(483, 83);
            this.lblLoading.TabIndex = 3;
            this.lblLoading.Text = "L O A D I N G . . .";
            this.lblLoading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cpbOne
            // 
            this.cpbOne.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cpbOne.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.cpbOne.AnimationSpeed = 0;
            this.cpbOne.BackColor = System.Drawing.Color.Transparent;
            this.cpbOne.Font = new System.Drawing.Font("Bahnschrift", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpbOne.ForeColor = System.Drawing.Color.DimGray;
            this.cpbOne.InnerColor = System.Drawing.Color.Transparent;
            this.cpbOne.InnerMargin = 2;
            this.cpbOne.InnerWidth = -1;
            this.cpbOne.Location = new System.Drawing.Point(971, 382);
            this.cpbOne.Margin = new System.Windows.Forms.Padding(4);
            this.cpbOne.MarqueeAnimationSpeed = 0;
            this.cpbOne.Name = "cpbOne";
            this.cpbOne.OuterColor = System.Drawing.Color.DimGray;
            this.cpbOne.OuterMargin = -25;
            this.cpbOne.OuterWidth = 5;
            this.cpbOne.ProgressColor = System.Drawing.Color.Lime;
            this.cpbOne.ProgressWidth = 5;
            this.cpbOne.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.cpbOne.Size = new System.Drawing.Size(373, 345);
            this.cpbOne.StartAngle = 270;
            this.cpbOne.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.cpbOne.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cpbOne.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.cpbOne.SubscriptText = "";
            this.cpbOne.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cpbOne.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.cpbOne.SuperscriptText = "";
            this.cpbOne.TabIndex = 0;
            this.cpbOne.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.cpbOne.Value = 68;
            // 
            // tmrOne
            // 
            this.tmrOne.Interval = 80;
            this.tmrOne.Tick += new System.EventHandler(this.tmrOne_Tick);
            // 
            // frmLoading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp5.Properties.Resources.LOGIN_TEMPLATE;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1549, 990);
            this.Controls.Add(this.cpbOne);
            this.Controls.Add(this.lblLoading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmLoading";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOADING";
            this.Load += new System.EventHandler(this.frmLoading_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLoading;
        private CircularProgressBar.CircularProgressBar cpbOne;
        private System.Windows.Forms.Timer tmrOne;
    }
}