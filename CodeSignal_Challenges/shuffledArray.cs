
public class Shuffled
{

    public int[] shuffledArray(int[] shuffled)
    {

        Array.Sort(shuffled);
        int sum= arrayToList.Sum();

        List<int> arrayToList = shuffled.ToList();

        for (int i = 0; i < arrayToList.Count; i++)
        {
            if ((sum - arrayToList[i]) == arrayToList[i])
            {
                arrayToList.Remove(arrayToList[i]);
                break;
            }
        }

        return arrayToList.ToArray();
    }
}

static void Main()


