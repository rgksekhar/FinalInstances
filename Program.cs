using System;
using System.Diagnostics.SymbolStore;

class FIS
{

    // Function to find the number of
    // instances after compintion
    // Language : c#
    //hackerrank finalInstances(int instances, int[] averageUtil)
    //finalInstances(int instances, List<int> averageUtil)
    static void finalInstances(int instances, List<int> averageUtil)
    {

        //int instancesLimit = 2 * (10 * *8);
        var instancesCopy = instances;
        int i = 0;
        while (i < averageUtil.Count)
        {

            var util = averageUtil[i];
            if (util < 25)
            {
                if (instancesCopy > 1)
                {
                    Console.WriteLine(Math.Ceiling(instancesCopy / 2.0M));
                    instancesCopy = Convert.ToInt16(Math.Ceiling(instancesCopy / 2.0M));

                    i += 10;
                }
            }
            else if (util > 60)
            {
                var doubled = instancesCopy * 2;
                if (doubled < Math.Pow(10,8))
                {
                    instancesCopy = doubled;

                    i += 10;
                }
            }
            i++;
        }
        Console.WriteLine(instancesCopy);

    }

            // Driver Code
            static void Main()
    {
        int instances = 5;

        int[] arr = {25, 23, 1, 2, 3, 4, 5,
        6, 7, 8, 9, 10, 76, 80};
        List<int> numberList = new List<int>();
        numberList.Add(30);
        numberList.Add(5);
        numberList.Add(4);
        numberList.Add(8);
        numberList.Add(19);
        numberList.Add(89);
        //numberList.Add(5);
        //numberList.Add(6);
        //numberList.Add(7);
        //numberList.Add(8);
        //numberList.Add(9);
        //numberList.Add(10);
        //numberList.Add(76);
        //numberList.Add(80);
        //numberList.Add(25);
        //numberList.Add(23);
        //numberList.Add(1);
        //numberList.Add(2);
        //numberList.Add(3);
        //numberList.Add(4);
        //numberList.Add(5);
        //numberList.Add(6);
        //numberList.Add(7);
        //numberList.Add(8);
        //numberList.Add(9);
        //numberList.Add(10);
        //numberList.Add(76);
        //numberList.Add(80);
        // Function Call
        finalInstances(instances, numberList);
    }
}