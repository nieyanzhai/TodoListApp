using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace TodoListApp.Views.UserControls;

public partial class TodoListView : UserControl
{
    public TodoListView()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}