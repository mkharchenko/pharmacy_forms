

namespace Pharmacy
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
            this.button1 = new System.Windows.Forms.Button();
            this.incoming_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(342, 188);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 90);
            this.button1.TabIndex = 0;
            this.button1.Text = "Продажа";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.sale_click);
            // 
            // incoming_button
            // 
            this.incoming_button.Location = new System.Drawing.Point(170, 188);
            this.incoming_button.Name = "incoming_button";
            this.incoming_button.Size = new System.Drawing.Size(150, 90);
            this.incoming_button.TabIndex = 1;
            this.incoming_button.Text = "Приход";
            this.incoming_button.UseVisualStyleBackColor = true;
            this.incoming_button.Click += new System.EventHandler(this.incoming_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 541);
            this.Controls.Add(this.incoming_button);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Главная форма";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button incoming_button;
    }
}

