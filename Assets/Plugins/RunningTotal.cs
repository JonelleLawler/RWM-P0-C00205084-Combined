using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RunningTotal
{
    public static int[] runTotal(int[] nums)
    {
        int[] result = new int[nums.Length];

        // not including first num in loop
        result[0] = nums[0];

        for(int i = 1; i < nums.Length; i++) // start at second number
        {
            result[i] = nums[i] += nums[i - 1];
        }

        return result;
    }
}
