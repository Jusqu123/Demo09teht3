using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;


// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Demo10teht1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void BuyButton_Click(object sender, RoutedEventArgs e)
        {
            shoppingListTextBox.Text = "";

            if ((bool)MilkCheckBox.IsChecked)
            {
                shoppingListTextBox.Text += "Milk ";
            }
            else { }
            if ((bool)ButterCheckBox.IsChecked)
            {
                shoppingListTextBox.Text += "Butter ";
            }
            if ((bool)BeerCheckBox.IsChecked)
            {
                shoppingListTextBox.Text += "Beer ";
            }
            if ((bool)ChickenCheckBox.IsChecked)
            {
                shoppingListTextBox.Text += "Chicken ";
            }
            if ((bool)Lemonade.IsChecked)
            {
                shoppingListTextBox.Text += "lemonade ";

            }
     
        }
    }
}







































/*
                 string items = "";
                 foreach (object control in StackPanel)

                     if (control is CheckBox)
                     {
                         CheckBox checbox = (CheckBox)control;           
                         }
                         if ((bool)CheckBox.isChecked) items += CheckBox.Content + "";
                     }*/
