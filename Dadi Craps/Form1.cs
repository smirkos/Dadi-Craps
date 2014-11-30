//Mirko Squadrani 5AI 17/10/2008
//Gioco dadi craps
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Dadi_Craps
{
    public partial class Form1 : Form
    {            
        Random g = new Random();
        int P,D1,D2,P1;
        Image nvuoto = Image.FromFile(@"Nvuoto.bmp");

        public Form1()
        {
            InitializeComponent();
            pcbDado1.Image = nvuoto;
            pcbDado2.Image = nvuoto;
        }

        private void btnLancia_Click(object sender, EventArgs e)
        {
            Image n1 = Image.FromFile(@"N1.bmp");
            Image n2 = Image.FromFile(@"N2.bmp");
            Image n3 = Image.FromFile(@"N3.bmp");
            Image n4 = Image.FromFile(@"N4.bmp");
            Image n5 = Image.FromFile(@"N5.bmp");
            Image n6 = Image.FromFile(@"N6.bmp");
            
            D1 = g.Next(1, 7);
            switch (D1)
            {
                case 1:
                    pcbDado1.Image = n1;
                    break;
                case 2:
                    pcbDado1.Image = n2;
                    break;
                case 3:
                    pcbDado1.Image = n3;
                    break;
                case 4:
                    pcbDado1.Image = n4;
                    break;
                case 5:
                    pcbDado1.Image = n5;
                    break;
                case 6:
                    pcbDado1.Image = n6;
                    break;
            }

            D2 = g.Next(1, 7);
            switch (D2)
            {
                case 1:
                    pcbDado2.Image = n1;
                    break;
                case 2:
                    pcbDado2.Image = n2;
                    break;
                case 3:
                    pcbDado2.Image = n3;
                    break;
                case 4:
                    pcbDado2.Image = n4;
                    break;
                case 5:
                    pcbDado2.Image = n5;
                    break;
                case 6:
                    pcbDado2.Image = n6;
                    break;
            }
            P = D1 + D2;
            lstNum_estratti.Items.Add(D1 + " + " + D2 + " = " + P);
            if (P == 2 || P == 3 || P == 12)
            {
                lblRis.Text = "Risultato: Hai perso!!Ritenta!";
                btnLancia.Enabled = false;
                P = 0;
                P1 = 0;
                D1 = 0;
                D2 = 0;
            }
            if (P == 7 || P == 11)
                lblRis.Text = "Risultato: Hai vinto!!";
            if (P >= 4 || P <= 10)
            {
                lblRis.Text = "Risultato: Rilancia";
                P1 = P;
                if (P1 == P)
                    lblRis.Text = "Risultato: Hai vinto!!";
                if (P == 7 || P == 11)
                {
                    lblRis.Text = "Risultato: Hai perso!!Ritenta";
                    btnLancia.Enabled = false;
                    P = 0;
                    P1 = 0;
                    D1 = 0;
                    D2 = 0;
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            btnLancia.Enabled = true;
            pcbDado1.Image = nvuoto;
            pcbDado2.Image = nvuoto;
            lstNum_estratti.Items.Clear();
            lblRis.Text = "RESET";
            P = 0;
            P1 = 0;
        }
    }
}