using System;
using CBingo;
using Gtk;

public partial class MainWindow : Gtk.Window
{

    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
        Bombo bombo = new Bombo();
        Panel panel = new Panel(vbox);
        BJugar.Clicked += delegate {

            int numero = bombo.sacarBola();
            panel.Marcar(numero);
        };
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    /*protected void OnBJugarClicked(object sender, EventArgs e)
    {

        int numero = bombo.sacarBola();


    }*/

}
