using System.Collections.Generic;
using System.Collections.ObjectModel;
using TodoListApp.Models;

namespace TodoListApp.ViewModels;

public class TodoListViewModel : ViewModelBase
{
    public ObservableCollection<TodoItem> Items { get; }

    public TodoListViewModel()
    {
        var items = new[]
        {
            new TodoItem {Description = "Walk the dog"},
            new TodoItem {Description = "Buy some milk"},
            new TodoItem {Description = "Learn Avalonia", IsChecked = true},
        };
        Items = new ObservableCollection<TodoItem>(items);
    }
}