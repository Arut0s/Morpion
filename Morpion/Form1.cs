using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Morpion
{
    public partial class Morpion : Form
    {
        int nbClic = 0;
        List<Button> btnListe = new List<Button>();
        List<Label> lblListe = new List<Label>();
        List<int> X = new List<int>();
        List<int> O = new List<int>();
        public Morpion()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NewGame();
        }

        private void NewGame()
        {
            lblWin.Visible = false;
            lblWin.Text = "";
            CreateButtons();
            lblJoueur.Text = "1";
            X.Clear();
            O.Clear();
            nbClic = 0;
        }

        private void CreateButtons()
        {
            DeleteButtons();
            int size = 50;
            btnListe.Clear();
            lblListe.Clear();
            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {

                    Label label = new Label();
                    Controls.Add(label);
                    label.Visible = false;
                    label.Text = "";
                    label.Size = new Size(30, 30);
                    label.Font = new Font("", 18);
                    label.Location = new Point(27 + (size + 5) * x, 50 + (size + 5) * y);
                    lblListe.Add(label);


                    Button btn = new Button();
                    Controls.Add(btn);
                    btn.Size = new Size(size, size);
                    btn.Visible = true;
                    btn.Location = new Point(15 + (size + 5) * x, 40 + (size + 5) * y);
                    btn.Click += new EventHandler(button_Click);
                    btnListe.Add(btn);
                }
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            nbClic++;
            var indice = btnListe.IndexOf((Button)sender);
            btnListe[indice].Visible = false;
            lblListe[indice].Visible = true;
            if (lblJoueur.Text == "1")
            {
                lblListe[indice].Text = "X";
            }
            else
            {
                lblListe[indice].Text = "O";
            }
            if (Winner(indice, lblJoueur.Text))
            {
                End("Victoire du joueur " + lblJoueur.Text + " !");
                PlayerChange();
            }
            else
            {
                if (nbClic == 9)
                {
                    End("Égalité !");
                }
            }
            PlayerChange();

        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            NewGame();
        }

        private void PlayerChange()
        {
            if (lblJoueur.Text == "1")
            {
                lblJoueur.Text = "2";
            }
            else
            {
                lblJoueur.Text = "1";
            }
        }
        private void DeleteButtons()
        {
            for (int k = 0; k < btnListe.Count + lblListe.Count; k++)
            {
                this.Controls.RemoveAt(4);
            }
        }
        private void End(string message)
        {
            lblWin.Visible = true;
            lblWin.Text = message;
            for (int k = 0; k < btnListe.Count; k++)
            {
                btnListe[k].Enabled = false;
                btnListe[k].Visible = false;
            }

        }
        private bool Winner(int indice, string Joueur)
        {
            //Victoire du joueur 1 (X)//
            if (lblListe[indice].Text == "X")
            {
                X.Add(indice);
                if (X.Contains(4))
                {
                    if (X.Contains(0) && X.Contains(8) || X.Contains(2) && X.Contains(6) || X.Contains(1) && X.Contains(7) || X.Contains(3) && X.Contains(5))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
                else
                {
                    if (X.Contains(0))
                    {
                        if (X.Contains(1) && X.Contains(2) || X.Contains(3) && X.Contains(6))
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        if (X.Contains(8))
                        {
                            if (X.Contains(6) && X.Contains(7) || X.Contains(2) && X.Contains(5))
                            {
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
            else
            {
                O.Add(indice);
                if (O.Contains(4))
                {
                    if (O.Contains(0) && O.Contains(8) || O.Contains(2) && O.Contains(6) || O.Contains(1) && O.Contains(7) || O.Contains(3) && O.Contains(5))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    if (O.Contains(0))
                    {
                        if (O.Contains(1) && O.Contains(2) || O.Contains(3) && O.Contains(6))
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        if (O.Contains(8))
                        {
                            if (O.Contains(6) && O.Contains(7) || O.Contains(2) && O.Contains(5))
                            {
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
        }
    }
}
