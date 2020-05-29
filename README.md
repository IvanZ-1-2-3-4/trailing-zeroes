# trailing-zeroes
> [trailing-zeroes.exe](https://github.com/IvanZ-1-2-3-4/trailing-zeroes/blob/master/trailing-zeroes.exe) is the file you're looking for.  

How many zeros are there in ![](https://latex.codecogs.com/gif.latex?n%21)?
I started thinking about this puzzle when someone asked me how many trailing zeros are there in 100 factorial, which I then generalised to ![](https://latex.codecogs.com/gif.latex?n%21). This applet is just something to verify that my hypothesis was true.

------------------------------
### Explanation
A number with trailing zeros has as many factors of 10 as it has trailing zeros. This means we can solve the problem of counting how many trailing zeros are in ![](https://latex.codecogs.com/gif.latex?n%21) by counting the number of tens that go into ![](https://latex.codecogs.com/gif.latex?n%21). This is a much simpler problem.  
The helpful insight here is to regard 10 as a product of its prime factors - 2 and 5 - and to count the number of those in ![](https://latex.codecogs.com/gif.latex?n%21) instead. Then we can just find the number of tens by pairing up the 2s and 5s we find.  
Let's start with the 2s. Every even number has a factor of 2, and there are ![](https://latex.codecogs.com/gif.latex?floor%28%5Cfrac%7Bn%7D%7B2%7D%29) even numbers below ![](https://latex.codecogs.com/gif.latex?n). But what about the numbers with more than one factor of 2, e.g. 12? Let's say that these numbers have a factor of ![](https://latex.codecogs.com/gif.latex?2%5Ek), and the maximum value of ![](https://latex.codecogs.com/gif.latex?k) for any ![](https://latex.codecogs.com/gif.latex?n) will be ![](https://latex.codecogs.com/gif.latex?floor%28%5Clog_2%7Bn%7D%29) - simply the lowest highest power of two 
