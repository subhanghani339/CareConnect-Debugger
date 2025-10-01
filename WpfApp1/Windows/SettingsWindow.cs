using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp1.Windows
{
    public partial class SettingsWindow: Window
    {
        public SettingsWindow()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            // Example: just close the popup for now
            this.DialogResult = true; // makes ShowDialog() return true
            this.Close();

            // Later you can add logic here to read/write your textboxes
        }


    }
}
