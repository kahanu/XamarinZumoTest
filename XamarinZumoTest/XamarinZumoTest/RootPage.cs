using System;
using System.Linq;
using Xamarin.Forms;
using XamarinZumoTest.ViewModels;

namespace XamarinZumoTest
{
    public class RootPage : ContentPage
    {
        #region ctors

        private RootPageViewModel _viewModel;

        public RootPage()
        {
            BindPage();
        }

        #endregion

        #region Private Methods

        void BindPage()
        {
            BindingContext = this._viewModel = new RootPageViewModel();

            /************* Set Page Title *************/
            Title = "Todo Items King";

            var layout = new StackLayout { Padding = new Thickness(10, Device.OnPlatform(20, 10, 10), 10, 10) };

            /************* Set Input Fields *************/
            var label = new Label
            {
                Text = "The Todo Items"
            };
            layout.Children.Add(label);

            _viewModel.LoadItems();

            var labelCount = new Label
            {
                Text = string.Format("{0} items", _viewModel.Items.Count)
            };
            layout.Children.Add(labelCount);


            ListView list = new ListView
            {
                ItemsSource = _viewModel.Items,
                ItemTemplate = new DataTemplate(() => {
                    Label nameLabel = new Label();
                    nameLabel.SetBinding(Label.TextProperty, "Text");
                    return new ViewCell
                    {
                        View = nameLabel
                    };
                })
            };
            layout.Children.Add(list);

            Content = new ScrollView { Content = layout };
        }

        #endregion

    }
}
