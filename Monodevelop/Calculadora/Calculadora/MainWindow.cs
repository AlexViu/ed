using System;
using Gtk;

public partial class MainWindow : Gtk.Window
{
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
    }

    protected void OnBorrarClicked(object sender, EventArgs e)
    {
    }

    protected void OnDividirClicked(object sender, EventArgs e)
    {

    }

    protected void OnMultiplicarClicked(object sender, EventArgs e)
    {

    }

    protected void OnRestarClicked(object sender, EventArgs e)
    {

    }

    protected void OnComaClicked(object sender, EventArgs e)
    {
        String display = pantalla.Text.ToString();
        pantalla.DeleteText(0, pantalla.Text.Length);
        pantalla.InsertText(display + ",");
    }

    protected void OnIgualClicked(object sender, EventArgs e)
    {
    }

    protected void OnSumarClicked(object sender, EventArgs e)
    {

    }
}
