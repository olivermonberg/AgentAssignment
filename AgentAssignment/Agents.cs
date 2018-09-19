using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.ComponentModel;
using MvvmFoundation.Wpf;
using System.Windows.Input;
using System.Runtime.CompilerServices;

namespace AgentAssignment
{
    public class Agents : ObservableCollection<Agent>, INotifyPropertyChanged
    {
        public Agents()
        {
            Add(new Agent("007", "James Bond", "Assassination", "UpperVolta"));
            Add(new Agent("006", "Bames Jond", "Baker", "Ukraine"));
        }

      

        ICommand _addCommand;

        public ICommand AddCommand
        {
            get { return _addCommand ?? (_addCommand = new RelayCommand(AddAgent)); }
        }

        private void AddAgent()
        {
            Add(new Agent());
            CurrentIndex = Count - 1;
        }

        ICommand _nextCommand;

        public ICommand NextCommand
        {
            get
            {
                return _nextCommand ?? (_nextCommand = new RelayCommand(
                    () => ++CurrentIndex,
                    () => CurrentIndex < (Count - 1)));
            }
        }

        int currentIndex = -1;

        public int CurrentIndex
        {
            get { return CurrentIndex; }
            set
            {
                if (currentIndex != value)
                {
                    currentIndex = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public new event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName]string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}