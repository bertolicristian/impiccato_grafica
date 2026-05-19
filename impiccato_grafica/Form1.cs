

namespace impiccato_grafica
{
    public partial class Form1 : Form
    {
        string sceltaDifficolta, sceltaCategoria, parolaScelta, parolaNascosta;
        char letteraScelta;
        int posizioneParola;
        List<string> animali = new List<string>();
        List<string> sport = new List<string>();
        List<string> citta = new List<string>();
        public Form1()
        {
            InitializeComponent();

            buttonA.Visible = false;
            buttonB.Visible = false;
            buttonC.Visible = false;
            buttonD.Visible = false;
            buttonE.Visible = false;
            buttonF.Visible = false;
            buttonG.Visible = false;
            buttonH.Visible = false;
            buttonI.Visible = false;
            buttonJ.Visible = false;
            buttonK.Visible = false;
            buttonL.Visible = false;
            buttonM.Visible = false;
            buttonN.Visible = false;
            buttonO.Visible = false;
            buttonP.Visible = false;
            buttonQ.Visible = false;
            buttonR.Visible = false;
            buttonS.Visible = false;
            buttonT.Visible = false;
            buttonU.Visible = false;
            buttonV.Visible = false;
            buttonW.Visible = false;
            buttonX.Visible = false;
            buttonY.Visible = false;
            buttonZ.Visible = false;

            label3.Visible = false;
            label4.Visible = false;
            label2.Visible = false;
            label5.Text = "";
        }

        private void categoriaAnimali_Click(object sender, EventArgs e)
        {
            sceltaCategoria = "animali";


            using (StreamReader pw = new StreamReader("animali.txt"))
            {
                string riga = pw.ReadLine();

                while (riga != null)
                {
                    animali.Add(riga);

                    riga = pw.ReadLine();
                }
            }

            categoriaCitta.Visible = false;
            categoriaAnimali.Visible = false;
            categoriaSport.Visible = false;
            label1.Visible = false;
            label2.Visible = true;
        }

        private void categoriaSport_Click(object sender, EventArgs e)
        {
            sceltaCategoria = "sport";




            using (StreamReader pw = new StreamReader("sport.txt"))
            {
                string riga = pw.ReadLine();

                while (riga != null)
                {
                    sport.Add(riga);

                    riga = pw.ReadLine();
                }
            }

            categoriaCitta.Visible = false;
            categoriaAnimali.Visible = false;
            categoriaSport.Visible = false;
            label1.Visible = false;
            label2.Visible = true;
        }

        private void categoriaCitta_Click(object sender, EventArgs e)
        {
            sceltaCategoria = "citta";


            using (StreamReader pw = new StreamReader("città.txt"))
            {
                string riga = pw.ReadLine();

                while (riga != null)
                {
                    citta.Add(riga);

                    riga = pw.ReadLine();
                }
            }

            categoriaCitta.Visible = false;
            categoriaAnimali.Visible = false;
            categoriaSport.Visible = false;
            label1.Visible = false;
            label2.Visible = true;
        }

        private void difficoltaFacile_Click(object sender, EventArgs e)
        {
            sceltaDifficolta = "facile";
            difficoltaFacile.Visible = false;
            difficoltaMedia.Visible = false;
            difficoltaDifficile.Visible = false;

            if (sceltaCategoria == "sport" && sceltaDifficolta == "facile")
            {
                Random random = new Random();
                posizioneParola = random.Next(1, 11);
                parolaScelta = new string('_', sport[posizioneParola].Length);
                parolaNascosta = sport[posizioneParola];
                label5.Text = parolaScelta;
            }

            else if (sceltaCategoria == "animali" && sceltaDifficolta == "facile")
            {
                Random random = new Random();
                posizioneParola = random.Next(1, 11);
                parolaScelta = new string('_', animali[posizioneParola].Length);
                parolaNascosta = animali[posizioneParola];
                label5.Text = parolaScelta;
            }

            else if (sceltaCategoria == "citta" && sceltaDifficolta == "facile")
            {
                Random random = new Random();
                posizioneParola = random.Next(1, 11);
                parolaScelta = new string('_', citta[posizioneParola].Length);
                parolaNascosta = citta[posizioneParola];
                label5.Text = parolaScelta;
            }


            label2.Visible = false;
            buttonA.Visible = true;
            buttonB.Visible = true;
            buttonC.Visible = true;
            buttonD.Visible = true;
            buttonE.Visible = true;
            buttonF.Visible = true;
            buttonG.Visible = true;
            buttonH.Visible = true;
            buttonI.Visible = true;
            buttonJ.Visible = true;
            buttonK.Visible = true;
            buttonL.Visible = true;
            buttonM.Visible = true;
            buttonN.Visible = true;
            buttonO.Visible = true;
            buttonP.Visible = true;
            buttonQ.Visible = true;
            buttonR.Visible = true;
            buttonS.Visible = true;
            buttonT.Visible = true;
            buttonU.Visible = true;
            buttonV.Visible = true;
            buttonW.Visible = true;
            buttonX.Visible = true;
            buttonY.Visible = true;
            buttonZ.Visible = true;

            label3.Visible = true;
            label4.Visible = true;
        }

