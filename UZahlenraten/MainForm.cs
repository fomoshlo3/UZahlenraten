namespace UZahlenraten
{
    public partial class MainForm : Form
    {
        private int _Zufallszahl = 0, _Versuche;
        

        public MainForm()
        {
            InitializeComponent();
        }

        private void CmdGenerateRandomNum_Click(object sender, EventArgs e)
        {
            _Versuche = 0;
            Random Zufallszahl = new();
            _Zufallszahl = Zufallszahl.Next(1,100);
            LblOutput.Text = $"Versuche: {_Versuche}, Eingabe: NA";
        }

        private void CmdCompare_Click(object sender, EventArgs e)
        {
            _Versuche++;
            int tipp = Int32.Parse(TBxInput.Text);
            TBxInput.Text = "";
            if (tipp < _Zufallszahl)
            {
                LblOutput.Text = $"Versuche: {_Versuche}, Eingabe: {tipp}, zu klein";
            }
            else if (tipp > _Zufallszahl)
            {
                LblOutput.Text = $"Versuche: {_Versuche}, Eingabe: {tipp}, zu groﬂ";
            }
            else
            {
                LblOutput.Text = $"Versuche: {_Versuche}, Eingabe: {tipp}, gewonnen";
            }
        }
    }
}