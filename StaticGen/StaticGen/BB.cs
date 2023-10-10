//using System.Globalization;
//using System.Text.RegularExpressions;
//using System.Xml;

//public class TwoSum
//{
//    public class Bloomberg
//    {

//    }
//    public class Problem
//    {
//        /**
//           Two Sum
//           Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
//            You may assume that each input would have exactly one solution, and you may not use the same element twice.
//            You can return the answer in any order.
//        **/
//    }
//    public class Example
//    {
//        /**
//            Example 1:

//             Input: nums = [2,7,11,15], target = 9
//             Output: [0,1]
//             Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
//             Example 2:

//             Input: nums = [3,2,4], target = 6
//             Output: [1,2]
//             Example 3:

//             Input: nums = [3,3], target = 6
//             Output: [0,1]
//         **/
//    }
//    public class ClarifyingQuestions
//    {
//        /**
//           1 Can you provide an example input and output for this problem?

//            2 Are the integers in the array guaranteed to be unique?

//            3 Can the array be empty or contain only one element?

//            4 Can the integers in the array be negative or zero?

//            5 Can the target integer be negative or zero?

//            6 What is the expected time complexity of the solution?

//            7 Are there any space complexity requirements for the solution?

//            8 Can I modify the input array?
//        **/
//    }
//    public class DiscussSolutions
//    {
//        /**
//       Brute Force: The simplest approach is to use two nested loops to check all possible pairs 
//       of numbers in the array and see if they add up to the target. This approach has a time complexity of O(n^2).

//       Use: Hash Table: We can use a hash table to store each number in the array along with its index. 
//       Then, we can iterate through the array and check if the difference between the target and the
//        current number is already in the hash table. 
//        This approach has a time complexity of O(n) and a space complexity of O(n).

//       Sorting: We can sort the array and then use two pointers, one at the beginning and one at the end, 
//       to iterate through the array and find the pair that adds up to the target. This approach has a time 
//       complexity of O(nlogn) due to the sorting operation.

//       Two-pass Hash Table: We can use a hash table to store each number in the array along with its index, 
//       and then iterate through the array again to find the complement of each number. 
//       This approach also has a time complexity of O(n) and a space complexity of O(n), 
//       but may be slower than the single-pass hash table approach due to the need for two iterations.
//       **/

//    }
//    public class BruteForce
//    {
//        /**
//        Algo
//        1 Iterate through each element in the array.
//        2 For each element, iterate through the remaining elements in the array.
//        3 Check if the sum of the current element and the remaining element equals the target.
//        4 If it does, return the indices of the two elements.
//        **/
//        public int[] TwoSum(int[] nums, int target)
//        {
//            // Iterate over every possible pair of indices (i,j) where i<j.
//            for (int i = 0; i < nums.Length; i++)
//            {
//                for (int j = i + 1; j < nums.Length; j++)
//                {
//                    // Check if the sum of the numbers at indices i and j is equal to the target.
//                    if (nums[i] + nums[j] == target)
//                    {
//                        // If so, return the indices as an array.
//                        return new int[] { i, j };
//                    }
//                }
//            }
//            // If no two numbers in the array add up to the target, throw an exception.
//            throw new ArgumentException("No two sum solution");
//        }

//        /**
//        TC
//        Time complexity: O(n^2) because we iterate over every possible pair of indices (i,j) where i<j.
//        //Space complexity: O(1) because we use only constant additional space.
//        **/
//    }
//    public class Use
//    {
//        /**
//        Algo
//        **/
//        public int[] TwoSum(int[] nums, int target)
//        {
//            // Create a dictionary to store each number and its index in the array.
//            Dictionary<int, int> map = new Dictionary<int, int>();
//            // Iterate over the array.
//            for (int i = 0; i < nums.Length; i++)
//            {
//                // Calculate the complement of the current number with respect to the target.
//                int complement = target - nums[i];
//                // Check if the complement is already in the dictionary.
//                if (map.ContainsKey(complement))
//                {
//                    // If so, return the indices of the current number and its complement.
//                    return new int[] { map[complement], i };
//                }
//                // Add the current number and its index to the dictionary.
//                map[nums[i]] = i;
//            }
//            // If no two numbers in the array add up to the target, throw an exception.
//            throw new ArgumentException("No two sum solution");
//        }

//        /**
//       TC
//       Time complexity: O(n) because we iterate over the array once, and each dictionary 
//       lookup and insertion takes constant time on average.
//       Space complexity: O(n) because in the worst case, we need to store every number 
//       in the array and its index in the dictionary.
//       **/
//    }
//    public class Sorting
//    {
//        /**
//        Algo
//        **/
//        public int[] TwoSum(int[] nums, int target)
//        {
//            // Make a copy of the original array and sort it.
//            int[] sorted = (int[])nums.Clone();
//            Array.Sort(sorted);
//            // Initialize two pointers to the beginning and end of the sorted array.
//            int left = 0;
//            int right = sorted.Length - 1;
//            // Move the pointers inward until they meet or find a pair that adds up to the target.
//            while (left < right)
//            {
//                int sum = sorted[left] + sorted[right];
//                if (sum == target)
//                {
//                    // If a pair is found, find their indices in the original array and return them.
//                    int index1 = Array.IndexOf(nums, sorted[left]);
//                    int index2 = Array.IndexOf(nums, sorted[right], index1 + 1);
//                    return new int[] { index1, index2 };
//                }
//                else if (sum < target)
//                {
//                    // If the sum is less than the target, move the left pointer to the right.
//                    left++;
//                }
//                else
//                {
//                    // If the sum is greater than the target, move the right pointer to the left.
//                    right--;
//                }
//            }
//            // If no two numbers in the array add up to the target, throw an exception.
//            throw new ArgumentException("No two sum solution");
//        }

//        /**
//        TC
//        Time complexity: O(n log n) because we need to sort the array first, which takes O(n log n) time, 
//        and then we need to iterate over it once, which takes O(n) time.
//Space complexity: O(n) because we need to make a copy of the original array and sort it, which takes O(n) space.
//        **/

//    }

//    public class TwoPassHashTable
//    {
//        /**
//        Algo
//        **/
//        public int[] TwoSum(int[] nums, int target)
//        {
//            // Create a dictionary to store each number and its index in the array.
//            Dictionary<int, int> map = new Dictionary<int, int>();
//            // First pass: populate the dictionary with each number and its index.
//            for (int i = 0; i < nums.Length; i++)
//            {
//                map[nums[i]] = i;
//                // Second pass: check if each number's complement exists in the dictionary.
//                for (int i = 0; i < nums.Length; i++)
//                {
//                    int complement = target - nums[i];
//                    if (map.ContainsKey(complement) && map[complement] != i)
//                    {
//                        // If the complement exists in the dictionary and is not the same as the current number,
//                        // return the indices of the current number and its complement.
//                        return new int[] { i, map[complement] };
//                    }
//                }
//                // If no two numbers in the array add up to the target, throw an exception.
//                throw new ArgumentException("No two sum solution");
//            }

//            /**
//            TC
//            Time complexity: O(n) because we iterate over the array twice, and each dictionary lookup and 
//            insertion takes constant time on average.
//Space complexity: O(n) because we need to store every number in the array and its index in the dictionary.
//            **/
//        }
//    }
//}
//public class ThreeSum
//{
//    public class Bloomberg
//    {

//    }
//    public class Problem
//    {
//        /**
//           Given an integer array nums, return all the triplets [nums[i], nums[j], nums[k]] such that i != j, i != k, and j != k, and nums[i] + nums[j] + nums[k] == 0.
//        **/
//    }
//    public class Example
//    {
//        /**
//            Example 1:

//Input: nums = [-1,0,1,2,-1,-4]
//Output: [[-1,-1,2],[-1,0,1]]
//Explanation: 
//nums[0] + nums[1] + nums[2] = (-1) + 0 + 1 = 0.
//nums[1] + nums[2] + nums[4] = 0 + 1 + (-1) = 0.
//nums[0] + nums[3] + nums[4] = (-1) + 2 + (-1) = 0.
//The distinct triplets are [-1,0,1] and [-1,-1,2].
//Notice that the order of the output and the order of the triplets does not matter.
//Example 2:

//Input: nums = [0,1,1]
//Output: []
//Explanation: The only possible triplet does not sum up to 0.
//Example 3:

//Input: nums = [0,0,0]
//Output: [[0,0,0]]
//Explanation: The only possible triplet sums up to 0.
//         **/
//    }
//    public class ClarifyingQuestions
//    {
//        /**
//           1 What is the range of integers in the array 'nums'?
//        2 Can there be duplicate integers in the 'nums' array?
//        3 Can the solution contain duplicate triplets?
//        4 Do we need to return the triplets in a specific order?
//        5 Do we need to return the solution in any specific data structure?
//        **/
//    }
//    public class DiscussSolutions
//    {
//        /**
//          Brute Force Approach: The simplest approach would be to use three nested loops 
//          to iterate over all possible triplets, and check if the sum of the triplet is zero.
//           This approach has a time complexity of O(n^3), where n is the size of the input array.

//      Use: Sorting with Two-PointersApproach: Sort the input array, then use two pointers to iterate over the array.
//        Fix the first pointer at the beginning of the array and the second pointer at the end of the array.
//         Then, for each pair of pointers, check if the sum of the two values is the negation of the 
//         value of the first pointer. If it is, we have found a triplet with a sum of zero. If not, we
//          move the first or the second pointer accordingly. This approach has a time complexity of O(n^2), 
//          where n is the size of the input array.

//       Hash Table Approach: We can use a hash table to store the values of the input array as keys, and
//        their indices as values. Then, we can use two nested loops to iterate over all possible pairs 
//        of values, and check if the negation of their sum exists in the hash table. If it does, we have 
//        found a triplet with a sum of zero. This approach has a time complexity of O(n^2), where n is the
//         size of the input array, and a space complexity of O(n).

//       Sorting with Binary Search: This is an optimized version of the Two-Pointer Approach. 
//       Sort the input array, then use one pointer to iterate over the array, and for each value of 
//       the pointer, use two more pointers (left and right) to find the other two values that would 
//       make the sum of the triplet zero. This approach has a time complexity of O(n^2),
//        where n is the size of the input array, and a space complexity of O(1).
//       **/

//    }
//    public class Use
//    {
//        /**
//        Sorting with Two-Pointers
//        Algo
//        Sort the input array in non-decreasing order.
//        Use two pointers to iterate over the array, one starting at the beginning and the other at the end.
//        For each pair of pointers, check if the sum of their values is the negation of the value of the first pointer.
//        If it is, add the triplet to the list of solutions and move both pointers towards the center.
//        If the sum is less than the negation of the value of the first pointer, move the first pointer towards the center.
//        If the sum is greater than the negation of the value of the first pointer, move the second pointer towards the center.
//        Repeat steps 3-6 until both pointers cross each other.
//        Return the list of solutions.
//        **/
//        public IList<IList<int>> ThreeSumTwoPointer(int[] nums)
//        {
//            IList<IList<int>> result = new List<IList<int>>();
//            int n = nums.Length;

//            // Sort the input array in non-decreasing order
//            Array.Sort(nums);

//            // Use two pointers to iterate over the array
//            for (int i = 0; i < n - 2; i++)
//            {
//                // Skip duplicates
//                if (i > 0 && nums[i] == nums[i - 1]) continue;
//                int j = i + 1;
//                int k = n - 1;
//                while (j < k)
//                {
//                    int sum = nums[i] + nums[j] + nums[k];
//                    // If the sum is zero, add the triplet to the list of solutions
//                    if (sum == 0)
//                    {
//                        result.Add(new List<int> { nums[i], nums[j], nums[k] });
//                        // Move both pointers towards the center and skip duplicates
//                        while (j < k && nums[j] == nums[j + 1]) j++;
//                        while (j < k && nums[k] == nums[k - 1]) k--;
//                        j++;
//                        k--;
//                    }
//                    // If the sum is less than zero, move the left pointer to the right
//                    else if (sum < 0)
//                    {
//                        j++;
//                    }
//                    // If the sum is greater than zero, move the right pointer to the left
//                    else
//                    {
//                        k--;
//                    }
//                }
//            }
//            return result;
//        }

//        /**
//        TC
//        Time Complexity: O(n^2) where n is the length of the input array. 
//        The algorithm uses two nested loops to generate all possible pairs of values 
//        in the input array, and then iterates over them with two pointers to find the third value that completes the triplet.

//Space Complexity: O(1). The algorithm only uses a constant amount of extra space 
//to store the current triplet and the sum of its elements.
//        **/
//    }

//    public class BruteForce
//    {
//        /**
//        Algo
//        Use three nested loops to iterate over all possible triplets in the input array.
//        Check if the sum of the triplet is zero.
//        If the sum is zero, add the triplet to the list of solutions.
//        Return the list of solutions.
//        **/
//        public IList<IList<int>> ThreeSumBruteForce(int[] nums)
//        {
//            IList<IList<int>> result = new List<IList<int>>();
//            int n = nums.Length;

//            // Iterate over all possible triplets in the array
//            for (int i = 0; i < n - 2; i++)
//            {
//                for (int j = i + 1; j < n - 1; j++)
//                {
//                    for (int k = j + 1; k < n; k++)
//                    {
//                        // Check if the sum of the triplet is zero
//                        if (nums[i] + nums[j] + nums[k] == 0)
//                        {
//                            // Add the triplet to the list of solutions
//                            result.Add(new List<int> { nums[i], nums[j], nums[k] });
//                        }
//                    }
//                }
//            }
//            return result;
//        }

//        /**
//        TC
//        Time Complexity: O(n^3) where n is the length of the input array. 
//        The algorithm uses three nested loops to generate all possible triplets in the input array.

