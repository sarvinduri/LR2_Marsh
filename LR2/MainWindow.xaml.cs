using Microsoft.Win32;
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


namespace LR2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnSavestudent_Click(object sender, RoutedEventArgs e)
        {
            ClsMarsh Marsh = new ClsMarsh();
            Marsh.StartA = TxtA.Text;
            Marsh.EndB = TxtB.Text;
            Marsh.Number = TxtStip.Text;

            LstStudents.Items.Clear();
            LstStudents.Items.Add(Marsh.PrintToScreen());
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == false)
                return;
            Marsh.SaveToFile(saveFileDialog.FileName);

        }
    }
}
