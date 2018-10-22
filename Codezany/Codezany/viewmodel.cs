using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading;

namespace Codezany
{

    public class Viewmodel : BaseVM
    {
        public ObservableCollection<TelemetModel> OtelemetInstance { get; set; }

        public Viewmodel()
        {
            OtelemetInstance = new ObservableCollection<TelemetModel>();
            //Initial value
            var otelemet = new TelemetModel
            {
                Daycount = 0,
                Tdyattnd = 40, //Random values
                Tdybnk = 40,
                Tomattnd = 40,
                Tombnk = 40
            };
            OtelemetInstance.Add(otelemet);
        }

        public void SomeMethod()
        {


            var otelemet = new TelemetModel
            {
                Daycount = new Random().Next(1, 100),
                Tdyattnd = 40, //Random values
                Tdybnk = 40,
                Tomattnd = 40,
                Tombnk = 40
            };
            OtelemetInstance.Clear();

            OtelemetInstance.Add(otelemet);


        }

    }
}
