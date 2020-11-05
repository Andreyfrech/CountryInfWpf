using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
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
        CountryForm CountryForm = new CountryForm();
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
                // Преобразование площади из string (записанная через точку) в double 
                //
                CultureInfo temp_culture = Thread.CurrentThread.CurrentCulture;
                Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-US");
                double area = double.Parse(SerchCountry.result[3]);
                Thread.CurrentThread.CurrentCulture = temp_culture;
                for (i = 0; i < 6; i += gridViewCoutryInfo.Columns.Count)
                {
                    listViewCoutryInfo.Items.Add(new CountryForm { Country = SerchCountry.result[i], CodeCountry = SerchCountry.result[i + 1], Capital = SerchCountry.result[i + 2], Area = area, Population =Convert.ToDouble(SerchCountry.result[i+4]), Region = SerchCountry.result[i+5] });
                  
                }
                // Вывод сообщения сохранять данные или нет
                if (Convert.ToString(listViewCoutryInfo.Items[0]) != "")
                {
                   
                   MessageBoxResult messageBoxResultSave = MessageBox.Show("Сохранить данные?", "Сообщение", MessageBoxButton.YesNo, MessageBoxImage.Question);

                    if (messageBoxResultSave == MessageBoxResult.Yes)
                    {
                        ToolStripMenuItemSave_Click(sender, e);
                    }
                }
            }
            catch { }
        }
    }
    }

