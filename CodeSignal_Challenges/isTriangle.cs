bool triangleExistence(int[] sides)
{
    Array.Sort(sides);

    if ((sides[0] + sides[1]) >= sides[2])
    {
        return true;
    }

    return false;
}