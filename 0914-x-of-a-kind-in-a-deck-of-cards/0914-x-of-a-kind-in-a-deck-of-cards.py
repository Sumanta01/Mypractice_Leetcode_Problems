from collections import Counter
from math import gcd
from functools import reduce
class Solution:
    def hasGroupsSizeX(self, deck: List[int]) -> bool:
        count=Counter(deck)
        val=count.values()
        g_value=reduce(gcd,val)
        return(g_value>=2)
            
            