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

        #region Problem 2 27. Remove Element
        public int RemoveElement(int[] nums, int val)
        {
            int j = 0;
            int i = 0;

            while (j < nums.Length)
            {
                if (nums[j] != val)
                {
                    nums[i++] = nums[j];
                }
                j++;
            }

            return i;
        }
        #endregion

        #region Problem 3 26. Remove Duplicates from Sorted Array
        public int RemoveDuplicates_V1(int[] nums)
        {
            int indexJ = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                while (i < nums.Length && nums[i] == nums[i - 1])
                {
                    i++;
                }
                if (i < nums.Length)
                {
                    nums[indexJ] = nums[i];
                    indexJ++;
                }
            }

            return indexJ;
        }

        #endregion

        #region Problem 4
        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length <= 2) return nums.Length;
            int i = 2, j = 2;

            while (j < nums.Length)
            {
                if (nums[j] != nums[i - 2])
                {
                    nums[i++] = nums[j];
                }
                j++;

            }
            return i;
        }
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
        #region Problem 61
        #endregion
        #region Problem 62
        #endregion
        #region Problem 63
        #endregion
        #region Problem 64
        #endregion
        #region Problem 65
        #endregion
        #region Problem 66
        #endregion
        #region Problem 67
        #endregion
        #region Problem 68
        #endregion
        #region Problem 69
        #endregion
        #region Problem 70
        #endregion
        #region Problem 71
        #endregion
        #region Problem 72
        #endregion
        #region Problem 73
        #endregion
        #region Problem 74
        #endregion
        #region Problem 75
        #endregion
        #region Problem 76
        #endregion
        #region Problem 77
        #endregion
        #region Problem 78
        #endregion
        #region Problem 79
        #endregion
        #region Problem 80
        #endregion
        #region Problem 81
        #endregion
        #region Problem 82
        #endregion
        #region Problem 83
        #endregion
        #region Problem 84
        #endregion
        #region Problem 85
        #endregion
        #region Problem 86
        #endregion
        #region Problem 87
        #endregion
        #region Problem 88
        #endregion
        #region Problem 89
        #endregion
        #region Problem 90
        #endregion
        #region Problem 91
        #endregion
        #region Problem 92
        #endregion
        #region Problem 93
        #endregion
        #region Problem 94
        #endregion
        #region Problem 95
        #endregion
        #region Problem 96
        #endregion
        #region Problem 97
        #endregion
        #region Problem 98
        #endregion
        #region Problem 99
        #endregion
        #region Problem 100
        #endregion
        #region Problem 101
        #endregion
        #region Problem 102
        #endregion
        #region Problem 103
        #endregion
        #region Problem 104
        #endregion
        #region Problem 105
        #endregion
        #region Problem 106
        #endregion
        #region Problem 107
        #endregion
        #region Problem 108
        #endregion
        #region Problem 109
        #endregion
        #region Problem 110
        #endregion
        #region Problem 111
        #endregion
        #region Problem 112
        #endregion
        #region Problem 113
        #endregion
        #region Problem 114
        #endregion
        #region Problem 115
        #endregion
        #region Problem 116
        #endregion
        #region Problem 117
        #endregion
        #region Problem 118
        #endregion
        #region Problem 119
        #endregion
        #region Problem 120
        #endregion
        #region Problem 121
        #endregion
        #region Problem 122
        #endregion
        #region Problem 123
        #endregion
        #region Problem 124
        #endregion
        #region Problem 125
        #endregion
        #region Problem 126
        #endregion
        #region Problem 127
        #endregion
        #region Problem 128
        #endregion
        #region Problem 129
        #endregion
        #region Problem 130
        #endregion
        #region Problem 131
        #endregion
        #region Problem 132
        #endregion
        #region Problem 133
        #endregion
        #region Problem 134
        #endregion
        #region Problem 135
        #endregion
        #region Problem 136
        #endregion
        #region Problem 137
        #endregion
        #region Problem 138
        #endregion
        #region Problem 139
        #endregion
        #region Problem 140
        #endregion
        #region Problem 141
        #endregion
        #region Problem 142
        #endregion
        #region Problem 143
        #endregion
        #region Problem 144
        #endregion
        #region Problem 145
        #endregion
        #region Problem 146
        #endregion
        #region Problem 147
        #endregion
        #region Problem 148
        #endregion
        #region Problem 149
        #endregion
        #region Problem 150
        #endregion
    }
}
