namespace lab_5;

public class Client
{
    private string name;
    private Order _order;

    public Client(string cname)
    {
        name = cname;
    }


    public string getName()
    {
        return name;
    }

    public void Order(Order new_order)
    {
        _order = new_order;
    }

    public double getSum()
    {
        return _order.getSum();
    }
    
}