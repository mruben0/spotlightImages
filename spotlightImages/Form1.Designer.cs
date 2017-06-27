namespace GetImagesightImages
{
    partial class form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form));
            this.getImgs = new System.Windows.Forms.Button();
            this.agree = new System.Windows.Forms.CheckBox();
            this.browse = new System.Windows.Forms.Button();
            this.browser = new System.Windows.Forms.FolderBrowserDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.conditions = new System.Windows.Forms.Button();
            this.footer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // getImgs
            // 
            this.getImgs.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.getImgs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.getImgs.Location = new System.Drawing.Point(161, 163);
            this.getImgs.Name = "getImgs";
            this.getImgs.Size = new System.Drawing.Size(172, 63);
            this.getImgs.TabIndex = 0;
            this.getImgs.Text = "Find Images";
            this.getImgs.UseVisualStyleBackColor = false;
            this.getImgs.Click += new System.EventHandler(this.getImgs_Click);
            // 
            // agree
            // 
            this.agree.AutoSize = true;
            this.agree.Location = new System.Drawing.Point(116, 100);
            this.agree.Name = "agree";
            this.agree.Size = new System.Drawing.Size(261, 17);
            this.agree.TabIndex = 1;
            this.agree.Text = "I have read and agree to the terms and conditions";
            this.agree.UseVisualStyleBackColor = true;
            this.agree.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // browse
            // 
            this.browse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.browse.Location = new System.Drawing.Point(339, 53);
            this.browse.Name = "browse";
            this.browse.Size = new System.Drawing.Size(75, 23);
            this.browse.TabIndex = 2;
            this.browse.Text = "browse";
            this.browse.UseVisualStyleBackColor = true;
            this.browse.Click += new System.EventHandler(this.browse_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(107, 56);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(226, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // conditions
            // 
            this.conditions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.conditions.Location = new System.Drawing.Point(194, 134);
            this.conditions.Name = "conditions";
            this.conditions.Size = new System.Drawing.Size(117, 23);
            this.conditions.TabIndex = 4;
            this.conditions.Text = "conditions";
            this.conditions.UseVisualStyleBackColor = true;
            this.conditions.Click += new System.EventHandler(this.conditions_Click);
            // 
            // footer
            // 
            this.footer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.footer.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.footer.Location = new System.Drawing.Point(-2, 232);
            this.footer.Name = "footer";
            this.footer.Size = new System.Drawing.Size(491, 76);
            this.footer.TabIndex = 5;
            this.footer.Text = "Created By Ram6ler";
            this.footer.UseVisualStyleBackColor = false;
            this.footer.Click += new System.EventHandler(this.footer_Click);
            // 
            // form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 302);
            this.Controls.Add(this.footer);
            this.Controls.Add(this.conditions);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.browse);
            this.Controls.Add(this.agree);
            this.Controls.Add(this.getImgs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form";
            this.Text = "GetImagesight Images";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button getImgs;
        private System.Windows.Forms.CheckBox agree;
        private System.Windows.Forms.Button browse;
        private System.Windows.Forms.FolderBrowserDialog browser;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button conditions;
        private System.Windows.Forms.Button footer;
    }
}

