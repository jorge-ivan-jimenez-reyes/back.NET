//Esto de interfaces sirve para arquitectura y patrones de diseño 







//ionterfaz es dar reglas de esta manera pudes categoriazar tu clase
interface ISale
{
    //reglas de la interfaz
    decimal Total { get; set; }
    
}
//Interfaz para guardar mecanismo
interface ISave
{
    //metodo para guardar
    public void Save();

}

interface Buy
{
    public void Buy();
}
