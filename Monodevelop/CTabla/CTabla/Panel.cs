using System;
using Gtk;

namespace CTabla {

    public class Panel
    {
        public Panel(VBox vbox)
        {

            Table table = new Table(3, 3, true);
            int index = 0;
            int num = 0;
            for (int row = 0; row < 3; row++)
            {
                for (int column = 0; column < 3; column++)
                {
                    index++;
                    Button button = new Button();
                    table.Attach(button, (uint)column, (uint)column + 1, (uint)row, (uint)row + 1);
                    //button.Label = "Button";
                    button.Label = "Button " + index.ToString();
                    button.Clicked += delegate {
                        num++;
                        if (num / 2 == 0) {
                            button.ModifyBg(StateType.Normal, new Gdk.Color(100, 200, 200));
                        }
                        else {
                            button.ModifyBg(StateType.Normal, new Gdk.Color(255, 0, 0));
                        }
                    };

                }
                vbox.Add(table);
                table.ShowAll();

            }
        }
    }
}