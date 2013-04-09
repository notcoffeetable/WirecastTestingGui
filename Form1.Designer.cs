namespace WirecastTestingGUI
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
            this.autolive = new System.Windows.Forms.CheckBox();
            this.start_wirecast = new System.Windows.Forms.Button();
            this.status = new System.Windows.Forms.Label();
            this.toggle_broadcast = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // autolive
            // 
            this.autolive.AutoSize = true;
            this.autolive.Enabled = false;
            this.autolive.Location = new System.Drawing.Point(13, 13);
            this.autolive.Name = "autolive";
            this.autolive.Size = new System.Drawing.Size(63, 17);
            this.autolive.TabIndex = 0;
            this.autolive.Text = "autolive";
            this.autolive.UseVisualStyleBackColor = true;
            this.autolive.CheckedChanged += new System.EventHandler(this.autolive_CheckedChanged);
            // 
            // start_wirecast
            // 
            this.start_wirecast.Location = new System.Drawing.Point(13, 226);
            this.start_wirecast.Name = "start_wirecast";
            this.start_wirecast.Size = new System.Drawing.Size(75, 23);
            this.start_wirecast.TabIndex = 1;
            this.start_wirecast.Text = "Get Wirecast";
            this.start_wirecast.UseVisualStyleBackColor = true;
            this.start_wirecast.Click += new System.EventHandler(this.start_wirecast_Click);
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(95, 236);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(66, 13);
            this.status.TabIndex = 2;
            this.status.Text = "No Wirecast";
            // 
            // toggle_broadcast
            // 
            this.toggle_broadcast.Enabled = false;
            this.toggle_broadcast.Location = new System.Drawing.Point(12, 197);
            this.toggle_broadcast.Name = "toggle_broadcast";
            this.toggle_broadcast.Size = new System.Drawing.Size(120, 23);
            this.toggle_broadcast.TabIndex = 3;
            this.toggle_broadcast.Text = "Toggle Broadcast";
            this.toggle_broadcast.UseVisualStyleBackColor = true;
            this.toggle_broadcast.Click += new System.EventHandler(this.toggle_broadcast_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.toggle_broadcast);
            this.Controls.Add(this.status);
            this.Controls.Add(this.start_wirecast);
            this.Controls.Add(this.autolive);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox autolive;
        private System.Windows.Forms.Button start_wirecast;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Button toggle_broadcast;

    }
}

