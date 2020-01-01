object makeArrayConsecutive(int[] s) =>
    Enumerable.Range(s.Min(), s.Max() - s.Min()).Except(s);
