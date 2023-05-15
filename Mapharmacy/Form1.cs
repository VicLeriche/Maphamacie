using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mapharmacy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int pdd = 0;
        private void Timer1_tick(object sender, EventArgs e)
        {
            pdd += 0;
            BardeProgression.Value = pdd;
            if(BardeProgression.Value == 100)
            {
                BardeProgression.Value = 0;
                timer1.Stop();
                connexion MyCon = new connexion();
                MyCon.Show();
                this.Hide();
            }
        }
        private void Form1_load (object sender,EventArgs e)
        {
            timer1.Start();
        }
    }
}