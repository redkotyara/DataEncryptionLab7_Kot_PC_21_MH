namespace DataEncryptionLab7_Kot_PC_21_MH
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.outputSize = new System.Windows.Forms.Label();
            this.textBoxFileOutput = new System.Windows.Forms.TextBox();
            this.buttonFileOutput = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonFileInput = new System.Windows.Forms.Button();
            this.textBoxFileInput = new System.Windows.Forms.TextBox();
            this.inputSize = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radioButton3DES = new System.Windows.Forms.RadioButton();
            this.radioButtonAES = new System.Windows.Forms.RadioButton();
            this.codingTime = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonEncode = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(317, 276);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Файл";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.outputSize);
            this.groupBox3.Controls.Add(this.textBoxFileOutput);
            this.groupBox3.Controls.Add(this.buttonFileOutput);
            this.groupBox3.Location = new System.Drawing.Point(6, 163);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(305, 100);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Вихідний";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Розмір:";
            // 
            // outputSize
            // 
            this.outputSize.AutoSize = true;
            this.outputSize.Location = new System.Drawing.Point(74, 66);
            this.outputSize.Name = "outputSize";
            this.outputSize.Size = new System.Drawing.Size(25, 13);
            this.outputSize.TabIndex = 5;
            this.outputSize.Text = "???";
            // 
            // textBoxFileOutput
            // 
            this.textBoxFileOutput.Location = new System.Drawing.Point(4, 22);
            this.textBoxFileOutput.Name = "textBoxFileOutput";
            this.textBoxFileOutput.Size = new System.Drawing.Size(214, 20);
            this.textBoxFileOutput.TabIndex = 4;
            // 
            // buttonFileOutput
            // 
            this.buttonFileOutput.Location = new System.Drawing.Point(224, 19);
            this.buttonFileOutput.Name = "buttonFileOutput";
            this.buttonFileOutput.Size = new System.Drawing.Size(75, 23);
            this.buttonFileOutput.TabIndex = 3;
            this.buttonFileOutput.Text = "...";
            this.buttonFileOutput.UseVisualStyleBackColor = true;
            this.buttonFileOutput.Click += new System.EventHandler(this.buttonFileOutput_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.buttonFileInput);
            this.groupBox2.Controls.Add(this.textBoxFileInput);
            this.groupBox2.Controls.Add(this.inputSize);
            this.groupBox2.Location = new System.Drawing.Point(6, 43);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(305, 100);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Вхідний";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Розмір:";
            // 
            // buttonFileInput
            // 
            this.buttonFileInput.Location = new System.Drawing.Point(224, 26);
            this.buttonFileInput.Name = "buttonFileInput";
            this.buttonFileInput.Size = new System.Drawing.Size(75, 23);
            this.buttonFileInput.TabIndex = 2;
            this.buttonFileInput.Text = "...";
            this.buttonFileInput.UseVisualStyleBackColor = true;
            this.buttonFileInput.Click += new System.EventHandler(this.buttonFileInput_Click);
            // 
            // textBoxFileInput
            // 
            this.textBoxFileInput.Location = new System.Drawing.Point(6, 28);
            this.textBoxFileInput.Name = "textBoxFileInput";
            this.textBoxFileInput.Size = new System.Drawing.Size(214, 20);
            this.textBoxFileInput.TabIndex = 1;
            // 
            // inputSize
            // 
            this.inputSize.AutoSize = true;
            this.inputSize.Location = new System.Drawing.Point(74, 67);
            this.inputSize.Name = "inputSize";
            this.inputSize.Size = new System.Drawing.Size(25, 13);
            this.inputSize.TabIndex = 0;
            this.inputSize.Text = "???";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radioButton3DES);
            this.groupBox4.Controls.Add(this.radioButtonAES);
            this.groupBox4.Location = new System.Drawing.Point(12, 294);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(317, 80);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Алгоритми шифрування";
            // 
            // radioButton3DES
            // 
            this.radioButton3DES.AutoSize = true;
            this.radioButton3DES.Location = new System.Drawing.Point(194, 37);
            this.radioButton3DES.Name = "radioButton3DES";
            this.radioButton3DES.Size = new System.Drawing.Size(73, 17);
            this.radioButton3DES.TabIndex = 1;
            this.radioButton3DES.TabStop = true;
            this.radioButton3DES.Text = "TripleDES";
            this.radioButton3DES.UseVisualStyleBackColor = true;
            // 
            // radioButtonAES
            // 
            this.radioButtonAES.AutoSize = true;
            this.radioButtonAES.Location = new System.Drawing.Point(15, 37);
            this.radioButtonAES.Name = "radioButtonAES";
            this.radioButtonAES.Size = new System.Drawing.Size(46, 17);
            this.radioButtonAES.TabIndex = 0;
            this.radioButtonAES.TabStop = true;
            this.radioButtonAES.Text = "AES";
            this.radioButtonAES.UseVisualStyleBackColor = true;
            // 
            // codingTime
            // 
            this.codingTime.AutoSize = true;
            this.codingTime.Location = new System.Drawing.Point(156, 427);
            this.codingTime.Name = "codingTime";
            this.codingTime.Size = new System.Drawing.Size(25, 13);
            this.codingTime.TabIndex = 3;
            this.codingTime.Text = "???";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 427);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Час розрахунку";
            // 
            // buttonEncode
            // 
            this.buttonEncode.Location = new System.Drawing.Point(12, 380);
            this.buttonEncode.Name = "buttonEncode";
            this.buttonEncode.Size = new System.Drawing.Size(318, 23);
            this.buttonEncode.TabIndex = 0;
            this.buttonEncode.Text = "Зашифрувати";
            this.buttonEncode.UseVisualStyleBackColor = true;
            this.buttonEncode.Click += new System.EventHandler(this.buttonEncode_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 462);
            this.Controls.Add(this.codingTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.buttonEncode);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button buttonFileInput;
        private System.Windows.Forms.TextBox textBoxFileInput;
        private System.Windows.Forms.Label inputSize;
        private System.Windows.Forms.TextBox textBoxFileOutput;
        private System.Windows.Forms.Button buttonFileOutput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label outputSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton3DES;
        private System.Windows.Forms.RadioButton radioButtonAES;
        private System.Windows.Forms.Label codingTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonEncode;
    }
}

