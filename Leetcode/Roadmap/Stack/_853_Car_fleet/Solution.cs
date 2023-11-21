// https://leetcode.com/problems/car-fleet/
namespace Leetcode.Roadmap.Stack._853_Car_fleet;

public class Solution
{
    private Stack<Car> m_stack = new();
    private List<Car> cars = new();
    public int CarFleet(int target, int[] position, int[] speed)
    {
        for (int i = 0; i < position.Length; i++)
        {
            double reachTime = (double)(target - position[i]) / speed[i];
            Car car = new Car(position[i], speed[i], reachTime);
            cars.Add(car);
        }

        List<Car> orderedCars = cars.OrderByDescending(car => car.pos).ToList();

        foreach (Car car in orderedCars)
        {
            if (0 == m_stack.Count || m_stack.Peek().reachTime < car.reachTime)
            {
                m_stack.Push(car);
            }
        }

        return m_stack.Count;
    }
}

public class Car
{
    public int pos;
    public int speed;
    public double reachTime;

    public Car(int pos, int speed, double reachTime)
    {
        this.pos = pos;
        this.speed = speed;
        this.reachTime = reachTime;
    }
}
