using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YahtzeeTeerling
{
    public partial class helpView : UserControl
    {

        helpController _controller;

        public helpView(helpController controller)
        {
            _controller = controller;
            InitializeComponent();
        }

        //wanneer op help button wordt geklikt
        private void helpButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
            "Probeer een zo hoog mogelijke score te halen door op de 'werp allemaal' button te duwen. \n\nU heeft hiervoor 3 kansen. \n\nOf druk op de help button voor meer informatie op de website",
            "Yathzee info",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information,
            MessageBoxDefaultButton.Button1,
            0,
            "https://nl.wikipedia.org/wiki/Yahtzee",
            "keyword");
      }

     
    }
}
