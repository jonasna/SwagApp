using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using SwagApp.DataStores;
using SwagApp.Models;

namespace SwagApp.ViewModels
{
    public class ListItemViewModel : INotifyPropertyChanged
    {

        private readonly List<ListItem> _items;
        private readonly string _name;





        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}