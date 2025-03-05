using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokamon_Dex
{
    public class Charizard : Pokemon
    {
        public Charizard()
        {
            this.Type = PokemonType.Fire;
            this.Height = 1.7;
            this.Weight = 90.5;
            this.HP = 78;
            this.Attack = 84;
            this.Defense = 78;
            this.SpecialAttack = 109;
            this.SpecialDefense = 85;
            this.Speed = 100;
            this.Total = 534;
            this.Name = "Charizard";
            this.image = Resource1.ResourceManager.GetObject("charizard") as byte[] ?? Array.Empty<byte>();
        }
    }
}
