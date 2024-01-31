using SuperHeroesApp.Models;

var poderVolar = new SuperPoder();
poderVolar.Nombre = "volar";
poderVolar.Descripcion = "capacidad de volar y planear";
poderVolar.Nivel = NivelPoder.NivelDos;

var superFuerza = new SuperPoder();
superFuerza.Nombre = "super fuerza";
superFuerza.Nivel = NivelPoder.NivelTRes;

var superman = new SuperHeroe();
superman.id = 1;
superman.Nombre = "superman";
superman.IdentSecreta = "clark kent";
superman.CiudadOrigen = "metropolis";
superman.PuedeVolar = true;

var superman2 = new SuperHeroe();
superman2.id = 1;
superman2.Nombre = "superman";
superman2.IdentSecreta = "clark kent";
superman2.CiudadOrigen = "metropolis";
superman2.PuedeVolar = true;

Console.WriteLine(superman == superman2);

SuperHeroeRecord superHeroRecord = new SuperHeroeRecord(1, "Superman", "Clark Kent");
SuperHeroeRecord superHeroRecord2 = new SuperHeroeRecord(1, "Superman", "Clark Kent");

Console.WriteLine(superHeroRecord == superHeroRecord2);

//List<SuperPoder> poderesSuperman = new List<SuperPoder>();
//poderesSuperman.Add(poderVolar);
//poderesSuperman.Add(superFuerza);
//superman.SuperPoderes = poderesSuperman;
//string resultSuperPoderes = superman.UsarSuperPoderes();
//Console.WriteLine(resultSuperPoderes);

enum NivelPoder
{
    NivelUno,
    NivelDos,
    NivelTRes,
}

public record SuperHeroeRecord(int id, string Nombre, string IdentidadSecreta);