//Space Complexity: O(1). The algorithm only uses a constant amount of extra space to store
//     the current triplet and the sum of its elements.
//        **/
//    }
//    public class Sorting
//    {
//        /**
//        Optimized Two-Pointer Approach: Sorting with Binary Search Approach:
//        Algo
//        Sort the input array in non-decreasing order.
//        Use one pointer to iterate over the array, starting from the beginning.
//        For each value of the pointer, use two more pointers (left and right) to find the other two values that would make the sum of the triplet zero.
//        If the sum of the triplet is zero, add the triplet to the list of solutions.
//        If the sum is less than zero, move the left pointer to the right.
//        If the sum is greater than zero, move the right pointer to the left.
//        Repeat steps 3-6 until the left pointer is greater than the right pointer.
//        Move the first pointer to the next unique value and repeat steps 3-7 until all unique values have been considered.
//        Return the list of solutions.
//        **/
//        public IList<IList<int>> ThreeSumSortingBinarySearch(int[] nums)
//        {
//            IList<IList<int>> result = new List<IList<int>>();
//            int n = nums.Length;

//            // Sort the input array in non-decreasing order
//            Array.Sort(nums);

//            // Use two nested loops to iterate over all possible pairs of values in the input array
//            for (int i = 0; i < n - 2; i++)
//            {
//                // Skip duplicates
//                if (i > 0 && nums[i] == nums[i - 1]) continue;
//                for (int j = i + 1; j < n - 1; j++)
//                {
//                    // Skip duplicates
//                    if (j > i + 1 && nums[j] == nums[j - 1]) continue;
//                    int complement = -(nums[i] + nums[j]);
//                    // Use binary search to find the index of the complement in the remaining subarray
//                    int k = Array.BinarySearch(nums, j + 1, n - j - 1, complement);
//                    if (k >= 0)
//                    {
//                        // Add the triplet to the list of solutions
//                        result.Add(new List<int> { nums[i], nums[j], complement });
//                    }
//                }
//            }
//            return result;
//        }

//        /**
//       TC
//       Time Complexity: O(n^2 log n) where n is the length of the input array. 
//       The algorithm uses two nested loops to generate all possible pairs of values 
//       in the input array, and then performs binary search in a sorted subarray to find the 
//       third value that completes the triplet. 
//       The binary search takes O(log n) time, so the overall time complexity is O(n^2 log n).

//Space Complexity: O(1). The algorithm only uses a constant amount of extra space to
//store the current triplet and the sum of its elements.
//       **/
//    }

//    public class HashTable
//    {
//        /**
//        Algo
//        Create an empty hash table.
//    Iterate over the input array, and for each value, add it to the hash table with its index as the value.
//    Use two nested loops to iterate over all possible pairs of values in the input array.
//    For each pair of values, check if the negation of their sum exists in the hash table, and its index is not the same as either of the indices of the pair.
//    If it does, add the triplet to the list of solutions.
//        **/
//        public IList<IList<int>> ThreeSumHashTable(int[] nums)
//        {
//            IList<IList<int>> result = new List<IList<int>>();
//            int n = nums.Length;

//            // Create an empty hash table
//            Dictionary<int, int> hash = new Dictionary<int, int>();

//            // Iterate over the input array and add each value to the hash table with its index as the value
//            for (int i = 0; i < n; i++)
//            {
//                if (!hash.ContainsKey(nums[i]))
//                {
//                    hash[nums[i]] = i;
//                }
//            }

//            // Use two nested loops to iterate over all possible pairs of values in the input array
//            for (int i = 0; i < n - 1; i++)
//            {
//                for (int j = i + 1; j < n; j++)
//                {
//                    int complement = -(nums[i] + nums[j]);
//                    // Check if the negation of their sum exists in the hash table, and its index is not the same as either of the indices of the
//                    if (hash.ContainsKey(complement) && hash[complement] != i && hash[complement] != j)
//                    {
//                        // Add the triplet to the list of solutions
//                        result.Add(new List<int> { nums[i], nums[j], complement });
//                    }
//                }
//            }
//            return result;
//        }

//        /**
//        TC
//        Time Complexity: O(n^2) where n is the length of the input array. 
//        The algorithm uses two nested loops to generate all possible pairs of 
//        values in the input array, and then performs constant-time lookups in a 
//        hash table to find the third value that completes the triplet.

//    Space Complexity: O(n). The algorithm uses a hash table to store the values
//     in the input array, which can take up to O(n) space.
//        **/
//    }
//}

//public class LongestSubstringWithoutRepeatingCharacters
//{
//    public class Bloomberg
//    {

//    }
//    public class Problem
//    {
//        /**
//           Longest Substring Without Repeating Characters
//           Given a string s, find the length of the longest substring without repeating characters.
//        **/
//    }
//    public class Example
//    {
//        /**
//            Example 1:

//             Input: s = "abcabcbb"
//             Output: 3
//             Explanation: The answer is "abc", with the length of 3.
//             Example 2:

//             Input: s = "bbbbb"
//             Output: 1
//             Explanation: The answer is "b", with the length of 1.
//             Example 3:

//             Input: s = "pwwkew"
//             Output: 3
//             Explanation: The answer is "wke", with the length of 3.
//             Notice that the answer must be a substring, "pwke" is a subsequence and not a substring.
//         **/
//    }
//    public class ClarifyingQuestions
//    {
//        /**
//           1 Is the input string limited to a certain character set?
//        2 Should the output be the length of the substring or the substring itself?
//        3 Should the solution be case-sensitive or case-insensitive?
//        4 Can the input string be empty?
//        5 Can the input string contain spaces or special characters?
//        6 Should the output be a unique longest substring or could there be multiple substrings with the same longest length?
//        **/
//    }
//    public class DiscussSolutions
//    {
//        /**
//          Brute Force Approach: The brute force approach involves generating all possible substrings 
//          of the input string and checking for each substring whether it contains repeating characters or not. 
//          The length of the longest substring without repeating characters is the maximum length of all such substrings. 
//          This approach has a time complexity of O(n^3) and is not recommended for large input strings.

//       Use: Sliding Window Approach: The sliding window approach involves maintaining a window of characters
//        in the input string, where the window slides over the string and expands or contracts depending 
//        on whether the current window contains repeating characters or not. This approach has a time 
//        complexity of O(n) and is considered an optimal solution for this problem.

//       Hash Map Approach: The hash map approach involves maintaining a hash map of characters and their 
//       indices in the input string. As we traverse the string, we update the indices in the hash map
//        and check for repeating characters. If a repeating character is found, we move the window's 
//        starting index to the next index of the first occurrence of the repeating character. 
//        This approach also has a time complexity of O(n).

//       Two-Pointer Approach: The two-pointer approach involves maintaining two pointers, left and right,
//        where the left pointer indicates the start of the current substring without repeating characters,
//         and the right pointer indicates the end of the substring. As we traverse the string, we update
//          the pointers and the maximum length of the substring. 
//          This approach has a time complexity of O(n) and is similar to the sliding window approach.

//          In terms of time complexity, the sliding window and hash map approaches are the most efficient, 
//          with O(n) time complexity. The two-pointer approach also has O(n) time complexity, but it has 
//          slightly higher overhead due to the use of a hash set. The brute force approach is the least
//           efficient, with O(n^3) time complexity. In terms of space complexity, all four approaches 
//           have the same O(min(n, m)) space complexity, where m is the size of the character set.
//       **/

//    }
//    public class Use  //Sliding Window Approach
//    {
//        /**
//        Algo
//        Initialize two pointers, start and end, to the first index of the input string.
//        Initialize a hash set to store the unique characters in the current window.
//        While the end pointer is less than the length of the string:
//            If the current character at the end pointer is not in the hash set:
//                Add the character to the hash set and increment the end pointer.
//                Update the length of the longest substring if the current window is longer.
//            If the current character at the end pointer is in the hash set:
//                Remove the character at the start pointer from the hash set and increment the start pointer.
//        **/
//        public int LengthOfLongestSubstring(string s)
//        {
//            int n = s.Length;
//            int maxLength = 0;
//            int start = 0;
//            int end = 0;
//            HashSet<char> set = new HashSet<char>();
//            while (start < n && end < n)
//            {
//                // if the current character is not in the hash set, add it and update maxLength
//                if (!set.Contains(s[end]))
//                {
//                    set.Add(s[end++]);
//                    maxLength = Math.Max(maxLength, end - start);
//                }
//                else
//                {
//                    // if the current character is already in the hash set, remove the first character and increment start
//                    set.Remove(s[start++]);
//                }
//            }
//            return maxLength;
//        }

//        /**
//       TC
//       Time Complexity: O(n), where n is the length of the input string. 
//       The two pointers start and end traverse the string only once.

//Space Complexity: O(min(n, m)), where n is the length of the input 
//string and m is the size of the character set. In the worst case, 
//the hash set can contain all the characters in the input string.
//       **/
//    }
//    public class BruteForce
//    {
//        /**
//        Algo
//        Generate all possible substrings of the input string.
//        Check each substring for repeating characters.
//        If a substring contains no repeating characters, compare its length with the length of the previous longest substring.
//        Return the length of the longest substring without repeating characters.
//        **/
//        public int LengthOfLongestSubstring(string s)
//        {
//            int n = s.Length;
//            int maxLength = 0;
//            // iterate over all possible substrings of the input string
//            for (int i = 0; i < n; i++)
//            {
//                for (int j = i + 1; j <= n; j++)
//                {
//                    // check if the substring contains no repeating characters
//                    if (AllUnique(s, i, j))
//                    {
//                        // if the substring is longer than the previous longest substring, update maxLength
//                        maxLength = Math.Max(maxLength, j - i);
//                    }
//                }
//            }
//            return maxLength;
//        }

//        private bool AllUnique(string s, int start, int end)
//        {
//            HashSet<char> set = new HashSet<char>();
//            // check if each character in the substring is unique
//            for (int i = start; i < end; i++)
//            {
//                char c = s[i];
//                if (set.Contains(c))
//                {
//                    // if a character is not unique, return false
//                    return false;
//                }
//                set.Add(c);
//            }
//            // if all characters in the substring are unique, return true
//            return true;
//        }

//        /**
//        TC
//        Time Complexity: O(n^3), where n is the length of the input string. 
//        The outer loop iterates over n elements, and the inner loop iterates 
//        over n elements for each outer loop iteration, and the AllUnique 
//        function can take up to O(n) time in the worst case.

//Space Complexity: O(min(n, m)), where n is the length of the input string 
//and m is the size of the character set. In the worst case, the hash set 
//can contain all the characters in the input string.
//        **/
//    }

//    public class HashMap
//    {
//        /**
//        Algo
//        Initialize two pointers, start and end, to the first index of the input string.
//        Initialize an empty hash map to store the last index of each character in the current window.
//        While the end pointer is less than the length of the string:
//            If the current character at the end pointer is in the hash map:
//                Move the start pointer to the next index of the last occurrence of the current character.
//            Update the index of the current character in the hash map and increment the end pointer.
//            Update the length of the longest substring if the current window is longer.
//        **/
//        public int LengthOfLongestSubstring(string s)
//        {
//            int n = s.Length;
//            int maxLength = 0;
//            int start = 0;
//            int end = 0;
//            Dictionary<char, int> map = new Dictionary<char, int>();
//            while (end < n)
//            {
//                char c = s[end];
//                // if the current character is already in the hash map and its last occurrence is within the current window, update start
//                if (map.ContainsKey(c) && map[c] >= start)
//                {
//                    start = map[c] + 1;
//                }
//                // update the last occurrence of the current character in the hash map and update maxLength
//                map[c] = end;
//                maxLength = Math.Max(maxLength, end - start + 1);
//                end++;
//            }
//            return maxLength;
//        }

//        /**
//        TC
//        Time Complexity: O(n), where n is the length of the input string. 
//        The two pointers start and end traverse the string only once, 
//        and the hash map can contain up to n entries.

//    Space Complexity: O(min(n, m)), where n is the length of the input 
//    string and m is the size of the character set. In the worst case, 
//    the hash map can contain all the characters in the input string.
//        **/
//    }
//    public class TwoPointer
//    {
//        /**
//        Algo
//       Initialize two pointers, left and right, to the first index of the input string.
//        Initialize an empty hash set to store the unique characters in the current window.
//        Initialize a variable to store the length of the longest substring to 0.
//        While the right pointer is less than the length of the string:
//            If the current character at the right pointer is not in the hash set:
//                Add the character to the hash set and increment the right pointer.
//                Update the length of the longest substring if the current window is longer.
//            If the current character at the right pointer is in the hash set:
//                Remove the character at the left pointer from the hash set and increment the left pointer.
//        **/
//        public int LengthOfLongestSubstring(string s)
//        {
//            int n = s.Length;
//            int maxLength = 0;
//            int left = 0;
//            int right = 0;
//            HashSet<char> set = new HashSet<char>();
//            while (right < n)
//            {
//                // if the current character is not in the hash set, add it and update maxLength
//                if (!set.Contains(s[right]))
//                {
//                    set.Add(s[right++]);
//                    maxLength = Math.Max(maxLength, set.Count);
//                }
//                else
//                {
//                    // if the current character is already in the hash set, remove the first character and increment left
//                    set.Remove(s[left++]);
//                }
//            }
//            return maxLength;
//        }

//        /**
//        TC
//        Time Complexity: O(n), where n is the length of the input string. 
//        The two pointers left and right traverse the string only once.

//    Space Complexity: O(min(n, m)), where n is the length of the input 
//    string and m is the size of the character set. In the worst case, 
//    the hash set can contain all the characters in the input string.
//        **/
//    }
//}

//public class ValidAnagram
//{
//    public class Bloomberg
//    {

