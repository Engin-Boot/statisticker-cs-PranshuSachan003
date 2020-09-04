﻿using System;
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
        public double CalculateAverage(List<double> numbers)
    {
        double sum = 0;
        double average;
        for(int i=0;i<numbers.Count;i++)
            sum=sum+numbers[i];
         average = (double)(sum/numbers.Count);
          return average;
    }
    public double CalculateMin(List<double> numbers)
    {
        double min = numbers[0];
        for(int i=1;i<numbers.Count;i++)
           {
              if(numbers[i]<min)
                 min=numbers[i];
           }
        return min;
    }
    public double CalculateMax(List<double> numbers)
    {
        double max = numbers[0];
            for(int i=1;i<numbers.Count;i++)
            {
                if(numbers[i]>max)
                    max=numbers[i];
            }
        return max;
    }
         public List<double> ReturningListAfterRemovingNaNIfContain(List<double> numbers)
    { 
             List<double> number;
            for(int i=1;i<numbers.Count;i++)
            {
                if(!(Double.IsNaN(numbers[i])))
                   number.Add(numbers[i]);
            }
        return number;
    }
        public Stats CalculateStatistics(List<double> numbers) {
             Stats obj = new Stats();
            List<double> numbers = ReturningListAfterRemovingNaNIfContain(List<double> numbers)
            if(numbers.Count!=0)
            {
                double averageOfNumbers = CalculateAverage(numbers);
                double minOfNumbers  = CalculateMin(numbers);
                double maxOfNumbers = CalculateMax(numbers);
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
