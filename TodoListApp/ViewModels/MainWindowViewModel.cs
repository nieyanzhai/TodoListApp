using System;
using System.Reactive.Linq;
using ReactiveUI;
using TodoListApp.Models;
using TodoListApp.ViewModels.UserControls;

namespace TodoListApp.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private ViewModelBase _content;

        public ViewModelBase Content
        {
            get => _content;
            set => this.RaiseAndSetIfChanged(ref _content, value);
        }

        public TodoListViewModel List { get; }

        public MainWindowViewModel() => Content = List = new TodoListViewModel();

        public void AddItem()
        {
            var vm = new AddItemViewModel();

            Observable.Merge(vm.Ok, vm.Cancel.Select(_ => (TodoItem) null))
                .Take(1)
                .Subscribe(model =>
                {
                    if (model != null) List.Items.Add(model);
                    Content = List;
                });
            Content = vm;
        }
    }
}