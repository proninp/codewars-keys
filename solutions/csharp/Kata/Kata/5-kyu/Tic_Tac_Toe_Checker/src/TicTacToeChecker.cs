using System;
using System.Linq;

namespace Kata._5_kyu.Tic_Tac_Toe_Checker.src;
public class TicTacToeChecker
{
    private bool isNotFinished = false;
    private int draw = -1;
    private int whoWin = -1;

    public int IsSolved(int[,] board)
    {
        if (board.Cast<int>().All(e => e != 0))
            return 0;
        for (int i = 0; i < board.GetLength(0); i++)
        {
            var line = new[] { board[i, 0], board[i, 1], board[i, 2] };
            var column = new[] { board[0, i], board[1, i], board[2, i] };
            if (Check(line) || Check(column))
                return whoWin;
        }
        var ld = new[] { board[0, 0], board[1, 1], board[2, 2] };
        var rd = new[] { board[0, 2], board[1, 1], board[2, 0] };
        if (Check(ld) || Check(rd))
            return whoWin;
        return isNotFinished ? -1 : draw;
    }

    private bool Check(int[] set)
    {
        whoWin = set[0] & set[1] & set[2];
        var distinctCount = set.Distinct().Count();
        if (distinctCount == 1 && set[0] == 0)
            isNotFinished = true;
        if (!isNotFinished && distinctCount == 3)
            draw = 0;
        return (whoWin == 1 || whoWin == 2);
    }



}
