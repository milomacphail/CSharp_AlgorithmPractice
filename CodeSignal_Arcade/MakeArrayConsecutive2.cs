int makeArrayConsecutive2(int[] statues)
{

    Array.Sort(statues);

    int count = 0;

    for (int index = statues.Min(); index < statues.Max(); index++)
    {
        if (statues.Contains(index) == false)
        {
            count++;
        }
    }
    return count;

}