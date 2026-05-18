using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using ind_project_project.Core;

namespace ind_project_project.Models
{
    public abstract class BaseRecord : ITaxable
    {
        public DateTime Date { get; set; }
        public int ID { get; set; }

        public float EstimatedTaxRate = (float)ConfigManager.Instance.Get<double>("EstimatedTaxRate");

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
