using System;
using System.Collections.Generic;

namespace Statistics
{
    public class Stats
    {
       public float average;
        public float max;
        public float min;
    }
    public class StatsComputer
    {
        public float CalculateAverage(List<float> numbers)
    {
        float sum = 0;
        float average;
        for(int i=0;i<numbers.Count;i++)
             sum=sum+numbers[i];
         average = (float)(sum/numbers.Count);
    }
    public float CalculateMin(List<float> numbers)
    {
        float min = numbers[0];
        for(int i=1;i<numbers.Count;i++)
           {
              if(numbers[i]<min)
                 min=numbers[i];
           }
    }
        public Stats CalculateStatistics(List<float> numbers) {
            float averageOfNumbers = CalculateAverage(numbers);
            float minOfNumbers  = CalculateMin(numbers);
            float maxOfNumbers = numbers[0];
            for(int i=1;i<numbers.Count;i++)
            {
                if(numbers[i]>maxOfNumbers)
                    maxOfNumbers=numbers[i];
            }
            Stats obj = new Stats();
            obj.average = averageOfNumbers;
            obj.max = maxOfNumbers;
            obj.min = minOfNumbers;
            return obj;
            //Implement statistics here
        }
    }
}
