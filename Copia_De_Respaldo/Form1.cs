using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Copia_De_Respaldo
{
    public partial class Crear_BackUp : Form
    {
        public Crear_BackUp()
        {
            InitializeComponent();
        }

        private void BackUp_Click(object sender, EventArgs e)
        {
            DataClassesDataContext db = new DataClassesDataContext();
            db.Back_Up();
            MessageBox.Show("Back-UP creado correctamente");
        }
    }
}
