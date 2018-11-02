using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClsWrkTwoWayDataBindingProject.Model;

namespace ClsWrkTwoWayDataBindingProject.ViewModel
{
    class CarVm
    {
        // Define object of your business logic 
        private Car _car;

        public CarVm()
        {
            _car = new Car(12, "Mercedes");
        }

        // Source Property :
        public Car Car
        {
            get { return _car; }
            set { _car = value; }
        }

    }
}
