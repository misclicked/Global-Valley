namespace Global_Valley
{
    partial class Form_main
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox_org = new System.Windows.Forms.PictureBox();
            this.button_imgSelect = new System.Windows.Forms.Button();
            this.pictureBox_tran = new System.Windows.Forms.PictureBox();
            this.button_Convert = new System.Windows.Forms.Button();
            this.checkBox_F = new System.Windows.Forms.CheckBox();
            this.checkBox_mB = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_org)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_tran)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_org
            // 
            this.pictureBox_org.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_org.Location = new System.Drawing.Point(12, 41);
            this.pictureBox_org.Name = "pictureBox_org";
            this.pictureBox_org.Size = new System.Drawing.Size(600, 400);
            this.pictureBox_org.TabIndex = 0;
            this.pictureBox_org.TabStop = false;
            // 
            // button_imgSelect
            // 
            this.button_imgSelect.Location = new System.Drawing.Point(12, 12);
            this.button_imgSelect.Name = "button_imgSelect";
            this.button_imgSelect.Size = new System.Drawing.Size(75, 23);
            this.button_imgSelect.TabIndex = 1;
            this.button_imgSelect.Text = "Select Image";
            this.button_imgSelect.UseVisualStyleBackColor = true;
            this.button_imgSelect.Click += new System.EventHandler(this.button_imgSelect_Click);
            // 
            // pictureBox_tran
            // 
            this.pictureBox_tran.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_tran.Location = new System.Drawing.Point(624, 41);
            this.pictureBox_tran.Name = "pictureBox_tran";
            this.pictureBox_tran.Size = new System.Drawing.Size(600, 400);
            this.pictureBox_tran.TabIndex = 2;
            this.pictureBox_tran.TabStop = false;
            // 
            // button_Convert
            // 
            this.button_Convert.Enabled = false;
            this.button_Convert.Location = new System.Drawing.Point(588, 447);
            this.button_Convert.Name = "button_Convert";
            this.button_Convert.Size = new System.Drawing.Size(56, 23);
            this.button_Convert.TabIndex = 3;
            this.button_Convert.Text = "Convert";
            this.button_Convert.UseVisualStyleBackColor = true;
            this.button_Convert.Click += new System.EventHandler(this.button_Convert_Click);
            // 
            // checkBox_F
            // 
            this.checkBox_F.AutoSize = true;
            this.checkBox_F.Location = new System.Drawing.Point(911, 454);
            this.checkBox_F.Name = "checkBox_F";
            this.checkBox_F.Size = new System.Drawing.Size(100, 16);
            this.checkBox_F.TabIndex = 4;
            this.checkBox_F.Text = "use \"F\" function";
            this.checkBox_F.UseVisualStyleBackColor = true;
            // 
            // checkBox_mB
            // 
            this.checkBox_mB.AutoSize = true;
            this.checkBox_mB.Location = new System.Drawing.Point(1017, 454);
            this.checkBox_mB.Name = "checkBox_mB";
            this.checkBox_mB.Size = new System.Drawing.Size(97, 16);
            this.checkBox_mB.TabIndex = 5;
            this.checkBox_mB.Text = "use medianBlur";
            this.checkBox_mB.UseVisualStyleBackColor = true;
            // 
            // Form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 499);
            this.Controls.Add(this.checkBox_mB);
            this.Controls.Add(this.checkBox_F);
            this.Controls.Add(this.button_Convert);
            this.Controls.Add(this.pictureBox_tran);
            this.Controls.Add(this.button_imgSelect);
            this.Controls.Add(this.pictureBox_org);
            this.Name = "Form_main";
            this.Text = "Global valley";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_org)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_tran)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_org;
        private System.Windows.Forms.Button button_imgSelect;
        private System.Windows.Forms.PictureBox pictureBox_tran;
        private System.Windows.Forms.Button button_Convert;
        private System.Windows.Forms.CheckBox checkBox_F;
        private System.Windows.Forms.CheckBox checkBox_mB;
    }
}

