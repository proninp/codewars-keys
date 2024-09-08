using Kata._8_kyu.Grasshopper_Terminal_game_move_function.src;
using NUnit.Framework;

namespace Kata._8_kyu.Grasshopper_Terminal_game_move_function.test;

[TestFixture]
public class GrasshopperTerminalGameMoveFunctionTest
{
    [Test]
    public void Test1()
    {
        Assert.That(GrasshopperTerminalGameMoveFunction.Move(0, 4), Is.EqualTo(8));
    }
}