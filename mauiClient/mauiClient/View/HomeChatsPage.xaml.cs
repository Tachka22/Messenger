

namespace mauiClient.View;

class Language
{
    public string Name { get; set; } = "";
    public string Description { get; set; } = "";
    public string ImagePath { get; set; } = "";
}
public partial class HomeChatsPage : ContentPage
{
    ListView listView = new ListView { };
    public HomeChatsPage()
	{
		InitializeComponent();
        
        listView.SeparatorVisibility = SeparatorVisibility.Default;
        listView.SeparatorColor = Color.FromArgb("#eaeaea");
        listView.ItemSelected += ListView_ItemSelected;
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
            CustomCell customCell = new CustomCell { ImageHeight = 50, ImageWidth = 50 };

            customCell.SetBinding(CustomCell.TitleProperty, "Name");
            customCell.SetBinding(CustomCell.DetailProperty, "Description");
            customCell.SetBinding(CustomCell.ImagePathProperty, "ImagePath");
            return customCell;
        });
        
        StackL.Add(new Microsoft.Maui.Controls.StackLayout { Children = { listView }, Padding = 7, });
    }

    private async void ListView_ItemSelected(object? sender, SelectedItemChangedEventArgs e)
    {
        await Shell.Current.GoToAsync($"//{nameof(View.ChatPage)}");
    }
}