100 doors in a row are all initially closed. You make 100 passes by the doors. The first time through, you visit every door and toggle the door (if the door is closed, you open it; if it is open, you close it).
The second time you only visit every 2nd door (door #2, #4, #6, ...).
The third time, every 3rd door (door #3, #6, #9, ...), etc, until you only visit the 100th door.

Question: What state are the doors in after the last pass? Which are open, which are closed?

[Source http://rosettacode.org]

Brought to you by:  the number 1707 (the model of my Mac) and
TDD.Academy     https://agilenoir.biz/en/tdd-academy-videos/    
YOUtube videos  https://www.youtube.com/results?search_query=tdd.academy   


Lances guest 50/50 Open/Close doors

David actually took the time to think deeply and Malibu (his dog) came up with 10 Open doors.

====== David and Malibu’s rational for prediction of 10 doors Open =======

Key:   o newly Opened; x newly Closed; O - Open; X - Closed

1234567890123456789012345678901234567890
XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX			pass 0
Ooooooooooooooooooooooooooooooooooooooo		pass 1
OxOxOxOxOxOxOxOxOxOxOxOxOxOxOxOxOxOxOx		pass 2
OXxXOoOXxXOoOXxXOOxXOOOXxXOoOXxXOoOXxX		pass 3 (visit 3rd door…)
OXXoOOOoXXOxOXXOOOoXOOxXXXxOOXoXOOxXXX	   pass 4
OXXOxOOOXoOXOXoOOOOoOOXXoXXOOoOXOOoXXX			pass 5
OXXOXxOOXOOoOXOOOOxOOOXoOXXOxOOXOxOXXX			pass 6
OXXOXXxOXOOOOoOOOOxOxOXOOXXxXOOXOXxXXX		    pass 7
OXXOXXXxXOOOOOOxOOXOXOXOxXXXXOOXOoXXXX			pass 8
1234567890123456789012345678901234567890
       ^ pass pointer

Our 100  Doors problem is  leaving the  door open if the number of factors for N is odd.   10 doors left open at  100  passes.

Open Doors in my hand sim:   1, 4,  (stopped  at 8) 10,  11, 12, 13,   (at  pass  8; which leave 8++ undone yet)

The  Fundamental Theorem of Arithmetic => All counting numbers (except ONE, 2++)  may be  written as the product  of prime numbers  in  a unique  way.    also called the unique factorization theorem.
“The fundamental theorem of arithmetic states that every positive integer (except the number 1) can be represented in exactly one way apart from rearrangement as a product of one or more primes (Hardy and Wright 1979, pp. 2-3).”
https://mathworld.wolfram.com/FundamentalTheoremofArithmetic.html

Table of factors from 1 to 100
Let’s find factors of all numbers from 1 to 100 and check whether they are prime or not.
Then count factors and look for Odd number of factors.... 10.

What we learned Sep13th: 
- David says write unit tests because 3 experienced engineers don't write code that computes boundries on the 1st try, the 2nd try, and ....... and finally. 
- Just because you got your initial condition correct doesn't mean you have the boundary right.
- Ankur: boundary conditions take a lot of time. Finally came up with a mathematical formula that works.
- Lance: 
 - how to step through a for loop using other stepping functions.
 - functionas can be in the boundary test.
 - WriteLine
 - Writing a simple test is very important, otherwise you'll need to debug the test code.
