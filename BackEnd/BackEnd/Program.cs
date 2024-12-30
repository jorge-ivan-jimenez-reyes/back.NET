// See https://aka.ms/new-console-template for more information

// como crear clases y objeto
//s 

//clase molde para la creacion de un objeto 
//objeto atributos y propiedades


//diferentes formas de crear objetos
var sale = new Sale(15);
//var azucar sintactica cualidad que tienen los lenguaje para hacerlo mas legible
var message = sale.GetInfo();
Console.WriteLine(message);

class Sale
{
    //get y set para modificarla 
    public decimal Total { get; set; }
    
    //nosotros podemos darle a un objeto un elemento desde su creacion a esto se le llama constructor
    //constructor tiene el mismo nombre a la clase con la que esta hecha 
    public Sale(decimal total)
    {
         Total = total;
    }

    public string GetInfo()
    {
        return "el total es " + Total;
    }
}