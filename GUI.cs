using System.Windows.Forms;
using System.Drawing;

public class GUI : Form
{
    public GUI()
    {
       Text = "GUI";
       Size = new Size(250, 200);
       CenterToScreen();
    }

    static public void Main()
    {
       Application.Run(new GUI());
    }
}