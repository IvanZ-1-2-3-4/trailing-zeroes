  # trailing-zeroes
> [trailing-zeroes.exe](https://github.com/IvanZ-1-2-3-4/trailing-zeroes/blob/master/trailing-zeroes.exe) is the file you're looking for.  

How many zeros are there in ![](https://latex.codecogs.com/gif.latex?n%21)?
I started thinking about this puzzle when someone asked me how many trailing zeros are there in 100 factorial, which I then generalised to ![](https://latex.codecogs.com/gif.latex?n%21). This applet is just something to verify that my hypothesis was true.

------------------------------
### Explanation
A number with trailing zeros has as many factors of 10 as it has trailing zeros. This means we can solve the problem of counting how many trailing zeros are in ![](https://latex.codecogs.com/gif.latex?n%21) by counting the number of tens that go into ![](https://latex.codecogs.com/gif.latex?n%21). This is a much simpler problem.  
  
  
The helpful insight here is to regard 10 as a product of its prime factors - 2 and 5 - and to count the number of those in the sequence of consecutive integers that make up the product which equals ![](https://latex.codecogs.com/gif.latex?n%21) instead. Then we can just find the number of tens by pairing up the 2s and 5s we find. Another thing to realize is that in any sequence of consecutive numbers there will always be more numbers with factors of 2 than numbers with factors of 5, simply because they are more densely packed on the number line - you need only to walk 1 or 2 steps along to find an even number, while you need to 5 (at most) to find a multiple of 5. This realization makes our problem even simpler, because we don't need to count the number of 2s, since there will always be a 2 to pair with a 5, as there is more of them.  
  
  
So let's start counting the 5s! To begin, let's count the number of multiples of 5 in the sequence of numbers that make up ![](https://latex.codecogs.com/gif.latex?n%21). This is easily done by computing ![](https://latex.codecogs.com/gif.latex?floor%28n%20/%205%29). However, this doesn't account for all 5s in the product - but what about numbers with more than one 5 as a factor, e.g. 25? To account for these numbers, we need to recognise that any number with more than one 5 as a factor will have a factor of a power of 5, ![](https://latex.codecogs.com/gif.latex?5%5Ek), for some positive integer ![](https://latex.codecogs.com/gif.latex?k). So we need to count the number of multiples of all the powers of 5 which are in the product as well. Obviously not every power of 5 will be contained in the numbers that make up the product of ![](https://latex.codecogs.com/gif.latex?n%21), so we need a threshold for when to stop looking for multiples of higher powers of 5. This will just be any ![](https://latex.codecogs.com/gif.latex?k) for which ![](https://latex.codecogs.com/gif.latex?5%5Ek%5Cleq%20n), or analytically, ![](https://latex.codecogs.com/gif.latex?k%5Cleq%20floor%28log_5%28n%29%29). To count the number of 5s in the multiples of ![](https://latex.codecogs.com/gif.latex?5%5Ek) in the sequence, we compute ![](https://latex.codecogs.com/gif.latex?k%5Ccdot%20floor%28n/5%5Ek%29). However, if we add this to the number of multiples of 5, (or ![](https://latex.codecogs.com/gif.latex?5%5E1)), we will encounter a double-counting problem. Any sum like ![](https://latex.codecogs.com/gif.latex?k%5Ccdot%20floor%28n/5%5Ek%29&plus;%28k&plus;1%29%5Ccdot%20floor%28n/5%5E%7Bk&plus;1%7D%29) will result in double counting of 5s in multiples of ![](https://latex.codecogs.com/gif.latex?5%5E%7Bk&plus;1%7D), as the factor of ![](https://latex.codecogs.com/gif.latex?5%5E%7Bk%7D) in each of those multiples is already counted by ![](https://latex.codecogs.com/gif.latex?k%5Ccdot%20floor%28n/5%5Ek%29). To avoid this, we notice that computing ![](https://latex.codecogs.com/gif.latex?k%5Ccdot%20floor%28n/5%5Ek%29) only misses one factor of 5 from each multiple of ![](https://latex.codecogs.com/gif.latex?5%5E%7Bk&plus;1%7D), as ![](https://latex.codecogs.com/gif.latex?p%285%5E%7Bk&plus;1%7D%29%3D5p%285%5Ek%29), where ![](https://latex.codecogs.com/gif.latex?p%285%5E%7Bk&plus;1%7D%29) is said multiple of 5. Since from each multiple of ![](https://latex.codecogs.com/gif.latex?5%5E%7Bk&plus;1%7D) only one 5 is missed by computing ![](https://latex.codecogs.com/gif.latex?k%5Ccdot%20floor%28n/5%5Ek%29), to account for these missing 5s we can add to this ![](https://latex.codecogs.com/gif.latex?floor%28n/5%5E%7Bk&plus;1%7D%29), which is just the number of multiples of ![](https://latex.codecogs.com/gif.latex?5%5E%7Bk&plus;1%7D), which is also the number of missing 5s. Hence the number of factors of 5 in multiples of ![](https://latex.codecogs.com/gif.latex?5%5Ek) and ![](https://latex.codecogs.com/gif.latex?5%5E%7Bk&plus;1%7D) is ![](https://latex.codecogs.com/gif.latex?k%5Ccdot%20floor%28n/5%5Ek%29&plus;floor%28n/5%5E%7Bk&plus;1%7D%29). This gives us a sort of recurrence formula which we can use to compute number of 5s in multiples of 5 and 5², 5² and 5³, 5³ and 5⁴, and so on, until we reach our maximum value of ![](https://latex.codecogs.com/gif.latex?k).   
  
  
So finally, what we end up with to count the number of factors of 5 in a sequence of consecutive integers below ![](https://latex.codecogs.com/gif.latex?n) is the following:  
(starting at ![](https://latex.codecogs.com/gif.latex?k%3D1))    

![](https://latex.codecogs.com/gif.latex?floor%28n/5%29&plus;floor%28n/5%5E2%29&plus;floor%28n/5%5E3%29...&plus;floor%28n/5%5E%7BMAX-1%7D%29&plus;floor%28n/5%5E%7BMAX%7D%29)  
  
  
Where ![](https://latex.codecogs.com/gif.latex?MAX%3Dfloor%28log_5%28n%29%29).  
  
  
In pseudocode, this would look like:
```
answer = 0
out = 0
k = 1

INPUT answer

LOOP WHILE ((answer / 5 ^ k) > 1)
    out = out + (FLOOR(answer / (5 ^ k)))
    k = k + 1
END WHILE

OUTPUT answer
```
A very short and simple program indeed!
