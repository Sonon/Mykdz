namespace KDZ_3module
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сортировкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поИмениToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поБлижайшейСтанцииМетроToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фильтроватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поИмениToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.поБлижайшейСтанцииМетроToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.архивToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.сортировкаToolStripMenuItem,
            this.фильтроватьToolStripMenuItem,
            this.архивToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(399, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.сохранитьКакToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("открытьToolStripMenuItem.Image")));
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("сохранитьToolStripMenuItem.Image")));
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            // 
            // сохранитьКакToolStripMenuItem
            // 
            this.сохранитьКакToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("сохранитьКакToolStripMenuItem.Image")));
            this.сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            this.сохранитьКакToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.сохранитьКакToolStripMenuItem.Text = "Сохранить как...";
            // 
            // сортировкаToolStripMenuItem
            // 
            this.сортировкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поИмениToolStripMenuItem,
            this.поБлижайшейСтанцииМетроToolStripMenuItem});
            this.сортировкаToolStripMenuItem.Name = "сортировкаToolStripMenuItem";
            this.сортировкаToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.сортировкаToolStripMenuItem.Text = "Сортировка";
            // 
            // поИмениToolStripMenuItem
            // 
            this.поИмениToolStripMenuItem.Name = "поИмениToolStripMenuItem";
            this.поИмениToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.поИмениToolStripMenuItem.Text = "По имени";
            // 
            // поБлижайшейСтанцииМетроToolStripMenuItem
            // 
            this.поБлижайшейСтанцииМетроToolStripMenuItem.Name = "поБлижайшейСтанцииМетроToolStripMenuItem";
            this.поБлижайшейСтанцииМетроToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.поБлижайшейСтанцииМетроToolStripMenuItem.Text = "По ближайшей станции метро";
            // 
            // фильтроватьToolStripMenuItem
            // 
            this.фильтроватьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поИмениToolStripMenuItem1,
            this.поБлижайшейСтанцииМетроToolStripMenuItem1});
            this.фильтроватьToolStripMenuItem.Name = "фильтроватьToolStripMenuItem";
            this.фильтроватьToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.фильтроватьToolStripMenuItem.Text = "Фильтровать";
            // 
            // поИмениToolStripMenuItem1
            // 
            this.поИмениToolStripMenuItem1.Name = "поИмениToolStripMenuItem1";
            this.поИмениToolStripMenuItem1.Size = new System.Drawing.Size(245, 22);
            this.поИмениToolStripMenuItem1.Text = "По имени";
            // 
            // поБлижайшейСтанцииМетроToolStripMenuItem1
            // 
            this.поБлижайшейСтанцииМетроToolStripMenuItem1.Name = "поБлижайшейСтанцииМетроToolStripMenuItem1";
            this.поБлижайшейСтанцииМетроToolStripMenuItem1.Size = new System.Drawing.Size(245, 22);
            this.поБлижайшейСтанцииМетроToolStripMenuItem1.Text = "По ближайшей станции метро";
            // 
            // архивToolStripMenuItem
            // 
            this.архивToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1});
            this.архивToolStripMenuItem.Name = "архивToolStripMenuItem";
            this.архивToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.архивToolStripMenuItem.Text = "Архив";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 23);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 374);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьКакToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сортировкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поИмениToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поБлижайшейСтанцииМетроToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фильтроватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поИмениToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem поБлижайшейСтанцииМетроToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem архивToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
    }
}

