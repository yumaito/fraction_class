namespace FractionTest
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxXN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxXD = new System.Windows.Forms.TextBox();
            this.textBoxYN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxYD = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.radioButtonPlus = new System.Windows.Forms.RadioButton();
            this.radioButtonMinus = new System.Windows.Forms.RadioButton();
            this.radioButtonMultiple = new System.Windows.Forms.RadioButton();
            this.radioButtonDivide = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxXN
            // 
            this.textBoxXN.Location = new System.Drawing.Point(13, 13);
            this.textBoxXN.Name = "textBoxXN";
            this.textBoxXN.Size = new System.Drawing.Size(41, 19);
            this.textBoxXN.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "/";
            // 
            // textBoxXD
            // 
            this.textBoxXD.Location = new System.Drawing.Point(79, 12);
            this.textBoxXD.Name = "textBoxXD";
            this.textBoxXD.Size = new System.Drawing.Size(46, 19);
            this.textBoxXD.TabIndex = 2;
            // 
            // textBoxYN
            // 
            this.textBoxYN.Location = new System.Drawing.Point(13, 39);
            this.textBoxYN.Name = "textBoxYN";
            this.textBoxYN.Size = new System.Drawing.Size(41, 19);
            this.textBoxYN.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "/";
            // 
            // textBoxYD
            // 
            this.textBoxYD.Location = new System.Drawing.Point(78, 39);
            this.textBoxYD.Name = "textBoxYD";
            this.textBoxYD.Size = new System.Drawing.Size(47, 19);
            this.textBoxYD.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(13, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(177, 51);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.radioButtonPlus);
            this.flowLayoutPanel1.Controls.Add(this.radioButtonMinus);
            this.flowLayoutPanel1.Controls.Add(this.radioButtonMultiple);
            this.flowLayoutPanel1.Controls.Add(this.radioButtonDivide);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(7, 19);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(164, 26);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // radioButtonPlus
            // 
            this.radioButtonPlus.AutoSize = true;
            this.radioButtonPlus.Location = new System.Drawing.Point(3, 3);
            this.radioButtonPlus.Name = "radioButtonPlus";
            this.radioButtonPlus.Size = new System.Drawing.Size(29, 16);
            this.radioButtonPlus.TabIndex = 0;
            this.radioButtonPlus.TabStop = true;
            this.radioButtonPlus.Text = "+";
            this.radioButtonPlus.UseVisualStyleBackColor = true;
            // 
            // radioButtonMinus
            // 
            this.radioButtonMinus.AutoSize = true;
            this.radioButtonMinus.Location = new System.Drawing.Point(38, 3);
            this.radioButtonMinus.Name = "radioButtonMinus";
            this.radioButtonMinus.Size = new System.Drawing.Size(29, 16);
            this.radioButtonMinus.TabIndex = 1;
            this.radioButtonMinus.TabStop = true;
            this.radioButtonMinus.Text = "-";
            this.radioButtonMinus.UseVisualStyleBackColor = true;
            // 
            // radioButtonMultiple
            // 
            this.radioButtonMultiple.AutoSize = true;
            this.radioButtonMultiple.Location = new System.Drawing.Point(73, 3);
            this.radioButtonMultiple.Name = "radioButtonMultiple";
            this.radioButtonMultiple.Size = new System.Drawing.Size(29, 16);
            this.radioButtonMultiple.TabIndex = 2;
            this.radioButtonMultiple.TabStop = true;
            this.radioButtonMultiple.Text = "x";
            this.radioButtonMultiple.UseVisualStyleBackColor = true;
            // 
            // radioButtonDivide
            // 
            this.radioButtonDivide.AutoSize = true;
            this.radioButtonDivide.Location = new System.Drawing.Point(108, 3);
            this.radioButtonDivide.Name = "radioButtonDivide";
            this.radioButtonDivide.Size = new System.Drawing.Size(29, 16);
            this.radioButtonDivide.TabIndex = 3;
            this.radioButtonDivide.TabStop = true;
            this.radioButtonDivide.Text = "/";
            this.radioButtonDivide.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "計算";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(13, 162);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(109, 19);
            this.textBoxResult.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBoxYD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxYN);
            this.Controls.Add(this.textBoxXD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxXN);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxXN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxXD;
        private System.Windows.Forms.TextBox textBoxYN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxYD;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.RadioButton radioButtonPlus;
        private System.Windows.Forms.RadioButton radioButtonMinus;
        private System.Windows.Forms.RadioButton radioButtonMultiple;
        private System.Windows.Forms.RadioButton radioButtonDivide;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxResult;
    }
}

