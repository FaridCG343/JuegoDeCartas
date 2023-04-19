using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuegoDeCartas.Controllers
{
    public partial class CardDesing : UserControl
    {
        public CardDesing()
        {
            InitializeComponent();
        }

        public void SetCardName(string name)
        {
            lblNombre.Text = name;
        }

        public void SetCardAction(string action)
        {
            lblDescripcion.Text = action;
        }

        public void SetEnergia(int energia)
        {
            lblEnergia.Text = energia.ToString();
        }
    }
}
