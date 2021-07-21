
namespace LicenseTax
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
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
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
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.cbxType1 = new System.Windows.Forms.ComboBox();
            this.cbxType2 = new System.Windows.Forms.ComboBox();
            this.rad1 = new System.Windows.Forms.RadioButton();
            this.rad2 = new System.Windows.Forms.RadioButton();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.dtp1 = new System.Windows.Forms.DateTimePicker();
            this.dtp2 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "使用期間";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 152);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "用途";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(277, 36);
            this.label3.TabIndex = 2;
            this.label3.Text = "汽缸CC數／馬達馬力";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 334);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 36);
            this.label4.TabIndex = 3;
            this.label4.Text = "試算結果";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(368, 334);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(71, 36);
            this.lblResult.TabIndex = 4;
            this.lblResult.Text = "結果";
            // 
            // cbxType1
            // 
            this.cbxType1.FormattingEnabled = true;
            this.cbxType1.Location = new System.Drawing.Point(451, 152);
            this.cbxType1.Name = "cbxType1";
            this.cbxType1.Size = new System.Drawing.Size(299, 43);
            this.cbxType1.TabIndex = 5;
            this.cbxType1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cbxType2
            // 
            this.cbxType2.FormattingEnabled = true;
            this.cbxType2.Location = new System.Drawing.Point(451, 238);
            this.cbxType2.Name = "cbxType2";
            this.cbxType2.Size = new System.Drawing.Size(403, 43);
            this.cbxType2.TabIndex = 6;
            // 
            // rad1
            // 
            this.rad1.AutoSize = true;
            this.rad1.Location = new System.Drawing.Point(451, 60);
            this.rad1.Name = "rad1";
            this.rad1.Size = new System.Drawing.Size(120, 40);
            this.rad1.TabIndex = 7;
            this.rad1.TabStop = true;
            this.rad1.Text = "全年度";
            this.rad1.UseVisualStyleBackColor = true;
            this.rad1.CheckedChanged += new System.EventHandler(this.rad1_CheckedChanged);
            // 
            // rad2
            // 
            this.rad2.AutoSize = true;
            this.rad2.Location = new System.Drawing.Point(577, 60);
            this.rad2.Name = "rad2";
            this.rad2.Size = new System.Drawing.Size(120, 40);
            this.rad2.TabIndex = 8;
            this.rad2.TabStop = true;
            this.rad2.Text = "依期間";
            this.rad2.UseVisualStyleBackColor = true;
            this.rad2.CheckedChanged += new System.EventHandler(this.rad2_CheckedChanged);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(277, 607);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(187, 64);
            this.btnCalculate.TabIndex = 9;
            this.btnCalculate.Text = "確定送出";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(604, 607);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(191, 64);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "取消重填";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // dtp1
            // 
            this.dtp1.Location = new System.Drawing.Point(735, 57);
            this.dtp1.Name = "dtp1";
            this.dtp1.Size = new System.Drawing.Size(234, 43);
            this.dtp1.TabIndex = 11;
            this.dtp1.Value = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.dtp1.Visible = false;
            // 
            // dtp2
            // 
            this.dtp2.Location = new System.Drawing.Point(1032, 60);
            this.dtp2.Name = "dtp2";
            this.dtp2.Size = new System.Drawing.Size(235, 43);
            this.dtp2.TabIndex = 12;
            this.dtp2.Value = new System.DateTime(2021, 12, 31, 0, 0, 0, 0);
            this.dtp2.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(686, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 36);
            this.label5.TabIndex = 13;
            this.label5.Text = "從";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(975, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 36);
            this.label6.TabIndex = 14;
            this.label6.Text = "至";
            this.label6.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 35F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1279, 683);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtp2);
            this.Controls.Add(this.dtp1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.rad2);
            this.Controls.Add(this.rad1);
            this.Controls.Add(this.cbxType2);
            this.Controls.Add(this.cbxType1);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.ComboBox cbxType1;
        private System.Windows.Forms.ComboBox cbxType2;
        private System.Windows.Forms.RadioButton rad1;
        private System.Windows.Forms.RadioButton rad2;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.DateTimePicker dtp1;
        private System.Windows.Forms.DateTimePicker dtp2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