        private void difficoltaMedia_Click(object sender, EventArgs e)
        {
            sceltaDifficolta = "media";

            if (sceltaCategoria == "sport" && sceltaDifficolta == "media")
            {
                Random random = new Random();
                posizioneParola = random.Next(12, 22);
                parolaScelta = new string('_', sport[posizioneParola].Length);
                parolaNascosta = sport[posizioneParola];
                label5.Text = parolaScelta;
            }

            else if (sceltaCategoria == "animali" && sceltaDifficolta == "media")
            {
                Random random = new Random();
                posizioneParola = random.Next(12, 22);
                parolaScelta = new string('_', animali[posizioneParola].Length);
                parolaNascosta = animali[posizioneParola];
                label5.Text = parolaScelta;
            }

            else if (sceltaCategoria == "citta" && sceltaDifficolta == "media")
            {
                Random random = new Random();
                posizioneParola = random.Next(12, 22);
                parolaScelta = new string('_', citta[posizioneParola].Length);
                parolaNascosta = citta[posizioneParola];
                label5.Text = parolaScelta;
            }

            difficoltaFacile.Visible = false;
            difficoltaMedia.Visible = false;
            difficoltaDifficile.Visible = false;
            label2.Visible = false;
            buttonA.Visible = true;
            buttonB.Visible = true;
            buttonC.Visible = true;
            buttonD.Visible = true;
            buttonE.Visible = true;
            buttonF.Visible = true;
            buttonG.Visible = true;
            buttonH.Visible = true;
            buttonI.Visible = true;
            buttonJ.Visible = true;
            buttonK.Visible = true;
            buttonL.Visible = true;
            buttonM.Visible = true;
            buttonN.Visible = true;
            buttonO.Visible = true;
            buttonP.Visible = true;
            buttonQ.Visible = true;
            buttonR.Visible = true;
            buttonS.Visible = true;
            buttonT.Visible = true;
            buttonU.Visible = true;
            buttonV.Visible = true;
            buttonW.Visible = true;
            buttonX.Visible = true;
            buttonY.Visible = true;
            buttonZ.Visible = true;

            label3.Visible = true;
            label4.Visible = true;
        }

