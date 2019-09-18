using System;
using System.Linq;

class Difference {
    private int[] elements;
    public int maximumDifference;

    public Difference (int[] elements)
    {
        this.elements = elements;
    }

    int maxDifference = 0;
    int absoluteDifference = 0;

    public void computeDifference()
    {
        for(int i = 0; i < elements.Length; i++)
        {
            for(int j = 0; j<elements.Length; j++)
            {
                absoluteDifference = Math.Abs(elements[i] - elements[j]);

                if (absoluteDifference > maxDifference)
                {
                    maxDifference = absoluteDifference;
                }
            }
            maximumDifference = maxDifference;
        }
    }

}
class Solution {
    static void Main(string[] args) {
        Convert.ToInt32(Console.ReadLine());
        
        int[] a = Console.ReadLine().Split(' ').Select(x=>Convert.ToInt32(x)).ToArray();
        
        Difference d = new Difference(a);
        
        d.computeDifference();
        
        Console.Write(d.maximumDifference);
    }
}