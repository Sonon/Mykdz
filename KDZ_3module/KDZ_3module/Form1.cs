using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lib;
using System.IO;

namespace KDZ_3module
{
    public partial class Form1 : Form
    {
        DataBase activeDataBase = DataBase.Instance;
        public Form1()
        {
            InitializeComponent();
        }

        private void ъToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.Filter = "Файлы таблиц (*.csv)|*.csv";
            openfile.ShowDialog();
            //try
            //{
            //    StreamReader reader = new StreamReader(openfile.OpenFile());
            //    activeDataBase.GetNewDataBaseFromString(reader.ReadToEnd());
            //}
            //catch (Exception ex)
            //{
            //    string mes = ex.Message;
            //    if (ex is IndexOutOfRangeException)
            //    {
            //        mes = "Ошибка при выборе файла";
            //    }
            //    MessageBox.Show(mes);
            //}
            StreamReader reader = new StreamReader(openfile.OpenFile());
            activeDataBase.GetNewDataBaseFromString(reader.ReadToEnd());
        }
    }
}
