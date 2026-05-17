using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace ind_project_project.models
{
    public abstract class BaseRecord : ITaxable
    {
        public DateTime Date { get; set; }
        public int ID { get; set; }

        public float EstimatedTaxRate = (float)core.ConfigManager.Instance.Get<double>("EstimatedTaxRate");

        public abstract float GetGrossIncome();
        
        public virtual string GetDescText()
        {
            return $"Record from {Date.ToShortDateString()} with gross income {GetGrossIncome()}";
        }

        public double GetEstimatedTax()
        {
            return GetGrossIncome() * EstimatedTaxRate;
        }
    }
}
