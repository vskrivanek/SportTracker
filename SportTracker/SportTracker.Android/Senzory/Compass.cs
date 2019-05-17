using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace SportTracker.Droid.Senzory
{
    public class Compass
    {
        SensorSpeed speed = SensorSpeed.UI;

        public CompassTest()
        {
            Compass.ReadingChanged += Compass_ReadingChanged;
        }

        void Compass_ReadingChanged(object sender, CompassChangedEventArgs e)
        {
            var data = e.Reading;
        }

    }
}