//    }
//    public class Problem
//    {
//        /**
//           Valid Anagram
//           Given two strings s and t, return true if t is an anagram of s, and false otherwise.
//        **/
//    }
//    public class Example
//    {
//        /**
//            Example 1:

//Input: s = "anagram", t = "nagaram"
//Output: true
//Example 2:

//Input: s = "rat", t = "car"
//Output: false
//         **/
//    }
//    public class ClarifyingQuestions
//    {
//        /**
//           Can you provide an example input and output for the function?
//    Are the strings case-sensitive?
//    Can the input strings contain spaces or special characters?
//    Are there any time or space complexity requirements for the solution?
//    Can we assume that the input strings are of equal length?
//        **/
//    }
//    public class DiscussSolutions
//    {
//        /**
//          Sorting the strings: One approach is to sort the characters in
//        both strings and compare them. If the sorted strings are equal, then
//        the input strings are anagrams. The time complexity of this approach
//        is O(n log n), where n is the length of the strings.

//         Use:Using an array: Another approach is to create an array of size 26
//        (assuming only lowercase English letters) and increment the count of
//        each character in the first string and then decrement the count of each
//        character in the second string. If the array ends up with all zero counts
//        for each character, then the strings are anagrams. The time complexity of
//        this approach is O(n), where n is the length of the strings.

//        Using a Hash Table: Another approach is to create a hash table for one
//        string and then traverse the other string, decrementing the count of each
//        character in the hash table as it is encountered. If the hash table ends
//        up with all zero counts for each character, then the strings are anagrams.
//        The time complexity of this approach is O(n), where n is the length of the strings.

       

//        Using XOR: Another approach is to XOR all the characters in both strings.
//        If the result is zero, then the strings are anagrams. The time complexity of
//        this approach is O(n), where n is the length of the strings.
//       **/

//    }
//    public class Use
//    {
//        /** Using Array
//        Algo
//        Create an array of size 26 (assuming only lowercase English letters)
//Traverse the first input string, incrementing the count of each character in the array as it is encountered
//Traverse the second input string, decrementing the count of each character in the array as it is encountered
//If the array ends up with all zero counts for each character, return true, otherwise return false
//        **/
//        public bool IsAnagram(string s, string t)
//        {
//            // Create an array of size 26 (assuming only lowercase English letters)
//            int[] charCount = new int[26];

//            // Traverse the first input string, incrementing the count of each character in the array as it is encountered
//            foreach (char c in s)
//            {
//                charCount[c - 'a']++;
//            }

//            // Traverse the second input string, decrementing the count of each character in the array as it is encountered
//            foreach (char c in t)
//            {
//                charCount[c - 'a']--;
//            }

//            // If the array ends up with all zero counts for each character, return true, otherwise return false
//            foreach (int count in charCount)
//            {
//                if (count != 0)
//                {
//                    return false;
//                }
//            }
//            return true;
//        }

//        /**
//       TC
//        Time complexity: O(n), where n is the length of the input strings.
//        This is because we need to traverse both strings once,
//        which takes O(n) time in the worst case. Array operations take O(1)
//        time, so this does not increase the time complexity.
//Space complexity: O(1), because we create a fixed-size array of length 26 to store the counts of each character.
//       **/
//    }
//    public class BruteForce
//    {
//        /** Sorting the strings:
//        Algo
//        Sort both input strings
//Compare the sorted strings to see if they are equal
//Return true if they are equal, false otherwise
//        **/
//        public bool IsAnagram(string s, string t)
//        {
//            // Sort both strings
//            char[] sArr = s.ToCharArray();
//            Array.Sort(sArr);
//            string sortedS = new string(sArr);
//            char[] tArr = t.ToCharArray();
//            Array.Sort(tArr);
//            string sortedT = new string(tArr);

//            // Compare the sorted strings to see if they are equal
//            return sortedS.Equals(sortedT);
//        }

//        /**
//        TC
//        Time complexity: O(nlogn), where n is the length of the input strings.
//        This is because we need to sort the strings, which takes O(nlogn) time in the worst case.
//Space complexity: O(n), where n is the length of the input strings.
//        This is because we create two new strings, each of which is of length n.
//        **/
//    }

//    public class HashTable
//    {
//        /**
//        Algo
//        Create a hash table for one of the input strings
//Traverse the other input string, decrementing the count of each character in the hash table as it is encountered
//If the hash table ends up with all zero counts for each character, return true, otherwise return false
//        **/
//        public bool IsAnagram(string s, string t)
//        {
//            // Create a hash table for one of the input strings
//            Dictionary<char, int> charCount = new Dictionary<char, int>();
//            foreach (char c in s)
//            {
//                if (charCount.ContainsKey(c))
//                {
//                    charCount[c]++;
//                }
//                else
//                {
//                    charCount.Add(c, 1);
//                }
//            }

//            // Traverse the other input string, decrementing the count of each character in the hash table as it is encountered
//            foreach (char c in t)
//            {
//                if (charCount.ContainsKey(c))
//                {
//                    charCount[c]--;
//                }
//                else
//                {
//                    // If a character is encountered in the second string that is not in the hash table, it is not an anagram
//                    return false;
//                }
//            }

//            // If the hash table ends up with all zero counts for each character, return true, otherwise return false
//            foreach (int count in charCount.Values)
//            {
//                if (count != 0)
//                {
//                    return false;
//                }
//            }
//            return true;
//        }

//        /**
//        TC
//        Time complexity: O(n), where n is the length of the input strings.
//        This is because we need to traverse both strings once, which takes
//        O(n) time in the worst case. Hash table operations take O(1)
//        time on average, so this does not increase the time complexity.
//Space complexity: O(n), where n is the length of the input string.
//        This is because we create a hash table of size n to store the counts of each character.
//        **/
//    }
//    public class XOR
//    {
//        /**
//        Algo
//        Initialize a variable to zero
//Traverse both input strings, XORing the value of each character with the variable
//If the variable is zero at the end of the traversal, return true, otherwise return false
//        **/
//        public bool IsAnagram(string s, string t)
//        {
//            // Initialize a variable to zero
//            int xorResult = 0;

//            // Traverse both input strings, XORing the value of each character with the variable
//            foreach (char c in s)
//            {
//                xorResult ^= (int)c;
//            }
//            foreach (char c in t)
//            {
//                xorResult ^= (int)c;
//            }

//            // If the variable is zero at the end of the traversal, return true, otherwise return false
//            return xorResult == 0;
//        }

//        /**
//        TC
//        Time complexity: O(n), where n is the length of the input strings.
//        This is because we need to traverse both strings once,
//        which takes O(n) time in the worst case. XOR operations take O(1) time,
//        so this does not increase the time complexity.
//Space complexity: O(1), because we only need to store a single integer variable.
//        **/
//    }
//}

//public class SpiralMatrix
//{
//    public class Bloomberg
//    {

//    }
//    public class Problem
//    {
//        /**
//           Given an m x n matrix, return all elements of the matrix in spiral order.

//        **/
//    }
//    public class Example
//    {
//        /**
//         * 1 -> 2 -> 3
//         *           |
//         * 4 -> 5    6
//         * |         |
//         * 7 <- 8 <- 9
//           Input: matrix = [[1,2,3],[4,5,6],[7,8,9]]
//Output: [1,2,3,6,9,8,7,4,5] 
//         **/
//    }
//    public class ClarifyingQuestions
//    {
//        /**
//           1 Can you provide an example of what you mean by "spiral order"?
//           2  Are the values in the matrix guaranteed to be integers,
//        or could they be of any data type?
//           3  Can we assume that the input matrix is always rectangular
//        (i.e., that all rows have the same length)?
//           4  Are there any constraints on the size of the input matrix
//        (e.g., is it small enough to be stored in memory)?
//           5  Are there any specific time or space complexity requirements
//        for the algorithm that we will be implementing to solve this problem?
//        **/
//    }
//    public class DiscussSolutions
//    {
//        /**
//          Simulation approach: The simulation approach involves repeatedly
//        traversing the boundary of the matrix in a clockwise direction until
//        all elements have been visited. This approach involves keeping track
//        of the boundaries of the matrix that have not yet been traversed,
//        and moving in a clockwise direction along these boundaries until
//        all elements have been visited.

//        Recursive approach: In the recursive approach, we can start by
//        traversing the outermost layer of the matrix in a clockwise direction,
//        then recursively traverse the remaining layers in the same way.
//        This approach requires that we keep track of the current layer
//        of the matrix being traversed, and that we call the function recursively
//        on the remaining layers.

//        Iterative approach: The iterative approach involves traversing the
//        matrix in a clockwise direction using a series of loops. This approach
//        requires that we keep track of the current position in the matrix,
//        and that we update the direction in which we are moving based on the current position.

//        Stack approach: In the stack approach, we can push the elements of
//        the first row of the matrix onto a stack, then traverse the remaining
//        elements of the matrix in a clockwise direction using a series of loops.
//        This approach requires that we keep track of the current position in the
//        matrix, and that we pop elements off the stack and append them to a list
//        as we traverse the matrix.

//        The iterative approach has a time complexity of O(n) and a space complexity of O(1),
//        which means that it is the most efficient in terms of both time and space complexity.
//        The recursive and stack approaches also have a time complexity of O(n), but they require
//        extra space to store the recursive call stack or the stack data structure.
//        The brute force approach has a time complexity of O(n^2)
//       **/

//    }
//    public class Use // Iterative approach:
//    {
//        /**
//        Algo

//    Initialize four variables: left, right, top, and bottom,
//        to represent the boundaries of the matrix.
//    Initialize an empty list to hold the result.
//    Initialize two variables: row and col, to represent
//        the current position in the matrix.
//    Initialize a variable direction to represent the current
//        direction of traversal (e.g., right, down, left, up).
//    Repeat the following steps until all elements have been visited:
//        Traverse in the current direction until a boundary is reached,
//        appending each element to the result list.
//        Update the current position accordingly.
//        If the current position is outside the boundaries, adjust the
//        boundaries accordingly and switch the direction of traversal.
//        **/
//        public IList<int> SpiralOrder(int[][] matrix)
//        {
//            int rows = matrix.Length;
//            int cols = matrix[0].Length;

//            // Initialize variables to represent the boundaries of the matrix
//            int top = 0, bottom = rows - 1;
//            int left = 0, right = cols - 1;

//            // Initialize an empty list to hold the result
//            List<int> result = new List<int>();

//            while (result.Count < rows * cols)
//            {
//                // Traverse the top row from left to right
//                for (int i = left; i <= right && result.Count < rows * cols; i++)
//                {
//                    result.Add(matrix[top][i]);
//                }
//                top++; // Increment top boundary to exclude top row from future traversals

//                // Traverse the right column from top to bottom
//                for (int i = top; i <= bottom && result.Count < rows * cols; i++)
//                {
//                    result.Add(matrix[i][right]);
//                }
//                right--; // Decrement right boundary to exclude right column from future traversals

//                // Traverse the bottom row from right to left
//                for (int i = right; i >= left && result.Count < rows * cols; i--)
//                {
//                    result.Add(matrix[bottom][i]);
//                }
//                bottom--; // Decrement bottom boundary to exclude bottom row from future traversals

//                // Traverse the left column from bottom to top
//                for (int i = bottom; i >= top && result.Count < rows * cols; i--)
//                {
//                    result.Add(matrix[i][left]);
//                }
//                left++; // Increment left boundary to exclude left column from future traversals
//            }

//            return result;
//        }

//        /**
//       TC
//        Time complexity: O(n)
//        We need to visit each element of the matrix exactly once, so the time complexity is O(n),
//        where n is the total number of elements in the matrix.
//        Space complexity: O(1)
//        We only need constant extra space to store the variables that represent the
//        boundaries of the matrix and the result list.
//       **/
//    }

//    public class BruteForce
//    {
//        /**
//        Algo
//        Initialize four variables: left, right, top, and bottom, to represent the boundaries of the matrix.
//        Initialize an empty list to hold the result.
//        Repeat the following steps until all elements have been visited:
//            Traverse the top row from left to right and append each element to the result list.
//            Increment the top variable to exclude the top row from future traversals.
//            Traverse the right column from top to bottom and append each element to the result list.
//            Decrement the right variable to exclude the right column from future traversals.
//            Traverse the bottom row from right to left and append each element to the result list.
//            Decrement the bottom variable to exclude the bottom row from future traversals.
//            Traverse the left column from bottom to top and append each element to the result list.
//            Increment the left variable to exclude the left column from future traversals.
//        **/
//        public IList<int> SpiralOrder(int[][] matrix)
//        {
//            // Initialize variables to represent the boundaries of the matrix
//            int top = 0, bottom = matrix.Length - 1;
//            int left = 0, right = matrix[0].Length - 1;

//            // Initialize an empty list to hold the result
//            List<int> result = new List<int>();

//            while (top <= bottom && left <= right)
//            {
//                // Traverse the top row from left to right
//                for (int i = left; i <= right; i++)
//                {
//                    result.Add(matrix[top][i]);
//                }
//                top++; // Increment top boundary to exclude top row from future traversals

//                // Traverse the right column from top to bottom
//                for (int i = top; i <= bottom; i++)
//                {
//                    result.Add(matrix[i][right]);
//                }
//                right--; // Decrement right boundary to exclude right column from future traversals

//                // Traverse the bottom row from right to left
//                if (top <= bottom)
//                { // Check if there are still rows left to traverse
//                    for (int i = right; i >= left; i--)
//                    {
//                        result.Add(matrix[bottom][i]);
//                    }
//                    bottom--; // Decrement bottom boundary to exclude bottom row from future traversals
//                }

