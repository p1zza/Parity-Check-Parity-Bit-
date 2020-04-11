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
            this.SendlerText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Result = new System.Windows.Forms.Label();
            this.GetResult = new System.Windows.Forms.Button();
            this.ReceiverText = new System.Windows.Forms.TextBox();
            this.CheckMessage = new System.Windows.Forms.Button();
            this.IsOK = new System.Windows.Forms.Label();
            this.ControlSumSendlerText = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // SendlerText
            // 
            this.SendlerText.Location = new System.Drawing.Point(28, 65);
            this.SendlerText.Name = "SendlerText";
            this.SendlerText.Size = new System.Drawing.Size(100, 20);
            this.SendlerText.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите текст";
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Location = new System.Drawing.Point(70, 150);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(0, 13);
            this.Result.TabIndex = 2;
            // 
            // GetResult
            // 
            this.GetResult.Location = new System.Drawing.Point(161, 65);
            this.GetResult.Name = "GetResult";
            this.GetResult.Size = new System.Drawing.Size(75, 23);
            this.GetResult.TabIndex = 3;
            this.GetResult.Text = "Отправить";
            this.GetResult.UseVisualStyleBackColor = true;
            this.GetResult.Click += new System.EventHandler(this.GetResult_Click);
            // 
            // ReceiverText
            // 
            this.ReceiverText.Location = new System.Drawing.Point(28, 147);
            this.ReceiverText.Name = "ReceiverText";
            this.ReceiverText.Size = new System.Drawing.Size(100, 20);
            this.ReceiverText.TabIndex = 4;
            // 
            // CheckMessage
            // 
            this.CheckMessage.Location = new System.Drawing.Point(161, 145);
            this.CheckMessage.Name = "CheckMessage";
            this.CheckMessage.Size = new System.Drawing.Size(75, 23);
            this.CheckMessage.TabIndex = 6;
            this.CheckMessage.Text = "Проверить";
            this.CheckMessage.UseVisualStyleBackColor = true;
            this.CheckMessage.Click += new System.EventHandler(this.CheckMessage_Click);
            // 
            // IsOK
            // 
            this.IsOK.AutoSize = true;
            this.IsOK.Location = new System.Drawing.Point(25, 185);
            this.IsOK.Name = "IsOK";
            this.IsOK.Size = new System.Drawing.Size(0, 13);
            this.IsOK.TabIndex = 7;
            // 
            // ControlSumSendlerText
            // 
            this.ControlSumSendlerText.Location = new System.Drawing.Point(28, 91);
            this.ControlSumSendlerText.Name = "ControlSumSendlerText";
            this.ControlSumSendlerText.Size = new System.Drawing.Size(100, 30);
            this.ControlSumSendlerText.TabIndex = 8;
            this.ControlSumSendlerText.Text = "Хэш";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 315);
            this.Controls.Add(this.ControlSumSendlerText);
            this.Controls.Add(this.IsOK);
            this.Controls.Add(this.CheckMessage);
            this.Controls.Add(this.ReceiverText);
            this.Controls.Add(this.GetResult);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SendlerText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SendlerText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.Button GetResult;
        private System.Windows.Forms.TextBox ReceiverText;
        private System.Windows.Forms.Button CheckMessage;
        private System.Windows.Forms.Label IsOK;
        private System.Windows.Forms.RichTextBox ControlSumSendlerText;
    }
}

