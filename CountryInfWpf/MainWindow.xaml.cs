using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CountryInfWpf
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int i = 0;//счетчик в цикле
        SerchCountry SerchCountry = new SerchCountry();
        public MainWindow()
        {
            InitializeComponent();
            
        }
        //Очистка listview
        public void ListViewClear()
        {
            listViewCoutryInfo.Items.Clear();
        }

        private void buttonSerch_Click(object sender, RoutedEventArgs e)
        {
            ListViewClear();

            SerchCountry.Serch(textBoxEnterCountry.Text);// Вызов метода Serch (поиск информации о введенной стране) 
            //Вывод информации в ListView 
            try
            {
                for (i = 0; i < 6; i += gridViewCoutryInfo.Columns.Count)
                {
                    listViewCoutryInfo.Items.Add(Country);
                    ListViewItem item = listViewCoutryInfo.Items.Add(SerchCountry.result[i]);
                    item.SubItems.Add(SerchCountry.result[i + 1]);
                    item.SubItems.Add(SerchCountry.result[i + 2]);
                    item.SubItems.Add(SerchCountry.result[i + 3]);
                    item.SubItems.Add(SerchCountry.result[i + 4]);
                    item.SubItems.Add(SerchCountry.result[i + 5]);
                }
                // Вывод сообщения сохранять данные или нет
                if (Convert.ToString(listViewCoutryInfo.Items[0].Text) != "")
                {
                    DialogResult dialogResultSave = MessageBox.Show("Сохранить данные?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialogResultSave == DialogResult.Yes)
                    {
                        ToolStripMenuItemSave_Click(sender, e);
                    }
                }
            }
            catch { }
        }
    }
    }
}