//                // Traverse the left column from bottom to top
//                if (left <= right)
//                { // Check if there are still columns left to traverse
//                    for (int i = bottom; i >= top; i--)
//                    {
//                        result.Add(matrix[i][left]);
//                    }
//                    left++; // Increment left boundary to exclude left column from future traversals
//                }
//            }

//            return result;
//        }

//        /**
//        TC
//        Time complexity: O(n^2)
//        We need to traverse all elements of the matrix to generate the result list,
//        so the time complexity is O(n^2), where n is the total number of elements in the matrix.
//        Space complexity: O(n)
//        We need to store all elements of the matrix in the result list,
//        so the space complexity is O(n), where n is the total number of elements in the matrix.
//        **/
//    }

//    public class Recursive
//    {
//        /**
//        Algo
//        Recursive case:
//Traverse the top row from left to right and append each element to the result list.
//Traverse the right column from top to bottom and append each element to the result list.
//Traverse the bottom row from right to left and append each element to the result list.
//Traverse the left column from bottom to top and append each element to the result list.
//Call the recursive function on the remaining matrix with the current layer incremented by 1.
//        **/
//        public IList<int> SpiralOrder(int[][] matrix)
//        {
//            List<int> result = new List<int>();
//            SpiralTraversal(matrix, 0, result);
//            return result;
//        }

//        private void SpiralTraversal(int[][] matrix, int layer, List<int> result)
//        {
//            int rows = matrix.Length;
//            int cols = matrix[0].Length;
//            int startRow = layer, endRow = rows - layer - 1;
//            int startCol = layer, endCol = cols - layer - 1;

//            // Base case: if there are no more layers to traverse
//            if (startRow > endRow || startCol > endCol)
//            {
//                return;
//            }

//            // Traverse the top row from left to right
//            for (int i = startCol; i <= endCol; i++)
//            {
//                result.Add(matrix[startRow][i]);
//            }

//            // Traverse the right column from top to bottom
//            for (int i = startRow + 1; i <= endRow; i++)
//            {
//                result.Add(matrix[i][endCol]);
//            }

//            // Traverse the bottom row from right to left
//            for (int i = endCol - 1; i >= startCol && startRow < endRow; i--)
//            {
//                result.Add(matrix[endRow][i]);
//            }

//            // Traverse the left column from bottom to top
//            for (int i = endRow - 1; i > startRow && startCol < endCol; i--)
//            {
//                result.Add(matrix[i][startCol]);
//            }

//            // Call the recursive function on the remaining matrix with the current layer incremented by 1
//            SpiralTraversal(matrix, layer + 1, result);
//        }

//        /**
//        TC
//        Time complexity: O(n)
//We need to visit each element of the matrix exactly once, so the time complexity is O(n),
//        where n is the total number of elements in the matrix.
//Space complexity: O(n)
//The maximum depth of the recursive call stack is n/4, which corresponds to the number
//        of layers in the matrix. Each recursive call creates a new layer in the call stack,
//        which requires O(1) space. Therefore, the space complexity is O(n).
//        **/
//    }
//    public class Stack
//    {
//        /**
//        Algo
//        Stack approach:

//Initialize an empty list to hold the result.
//Push all elements of the first row onto a stack.
//Traverse the remaining elements of the matrix in a clockwise direction,
//        appending each element to the result list.
//When encountering a boundary, pop the corresponding elements off the stack
//        and append them to the result list.
//        **/
//        public IList<int> SpiralOrder(int[][] matrix)
//        {
//            // Initialize variables to represent the boundaries of the matrix
//            int top = 0, bottom = matrix.Length - 1;
//            int left = 0, right = matrix[0].Length - 1;

//            // Initialize an empty stack to hold the result in reverse order
//            Stack<int> stack = new Stack<int>();

//            while (top <= bottom && left <= right)
//            {
//                // Traverse the top row from left to right
//                for (int i = left; i <= right; i++)
//                {
//                    stack.Push(matrix[top][i]);
//                }
//                top++; // Increment top boundary to exclude top row from future traversals

//                // Traverse the right column from top to bottom
//                for (int i = top; i <= bottom; i++)
//                {
//                    stack.Push(matrix[i][right]);
//                }
//                right--; // Decrement right boundary to exclude right column from future traversals

//                // Traverse the bottom row from right to left
//                if (top <= bottom)
//                { // Check if there are still rows left to traverse
//                    for (int i = right; i >= left; i--)
//                    {
//                        stack.Push(matrix[bottom][i]);
//                    }
//                    bottom--; // Decrement bottom boundary to exclude bottom row from future traversals
//                }

//                // Traverse the left column from bottom to top
//                if (left <= right)
//                { // Check if there are still columns left to traverse
//                    for (int i = bottom; i >= top; i--)
//                    {
//                        stack.Push(matrix[i][left]);
//                    }
//                    left++; // Increment left boundary to exclude left column from future traversals
//                }
//            }

//            // Convert the stack to a list to return the result in the correct order
//            return stack.ToList();
//        }

//        /**
//        TC
//        Time complexity: O(n)
//We need to visit each element of the matrix exactly once, so the time complexity is O(n),
//        where n is the total number of elements in the matrix.
//Space complexity: O(n)
//We need to store all elements of the matrix in the stack, so the space complexity is O(n),
//        where n is the total number of elements in the matrix.
//        **/
//    }
//}

//public class MergeSortedArray
//{
//    public class Bloomberg
//    {

//    }
//    public class Problem
//    {
//        /**
//           ou are given two integer arrays nums1 and nums2, sorted in non-decreasing order, and two integers m and n, representing the number of elements in nums1 and nums2 respectively.

//Merge nums1 and nums2 into a single array sorted in non-decreasing order.

//The final sorted array should not be returned by the function, but instead be stored inside the array nums1. To accommodate this, nums1 has a length of m + n, where the first m elements denote the elements that should be merged, and the last n elements are set to 0 and should be ignored. nums2 has a length of n.
//        **/
//    }
//    public class Example
//    {
//        /**
//            Example 1:

//Input: nums1 = [1,2,3,0,0,0], m = 3, nums2 = [2,5,6], n = 3
//Output: [1,2,2,3,5,6]
//Explanation: The arrays we are merging are [1,2,3] and [2,5,6].
//The result of the merge is [1,2,2,3,5,6] with the underlined elements coming from nums1.
//Example 2:

//Input: nums1 = [1], m = 1, nums2 = [], n = 0
//Output: [1]
//Explanation: The arrays we are merging are [1] and [].
//The result of the merge is [1].
//         **/
//    }
//    public class ClarifyingQuestions
//    {
//        /**
//           Are the arrays nums1 and nums2 guaranteed to be of equal length?
//        Can we assume that the non-zero elements in nums1 are already sorted in non-decreasing order?
//        Can we assume that the non-zero elements in nums2 are already sorted in non-decreasing order?
//        Is it allowed to use additional data structures or do we need to perform the merge in-place?
//        Do we need to consider edge cases such as empty arrays or arrays with only zero elements?

       
//        **/
//    }
//    public class DiscussSolutions
//    {
//        /**
//          BF: Iterate over both arrays, compare the elements at each index,
//        and insert the smaller element into a new array until both arrays are exhausted.
//        Then, copy the new array back into nums1. O((m+n)^2)

//         Two-pointer O(m+n): Initialize two pointers, one for each array,
//        and iterate over both arrays, comparing the elements at each
//        pointer's current position. The smaller element is inserted
//        into nums1, and the corresponding pointer is moved one position
//        to the right. This process continues until one of the arrays
//        is exhausted. Then, copy the remaining elements from the non-exhausted array into nums1.

//        Merge & Sort O((m+n)log(m+n)): Merge the two arrays into a new array, then sort the new array,
//        and copy the sorted elements back into nums1.

//        In-place merging: Starting from the end of nums1, compare
//        the last elements of both arrays and insert the larger element
//        at the end of nums1. Move the pointer of the array that contains
//        the larger element to the left and repeat until one of the arrays
//        is exhausted. Then, copy the remaining elements from the non-exhausted array into nums1.
//       **/

//    }
//    public class Use
//    {
//        /**Two Pointer
//        Algo
//        Initialize two pointers, i and j, to point to the
//        first element of nums1 and nums2, respectively.
//        While both arrays have elements:
//            If nums1[i] is smaller than or equal to nums2[j], increment i.
//            Otherwise, shift the elements in nums1 from index i to m+j one
//            position to the right and insert nums2[j] at index i. Increment i and j.
//        If nums2 still has elements, copy the remaining elements to nums1.
//        **/
//        public void Merge(int[] nums1, int m, int[] nums2, int n)
//        {
//            // Initialize three pointers: i for nums1, j for nums2, and k for the end of nums1
//            int i = m - 1; // Index of last element in nums1
//            int j = n - 1; // Index of last element in nums2
//            int k = m + n - 1; // Index of last element in merged array

//            // While both arrays have elements, compare the current elements
//            // from nums1 and nums2 and insert the larger one at the end of nums1
//            while (i >= 0 && j >= 0)
//            {
//                if (nums1[i] >= nums2[j])
//                {
//                    // Insert the current element of nums1 and decrement i and k
//                    nums1[k--] = nums1[i--];
//                }
//                else
//                {// Insert the current element of nums2 and decrement j and k
//                    nums1[k--] = nums2[j--];
//                }
//            }

//            // If there are any remaining elements in nums2, insert them at the end of nums1
//            while (j >= 0)
//            {
//                nums1[k--] = nums2[j--];
//            }
//        }
//        /**
//       TC
//        Time complexity: O(m+n)

//Space complexity: O(1)

//This approach involves traversing the two arrays using two pointers until
//        all the elements have been merged. It is a linear-time algorithm
//        and has a space complexity of O(1) because it does not use any additional data structures.
//       **/
//    }
//    public class BruteForce
//    {
//        /**
//        Algo
//        Initialize an empty array merged.
//Initialize two pointers, i and j, to point to the first element of nums1 and nums2, respectively.
//While both arrays have elements:
//    If nums1[i] is smaller than or equal to nums2[j], append nums1[i] to merged and increment i.
//    Otherwise, append nums2[j] to merged and increment j.
//If nums1 still has elements, append the remaining elements to merged.
//If nums2 still has elements, append the remaining elements to merged.
//Copy the elements from merged back into nums1.
//        **/
//        public void Merge(int[] nums1, int m, int[] nums2, int n)
//        {
//            int[] merged = new int[m + n];
//            int i = 0, j = 0, k = 0;

//            while (i < m && j < n)
//            {
//                if (nums1[i] <= nums2[j])
//                {
//                    merged[k++] = nums1[i++];
//                }
//                else
//                {
//                    merged[k++] = nums2[j++];
//                }
//            }

//            while (i < m)
//            {
//                merged[k++] = nums1[i++];
//            }

//            while (j < n)
//            {
//                merged[k++] = nums2[j++];
//            }

//            Array.Copy(merged, nums1, m + n);
//        }
//        /**
//        TC
//        Time complexity: O((m+n)^2)

//Space complexity: O(m+n)

//This approach involves creating a new array and iterating over
//        both input arrays to add elements to the new array,
//        while keeping it sorted. For each element in the second
//        array, we compare it with each element in the first array
//        and insert it in the correct position. The time complexity
//        of this approach is O((m+n)^2), because for each element in
//        the second array we have to compare it to all the elements
//        in the first array. The space complexity is O(m+n),
//        because we create a new array to store the merged elements.
//        This approach is not efficient and is not practical for large
//        inputs, but it is simple to implement.
//        **/
//    }

//    public class Sort
//    {
//        /**
//        Algo
//        Merge the two arrays into a new array, merged.
//Sort the merged array.
//Copy the elements from merged back into nums1.
//        **/
//        public void Merge(int[] nums1, int m, int[] nums2, int n)
//        {
//            // Copy the elements of nums2 into the end of nums1
//            Array.Copy(nums2, 0, nums1, m, n);
//            // Sort the merged array in non-decreasing order
//            Array.Sort(nums1);
//        }
//        /**
//        TC
//        Time complexity: O((m+n)log(m+n))

//        Space complexity: O(m+n)

//This approach involves merging the two arrays and then sorting
//        the resulting array. The time complexity is dominated
//        by the sorting algorithm used, which is usually O((m+n)log(m+n)).
//        The space complexity is O(m+n) because a new array is created to store the merged and sorted elements.
//        **/
//    }
//}

//public class PascalTriangle
//{
//    public class Bloomberg
//    {

//    }
//    public class Problem
//    {
//        /**
//           Given an integer numRows, return the first numRows of Pascal's triangle.

//In Pascal's triangle, each number is the sum of the two numbers directly above it as shown:
//        **/
//    }
//    public class Example
//    {
//        /**
//            Example 1:

//Input: numRows = 5
//Output: [[1],[1,1],[1,2,1],[1,3,3,1],[1,4,6,4,1]]
//Example 2:

//Input: numRows = 1
//Output: [[1]]
//         **/
//    }
//    public class ClarifyingQuestions
//    {
//        /**
//           What is the range of the input integer numRows?
//Can we assume that numRows will always be a positive integer?
//Can we print the output in any particular format?
//Is there any specific data structure that needs to be used to represent the Pascal's triangle?
//Do we need to handle edge cases, such as when numRows is equal to 0 or 1?
//        **/
//    }
//    public class DiscussSolutions
//    {
//        /**
//          Brute force O(numRows^2): In this approach, we can generate each row of
//        Pascal's Triangle using the values of the previous row.
//        We can create an empty list for each row and then calculate
//        the values for each row using the values from the previous row.

//        Dynamic programming O(numRows^2): This approach involves using a 2D array
//        to store the values of the Pascal's Triangle. We can iterate
//        through the rows and columns of the array and calculate each
//        value using the formula for Pascal's Triangle.

//        Recursive: In this approach, we can use recursion to calculate
//        the values of each row of Pascal's Triangle. We can define a
//        recursive function that calculates the values for a given row
//        using the values from the previous row.

