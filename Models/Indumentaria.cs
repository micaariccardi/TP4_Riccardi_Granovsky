public class Indumentaria
{
    string medias {get; private set;}
    string pantalon {get; private set;}
    string camiseta {get; private set;}

    Indumentaria(string m, string p, string c)
    {
        medias = m;
        pantalon = p;
        camiseta = c;
    }
}