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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.обычнаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.построчнаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.аффиныеПреобразованияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.тождественноеПреобразованиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.локальноеМаштабированиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.симметрияОтносХToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.симметрияОтносYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.симметрияОтносительноНКToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сдвигВдольОХToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сдвигВдольOYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поворотНаЗаданныйУголToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.симметрияОтносYxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.симметрияОтносYxToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.переносНаЗаданныйВекторToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.общееМаштабированиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.white;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(680, 380);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.ToolStripMenuItem4,
            this.ToolStripMenuItem7,
            this.ToolStripMenuItem8,
            this.аффиныеПреобразованияToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(706, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(55, 20);
            this.toolStripMenuItem1.Text = "Линии";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem2.Text = "DDA";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem3.Text = "Brezenheim";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // ToolStripMenuItem4
            // 
            this.ToolStripMenuItem4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem5,
            this.ToolStripMenuItem6});
            this.ToolStripMenuItem4.Name = "ToolStripMenuItem4";
            this.ToolStripMenuItem4.Size = new System.Drawing.Size(61, 20);
            this.ToolStripMenuItem4.Text = "Кривые";
            // 
            // ToolStripMenuItem5
            // 
            this.ToolStripMenuItem5.Name = "ToolStripMenuItem5";
            this.ToolStripMenuItem5.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItem5.Text = "Дуги";
            // 
            // ToolStripMenuItem6
            // 
            this.ToolStripMenuItem6.Name = "ToolStripMenuItem6";
            this.ToolStripMenuItem6.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItem6.Text = "Окружности";
            this.ToolStripMenuItem6.Click += new System.EventHandler(this.ToolStripMenuItem6_Click);
            // 
            // ToolStripMenuItem7
            // 
            this.ToolStripMenuItem7.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.обычнаяToolStripMenuItem,
            this.построчнаяToolStripMenuItem});
            this.ToolStripMenuItem7.Name = "ToolStripMenuItem7";
            this.ToolStripMenuItem7.Size = new System.Drawing.Size(64, 20);
            this.ToolStripMenuItem7.Text = "Заливка";
            // 
            // обычнаяToolStripMenuItem
            // 
            this.обычнаяToolStripMenuItem.Name = "обычнаяToolStripMenuItem";
            this.обычнаяToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.обычнаяToolStripMenuItem.Text = "Обычная";
            this.обычнаяToolStripMenuItem.Click += new System.EventHandler(this.обычнаяToolStripMenuItem_Click);
            // 
            // построчнаяToolStripMenuItem
            // 
            this.построчнаяToolStripMenuItem.Name = "построчнаяToolStripMenuItem";
            this.построчнаяToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.построчнаяToolStripMenuItem.Text = "Построчная";
            this.построчнаяToolStripMenuItem.Click += new System.EventHandler(this.построчнаяToolStripMenuItem_Click);
            // 
            // ToolStripMenuItem8
            // 
            this.ToolStripMenuItem8.Name = "ToolStripMenuItem8";
            this.ToolStripMenuItem8.Size = new System.Drawing.Size(71, 20);
            this.ToolStripMenuItem8.Text = "Очистить";
            this.ToolStripMenuItem8.Click += new System.EventHandler(this.ToolStripMenuItem8_Click);
            // 
            // аффиныеПреобразованияToolStripMenuItem
            // 
            this.аффиныеПреобразованияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.тождественноеПреобразованиеToolStripMenuItem,
            this.локальноеМаштабированиеToolStripMenuItem,
            this.симметрияОтносХToolStripMenuItem,
            this.симметрияОтносYToolStripMenuItem,
            this.симметрияОтносительноНКToolStripMenuItem,
            this.сдвигВдольОХToolStripMenuItem,
            this.сдвигВдольOYToolStripMenuItem,
            this.поворотНаЗаданныйУголToolStripMenuItem,
            this.симметрияОтносYxToolStripMenuItem,
            this.симметрияОтносYxToolStripMenuItem1,
            this.переносНаЗаданныйВекторToolStripMenuItem,
            this.общееМаштабированиеToolStripMenuItem});
            this.аффиныеПреобразованияToolStripMenuItem.Name = "аффиныеПреобразованияToolStripMenuItem";
            this.аффиныеПреобразованияToolStripMenuItem.Size = new System.Drawing.Size(168, 20);
            this.аффиныеПреобразованияToolStripMenuItem.Text = "Аффиные преобразования";
            // 
            // тождественноеПреобразованиеToolStripMenuItem
            // 
            this.тождественноеПреобразованиеToolStripMenuItem.Name = "тождественноеПреобразованиеToolStripMenuItem";
            this.тождественноеПреобразованиеToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.тождественноеПреобразованиеToolStripMenuItem.Text = "Тождественное преобразование";
            this.тождественноеПреобразованиеToolStripMenuItem.Click += new System.EventHandler(this.тождественноеПреобразованиеToolStripMenuItem_Click);
            // 
            // локальноеМаштабированиеToolStripMenuItem
            // 
            this.локальноеМаштабированиеToolStripMenuItem.Name = "локальноеМаштабированиеToolStripMenuItem";
            this.локальноеМаштабированиеToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.локальноеМаштабированиеToolStripMenuItem.Text = "Локальное маштабирование";
            this.локальноеМаштабированиеToolStripMenuItem.Click += new System.EventHandler(this.локальноеМаштабированиеToolStripMenuItem_Click);
            // 
            // симметрияОтносХToolStripMenuItem
            // 
            this.симметрияОтносХToolStripMenuItem.Name = "симметрияОтносХToolStripMenuItem";
            this.симметрияОтносХToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.симметрияОтносХToolStripMenuItem.Text = "Симметрия относ. Х";
            this.симметрияОтносХToolStripMenuItem.Click += new System.EventHandler(this.симметрияОтносХToolStripMenuItem_Click);
            // 
            // симметрияОтносYToolStripMenuItem
            // 
            this.симметрияОтносYToolStripMenuItem.Name = "симметрияОтносYToolStripMenuItem";
            this.симметрияОтносYToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.симметрияОтносYToolStripMenuItem.Text = "Симметрия относ. Y";
            this.симметрияОтносYToolStripMenuItem.Click += new System.EventHandler(this.симметрияОтносYToolStripMenuItem_Click);
            // 
            // симметрияОтносительноНКToolStripMenuItem
            // 
            this.симметрияОтносительноНКToolStripMenuItem.Name = "симметрияОтносительноНКToolStripMenuItem";
            this.симметрияОтносительноНКToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.симметрияОтносительноНКToolStripMenuItem.Text = "Симметрия относительно НК";
            this.симметрияОтносительноНКToolStripMenuItem.Click += new System.EventHandler(this.симметрияОтносительноНКToolStripMenuItem_Click);
            // 
            // сдвигВдольОХToolStripMenuItem
            // 
            this.сдвигВдольОХToolStripMenuItem.Name = "сдвигВдольОХToolStripMenuItem";
            this.сдвигВдольОХToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.сдвигВдольОХToolStripMenuItem.Text = "Сдвиг вдоль ОХ";
            this.сдвигВдольОХToolStripMenuItem.Click += new System.EventHandler(this.сдвигВдольОХToolStripMenuItem_Click);
            // 
            // сдвигВдольOYToolStripMenuItem
            // 
            this.сдвигВдольOYToolStripMenuItem.Name = "сдвигВдольOYToolStripMenuItem";
            this.сдвигВдольOYToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.сдвигВдольOYToolStripMenuItem.Text = "Сдвиг вдоль OY";
            this.сдвигВдольOYToolStripMenuItem.Click += new System.EventHandler(this.сдвигВдольOYToolStripMenuItem_Click);
            // 
            // поворотНаЗаданныйУголToolStripMenuItem
            // 
            this.поворотНаЗаданныйУголToolStripMenuItem.Name = "поворотНаЗаданныйУголToolStripMenuItem";
            this.поворотНаЗаданныйУголToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.поворотНаЗаданныйУголToolStripMenuItem.Text = "Поворот на заданный угол";
            this.поворотНаЗаданныйУголToolStripMenuItem.Click += new System.EventHandler(this.поворотНаЗаданныйУголToolStripMenuItem_Click);
            // 
            // симметрияОтносYxToolStripMenuItem
            // 
            this.симметрияОтносYxToolStripMenuItem.Name = "симметрияОтносYxToolStripMenuItem";
            this.симметрияОтносYxToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.симметрияОтносYxToolStripMenuItem.Text = "Симметрия относ. y=x";
            this.симметрияОтносYxToolStripMenuItem.Click += new System.EventHandler(this.симметрияОтносYxToolStripMenuItem_Click);
            // 
            // симметрияОтносYxToolStripMenuItem1
            // 
            this.симметрияОтносYxToolStripMenuItem1.Name = "симметрияОтносYxToolStripMenuItem1";
            this.симметрияОтносYxToolStripMenuItem1.Size = new System.Drawing.Size(253, 22);
            this.симметрияОтносYxToolStripMenuItem1.Text = "Симметрия относ. y=-x";
            this.симметрияОтносYxToolStripMenuItem1.Click += new System.EventHandler(this.симметрияОтносYxToolStripMenuItem1_Click);
            // 
            // переносНаЗаданныйВекторToolStripMenuItem
            // 
            this.переносНаЗаданныйВекторToolStripMenuItem.Name = "переносНаЗаданныйВекторToolStripMenuItem";
            this.переносНаЗаданныйВекторToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.переносНаЗаданныйВекторToolStripMenuItem.Text = "Перенос на заданный вектор";
            this.переносНаЗаданныйВекторToolStripMenuItem.Click += new System.EventHandler(this.переносНаЗаданныйВекторToolStripMenuItem_Click);
            // 
            // общееМаштабированиеToolStripMenuItem
            // 
            this.общееМаштабированиеToolStripMenuItem.Name = "общееМаштабированиеToolStripMenuItem";
            this.общееМаштабированиеToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.общееМаштабированиеToolStripMenuItem.Text = "Общее маштабирование";
            this.общееМаштабированиеToolStripMenuItem.Click += new System.EventHandler(this.общееМаштабированиеToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.white;
            this.ClientSize = new System.Drawing.Size(706, 423);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem обычнаяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem построчнаяToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem аффиныеПреобразованияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem тождественноеПреобразованиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem локальноеМаштабированиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem симметрияОтносХToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem симметрияОтносYToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem симметрияОтносительноНКToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сдвигВдольОХToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сдвигВдольOYToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поворотНаЗаданныйУголToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem симметрияОтносYxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem симметрияОтносYxToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem переносНаЗаданныйВекторToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem общееМаштабированиеToolStripMenuItem;
    }
}

