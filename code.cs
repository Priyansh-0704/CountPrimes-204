public class Solution {
    public int CountPrimes(int n) {
        bool[] isNotPrime = new bool[n]; // creating an array of booleans currebntly initialized all to false
        int count = 0; // count variable to strore the number of prime numbers
        for(int i = 2; i < n; i++)
        {
            // loop starting from 2 to check if isNotPrime is false for current number
            if(isNotPrime[i] == false)
            {
                // if yes, that means the current number is a prime number, so count++
                count++;
                for(int j = i * 2; j < n; j += i)
                {
                    // now discard all the multiples of the current number less than n as they can't be prime numbers
                    isNotPrime[j] = true;
                }
            }
        }
        return count;
    }
}
