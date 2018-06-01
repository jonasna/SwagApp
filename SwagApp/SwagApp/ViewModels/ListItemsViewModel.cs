using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using SwagApp.DataStores;
using SwagApp.Models;

namespace SwagApp.ViewModels
{
    public class ListItemsViewModel : INotifyPropertyChanged
    {
        private readonly IListStore _listStore;

        public List<string> ListItems { get; private set; }

        public ListItemsViewModel()
        {
            _listStore = new FakeListStore();
            ListItems = new List<string>();
            Load();
        }

        private async void Load()
        {
            var result = await _listStore.GetAllLists();
            foreach (var list in result)
            {
                ListItems.Add(list);
                OnPropertyChanged("ListItems");
            }
        }

        public async Task Add(string name)
        {
            if (!string.IsNullOrEmpty(name))
            {
                var result = await _listStore.CreateList(new ToDoList() {Name = name});
                if (result != null)
                {
                    ListItems.Add(result.Name);
                    OnPropertyChanged("ListItems");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}