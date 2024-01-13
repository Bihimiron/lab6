namespace ConsoleApp1;

public class BracketValidator
{
     public static bool IsCorrect(string input, out int processedChars)
    {
        processedChars = 0;
        if (!input.EndsWith(';'))
        {
            return false;
        }
        Stack<char> bracketStack = new Stack<char>();
        foreach (char c in input)
        {
            processedChars++;
            if (IsBracket(c))
            {
                if (IsOpeningBracket(c))
                {
                    bracketStack.Push(c);
                }
                else if (!IsOpeningBracket(c))
                {
                    if (bracketStack.Count == 0 || !AreMatchingBrackets(bracketStack.Peek(), c))
                    {
                        
                        return false;
                    }

                    bracketStack.Pop();
                }
            }
        }

        return bracketStack.Count == 0;
    }

    /// <summary>
    /// Checks if current symbol is opening bracket.
    /// </summary>
    /// <param name="c">symbol.</param>
    /// <returns>True if symbol is opening bracket, otherwise false.</returns>
    private static bool IsOpeningBracket(char c)
    {
        return c is '(' or '[' or '{' or '<';
    }
    

    /// <summary>
    /// Checks if current symbol is bracket.
    /// </summary>
    /// <param name="c"> symbol</param>
    /// <returns>True if symbols is bracket o</returns>
    private static bool IsBracket(char c)
    {
        return c is '(' or ')' or '[' or ']' or '{' or '}' or '<' or '>';
    }


    /// <summary>
    /// Checks if 2 symbols are opening and closing brackets the same type.
    /// </summary>
    /// <param name="opening"> First symbol.</param>
    /// <param name="closing"> Second symbol.</param>
    /// <returns>True if 2 symbols are opening and closing brackets of same type, otherwise False</returns>
    private static bool AreMatchingBrackets(char opening, char closing)
    {
        return (opening == '(' && closing == ')') ||
               (opening == '[' && closing == ']') ||
               (opening == '{' && closing == '}') ||
               (opening == '<' && closing == '>');
    }
}