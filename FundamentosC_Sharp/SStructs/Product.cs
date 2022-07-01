struct Product
{
    public int Id;
    public float Price;

    public float PriceInDolar(float dolar)
    {
        return Price * dolar;
    }
}