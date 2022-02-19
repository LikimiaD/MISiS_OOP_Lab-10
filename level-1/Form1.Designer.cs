namespace level_1
{
    partial class Form1
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
            this.textbox = new System.Windows.Forms.RichTextBox();
            this.textbox1 = new System.Windows.Forms.RichTextBox();
            this.button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textbox
            // 
            this.textbox.Location = new System.Drawing.Point(68, 150);
            this.textbox.Name = "textbox";
            this.textbox.Size = new System.Drawing.Size(100, 96);
            this.textbox.TabIndex = 0;
            this.textbox.Text = "";
            // 
            // textbox1
            // 
            this.textbox1.Location = new System.Drawing.Point(236, 150);
            this.textbox1.Name = "textbox1";
            this.textbox1.ReadOnly = true;
            this.textbox1.Size = new System.Drawing.Size(100, 96);
            this.textbox1.TabIndex = 1;
            this.textbox1.Text = "";
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(185, 292);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(75, 23);
            this.button.TabIndex = 2;
            this.button.Text = "fetch";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 338);
            this.Controls.Add(this.button);
            this.Controls.Add(this.textbox1);
            this.Controls.Add(this.textbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox textbox;
        private System.Windows.Forms.RichTextBox textbox1;
        private System.Windows.Forms.Button button;
    }
}

