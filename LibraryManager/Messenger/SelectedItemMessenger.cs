﻿using System;

namespace LibraryManager.Messenger
{
    class SelectItemMessenger<T> where T : NotifyPropertyChanged
    {
        public event EventHandler<SelectItemEventArgs> SelectItem;

        public void OnSelectItem(T newItem)
        {
            SelectItem?.Invoke(this, new SelectItemEventArgs(newItem));
        }

        public class SelectItemEventArgs : EventArgs
        {
            public SelectItemEventArgs(Object item)
            {
                Item = item;
            }

            public Object Item
            {
                get;
                private set;
            }
        }
    }
}
