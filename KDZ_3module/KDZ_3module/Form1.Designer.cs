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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.инструментыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.перевернутьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сортировкаToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.поИмениToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.поБлижайшейСтанцииМетроToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.фильтрToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.сохранитьРезультатФильтрацииВАрхивToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отменитьРезультатФильтрацииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.архивToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.инструментыToolStripMenuItem,
            this.архивToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.toolStripSeparator1,
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
            this.сохранитьToolStripMenuItem.Enabled = false;
            this.сохранитьToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("сохранитьToolStripMenuItem.Image")));
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            // 
            // сохранитьКакToolStripMenuItem
            // 
            this.сохранитьКакToolStripMenuItem.Enabled = false;
            this.сохранитьКакToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("сохранитьКакToolStripMenuItem.Image")));
            this.сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            this.сохранитьКакToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.сохранитьКакToolStripMenuItem.Text = "Сохранить как...";
            // 
            // инструментыToolStripMenuItem
            // 
            this.инструментыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.перевернутьToolStripMenuItem,
            this.сортировкаToolStripMenuItem1,
            this.фильтрToolStripMenuItem});
            this.инструментыToolStripMenuItem.Enabled = false;
            this.инструментыToolStripMenuItem.Name = "инструментыToolStripMenuItem";
            this.инструментыToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.инструментыToolStripMenuItem.Text = "Инструменты";
            // 
            // перевернутьToolStripMenuItem
            // 
            this.перевернутьToolStripMenuItem.Name = "перевернутьToolStripMenuItem";
            this.перевернутьToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.перевернутьToolStripMenuItem.Text = "Перевернуть";
            this.перевернутьToolStripMenuItem.Click += new System.EventHandler(this.перевернутьToolStripMenuItem_Click);
            // 
            // сортировкаToolStripMenuItem1
            // 
            this.сортировкаToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поИмениToolStripMenuItem2,
            this.поБлижайшейСтанцииМетроToolStripMenuItem2});
            this.сортировкаToolStripMenuItem1.Name = "сортировкаToolStripMenuItem1";
            this.сортировкаToolStripMenuItem1.Size = new System.Drawing.Size(145, 22);
            this.сортировкаToolStripMenuItem1.Text = "Сортировка";
            // 
            // поИмениToolStripMenuItem2
            // 
            this.поИмениToolStripMenuItem2.Name = "поИмениToolStripMenuItem2";
            this.поИмениToolStripMenuItem2.Size = new System.Drawing.Size(245, 22);
            this.поИмениToolStripMenuItem2.Text = "По имени";
            this.поИмениToolStripMenuItem2.Click += new System.EventHandler(this.поИмениToolStripMenuItem2_Click);
            // 
            // поБлижайшейСтанцииМетроToolStripMenuItem2
            // 
            this.поБлижайшейСтанцииМетроToolStripMenuItem2.Name = "поБлижайшейСтанцииМетроToolStripMenuItem2";
            this.поБлижайшейСтанцииМетроToolStripMenuItem2.Size = new System.Drawing.Size(245, 22);
            this.поБлижайшейСтанцииМетроToolStripMenuItem2.Text = "По ближайшей станции метро";
            this.поБлижайшейСтанцииМетроToolStripMenuItem2.Click += new System.EventHandler(this.поБлижайшейСтанцииМетроToolStripMenuItem2_Click);
            // 
            // фильтрToolStripMenuItem
            // 
            this.фильтрToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1,
            this.сохранитьРезультатФильтрацииВАрхивToolStripMenuItem,
            this.отменитьРезультатФильтрацииToolStripMenuItem});
            this.фильтрToolStripMenuItem.Name = "фильтрToolStripMenuItem";
            this.фильтрToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.фильтрToolStripMenuItem.Text = "Фильтр";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.ForeColor = System.Drawing.Color.Silver;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(230, 23);
            this.toolStripTextBox1.Text = "Введите ключ фильтра...";
            this.toolStripTextBox1.Click += new System.EventHandler(this.toolStripTextBox1_Click);
            this.toolStripTextBox1.TextChanged += new System.EventHandler(this.toolStripTextBox1_TextChanged);
            // 
            // сохранитьРезультатФильтрацииВАрхивToolStripMenuItem
            // 
            this.сохранитьРезультатФильтрацииВАрхивToolStripMenuItem.Name = "сохранитьРезультатФильтрацииВАрхивToolStripMenuItem";
            this.сохранитьРезультатФильтрацииВАрхивToolStripMenuItem.Size = new System.Drawing.Size(302, 22);
            this.сохранитьРезультатФильтрацииВАрхивToolStripMenuItem.Text = "Сохранить результат фильтрации в архив";
            this.сохранитьРезультатФильтрацииВАрхивToolStripMenuItem.Click += new System.EventHandler(this.сохранитьРезультатФильтрацииВАрхивToolStripMenuItem_Click);
            // 
            // отменитьРезультатФильтрацииToolStripMenuItem
            // 
            this.отменитьРезультатФильтрацииToolStripMenuItem.Name = "отменитьРезультатФильтрацииToolStripMenuItem";
            this.отменитьРезультатФильтрацииToolStripMenuItem.Size = new System.Drawing.Size(302, 22);
            this.отменитьРезультатФильтрацииToolStripMenuItem.Text = "Отменить результат фильтрации";
            this.отменитьРезультатФильтрацииToolStripMenuItem.Click += new System.EventHandler(this.отменитьРезультатФильтрацииToolStripMenuItem_Click);
            // 
            // архивToolStripMenuItem
            // 
            this.архивToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1});
            this.архивToolStripMenuItem.Enabled = false;
            this.архивToolStripMenuItem.Name = "архивToolStripMenuItem";
            this.архивToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.архивToolStripMenuItem.Text = "Архив";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(300, 23);
            this.toolStripComboBox1.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox1_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(984, 857);
            this.dataGridView1.TabIndex = 1;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(159, 6);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 882);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьКакToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem архивToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ToolStripMenuItem инструментыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem перевернутьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сортировкаToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem поИмениToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem поБлижайшейСтанцииМетроToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem фильтрToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripMenuItem сохранитьРезультатФильтрацииВАрхивToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отменитьРезультатФильтрацииToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}

