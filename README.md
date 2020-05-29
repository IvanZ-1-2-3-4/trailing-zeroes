  # trailing-zeroes
> [trailing-zeroes.exe](https://github.com/IvanZ-1-2-3-4/trailing-zeroes/blob/master/trailing-zeroes.exe) is the file you're looking for.  

How many zeros are there in !(https://latex.codecogs.com/gif.latex?n%21)?
I started thinking about this puzzle when someone asked me how many trailing zeros are there in 100 factorial, which I then generalised to !(https://latex.codecogs.com/gif.latex?n%21). This applet is just something to verify that my hypothesis was true.

------------------------------
### Explanation
A number with trailing zeros has as many factors of 10 as it has trailing zeros. This means we can solve the problem of counting how many trailing zeros are in ![](https://latex.codecogs.com/gif.latex?n%21) by counting the number of tens that go into !(https://latex.codecogs.com/gif.latex?n%21). This is a much simpler problem.  
The helpful insight here is to regard 10 as a product of its prime factors - 2 and 5 - and to count the number of those in !(https://latex.codecogs.com/gif.latex?n%21) instead. Then we can just find the number of tens by pairing up the 2s and 5s we find. Another thing to realize is that in any sequence of consecutive numbers there will always be more numbers with factors of 2 than numbers with factors of 5, simply because they are more densely packed on the number line - you need only to walk 1 or 2 steps along to find an even number, while you need to 5 (at most) to find a multiple of 5. This realization makes our problem even simpler, because we don't need to count the number of 2s, since there will always be a 2 to pair with a 5, as there is more of them.  
So let's start counting the 5s! To begin, let's count the number of multiples of 5 in the sequence of numbers that make up !(https://latex.codecogs.com/gif.latex?n%21). This is easily done by computing !(https://latex.codecogs.com/gif.latex?floor%28n%20/%205%29)
