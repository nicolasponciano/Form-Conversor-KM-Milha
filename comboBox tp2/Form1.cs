namespace comboBox_tp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cbxConverter.Items.Add("KM para Milha");
            cbxConverter.Items.Add("Milha para KM");


        }


        private void btnConverter_Click(object sender, EventArgs e)
        {
            Converte converte = new Converte();
            converte.Valor = txtValor.Text;

            if (cbxConverter.SelectedIndex == 0)
            {
                converte.converteKm();
                txtValorConvertido.Text = converte.converteKm();
            }
            if (cbxConverter.SelectedIndex == 1)
            {
                converte.converteMilha();
                txtValorConvertido.Text = converte.converteMilha();
            }
        }
    }
}