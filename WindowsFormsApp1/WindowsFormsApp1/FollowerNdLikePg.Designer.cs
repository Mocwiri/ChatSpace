namespace WindowsFormsApp1
{
    partial class FollowerNdLikePg
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
            this.cbFollowers = new System.Windows.Forms.ComboBox();
            this.cbLikes = new System.Windows.Forms.ComboBox();
            this.lblFollow = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbFollowers
            // 
            this.cbFollowers.FormattingEnabled = true;
            this.cbFollowers.Location = new System.Drawing.Point(193, 115);
            this.cbFollowers.Name = "cbFollowers";
            this.cbFollowers.Size = new System.Drawing.Size(213, 24);
            this.cbFollowers.TabIndex = 0;
            // 
            // cbLikes
            // 
            this.cbLikes.FormattingEnabled = true;
            this.cbLikes.Location = new System.Drawing.Point(193, 199);
            this.cbLikes.Name = "cbLikes";
            this.cbLikes.Size = new System.Drawing.Size(213, 24);
            this.cbLikes.TabIndex = 1;
            // 
            // lblFollow
            // 
            this.lblFollow.AutoSize = true;
            this.lblFollow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFollow.Location = new System.Drawing.Point(39, 111);
            this.lblFollow.Name = "lblFollow";
            this.lblFollow.Size = new System.Drawing.Size(95, 25);
            this.lblFollow.TabIndex = 2;
            this.lblFollow.Text = "Followers";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Likes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(121, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Interaction Page";
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(193, 289);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(107, 34);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "Save";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(193, 359);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // FollowerNdLikePg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblFollow);
            this.Controls.Add(this.cbLikes);
            this.Controls.Add(this.cbFollowers);
            this.Name = "FollowerNdLikePg";
            this.Text = "FollowerNdLikePg";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbFollowers;
        private System.Windows.Forms.ComboBox cbLikes;
        private System.Windows.Forms.Label lblFollow;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label1;
    }
}