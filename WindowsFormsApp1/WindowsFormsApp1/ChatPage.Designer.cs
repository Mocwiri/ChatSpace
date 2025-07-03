namespace WindowsFormsApp1
{
    partial class ChatPage
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
            this.label1 = new System.Windows.Forms.Label();
            this.ChatBox = new System.Windows.Forms.ListBox();
            this.btnChat = new System.Windows.Forms.Button();
            this.lblTopic = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.txtTopic = new System.Windows.Forms.TextBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnLF = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(169, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(466, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to the Collaborative online Interaction";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ChatBox
            // 
            this.ChatBox.FormattingEnabled = true;
            this.ChatBox.ItemHeight = 16;
            this.ChatBox.Location = new System.Drawing.Point(12, 75);
            this.ChatBox.Name = "ChatBox";
            this.ChatBox.Size = new System.Drawing.Size(903, 196);
            this.ChatBox.TabIndex = 1;
            // 
            // btnChat
            // 
            this.btnChat.Location = new System.Drawing.Point(242, 472);
            this.btnChat.Name = "btnChat";
            this.btnChat.Size = new System.Drawing.Size(75, 23);
            this.btnChat.TabIndex = 2;
            this.btnChat.Text = "Send";
            this.btnChat.UseVisualStyleBackColor = true;
            this.btnChat.Click += new System.EventHandler(this.btnChat_Click);
            // 
            // lblTopic
            // 
            this.lblTopic.AutoSize = true;
            this.lblTopic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopic.Location = new System.Drawing.Point(146, 335);
            this.lblTopic.Name = "lblTopic";
            this.lblTopic.Size = new System.Drawing.Size(50, 20);
            this.lblTopic.TabIndex = 3;
            this.lblTopic.Text = "Topic";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(146, 407);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(77, 20);
            this.lblMessage.TabIndex = 4;
            this.lblMessage.Text = "Message";
            // 
            // txtTopic
            // 
            this.txtTopic.Location = new System.Drawing.Point(345, 335);
            this.txtTopic.Name = "txtTopic";
            this.txtTopic.Size = new System.Drawing.Size(137, 22);
            this.txtTopic.TabIndex = 5;
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(345, 405);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(137, 22);
            this.txtMessage.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 514);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "label2";
            // 
            // BtnLF
            // 
            this.BtnLF.Location = new System.Drawing.Point(345, 472);
            this.BtnLF.Name = "BtnLF";
            this.BtnLF.Size = new System.Drawing.Size(137, 23);
            this.BtnLF.TabIndex = 8;
            this.BtnLF.Text = "Likes nd Followers";
            this.BtnLF.UseVisualStyleBackColor = true;
            this.BtnLF.Click += new System.EventHandler(this.BtnLF_Click);
            // 
            // ChatPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 576);
            this.Controls.Add(this.BtnLF);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.txtTopic);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblTopic);
            this.Controls.Add(this.btnChat);
            this.Controls.Add(this.ChatBox);
            this.Controls.Add(this.label1);
            this.Name = "ChatPage";
            this.Text = "ChatPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox ChatBox;
        private System.Windows.Forms.Button btnChat;
        private System.Windows.Forms.Label lblTopic;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.TextBox txtTopic;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnLF;
    }
}