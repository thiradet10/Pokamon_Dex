using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokamon_Dex
{
    public class Azumarill : Pokemon
    {
        public Azumarill()
        {
            this.Type = PokemonType.Water;
            this.Height = 2.8;
            this.Weight = 28.5;
            this.HP = 100;
            this.Attack = 50;
            this.Defense = 80;
            this.SpecialAttack = 60;
            this.SpecialDefense = 80;
            this.Speed = 50;
            this.Total = 420;
            this.Name = "Azumarill";
            this.image = Resource1.ResourceManager.GetObject("azumarill") as byte[] ?? Array.Empty<byte>();
        }
    }
}
