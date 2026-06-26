class Solution:
    def longestCommonPrefix(self, strs: List[str]) -> str:
        first_index=strs[0]
        res=str()
        for i in range(len(first_index)):
            for word in strs[1:]:
                if i>=len(word) or word[i]!=first_index[i]:
                    return res
            res+=first_index[i]
            
        return res
        
        