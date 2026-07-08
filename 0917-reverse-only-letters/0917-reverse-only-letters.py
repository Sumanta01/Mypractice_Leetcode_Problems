class Solution(object):
    def reverseOnlyLetters(self, s):
        stack=list()

        for ch in s:
            if ch.isalpha():
                stack.append(ch)

        res=list()
        
        for ch in s:
            if ch.isalpha():
                res.append(stack.pop())
            else:
                res.append(ch)
        
        return ''.join(res)

    




        
        