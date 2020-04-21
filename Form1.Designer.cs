namespace Krypt_8
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
            this.Sendler = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Result = new System.Windows.Forms.Label();
            this.GetResult = new System.Windows.Forms.Button();
            this.Receiver = new System.Windows.Forms.TextBox();
            this.ControlSum = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // Sendler
            // 
            this.Sendler.Location = new System.Drawing.Point(28, 36);
            this.Sendler.Name = "Sendler";
            this.Sendler.Size = new System.Drawing.Size(168, 20);
            this.Sendler.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите текст";
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Location = new System.Drawing.Point(27, 150);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(110, 13);
            this.Result.TabIndex = 2;
            this.Result.Text = "Результат проверки";
            // 
            // GetResult
            // 
            this.GetResult.Location = new System.Drawing.Point(30, 62);
            this.GetResult.Name = "GetResult";
            this.GetResult.Size = new System.Drawing.Size(166, 23);
            this.GetResult.TabIndex = 3;
            this.GetResult.Text = "Отправить";
            this.GetResult.UseVisualStyleBackColor = true;
            this.GetResult.Click += new System.EventHandler(this.GetResult_Click);
            // 
            // Receiver
            // 
            this.Receiver.Location = new System.Drawing.Point(28, 127);
            this.Receiver.Name = "Receiver";
            this.Receiver.Size = new System.Drawing.Size(168, 20);
            this.Receiver.TabIndex = 4;
            // 
            // ControlSum
            // 
            this.ControlSum.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.ControlSum.Enabled = false;
            this.ControlSum.Location = new System.Drawing.Point(28, 91);
            this.ControlSum.Name = "ControlSum";
            this.ControlSum.Size = new System.Drawing.Size(168, 30);
            this.ControlSum.TabIndex = 8;
            this.ControlSum.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 178);
            this.Controls.Add(this.ControlSum);
            this.Controls.Add(this.Receiver);
            this.Controls.Add(this.GetResult);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Sendler);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "EAN-13";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Sendler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.Button GetResult;
        private System.Windows.Forms.TextBox Receiver;
        private System.Windows.Forms.RichTextBox ControlSum;
    }
}

