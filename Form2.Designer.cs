namespace MilestoneProject
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
            this.label2 = new System.Windows.Forms.Label();
            this.itemManagementBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.exitBtn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.userManagementBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(77, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Admin Portal";
            // 
            // itemManagementBtn
            // 
            this.itemManagementBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(137)))), ((int)(((byte)(88)))));
            this.itemManagementBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.itemManagementBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemManagementBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.itemManagementBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.itemManagementBtn.Location = new System.Drawing.Point(30, 249);
            this.itemManagementBtn.Name = "itemManagementBtn";
            this.itemManagementBtn.Size = new System.Drawing.Size(261, 38);
            this.itemManagementBtn.TabIndex = 7;
            this.itemManagementBtn.Text = "Item Management";
            this.itemManagementBtn.UseVisualStyleBackColor = false;
            this.itemManagementBtn.Click += new System.EventHandler(this.itemManagementBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(64, 96);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.Red;
            this.exitBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.exitBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.exitBtn.Location = new System.Drawing.Point(304, -1);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(33, 38);
            this.exitBtn.TabIndex = 12;
            this.exitBtn.Text = "X";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(64, 96);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(175, 123);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // userManagementBtn
            // 
            this.userManagementBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(137)))), ((int)(((byte)(88)))));
            this.userManagementBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.userManagementBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userManagementBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.userManagementBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.userManagementBtn.Location = new System.Drawing.Point(30, 316);
            this.userManagementBtn.Name = "userManagementBtn";
            this.userManagementBtn.Size = new System.Drawing.Size(261, 38);
            this.userManagementBtn.TabIndex = 9;
            this.userManagementBtn.Text = "User Management";
            this.userManagementBtn.UseVisualStyleBackColor = false;
            this.userManagementBtn.Click += new System.EventHandler(this.userManagementBtn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(337, 400);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.userManagementBtn);
            this.Controls.Add(this.itemManagementBtn);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Opacity = 0.97D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button itemManagementBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button userManagementBtn;
    }
}