using System;
using System.Linq;
using System.Text;

namespace Kata._6_kyu.Jewel_Thief.src;

class JewelThief
{
    public static int Crack(Safe safe)
    {
        const string click = "click";
        const int minComb = 0;
        const int maxComb = 99;
        var combinations = new string[3];
        var directions = new[] { 'L', 'R' };
        for (var i = 0; i < combinations.Length; i++)
        {
            for (var j = minComb; j <= maxComb; j++)
            {
                var isBreak = false;
                var numCode = j.ToString().PadLeft(2, '0');
                foreach (var direction in directions)
                {
                    var stepCode = string.Concat(direction, numCode);
                    var combination = new StringBuilder();
                    combination.Append(string.IsNullOrEmpty(combinations[0]) ? stepCode : combinations[0]);
                    combination.Append('-');
                    combination.Append(string.IsNullOrEmpty(combinations[1]) ? stepCode : combinations[1]);
                    combination.Append('-');
                    combination.Append(stepCode);
                    var combinationAttempt = combination.ToString();
                    var result = safe.Unlock(combinationAttempt);
                    if (result.Length >= click.Length * (i + 1))
                    {
                        combinations[i] = stepCode;
                        isBreak = true;
                        break;
                    }
                }
                if (isBreak)
                    break; 
            }
        }
        return safe.Open();
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