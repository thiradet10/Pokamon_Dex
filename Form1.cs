namespace Pokamon_Dex
{

    public partial class Form1 : Form
    {
        private Dictionary<string, Pokemon> pokemonDict = new Dictionary<string, Pokemon>();

        public Form1()
        {
            InitializeComponent();
            LoadPokemonList();
        }

        private void LoadPokemonList()
        {
            pokemonDict["Snorlax"] = new Snorlax();
            pokemonDict["Pikachu"] = new Pikachu();
            pokemonDict["Azumarill"] = new Azumarill();
            pokemonDict["Charizard"] = new Charizard();
            pokemonDict["Venusaur"] = new Venusaur();
            pokemonDict["Meditite"] = new Meditite();

            displayPokemon(pokemonDict["Pikachu"]);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void displayPokemon(Pokemon pokemon)
        {
            lbPokemon.Text = pokemon.getName();
            lbType.Text = pokemon.getType();
            lb_Hp.Text = pokemon.getHP().ToString();
            lb_Atk.Text = pokemon.getAttack().ToString();
            lb_Def.Text = pokemon.getDefense().ToString();
            lb_SplAtk.Text = pokemon.getSpecialAttack().ToString();
            lb_SplDef.Text = pokemon.getSpecialDefense().ToString();
            lb_Sp.Text = pokemon.getSpeed().ToString();
            lb_Total.Text = pokemon.getTotal().ToString();
            lb_H.Text = pokemon.getHeight().ToString() + " m";
            lb_W.Text = pokemon.getWeight().ToString() + " kg";

            using (var ms = new MemoryStream(pokemon.getImage()))
            {
                this.pictureBox1.Image = Image.FromStream(ms);
            }



        }


        private void btnPikachu_Click_1(object sender, EventArgs e) => displayPokemon(pokemonDict["Pikachu"]);
        private void btnSnorlax_Click_1(object sender, EventArgs e) => displayPokemon(pokemonDict["Snorlax"]);
        private void btnAzumarill_Click_1(object sender, EventArgs e) => displayPokemon(pokemonDict["Azumarill"]);
        private void btnCharizard_Click_1(object sender, EventArgs e) => displayPokemon(pokemonDict["Charizard"]);
        private void btnVenusaur_Click_1(object sender, EventArgs e) => displayPokemon(pokemonDict["Venusaur"]);
        private void btnMeditite_Click_1(object sender, EventArgs e) => displayPokemon(pokemonDict["Meditite"]);

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
