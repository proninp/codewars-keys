using System;

namespace Kata._8_kyu.Grasshopper_Terminal_game_move_function.src;
public class GrasshopperTerminalGameMoveFunction
{
    public static int Move(int position, int roll) =>
        position + roll + roll;
}
