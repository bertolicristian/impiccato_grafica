namespace impiccato_grafica
{
    public partial class titolo : Form
    {
        string sceltaDifficolta, sceltaCategoria;
        public titolo()
        {
            InitializeComponent();


        }

        private void btnA_Click(object sender, EventArgs e)
        {

        }

        private void animali_Click(object sender, EventArgs e)
        {
            List<string> animali = new List<string>();
            sceltaCategoria = "animali";

            using (StreamReader sr = new StreamReader("animali.txt"))
            {
                string riga = sr.ReadLine();

                while (riga != null)
                {
                    animali.Add(riga);

                    riga = sr.ReadLine();
                }
            }
        }

        private void sport_Click(object sender, EventArgs e)
        {
            List<string> sport = new List<string>();
            sceltaCategoria = "sport";

            using (StreamReader sr = new StreamReader("sport.txt"))
            {
                string riga = sr.ReadLine();

                while (riga != null)
                {
                    sport.Add(riga);

                    riga = sr.ReadLine();
                }
            }
        }

        private void città_Click(object sender, EventArgs e)
        {
            List<string> citta = new List<string>();
            sceltaCategoria = "citta";

            using (StreamReader sr = new StreamReader("città.txt"))
            {
                string riga = sr.ReadLine();

                while (riga != null)
                {
                    citta.Add(riga);

                    riga = sr.ReadLine();
                }
            }
        }

        private void facile_Click(object sender, EventArgs e)
        {
            sceltaDifficolta = "facile";
        }

        private void medio_Click(object sender, EventArgs e)
        {
            sceltaDifficolta = "medio";
        }

        private void difficile_Click(object sender, EventArgs e)
        {
            sceltaDifficolta = "difficile";
        }
    }
}
