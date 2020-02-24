using System;
using Gtk;
using Calculadora;

public partial class MainWindow : Gtk.Window
{

    CCalculadora calc = new CCalculadora(); 
    int contador;
    int contadorres;
    double num1;
    double num2;
    double resultado;
    int op;

    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    protected void OnBotonClicked(object sender, EventArgs e)
    {
        String display = pantalla.Text.ToString();
        pantalla.DeleteText(0, pantalla.Text.Length);
        pantalla.InsertText(display + "0");
    }

    protected void OnBoton1Clicked(object sender, EventArgs e)
    {
        String display = pantalla.Text.ToString();
        pantalla.DeleteText(0, pantalla.Text.Length);
        pantalla.InsertText(display + "1");
    }

    protected void OnBoton2Clicked(object sender, EventArgs e)
    {
        String display = pantalla.Text.ToString();
        pantalla.DeleteText(0, pantalla.Text.Length);
        pantalla.InsertText(display + "2");
    }

    protected void OnBoton3Clicked(object sender, EventArgs e)
    {
        String display = pantalla.Text.ToString();
        pantalla.DeleteText(0, pantalla.Text.Length);
        pantalla.InsertText(display + "3");
    }

    protected void OnBoton4Clicked(object sender, EventArgs e)
    {
        String display = pantalla.Text.ToString();
        pantalla.DeleteText(0, pantalla.Text.Length);
        pantalla.InsertText(display + "4");
    }

    protected void OnBoton5Clicked(object sender, EventArgs e)
    {
        String display = pantalla.Text.ToString();
        pantalla.DeleteText(0, pantalla.Text.Length);
        pantalla.InsertText(display + "5");
    }

    protected void OnBoton6Clicked(object sender, EventArgs e)
    {
        String display = pantalla.Text.ToString();
        pantalla.DeleteText(0, pantalla.Text.Length);
        pantalla.InsertText(display + "6");
    }

    protected void OnBoton7Clicked(object sender, EventArgs e)
    {
        String display = pantalla.Text.ToString();
        pantalla.DeleteText(0, pantalla.Text.Length);
        pantalla.InsertText(display + "7");

    }

    protected void OnBoton8Clicked(object sender, EventArgs e)
    {
        String display = pantalla.Text.ToString();
        pantalla.DeleteText(0, pantalla.Text.Length);
        pantalla.InsertText(display + "8");

    }

    protected void OnBoton9Clicked(object sender, EventArgs e)
    {
        String display = pantalla.Text.ToString();
        pantalla.DeleteText(0, pantalla.Text.Length);
        pantalla.InsertText(display + "9");
    }

    protected void OnVaciarClicked(object sender, EventArgs e)
    {
        pantalla.DeleteText(0, pantalla.Text.Length);
        contador = 0;
    }

    protected void OnBorrarClicked(object sender, EventArgs e)
    {
        pantalla.DeleteText(pantalla.Text.Length - 1, pantalla.Text.Length);
        string display = pantalla.Text.ToString();

        if (display.Contains(",")) {
            contador = 0;
        }
    }

    protected void OnDividirClicked(object sender, EventArgs e)
    {
        num1 = Convert.ToDouble(pantalla.Text);
        pantalla.DeleteText(0, pantalla.Text.Length);
        op = 4;
        contador = 0;
    }

    protected void OnMultiplicarClicked(object sender, EventArgs e)
    {
        num1 = Convert.ToDouble(pantalla.Text);
        pantalla.DeleteText(0, pantalla.Text.Length);
        op = 3;
        contador = 0;
    }

    protected void OnRestarClicked(object sender, EventArgs e)
    {
        num1 = Convert.ToDouble(pantalla.Text);
        pantalla.DeleteText(0, pantalla.Text.Length);
        op = 2;
        contador = 0;
    }

    protected void OnComaClicked(object sender, EventArgs e)
    {
        if (contador == 0)
        {
            String display = pantalla.Text.ToString();
            pantalla.DeleteText(0, pantalla.Text.Length);
            pantalla.InsertText(display + ",");
            contador++;
        }
    }

    protected void OnIgualClicked(object sender, EventArgs e)
    {

        num2 = Convert.ToDouble(pantalla.Text);

        switch (op) {
            case 1:
                resultado = calc.suma((float)num1, (float)num2);
                this.pantalla.Text = (Convert.ToString(resultado));
                break;
            case 2:
                resultado = calc.resta((float)num1, (float)num2);
                this.pantalla.Text = (Convert.ToString(resultado));
                break;
            case 3:
                resultado = calc.multiplicacion((float)num1, (float)num2);
                this.pantalla.Text = (Convert.ToString(resultado));
                break;
            case 4:
                resultado = calc.division((float)num1, (float)num2);
                this.pantalla.Text = (Convert.ToString(resultado));
                break;
        }

    }

    protected void OnSumarClicked(object sender, EventArgs e)
        { 
        num1 = Convert.ToDouble(pantalla.Text);
        pantalla.DeleteText(0, pantalla.Text.Length);
        op = 1;
        contador = 0;
        }
}
