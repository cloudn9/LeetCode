namespace Challenges.Easy
{
    public static class ClimbStairs
    {
        public static int Solution(int n)
        {
            // If n is less than or equal to 3, we return n.
            // This is because for n = 1 or n = 2, the number of ways to climb the stairs is equal to n.
            // And for n = 3, there are 3 ways: 1+1+1, 1+2, and 2+1.
            if (n <= 3)
            {
                return n;
            }

            int steps = 0;
            int pp_step = 1;
            int p_step = 2;
            for (int i = 3; i < n + 1; i++)
            {
                steps = p_step + pp_step;
                pp_step = p_step;
                p_step = steps;
            }

            return steps;
        }
    }
}
