namespace NetMeetingExample
{
    partial class FormMeeting
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBoxMessage = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBoxAddress = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.groupBoxRoom = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBoxRoom.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(12, 12);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(100, 25);
            this.buttonLogin.TabIndex = 0;
            this.buttonLogin.Text = "进入会议室";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(141, 12);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(100, 25);
            this.buttonLogout.TabIndex = 1;
            this.buttonLogout.Text = "离开会议室";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBoxMessage);
            this.groupBox1.Location = new System.Drawing.Point(6, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(222, 209);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "相关信息";
            // 
            // listBoxMessage
            // 
            this.listBoxMessage.FormattingEnabled = true;
            this.listBoxMessage.ItemHeight = 17;
            this.listBoxMessage.Location = new System.Drawing.Point(6, 22);
            this.listBoxMessage.Name = "listBoxMessage";
            this.listBoxMessage.Size = new System.Drawing.Size(210, 174);
            this.listBoxMessage.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBoxAddress);
            this.groupBox2.Location = new System.Drawing.Point(234, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(219, 209);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "会议室现有成员";
            // 
            // listBoxAddress
            // 
            this.listBoxAddress.FormattingEnabled = true;
            this.listBoxAddress.ItemHeight = 17;
            this.listBoxAddress.Location = new System.Drawing.Point(6, 22);
            this.listBoxAddress.Name = "listBoxAddress";
            this.listBoxAddress.Size = new System.Drawing.Size(207, 174);
            this.listBoxAddress.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxMessage);
            this.groupBox3.Location = new System.Drawing.Point(12, 287);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(459, 62);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.Location = new System.Drawing.Point(6, 22);
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.Size = new System.Drawing.Size(447, 23);
            this.textBoxMessage.TabIndex = 0;
            this.textBoxMessage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // groupBoxRoom
            // 
            this.groupBoxRoom.Controls.Add(this.groupBox1);
            this.groupBoxRoom.Controls.Add(this.groupBox2);
            this.groupBoxRoom.Location = new System.Drawing.Point(12, 44);
            this.groupBoxRoom.Name = "groupBoxRoom";
            this.groupBoxRoom.Size = new System.Drawing.Size(459, 237);
            this.groupBoxRoom.TabIndex = 5;
            this.groupBoxRoom.TabStop = false;
            this.groupBoxRoom.Text = "会议室";
            // 
            // FormMeeting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.groupBoxRoom);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonLogin);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormMeeting";
            this.Text = "Internet网络会议";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMeeting_FormClosing);
            this.Load += new System.EventHandler(this.FormMeeting_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBoxRoom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBoxMessage;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBoxAddress;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.GroupBox groupBoxRoom;
    }
}

