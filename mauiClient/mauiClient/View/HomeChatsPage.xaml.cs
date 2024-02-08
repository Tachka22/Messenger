

namespace mauiClient.View;

class Language
{
    public string Name { get; set; } = "";
    public string Description { get; set; } = "";
    public string ImagePath { get; set; } = "";
}
public partial class HomeChatsPage : ContentPage
{
	public HomeChatsPage()
	{
		InitializeComponent();
        ListView listView = new ListView();
        listView.Margin = 10;

        // определяем источник данных
        listView.ItemsSource = new List<Language>
        {
            new Language {Name="Vlad", ImagePath="chatavatar.png", Description = "Hi!" },
            new Language {Name="Iban", ImagePath="chatavatar.png", Description = "How?" },
            new Language {Name="Ann", ImagePath="chatavatar.png", Description = "I want five" },
            new Language {Name="Vova", ImagePath="chatavatar.png", Description = "are you?" },
            new Language {Name="Vlad", ImagePath="chatavatar.png", Description = "Hi!" },
            new Language {Name="Iban", ImagePath="chatavatar.png", Description = "How?" },
            new Language {Name="Ann", ImagePath="chatavatar.png", Description = "I want five" },
            new Language {Name="Vova", ImagePath="chatavatar.png", Description = "are you?" },
            new Language {Name="Vlad", ImagePath="chatavatar.png", Description = "Hi!" },
            new Language {Name="Iban", ImagePath="chatavatar.png", Description = "How?" },
            new Language {Name="Ann", ImagePath="chatavatar.png", Description = "I want five" },
            new Language {Name="Vova", ImagePath="chatavatar.png", Description = "are you?" },
        };
        // определяем шаблон данных
        listView.ItemTemplate = new DataTemplate(() =>
        {
            ImageCell imageCell = new ImageCell
            {
                TextColor = Color.FromArgb("#2E2B2B"),
                DetailColor = Color.FromArgb("#90A4AE"),
            };
            imageCell.SetBinding(ImageCell.TextProperty, "Name");
            imageCell.SetBinding(ImageCell.DetailProperty, "Description");
            imageCell.SetBinding(ImageCell.ImageSourceProperty, "ImagePath");
            return imageCell;
        });
        
        Label header = new Label { FontSize = 18, Text = "Языки программирования" };
        StackL.Add(new Microsoft.Maui.Controls.StackLayout { Children = { listView }, Padding = 7, });
    }
}