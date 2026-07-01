public class Solution {
    public string ReverseOnlyLetters(string input) {
        var s = input.ToCharArray();
        int firstPointer = 0;
        int secondPointer = s.Length - 1;
        if(s.Length == 1)
            return input;
        
        while(firstPointer < secondPointer){
            if(!IsEnglishCharecter(s[firstPointer])){
                firstPointer++;
                continue;
            }
                
            if(!IsEnglishCharecter(s[secondPointer])){
                secondPointer--;
                continue;
            }

            char c = s[firstPointer];
            s[firstPointer] = s[secondPointer];
            s[secondPointer] = c;

            firstPointer++;
            secondPointer--;
        }
        return new string(s);
    }
    public static bool IsEnglishCharecter(char c){
         var asciiValue = (int)c;
         if(asciiValue >= 65 && asciiValue <= 90)
            return true;
         else if(asciiValue >= 97 && asciiValue <= 122)
            return true;
        return false;
    }
}