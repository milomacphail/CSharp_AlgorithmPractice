class Solution {

    static int jumpingOnClouds(int[] c) {

        int jumps = 0;
        int position = 0;

        while(true)
        
        if(position + 2 <= c.Length && c[position + 2] == 0)
        {
            position += 2;
            jumps++;
        }
                
        else
        {
            position++;
            jumps++;
        }       
            return jumps;
    }
}
