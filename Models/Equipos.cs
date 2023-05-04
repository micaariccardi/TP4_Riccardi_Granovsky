static class Equipos
{
    public static List<string> listaEquipos {get; private set;} = new List<string> {"Boca","River", "San Lorenzo", "Independiente", "Racing", "Saca chispas", "Huracán", "Argentina jr.", "Banfield", "Veléz"};
    public static List<string> listaMedias {get; private set;} = new List<string> {"medias1.png","medias2.png","medias3.png","medias4.png","medias5.png","medias6.png","medias7.png","medias8.png","medias9.png","medias10.png"};
    public static List<string> listaPantalones {get; private set;} = new List<string> {"pantalon1.png", "pantalon2.png", "pantalon3.png", "pantalon4.png", "pantalon5.png", "pantalon6.png", "pantalon7.png", "pantalon8.png", "pantalon9.png", "pantalon10.png"};
    public static List<string> listaCamisetas {get; private set;} = new List<string> {"camiseta1.png","camiseta2.png","camiseta3.png","camiseta4.png","camiseta5.png","camiseta6.png","camiseta7.png","camiseta8.png","camiseta9.png","camiseta10.png"};
    public static Dictionary <string, Indumentaria> EquiposIndumentaria {get; private set;}

    public static bool IngresarIndumentaria(string equipoSeleccionado, Indumentaria item)
    {
        
        if(!EquiposIndumentaria.ContainsKey(equipoSeleccionado))
        {
            EquiposIndumentaria.Add(equipoSeleccionado, item);
            return true;
        }
        return false;
    }
}