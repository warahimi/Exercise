using System;

namespace Exercise // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] num = { 100,10,9,9,9,9,9,9,9,999,80};
            //Console.WriteLine("Largest: "+ Largest(num));
            //Console.WriteLine("Second Largest: "+ SecontLargest(num));
            //Console.WriteLine("Second Largest: "+ SecontLargest2(num));
            //Console.WriteLine("Second Largest: "+ SecontLargest3(num));
            //Console.WriteLine("IsSorted: "+ IsSorted(num));
            //Console.WriteLine("IsSorted: "+ IsSorted2(num));
            //Console.WriteLine("IsSorted: "+ IsArraySorted(num));

            //int[] num = { 1, 2, 3, 4, 5, 6, 7, 8 };
            //foreach (var x in num)
            //{
            //    Console.Write(x + " ");
            //}
            //Console.WriteLine();

            //rotateArrayKTimes2(num, 9);

            //foreach(var x in num)
            //{
            //    Console.Write(x + " ");
            //}


            //int[] num = {1,0,4,2, 3, 0,0,45, 6, 7, 8};
            //foreach (var x in num)
            //{
            //    Console.Write(x + " ");
            //}
            //Console.WriteLine();
            //moverZerosToEnd3(num);
            //foreach (var x in num)
            //{
            //    Console.Write(x + " ");
            //}

            //int[] arr1 = { 1, 1, 2, 3, 4, 5 };
            //int[] arr2 = {1, 2, 3, 4,4,4,4, 5,5,5 ,6 };

            //int[] union = Union(arr1, arr2);
            //foreach (int x in union)
            //    Console.Write(x + " ");
            //Console.WriteLine();
            //int[] union2 = Union2(arr1, arr2);
            //foreach (int x in union2)
            //    Console.Write(x + " ");
            //Console.WriteLine();
            //int[] union3 = Union3(arr1, arr2);
            //foreach (int x in union2)
            //Console.Write(x + " ");
            //int[] num = { 1, 2, 2, 2, 3, 3, 3, 3, 3, 3, 3, 4, 5, 5, 5, 6, 7, 7 };
            //removeDup2(num);
            //foreach (var i in num)
            //{
            //    Console.Write(i + " ");
            //}

            //int[] arr1 = { 1, 4, 7, 8, 99, 122, 777, 888 };
            //int[] arr2 = { 1,2, 3, 4, 4, 5, 6, 7, 8, 9, 19, 123, 777, 999 };
            //int[] arr3 = mergeSortedArrays(arr1, arr2);

            //foreach(int i in arr3)
            //{
            //    Console.Write(i + " ");
            //}

            //int[] a = { 1, 2, 3,3, 4, 5, 6 ,12};
            //int[] b = { 1, 3,3 ,5, 7, 8, 9, 10, 11, 12};
            //int[] result = intersection2(a, b);
            //foreach(int i in result)
            //{
            //    Console.Write(i + " ");
            //}

            //int[] num = { 1, 1, 2, 3, 3,30, 4, 4, 2, 9 ,9};
            //Console.WriteLine(findTheUniqueElement2(num));
            ////Console.WriteLine(1^2^2^1);
            ///
            //int[] num = {8, 1, 4, 7, 2, 9};
            //Console.WriteLine(twoSum(num, 10));

            //int[] num = { 2, 1, 2, 2, 1, 1, 0, 0, 0, 2, 1 };
            //sortT3(num);
            //foreach (int x in num)
            //{
            //    Console.Write(x + " ");
            //}
            //int[] arr = {5,5,5, 2, 3, 4, 3, 3, 5, 3,5,5,5};
            //Console.WriteLine(MajorityElement2(arr));
            //int[] arr = {2,3,5, -2,-4,3, 1, -2, -5, 2, -4,4,6,-7 ,1,-1,-4,-9,7,8};
            //rearrangeBySign3(arr);
            //foreach (int x in arr)
            //{
            //    Console.Write(x + " ");
            //}
            //int n = 17;
            //Console.WriteLine(fib(n));
            //long[] memo = new long[n+1];
            //Console.WriteLine(fib2(n, memo));
            //Console.WriteLine(fib_bottomUp(n));
            //Console.WriteLine(fib4(n));

            //int n = 66;
            //Console.WriteLine(nSum(n));
            //Console.WriteLine(nSum2(n));
            //Console.WriteLine(nSum3(n));
            //int[] arr = new int[n + 1];
            //Console.WriteLine(nSum4(n, arr));
            //int n = 10;
            //Console.WriteLine(NumberOfWaysToGetToTopOfStairs(n));
            //int n = 20;
            //foreach(var x in nFib(n))
            //    Console.Write(x + " ");
            //Console.WriteLine();    
            //nFib2(n);
            //Console.WriteLine();
            //for(int i = 1; i<= n; i++)
            //{
            //    Console.Write(nFibRec(i) + " ");
            //}
            //Console.WriteLine();
            //int[] memo = new int[n + 1];
            //Console.WriteLine(nFibRec2(n, memo));
            //Console.WriteLine(nthFib(n));
            //Console.WriteLine(nthFib2Rec(n));
            //Console.WriteLine(nSumm(5));
            //Console.WriteLine(nSummRec(5));
            int n = 10;
            //Console.WriteLine(climbingStairs3Steps(n));
            //Console.WriteLine(climbingStairs3Steps2(n));
            //Console.WriteLine(findStep(n));
            Console.WriteLine(ClimbingStairsKSteps(n, 4));
            Console.WriteLine(climbStairs4Steps(n));
            Console.WriteLine(climbStairs4Steps2(n));
            Console.WriteLine(climbStairs4Steps3(n));
            //Console.WriteLine(cl(n, 4));
        }

        public static int climbStairs4Steps3(int n)
        {
            if (n == 0)
                return 1;
            else if (n < 0)
                return 0;
            else
                return climbStairs4Steps(n - 4) +
                    climbStairs4Steps(n - 3) +
                    climbStairs4Steps(n - 2) +
                    climbStairs4Steps(n - 1);
        }

        public static int climbStairs4Steps2(int n)
        {
            if (n == 0) return 1;
            if (n == 1) return 1;
            if (n == 2) return 2;
            if (n == 3) return 4;

            int a = 1;
            int b = 1;
            int c = 2;
            int d = 4;
            int r = 0;

            for(int i = 4; i <= n; i++) 
            { 
                r = a + b + c + d;
                a = b;
                b = c; 
                c = d; 
                d = r;
            }
            return r;
        }

        public static int climbStairs4Steps(int n)
        {
            if (n == 0) return 1;
            if (n == 1) return 1;
            if (n == 2) return 2;
            if (n == 3) return 4;

            int[] dp = new int[n+1];

            dp[0] = 1;
            dp[1] = 1;
            dp[2] = 2;
            dp[3] = 4;
            for(int i = 4; i <= n; i++)
            {
                dp[i] = dp[i-1] + dp[i-2] + dp[i-3] + dp[i-4];
            }
            return dp[n];
        }
        public static int cl(int n, int k)
        {
            if(n == 0) return 1;
            int[] dp = new int[n + 1];
            dp[0] = 1;

            for(int i = 1; i <= n; i++) 
            {
                for(int j = 1; j<=k && j<=i;j++)
                {
                    dp[i] += dp[i-j];
                }
            }

            return dp[n];
        }

        /// <summary>
        /// Calculates the number of ways to climb a staircase of n steps, taking 1 to k steps at a time.
        /// </summary>
        /// <param name="n">Total number of steps in the staircase.</param>
        /// <param name="k">Maximum number of steps that can be taken at once.</param>
        /// <returns>The number of unique ways to climb the staircase.</returns>
        public static int ClimbingStairsKSteps(int n, int k)
        {
            // Base case: If there are no steps, there's only one way to be at the base (not climb at all).
            if (n == 0) return 1;

            // Array to store the number of ways to climb to each step.
            int[] dp = new int[n + 1];

            // Initialize the first step as there's only one way to be at the ground.
            dp[0] = 1;

            // Iterate over each step in the staircase.
            for (int i = 1; i <= n; i++)
            {
                // For each step, we consider the last k steps to calculate the number of ways 
                // to reach the current step. The inner loop sums up the ways to reach the previous 
                // k steps, from which you can jump to the current step.
                // dp[i] = dp[i-1] + dp[i-2] + dp[i-3]+ ..... + dp[i-k]
                // j <= j , we dont want j get begger than i, because dp[i-j] will give negative index
                for (int j = 1; j <= k && j <= i; j++)
                {
                    dp[i] += dp[i - j];
                }
            }

            // Return the total number of ways to reach the nth step.
            return dp[n];
        }


        // Returns count of ways to reach
        // n-th stair using 1 or 2 or 3 steps.
        public static int findStep(int n) // O(3^n)
        {
            if (n == 0)
                return 1;
            else if (n < 0)
                return 0;

            else
                return findStep(n - 3) + findStep(n - 2)
                    + findStep(n - 1);
        }
        public static int climbingStairs3Steps2(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            if (n == 2) return 2;

            int a = 1;  // ways to climb 1 step
            int b = 1;  // ways to climb 1 step
            int c = 2;  // ways to climb 1 or 2 steps

            for (int i = 3; i <= n; i++)
            {
                int r = a + b + c;
                a = b;
                b = c;
                c = r;
            }
            return c;
        }
        public static int climbingStairs3Steps(int n)
        {
            int[] arr = new int[n+1];
            arr[0] = 1;
            arr[1] = 1;
            arr[2] = 2;
            for(int i = 3; i<= n; i++)
            {
                arr[i] = arr[i-1] + arr[i-2] + arr[i-3];
            }
            return arr[n];

        }
        public static int nSummRec(int n)
        {
            if (n == 0)
                return 0;
            return n + nSummRec(n- 1);
        }
        public static int nSumm(int n)
        {
            int sum = 0;
            int a = 1;
            for(int i = 0; i <= n; i++)
            {
                sum += i;
            }
            return sum;
        }
        public static int[] nFib(int n)
        {
            
            if(n == 1)
                return new int[1] { 1 };
            if(n == 2)
                return new int[2] { 1,1 };
            int[] fib = new int[n];
            fib[0] = 1;
            fib[1] = 1;

            for(int i = 2; i < fib.Length;i++)
            {
                fib[i] = fib[i - 1] + fib[i-2];
            }

            return fib;
        }
        public static void nFib2(int n)
        {
            int a = 1;
            int b = 1;
            if(n == 1)
            {
                Console.Write(a);
            }
            else if(n == 2)
            {
                Console.Write(a + " " + b);
            }
            else
            {
                Console.Write(a + " " + b +" ");
                for(int i = 2; i < n;i++)
                {
                    int c = a + b;
                    Console.Write(c + " ");
                    a = b;
                    b = c;
                }
            }
        }
        public static int nFibRec2(int n, int[] memo)
        {
            int res;
            if (memo[n] != 0)
            {
                return memo[n];
            }
            if(n == 1 || n ==2)
            {
                res = 1;
            }
            else
            {
                res = nFibRec2(n-1,memo) + nFibRec2(n-2, memo);
            }
            memo[n] = res;
            return res;
        }
        public static int nthFib2Rec(int n)
        {
            if(n <= 2)
                return 1;
            return nthFib2Rec(n - 1) + nthFib2Rec(n - 2);
        }
        public static int nthFib(int n)
        {
            if (n == 1 || n == 2)
                return 1;
            int a = 1; 
            int b = 1;
            int c = 0;
            for(int i = 2; i< n; i++)
            {
                c = a + b;
                a = b; b = c;
            }
            return c;
        }
        public static int nFibRec(int n)
        {
            if(n <= 1) return n;
            return nFibRec(n - 1) + nFibRec(n-2);
        }
        public static int NumberOfWaysToGetToTopOfStairs(int n)
        {
            if (n == 0)
                n++;
            int[] arr = new int[n + 1];
            // base cases
            arr[0] = 1;
            arr[1] = 1;
            for(int i = 2; i <= n;i++)
            {
                arr[i] = arr[i-1] + arr[i-2];
            }
            return arr[n];   
        }

        //using Recursion and DP
        public static int nSum4(int n, int[] arr)
        {
            int sum = 0;
            if (arr[n] != 0)
            {
                sum = arr[n];
            }
            else if (n == 0)
            {
                sum = 0;
            }
            arr[n] = sum;
            return nSum3(n - 1) + n;
        }
        // Using Recursion
        public static int nSum3(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            return nSum3(n - 1) + n;
        }
        // Using DP
        public static int nSum2(int n)
        {
            int[] arr = new int[n + 1];
            arr[0] = 0;
            for (int i = 1; i <= n; i++)
            {
                arr[i] = arr[i - 1] + i;
            }
            return arr[n];
        }
        public static int nSum(int n)
        {
            int sum = 0;
            for (int i = 0; i <= n; i++)
            {
                sum += i;
            }
            return sum;
        }
        public static void printFib(int n)
        {
            int a = 1, b = 1;
            int r = 0;
            if (n == 1)
            {
                Console.Write(1);
            }
            else if (n == 2)
            {
                Console.Write(1 + " ");
                Console.Write(1 + " ");
            }
            else
            {
                Console.Write(1 + " ");
                Console.Write(1 + " ");
                for (int i = 3; i <= n; i++)
                {
                    r = a + b;
                    Console.Write(r + " ");
                    a = b;
                    b = r;
                }
            }
        }
        public static int fib4(int n)
        {
            int result = 0;
            if (n == 1 || n == 2)
            {
                result = 1;
            }
            else
            {
                int a = 1; int b = 1;
                for (int i = 3; i <= n; i++)
                {
                    result = (a + b);
                    a = b;
                    b = result;
                }
            }
            return result;
        }
        public static long fib_bottomUp(int n)
        {
            if (n == 1 || n == 2)
            {
                return 1;
            }
            int[] memo = new int[n + 1];
            memo[1] = 1;
            memo[2] = 1;
            for (int i = 3; i < memo.Length; i++)
            {
                memo[i] = memo[i - 1] + memo[i - 2];
            }
            return memo[n];
        }
        public static long fib2(int n, long[] memo)
        {
            long result = 0;
            if (memo[n] != 0)
            {
                result = memo[n];
            }
            else if (n == 1 || n == 2)
            {
                result = 1;
            }
            else
            {
                result = fib2(n - 1, memo) + fib2(n - 2, memo);
            }
            memo[n] = result;
            return result;
        }
        public static long fib(int n)
        {
            long result;
            if (n == 1 || n == 2)
            {
                result = 1;
            }
            else
            {
                result = fib(n - 1) + fib(n - 2);
            }
            return result;
        }
        public static void rearrangeBySign3(int[] arr)
        {
            List<int> pos = new List<int>();
            List<int> neg = new List<int>();
            foreach (int x in arr)
            {
                if (x > 0)
                {
                    pos.Add(x);
                }
                else
                {
                    neg.Add(x);
                }
            }
            int index = 0;
            for (int i = 0; i < Math.Min(pos.Count, neg.Count); i++)
            {
                arr[index++] = pos[i];
                arr[index++] = neg[i];
            }
            if (pos.Count > neg.Count)
            {
                for (int i = neg.Count; i < pos.Count; i++)
                {
                    arr[index++] = pos[i];
                }
            }
            else if (neg.Count > pos.Count)
            {
                for (int i = pos.Count; i < neg.Count; i++)
                {
                    arr[index++] = neg[i];
                }
            }
        }
        public static int[] rearrangeBySign2(int[] arr)
        {
            int[] answer = new int[arr.Length];
            int pInd = 0;
            int nInd = 1;
            foreach (int x in arr)
            {
                if (x > 0)
                {
                    answer[pInd] = x;
                    pInd += 2;
                }
                else
                {
                    answer[nInd] = x;
                    nInd += 2;
                }
            }
            return answer;
        }
        public static void rearrangeBySign(int[] arr)
        {
            if (arr.Length % 2 != 0)
                return;
            List<int> positives = new List<int>();
            List<int> negatives = new List<int>();
            foreach (int i in arr)
            {
                if (i > 0)
                    positives.Add(i);
                else
                    negatives.Add(i);
            }
            if (negatives.Count != positives.Count) return;

            int indx = 0;
            foreach (int i in positives)
            {
                arr[indx] = i;
                indx += 2;
            }
            indx = 1;
            foreach (int i in negatives)
            {
                arr[indx] = i;
                indx += 2;
            }
        }
        public static int MajorityElement2(int[] num)
        {
            int candedate = 0;
            int count = 0;
            foreach (var item in num)
            {
                if (count == 0)
                {
                    candedate = item;
                }
                if (candedate == item)
                {
                    count++;
                }
                else
                {
                    count--;
                }
            }
            count = 0;
            foreach (var item in num)
            {
                if (item == candedate)
                    count++;
            }
            if (count > num.Length / 2)
                return candedate;
            return -1;
        }

        public static int MajorityElement(int[] arr)
        {

            for (int i = 0; i < arr.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                        if (count > arr.Length / 2)
                        {
                            return arr[i];
                        }
                    }
                }
            }
            return -1;
        }
        public static void sortT3(int[] arr)
        {
            int l = 0, m = 0, h = arr.Length - 1;

            while (m <= h)
            {
                if (arr[m] == 0)
                {
                    swap(arr, l, m);
                    l++;
                    m++;
                }
                if (arr[m] == 1)
                {
                    m++;
                }
                if (arr[m] == 2)
                {
                    swap(arr, m, h);
                    h--;
                }
            }
        }
        public static void swap(int[] arr, int aIndex, int bIndex)
        {
            int temp = arr[aIndex];
            arr[aIndex] = arr[bIndex];
            arr[bIndex] = temp;
        }

        public static void sortT(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }
        public static void sortT2(int[] arr)
        {
            int ones = 0, zeros = 0, twos = 0;

            foreach (int x in arr)
            {
                switch (x)
                {
                    case 0:
                        zeros++;
                        break;
                    case 1:
                        ones++;
                        break;
                    case 2:
                        twos++;
                        break;
                }
            }
            int index = 0;
            for (int i = 0; i < zeros; i++)
            {
                arr[index++] = 0;
            }
            for (int i = 0; i < ones; i++)
            {
                arr[index++] = 1;
            }
            for (int i = 0; i < twos; i++)
            {
                arr[index++] = 2;
            }
        }

        public static bool twoSum(int[] arr, int target)
        {
            int left = 0;
            int right = arr.Length - 1;

            Array.Sort(arr);

            while (left < right)
            {
                if (arr[left] + arr[right] == target)
                {
                    return true;
                }
                else if (arr[left] + arr[right] < target)
                {
                    left++;
                }
                else if (arr[left] + arr[right] > target)
                {
                    right--;
                }
            }
            return false;
        }
        public static long findTheUniqueElement(int[] arr)
        {
            int unique = -1;
            Dictionary<long, int> dict = new Dictionary<long, int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (!dict.ContainsKey(arr[i]))
                {
                    dict.Add(arr[i], 1);
                }
                else
                {
                    dict[arr[i]]++;
                }
            }
            foreach (var x in dict)
            {
                if (x.Value == 1)
                    return x.Key;
            }
            return -1;
        }
        public static long findTheUniqueElement2(int[] arr)
        {
            long xor = 0;
            foreach (var x in arr)
                xor = xor ^ x;
            return xor;
        }
        public static int[] intersection2(int[] a, int[] b)
        {
            int[] visited = new int[b.Length];
            List<int> list = new List<int>();
            for (int i = 0; i < visited.Length; i++)
            {
                visited[i] = 0;
            }
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < b.Length; j++)
                {
                    if (a[i] == b[j] && visited[j] == 0)
                    {
                        list.Add(a[i]);
                        visited[j] = 1;
                        break;
                    }
                }
            }
            return list.ToArray();
        }
        public static int[] SortedArrayIntersection(int[] arr1, int[] arr2)
        {
            List<int> intersectionList = new List<int>();
            int i = 0, j = 0;

            // Find the common elements by comparing elements at each pointer
            while (i < arr1.Length && j < arr2.Length)
            {
                if (arr1[i] < arr2[j])
                {
                    i++;
                }
                else if (arr2[j] < arr1[i])
                {
                    j++;
                }
                else // If elements are equal, add to the intersection and move both pointers
                {
                    intersectionList.Add(arr1[i]);
                    i++;
                    j++;
                }
            }

            // Convert the List<int> to an array and return
            return intersectionList.ToArray();
        }
        public static int[] intersection(int[] a, int[] b)
        {
            int n1 = a.Length;
            int n2 = b.Length;
            int i = 0;
            int j = 0;
            List<int> list = new List<int>();

            while (i < n1 && j < n2)
            {
                if (a[i] == b[j])
                {
                    list.Add(a[i]);
                    i++;
                    j++;
                }
                else if (a[i] < b[j])
                {
                    i++;
                }
                else if (b[j] < a[i])
                {
                    j++;
                }
            }
            return list.ToArray();
        }
        public static int[] mergeSortedArrays(int[] arr1, int[] arr2)
        {
            List<int> list = new List<int>();
            int i = 0;
            int j = 0;

            while (i < arr1.Length && j < arr2.Length)
            {
                if (arr1[i] <= arr2[j])
                {
                    list.Add(arr1[i]);
                    i++;
                }
                else
                {
                    list.Add(arr2[j]);
                    j++;
                }
            }
            while (i < arr1.Length)
            {
                list.Add(arr1[i]);
                i++;
            }
            while (j < arr2.Length)
            {
                list.Add(arr2[j]);
                j++;
            }
            return list.ToArray();
        }
        public static void removeDup(int[] arr)
        {
            int i = 0;
            for (int j = 0; j < arr.Length; j++)
            {
                if (arr[i] != arr[j])
                {
                    arr[i + 1] = arr[j];
                    i++;
                }
            }
        }
        public static void removeDup2(int[] arr)
        {
            HashSet<int> set = new HashSet<int>();
            int i = 0;
            set.Add(arr[i]);
            for (int j = 1; j < arr.Length; j++)
            {
                if (!set.Contains(arr[j]))
                {
                    arr[i + 1] = arr[j];
                    set.Add(arr[j]);
                    i++;
                }
            }
        }
        public static int SecontLargest(int[] arr)
        {
            if (arr.Length < 3)
            {
                return -1;
            }
            int secondLargest = int.MinValue;
            Array.Sort(arr);
            int largest = arr[arr.Length - 1];
            for (int i = arr.Length - 2; i >= 0; i--)
            {
                if (arr[i] != largest)
                {
                    secondLargest = arr[i];
                    break;
                }
            }
            if (secondLargest == int.MinValue)
                return -1;
            return secondLargest;
        }

        public static int SecontLargest2(int[] arr)
        {
            if (arr.Length < 3)
            {
                return -1;
            }
            int secondLargest = int.MinValue;

            int largest = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > largest)
                {
                    secondLargest = largest;
                    largest = arr[i];
                }
            }
            if (secondLargest == int.MinValue)
                return -1;
            return secondLargest;
        }
        public static int SecontLargest3(int[] arr)
        {
            if (arr.Length < 3)
            {
                return -1;
            }
            int secondLargest = int.MinValue;

            int largest = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > largest)
                {
                    largest = arr[i];
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > secondLargest && arr[i] != largest)
                {
                    secondLargest = arr[i];
                }
            }
            if (secondLargest == int.MinValue)
                return -1;
            return secondLargest;
        }
        public static int Largest(int[] arr)
        {
            int largest = int.MinValue;
            foreach (int item in arr)
            {
                if (item > largest)
                    largest = item;
            }
            return largest;
        }

        public static bool IsSorted(int[] arr)
        {
            if (arr.Length <= 1)
                return true;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i - 1] > arr[i])
                    return false;
            }
            return true;
        }
        public static bool IsSorted2(int[] arr)
        {
            if (arr == null)
                throw new ArgumentNullException(nameof(arr));
            if (arr.Length <= 1)
                return true;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] >= arr[i - 1])
                {

                }
                else
                {
                    return false;
                }
            }
            return true;
        }
        public static bool IsArraySorted(int[] array)
        {
            if (array == null || array.Length == 0)
            {
                return true;
            }

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i - 1] > array[i])
                {
                    return false;
                }
            }

            return true;
        }

        public static void rotateArray(int[] arr)
        {
            if (arr == null) throw new ArgumentNullException();
            if (arr.Length <= 1)
                return;
            int firstElement = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                arr[i - 1] = arr[i];
            }
            arr[arr.Length - 1] = firstElement;
        }

        public static void rotateArrayKTimes(int[] arr, int k)
        {
            if (arr == null)
                throw new ArgumentNullException();
            if (k < 1 || arr.Length <= 1)
                return;
            k = k % arr.Length;

            int[] temp = new int[k];
            for (int i = 0; i < k; i++)
            {
                temp[i] = arr[i];
            }
            for (int i = k; i < arr.Length; i++)
            {
                arr[i - k] = arr[i];
            }
            for (int i = arr.Length - k; i < arr.Length; i++)
            {
                arr[i] = temp[i - (arr.Length - k)];
            }
        }
        public static void rotateArrayKTimes2(int[] arr, int k)
        {
            if (arr == null)
                throw new ArgumentNullException();
            if (k < 1 || arr.Length <= 1)
                return;
            k = k % arr.Length;
            if (k == 0)
                return;
            reverse(arr, 0, k - 1);
            reverse(arr, k, arr.Length - 1);
            reverse(arr, 0, arr.Length - 1);
        }
        public static void reverse(int[] arr, int start, int end)
        {

            if (start < 0 || end >= arr.Length || start > end)
            {
                throw new ArgumentOutOfRangeException("Invalid start or end indices.");
            }

            int temp;
            while (start <= end)
            {
                temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;
                start++;
                end--;
            }
        }

        public static void moverZerosToEnd(int[] arr)
        {
            if (arr.Length <= 1 || arr == null) return;

            List<int> temp = new List<int>();
            foreach (int item in arr)
            {
                if (item != 0)
                    temp.Add(item);
            }
            int index = 0;
            foreach (int x in temp)
            {
                arr[index++] = x;
            }
            for (int i = index; i < arr.Length; i++)
            {
                arr[i] = 0;
            }
        }
        public static void moverZerosToEnd2(int[] arr)
        {
            int n = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                {
                    n++;
                }
                else
                {
                    arr[i - n] = arr[i];
                }
            }
            for (int i = arr.Length - n; i < arr.Length; i++)
            {
                arr[i] = 0;
            }
        }

        public static void moverZerosToEnd3(int[] arr)
        {
            int j = -1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                {
                    j = i;
                    break;
                }
            }
            for (int i = j + 1; i < arr.Length; i++)
            {
                if (arr[i] != 0)
                {
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                    j++;
                }
            }
        }

        public static int[] Union(int[] arr1, int[] arr2)
        {


            HashSet<int> set = new HashSet<int>();

            foreach (int item in arr1)
                set.Add(item);
            foreach (int item in arr2)
                set.Add(item);
            int[] union = new int[set.Count];
            int i = 0;
            foreach (int x in set)
            {
                union[i++] = x;
            }
            return union;
        }
        public static int[] Union2(int[] arr1, int[] arr2)
        {
            int n1 = arr1.Length;
            int n2 = arr2.Length;

            int i = 0;
            int j = 0;
            List<int> list = new List<int>();
            while (i < n1 && j < n2)
            {
                if (arr1[i] <= arr2[j])
                {
                    if (list.Count() == 0 || arr1[i] != list.Last())
                    {
                        list.Add(arr1[i]);
                    }
                    i++;
                }
                else
                {
                    if (list.Count() == 0 || arr2[j] != list.Last())
                    {
                        list.Add(arr2[j]);

                    }
                    j++;
                }
            }
            while (i < n1)
            {

                if (list.Count() == 0 || arr1[i] != list.Last())
                {
                    list.Add(arr1[i]);
                }
                i++;
            }
            while (j < n2)
            {
                if (list.Count() == 0 || arr2[j] != list.Last())
                {
                    list.Add(arr2[j]);

                }
                j++;
            }
            int[] union = new int[list.Count];
            int k = 0;
            foreach (int x in list)
            {
                union[k++] = x;
            }
            return union;
        }
        public static int[] Union3(int[] arr1, int[] arr2)
        {
            List<int> unionList = new List<int>();
            int i = 0, j = 0;

            // Merge the arrays into the unionList while maintaining the sorted order
            while (i < arr1.Length && j < arr2.Length)
            {
                if (arr1[i] < arr2[j])
                {
                    unionList.Add(arr1[i]);
                    i++;
                }
                else if (arr2[j] < arr1[i])
                {
                    unionList.Add(arr2[j]);
                    j++;
                }
                else // If elements are equal, add only once and move both pointers
                {
                    unionList.Add(arr1[i]);
                    i++;
                    j++;
                }
            }

            // Add remaining elements from arr1 and arr2 (if any)
            while (i < arr1.Length)
            {
                unionList.Add(arr1[i]);
                i++;
            }

            while (j < arr2.Length)
            {
                unionList.Add(arr2[j]);
                j++;
            }

            // Convert the List<int> to an array and return
            return unionList.ToArray();
        }
    }
}