        private void difficoltaDifficile_Click(object sender, EventArgs e)
        {
            sceltaDifficolta = "difficile";

            if (sceltaCategoria == "sport" && sceltaDifficolta == "difficile")
            {
                Random random = new Random();
                posizioneParola = random.Next(23, 33);
                parolaScelta = new string('_', sport[posizioneParola].Length);
                parolaNascosta = sport[posizioneParola];
                label5.Text = parolaScelta;
            }

            else if (sceltaCategoria == "animali" && sceltaDifficolta == "difficile")
            {
                Random random = new Random();
                posizioneParola = random.Next(23, 33);
                parolaScelta = new string('_', animali[posizioneParola].Length);
                parolaNascosta = animali[posizioneParola];
                label5.Text = parolaScelta;
            }

            else if (sceltaCategoria == "citta" && sceltaDifficolta == "difficile")
            {
                Random random = new Random();
                posizioneParola = random.Next(23, 33);
                parolaScelta = new string('_', citta[posizioneParola].Length);
                parolaNascosta = citta[posizioneParola];
                label5.Text = parolaScelta;
            }

            difficoltaFacile.Visible = false;
            difficoltaMedia.Visible = false;
            difficoltaDifficile.Visible = false;
            label2.Visible = false;
            buttonA.Visible = true;
            buttonB.Visible = true;
            buttonC.Visible = true;
            buttonD.Visible = true;
            buttonE.Visible = true;
            buttonF.Visible = true;
            buttonG.Visible = true;
            buttonH.Visible = true;
            buttonI.Visible = true;
            buttonJ.Visible = true;
            buttonK.Visible = true;
            buttonL.Visible = true;
            buttonM.Visible = true;
            buttonN.Visible = true;
            buttonO.Visible = true;
            buttonP.Visible = true;
            buttonQ.Visible = true;
            buttonR.Visible = true;
            buttonS.Visible = true;
            buttonT.Visible = true;
            buttonU.Visible = true;
            buttonV.Visible = true;
            buttonW.Visible = true;
            buttonX.Visible = true;
            buttonY.Visible = true;
            buttonZ.Visible = true;

            label3.Visible = true;
            label4.Visible = true;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void buttonA_Click(object sender, EventArgs e)
        {
            letteraScelta = 'a';
            char[] pSChar = parolaScelta.ToCharArray();

            if (parolaNascosta.Contains(letteraScelta))
            {
                for (int i = 0; i < parolaNascosta.Length; i++)
                {
                    if (parolaNascosta[i] == letteraScelta)
                    {
                        pSChar[i] = letteraScelta;
                    }
                }
            }

            parolaScelta = new string(pSChar);
            label5.Text = parolaScelta;
        }

        private void buttonB_Click(object sender, EventArgs e)
        {
            letteraScelta = 'b';
            char[] pSChar = parolaScelta.ToCharArray();

            if (parolaNascosta.Contains(letteraScelta))
            {
                for (int i = 0; i < parolaNascosta.Length; i++)
                {
                    if (parolaNascosta[i] == letteraScelta)
                    {
                        pSChar[i] = letteraScelta;
                    }
                }
            }

            parolaScelta = new string(pSChar);
            label5.Text = parolaScelta;
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            letteraScelta = 'c';
            char[] pSChar = parolaScelta.ToCharArray();

            if (parolaNascosta.Contains(letteraScelta))
            {
                for (int i = 0; i < parolaNascosta.Length; i++)
                {
                    if (parolaNascosta[i] == letteraScelta)
                    {
                        pSChar[i] = letteraScelta;
                    }
                }
            }

            parolaScelta = new string(pSChar);
            label5.Text = parolaScelta;
        }

        private void buttonD_Click(object sender, EventArgs e)
        {
            letteraScelta = 'd';
            char[] pSChar = parolaScelta.ToCharArray();

            if (parolaNascosta.Contains(letteraScelta))
            {
                for (int i = 0; i < parolaNascosta.Length; i++)
                {
                    if (parolaNascosta[i] == letteraScelta)
                    {
                        pSChar[i] = letteraScelta;
                    }
                }
            }

            parolaScelta = new string(pSChar);
            label5.Text = parolaScelta;
        }

        private void buttonE_Click(object sender, EventArgs e)
        {
            letteraScelta = 'e';
            char[] pSChar = parolaScelta.ToCharArray();

            if (parolaNascosta.Contains(letteraScelta))
            {
                for (int i = 0; i < parolaNascosta.Length; i++)
                {
                    if (parolaNascosta[i] == letteraScelta)
                    {
                        pSChar[i] = letteraScelta;
                    }
                }
            }

            parolaScelta = new string(pSChar);
            label5.Text = parolaScelta;
        }

        private void buttonF_Click(object sender, EventArgs e)
        {
            letteraScelta = 'f';
            char[] pSChar = parolaScelta.ToCharArray();

            if (parolaNascosta.Contains(letteraScelta))
            {
                for (int i = 0; i < parolaNascosta.Length; i++)
                {
                    if (parolaNascosta[i] == letteraScelta)
                    {
                        pSChar[i] = letteraScelta;
                    }
                }
            }

            parolaScelta = new string(pSChar);
            label5.Text = parolaScelta;
        }

        private void buttonG_Click(object sender, EventArgs e)
        {
            letteraScelta = 'g';
            char[] pSChar = parolaScelta.ToCharArray();

            if (parolaNascosta.Contains(letteraScelta))
            {
                for (int i = 0; i < parolaNascosta.Length; i++)
                {
                    if (parolaNascosta[i] == letteraScelta)
                    {
                        pSChar[i] = letteraScelta;
                    }
                }
            }

            parolaScelta = new string(pSChar);
            label5.Text = parolaScelta;
        }

        private void buttonH_Click(object sender, EventArgs e)
        {
            letteraScelta = 'h';
            char[] pSChar = parolaScelta.ToCharArray();

            if (parolaNascosta.Contains(letteraScelta))
            {
                for (int i = 0; i < parolaNascosta.Length; i++)
                {
                    if (parolaNascosta[i] == letteraScelta)
                    {
                        pSChar[i] = letteraScelta;
                    }
                }
            }

            parolaScelta = new string(pSChar);
            label5.Text = parolaScelta;
        }

        private void buttonI_Click(object sender, EventArgs e)
        {
            letteraScelta = 'i';
            char[] pSChar = parolaScelta.ToCharArray();

            if (parolaNascosta.Contains(letteraScelta))
            {
                for (int i = 0; i < parolaNascosta.Length; i++)
                {
                    if (parolaNascosta[i] == letteraScelta)
                    {
                        pSChar[i] = letteraScelta;
                    }
                }
            }

            parolaScelta = new string(pSChar);
            label5.Text = parolaScelta;
        }

        private void buttonJ_Click(object sender, EventArgs e)
        {
            letteraScelta = 'j';
            char[] pSChar = parolaScelta.ToCharArray();

            if (parolaNascosta.Contains(letteraScelta))
            {
                for (int i = 0; i < parolaNascosta.Length; i++)
                {
                    if (parolaNascosta[i] == letteraScelta)
                    {
                        pSChar[i] = letteraScelta;
                    }
                }
            }

            parolaScelta = new string(pSChar);
            label5.Text = parolaScelta;
        }

        private void buttonK_Click(object sender, EventArgs e)
        {
            letteraScelta = 'k';
            char[] pSChar = parolaScelta.ToCharArray();

            if (parolaNascosta.Contains(letteraScelta))
            {
                for (int i = 0; i < parolaNascosta.Length; i++)
                {
                    if (parolaNascosta[i] == letteraScelta)
                    {
                        pSChar[i] = letteraScelta;
                    }
                }
            }

            parolaScelta = new string(pSChar);
            label5.Text = parolaScelta;
        }

        private void buttonL_Click(object sender, EventArgs e)
        {
            letteraScelta = 'l';
            char[] pSChar = parolaScelta.ToCharArray();

            if (parolaNascosta.Contains(letteraScelta))
            {
                for (int i = 0; i < parolaNascosta.Length; i++)
                {
                    if (parolaNascosta[i] == letteraScelta)
                    {
                        pSChar[i] = letteraScelta;
                    }
                }
            }

            parolaScelta = new string(pSChar);
            label5.Text = parolaScelta;
        }

        private void buttonM_Click(object sender, EventArgs e)
        {
            letteraScelta = 'm';
            char[] pSChar = parolaScelta.ToCharArray();

            if (parolaNascosta.Contains(letteraScelta))
            {
                for (int i = 0; i < parolaNascosta.Length; i++)
                {
                    if (parolaNascosta[i] == letteraScelta)
                    {
                        pSChar[i] = letteraScelta;
                    }
                }
            }

            parolaScelta = new string(pSChar);
            label5.Text = parolaScelta;
        }

        private void buttonN_Click(object sender, EventArgs e)
        {
            letteraScelta = 'n';
            char[] pSChar = parolaScelta.ToCharArray();

            if (parolaNascosta.Contains(letteraScelta))
            {
                for (int i = 0; i < parolaNascosta.Length; i++)
                {
                    if (parolaNascosta[i] == letteraScelta)
                    {
                        pSChar[i] = letteraScelta;
                    }
                }
            }

            parolaScelta = new string(pSChar);
            label5.Text = parolaScelta;
        }

        private void buttonO_Click(object sender, EventArgs e)
        {
            letteraScelta = 'o';
            char[] pSChar = parolaScelta.ToCharArray();

            if (parolaNascosta.Contains(letteraScelta))
            {
                for (int i = 0; i < parolaNascosta.Length; i++)
                {
                    if (parolaNascosta[i] == letteraScelta)
                    {
                        pSChar[i] = letteraScelta;
                    }
                }
            }

            parolaScelta = new string(pSChar);
            label5.Text = parolaScelta;
        }

        private void buttonP_Click(object sender, EventArgs e)
        {
            letteraScelta = 'p';
            char[] pSChar = parolaScelta.ToCharArray();

            if (parolaNascosta.Contains(letteraScelta))
            {
                for (int i = 0; i < parolaNascosta.Length; i++)
                {
                    if (parolaNascosta[i] == letteraScelta)
                    {
                        pSChar[i] = letteraScelta;
                    }
                }
            }

            parolaScelta = new string(pSChar);
            label5.Text = parolaScelta;
        }

        private void buttonQ_Click(object sender, EventArgs e)
        {
            letteraScelta = 'q';
            char[] pSChar = parolaScelta.ToCharArray();

            if (parolaNascosta.Contains(letteraScelta))
            {
                for (int i = 0; i < parolaNascosta.Length; i++)
                {
                    if (parolaNascosta[i] == letteraScelta)
                    {
                        pSChar[i] = letteraScelta;
                    }
                }
            }

            parolaScelta = new string(pSChar);
            label5.Text = parolaScelta;
        }

        private void buttonR_Click(object sender, EventArgs e)
        {
            letteraScelta = 'r';
            char[] pSChar = parolaScelta.ToCharArray();

            if (parolaNascosta.Contains(letteraScelta))
            {
                for (int i = 0; i < parolaNascosta.Length; i++)
                {
                    if (parolaNascosta[i] == letteraScelta)
                    {
                        pSChar[i] = letteraScelta;
                    }
                }
            }

            parolaScelta = new string(pSChar);
            label5.Text = parolaScelta;
        }

        private void buttonS_Click(object sender, EventArgs e)
        {
            letteraScelta = 's';
            char[] pSChar = parolaScelta.ToCharArray();

            if (parolaNascosta.Contains(letteraScelta))
            {
                for (int i = 0; i < parolaNascosta.Length; i++)
                {
                    if (parolaNascosta[i] == letteraScelta)
                    {
                        pSChar[i] = letteraScelta;
                    }
                }
            }

            parolaScelta = new string(pSChar);
            label5.Text = parolaScelta;
        }

        private void buttonT_Click(object sender, EventArgs e)
        {
            letteraScelta = 't';
            char[] pSChar = parolaScelta.ToCharArray();

            if (parolaNascosta.Contains(letteraScelta))
            {
                for (int i = 0; i < parolaNascosta.Length; i++)
                {
                    if (parolaNascosta[i] == letteraScelta)
                    {
                        pSChar[i] = letteraScelta;
                    }
                }
            }

            parolaScelta = new string(pSChar);
            label5.Text = parolaScelta;
        }

        private void buttonU_Click(object sender, EventArgs e)
        {
            letteraScelta = 'u';
            char[] pSChar = parolaScelta.ToCharArray();

            if (parolaNascosta.Contains(letteraScelta))
            {
                for (int i = 0; i < parolaNascosta.Length; i++)
                {
                    if (parolaNascosta[i] == letteraScelta)
                    {
                        pSChar[i] = letteraScelta;
                    }
                }
            }

            parolaScelta = new string(pSChar);
            label5.Text = parolaScelta;
        }

        private void buttonV_Click(object sender, EventArgs e)
        {
            letteraScelta = 'v';
            char[] pSChar = parolaScelta.ToCharArray();

            if (parolaNascosta.Contains(letteraScelta))
            {
                for (int i = 0; i < parolaNascosta.Length; i++)
                {
                    if (parolaNascosta[i] == letteraScelta)
                    {
                        pSChar[i] = letteraScelta;
                    }
                }
            }

            parolaScelta = new string(pSChar);
            label5.Text = parolaScelta;
        }

        private void buttonW_Click(object sender, EventArgs e)
        {
            letteraScelta = 'w';
            char[] pSChar = parolaScelta.ToCharArray();

            if (parolaNascosta.Contains(letteraScelta))
            {
                for (int i = 0; i < parolaNascosta.Length; i++)
                {
                    if (parolaNascosta[i] == letteraScelta)
                    {
                        pSChar[i] = letteraScelta;
                    }
                }
            }

            parolaScelta = new string(pSChar);
            label5.Text = parolaScelta;
        }

        private void buttonX_Click(object sender, EventArgs e)
        {
            letteraScelta = 'x';
            char[] pSChar = parolaScelta.ToCharArray();

            if (parolaNascosta.Contains(letteraScelta))
            {
                for (int i = 0; i < parolaNascosta.Length; i++)
                {
                    if (parolaNascosta[i] == letteraScelta)
                    {
                        pSChar[i] = letteraScelta;
                    }
                }
            }

            parolaScelta = new string(pSChar);
            label5.Text = parolaScelta;
        }

        private void buttonY_Click(object sender, EventArgs e)
        {
            letteraScelta = 'y';
            char[] pSChar = parolaScelta.ToCharArray();

            if (parolaNascosta.Contains(letteraScelta))
            {
                for (int i = 0; i < parolaNascosta.Length; i++)
                {
                    if (parolaNascosta[i] == letteraScelta)
                    {
                        pSChar[i] = letteraScelta;
                    }
                }
            }

            parolaScelta = new string(pSChar);
            label5.Text = parolaScelta;
        }

        private void buttonZ_Click(object sender, EventArgs e)
        {
            letteraScelta = 'z';
            char[] pSChar = parolaScelta.ToCharArray();

            if (parolaNascosta.Contains(letteraScelta))
            {
                for (int i = 0; i < parolaNascosta.Length; i++)
                {
                    if (parolaNascosta[i] == letteraScelta)
                    {
                        pSChar[i] = letteraScelta;
                    }
                }
            }

            parolaScelta = new string(pSChar);
            label5.Text = parolaScelta;
        }
    }
}
