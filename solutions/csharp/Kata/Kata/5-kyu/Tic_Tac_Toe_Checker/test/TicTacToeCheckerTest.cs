using Kata._5_kyu.Tic_Tac_Toe_Checker.src;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Collections.Generic;
using System;
using System.Linq;

namespace Kata._5_kyu.Tic_Tac_Toe_Checker.test;

[TestFixture]
public class TicTacToeCheckerTest
{
    private TicTacToeChecker tictactoe = new TicTacToeChecker();

    [Test]
    public void TestingReturnOfIsSolvedMethod()
    {
        var boards = new Dictionary<int[,], int>();
        boards.Add(new int[,] { { 1, 1, 1 }, { 0, 2, 2 }, { 0, 0, 0 } }, 1);
        boards.Add(new int[,] { { 1, 2, 0 }, { 0, 1, 2 }, { 0, 0, 1 } }, 1);
        boards.Add(new int[,] { { 2, 1, 1 }, { 0, 1, 1 }, { 2, 2, 2 } }, 2);
        boards.Add(new int[,] { { 2, 2, 2 }, { 0, 1, 1 }, { 1, 0, 0 } }, 2);
        boards.Add(new int[,] { { 2, 1, 2 }, { 2, 1, 1 }, { 1, 2, 1 } }, 0);
        boards.Add(new int[,] { { 1, 2, 1 }, { 1, 1, 2 }, { 2, 1, 2 } }, 0);
        boards.Add(new int[,] { { 2, 0, 2 }, { 2, 1, 1 }, { 1, 2, 1 } }, -1);
        boards.Add(new int[,] { { 0, 0, 2 }, { 0, 0, 0 }, { 1, 0, 1 } }, -1);
        boards.Add(new int[,] { { 1, 2, 1 }, { 1, 1, 2 }, { 2, 2, 0 } }, -1);
        boards.Add(new int[,] { { 0, 2, 2 }, { 2, 1, 1 }, { 0, 0, 1 } }, -1);
        boards.Add(new int[,] { { 0, 1, 1 }, { 2, 0, 2 }, { 2, 1, 0 } }, -1);

        Random r = new Random();
        boards = boards.OrderBy(o => r.Next()).ToDictionary(b => b.Key, b => b.Value);

        foreach (KeyValuePair<int[,], int> boardMap in boards)
        {
            var actual = tictactoe.IsSolved(boardMap.Key);
            var expected = boardMap.Value;
            var err = string.Join(" ", boardMap.Key.OfType<int>().Select((n, i) => (i % 3) == 0 ? "\n" + n : "" + n));
            ClassicAssert.AreEqual(expected, actual, "For the following board: " + err);
        }
    }
}