
using System.Net;

var sale = new SaleWithtax(12);
var message = sale.GetInfo();
Console.WriteLine(message);
//clase heredada de sale
class SaleWithtax : Sale
{
    public decimal Tax { get; set; }
    public SaleWithtax(decimal total) : base(total)
    {
    }

    public string GetInfowithTax()
    {
        return "el total es" + Total + "Impuesto es " + Tax;
    }
}



class Sale
{
    //get set para modificar y obtenerla
    public decimal Total { get; set; }

    public Sale(decimal total)
    {
        Total = total;
    }

    public string GetInfo()
    {
        return "el total es " + Total;
    }
}

class Buy
{
    public decimal Total { get; set; }

    public Buy(decimal total)
    {
        Total = total;
    }
}




//