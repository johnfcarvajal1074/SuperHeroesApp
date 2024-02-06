using SuperHeroesApp;
using SuperHeroesApp.Models;

var ImprimirInfo = new ImprimirInfo();

var poderVolar = new SuperPoder();
poderVolar.Nombre = "volar";
poderVolar.Descripcion = "capacidad de volar y planear";
poderVolar.Nivel = NivelPoder.NivelDos;

var superFuerza = new SuperPoder();
superFuerza.Nombre = "super fuerza";
superFuerza.Nivel = NivelPoder.NivelTRes;

var regeneracion = new SuperPoder();
superFuerza.Nombre = "Regeneracion";
superFuerza.Nivel = NivelPoder.NivelTRes;

var superman = new SuperHeroe();
superman.Id = 1;
superman.Nombre = "superman";
superman.IdentidadSecreta = "clark kent";
superman.CiudadOrigen = "metropolis";
superman.PuedeVolar = true;

ImprimirInfo.ImprimirSuperHeroe(superman);

List<SuperPoder> poderesSuperman = new List<SuperPoder>();
poderesSuperman.Add(poderVolar);
poderesSuperman.Add(superFuerza);
superman.SuperPoderes = poderesSuperman;
string resultSuperPoderes = superman.UsarSuperPoderes();
Console.WriteLine(resultSuperPoderes);
string salvar = superman.SalvarElMundo();
Console.WriteLine(salvar);
string salvarTierra = superman.SalvarLaTierra();
Console.WriteLine(salvarTierra);

var wolverine = new AntiHeroe();
wolverine.Id = 5;
wolverine.Nombre = "wolverine";
wolverine.IdentidadSecreta = "Logan";
wolverine.PuedeVolar = false;

ImprimirInfo.ImprimirSuperHeroe(wolverine);

List<SuperPoder> poderesWolverine = new List<SuperPoder>();
poderesWolverine.Add(regeneracion);
poderesWolverine.Add(superFuerza);
wolverine.SuperPoderes = poderesWolverine;
string resultWolverinPoderes = wolverine.UsarSuperPoderes();
Console.WriteLine(resultWolverinPoderes);

string accionAntiheroe = wolverine.RealizarAccionAntiheroe("Ataca la policia");
Console.WriteLine(accionAntiheroe);

enum NivelPoder
{
    NivelUno,
    NivelDos,
    NivelTRes,
}

public record SuperHeroeRecord(int id, string Nombre, string IdentidadSecreta);
