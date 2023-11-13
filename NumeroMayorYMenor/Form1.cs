namespace NumeroMayorYMenor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numero1 = Int32.Parse(textoNumero1.Text);
            int numero2 = Int32.Parse(textoNumero2.Text);
            int numero3 = Int32.Parse(textoNumero3.Text);

            int mayor = numero1;

            if (numero2 > mayor)
            {
                mayor = numero2;
            }

            if (numero3 > mayor)
            {
                mayor = numero3;
            }

            MessageBox.Show("El número mayor es: " + mayor);


            int menor = numero1;

            if (numero2 < menor)
            {
                menor = numero2;
            }

            if (numero3 < menor)
            {
                menor = numero3;
            }

            MessageBox.Show("El número menor es: " + menor);
        }
    }
}