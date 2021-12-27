
namespace Pharmacy
{
    partial class sale
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
            this.back_button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.discount_textbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.add_button = new System.Windows.Forms.Button();
            this.prescription_box = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.quantity_box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.med_listbox = new System.Windows.Forms.ListBox();
            this.medsearch_button = new System.Windows.Forms.Button();
            this.medsearch_box = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.remove_button = new System.Windows.Forms.Button();
            this.sales_listbox = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SumLabel = new System.Windows.Forms.Label();
            this.confirm_button = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.pharmacists_combobox = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // back_button
            // 
            this.back_button.Location = new System.Drawing.Point(12, 12);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(75, 23);
            this.back_button.TabIndex = 0;
            this.back_button.Text = "Назад";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.discount_textbox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.add_button);
            this.groupBox1.Controls.Add(this.prescription_box);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.quantity_box);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.med_listbox);
            this.groupBox1.Controls.Add(this.medsearch_button);
            this.groupBox1.Controls.Add(this.medsearch_box);
            this.groupBox1.Location = new System.Drawing.Point(12, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(392, 358);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Медикаменты";
            // 
            // discount_textbox
            // 
            this.discount_textbox.Location = new System.Drawing.Point(95, 270);
            this.discount_textbox.Name = "discount_textbox";
            this.discount_textbox.Size = new System.Drawing.Size(291, 22);
            this.discount_textbox.TabIndex = 10;
            this.discount_textbox.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 270);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "Скидка(%):";
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(6, 297);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(380, 55);
            this.add_button.TabIndex = 8;
            this.add_button.Text = "Добавить товар";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // prescription_box
            // 
            this.prescription_box.Enabled = false;
            this.prescription_box.Location = new System.Drawing.Point(121, 241);
            this.prescription_box.Name = "prescription_box";
            this.prescription_box.Size = new System.Drawing.Size(265, 22);
            this.prescription_box.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Номер рецепта:";
            // 
            // quantity_box
            // 
            this.quantity_box.Location = new System.Drawing.Point(102, 213);
            this.quantity_box.Name = "quantity_box";
            this.quantity_box.Size = new System.Drawing.Size(284, 22);
            this.quantity_box.TabIndex = 5;
            this.quantity_box.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Количество:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Медикамент:";
            // 
            // med_listbox
            // 
            this.med_listbox.FormattingEnabled = true;
            this.med_listbox.ItemHeight = 16;
            this.med_listbox.Location = new System.Drawing.Point(6, 71);
            this.med_listbox.Name = "med_listbox";
            this.med_listbox.Size = new System.Drawing.Size(380, 132);
            this.med_listbox.TabIndex = 2;
            this.med_listbox.SelectedIndexChanged += new System.EventHandler(this.med_listbox_SelectedIndexChanged);
            // 
            // medsearch_button
            // 
            this.medsearch_button.Location = new System.Drawing.Point(311, 42);
            this.medsearch_button.Name = "medsearch_button";
            this.medsearch_button.Size = new System.Drawing.Size(75, 23);
            this.medsearch_button.TabIndex = 1;
            this.medsearch_button.Text = "Поиск";
            this.medsearch_button.UseVisualStyleBackColor = true;
            this.medsearch_button.Click += new System.EventHandler(this.medsearch_button_Click);
            // 
            // medsearch_box
            // 
            this.medsearch_box.Location = new System.Drawing.Point(6, 43);
            this.medsearch_box.Name = "medsearch_box";
            this.medsearch_box.Size = new System.Drawing.Size(299, 22);
            this.medsearch_box.TabIndex = 0;
            this.medsearch_box.TextChanged += new System.EventHandler(this.medsearch_box_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.remove_button);
            this.groupBox2.Controls.Add(this.sales_listbox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(410, 42);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(356, 357);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Общий счет";
            // 
            // remove_button
            // 
            this.remove_button.Location = new System.Drawing.Point(6, 296);
            this.remove_button.Name = "remove_button";
            this.remove_button.Size = new System.Drawing.Size(344, 55);
            this.remove_button.TabIndex = 2;
            this.remove_button.Text = "Удалить";
            this.remove_button.UseVisualStyleBackColor = true;
            this.remove_button.Click += new System.EventHandler(this.remove_button_Click);
            // 
            // sales_listbox
            // 
            this.sales_listbox.FormattingEnabled = true;
            this.sales_listbox.ItemHeight = 16;
            this.sales_listbox.Location = new System.Drawing.Point(6, 43);
            this.sales_listbox.Name = "sales_listbox";
            this.sales_listbox.Size = new System.Drawing.Size(344, 244);
            this.sales_listbox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Позиции:";
            // 
            // SumLabel
            // 
            this.SumLabel.AutoSize = true;
            this.SumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SumLabel.ForeColor = System.Drawing.Color.SeaGreen;
            this.SumLabel.Location = new System.Drawing.Point(5, 425);
            this.SumLabel.Name = "SumLabel";
            this.SumLabel.Size = new System.Drawing.Size(149, 38);
            this.SumLabel.TabIndex = 3;
            this.SumLabel.Text = "Итого: 0";
            // 
            // confirm_button
            // 
            this.confirm_button.Location = new System.Drawing.Point(529, 435);
            this.confirm_button.Name = "confirm_button";
            this.confirm_button.Size = new System.Drawing.Size(237, 54);
            this.confirm_button.TabIndex = 4;
            this.confirm_button.Text = "Оплачено";
            this.confirm_button.UseVisualStyleBackColor = true;
            this.confirm_button.Click += new System.EventHandler(this.confirm_button_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(529, 405);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Фармацевт:";
            // 
            // pharmacists_combobox
            // 
            this.pharmacists_combobox.FormattingEnabled = true;
            this.pharmacists_combobox.Location = new System.Drawing.Point(624, 405);
            this.pharmacists_combobox.Name = "pharmacists_combobox";
            this.pharmacists_combobox.Size = new System.Drawing.Size(142, 24);
            this.pharmacists_combobox.TabIndex = 6;
            // 
            // sale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 501);
            this.Controls.Add(this.pharmacists_combobox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.confirm_button);
            this.Controls.Add(this.SumLabel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.back_button);
            this.Name = "sale";
            this.Text = "Продажа медикаментов";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.sale_FormClosing);
            this.VisibleChanged += new System.EventHandler(this.sale_VisibleChanged);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox med_listbox;
        private System.Windows.Forms.Button medsearch_button;
        private System.Windows.Forms.TextBox medsearch_box;
        private System.Windows.Forms.TextBox prescription_box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox quantity_box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button remove_button;
        private System.Windows.Forms.ListBox sales_listbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button confirm_button;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox pharmacists_combobox;
        private System.Windows.Forms.TextBox discount_textbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label SumLabel;
    }
}