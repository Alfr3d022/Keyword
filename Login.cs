using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace Keyword
{
    public partial class Login : Form
    {
        Thread th;
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(abrirJanela);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void abrirJanela(object obj)
        {
            Application.Run(new Home());
        }
    }
}