
namespace lab7_Derikot_Melnykov_Kirilenko_Telezhynskyi
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.buttonGKey = new System.Windows.Forms.Button();
            this.textKey = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.checkBoxIV0 = new System.Windows.Forms.CheckBox();
            this.buttonGIV = new System.Windows.Forms.Button();
            this.textIV = new System.Windows.Forms.TextBox();
            this.textTime = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.buttonDecrypt = new System.Windows.Forms.Button();
            this.buttonEncrypt = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.radioButton3Des = new System.Windows.Forms.RadioButton();
            this.radioButtonAes = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbKeySize = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textOutFileEntropy = new System.Windows.Forms.Label();
            this.textOutFileSize = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textOutPath = new System.Windows.Forms.TextBox();
            this.bOut = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textInFileEntropy = new System.Windows.Forms.Label();
            this.textInFileSize = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.bIn = new System.Windows.Forms.Button();
            this.textInPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox8.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.buttonSave);
            this.groupBox8.Controls.Add(this.buttonLoad);
            this.groupBox8.Controls.Add(this.groupBox5);
            this.groupBox8.Controls.Add(this.groupBox6);
            this.groupBox8.Location = new System.Drawing.Point(13, 365);
            this.groupBox8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox8.Size = new System.Drawing.Size(775, 217);
            this.groupBox8.TabIndex = 21;
            this.groupBox8.TabStop = false;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(513, 169);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(123, 32);
            this.buttonSave.TabIndex = 10;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(647, 169);
            this.buttonLoad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(123, 32);
            this.buttonLoad.TabIndex = 11;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.buttonGKey);
            this.groupBox5.Controls.Add(this.textKey);
            this.groupBox5.Location = new System.Drawing.Point(5, 21);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Size = new System.Drawing.Size(763, 68);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Key";
            // 
            // buttonGKey
            // 
            this.buttonGKey.Location = new System.Drawing.Point(491, 18);
            this.buttonGKey.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonGKey.Name = "buttonGKey";
            this.buttonGKey.Size = new System.Drawing.Size(159, 31);
            this.buttonGKey.TabIndex = 1;
            this.buttonGKey.Text = "Generate Key";
            this.buttonGKey.UseVisualStyleBackColor = true;
            this.buttonGKey.Click += new System.EventHandler(this.buttonGKey_Click);
            // 
            // textKey
            // 
            this.textKey.Location = new System.Drawing.Point(7, 22);
            this.textKey.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textKey.Name = "textKey";
            this.textKey.Size = new System.Drawing.Size(477, 22);
            this.textKey.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.checkBoxIV0);
            this.groupBox6.Controls.Add(this.buttonGIV);
            this.groupBox6.Controls.Add(this.textIV);
            this.groupBox6.Location = new System.Drawing.Point(5, 95);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox6.Size = new System.Drawing.Size(763, 68);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Initialization Vector";
            // 
            // checkBoxIV0
            // 
            this.checkBoxIV0.AutoSize = true;
            this.checkBoxIV0.Location = new System.Drawing.Point(655, 23);
            this.checkBoxIV0.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxIV0.Name = "checkBoxIV0";
            this.checkBoxIV0.Size = new System.Drawing.Size(66, 21);
            this.checkBoxIV0.TabIndex = 2;
            this.checkBoxIV0.Text = "ВІ = 0";
            this.checkBoxIV0.UseVisualStyleBackColor = true;
            this.checkBoxIV0.CheckedChanged += new System.EventHandler(this.checkBoxIV0_CheckedChanged);
            // 
            // buttonGIV
            // 
            this.buttonGIV.Location = new System.Drawing.Point(491, 18);
            this.buttonGIV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonGIV.Name = "buttonGIV";
            this.buttonGIV.Size = new System.Drawing.Size(159, 31);
            this.buttonGIV.TabIndex = 1;
            this.buttonGIV.Text = "Generate ВІ";
            this.buttonGIV.UseVisualStyleBackColor = true;
            this.buttonGIV.Click += new System.EventHandler(this.buttonGIV_Click);
            // 
            // textIV
            // 
            this.textIV.Location = new System.Drawing.Point(7, 22);
            this.textIV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textIV.Name = "textIV";
            this.textIV.Size = new System.Drawing.Size(477, 22);
            this.textIV.TabIndex = 0;
            // 
            // textTime
            // 
            this.textTime.AutoSize = true;
            this.textTime.Location = new System.Drawing.Point(712, 657);
            this.textTime.Name = "textTime";
            this.textTime.Size = new System.Drawing.Size(64, 17);
            this.textTime.TabIndex = 20;
            this.textTime.Text = "00:00:00";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(549, 657);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(114, 17);
            this.label11.TabIndex = 19;
            this.label11.Text = "Settlement Time:";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(349, 651);
            this.button7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(155, 30);
            this.button7.TabIndex = 18;
            this.button7.Text = "Stop";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // buttonDecrypt
            // 
            this.buttonDecrypt.Location = new System.Drawing.Point(181, 651);
            this.buttonDecrypt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDecrypt.Name = "buttonDecrypt";
            this.buttonDecrypt.Size = new System.Drawing.Size(163, 30);
            this.buttonDecrypt.TabIndex = 17;
            this.buttonDecrypt.Text = "Decipher";
            this.buttonDecrypt.UseVisualStyleBackColor = true;
            this.buttonDecrypt.Click += new System.EventHandler(this.buttonDecrypt_Click);
            // 
            // buttonEncrypt
            // 
            this.buttonEncrypt.Location = new System.Drawing.Point(13, 651);
            this.buttonEncrypt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEncrypt.Name = "buttonEncrypt";
            this.buttonEncrypt.Size = new System.Drawing.Size(163, 30);
            this.buttonEncrypt.TabIndex = 16;
            this.buttonEncrypt.Text = "Encrypt";
            this.buttonEncrypt.UseVisualStyleBackColor = true;
            this.buttonEncrypt.Click += new System.EventHandler(this.buttonEncrypt_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.radioButton3Des);
            this.groupBox7.Controls.Add(this.radioButtonAes);
            this.groupBox7.Location = new System.Drawing.Point(13, 587);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox7.Size = new System.Drawing.Size(775, 58);
            this.groupBox7.TabIndex = 15;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Encryption Algorithm";
            // 
            // radioButton3Des
            // 
            this.radioButton3Des.AutoSize = true;
            this.radioButton3Des.Location = new System.Drawing.Point(76, 21);
            this.radioButton3Des.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton3Des.Name = "radioButton3Des";
            this.radioButton3Des.Size = new System.Drawing.Size(65, 21);
            this.radioButton3Des.TabIndex = 2;
            this.radioButton3Des.TabStop = true;
            this.radioButton3Des.Text = "3DES";
            this.radioButton3Des.UseVisualStyleBackColor = true;
            this.radioButton3Des.CheckedChanged += new System.EventHandler(this.radioButton3Des_CheckedChanged);
            // 
            // radioButtonAes
            // 
            this.radioButtonAes.AutoSize = true;
            this.radioButtonAes.Checked = true;
            this.radioButtonAes.Location = new System.Drawing.Point(13, 21);
            this.radioButtonAes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonAes.Name = "radioButtonAes";
            this.radioButtonAes.Size = new System.Drawing.Size(56, 21);
            this.radioButtonAes.TabIndex = 0;
            this.radioButtonAes.TabStop = true;
            this.radioButtonAes.Text = "AES";
            this.radioButtonAes.UseVisualStyleBackColor = true;
            this.radioButtonAes.CheckedChanged += new System.EventHandler(this.radioButtonAes_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbKeySize);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Location = new System.Drawing.Point(12, 259);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(776, 100);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Parameters";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // cbKeySize
            // 
            this.cbKeySize.FormattingEnabled = true;
            this.cbKeySize.Items.AddRange(new object[] {
            "128",
            "256"});
            this.cbKeySize.Location = new System.Drawing.Point(171, 39);
            this.cbKeySize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbKeySize.Name = "cbKeySize";
            this.cbKeySize.Size = new System.Drawing.Size(121, 24);
            this.cbKeySize.TabIndex = 4;
            this.cbKeySize.Text = " ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 17);
            this.label9.TabIndex = 2;
            this.label9.Text = "Key lenght (bits): ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(776, 241);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "File Menu";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textOutFileEntropy);
            this.groupBox3.Controls.Add(this.textOutFileSize);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.textOutPath);
            this.groupBox3.Controls.Add(this.bOut);
            this.groupBox3.Location = new System.Drawing.Point(5, 127);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(764, 100);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Output";
            // 
            // textOutFileEntropy
            // 
            this.textOutFileEntropy.AutoSize = true;
            this.textOutFileEntropy.Location = new System.Drawing.Point(87, 80);
            this.textOutFileEntropy.Name = "textOutFileEntropy";
            this.textOutFileEntropy.Size = new System.Drawing.Size(32, 17);
            this.textOutFileEntropy.TabIndex = 9;
            this.textOutFileEntropy.Text = "???";
            // 
            // textOutFileSize
            // 
            this.textOutFileSize.AutoSize = true;
            this.textOutFileSize.Location = new System.Drawing.Point(325, 80);
            this.textOutFileSize.Name = "textOutFileSize";
            this.textOutFileSize.Size = new System.Drawing.Size(32, 17);
            this.textOutFileSize.TabIndex = 7;
            this.textOutFileSize.Text = "???";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(260, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Size:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "Entropy: ";
            // 
            // textOutPath
            // 
            this.textOutPath.Location = new System.Drawing.Point(9, 42);
            this.textOutPath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textOutPath.Name = "textOutPath";
            this.textOutPath.Size = new System.Drawing.Size(689, 22);
            this.textOutPath.TabIndex = 3;
            // 
            // bOut
            // 
            this.bOut.Location = new System.Drawing.Point(704, 38);
            this.bOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bOut.Name = "bOut";
            this.bOut.Size = new System.Drawing.Size(53, 31);
            this.bOut.TabIndex = 2;
            this.bOut.Text = "...";
            this.bOut.UseVisualStyleBackColor = true;
            this.bOut.Click += new System.EventHandler(this.bOut_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textInFileEntropy);
            this.groupBox2.Controls.Add(this.textInFileSize);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.bIn);
            this.groupBox2.Controls.Add(this.textInPath);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(5, 21);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(764, 100);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Input";
            // 
            // textInFileEntropy
            // 
            this.textInFileEntropy.AutoSize = true;
            this.textInFileEntropy.Location = new System.Drawing.Point(87, 80);
            this.textInFileEntropy.Name = "textInFileEntropy";
            this.textInFileEntropy.Size = new System.Drawing.Size(32, 17);
            this.textInFileEntropy.TabIndex = 5;
            this.textInFileEntropy.Text = "???";
            // 
            // textInFileSize
            // 
            this.textInFileSize.AutoSize = true;
            this.textInFileSize.Location = new System.Drawing.Point(325, 80);
            this.textInFileSize.Name = "textInFileSize";
            this.textInFileSize.Size = new System.Drawing.Size(32, 17);
            this.textInFileSize.TabIndex = 2;
            this.textInFileSize.Text = "???";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(260, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Size: ";
            // 
            // bIn
            // 
            this.bIn.Location = new System.Drawing.Point(704, 34);
            this.bIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bIn.Name = "bIn";
            this.bIn.Size = new System.Drawing.Size(53, 31);
            this.bIn.TabIndex = 3;
            this.bIn.Text = "...";
            this.bIn.UseVisualStyleBackColor = true;
            this.bIn.Click += new System.EventHandler(this.bIn_Click);
            // 
            // textInPath
            // 
            this.textInPath.Location = new System.Drawing.Point(9, 38);
            this.textInPath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textInPath.Name = "textInPath";
            this.textInPath.Size = new System.Drawing.Size(689, 22);
            this.textInPath.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Entropy: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 759);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.textTime);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.buttonDecrypt);
            this.Controls.Add(this.buttonEncrypt);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox8.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button buttonGKey;
        private System.Windows.Forms.TextBox textKey;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.CheckBox checkBoxIV0;
        private System.Windows.Forms.Button buttonGIV;
        private System.Windows.Forms.TextBox textIV;
        private System.Windows.Forms.Label textTime;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button buttonDecrypt;
        private System.Windows.Forms.Button buttonEncrypt;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.RadioButton radioButton3Des;
        private System.Windows.Forms.RadioButton radioButtonAes;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cbKeySize;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label textOutFileEntropy;
        private System.Windows.Forms.Label textOutFileSize;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textOutPath;
        private System.Windows.Forms.Button bOut;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label textInFileEntropy;
        private System.Windows.Forms.Label textInFileSize;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bIn;
        private System.Windows.Forms.TextBox textInPath;
        private System.Windows.Forms.Label label2;
    }
}

