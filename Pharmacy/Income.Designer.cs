
namespace Pharmacy
{
    partial class Income
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
            this.searchbox = new System.Windows.Forms.TextBox();
            this.search_button = new System.Windows.Forms.Button();
            this.med_listbox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.amount_textbox = new System.Windows.Forms.TextBox();
            this.add_button = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.title_textbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.price_textbox = new System.Windows.Forms.TextBox();
            this.prescription_checkbox = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.quantity_textbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.provider_combobox = new System.Windows.Forms.ComboBox();
            this.newmed_button = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // back_button
            // 
            this.back_button.Location = new System.Drawing.Point(13, 13);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(75, 23);
            this.back_button.TabIndex = 0;
            this.back_button.Text = "Назад";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.add_button);
            this.groupBox1.Controls.Add(this.amount_textbox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.med_listbox);
            this.groupBox1.Controls.Add(this.search_button);
            this.groupBox1.Controls.Add(this.searchbox);
            this.groupBox1.Location = new System.Drawing.Point(13, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(396, 395);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Медикаменты";
            // 
            // searchbox
            // 
            this.searchbox.Location = new System.Drawing.Point(7, 22);
            this.searchbox.Name = "searchbox";
            this.searchbox.Size = new System.Drawing.Size(302, 22);
            this.searchbox.TabIndex = 0;
            this.searchbox.TextChanged += new System.EventHandler(this.searchbox_TextChanged);
            // 
            // search_button
            // 
            this.search_button.Location = new System.Drawing.Point(315, 22);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(75, 23);
            this.search_button.TabIndex = 1;
            this.search_button.Text = "Поиск";
            this.search_button.UseVisualStyleBackColor = true;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // med_listbox
            // 
            this.med_listbox.FormattingEnabled = true;
            this.med_listbox.ItemHeight = 16;
            this.med_listbox.Location = new System.Drawing.Point(7, 51);
            this.med_listbox.Name = "med_listbox";
            this.med_listbox.Size = new System.Drawing.Size(383, 260);
            this.med_listbox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 318);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Добавить:";
            // 
            // amount_textbox
            // 
            this.amount_textbox.Location = new System.Drawing.Point(90, 318);
            this.amount_textbox.Name = "amount_textbox";
            this.amount_textbox.Size = new System.Drawing.Size(300, 22);
            this.amount_textbox.TabIndex = 4;
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(10, 346);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(380, 43);
            this.add_button.TabIndex = 5;
            this.add_button.Text = "Добавить";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.newmed_button);
            this.groupBox2.Controls.Add(this.provider_combobox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.quantity_textbox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.prescription_checkbox);
            this.groupBox2.Controls.Add(this.price_textbox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.title_textbox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(416, 43);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(372, 389);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Новый медикамент";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Название:";
            // 
            // title_textbox
            // 
            this.title_textbox.Location = new System.Drawing.Point(90, 22);
            this.title_textbox.Name = "title_textbox";
            this.title_textbox.Size = new System.Drawing.Size(276, 22);
            this.title_textbox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Цена:";
            // 
            // price_textbox
            // 
            this.price_textbox.Location = new System.Drawing.Point(64, 51);
            this.price_textbox.Name = "price_textbox";
            this.price_textbox.Size = new System.Drawing.Size(302, 22);
            this.price_textbox.TabIndex = 3;
            // 
            // prescription_checkbox
            // 
            this.prescription_checkbox.AutoSize = true;
            this.prescription_checkbox.Location = new System.Drawing.Point(13, 79);
            this.prescription_checkbox.Name = "prescription_checkbox";
            this.prescription_checkbox.Size = new System.Drawing.Size(123, 21);
            this.prescription_checkbox.TabIndex = 5;
            this.prescription_checkbox.Text = "Нужен рецепт";
            this.prescription_checkbox.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Количество:";
            // 
            // quantity_textbox
            // 
            this.quantity_textbox.Location = new System.Drawing.Point(107, 107);
            this.quantity_textbox.Name = "quantity_textbox";
            this.quantity_textbox.Size = new System.Drawing.Size(259, 22);
            this.quantity_textbox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Поставщик:";
            // 
            // provider_combobox
            // 
            this.provider_combobox.FormattingEnabled = true;
            this.provider_combobox.Location = new System.Drawing.Point(105, 140);
            this.provider_combobox.Name = "provider_combobox";
            this.provider_combobox.Size = new System.Drawing.Size(261, 24);
            this.provider_combobox.TabIndex = 9;
            // 
            // newmed_button
            // 
            this.newmed_button.Location = new System.Drawing.Point(6, 178);
            this.newmed_button.Name = "newmed_button";
            this.newmed_button.Size = new System.Drawing.Size(360, 205);
            this.newmed_button.TabIndex = 10;
            this.newmed_button.Text = "Добавить";
            this.newmed_button.UseVisualStyleBackColor = true;
            this.newmed_button.Click += new System.EventHandler(this.newmed_button_Click);
            // 
            // Income
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.back_button);
            this.Name = "Income";
            this.Text = "Приход";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Income_FormClosing);
            this.VisibleChanged += new System.EventHandler(this.Income_VisibleChanged);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox med_listbox;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.TextBox searchbox;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.TextBox amount_textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button newmed_button;
        private System.Windows.Forms.ComboBox provider_combobox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox quantity_textbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox prescription_checkbox;
        private System.Windows.Forms.TextBox price_textbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox title_textbox;
        private System.Windows.Forms.Label label2;
    }
}