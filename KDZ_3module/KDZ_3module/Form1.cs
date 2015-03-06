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
        string path = "";
        List<NotaryDisplay> listToDisplay = new List<NotaryDisplay>();
        DataBase activeDataBase = DataBase.Instance;
        bool IsTextBoxClicked = false;
        public Form1()
        {
            InitializeComponent();
        }
        private void RefreshListToDisplay()
        {
            int j = 1;
            listToDisplay = new List<NotaryDisplay>();
            foreach (Notary q in activeDataBase.GetList)
            {
                listToDisplay.Add(new NotaryDisplay(j++, q));
            }
            bindingSource1.DataSource = listToDisplay;
            dataGridView1.Refresh();
        }
        private void ъToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void ShowActiveList()
        {
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
            int i = 1;
            foreach (ListVersion q in activeDataBase.GetHistory)
            {
                toolStripComboBox1.Items.Add(i++.ToString() + ". " + q);
            }
            //if (toolStripComboBox1.Items.Count > 0)
            //    toolStripComboBox1.SelectedIndex = toolStripComboBox1.Items.Count - 1;
        }
        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.Filter = "Файлы таблиц (*.csv)|*.csv";
            if (openfile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    StreamReader reader = new StreamReader(openfile.OpenFile());
                    activeDataBase.GetNewDataBaseFromString(reader.ReadToEnd());
                    reader.Close();
                    if (activeDataBase.GetList.Count > 0)
                    {
                        сохранитьToolStripMenuItem.Enabled = true;
                        сохранитьКакToolStripMenuItem.Enabled = true;
                        инструментыToolStripMenuItem.Enabled = true;
                        архивToolStripMenuItem.Enabled = true;
                        добавитьКToolStripMenuItem.Enabled = true;

                        path = openfile.FileName;

                        activeDataBase.GetHistory.Clear();
                        activeDataBase.AddNewVersion("Загруженный файл", activeDataBase.GetList);

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
                        MessageBox.Show("Файл слишком сильно поврежден! Пожалуйста, загрузите другой файл.");
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

        private void поИмениToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (toolStripTextBox1.Text == "" || IsTextBoxClicked == false)
            {
                activeDataBase.GetList.Sort((a, b) =>
                    {
                        return a.GetFullName.CompareTo(b.GetFullName);
                    });
                activeDataBase.GetList.Sort((a, b) =>
                {
                    return a.GetFullName.CompareTo(b.GetFullName);
                });
                activeDataBase.AddNewVersion("Сортировка по имени", activeDataBase.GetList);
                RefreshHistory();
                RefreshListToDisplay();
            }
            else
            {
                MessageBox.Show("Сначала сохраните или отмените фильтрацию");
            }
        }

        private void поБлижайшейСтанцииМетроToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (toolStripTextBox1.Text == "" || IsTextBoxClicked == false)
            {
                activeDataBase.GetList.Sort((a, b) =>
                {
                    return a.GetMetrostations.CompareTo(b.GetMetrostations);
                });
                activeDataBase.GetList.Sort((a, b) =>
                {
                    return a.GetMetrostations.CompareTo(b.GetMetrostations);
                });
                activeDataBase.AddNewVersion("Сортировка по станциям", activeDataBase.GetList);
                RefreshHistory();
                RefreshListToDisplay();
            }
            else
            {
                MessageBox.Show("Сначала сохраните или отмените фильтрацию");
            }
        }

        private void перевернутьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (toolStripTextBox1.Text == "" || IsTextBoxClicked == false)
            {
                activeDataBase.GetList.Reverse();
                activeDataBase.AddNewVersion("Обратный порядок", activeDataBase.GetList);
                RefreshHistory();
                RefreshListToDisplay();
            }
            else
            {
                MessageBox.Show("Сначала сохраните или отмените фильтрацию");
            }
        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (toolStripTextBox1.Text != "")
            {
                string text = toolStripTextBox1.Text;
                activeDataBase.GetList.Clear();
                foreach (Notary q in activeDataBase.GetHistory[activeDataBase.GetHistory.Count - 1].GetList)
                {
                    if (q.GetFullName.IndexOf(text) > -1 ||
                        q.GetPhoneNumber.IndexOf(text) > -1 ||
                        q.GetAddress.IndexOf(text) > -1 ||
                        q.GetMetrostations.IndexOf(text) > -1)
                    {
                        activeDataBase.GetList.Add(q);
                    }
                }
                RefreshHistory();
                RefreshListToDisplay();
            }
        }

        private void сохранитьРезультатФильтрацииВАрхивToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (toolStripTextBox1.Text != "" && activeDataBase.GetList.Count > 0)
            {
                activeDataBase.AddNewVersion("Фильтрация по ключу: \"" + toolStripTextBox1.Text + "\"", activeDataBase.GetList);
                RefreshHistory();
                RefreshListToDisplay();
                toolStripTextBox1.Text = "";
            }
            else
            {
                activeDataBase.GetList.Clear();
                foreach (Notary q in activeDataBase.GetHistory[activeDataBase.GetHistory.Count - 1].GetList)
                {
                    activeDataBase.GetList.Add(q);
                }
                toolStripTextBox1.Text = "";
                RefreshListToDisplay();
                dataGridView1.Refresh();
            }
        }

        private void отменитьРезультатФильтрацииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            activeDataBase.GetList.Clear();
            foreach (Notary q in activeDataBase.GetHistory[activeDataBase.GetHistory.Count - 1].GetList)
            {
                activeDataBase.GetList.Add(q);
            }
            toolStripTextBox1.Text = "";
            RefreshListToDisplay();
            dataGridView1.Refresh();
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
            IsTextBoxClicked = true;
            toolStripTextBox1.Text = "";
            toolStripTextBox1.ForeColor = Color.Black;
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            activeDataBase.AddNewVersion("Выбор версии -> " + (toolStripComboBox1.SelectedIndex + 1).ToString(), activeDataBase.GetHistory[toolStripComboBox1.SelectedIndex].GetList);
            RefreshHistory();
            RefreshListToDisplay();
            dataGridView1.Refresh();
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamWriter stream = new StreamWriter(new FileStream(path, FileMode.Create), Encoding.Unicode);
            stream.Write(activeDataBase.GetString());
            stream.Close();
        }

        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            if (savefile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                path = savefile.FileName;
                StreamWriter stream = new StreamWriter(new FileStream(path, FileMode.Create), Encoding.Unicode);
                stream.Write(activeDataBase.GetString());
                stream.Close();
            }
        }

        private void добавитьКToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog savefile = new SaveFileDialog();
                savefile.OverwritePrompt = false;
                savefile.CheckFileExists = true;
                savefile.Filter = "Файлы таблиц (*.csv)|*.csv";
                if (savefile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    path = savefile.FileName;
                    StreamWriter stream = new StreamWriter(new FileStream(path, FileMode.Append), Encoding.Unicode);
                    stream.Write(activeDataBase.GetString());
                    stream.Close();
                }
            }
            catch(Exception mes)
            {
                MessageBox.Show(mes.Message);
            }
        }
    }
}
