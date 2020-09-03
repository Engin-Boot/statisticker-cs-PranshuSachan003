﻿using System;
using System.Collections.Generic;

namespace Statistics
{
    public class Stats
    {
       public float average;
        public float min;
        public float max;
    }
    public class StatsComputer
    {
        public Stats CalculateStatistics(List<float> numbers) {
            double sumOfNumbers = 0;
            float averageOfNumbers;
            for(int i=0;i<numbers.Count;i++)
                sumOfNumbers=sumOfNumbers+numbers[i];
            averageOfNumbers = (float)(sumOfNumbers/numbers.Count);
            float minOfNumbers = numbers[0];
            for(int i=1;i<numbers.Count;i++)
            {
                if(numbers[i]<minOfNumbers)
                    minOfNumbers=numbers[i];
            }
            float maxOfNumbers = numbers[0];
            for(int i=1;i<numbers.Count;i++)
            {
                if(numbers[i]>maxOfNumbers)
                    maxOfNumbers=numbers[i];
            }
            Stats obj = new Stats();
            obj.average = averageOfNumbers;
            obj.min = minOfNumbers;
            obj.max = maxOfNumbers;
            return obj;
            //Implement statistics here
        }
    }
}
