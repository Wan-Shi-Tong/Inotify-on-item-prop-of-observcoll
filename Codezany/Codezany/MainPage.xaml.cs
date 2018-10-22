using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Codezany
{
    public partial class MainPage : ContentPage
    {


        public MainPage()
        {
            InitializeComponent();


            label.Text = "welcome";
            label.BindingContext = InstanceClass.vm.OtelemetInstance[0];
            label.SetBinding(Label.TextProperty, "Daycount"); //skipped a convertor since it doesnt matter

            while (true)
            {
                Thread.Sleep(1000);
                InstanceClass.vm.SomeMethod();
            }

        }
    }
}
