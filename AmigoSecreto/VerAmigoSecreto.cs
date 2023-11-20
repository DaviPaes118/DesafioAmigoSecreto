using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AmigoSecreto;

namespace AmigoSecreto
{
    public partial class VerAmigoSecreto : Form
    {
        public VerAmigoSecreto()
        {
            InitializeComponent();

            Persistência.lerAmigoSecreto(listView_VerAmigoSecreto);
        }


    }
}
