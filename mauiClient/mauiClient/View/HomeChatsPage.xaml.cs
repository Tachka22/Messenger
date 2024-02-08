

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
        ListView listView = new ListView { };
        listView.SeparatorVisibility = SeparatorVisibility.Default;
        listView.SeparatorColor = Color.FromArgb("#eaeaea");
        // ���������� �������� ������
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
            new Language {Name="Ann", ImagePath="chatavatar.png", Description = "I want five" },
            new Language {Name="Vova", ImagePath="chatavatar.png", Description = "are you?" },
            new Language {Name="Vlad", ImagePath="chatavatar.png", Description = "Hi!" },
            new Language {Name="Iban", ImagePath="chatavatar.png", Description = "How?" },
            new Language {Name="Ann", ImagePath="chatavatar.png", Description = "I want five" },
            new Language {Name="Vova", ImagePath="chatavatar.png", Description = "are you?" },
        };
        // ���������� ������ ������
        listView.ItemTemplate = new DataTemplate(() =>
        {
            CustomCell customCell = new CustomCell { ImageHeight = 50, ImageWidth = 50 };

            customCell.SetBinding(CustomCell.TitleProperty, "Name");
            customCell.SetBinding(CustomCell.DetailProperty, "Description");
            customCell.SetBinding(CustomCell.ImagePathProperty, "ImagePath");
            return customCell;
        });
        
        StackL.Add(new Microsoft.Maui.Controls.StackLayout { Children = { listView }, Padding = 7, });
    }
}