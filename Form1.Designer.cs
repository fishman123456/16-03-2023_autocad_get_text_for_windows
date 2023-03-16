namespace _16_03_2023_autocad_get_text_for_windows
{
    partial class WF_1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Load_ = new System.Windows.Forms.Button();
            this.Earse = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(267, 223);
            this.textBox1.TabIndex = 0;
            // 
            // Load_
            // 
            this.Load_.Location = new System.Drawing.Point(12, 260);
            this.Load_.Name = "Load_";
            this.Load_.Size = new System.Drawing.Size(75, 23);
            this.Load_.TabIndex = 1;
            this.Load_.Text = "Load";
            this.Load_.UseVisualStyleBackColor = true;
            // 
            // Earse
            // 
            this.Earse.Location = new System.Drawing.Point(106, 260);
            this.Earse.Name = "Earse";
            this.Earse.Size = new System.Drawing.Size(75, 23);
            this.Earse.TabIndex = 2;
            this.Earse.Text = "Earse";
            this.Earse.UseVisualStyleBackColor = true;
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(204, 260);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(75, 23);
            this.Update.TabIndex = 3;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            // 
            // WF_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 307);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Earse);
            this.Controls.Add(this.Load_);
            this.Controls.Add(this.textBox1);
            this.Name = "WF_1";
            this.Text = "U-83";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Load_;
        private System.Windows.Forms.Button Earse;
        private System.Windows.Forms.Button Update;
    }
}