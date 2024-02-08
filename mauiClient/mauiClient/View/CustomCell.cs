using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mauiClient.View
{
    
    public class CustomCell : ViewCell
    {
        Label titleLabel, detailLabel;
        Image image;


        public CustomCell()
        {
            titleLabel = new Label { FontSize = 18, TextColor = Color.FromArgb("#455A64") };
            image = new Image { Margin = new Thickness(0,10,0,10)};
            detailLabel = new Label {TextColor = Color.FromArgb("#455A64"), FontSize = 14};
            Frame frame = new Frame { 
                BorderColor = Colors.Transparent,
                BackgroundColor = Colors.Transparent,
                Padding = 0,
                CornerRadius = 10,
                Margin = new Thickness(0, 0, 0, 4)
            };
            StackLayout cell = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                Margin = new Thickness(10, 5),
                HeightRequest = 60
            };

            StackLayout titleDetailLayout = new StackLayout { 
                Margin = new Thickness(20,0,0,0),
                VerticalOptions = LayoutOptions.Center};
            titleDetailLayout.Children.Add(titleLabel);
            titleDetailLayout.Children.Add(detailLabel);

            cell.Children.Add(image);
            cell.Children.Add(titleDetailLayout);
            frame.Content = cell;
            View = frame;
        }

        public static readonly BindableProperty TitleProperty =
            BindableProperty.Create("Title", typeof(string), typeof(CustomCell), "");
        public static readonly BindableProperty ImagePathProperty =
            BindableProperty.Create("ImagePath", typeof(ImageSource), typeof(CustomCell), null);

        public static readonly BindableProperty ImageWidthProperty =
            BindableProperty.Create("ImageWidth", typeof(int), typeof(CustomCell), 100);

        public static readonly BindableProperty ImageHeightProperty =
            BindableProperty.Create("ImageHeight", typeof(int), typeof(CustomCell), 100);

        public static readonly BindableProperty DetailProperty =
            BindableProperty.Create("Detail", typeof(string), typeof(CustomCell), "");
        public string Title
        {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }
        public int ImageWidth
        {
            get { return (int)GetValue(ImageWidthProperty); }
            set { SetValue(ImageWidthProperty, value); }
        }
        public int ImageHeight
        {
            get { return (int)GetValue(ImageHeightProperty); }
            set { SetValue(ImageHeightProperty, value); }
        }

        public ImageSource ImagePath
        {
            get { return (ImageSource)GetValue(ImagePathProperty); }
            set { SetValue(ImagePathProperty, value); }
        }

        public string Detail
        {
            get { return (string)GetValue(DetailProperty); }
            set { SetValue(DetailProperty, value); }
        }
        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();

            if (BindingContext != null)
            {
                titleLabel.Text = Title;
                detailLabel.Text = Detail;
                image.Source = ImagePath;
                image.WidthRequest = ImageWidth;
                image.HeightRequest = ImageHeight;
            }
        }
    }
}