//        Combinatorics: This approach involves using combinatorics to
//        calculate the values of Pascal's Triangle. We can use the formula
//        for the combination of n choose k to calculate the values for each row.
//       **/

//    }
//    public class Use
//    {
//        /** dYNAMIC Approach
//        Algo
//        a. Create a 2D array to store the values of Pascal's Triangle
//b. Initialize the first row of the array to [1]
//c. Loop through the range of numRows starting from row 2
//d. For each row i, create a list with i + 1 elements
//e. Set the first and last element of the row to 1
//f. For the elements between the first and last element, set each element to the sum of the two elements directly above it in the previous row
//g. Set the current row of the array to the generated row
//h. Return the 2D array of Pascal's Triangle
//        **/
//        public IList<IList<int>> GeneratePascalsTriangle(int numRows)
//        {
//            IList<IList<int>> triangle = new List<IList<int>>();

//            // Initialize the first row of the array to [1]
//            triangle.Add(new List<int> { 1 });

//            // Loop through the range of numRows starting from row 2
//            for (int i = 1; i < numRows; i++)
//            {
//                // Create a list with i + 1 elements for the current row
//                IList<int> row = new List<int>(i + 1);

//                // Set the first element of the row to 1
//                row.Add(1);

//                // For the elements between the first and last element, set each element to the sum of the two elements directly above it in the previous row
//                for (int j = 1; j < i; j++)
//                {
//                    row.Add(triangle[i - 1][j - 1] + triangle[i - 1][j]);
//                }

//                // Set the last element of
//                // the row to 1
//                row.Add(1);

//                // Append the row to the list of rows
//                triangle.Add(row);
//            }

//            // Return the list of rows
//            return triangle;
//        }
//        /**
//       TC
//       The Dynamic Programming Approach has a time complexity of O(numRows^2)
//        and a space complexity of O(numRows^2). This approach generates each
//        row iteratively by building on the previous row, which avoids redundant
//        calculations and minimizes memory usage. The use of a 2D array to store
//        the triangle allows for constant-time access to previously computed values.
//       **/
//    }
//    public class BruteForce
//    {
//        /**
//        Algo
//        a. Create an empty list to store the rows of Pascal's Triangle
//b. Loop through the range of numRows
//c. For each row i, create a list with i + 1 elements
//d. Set the first and last element of the row to 1
//e. For the elements between the first and last element, set each element to the sum of the two elements directly above it in the previous row
//f. Append the row to the list of rows
//g. Return the list of rows
//        **/
//        public IList<IList<int>> GeneratePascalsTriangle(int numRows)
//        {
//            IList<IList<int>> triangle = new List<IList<int>>();

//            // Loop through the range of numRows
//            for (int i = 0; i < numRows; i++)
//            {
//                // Create a list with i + 1 elements for the current row
//                IList<int> row = new List<int>(i + 1);

//                // Set the first and last element of the row to 1
//                row.Add(1);

//                // For the elements between the first and last element, set each element to the sum of the two elements directly above it in the previous row
//                for (int j = 1; j < i; j++)
//                {
//                    row.Add(triangle[i - 1][j - 1] + triangle[i - 1][j]);
//                }

//                // Set the last element of the row to 1
//                if (i > 0)
//                {
//                    row.Add(1);
//                }

//                // Append the row to the list of rows
//                triangle.Add(row);
//            }

//            // Return the list of rows
//            return triangle;
//        }

//        /**
//        TC
//        **/
//    }

//    public class Recursive
//    {
//        /**
//        Algo
//        a. Create a function that takes in the current row number and returns the corresponding row of Pascal's Triangle
//b. Define the base case for row 1, which is [1]
//c. For all other rows, call the function recursively with the previous row number
//d. Create an empty list to store the current row
//e. Loop through the range of the current row length
//f. For each element in the current row, set it to the sum of the corresponding elements in the previous row
//g. Append the current row to the list of rows
//h. Return the list of rows
//        **/
//        public IList<IList<int>> GeneratePascalsTriangle(int numRows)
//        {
//            IList<IList<int>> triangle = new List<IList<int>>();

//            // Loop through the range of numRows and recursively generate each row
//            for (int i = 0; i < numRows; i++)
//            {
//                IList<int> row = GenerateRow(i);
//                triangle.Add(row);
//            }

//            // Return the list of rows
//            return triangle;
//        }

//        // Recursive function to generate a single row of the triangle
//        private IList<int> GenerateRow(int rowNumber)
//        {
//            // Base case: the first two rows are always [1] and [1, 1]
//            if (rowNumber == 0)
//            {
//                return new List<int>() { 1 };
//            }
//            else if (rowNumber == 1)
//            {
//                return new List<int>() { 1, 1 };
//            }

//            // Recursive case: generate the current row by adding the elements from the previous row
//            IList<int> prevRow = GenerateRow(rowNumber - 1);
//            IList<int> row = new List<int>(rowNumber + 1);
//            row.Add(1);
//            for (int i = 1; i < rowNumber; i++)
//            {
//                int element = prevRow[i - 1] + prevRow[i];
//                row.Add(element);
//            }
//            row.Add(1);

//            return row;
//        }

//        /**
//        TC
//        The Recursive Approach has a time complexity of O(numRows^2) and a space complexity of O(numRows^2).
//        This approach generates each row recursively, which can lead to stack overflow errors for large values
//        of numRows. It also requires more memory to store each row on the recursive stack.
//        **/
//    }
//    public class Combinatorics
//    {
//        /**
//        Algo
//        a. Create an empty list to store the rows of Pascal's Triangle
//b. Loop through the range of numRows
//c. For each row i, create a list with i + 1 elements
//d. Set the first and last element of the row to 1
//e. For the elements between the first and last element, set each element to the combination of i choose j, where i is the current row number and j is the current element number
//f. Append the row to the list of rows
//g. Return the list of rows
//        **/
//        public IList<IList<int>> GeneratePascalsTriangle(int numRows)
//        {
//            IList<IList<int>> triangle = new List<IList<int>>();

//            // Loop through the range of numRows
//            for (int i = 0; i < numRows; i++)
//            {
//                // Create a list with i + 1 elements for the current row
//                IList<int> row = new List<int>(i + 1);

//                // Calculate the value of each element in the row using the formula for combinations
//                for (int j = 0; j <= i; j++)
//                {
//                    int element = Factorial(i) / (Factorial(j) * Factorial(i - j));
//                    row.Add(element);
//                }

//                // Append the row to the list of rows
//                triangle.Add(row);
//            }

//            // Return the list of rows
//            return triangle;
//        }

//        // Helper function to calculate the factorial of a number
//        private int Factorial(int n)
//        {
//            int result = 1;
//            for (int i = 2; i <= n; i++)
//            {
//                result *= i;
//            }
//            return result;
//        }

//        /**
//        TC
//        The Combinatorics Approach has a time complexity of O(numRows^2)
//        and a space complexity of O(numRows). While this approach also avoids
//        redundant calculations, it requires additional mathematical computations
//        to calculate each element of the triangle.
//        **/
//    }
//}

//public class IntegertoEnglishWords
//{
//    public class Bloomberg
//    {

//    }
//    public class Problem
//    {
//        /**
//           Convert a non-negative integer num to its English words representation.
//        **/
//    }
//    public class Example
//    {
//        /**
//           Input: num = 123
//Output: "One Hundred Twenty Three"
//Example 2:

//Input: num = 12345
//Output: "Twelve Thousand Three Hundred Forty Five"
//Example 3:

//Input: num = 1234567
//Output: "One Million Two Hundred Thirty Four Thousand Five Hundred Sixty Seven" 
//         **/
//    }
//    public class ClarifyingQuestions
//    {
//        /**
//           Are we considering only non-negative integers, or do we need to consider negative integers as well?
//What is the range of values that we need to consider for the input num?
//Should the output be in lowercase or uppercase?
//Do we need to consider commas in the output for large numbers (e.g., 1,000,000)?
//Are there any specific naming conventions that we need to follow for the English words representation of numbers?
//        **/
//    }
//    public class DiscussSolutions
//    {
//        /**
//          Using Recursion: One approach is to use recursion to break
//        the number down into smaller parts and then recursively call
//        the function to convert those smaller parts to English words.

//Using a Lookup Table: Another approach is to create a lookup table
//        that maps each digit or group of digits to its corresponding
//        English word representation. Then, we can iterate through
//        the number and use the lookup table to convert each group
//        of digits to its English word representation.

//Using Mathematical Operations: We can also use mathematical
//        operations like modulus and division to extract the
//        digits of the number and convert them to English words.

//Using Regular Expressions: Another approach is to use regular
//        expressions to split the number into groups of digits
//        and then convert each group to its English word representation.

//Using a Stack: We can also use a stack data structure to break down
//        the number into smaller parts and then convert those parts
//        to English words in reverse order.
//       **/

//    }
//    public class Use
//    {
//        /** Mathematical
//        Algo
//        Define a function that takes a non-negative integer as input.
//Create a lookup table that maps each digit to its corresponding English word representation.
//If the input is 0, return "Zero".
//Initialize an empty list to hold the English word representations of the digits.
//While the input is greater than 0:
//    Extract the rightmost digit of the input using modulus.
//    Convert the digit to its English word representation using the lookup table, and append it to the list.
//    Divide the input by 10 and discard any remainder.
//Reverse the list of English word representations.
//Join the list with spaces.
//        **/
//        public string NumberToWords(int num)
//        {
//            // Define a lookup table for numbers up to 19
//            string[] ones = { "", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };

//            // Define a lookup table for multiples of ten
//            string[] tens = { "", "", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };

//            // Define a lookup table for magnitudes
//            string[] magnitudes = { "", "Thousand", "Million", "Billion" };

//            // Define the output string
//            string words = "";

//            // Check if the number is 0
//            if (num == 0)
//            {
//                return "Zero";
//            }

//            // Define a counter for the magnitudes lookup table
//            int magnitudeIndex = 0;

//            while (num > 0)
//            {
//                // Get the current magnitude
//                int magnitude = num % 1000;

//                // Convert the current magnitude to words using recursive division
//                string magnitudeWords = ConvertMagnitudeToWords(magnitude, ones, tens);

//                // If the magnitude is not zero, append it to the output string
//                if (magnitudeWords != "")
//                {
//                    words = magnitudeWords + " " + magnitudes[magnitudeIndex] + " " + words;
//                }

//                // Move to the next magnitude
//                magnitudeIndex++;
//                num /= 1000;
//            }

//            // Return the output string
//            return words.Trim();
//        }

//        // Helper function to convert a magnitude to words using recursive division
//        private string ConvertMagnitudeToWords(int num, string[] ones, string[] tens)
//        {
//            string words = "";

//            // Convert the hundreds place to words
//            if (num >= 100)
//            {
//                words = ones[num / 100] + " Hundred";
//                num %= 100;
//            }

//            // Convert the tens and ones places to words
//            if (num >= 20)
//            {
//                words += " " + tens[num / 10];
//                num %= 10;
//            }

//            if (num > 0)
//            {
//                words += " " + ones[num];
//            }

//            // Return the magnitude in words
//            return words.Trim();
//        }

//        /**
//       TC
//        Time Complexity: O(log n) since the number of iterations is proportional to the number of digits in the input number
//Space Complexity: O(1) since we only use a constant amount of extra space for variables
//       **/
//    }
//    public class Recursive
//    {
//        /**
//        Algo
//        Define a function that takes a non-negative integer as input.
//Create a lookup table that maps each digit or group of digits to its corresponding English word representation.
//Base case: if the input is 0, return "Zero".
//Recursive case:
//    If the input is less than 20, use the lookup table to convert
//        it to its English word representation.
//    If the input is less than 100, use the lookup table to convert
//        the tens digit and the ones digit separately, and then concatenate them with a hyphen.
//    If the input is less than 1000, recursively call the function
//        to convert the hundreds digit, and then concatenate it with
//        "Hundred" and the English word representation of the remaining two digits.
//    If the input is less than 1,000,000, recursively call the
//        function to convert the thousands digit, and then concatenate
//        it with "Thousand" and the English word representation of the remaining three digits.
//    If the input is less than 1,000,000,000, recursively call
//        the function to convert the millions digit, and then concatenate
//        it with "Million" and the English word representation of the remaining six digits.
//    If the input is less than 1,000,000,000,000, recursively call
//        the function to convert the billions digit, and then concatenate
//        it with "Billion" and the English word representation of the remaining nine digits.
//    If the input is greater than or equal to 1,000,000,000,000,
//        recursively call the function to convert the trillions digit,
//        and then concatenate it with "Trillion" and the English word representation
//        of the remaining twelve digits.
//        **/
//        public string NumberToWords(int num)
//        {
//            // Define a lookup table for numbers up to 19
//            string[] ones = { "", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };

//            // Define a lookup table for multiples of ten
//            string[] tens = { "", "", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };

//            if (num < 20)
//            {
//                // If the number is less than 20, use the ones lookup table
//                return ones[num];
//            }
//            else if (num < 100)
//            {
//                // If the number is between 20 and 99, use the tens and ones lookup tables
//                return tens[num / 10] + (num % 10 > 0 ? " " + NumberToWords(num % 10) : "");
//            }
//            else if (num < 1000)
//            {
//                // If the number is between 100 and 999, use recursive division
//                return NumberToWords(num / 100) + " Hundred" + (num % 100 > 0 ? " " + NumberToWords(num % 100) : "");
//            }
//            else if (num < 1000000)
//            {
//                // If the number is between 1000 and 999999, use recursive division with "Thousand" magnitude
//                return NumberToWords(num / 1000) + " Thousand" + (num % 1000 > 0 ? " " + NumberToWords(num % 1000) : "");
//            }
//            else if (num < 1000000000)
//            {
//                // If the number is between 1 million and 999 million, use recursive division with "Million" magnitude
//                return NumberToWords(num / 1000000) + " Million" + (num % 1000000 > 0 ? " " + NumberToWords(num % 1000000) : "");
//            }
//            else
//            {
//                // If the number is between 1 billion and 2^31 - 1, use recursive division with "Billion" magnitude
//                return NumberToWords(num / 1000000000) + " Billion" + (num % 1000000000 > 0 ? " " + NumberToWords(num % 1000000000) : "");
//            }
//        }

