using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using CsvHelper;
using MahApps.Metro.Controls;

namespace IVAP.Syncer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Create OpenFileDialog 
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();



            // Set filter for file extension and default file extension 
            dlg.DefaultExt = ".csv";
            //dlg.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";


            // Display OpenFileDialog by calling ShowDialog method 
            Nullable<bool> result = dlg.ShowDialog();


            // Get the selected file name and display in a TextBox 
            if (result == true)
            {
                // Open document 
                string filename = dlg.FileName;
                fileTxtBox.Text = filename;
                
               
            }
        }

        private void syncButton_Click(object sender, RoutedEventArgs e)
        {
            var uCSV = new CsvReader(new StreamReader(fileTxtBox.Text));

            var unSyncedList = uCSV.GetRecords<Survey>();
            Syncrhonizerer syncer = new Syncrhonizerer();
            var syncedList = syncer.SyncSurveyWithMagicalUnicorns(unSyncedList.ToList());

            //Lets write this file
            using (var csv = new CsvWriter(new StreamWriter("C:\\Users\\ali\\Desktop\\SyncedSample.csv")))
            {
                csv.WriteRecords(syncedList);
            }

        }
    }
}
