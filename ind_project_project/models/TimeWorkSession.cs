using System;
using System.Collections.Generic;
using System.Text;
using static System.Collections.Specialized.BitVector32;

namespace ind_project_project.models
{
    internal class TimeWorkSession : BaseRecord, ITaxable
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public float HourRate { get; set; }
        public override float GetGrossIncome() { 
            return (float)Math.Round((Hours + Minutes / 60f) * HourRate, 2); 
        }
        public override string GetDescText()
        {
            return $"{Hours} hours {Minutes} minutes ({HourRate:F0}€/h) → {GetGrossIncome():F2} EUR #worktime";
        }

        public TimeWorkSession(int hours, int minutes, float hourRate  )
        {
            Hours = hours;
            Minutes = minutes;
            HourRate = hourRate;
        }
    }
}
