# 🔗 Valid Parentheses

## Description

Given a string `s` containing just the characters `'('`, `')'`, `'{'`, `'}'`, `'['` and `']'`, determine if the input string is valid.

An input string is valid if:

1. Open brackets are closed by the same type of brackets
2. Open brackets are closed in the correct order
3. Every closing bracket has a corresponding open bracket

---

## Example 1

```id="ex1"
Input: s = "()"
Output: true
```

---

## Example 2

```id="ex2"
Input: s = "()[]{}"
Output: true
```

---

## Example 3

```id="ex3"
Input: s = "(]"
Output: false
```

---

## Example 4

```id="ex4"
Input: s = "([)]"
Output: false
```

---

## Function Signature (C#)

```id="sig"
public bool IsValid(string s)
```

---

## Constraints

* `1 <= s.length <= 10^4`
* `s` consists only of parentheses characters: `()[]{}`

---

## Requirements

* Return `true` if the string is valid
* Return `false` otherwise
* The solution should be efficient for large inputs

---

## Notes

* Pay attention to order and matching types of brackets
* Edge cases (empty or single character) should be handled

---
