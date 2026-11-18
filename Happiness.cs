// Exercise 23.4: Happiness
// The following program describes a situation where a person wants to buy 15 items, each costing
// 6000 DKK. This person has an amount in his bankbook and owns a house of modest value. In
// addition, the individual has a distorted perception of his own happiness. The following program
// simulates how the individual purchases affect the individual’s happiness.

public class Happiness
{
    const int ITEM_PRICE = 6000;
    const int ITEM_COUNT = 15;
    const int HOUSE_VALUE = 8000;
    static int account = 30000;
    static bool ownsHouse = true;
    static bool AccountIsPositive ()
    {
        return account>0;
    }
    static bool BuyItem (int price)
    {
        account -= price;
        return AccountIsPositive();
    }
    // returns true if able to sell house or no sale necessary
    static bool SellHouseIfNecessary ()
    {
        if (!AccountIsPositive())
        {
            if (!ownsHouse) return false;
            account += HOUSE_VALUE;
            ownsHouse = false;
        }
        return true;
    }
}