//        /**
//        TC
//        Time Complexity: O(log n) since the number of recursive calls is proportional to the number of digits in the input number
//Space Complexity: O(log n) due to the recursive calls and call stack
//        **/
//    }

//    public class Queue
//    {
//        /**
//        Algo
//        Define a function that takes a non-negative integer as input.
//Create a lookup table that maps each digit or group of digits to its corresponding English word representation.
//If the input is 0, return "Zero".
//Convert the input number to a string.
//Initialize an empty stack to hold the groups of digits.
//While the input is greater than 0:
//    Extract the rightmost three digits of the input using modulus.
//    Push the group of digits onto the stack.
//    Divide the input by 1000 and discard any remainder.
//Create an empty list to hold the English word representations of the groups.
//While the stack is not empty:
//    Pop the top group from the stack.
//    If the group is not equal to 0, use the lookup table to convert it to its English word representation, and concatenate it with the appropriate magnitude word (e.g., "Thousand", "Million", etc.).
//    If the group is equal to 0 and there are no more non-zero groups on the stack, skip it.
//    Append the English word representation to the list.
//Join the English word representations of the groups with spaces.
//        **/
//        public string NumberToWords(int num)
//        {
//            // Define a lookup table for numbers up to 19
//            string[] ones = { "", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };

//            // Define a lookup table for multiples of ten
//            string[] tens = { "", "", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };

//            // Define a lookup table for magnitudes
//            string[] magnitudes = { "", "Thousand", "Million", "Billion" };

//            // Define the output queue
//            Queue<string> queue = new Queue<string>();

//            // Check if the number is 0
//            if (num == 0)
//            {
//                return "Zero";
//            }

//            // Define a counter for the magnitude
//            int magnitudeIndex = 0;

//            while (num > 0)
//            {
//                // Get the current magnitude
//                int magnitude = num % 1000;

//                // Convert the current magnitude to words using iterative division
//                string magnitudeWords = "";

//                if (magnitude >= 100)
//                {
//                    magnitudeWords += ones[magnitude / 100] + " Hundred ";
//                    magnitude %= 100;
//                }

//                if (magnitude == 0)
//                {
//                    // Do nothing
//                }
//                else if (magnitude <= 19)
//                {
//                    magnitudeWords += ones[magnitude];
//                }
//                else
//                {
//                    magnitudeWords += tens[magnitude / 10];
//                    magnitude %= 10;

//                    if (magnitude > 0)
//                    {
//                        magnitudeWords += " " + ones[magnitude];
//                    }
//                }

//                // Append the current magnitude to
//                // the queue
//                if (magnitudeWords != "")
//                {
//                    queue.Enqueue(magnitudeWords + " " + magnitudes[magnitudeIndex]);
//                }

//                // Move to the next magnitude
//                magnitudeIndex++;
//                num /= 1000;
//            }

//            // Build the final output string by dequeuing elements from the queue
//            string words = queue.Dequeue();

//            while (queue.Count > 0)
//            {
//                words = queue.Dequeue() + " " + words;
//            }

//            // Return the output string
//            return words.Trim();

//        }

//        /**
//        TC
//        Time Complexity: O(log n) since the number of iterations is proportional to the number of digits in the input number, but with a slightly higher constant factor than the iterative division approach due to the queue operations
//Space Complexity: O(n) since we need to store a dictionary containing all the mappings for numbers up to 1000, and also a queue to hold the number groups
//        **/
//    }
//    public class Regex
//    {
//        /**
//        Algo
//        Define a function that takes a non-negative integer as input.
//Create a lookup table that maps each digit or group of digits
//        If the input is 0, return "Zero".

//Convert the input number to a string.
//Use regular expressions to split the string into groups of three digits starting from the right end.
//Reverse the list of groups.
//Create a lookup table that maps each digit or group of digits to its corresponding English word representation.
//Iterate through the groups from right to left, and for each group:
//If the group is not equal to 0, use the lookup table to convert it to its English word representation, and concatenate it with the appropriate magnitude word (e.g., "Thousand", "Million", etc.).
//If the group is equal to 0, skip it.
//Join the English word representations of the groups with spaces.
//        **/
//        public string NumberToWords(int num)
//        {
//            // Define a lookup table for numbers up to 19
//            string[] ones = { "", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };

//            // Define a lookup table for multiples of ten
//            string[] tens = { "", "", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };

//            // Define a lookup table for magnitudes
//            string[] magnitudes = { "", "Thousand", "Million", "Billion" };

//            // Define the output string
//            string words = "";

//            // Check if the number is 0
//            if (num == 0)
//            {
//                return "Zero";
//            }

//            // Convert the number to a string
//            string numString = num.ToString();

//            // Pad the number string with zeros until its length is a multiple of 3
//            while (numString.Length % 3 != 0)
//            {
//                numString = "0" + numString;
//            }

//            // Divide the number string into groups of 3 digits
//            string[] groups = new string[numString.Length / 3];

//            for (int i = 0; i < groups.Length; i++)
//            {
//                groups[i] = numString.Substring(i * 3, 3);
//            }

//            // Iterate over the groups and convert each group to words
//            for (int i = 0; i < groups.Length; i++)
//            {
//                // Convert the current group to a number
//                int currentGroup = int.Parse(groups[i]);

//                // Convert the current group to words using the ones and tens lookup tables
//                string currentGroupWords = "";

//                if (currentGroup >= 100)
//                {
//                    currentGroupWords += ones[currentGroup / 100] + " Hundred ";
//                    currentGroup %= 100;
//                }

//                if (currentGroup == 0)
//                {
//                    // Do nothing
//                }
//                else if (currentGroup <= 19)
//                {
//                    currentGroupWords += ones[currentGroup];
//                }
//                else
//                {
//                    currentGroupWords += tens[currentGroup / 10];
//                    currentGroup %= 10;

//                    if (currentGroup > 0)
//                    {
//                        currentGroupWords += " " + ones[currentGroup];
//                    }
//                }

//                // Append the current group to the output string, along with the magnitude
//                if (currentGroupWords != "")
//                {
//                    words += currentGroupWords + " " + magnitudes[groups.Length - i - 1] + " ";
//                }
//            }

//            // Remove any extra whitespace from the output string and return it
//            return Regex.Replace(words.Trim(), @"\s+", " ");
//        }


//        /**
//        TC
//        Time Complexity: O(log n) since the number of iterations is proportional to the number of digits in the input number
//Space Complexity: O(1) since we only use a constant amount of extra space for variables
//        **/
//    }
//}

//public class MoveZeroes
//{
//    public class Bloomberg
//    {

//    }
//    public class Problem
//    {
//        /**
//           Given an integer array nums, move all 0's to the end of it while maintaining the relative order of the non-zero elements.

//Note that you must do this in-place without making a copy of the array.
//        **/
//    }
//    public class Example
//    {
//        /**
//            Example 1:

//Input: nums = [0,1,0,3,12]
//Output: [1,3,12,0,0]
//Example 2:

//Input: nums = [0]
//Output: [0]
//         **/
//    }
//    public class ClarifyingQuestions
//    {
//        /**
//           Can you please tell me the size of the input array, nums?
//What should be the output of the function? Should it return anything or modify the input array in-place?
//Are there any constraints on the input array?
//Should the ordering of the non-zero elements be preserved after moving the zeroes to the end?
//Is there a limit to the number of zeroes in the input array?
//        **/
//    }
//    public class DiscussSolutions
//    {
//        /**
//          Two Pointers Approach O(n): This approach involves using two pointers,
//        one to keep track of the current index and another to keep track of
//        the next available index for a non-zero element. As we traverse the
//        array, if we encounter a non-zero element, we swap it with the element
//        at the next available index and increment both pointers. This ensures
//        that all non-zero elements are moved to the front of the array, while
//        the zeroes are moved to the end.

//Count Zeroes Approach O(n) but 3loops: This approach involves first counting the number of
//        zeroes in the input array. Then, we can traverse the array and move
//        all non-zero elements to the front of the array. Finally, we can fill
//        the remaining positions with zeroes, based on the count we obtained earlier.

//Using a Priority Queue Approach O(n log n): This approach involves using a priority queue to keep
//        track of all non-zero elements in the input array. We can then pop elements from
//        the priority queue and append them to the end of the array, while maintaining
//        their relative order.

//Recursive Approach O(n^2): This approach involves recursively swapping the array elements
//        until all zeroes have been moved to the end of the array. The base case for
//        the recursion is when the array is sorted and all zeroes have been moved to
//        the end.
//       **/

//    }
//    public class Use
//    {
//        /** Two Pointer
//        Algo
//        Initialize two pointers, i and j, to 0.
//b. Traverse the array using the i pointer.
//c. If nums[i] is non-zero, swap nums[i] with nums[j] and increment both i and j.
//d. If nums[i] is zero, only increment i.
//e. Repeat steps b through d until i reaches the end of the array.
//        **/
//        public void MoveZeroes(int[] nums)
//        {
//            // Initialize two pointers, i and j, to 0
//            int i = 0, j = 0;

//            // Traverse the array using the i pointer
//            while (i < nums.Length)
//            {
//                // If nums[i] is non-zero, swap nums[i] with nums[j] and increment both i and j
//                if (nums[i] != 0)
//                {
//                    int temp = nums[i];
//                    nums[i] = nums[j];
//                    nums[j] = temp;
//                    j++;
//                }

//                // If nums[i] is zero, only increment i
//                i++;
//            }
//        }

//        /**
//       TC
//        This approach has a time complexity of O(n) and a space complexity of O(1).
//        We use two pointers to traverse the input array and move non-zero elements
//        to the left side of the array, while maintaining the relative order of the
//        elements. This approach requires constant space as we are not using any additional
//        data structures.
//       **/
//    }
//    public class CountZeros
//    {
//        /**
//        Algo
//        Count the number of zeroes in the input array and store the count in a variable.
//b. Initialize a pointer i to 0.
//c. Traverse the array using the i pointer.
//d. If nums[i] is non-zero, move it to the next available position and increment the pointer i.
//e. Repeat steps c through d until i reaches the end of the array.
//f. Fill the remaining positions in the array with zeroes, based on the count obtained in 
//        **/
//        public void MoveZeroes(int[] nums)
//        {
//            // Count the number of zeroes in the input array and store the count in a variable
//            int zeroCount = 0;
//            for (int i = 0; i < nums.Length; i++)
//            {
//                if (nums[i] == 0)
//                {
//                    zeroCount++;
//                }
//            }

//            // Initialize a pointer i to 0
//            int i = 0;

//            // Traverse the array using the i pointer
//            for (int j = 0; j < nums.Length; j++)
//            {
//                // If nums[j] is non-zero, move it to the next available position and increment the pointer i
//                if (nums[j] != 0)
//                {
//                    nums[i] = nums[j];
//                    i++;
//                }
//            }

//            // Fill the remaining positions in the array with zeroes, based on the count obtained earlier
//            for (int j = nums.Length - zeroCount; j < nums.Length; j++)
//            {
//                nums[j] = 0;
//            }
//        }

//        /**
//        TC
//        This approach has a time complexity of O(n) and a space complexity of O(1).
//        We count the number of non-zero elements in the input array and then replace
//        the elements in the array with the non-zero elements, followed by appending
//        zeroes at the end of the array.
//        **/
//    }

//    public class PriorityQueue
//    {
//        /**
//        Algo
//         Initialize a priority queue.
//b. Traverse the array and add all non-zero elements to the priority queue.
//c. Initialize a pointer i to 0.
//d. Pop elements from the priority queue and append them to the array, starting from position i.
//e. Increment i for each element appended to the array.
//f. Repeat steps d through e until the priority queue is empty.
//        **/
//        public void MoveZeroes(int[] nums)
//        {
//            // Initialize a priority queue
//            PriorityQueue<int> pq = new PriorityQueue<int>();

//            // Traverse the array and add all non-zero elements to the priority queue
//            foreach (int num in nums)
//            {
//                if (num != 0)
//                {
//                    pq.Enqueue(num);
//                }

//                // Fill the remaining positions in the array with zeroes
//                int i = 0;
//                while (pq.Count > 0)
//                {
//                    nums[i] = pq.Dequeue();
//                    i++;
//                }

//                while (i < nums.Length)
//                {
//                    nums[i] = 0;
//                    i++;
//                }
//            }
//        }
//        /**
//        TC
//        This approach has a time complexity of O(n log n) and a space complexity of O(n).
//        We use a priority queue to store the non-zero elements of the input array, which
//        automatically sorts the elements in ascending order. We then dequeue the elements
//        and put them back in the input array in the correct order.
//        **/
//    }
//    public class Recursive
//    {
//        /**
//        Algo
//        Define a recursive function that takes in the input array, a start index, and an end index.
//b. If the start index is greater than or equal to the end index, return.
//c. Traverse the array from start to end using a pointer i.
//d. If nums[i] is zero, swap nums[i] with nums[end] and decrement the end index.
//e. If nums[i] is non-zero, increment the pointer i.
//f. Call the recursive function with the updated start and end indices.
//        **/
//        public void MoveZeroes(int[] nums)
//        {
//            MoveZeroesHelper(nums, 0);
//        }

