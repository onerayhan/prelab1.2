
namespace prelab1._2
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
            this.log = new System.Windows.Forms.RichTextBox();
            this.button_connect = new System.Windows.Forms.Button();
            this.name_label = new System.Windows.Forms.Label();
            this.name_text_box = new System.Windows.Forms.TextBox();
            this.ip_text_box = new System.Windows.Forms.TextBox();
            this.port_text_box = new System.Windows.Forms.TextBox();
            this.ip_label = new System.Windows.Forms.Label();
            this.port_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // log
            // 
            this.log.Location = new System.Drawing.Point(301, 80);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(280, 332);
            this.log.TabIndex = 0;
            this.log.Text = "";
            // 
            // button_connect
            // 
            this.button_connect.Location = new System.Drawing.Point(108, 255);
            this.button_connect.Name = "button_connect";
            this.button_connect.Size = new System.Drawing.Size(75, 23);
            this.button_connect.TabIndex = 1;
            this.button_connect.Text = "Connect";
            this.button_connect.UseVisualStyleBackColor = true;
            this.button_connect.Click += new System.EventHandler(this.button_connect_Click);
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Location = new System.Drawing.Point(40, 215);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(38, 13);
            this.name_label.TabIndex = 2;
            this.name_label.Text = "Name:";
            // 
            // name_text_box
            // 
            this.name_text_box.Location = new System.Drawing.Point(108, 208);
            this.name_text_box.Name = "name_text_box";
            this.name_text_box.Size = new System.Drawing.Size(157, 20);
            this.name_text_box.TabIndex = 3;
            // 
            // ip_text_box
            // 
            this.ip_text_box.Location = new System.Drawing.Point(108, 122);
            this.ip_text_box.Name = "ip_text_box";
            this.ip_text_box.Size = new System.Drawing.Size(157, 20);
            this.ip_text_box.TabIndex = 4;
            // 
            // port_text_box
            // 
            this.port_text_box.Location = new System.Drawing.Point(108, 166);
            this.port_text_box.Name = "port_text_box";
            this.port_text_box.Size = new System.Drawing.Size(157, 20);
            this.port_text_box.TabIndex = 5;
            // 
            // ip_label
            // 
            this.ip_label.AutoSize = true;
            this.ip_label.Location = new System.Drawing.Point(40, 129);
            this.ip_label.Name = "ip_label";
            this.ip_label.Size = new System.Drawing.Size(20, 13);
            this.ip_label.TabIndex = 6;
            this.ip_label.Text = "IP:";
            // 
            // port_label
            // 
            this.port_label.AutoSize = true;
            this.port_label.Location = new System.Drawing.Point(40, 169);
            this.port_label.Name = "port_label";
            this.port_label.Size = new System.Drawing.Size(29, 13);
            this.port_label.TabIndex = 7;
            this.port_label.Text = "Port:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.port_label);
            this.Controls.Add(this.ip_label);
            this.Controls.Add(this.port_text_box);
            this.Controls.Add(this.ip_text_box);
            this.Controls.Add(this.name_text_box);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.button_connect);
            this.Controls.Add(this.log);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox log;
        private System.Windows.Forms.Button button_connect;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.TextBox name_text_box;
        private System.Windows.Forms.TextBox ip_text_box;
        private System.Windows.Forms.TextBox port_text_box;
        private System.Windows.Forms.Label ip_label;
        private System.Windows.Forms.Label port_label;
    }
}

