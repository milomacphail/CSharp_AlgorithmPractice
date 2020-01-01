char fractionComparison(int[] a, int[] b) {
    if (a[0] * b[1] == b[0] * a[1])
    {
        return '=';
    }
    else if(a[0] * b[1] > b[0] * a[1])
    {
        return '>';
    }
    else return '<';
}