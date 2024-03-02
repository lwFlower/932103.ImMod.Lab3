namespace Lab3
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btResult = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.masked = new System.Windows.Forms.MaskedTextBox();
            this.btClear = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btClear);
            this.panel1.Controls.Add(this.btResult);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.masked);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(705, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 503);
            this.panel1.TabIndex = 0;
            // 
            // btResult
            // 
            this.btResult.Location = new System.Drawing.Point(17, 69);
            this.btResult.Name = "btResult";
            this.btResult.Size = new System.Drawing.Size(121, 36);
            this.btResult.TabIndex = 2;
            this.btResult.Text = "Результат";
            this.btResult.UseVisualStyleBackColor = true;
            this.btResult.Click += new System.EventHandler(this.btResult_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Номер правила";
            // 
            // masked
            // 
            this.masked.Location = new System.Drawing.Point(23, 28);
            this.masked.Mask = "000";
            this.masked.Name = "masked";
            this.masked.ResetOnSpace = false;
            this.masked.Size = new System.Drawing.Size(106, 22);
            this.masked.TabIndex = 0;
            this.masked.TextChanged += new System.EventHandler(this.masked_TextChanged);
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(17, 133);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(121, 36);
            this.btClear.TabIndex = 3;
            this.btClear.Text = "Очистить";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 503);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox masked;
        private System.Windows.Forms.Button btResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Timer timer1;
    }
}

