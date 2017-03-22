using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace CarouselViewControlTestApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            this.BindingContext = this;

            this.NextPageCommand = new Command(async () => await this.NextPage());

            InitializeComponent();

            this.carouselViewControl.ItemTemplate = new PageTemplateSelector();

            this.carouselViewControl.ItemsSource = new List<int>() { 0 }; 
        }

        public ICommand NextPageCommand { get; set; }

        private async Task NextPage()
        {
            var pageIndex = Convert.ToInt32(this.carouselViewControl.ItemsSource[0]);

            await this.carouselViewControl.InsertPage(pageIndex + 1);

            this.carouselViewControl.Position++;

            await Task.Delay(1000);

            await this.carouselViewControl.RemovePage(0);
        }
    }
}
