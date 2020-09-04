using System;
using System.Collections.Generic;

namespace Statistics
{
    public class Stats
    {
       public double average;
        public double max;
        public double min;
    }
    public class StatsComputer
    {
        public double CalculateAverage(List<double> numbersListWithoutNaN)
    {
        double sum = 0;
        double average;
        for(int i=0;i<numbersListWithoutNaN.Count;i++)
            sum=sum+numbersListWithoutNaN[i];
         average = (double)(sum/numbersListWithoutNaN.Count);
          return average;
    }
    public double CalculateMin(List<double> numbersListWithoutNaN)
    {
        double min = numbersListWithoutNaN[0];
        for(int i=1;i<numbersListWithoutNaN.Count;i++)
           {
              if(numbersListWithoutNaN[i]<min)
                 min=numbersListWithoutNaN[i];
           }
        return min;
    }
    public double CalculateMax(List<double> numbersListWithoutNaN)
    {
        double max = numbersListWithoutNaN[0];
            for(int i=1;i<numbersListWithoutNaN.Count;i++)
            {
                if(numbersListWithoutNaN[i]>max)
                    max=numbersListWithoutNaN[i];
            }
        return max;
    }
         public List<double> ReturningListAfterRemovingNaNIfContain(List<double> numbers)
    { 
             List<double> number = new List<double>();;
            for(int i=1;i<numbers.Count;i++)
            {
                if(!(Double.IsNaN(numbers[i])))
                   number.Add(numbers[i]);
            }
        return number;
    }
        public Stats CalculateStatistics(List<double> numbers) {
             Stats obj = new Stats();
            List<double> numberswithoutNaN = ReturningListAfterRemovingNaNIfContain(numbers);
            if(numberswithoutNaN.Count!=0)
            {
                double averageOfNumbers = CalculateAverage(numberswithoutNaN);
                double minOfNumbers  = CalculateMin(numberswithoutNaN);
                double maxOfNumbers = CalculateMax(numberswithoutNaN);
                obj.average = averageOfNumbers;
                obj.max = maxOfNumbers;
                obj.min = minOfNumbers;
            }
            else
            {
               obj.average = double.NaN;
               obj.max =  double.NaN;
               obj.min =  double.NaN;
            }
            return obj;
            //Implement statistics here
        }
    }
}
