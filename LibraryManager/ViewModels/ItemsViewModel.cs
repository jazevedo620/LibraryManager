﻿using LibraryManager.Data.Item;
using LibraryManager.Messenger;
using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace LibraryManager.ViewModels
{
    class ItemsViewModel : NotifyPropertyChanged
    {
        private readonly ObservableCollection<IssuableItem> _items;

        public ObservableCollection<IssuableItem> Items
        {
            get { return _items; }
        }

        public SelectItemMessenger<IssuableItem> SelectItem { get; private set; }

        public ItemsViewModel(ObservableCollection<IssuableItem> items)
        {
            _items = items;
            _items.CollectionChanged += Items_CollectionChanged;
            SelectItem = new SelectItemMessenger<IssuableItem>();
        }

        private void Items_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            ForcePropertyChanged("Items");
        }

        internal bool ContainsID(string proposedID)
        {
            foreach(IssuableItem item in Items)
            {
                if (item.ID.Equals(proposedID)) return true;
            }
            return false;
        }
    }
}
