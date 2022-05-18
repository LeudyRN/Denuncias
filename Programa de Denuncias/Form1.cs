namespace TareaFinal;

public partial class Form1Login : Form
{

    string Usuario = "Itadori";
    string Contraseña = "Itadori";
    public Form1Login()

    {
        InitializeComponent();
    }


    private void button2_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        if (txtUsuario.Text != Usuario || txtContraseña.Text != Contraseña)
        {
            
                Form2 form = new Form2();
                form.ShowDialog();

            
        }
        else
        {
            MessageBox.Show("Usuario o Contraseña incorrecta, por favor intentarlo de nuevo ");
        }
    }

}
