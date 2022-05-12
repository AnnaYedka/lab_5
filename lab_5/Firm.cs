namespace lab_5;

public class Firm
{
    public enum Rate
    {
        small,
        medium,
        high
    }

    private Client current_client;
    private List<Client> _clients = new List<Client>();

    public void RegisterClient(string name)
    {
        current_client = new Client(name);
        _clients.Add(current_client);
    }

    public void MakeOrder(int dist, Rate rate)
    {
        if (rate == Rate.small)
        {
            current_client.Order(new Order(dist, 0.1));
        }
        else if (rate == Rate.medium)
        {
            current_client.Order(new Order(dist, 0.15));
        }
        else if (rate == Rate.high)
        {
            current_client.Order(new Order(dist, 0.2));
        }
    }

    public double getClientSum(string name)
    {
        foreach (Client person in _clients)
        {
            if (person.getName() == name)
            {
                return person.getSum();
            }
        }
        {
            
        }
        return 0;
    }

    public double getAllSums()
    {
        double tmp = 0;
        foreach (Client person in _clients)
        {
            tmp += person.getSum();
        }

        return tmp;
    }
}
