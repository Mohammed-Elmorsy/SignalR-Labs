namespace chatApp
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
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_group = new System.Windows.Forms.TextBox();
            this.txt_message = new System.Windows.Forms.TextBox();
            this.lbl_messages = new System.Windows.Forms.ListBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_message = new System.Windows.Forms.Label();
            this.lbl_group = new System.Windows.Forms.Label();
            this.btn_send = new System.Windows.Forms.Button();
            this.btn_join = new System.Windows.Forms.Button();
            this.btn_send_group = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(353, 31);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(100, 20);
            this.txt_name.TabIndex = 0;
            // 
            // txt_group
            // 
            this.txt_group.Location = new System.Drawing.Point(120, 132);
            this.txt_group.Name = "txt_group";
            this.txt_group.Size = new System.Drawing.Size(100, 20);
            this.txt_group.TabIndex = 1;
            // 
            // txt_message
            // 
            this.txt_message.Location = new System.Drawing.Point(120, 81);
            this.txt_message.Name = "txt_message";
            this.txt_message.Size = new System.Drawing.Size(100, 20);
            this.txt_message.TabIndex = 2;
            // 
            // lbl_messages
            // 
            this.lbl_messages.FormattingEnabled = true;
            this.lbl_messages.Location = new System.Drawing.Point(197, 248);
            this.lbl_messages.Name = "lbl_messages";
            this.lbl_messages.Size = new System.Drawing.Size(404, 134);
            this.lbl_messages.TabIndex = 3;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Enabled = false;
            this.lbl_name.Location = new System.Drawing.Point(303, 38);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(33, 13);
            this.lbl_name.TabIndex = 4;
            this.lbl_name.Text = "name";
            this.lbl_name.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_message
            // 
            this.lbl_message.AutoSize = true;
            this.lbl_message.Location = new System.Drawing.Point(61, 88);
            this.lbl_message.Name = "lbl_message";
            this.lbl_message.Size = new System.Drawing.Size(49, 13);
            this.lbl_message.TabIndex = 5;
            this.lbl_message.Text = "message";
            this.lbl_message.Click += new System.EventHandler(this.lbl_message_Click);
            // 
            // lbl_group
            // 
            this.lbl_group.AutoSize = true;
            this.lbl_group.Location = new System.Drawing.Point(76, 139);
            this.lbl_group.Name = "lbl_group";
            this.lbl_group.Size = new System.Drawing.Size(34, 13);
            this.lbl_group.TabIndex = 6;
            this.lbl_group.Text = "group";
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(247, 81);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(75, 23);
            this.btn_send.TabIndex = 7;
            this.btn_send.Text = "send";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // btn_join
            // 
            this.btn_join.Location = new System.Drawing.Point(247, 130);
            this.btn_join.Name = "btn_join";
            this.btn_join.Size = new System.Drawing.Size(75, 23);
            this.btn_join.TabIndex = 8;
            this.btn_join.Text = "join";
            this.btn_join.UseVisualStyleBackColor = true;
            this.btn_join.Click += new System.EventHandler(this.btn_join_Click);
            // 
            // btn_send_group
            // 
            this.btn_send_group.Location = new System.Drawing.Point(164, 179);
            this.btn_send_group.Name = "btn_send_group";
            this.btn_send_group.Size = new System.Drawing.Size(119, 26);
            this.btn_send_group.TabIndex = 9;
            this.btn_send_group.Text = "send to group";
            this.btn_send_group.UseVisualStyleBackColor = true;
            this.btn_send_group.Click += new System.EventHandler(this.btn_send_group_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_send_group);
            this.Controls.Add(this.btn_join);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.lbl_group);
            this.Controls.Add(this.lbl_message);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.lbl_messages);
            this.Controls.Add(this.txt_message);
            this.Controls.Add(this.txt_group);
            this.Controls.Add(this.txt_name);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_group;
        private System.Windows.Forms.TextBox txt_message;
        private System.Windows.Forms.ListBox lbl_messages;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_message;
        private System.Windows.Forms.Label lbl_group;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.Button btn_join;
        private System.Windows.Forms.Button btn_send_group;
    }
}

