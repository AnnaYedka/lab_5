namespace lab_5;

public class Order
{
    private int distance;
    private double rate;
    private double sum;

    public Order(int dist, double crate)
    {
        distance = dist;
        rate = crate;
    }

    public double getSum()
    {
        sum = distance * rate;
        return sum;
    }
    
    
}