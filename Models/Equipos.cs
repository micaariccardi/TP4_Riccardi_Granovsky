static class Equipos
{
    public static List<string> listaEquipos {get; private set;} = {"Boca","River", "San Lorenzo", "Independiente", "Racing"}
    public static List<string> listaMedias {get; private set;} //BUSCAR IMAGENES
    public static List<string> listaPantalones {get; private set;}
    public static List<string> listaCamisetas {get; private set;}
    public static Dictionary <string, Indumentaria> EquiposIndumentaria {get; private set;}

    public bool IngresarIndumentaria(string equipoSeleccionado, Indumentaria item)
    {
        bool hecho = false;
        if(!EquiposIndumentaria.ContainsKey(equipoSeleccionado))
        {
            EquiposIndumentaria.Add(equipoSeleccionado, item);
            hecho = true;
        }
        return hecho;
    }
}