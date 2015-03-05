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
        List<NotaryDisplay> listToDisplay = new List<NotaryDisplay>();
        DataBase activeDataBase = DataBase.Instance;
        public Form1()
        {
            InitializeComponent();
        }
        private void RefreshListToDisplay()
        {
            int j = 1;
            listToDisplay.Clear();
            foreach (Notary q in activeDataBase.GetList)
            {
                listToDisplay.Add(new NotaryDisplay(j++, q));
            }
        }
        private void ъToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void ShowActiveList()
        {
            int i = 1;
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
            bindingSource1.DataSource = activeDataBase.GetList;
            foreach (Notary q in activeDataBase.GetList)
            {
                
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            toolStripComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void RefreshHistory()
        {
            toolStripComboBox1.Items.Clear();
            foreach (ListVersion q in activeDataBase.GetHistory)
            {
                toolStripComboBox1.Items.Add(q);
            }
            if (toolStripComboBox1.Items.Count > 0)
                toolStripComboBox1.SelectedIndex = 0;
        }
        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.Filter = "Файлы таблиц (*.csv)|*.csv";
            openfile.ShowDialog();
            try
            {
                StreamReader reader = new StreamReader(openfile.OpenFile());
                activeDataBase.GetNewDataBaseFromString(reader.ReadToEnd());
                reader.Close();
                if (activeDataBase.GetList.Count > 0)
                {
                    RefreshListToDisplay();
                    if (activeDataBase.GetErrorList.Count > 0)
                    {
                        string res = string.Format("Количество необработанных строк: {0}\n\n\n\nСписок:\n\n", activeDataBase.GetErrorList.Count);
                        foreach (string q in activeDataBase.GetErrorList)
                        {
                            res += q;
                        }
                        MessageBox.Show(res);
                    }
                    RefreshHistory();
                    bindingSource1.DataSource = listToDisplay;
                    dataGridView1.DataSource = bindingSource1;
                }
                else
                {
                    MessageBox.Show("В файле нет корректных строк! Пожалуйста, загрузите другой файл.");
                }
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
                if (ex is IndexOutOfRangeException)
                {
                    mes = "Ошибка при выборе файла";
                }
                MessageBox.Show(mes);
            }

        }
    }
}
