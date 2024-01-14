using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FarmEmployees
{
    public class Statistics
    {

        
        public float Count { get; private set; }
        public float Sum { get; private set; }
        //public float Min { get; private set; }
        //public float Max { get; private set; }
        public float DailyWorkingNorm { get; private set; }
        public float WeeklyWorkingNorm { get; private set; }
        public float StandardHourlyIncome { get; private set; }            

        public float HourlyAverage
        {
            get
            {            
                return this.Sum / WeeklyWorkingNorm;
            }
        }
        
        public float DaylyAverage
        {
            get
            {            
                return HourlyAverage * DailyWorkingNorm;
            }
        }

        public float DeviationFromStandardHourlyIncome
        {
            get
            {
                return ((HourlyAverage  / StandardHourlyIncome) - 1) * 100;
            }
        }
       
        public Statistics(DataForCalculateion data)
        {            
            this.Count = 0;
            this.Sum = 0;
            //this.Min = float.MaxValue;
            //this.Max = float.MinValue;

            this.DailyWorkingNorm = data.DailyWorkingNorm;
            this.WeeklyWorkingNorm = data.WeeklyWorkingNorm;
            this.StandardHourlyIncome = data.StandardHourlyIncome;
        }

        public void AddSalary(float salary)
        {
            this.Count++; 
            this.Sum += salary;
            //this.Min = Math.Min(this.Min, salary);
            //this.Max = Math.Max(this.Max, salary);   
        }
              
    }
}
