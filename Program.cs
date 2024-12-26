//*****************************************************************************
//** 494. Target Sum                                                leetcode **
//*****************************************************************************

int findTotalWays(int* nums, int numsSize, int i, int s, int target)
{
    if (s == target && i == numsSize)
    {
        return 1;
    }

    if (i >= numsSize)
    {
        return 0;
    }

    return findTotalWays(nums, numsSize, i + 1, s + nums[i], target) +
           findTotalWays(nums, numsSize, i + 1, s - nums[i], target);
}

int findTargetSumWays(int* nums, int numsSize, int target)
{
    return findTotalWays(nums, numsSize, 0, 0, target);
}