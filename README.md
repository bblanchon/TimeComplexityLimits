Time-complexity benchmarks in C#
================================

A very small project to see what is the maximum problem size depending on the problem complexity.

### The results

Here is what my Core i5-2500 can do in 5 seconds:

| Time complexity | Maximum N |
| --------------- | --------- |
| O(1)            | Infinity  |
| O(log(n))       | Infinity  |
| O(n)            | 10^9      |
| O(n log(n))     | 10^8      |
| O(n^2)          | 10^4      |
| O(n^3)          | 10^3      |
| O(2^n)          | 30        |
| O(n!)           | 10        |

### Why ?

I needed that for my [Google Code Jam Cheat Sheet](http://blog.benoitblanchon.fr/google-code-jam-cheat-sheet/)