//        private void MoveZeroesHelper(int[] nums, int start)
//        {
//            // Base case: if start reaches the end of the array, return
//            if (start == nums.Length)
//            {
//                return;
//            }

//            // Recursive case: if nums[start] is zero, move all non-zero elements to the left of it
//            // by swapping it with the next non-zero element
//            if (nums[start] == 0)
//            {
//                int nextNonZeroIndex = start + 1;
//                while (nextNonZeroIndex < nums.Length && nums[nextNonZeroIndex] == 0)
//                {
//                    nextNonZeroIndex++;
//                }

//                if (nextNonZeroIndex < nums.Length)
//                {
//                    int temp = nums[start];
//                    nums[start] = nums[nextNonZeroIndex];
//                    nums[nextNonZeroIndex] = temp;
//                }
//            }

//            // Recursively call MoveZeroesHelper on the next index
//            MoveZeroesHelper(nums, start + 1);
//        }

//        /**
//        TC
//        This approach has a time complexity of O(n^2) and a space complexity of O(n)
//        due to the recursion stack. We use a recursive helper function to move all
//        non-zero elements to the left of each zero element in the input array.

//        **/
//    }
//}
//public class FirstUniqueCharacterinaString
//{//First Unique Character in a String
//    public class Bloomberg
//    {

//    }
//    public class Problem
//    {
//        /**
//           Given a string s, find the first non-repeating character in it and return its index. If it does not exist, return -1.
//        **/
//    }
//    public class Example
//    {
//        /**
//            Input: s = "leetcode"
//Output: 0
//Example 2:

//Input: s = "loveleetcode"
//Output: 2
//Example 3:

//Input: s = "aabb"
//Output: -1
//         **/
//    }
//    public class ClarifyingQuestions
//    {
//        /**
//Can you give me an example of input and expected output for this problem?

//Are the characters in the string case-sensitive?

//Can the string contain special characters or only alphabets?

//Is there a constraint on the size of the input string?

//Can I assume that the input string is non-empty?
//        **/
//    }
//    public class DiscussSolutions
//    {
//        /**
// Brute Force Approach: One way to solve this problem is by iterating
//        over the string and comparing each character with every other
//        character in the string. This approach would have a time complexity
//        of O(n^2), where n is the length of the input string.

//Hash Map Approach: Another approach is to use a hash map to store the
//        frequency of each character in the string. After building the hash
//        map, we can then iterate over the string and check for the first 
//        character with a frequency of 1. This approach would have a time 
//        complexity of O(2n) = O(n), where n is the length of the input string.

//Queue Approach: We can use a queue to store the characters and their 
//        frequency in the order they appear in the string. After building
//        the queue, we can then iterate over the queue and check for the 
//        first character with a frequency of 1. This approach would have a
//        time complexity of O(n), where n is the length of the input string.
//       **/

//    }
//    public class Use
//    {
//        //Hash Map
//        /**
//        Algo
//        Create an empty hash map to store the frequency of each character.
//Iterate over each character in the string and update its frequency in the hash map.
//Iterate over the string again and check if the frequency of each character is 1.  
//If the frequency is 1, return the index of that character.
//If there are no non-repeating characters, return -1.
//        **/
//        public int FirstUniqChar(string s)
//        {
//            // Create an empty hash map to store the frequency of each character.
//            Dictionary<char, int> charFreq = new Dictionary<char, int>();
//            // Iterate over each character in the string and update its frequency in the hash map.
//            foreach (char c in s)
//            {
//                if (charFreq.ContainsKey(c))
//                {
//                    charFreq[c]++;
//                }
//                else
//                {
//                    charFreq[c] = 1;
//                }
//            }
//            // Iterate over the string again and check if the frequency of each character is 1.
//            for (int i = 0; i < s.Length; i++)
//            {
//                if (charFreq[s[i]] == 1)
//                {
//                    // If the frequency is 1, return the index of that character.
//                    return i;
//                }
//            }
//            // If there are no non-repeating characters, return -1.
//            return -1;
//        }

//        /**
//       TC
//        The Hash Map approach has a time complexity of O(2n) = O(n)  since we are iterating over the
//        string only once and performing constant-time operations on the hash map. 
//        It has a space complexity of O(k) where k is the size of the character set,
//        since we are using a hash map to store the frequency of each character.
//       **/
//    }
//    public class BruteForce
//    {
//        /**
//        Algo
//        Iterate over each character in the string.
//For each character, iterate over the entire string again to check if it's a non-repeating character.
//If the character is non-repeating, return its index.
//If there are no non-repeating characters, return -1.
//        **/
//        public int FirstUniqChar(string s)
//        {
//            // Iterate over each character in the string.
//            for (int i = 0; i < s.Length; i++)
//            {
//                bool isDuplicate = false;
//                // For each character, iterate over the entire string again
//                // to check if it's a non-repeating character.
//                for (int j = 0; j < s.Length; j++)
//                {
//                    if (i != j && s[i] == s[j])
//                    {
//                        // If the character is repeated, mark it as a
//                        // duplicate and break out of the inner loop.
//                        isDuplicate = true;
//                        break;
//                    }
//                }
//                // If the character is not a duplicate, return its index.
//                if (!isDuplicate)
//                {
//                    return i;
//                }
//            }
//            // If there are no non-repeating characters, return -1.
//            return -1;
//        }

//        /**
//        TC
//         The Brute Force approach has a time complexity of O(n^2) since
//        we are iterating over the string twice and checking each
//        character against all the other characters. It has a space
//        complexity of O(1) since we are not using any extra data
//        structures.
//        **/
//    }

//    public class Queue
//    {
//        /**
//        Algo
//Create an empty queue to store the characters and their frequency in the order they appear in the string.
//Iterate over each character in the string and update its frequency in the queue.
//Iterate over the queue and check if the frequency of each character is 1.
//If the frequency is 1, return the index of that character.
//If there are no non-repeating characters, return -1.
//        **/
//        public int FirstUniqChar(string s)
//        {
//            // Create a hash map to store the frequency of each character and a queue to store non-repeating characters.
//            Dictionary<char, int> charFreq = new Dictionary<char, int>();
//            Queue<int> nonRepeatingChars = new Queue<int>();

//            // Iterate over each character in the string and update its frequency in the hash map.
//            for (int i = 0; i < s.Length; i++)
//            {
//                char c = s[i];
//                if (charFreq.ContainsKey(c))
//                {
//                    charFreq[c]++;
//                }
//                else
//                {
//                    charFreq[c] = 1;
//                    nonRepeatingChars.Enqueue(i);
//                }
//            }

//            // Dequeue the index of the first non-repeating character from the queue and return it.
//            while (nonRepeatingChars.Count > 0)
//            {
//                int index = nonRepeatingChars.Dequeue();
//                if (charFreq[s[index]] == 1)
//                {
//                    return index;
//                }
//            }

//            // If there are no non-repeating characters, return -1.
//            return -1;
//        }

//        /**
//        TC
//        The Queue approach has a time complexity of O(n) since we are 
//        iterating over the string only twice (once to update the
//        hash map and the queue, and once to dequeue the non-repeating
//        characters) and performing constant-time operations on the hash
//        map and the queue. It has a space complexity of O(k) where k is
//        the size of the character set, since we are using a hash map to
//        store the frequency of each character and a queue to store the
//        indices of non-repeating characters.
//        **/
//    }
//    public class LinkedList
//    {
//        /**
//        Algo
//        Create a doubly linked list and initialize two pointers: head and tail.
//Iterate over the input string character by character.
//For each character:
//    Check if the character is already present in the linked list. If it is,
//        remove the node from the list since it is no longer a non-repeating character.
//    If the character is not present in the list, create a new node for it
//        and append it to the tail of the linked list.
//After iterating over the entire string, the head of the linked list will 
//        point to the first non-repeating character in the string. If the head 
//        is NULL, then there are no non-repeating characters in the string.
//Return the index of the first non-repeating character by iterating over the
//        string again and comparing each character with the character at the head node of the linked list.
//        **/
//        public int FirstUniqChar(string s)
//        {
//            // Create a hash map to store the frequency of each character and a linked list to store non-repeating characters.
//            Dictionary<char, int> charFreq = new Dictionary<char, int>();
//            LinkedList<int> nonRepeatingChars = new LinkedList<int>();
//            LinkedListNode<int>[] nodes = new LinkedListNode<int>[26];

//            // Iterate over each character in the string and update its frequency in the hash map.
//            for (int i = 0; i < s.Length; i++)
//            {
//                char c = s[i];
//                if (charFreq.ContainsKey(c))
//                {
//                    charFreq[c]++;
//                    if (nodes[c - 'a'] != null)
//                    {
//                        nonRepeatingChars.Remove(nodes[c - 'a']);
//                        nodes[c - 'a'] = null;
//                    }
//                }
//                else
//                {
//                    charFreq[c] = 1;
//                    LinkedListNode<int> node = nonRepeatingChars.AddLast(i);
//                    nodes[c - 'a'] = node;
//                }
//            }

//            // Check the first node in the linked list to see if it has a frequency of 1.
//            if (nonRepeatingChars.First != null && charFreq[s[nonRepeatingChars.First.Value]] == 1)
//            {
//                return nonRepeatingChars.First.Value;
//            }

//            // If there are no non-repeating characters, return -1.
//            return -1;
//        }

//        /**
//        TC
//        The Linked List approach has a time complexity of O(n) since we are
//        iterating over the string only once and performing constant-time 
//        operations on the hash map and the linked list. It has a space 
//        complexity of O(k) where k is the size of the character set, 
//        since we are using a hash map to store the frequency of each 
//        character and a linked list to store the indices of non-repeating characters.
//        **/
//    }
//}

//public class StringCompression
//{
//    public class Bloomberg
//    {

//    }
//    public class Problem
//    {
//        /**
//           Given an array of characters chars, compress it using the following algorithm:

//Begin with an empty string s. For each group of consecutive repeating characters in chars:

//If the group's length is 1, append the character to s.
//Otherwise, append the character followed by the group's length.
//The compressed string s should not be returned separately, but instead, be stored in the input character array chars. Note that group lengths that are 10 or longer will be split into multiple characters in chars.

//After you are done modifying the input array, return the new length of the array.

//You must write an algorithm that uses only constant extra space.
//        **/
//    }
//    public class Example
//    {
//        /**
//            Example 1:

//Input: chars = ["a","a","b","b","c","c","c"]
//Output: Return 6, and the first 6 characters of the input array should be: ["a","2","b","2","c","3"]
//Explanation: The groups are "aa", "bb", and "ccc". This compresses to "a2b2c3".
//Example 2:

//Input: chars = ["a"]
//Output: Return 1, and the first character of the input array should be: ["a"]
//Explanation: The only group is "a", which remains uncompressed since it's a single character.
//Example 3:

//Input: chars = ["a","b","b","b","b","b","b","b","b","b","b","b","b"]
//Output: Return 4, and the first 4 characters of the input array should be: ["a","b","1","2"].
//Explanation: The groups are "a" and "bbbbbbbbbbbb". This compresses to "ab12".
//         **/
//    }
//    public class ClarifyingQuestions
//    {
//        /**
//           What is the size range of the input array 'chars'?
//Can we assume that the input array 'chars' contains only uppercase and lowercase English letters?
//Should the function modify the original input array or create a new one?
//Is it acceptable to modify the input array in place, including removing elements?
//Can we assume that the input array 'chars' is not null or empty?
//Is it required to return the compressed string s, or just the new length of the array?
//Is it necessary to preserve the order of characters in the compressed string?
//Can we use any built-in functions or libraries in our solution?
//        **/
//    }
//    public class DiscussSolutions
//    {
//        /**
//Two-Pointer Approach: This approach involves using two pointers 
//to keep track of the beginning and end of each group of consecutive 
//repeating characters. We can then iterate through the array, update 
//the pointers, and append the compressed characters to the output string.

//Iterative Approach: This approach involves iterating through the array
// and keeping track of the current character and its count. Whenever
//  the current character changes, we append the compressed characters 
//  to the output string and reset the count.

//Using a Stack: This approach involves using a stack to keep track of 
//the current group of repeating characters. We can then iterate through
// the array, push the current character onto the stack if it matches 
// the top element, and pop the stack if it doesn't match. Whenever we
//  pop the stack, we append the compressed characters to the output string.

//Using String Concatenation: This approach involves concatenating the
// compressed characters directly to the output string instead of appending
//  them to an intermediate data structure. We can then iterate through 
//  the array and update the output string accordingly.
//       **/

//    }
//    public class Use
//    { //two - pointers
//        /**
//        Algo
//Initialize variables currentChar and count to the 
//first character in the array and 1, respectively.
//Iterate through the array from the second character.
//If the current character is the same as the previous character, increment the count.
//If the current character is different from the previous character,
// append the previous character to the output string, followed by
//  its count if the count is greater than 1.
//Update currentChar to the current character and reset the count to 1.
//After the loop, append the last character to the output string, followed 
//by its count if the count is greater than 1.
//        **/
//        public int Compress(char[] chars)
//        {
//            int i = 0; // Initialize pointer i to the beginning of the array
//            int j = 0; // Initialize pointer j to the beginning of the array
//            while (j < chars.Length)
//            { // Iterate through the array using pointer j
//                int count = 1; // Initialize count to 1
//                               // While the next character is the same as the current character and we have not reached the end of the array
//                while (j + 1 < chars.Length && chars[j] == chars[j + 1])
//                {
//                    count++; // Increment the count
//                    j++; // Move pointer j to the next character
//                }
//                chars[i++] = chars[j]; // Append the current character to the output array
//                if (count > 1)
//                { // If the count is greater than 1
//                  // Convert the count to a string and iterate through each character
//                    foreach (char c in count.ToString())
//                    {
//                        chars[i++] = c; // Append the current digit to the output array
//                    }
//                }
//                j++; // Move pointer j to the next character
//            }

