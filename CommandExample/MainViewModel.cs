using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace CommandExample
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public MainViewModel()
        {
            IncreaseCommand = new Command(IncreaseCount);

            //if you want to execute the command manually then you do
            // IncreaseCommand.Execute
        }

        public ICommand IncreaseCommand { get; }

        int count = 0;

        void IncreaseCount()
        {
            count++;
            OnPropertyChanged(nameof(DisplayCount));
        }

        public string DisplayCount => $"You clicked {count} time(s).";

        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
