namespace GetImagesightImages
{
    partial class DoneMessage
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
            this.Ok = new System.Windows.Forms.Button();
            this.OpenFolder = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Ok
            // 
            this.Ok.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Ok.Location = new System.Drawing.Point(213, 87);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(61, 35);
            this.Ok.TabIndex = 0;
            this.Ok.Text = "OK";
            this.Ok.UseVisualStyleBackColor = true;
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // OpenFolder
            // 
            this.OpenFolder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OpenFolder.Location = new System.Drawing.Point(302, 87);
            this.OpenFolder.Name = "OpenFolder";
            this.OpenFolder.Size = new System.Drawing.Size(107, 35);
            this.OpenFolder.TabIndex = 1;
            this.OpenFolder.Text = "Open Folder";
            this.OpenFolder.UseVisualStyleBackColor = true;
            this.OpenFolder.Click += new System.EventHandler(this.OpenFolder_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.SystemColors.Control;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label.Location = new System.Drawing.Point(22, 35);
            this.label.MaximumSize = new System.Drawing.Size(500, 50);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(0, 16);
            this.label.TabIndex = 2;
            // 
            // DoneMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 153);
            this.Controls.Add(this.label);
            this.Controls.Add(this.OpenFolder);
            this.Controls.Add(this.Ok);
            this.Name = "DoneMessage";
            this.Text = "Done";
            this.Load += new System.EventHandler(this.DoneMessage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Ok;
        private System.Windows.Forms.Button OpenFolder;
        private System.Windows.Forms.Label label;
    }
}