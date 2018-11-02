using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using ClsWrkTwoWayDataBindingProject.Annotations;

namespace ClsWrkTwoWayDataBindingProject.Model
{
    class Car : INotifyPropertyChanged
    {
        private int _id;
        private string _name;

        public Car(int id , string name)
        {
            _id = id;
            _name = name;
        }

        public int ID
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
                 OnPropertyChanged(nameof(ID));
                
            }
         }
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
               
                OnPropertyChanged(nameof(Name));
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