//            return i; // Return the new length of the array
//        }

//        /**
//       TC
//       Time complexity: O(n), where n is the length of the input array. This is because we only iterate over the array once.
//Space complexity: O(1), since we only use constant extra space.
//       **/
//    }
//    public class Stack
//    {
//        /**
//        Algo
//Initialize an empty stack and push the first character in the array onto the stack.
//Iterate through the array from the second character.
//If the current character is the same as the top element of the stack,
// push the current character onto the stack.
//If the current character is different from the top element of the stack,
// pop the stack and append the popped character to the output string,
//  followed by its count if the count is greater than 1.
//Repeat steps 3-4 until the stack is empty or the current character is 
//successfully pushed onto the stack.
//After the loop, pop any remaining characters from the stack and append them to 
//the output string, followed by their counts if the counts are greater than 1.
//        **/
//        public int Compress(char[] chars)
//        {
//            Stack<(char, int)> stack = new Stack<(char, int)>(); // Initialize a stack to hold pairs of characters and their counts
//            foreach (char c in chars)
//            { // Iterate through the characters in the input array
//              // If the stack is empty or the top element is not the same as the current character
//                if (!stack.TryPeek(out var top) || top.Item1 != c)
//                {
//                    stack.Push((c, 1)); // Push a new pair onto the stack with count 1
//                }
//                else
//                { // If the top element is the same as the current character
//                    stack.Pop();
//                    stack.Push((c, top.Item2 + 1)); // Increment the count of the top element
//                }
//            }
//            int i = 0; // Initialize pointer i to the beginning of the array
//            while (stack.Count > 0)
//            { // While the stack is not empty
//                var (c, count) = stack.Pop(); // Get the top pair from the stack
//                chars[i] = c; // Append the character to the output array
//                i++;
//                if (count > 1)
//                { // If the count is greater than 1
//                    string count_str = count.ToString(); // Convert the count to a string
//                    foreach (char ch in count_str)
//                    { // Iterate through each character in the string
//                        chars[i] = ch; // Append the current digit to the output array
//                        i++;
//                    }
//                }
//            }
//            Array.Reverse(chars, 0, i); // Reverse the output array
//            return i; // Return the new length of the array
//        }
//        /**
//        TC
//        Time complexity: O(n), where n is the length of the input array. 
//        This is because we only iterate over the array once and perform constant time operations on the stack.
//Space complexity: O(n), since we use a stack to store the characters and their counts. 
//In the worst case, when all characters are unique, the stack will contain n elements.
//        **/
//    }

//    public class StringConcatenation
//    {
//        /**
//        Algo
//        Initialize an empty output string and variables currentChar and 
//        count to the first character in the array and 1, respectively.
//Iterate through the array from the second character.
//If the current character is the same as the previous character, increment the count.
//If the current character is different from the previous character, 
//    append the previous character to the output string, followed by its count if the count is greater than 1.
//Update currentChar to the current character and reset the count to 1.
//After the loop, append the last character to the output string, followed by its count if the count is greater than 1.
//        **/
//        public int Compress(char[] chars)
//        {
//            // check if the array is null or empty
//            if (chars == null || chars.Length == 0)
//            {
//                return 0;
//            }

//            // initialize variables
//            char prev = chars[0]; // previous character
//            int count = 1; // count of consecutive characters
//            string result = ""; // compressed string

//            // loop through the array
//            for (int i = 1; i < chars.Length; i++)
//            {
//                // if current character is the same as previous character
//                if (chars[i] == prev)
//                {
//                    count++; // increment count
//                }
//                else
//                { // if current character is different from previous character
//                  // append previous character to result string
//                    result += prev;
//                    // if count is greater than 1, append count as string to result string
//                    if (count > 1)
//                    {
//                        result += count.ToString();
//                    }
//                    // update previous character and reset count
//                    prev = chars[i];
//                    count = 1;
//                }
//            }

//            // append last character and count to result string
//            result += prev;
//            if (count > 1)
//            {
//                result += count.ToString();
//            }

//            // copy result string to original char array and return length of compressed array
//            char[] res = result.ToCharArray();
//            Array.Copy(res, chars, res.Length);
//            return res.Length;
//        }

//        /**
//        TC
//        Time complexity: O(n), where n is the length of the input array. 
//        This is because we only iterate over the array once and perform constant time operations on the string.
//Space complexity: O(n), since we use a string to store the compressed characters.
// In the worst case, when all characters are unique, the string will contain n elements.
//        **/
//    }
//}

//public class SubarraySumEqualsK
//{
//    public class Bloomberg
//    {

//    }
//    public class Problem
//    {
//        /**
//           Given an array of integers nums and an integer k, return the total number of subarrays whose sum equals to k.

//A subarray is a contiguous non-empty sequence of elements within an array.
//        **/
//    }
//    public class Example
//    {
//        /**
//            Example 1:

//Input: nums = [1,1,1], k = 2
//Output: 2
//Example 2:

//Input: nums = [1,2,3], k = 3
//Output: 2
//         **/
//    }
//    public class ClarifyingQuestions
//    {
//        /**
//           Can the input array contain negative integers?
//Is the subarray required to be non-empty?
//Are there any constraints on the size of the input array and the value of k?
//Are we allowed to use additional data structures or do we need to solve this problem in-place?
//Can the input array contain duplicates? If yes, do we need to consider all possible combinations of subarrays with the same sum?
//        **/
//    }
//    public class DiscussSolutions
//    {
//        /**
//          Brute Force: This involves using two nested loops to iterate over all
//           possible subarrays of the input array and checking if their sum equals k.
//            This approach has a time complexity of O(n^2), where n is the size of the input array.

//Hash Map - Use: This approach involves using a hash map to store the cumulative sum of 
//the elements in the array up to a certain index. We then iterate over the array 
//and for each index, we check if the difference between the cumulative sum up to 
//that index and k exists in the hash map. If it does, we increment the count of 
//subarrays. This approach has a time complexity of O(n), where n is the size of the input array.

//Prefix Sum: This approach is similar to the hash map approach but uses an array 
//to store the cumulative sum instead of a hash map. We then iterate over the array 
//and for each index, we check if the difference between the cumulative sum up to 
//that index and k exists in the prefix sum array. If it does, we increment the 
//count of subarrays. This approach also has a time complexity of O(n), where n 
//is the size of the input array.

//Two Pointers: This approach involves using two pointers to maintain a sliding 
//window of the subarray. We initialize two pointers, left and right, at the start 
//of the array. We then move the right pointer forward until the sum of the subarray 
//is greater than or equal to k. At this point, we increment the count of subarrays 
//and move the left pointer forward until the sum of the subarray is less than k. 
//We repeat this process until we reach the end of the array. This approach also 
//has a time complexity of O(n^2), where n is the size of the input array.
//       **/

//    }
//    public class UseThis
//    {//Hash map
//        /**
//        Algo
//        . Initialize a count variable to zero.
//b. Initialize a hash map with an initial key-value pair of (0,1) to handle the case where a subarray starting from index 0 has sum k.
//c. Initialize a variable 'sum' to 0.
//d. Iterate over the input array from left to right.
//e. For each element, add it to 'sum'.
//f. Compute the difference between 'sum' and k.
//g. If the difference exists in the hash map, add the value associated with that key to the count variable.
//h. If the difference does not exist in the hash map, add a new key-value pair of (sum,1) to the hash map.
//i. Return the count variable.
//        **/
//        public static int SubarraySum(int[] nums, int k)
//        {
//            int count = 0; // Initialize count variable to 0
//            int sum = 0;
//            Dictionary<int, int> map = new Dictionary<int, int>();
//            map.Add(0, 1); // Add an initial key-value pair to the map

//            for (int i = 0; i < nums.Length; i++)
//            {
//                sum += nums[i];

//                // If the map already contains the complement, increment the count 
//                //by the value of the complement in the map
//                if (map.ContainsKey(sum - k))
//                {
//                    count += map[sum - k];
//                }

//                // Add the current sum to the map
//                if (map.ContainsKey(sum))
//                {
//                    map[sum]++;
//                }
//                else
//                {
//                    map.Add(sum, 1);
//                }
//            }

//            return count; // Return the count variable
//        }
//        /**
//        TC
//        The time complexity of this approach is O(n), where n is the length of the input array
//        , since we traverse the input array only once. 
//        The space complexity is also O(n) since in the worst case scenario, 
//        all elements of the input array can be distinct and hence the hash map would 
//        need to store n distinct entries.
//        **/
//    }
//    public class TwoPointer
//    {
//        /**
//        Algo
//        Initialize a count variable to zero.
//b. Initialize two pointers, left and right, to the start of the input array.
//c. Initialize a variable 'sum' to 0.
//d. Iterate over the input array from left to right using the right pointer.
//e. For each element, add it to 'sum'.
//f. While the sum is greater than k, move the left pointer forward and subtract the corresponding element from 'sum'.
//g. If the sum equals k, increment the count variable.
//h. Repeat steps d-g until the right pointer reaches the end of the input array.
//i. Return the count variable.
//        **/
//        public int SubarraySum(int[] nums, int k)
//        {
//            int count = 0; // Initialize count variable
//            int left = 0; // Initialize left pointer
//            int right = 0; // Initialize right pointer
//            int sum = 0; // Initialize sum variable

//            while (right < nums.Length)
//            { // Loop through nums array
//                sum += nums[right]; // Add current element to sum
//                right++; // Increment right pointer

//                while (left < right && sum > k)
//                { // If sum is greater than k, move the left pointer and subtract the element
//                    sum -= nums[left];
//                    left++;
//                }

//                if (sum == k)
//                { // If sum equals k, increment count
//                    count++;
//                }
//            }

//            return count; // Return the count variable
//        }

//        /**
//       TC
//       The time complexity of this approach is O(n),
//        where n is the length of the input array, since we traverse the input array only once.
//         The space complexity is O(1) since we are not using any extra space other than some 
//         constant number of variables.
//       **/
//    }
//    public class BruteForce
//    {
//        /**
//        Algo
//        Initialize a count variable to zero.
//b. Iterate over all possible subarrays of the input array using two nested loops.
//c. For each subarray, compute the sum of its elements.
//d. If the sum equals k, increment the count variable.
//e. Return the count variable.
//        **/
//        public static int SubarraySum(int[] nums, int k)
//        {
//            int count = 0; // Initialize count variable to 0
//            for (int i = 0; i < nums.Length; i++)
//            {
//                int sum = 0;
//                for (int j = i; j < nums.Length; j++)
//                {
//                    sum += nums[j];
//                    if (sum == k)
//                    {
//                        count++;
//                    }
//                }
//            }
//            return count; // Return the count variable
//        }

//        /**
//        TC
//        We use two nested loops to iterate through all possible subarrays of the given array.
//         The time complexity of this approach is O(n^2), where n is the length of the input array. 
//         The space complexity is O(1) since we are not using any extra space other than the input
//          array.
//        **/
//    }


//    public class PrefixSum
//    {
//        /**
//        Algo
//        a. Initialize a count variable to zero.
//b. Initialize a prefix sum array of size n+1, where n is the size of the input array, with an initial value of 0 at index 0.
//c. Initialize a variable 'sum' to 0.
//d. Iterate over the input array from left to right.
//e. For each element, add it to 'sum' and store the value in the prefix sum array at the current index + 1.
//f. Compute the difference between the current prefix sum and k.
//g. If the difference exists in the prefix sum array up to the current index, add the number of occurrences to the count variable.
//h. Increment the value of the prefix sum array at the current index + 1.
//i. Return the count variable.
//        **/
//        public static int SubarraySum(int[] nums, int k)
//        {
//            int count = 0; // Initialize count variable to 0
//            int[] prefixSum = new int[nums.Length + 1]; // Initialize prefix sum array of size nums.Length + 1
//            prefixSum[0] = 0; // Set the first element of the prefix sum array to 0

//            // Calculate the prefix sum of nums array and store it in prefixSum array
//            for (int i = 1; i <= nums.Length; i++)
//            {
//                prefixSum[i] = prefixSum[i - 1] + nums[i - 1];
//            }

//            // Calculate the subarray sum by subtracting two prefix sums
//            for (int i = 0; i < nums.Length; i++)
//            {
//                for (int j = i + 1; j <= nums.Length; j++)
//                {
//                    if (prefixSum[j] - prefixSum[i] == k)
//                    { // If the subarray sum equals k, increment count
//                        count++;
//                    }
//                }
//            }

//            return count; // Return the count variable
//        }

//        /**
//        TC
//        The time complexity of this approach is O(n), where n is the length of the input array, 
//        since we traverse the input array only twice. 
//        The space complexity is O(n) since we use an extra prefix sum array of length n.
//        **/
//    }
//}

//public class Q
//{
//    public class Bloomberg
//    {

//    }
//    public class Problem
//    {
//        /**
           
//        **/
//    }
//    public class Example
//    {
//        /**
            
//         **/
//    }
//    public class ClarifyingQuestions
//    {
//        /**
           
//        **/
//    }
//    public class DiscussSolutions
//    {
//        /**
          
//       **/

//    }
//    public class Use
//    {
//        /**
//        Algo
//        **/
//        /**
//       TC
//       **/
//    }
//    public class BruteForce
//    {
//        /**
//        Algo
//        **/
//        /**
//        TC
//        **/
//    }

//    public class DP
//    {
//        /**
//        Algo
//        **/
//        /**
//        TC
//        **/
//    }
//    public class DP
//    {
//        /**
//        Algo
//        **/
//        /**
//        TC
//        **/
//    }
//}
