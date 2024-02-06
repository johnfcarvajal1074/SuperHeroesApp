using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroesApp.Models
{
    internal class AntiHeroe : SuperHeroe
    {
        public string RealizarAccionAntiheroe(string accion)
        {
            return $"El AntiHeroe {NombreEIdentidadSecreta} ha realizado: {accion}";
        }
    }
}
