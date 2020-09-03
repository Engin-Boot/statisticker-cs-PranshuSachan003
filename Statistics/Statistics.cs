using System;
using System.Collections.Generic;

namespace Statistics
{
    public class StatsComputer
    {
        public Stats CalculateStatistics(List<float> numbers) {
            double sum = 0;
            float average;
            for(int i=0;i<numbers.count;i++)
                sum=sum+numbers[i];
            average = (float)(sum/numbers.count);
            return average;
            float min = numbers[0];
            for(int i=1;i<numbers.count;i++)
            {
                if(numbers[i]<min)
                    min=numbers[i];
            }
            return min;
            float max = numbers[0];
            for(int i=1;i<numbers.count;i++)
            {
                if(numbers[i]>max)
                    max=numbers[i];
            }
            return max;
            if (double.IsNaN(average)||double.IsNaN(min)||double.IsNaN(mx))
            throw new ArithmeticException();
            //Implement statistics here
        }
    }
}
