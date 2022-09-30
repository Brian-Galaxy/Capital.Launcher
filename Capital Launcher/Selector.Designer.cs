namespace Capital_Launcher
{
    partial class Selector
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Selector));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bankBtn = new System.Windows.Forms.Button();
            this.bankStart = new System.Windows.Forms.Button();
            this.verLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("GOST type A", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Банк:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("GOST type A", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(71, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Не установлен";
            // 
            // bankBtn
            // 
            this.bankBtn.Font = new System.Drawing.Font("GOST type A", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bankBtn.Location = new System.Drawing.Point(185, 9);
            this.bankBtn.Name = "bankBtn";
            this.bankBtn.Size = new System.Drawing.Size(75, 23);
            this.bankBtn.TabIndex = 2;
            this.bankBtn.Text = "Установить";
            this.bankBtn.UseVisualStyleBackColor = true;
            this.bankBtn.Visible = false;
            this.bankBtn.Click += new System.EventHandler(this.bankBtn_Click);
            // 
            // bankStart
            // 
            this.bankStart.Font = new System.Drawing.Font("GOST type A", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bankStart.Location = new System.Drawing.Point(266, 10);
            this.bankStart.Name = "bankStart";
            this.bankStart.Size = new System.Drawing.Size(75, 23);
            this.bankStart.TabIndex = 3;
            this.bankStart.Text = "Запуск";
            this.bankStart.UseVisualStyleBackColor = true;
            this.bankStart.Visible = false;
            this.bankStart.Click += new System.EventHandler(this.bankStart_Click);
            // 
            // verLbl
            // 
            this.verLbl.AutoSize = true;
            this.verLbl.Font = new System.Drawing.Font("GOST type A", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.verLbl.Location = new System.Drawing.Point(331, 459);
            this.verLbl.Name = "verLbl";
            this.verLbl.Size = new System.Drawing.Size(55, 20);
            this.verLbl.TabIndex = 4;
            this.verLbl.Text = "Версия:";
            // 
            // Selector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 488);
            this.Controls.Add(this.verLbl);
            this.Controls.Add(this.bankStart);
            this.Controls.Add(this.bankBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(473, 527);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(473, 527);
            this.Name = "Selector";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Capital Selector";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bankBtn;
        private System.Windows.Forms.Button bankStart;
        private System.Windows.Forms.Label verLbl;
    }
}

