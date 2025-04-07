using CatAsService.Modules;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatAsService
{
    public partial class HomeCat : Form
    {
        private BuscarRacas buscarRacasForm;
        private FavoritarRacas favoritosRacasForm;

        public HomeCat()
        {
            InitializeComponent();
            
        }

        private void buscarRacasMenuItem_Click(object sender, EventArgs e)
        {
            if (buscarRacasForm == null || buscarRacasForm.IsDisposed)
            {
                buscarRacasForm = new BuscarRacas();
                buscarRacasForm.Show();
            }
            else
            {
                buscarRacasForm.BringToFront();
                //buscarRacasForm.Focus();
            }
        }

        private void meusFavoritosMenuItem_Click(object sender, EventArgs e)
        {
            if (favoritosRacasForm == null || favoritosRacasForm.IsDisposed)
            {
                favoritosRacasForm = new FavoritarRacas();
                favoritosRacasForm.Show();
            }
            else
            {
                favoritosRacasForm.BringToFront();
                //favoritosRacasForm.Focus();
            }
        }
    }
}
