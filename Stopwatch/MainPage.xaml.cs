using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Diagnostics;

namespace StopWatch 
{
    public partial class MainPage : ContentPage
    {
        Stopwatch stopwatch;
        public MainPage()
        {
            InitializeComponent();
            stopwatch = new Stopwatch();
            Stopwatch.Text = "00:00:00:00";
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            if (!stopwatch.IsRunning)
            {
                stopwatch.Start();
                Device.StartTimer(TimeSpan.FromMilliseconds(100), () =>
                {
                    Stopwatch.Text = stopwatch.Elapsed.ToString();
                    if (!stopwatch.IsRunning)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
                );
                    
            }
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            stopwatch.Stop();
        }

        private void btnReset_Clicked(object sender, EventArgs e)
        {
            Stopwatch.Text = "00:00:00:000";
            stopwatch.Reset();
        }
    }
}