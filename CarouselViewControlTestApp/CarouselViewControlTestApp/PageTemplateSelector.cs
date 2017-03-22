using System;
using Xamarin.Forms;

namespace CarouselViewControlTestApp
{
    public class PageTemplateSelector : DataTemplateSelector
    {
        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var dataTemplate = new DataTemplate(() =>
            {
                return new ContentView()
                {
                    BackgroundColor = Color.Green,
                    HeightRequest = 500,
                    WidthRequest = 400,
                    VerticalOptions = LayoutOptions.Center,
                    Content = new Label()
                    {
                        Text = Convert.ToString(item),
                        HorizontalTextAlignment = TextAlignment.Center,
                        VerticalTextAlignment = TextAlignment.Center,
                        FontSize = 30
                    }
                };
            });

            return dataTemplate;
        }
    }
}
