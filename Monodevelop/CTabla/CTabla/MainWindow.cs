﻿using System;
using CTabla;
using Gtk;

public partial class MainWindow : Gtk.Window
{
    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();

        Panel panel = new Panel(vbox);


        /* Table table = new Table(3, 3, true);
        int index = 0;
        for (int row = 0; row < 3; row++) { 
            for (int column = 0; column < 3; column++) {
                index++;
                Button button = new Button();
                table.Attach(button, (uint)column, (uint)column + 1, (uint)row, (uint)row + 1);
                //button.Label = "Button";
                button.Label = "Button " + index.ToString();
                button.Clicked +=delegate {

                    button.ModifyBg(StateType.Normal, new Gdk.Color(100, 200, 200));
                };

            }
            vbox.Add(table);
            table.ShowAll(); 
        }*/
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }
}
