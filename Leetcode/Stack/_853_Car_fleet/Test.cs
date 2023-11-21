using Leetcode.Interface;

namespace Leetcode.Stack._853_Car_fleet;

public class Test : Solution, ITest
{
    private int target;
    private int[] position = [];
    private int[] speed = [];
    private int result;

    public void TestCases()
    {
        target = 12;
        position = [10, 8, 0, 5, 3];
        speed = [2, 4, 1, 1, 3];
        result = 3;
        Console.WriteLine(Case(target, position, speed, result));

        target = 10;
        position = [6, 8];
        speed = [3, 2];
        result = 2;
        //Console.WriteLine(Case(target, position, speed, result));

        target = 10;
        position = [0, 4, 2];
        speed = [2, 1, 3];
        result = 1;
        //Console.WriteLine(Case(target, position, speed, result));
    }

    private bool Case(int target, int[] position, int[] speed, int result)
    {
        return result == CarFleet(target: target, position: position, speed: speed);
    }
}
