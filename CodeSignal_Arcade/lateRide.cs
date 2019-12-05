int lateRide(int n) {
    
    TimeSpan timeSpanFromInput = TimeSpan.FromMinutes(n);
    
    string timeSpan = timeSpanFromInput.ToString();
    
    timeSpan = timeSpan.Replace(":", "");
    
    int timeSpanDigits = Int32.Parse(timeSpan);
    
    Console.WriteLine(timeSpanDigits);
    
    int sum = 0;
    
    while (timeSpanDigits != 0) {
    sum += timeSpanDigits % 10;
    timeSpanDigits /= 10;
    }

    return sum;
}
