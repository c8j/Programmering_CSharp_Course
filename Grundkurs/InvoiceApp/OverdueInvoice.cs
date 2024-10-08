namespace InvoiceApp;

public class OverdueInvoice(int senderID, int customerID) : Invoice(senderID, customerID)
{
    /* PROPERTIES */
    public decimal Interest { get; } = 0.25M;
    public decimal Charge
    {
        get
        {
            return Interest * TotalValue;
        }
    }

    /* METHODS */
    public override string ToString()
    {
        return base.ToString() +
        "\n" +
        $"Obetald: {TotalValue}, Avgift: {Charge}, Nytt totalt: {TotalValue + Charge}";
    }
}
