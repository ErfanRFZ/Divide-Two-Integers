# [Divide-Two-Integers](https://leetcode.com/problems/divide-two-integers/)

Solve a problem on leetcode.com website divide two integers.
Its detail of problem can be found in the [Description](https://leetcode.com/problems/divide-two-integers/) (link of the problem) website leetcode.com.

## Description of Problem
Given two integers `dividend` and `divisor`, divide two integers without using multiplication, division, and mod operator.

Return the quotient after dividing `dividend` by `divisor`.

The integer division should truncate toward zero, which means losing its fractional part. For example, `truncate(8.345) = 8` and `truncate(-2.7335) = -2`.

**Note**: Assume we are dealing with an environment that could only store integers within the **32-bit** signed integer range: `[−231, 231 − 1]`. For this problem, assume that your function **returns** `231 − 1` **when the division result overflows**.

### *Example 1:*

```bash
Input: dividend = 10, divisor = 3
Output: 3
Explanation: 10/3 = truncate(3.33333..) = 3.
```

### *Example 2:*

```bash
Input: dividend = 7, divisor = -3
Output: -2
Explanation: 7/-3 = truncate(-2.33333..) = -2.
```

### *Example 3:*

```bash
Input: dividend = 0, divisor = 1
Output: 0
```

### *Example 4:*

```bash
Input: dividend = 1, divisor = 1
Output: 1
```

### Constraints:

* `-231 <= dividend, divisor <= 231 - 1`
* `divisor != 0`

## Solve The Problem
I solve this problem [**C#**](https://docs.microsoft.com/en-us/dotnet/csharp/fundamentals/coding-style/coding-conventions) language.

* *Step 1*:

First of all we need to check if divisor equal to `0` the inputs is wrong and we return **Exception** error in program because we can't have divide by zero in order to slove this we write code below:

```csharp

if (divisor == 0)
{
       throw new DivideByZeroException();
}  
```

* *Step 2*:

And then we need to calculate the divide function and name it `result`

```csharp

double result = (double)dividend/(double)divisor; 
```
* You can also do it with the long variable like this

```csharp

long result = (long)dividend/(long)divisor; 
```

You need to know we can't return result with long or double because the method is int so we need to convert it to int

* *Step 3*:


But before return the result we need to check the result which isn't out of the range of problem as I said before the problem have range:
**Note**: Assume we are dealing with an environment that could only store integers within the **32-bit** signed integer range: `[−231, 231 − 1]`. For this problem, assume that your function **returns** `231 − 1` **when the division result overflows**.
to solve this we need to write code below:

```csharp

if (result<int.MinValue || result > int.MaxValue)
{
       return (int)Math.Pow(2,31)-1;
} 
```
* `(int)` for converting the result value to int, and the answer will be `truncate` like example 1 and 2.


* *Last Step*:

For last step we need to return the result to the method as I said before we need to convert the variable result it dosn't matter you do it with long double we need to convert it write code below like did before:

```csharp

return (int)result;
```

## Final Code

```csharp
public class Solution {
    
    public int Divide(int dividend, int divisor) {
        
        if (divisor == 0)
        {
            throw new DivideByZeroException();
        }
        
        long result = (long)dividend/(long)divisor; 
        
	    if(result<int.MinValue || result > int.MaxValue)
        {
		    return (int)Math.Pow(2,31)-1;
	    }
        
	    return (int)result;
    }
}
```

## *Unit Tests Listing*

### *Example 1:*

```bash
Input: dividend = 10, divisor = 3
Output: 3
Explanation: 10/3 = truncate(3.33333..) = 3.
```

### *Example 2:*

```bash
Input: dividend = 7, divisor = -3
Output: -2
Explanation: 7/-3 = truncate(-2.33333..) = -2.
```

### *Example 3:*

```bash
Input: dividend = 0, divisor = 1
Output: 0
```

### *Example 4:*

```bash
Input: dividend = 1, divisor = 1
Output: 1
```
