using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokamon_Dex
{
    public class Meditite : Pokemon
    {
        public Meditite()
        {
            this.Type = PokemonType.Fighting;
            this.Height = 0.6;
            this.Weight = 11.2;
            this.HP = 30;
            this.Attack = 40;
            this.Defense = 55;
            this.SpecialAttack = 40;
            this.SpecialDefense = 55;
            this.Speed = 60;
            this.Total = 280;
            this.Name = "Meditite";
            this.image = Resource1.ResourceManager.GetObject("meditite") as byte[] ?? Array.Empty<byte>();
        }
    }
}
