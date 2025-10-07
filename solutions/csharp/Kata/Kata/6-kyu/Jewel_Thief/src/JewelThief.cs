using System;
using System.Linq;
using System.Text;

namespace Kata._6_kyu.Jewel_Thief.src;

class JewelThief
{
    private const int MinComb = 0, MaxComb = 99;
    private const string Click = "click";
    public static int Crack(Safe safe)
    {
        string[] known = ["L00", "L00", "L00"];
        var directions = new[] { 'L', 'R' };
        for (var i = 0; i < known.Length; i++)
        {
            foreach (var direction in directions)
            {
                if (CrackWheel(safe, direction, known, i))
                    break;
            }
        }
        return safe.Open();
    }

    private static bool CrackWheel(Safe safe, char direction, string[] known, int segment)
    {
        for (var i = MinComb; i <= MaxComb; i++)
        {
            var numCode = i.ToString("D2");
                    
            var candidate = string.Concat(direction, numCode);
            known[segment] = candidate;
            var combinationAttempt = string.Join('-', known);
            var result = safe.Unlock(combinationAttempt);
            if (result.Length >= Click.Length * (segment + 1))
            {
                return true;
            }
        }
        return false;
    }
}

public class Safe
{
    private int _jewelValue;
    private bool _isUnlocked;
    private string[] _combinations;
    
    public Safe(string combination, int score)
    {
        _jewelValue = score;
        _combinations = combination.Split('-');
    }
    public string Unlock(string combination)
    {
        var combinations = combination.Split('-', StringSplitOptions.RemoveEmptyEntries);
        if (combinations.Length != _combinations.Length)
            throw new ArgumentException("Wrong number of combinations");
        var result = new string[_combinations.Length];

        for (var i = 0; i < _combinations.Length; i++)
        {
            if (_combinations[i] != combinations[i])
                break;
            result[i] = "click";
            _isUnlocked = i == combinations.Length - 1;
        }
        var notEmptyResult = result.Where(s => !string.IsNullOrEmpty(s)).ToArray();
        return string.Join("-", notEmptyResult);
    }

    public int Open() => _isUnlocked ? _jewelValue : -1;
    
}