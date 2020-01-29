namespace DgvTf
{
    partial class FormMain
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonSohr = new System.Windows.Forms.Button();
            this.buttonZagr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSohr
            // 
            this.buttonSohr.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSohr.Location = new System.Drawing.Point(14, 14);
            this.buttonSohr.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.buttonSohr.Name = "buttonSohr";
            this.buttonSohr.Size = new System.Drawing.Size(110, 35);
            this.buttonSohr.TabIndex = 2;
            this.buttonSohr.Text = "Сохранить";
            this.buttonSohr.UseVisualStyleBackColor = true;
            this.buttonSohr.Click += new System.EventHandler(this.buttonSohr_Click);
            // 
            // buttonZagr
            // 
            this.buttonZagr.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonZagr.Location = new System.Drawing.Point(134, 14);
            this.buttonZagr.Margin = new System.Windows.Forms.Padding(5);
            this.buttonZagr.Name = "buttonZagr";
            this.buttonZagr.Size = new System.Drawing.Size(110, 35);
            this.buttonZagr.TabIndex = 3;
            this.buttonZagr.Text = "Загрзуить";
            this.buttonZagr.UseVisualStyleBackColor = true;
            this.buttonZagr.Click += new System.EventHandler(this.buttonZagr_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(259, 63);
            this.Controls.Add(this.buttonZagr);
            this.Controls.Add(this.buttonSohr);
            this.Font = new System.Drawing.Font("Isabella-Decor", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "FormMain";
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSohr;
        private System.Windows.Forms.Button buttonZagr;
    }
}

