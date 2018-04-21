namespace AutoShutDown
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dtp1 = new System.Windows.Forms.DateTimePicker();
            this.cmbHour = new System.Windows.Forms.ComboBox();
            this.lblHour = new System.Windows.Forms.Label();
            this.nudMinute = new System.Windows.Forms.NumericUpDown();
            this.lblMinute = new System.Windows.Forms.Label();
            this.lblSecond = new System.Windows.Forms.Label();
            this.nudSecond = new System.Windows.Forms.NumericUpDown();
            this.btnOK = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nudMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSecond)).BeginInit();
            this.SuspendLayout();
            // 
            // dtp1
            // 
            this.dtp1.Location = new System.Drawing.Point(12, 12);
            this.dtp1.Name = "dtp1";
            this.dtp1.Size = new System.Drawing.Size(126, 22);
            this.dtp1.TabIndex = 0;
            // 
            // cmbHour
            // 
            this.cmbHour.FormattingEnabled = true;
            this.cmbHour.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.cmbHour.Location = new System.Drawing.Point(145, 13);
            this.cmbHour.Name = "cmbHour";
            this.cmbHour.Size = new System.Drawing.Size(63, 20);
            this.cmbHour.TabIndex = 1;
            // 
            // lblHour
            // 
            this.lblHour.AutoSize = true;
            this.lblHour.Font = new System.Drawing.Font("新細明體", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblHour.Location = new System.Drawing.Point(214, 15);
            this.lblHour.Name = "lblHour";
            this.lblHour.Size = new System.Drawing.Size(26, 18);
            this.lblHour.TabIndex = 2;
            this.lblHour.Text = "時";
            // 
            // nudMinute
            // 
            this.nudMinute.Location = new System.Drawing.Point(247, 11);
            this.nudMinute.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nudMinute.Name = "nudMinute";
            this.nudMinute.Size = new System.Drawing.Size(54, 22);
            this.nudMinute.TabIndex = 3;
            // 
            // lblMinute
            // 
            this.lblMinute.AutoSize = true;
            this.lblMinute.Font = new System.Drawing.Font("新細明體", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblMinute.Location = new System.Drawing.Point(307, 15);
            this.lblMinute.Name = "lblMinute";
            this.lblMinute.Size = new System.Drawing.Size(26, 18);
            this.lblMinute.TabIndex = 4;
            this.lblMinute.Text = "分";
            // 
            // lblSecond
            // 
            this.lblSecond.AutoSize = true;
            this.lblSecond.Font = new System.Drawing.Font("新細明體", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblSecond.Location = new System.Drawing.Point(399, 15);
            this.lblSecond.Name = "lblSecond";
            this.lblSecond.Size = new System.Drawing.Size(26, 18);
            this.lblSecond.TabIndex = 6;
            this.lblSecond.Text = "秒";
            // 
            // nudSecond
            // 
            this.nudSecond.Location = new System.Drawing.Point(339, 11);
            this.nudSecond.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nudSecond.Name = "nudSecond";
            this.nudSecond.Size = new System.Drawing.Size(54, 22);
            this.nudSecond.TabIndex = 5;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(461, 13);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 7;
            this.btnOK.Text = "確定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(13, 53);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(125, 12);
            this.lblResult.TabIndex = 8;
            this.lblResult.Text = "您尚未設定關機時間！";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 77);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblSecond);
            this.Controls.Add(this.nudSecond);
            this.Controls.Add(this.lblMinute);
            this.Controls.Add(this.nudMinute);
            this.Controls.Add(this.lblHour);
            this.Controls.Add(this.cmbHour);
            this.Controls.Add(this.dtp1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSecond)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp1;
        private System.Windows.Forms.ComboBox cmbHour;
        private System.Windows.Forms.Label lblHour;
        private System.Windows.Forms.NumericUpDown nudMinute;
        private System.Windows.Forms.Label lblMinute;
        private System.Windows.Forms.Label lblSecond;
        private System.Windows.Forms.NumericUpDown nudSecond;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Timer timer1;
    }
}

