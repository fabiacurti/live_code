# 🔢 Merge Intervals

## Description

Given an array of intervals where `intervals[i] = [start_i, end_i]`, merge all overlapping intervals and return an array of the non-overlapping intervals that cover all the intervals in the input.

---

## Example 1

```id="ex1"
Input: intervals = [[1,3],[2,6],[8,10],[15,18]]
Output: [[1,6],[8,10],[15,18]]
```

**Explanation:** Intervals `[1,3]` and `[2,6]` overlap and are merged into `[1,6]`.

---

## Example 2

```id="ex2"
Input: intervals = [[1,4],[4,5]]
Output: [[1,5]]
```

**Explanation:** Intervals `[1,4]` and `[4,5]` overlap and are merged into `[1,5]`.

---

## Function Signature (C#)

```id="sig"
public int[][] MergeIntervals(int[][] intervals)
```

---

## Constraints

* `1 <= intervals.length <= 10^4`
* `intervals[i].length == 2`
* `0 <= start_i <= end_i <= 10^4`

---

## Requirements

* Merge all overlapping intervals
* Return a sorted array of non-overlapping intervals
* Optimize for time and space efficiency

---

## Notes

* Edge cases: single interval, intervals already sorted, fully overlapping intervals
* Sorting the intervals by start time first can simplify the solution

---
