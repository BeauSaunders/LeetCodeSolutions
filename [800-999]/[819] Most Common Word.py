"""
Last Solved: 06.01.26
Topics Utilised: Strings, Hash Map
Link: https://leetcode.com/problems/most-common-word/
Time Complexity: O(n + m) [where n = number of characters and & m = number of words in the paragraph]
Space Complexity: O(n)
"""

class Solution:
    def mostCommonWord(self, paragraph: str, banned: List[str]) -> str:
        paragraph = self.cleanParagraph(paragraph) # remove any punctuation and convert all to lower before doing anything

        counter = {}
        mostCommon = None

        # for each word in the paragraph
        for word in paragraph:
            # if it is not a banned word
            if word not in banned:
                # if the dict is already tracking this word
                if word in counter:
                    counter[word] = counter[word] + 1 # increment the count
                # else not yet tracking this word
                else:
                    counter[word] = 1 # start tracking this word

                # if not yet tracking the most common
                if mostCommon is None:
                    mostCommon = word # set the first one
                # else if current is more common than most common
                elif counter[word] > counter[mostCommon]:
                    mostCommon = word # set the new most common
        
        return mostCommon

    def cleanParagraph(self, paragraph: str) -> []:
        result = ['']

        i = 0
        wasLastSpace = False
        for letter in paragraph:
            # if a non-letter (e.g. space or punctuation) 
            if letter.isalpha() is False:
                # if was a space or punctuation last time, don't increment
                if wasLastSpace:
                    continue
                
                # else increment the list
                i = i + 1
                result.append('')
                wasLastSpace = True
            # else it is a letter
            else:
                result[i] += letter.lower()
                wasLastSpace = False

        return result
