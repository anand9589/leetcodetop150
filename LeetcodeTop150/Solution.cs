namespace LeetcodeTop150
{
    public class Solution
    {
        #region Problem 1 88. Merge Sorted Array

        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            for (int i = nums1.Length - 1; i >= 0; i--)
            {
                if (n == 0)
                {
                    nums1[i] = nums1[m - 1];
                    m--;
                }
                else if (m == 0)
                {
                    nums1[i] = nums2[n - 1];
                    n--;

                }
                else if (nums1[m - 1] > nums2[n - 1])
                {
                    nums1[i] = nums1[m - 1];
                    m--;
                }
                else
                {
                    nums1[i] = nums2[n - 1];
                    n--;
                }
            }
        }
        #endregion
        #region Problem 2
        #endregion
        #region Problem 3
        #endregion
        #region Problem 4
        #endregion
        #region Problem 5
        #endregion
        #region Problem 6
        #endregion
        #region Problem 7
        #endregion
        #region Problem 8
        #endregion
        #region Problem 9
        #endregion
        #region Problem 10
        #endregion
        #region Problem 11
        #endregion
        #region Problem 12
        #endregion
        #region Problem 13
        #endregion
        #region Problem 14
        #endregion
        #region Problem 15
        #endregion
        #region Problem 16
        #endregion
        #region Problem 17
        #endregion
        #region Problem 18
        #endregion
        #region Problem 19
        #endregion
        #region Problem 20
        #endregion
        #region Problem 21
        #endregion
        #region Problem 22
        #endregion
        #region Problem 23
        #endregion
        #region Problem 24
        #endregion
        #region Problem 25
        #endregion
        #region Problem 26
        #endregion
        #region Problem 27
        #endregion
        #region Problem 28
        #endregion
        #region Problem 29
        #endregion
        #region Problem 30
        #endregion
        #region Problem 31
        #endregion
        #region Problem 32
        #endregion
        #region Problem 33
        #endregion
        #region Problem 34
        #endregion
        #region Problem 35
        #endregion
        #region Problem 36
        #endregion
        #region Problem 37
        #endregion
        #region Problem 38
        #endregion
        #region Problem 39
        #endregion
        #region Problem 40
        #endregion
        #region Problem 41
        #endregion
        #region Problem 42
        #endregion
        #region Problem 43
        #endregion
        #region Problem 44
        #endregion
        #region Problem 45
        #endregion
        #region Problem 46
        #endregion
        #region Problem 47
        #endregion
        #region Problem 48
        #endregion
        #region Problem 49
        #endregion
        #region Problem 50
        #endregion
        #region Problem 51
        #endregion
        #region Problem 52
        #endregion
        #region Problem 53
        #endregion
        #region Problem 54
        #endregion
        #region Problem 55
        #endregion
        #region Problem 56
        #endregion
        #region Problem 57
        #endregion
        #region Problem 58
        #endregion
        #region Problem 59
        #endregion
        #region Problem 60
        #endregion
    }
}
