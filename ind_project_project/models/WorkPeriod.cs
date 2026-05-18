using ind_project_project.Core;
using System;
using System.Collections.Generic;
using System.Text;

// to correctly calculate VSAOI and IIN
namespace ind_project_project.Models
{
    internal class WorkPeriod
    {
        protected List <BaseRecord> _records = new List<BaseRecord>();
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        private double MinWage = (double)ConfigManager.Instance.Get<double>("NonTaxableMinimum");
        private const double VsaoiFullRate = 0.3107;
        private const double VsaoiPensionRate = 0.10;
        private const double IinRate = 0.255;
        private const double MonthlyNonTaxableMinimum = 550.0;

        internal void AddRecord(BaseRecord record)
        {
            _records.Add(record);
        }

        internal double CalculateSum()
        {
            double sum = 0;
            foreach (var record in _records)
            {
                sum += (double)record.GetGrossIncome();
            }
            return sum;
        }

        internal double CalculateVSAOI()
        {
            double sum = CalculateSum();

            if (sum <= 0) return 0;

            if (sum < MinWage)
            {
                // 10%
                return sum * VsaoiPensionRate;
            }
            else
            {
                // 31.07% from minimal (780) + 10%
                double baseVsaoi = MinWage * VsaoiFullRate;
                double extraVsaoi = (sum - MinWage) * VsaoiPensionRate;

                return baseVsaoi + extraVsaoi;
            }
        }

        internal double CalculateIIN()
        {
            double profit = CalculateSum();
            double vsaoi = CalculateVSAOI();

            int monthsCount = ((EndDate.Year - StartDate.Year) * 12) + EndDate.Month - StartDate.Month + 1;
            if (monthsCount <= 0) monthsCount = 1;

            double periodNonTaxableMinimum = MonthlyNonTaxableMinimum * monthsCount;

            // sum - vsaoi - nonTaxableMinimum
            double taxableBase = profit - vsaoi - periodNonTaxableMinimum;

            if (taxableBase <= 0) return 0;

            return taxableBase * IinRate;
        }
    }
}
