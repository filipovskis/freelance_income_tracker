using System;
using System.Collections.Generic;
using System.Text;

namespace ind_project_project.Models
{
    internal class FixedPriceWork : BaseRecord
    {
        public float Price { get; set; }
        public override float GetGrossIncome() { return Price; }
        public override string GetDescText()
        {
            return $"{Price:F2} EUR #fixedprice";
        }
        public FixedPriceWork(float price)
        {
            Price = price;
        }
    }
}
