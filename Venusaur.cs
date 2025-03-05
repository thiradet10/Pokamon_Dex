using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokamon_Dex
{
    public class Venusaur : Pokemon
    {
        public Venusaur()
        {
            this.Type = PokemonType.Grass;
            this.Height = 2.0;
            this.Weight = 100;
            this.HP = 80;
            this.Attack = 82;
            this.Defense = 83;
            this.SpecialAttack = 100;
            this.SpecialDefense = 100;
            this.Speed = 80;
            this.Total = 525;
            this.Name = "Venusaur";
            this.image = Resource1.ResourceManager.GetObject("venusaur") as byte[] ?? Array.Empty<byte>();
        }
    }
}
