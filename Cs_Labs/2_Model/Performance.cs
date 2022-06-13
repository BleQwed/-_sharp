using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Model
{
    public class Performance
    {
        private string name { get; set; }
        private int countOfPeopleBegin { get; set; }
        private int countOfPeopleEnd { get; set; }
        public Performance(string name, int n1, int n2)
        {
            this.name = name;
            countOfPeopleBegin = n1;
            countOfPeopleEnd = n2;
        }
        public virtual double getQuality()
        {
            return (double)(countOfPeopleEnd - countOfPeopleBegin) / (double)countOfPeopleBegin;
        }
        public virtual string getInfo()
        {
            return "Название: " + name +
                "\nКоличество людей в начале: " + countOfPeopleBegin +
                "\nКоличество людей в конце: " + countOfPeopleEnd;
        }
    }
    public class PerformanceYear : Performance
    {
        private int year;
        public PerformanceYear(string name, int n1, int n2, int year) : base(name, n1, n2)
        {
            this.year = year;
        }
        public override double getQuality()
        {
            return base.getQuality() * (2022 - year + 1);
        }
        public override string getInfo()
        {
            return base.getInfo() + "\nГод написания пьесы: " + year;
        }
    }
}
