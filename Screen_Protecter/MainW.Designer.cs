namespace Screen_Protecter
{
    partial class MainW
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainW));
            this.label1 = new System.Windows.Forms.Label();
            this.Pwd = new System.Windows.Forms.TextBox();
            this.Lock_b = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("等线", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "设置密码：";
            // 
            // Pwd
            // 
            this.Pwd.Location = new System.Drawing.Point(128, 20);
            this.Pwd.Name = "Pwd";
            this.Pwd.Size = new System.Drawing.Size(200, 25);
            this.Pwd.TabIndex = 1;
            this.Pwd.TextChanged += new System.EventHandler(this.Pwd_TextChanged);
            this.Pwd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Pwd_KeyDown);
            // 
            // Lock_b
            // 
            this.Lock_b.Location = new System.Drawing.Point(366, 18);
            this.Lock_b.Name = "Lock_b";
            this.Lock_b.Size = new System.Drawing.Size(75, 30);
            this.Lock_b.TabIndex = 2;
            this.Lock_b.Text = "锁定";
            this.Lock_b.UseVisualStyleBackColor = true;
            this.Lock_b.Click += new System.EventHandler(this.Lock_b_Click);
            // 
            // MainW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 58);
            this.Controls.Add(this.Lock_b);
            this.Controls.Add(this.Pwd);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainW";
            this.Text = "SetPassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Pwd;
        private System.Windows.Forms.Button Lock_b;
    }
}