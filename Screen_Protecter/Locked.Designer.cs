namespace Screen_Protecter
{
    partial class Locked
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
            this.label1 = new System.Windows.Forms.Label();
            this.Pwd_input = new System.Windows.Forms.TextBox();
            this.len_s = new System.Windows.Forms.Label();
            this.SHOW_incorrect = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(499, 397);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "输入密码以解锁:";
            // 
            // Pwd_input
            // 
            this.Pwd_input.Font = new System.Drawing.Font("黑体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Pwd_input.Location = new System.Drawing.Point(672, 396);
            this.Pwd_input.Name = "Pwd_input";
            this.Pwd_input.Size = new System.Drawing.Size(215, 28);
            this.Pwd_input.TabIndex = 1;
            this.Pwd_input.TextChanged += new System.EventHandler(this.Pwd_input_TextChanged);
            this.Pwd_input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Pwd_input_KeyDown);
            // 
            // len_s
            // 
            this.len_s.AutoSize = true;
            this.len_s.Font = new System.Drawing.Font("黑体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.len_s.Location = new System.Drawing.Point(901, 399);
            this.len_s.Name = "len_s";
            this.len_s.Size = new System.Drawing.Size(76, 18);
            this.len_s.TabIndex = 2;
            this.len_s.Text = "*长度:0";
            // 
            // SHOW_incorrect
            // 
            this.SHOW_incorrect.AutoSize = true;
            this.SHOW_incorrect.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SHOW_incorrect.ForeColor = System.Drawing.Color.Red;
            this.SHOW_incorrect.Location = new System.Drawing.Point(724, 361);
            this.SHOW_incorrect.Name = "SHOW_incorrect";
            this.SHOW_incorrect.Size = new System.Drawing.Size(126, 20);
            this.SHOW_incorrect.TabIndex = 3;
            this.SHOW_incorrect.Text = "*错误次数:0";
            // 
            // Locked
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1401, 653);
            this.Controls.Add(this.SHOW_incorrect);
            this.Controls.Add(this.len_s);
            this.Controls.Add(this.Pwd_input);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Locked";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Locked_FormClosing);
            this.Load += new System.EventHandler(this.Locked_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Pwd_input;
        private System.Windows.Forms.Label len_s;
        private System.Windows.Forms.Label SHOW_incorrect;
    }
}

