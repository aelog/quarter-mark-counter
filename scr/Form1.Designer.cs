namespace Quarter_Mark_Counter_GUI.NET_
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.count_button = new System.Windows.Forms.Button();
            this.welcome_message = new System.Windows.Forms.Label();
            this.mark_label = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.Reset_button = new System.Windows.Forms.Button();
            this.watch_button = new System.Windows.Forms.Button();
            this.about_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // count_button
            // 
            this.count_button.Location = new System.Drawing.Point(12, 77);
            this.count_button.Name = "count_button";
            this.count_button.Size = new System.Drawing.Size(88, 23);
            this.count_button.TabIndex = 0;
            this.count_button.Text = "Высчитать";
            this.count_button.UseVisualStyleBackColor = true;
            this.count_button.Click += new System.EventHandler(this.count_button_Click);
            // 
            // welcome_message
            // 
            this.welcome_message.AutoSize = true;
            this.welcome_message.Location = new System.Drawing.Point(9, 9);
            this.welcome_message.Name = "welcome_message";
            this.welcome_message.Size = new System.Drawing.Size(178, 13);
            this.welcome_message.TabIndex = 4;
            this.welcome_message.Text = "  Welcome to Quarter Mark Counter!";
            this.welcome_message.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.welcome_message.Click += new System.EventHandler(this.label5_Click);
            // 
            // mark_label
            // 
            this.mark_label.AutoSize = true;
            this.mark_label.Location = new System.Drawing.Point(12, 28);
            this.mark_label.Name = "mark_label";
            this.mark_label.Size = new System.Drawing.Size(51, 13);
            this.mark_label.TabIndex = 6;
            this.mark_label.Text = "Оценка: ";
            this.mark_label.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Коэффициент: ";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 131);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(185, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Смотреть коэффициенты";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(95, 49);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(105, 20);
            this.textBox3.TabIndex = 9;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(59, 26);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(141, 20);
            this.numericUpDown1.TabIndex = 10;
            this.numericUpDown1.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.numericUpDown1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // Reset_button
            // 
            this.Reset_button.Location = new System.Drawing.Point(113, 77);
            this.Reset_button.Name = "Reset_button";
            this.Reset_button.Size = new System.Drawing.Size(87, 23);
            this.Reset_button.TabIndex = 11;
            this.Reset_button.Text = "Сбросить";
            this.Reset_button.UseVisualStyleBackColor = true;
            this.Reset_button.Click += new System.EventHandler(this.Reset_button_Click);
            // 
            // watch_button
            // 
            this.watch_button.Location = new System.Drawing.Point(12, 102);
            this.watch_button.Name = "watch_button";
            this.watch_button.Size = new System.Drawing.Size(88, 23);
            this.watch_button.TabIndex = 12;
            this.watch_button.Text = "Просмотреть";
            this.watch_button.UseVisualStyleBackColor = true;
            this.watch_button.Click += new System.EventHandler(this.watch_button_Click);
            // 
            // about_button
            // 
            this.about_button.Location = new System.Drawing.Point(113, 102);
            this.about_button.Name = "about_button";
            this.about_button.Size = new System.Drawing.Size(87, 23);
            this.about_button.TabIndex = 13;
            this.about_button.Text = "О программе";
            this.about_button.UseVisualStyleBackColor = true;
            this.about_button.Click += new System.EventHandler(this.about_button_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(207, 166);
            this.Controls.Add(this.about_button);
            this.Controls.Add(this.watch_button);
            this.Controls.Add(this.Reset_button);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mark_label);
            this.Controls.Add(this.welcome_message);
            this.Controls.Add(this.count_button);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(223, 225);
            this.MinimumSize = new System.Drawing.Size(223, 205);
            this.Name = "Form1";
            this.Text = "Quarter Mark Counter";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button count_button;
        private System.Windows.Forms.Label welcome_message;
        private System.Windows.Forms.Label mark_label;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button Reset_button;
        private System.Windows.Forms.Button watch_button;
        private System.Windows.Forms.Button about_button;
    }
}

