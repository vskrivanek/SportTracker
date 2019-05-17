using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.Hardware;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace SportTracker.Droid.Senzory
{
    public class StepCounter : Java.Lang.Object, IStepCounter, ISensorEventListener
    {
        private int StepsCounter = 0;
        private SensorManager sManager;

        public int Steps
        {
            get { return StepsCounter; }
            set { StepsCounter = value; }
        }
    }
}