using Xunit;

using lab_5;

namespace TestProject1;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Firm fedex = new Firm();
        fedex.RegisterClient("Stacy");
        fedex.MakeOrder(100, Firm.Rate.medium);


        Assert.Equal(15, fedex.getClientSum("Stacy"));
    }


    [Fact]
    public void Test2()
    {
        Firm fedex = new Firm();
        fedex.RegisterClient("Stacy");
        fedex.MakeOrder(100, Firm.Rate.medium);

        fedex.RegisterClient("John");
        fedex.MakeOrder(250, Firm.Rate.high);
        
        Assert.Equal(65, fedex.getAllSums());
    }

}