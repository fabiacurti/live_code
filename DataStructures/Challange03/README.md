# 🔄 Rotate Array

## Description

Given an array `nums` and an integer `k`, rotate the array to the right by `k` steps, where `k` is non-negative.

You must do this **in-place** with `O(1)` extra space if possible.

---

## Example 1

```id="ex1"
Input: nums = [1,2,3,4,5,6,7], k = 3
Output: [5,6,7,1,2,3,4]
```

**Explanation:**
Rotate 1 step: `[7,1,2,3,4,5,6]`
Rotate 2 steps: `[6,7,1,2,3,4,5]`
Rotate 3 steps: `[5,6,7,1,2,3,4]`

---

## Example 2

```id="ex2"
Input: nums = [-1,-100,3,99], k = 2
Output: [3,99,-1,-100]
```

**Explanation:**
Rotate 1 step: `[99,-1,-100,3]`
Rotate 2 steps: `[3,99,-1,-100]`

---

## Function Signature (C#)

```id="sig"
public void Rotate(int[] nums, int k)
```

---

## Constraints

* `1 <= nums.length <= 10^5`
* `-2^31 <= nums[i] <= 2^31 - 1`
* `0 <= k <= 10^5`

---

## Requirements

* Rotate the array **in-place** if possible
* Optimize for time and space complexity
* Handle cases where `k` is greater than the array length

---

## Notes

* Consider reversing parts of the array to achieve rotation efficiently
* Pay attention to edge cases: `k = 0`, `k = nums.Length`, singl
