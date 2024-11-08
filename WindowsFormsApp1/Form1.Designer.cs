namespace WindowsFormsApp1
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
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnCheckStrength = new System.Windows.Forms.Button();
            this.chkSpecialChars = new System.Windows.Forms.CheckBox();
            this.lblPasswordStrength = new System.Windows.Forms.Label();
            this.nudPasswordLength = new System.Windows.Forms.NumericUpDown();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudPasswordLength)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(292, 266);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(95, 23);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "Сгенерировать";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.BtnGenerate_Click);
            // 
            // btnCheckStrength
            // 
            this.btnCheckStrength.Enabled = false;
            this.btnCheckStrength.Location = new System.Drawing.Point(292, 296);
            this.btnCheckStrength.Name = "btnCheckStrength";
            this.btnCheckStrength.Size = new System.Drawing.Size(161, 23);
            this.btnCheckStrength.TabIndex = 1;
            this.btnCheckStrength.Text = "Проверить силу пароля";
            this.btnCheckStrength.UseVisualStyleBackColor = true;
            this.btnCheckStrength.Click += new System.EventHandler(this.BtnCheckStrength_Click);
            // 
            // chkSpecialChars
            // 
            this.chkSpecialChars.AutoSize = true;
            this.chkSpecialChars.Location = new System.Drawing.Point(292, 227);
            this.chkSpecialChars.Name = "chkSpecialChars";
            this.chkSpecialChars.Size = new System.Drawing.Size(219, 17);
            this.chkSpecialChars.TabIndex = 2;
            this.chkSpecialChars.Text = "Использовать специальные символы";
            this.chkSpecialChars.UseVisualStyleBackColor = true;
            // 
            // lblPasswordStrength
            // 
            this.lblPasswordStrength.AutoSize = true;
            this.lblPasswordStrength.Location = new System.Drawing.Point(289, 90);
            this.lblPasswordStrength.Name = "lblPasswordStrength";
            this.lblPasswordStrength.Size = new System.Drawing.Size(74, 13);
            this.lblPasswordStrength.TabIndex = 3;
            this.lblPasswordStrength.Text = "Сила пароля:";
            // 
            // nudPasswordLength
            // 
            this.nudPasswordLength.Location = new System.Drawing.Point(44, 109);
            this.nudPasswordLength.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudPasswordLength.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.nudPasswordLength.Name = "nudPasswordLength";
            this.nudPasswordLength.Size = new System.Drawing.Size(36, 20);
            this.nudPasswordLength.TabIndex = 4;
            this.nudPasswordLength.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(44, 83);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.ReadOnly = true;
            this.txtPassword.Size = new System.Drawing.Size(152, 20);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(44, 136);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Очистить";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 361);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.nudPasswordLength);
            this.Controls.Add(this.lblPasswordStrength);
            this.Controls.Add(this.chkSpecialChars);
            this.Controls.Add(this.btnCheckStrength);
            this.Controls.Add(this.btnGenerate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudPasswordLength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnCheckStrength;
        private System.Windows.Forms.CheckBox chkSpecialChars;
        private System.Windows.Forms.Label lblPasswordStrength;
        private System.Windows.Forms.NumericUpDown nudPasswordLength;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnClear;
    }
}

