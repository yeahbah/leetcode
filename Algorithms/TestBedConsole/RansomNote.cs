using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace TestBedConsole;

public class RansomNote
{
    // O(N * M)
    public static bool CanSpellWordBruteForce(char[] letters, string word)
    {
        foreach (var letter in word)
        {
            if (!letters.Contains(letter)) return false;
        }

        return true;
    }

    // clumsy af, letters assumed unique
    // O(N + M), O(1)
    public static bool CanSpellWordHashed(char[] letters, string word)
    {
        var hash = letters.ToDictionary(l => l);
        foreach (var letter in word)
        {
            if (!hash.ContainsKey(letter))
                return false;
        }

        return true;
    }

    // Time: O(N + M)
    // Space: O(1)
    public static bool CanSpellWordTechlead(char[] letters, string word)
    {
        var map = new Dictionary<char, int>();
        foreach (var letter in letters)
        {
            if (map.ContainsKey(letter))
            {
                map[letter] += 1;
                continue;
            }

            map[letter] = 1;
        }

        foreach (var letter in word)
        {
            if (map[letter] <= 0) return false;

            map[letter] -= 1;
        }
        return true;
    }
}