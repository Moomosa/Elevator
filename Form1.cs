using System.Text;

namespace Elevator2
{
    public partial class Form1 : Form
    {
        private int eStartHeight = 500;
        public Form mainform;
        public static List<Bitmap> doorPics = new();
        Elevator e1;
        Elevator e2;
        Elevator e3;
        Elevator e4;
        Elevator e5;

        public Form1()
        {
            InitializeComponent();
            mainform = this;
            doorPics.Add(new Bitmap("closedDoor.png"));
            doorPics.Add(new Bitmap("openDoor.png"));
            foreach (string image in Directory.GetFiles("Doors"))
                doorPics.Add(new Bitmap(image));

            e1 = new Elevator(mainform, 92, eStartHeight);
            e1.SendFloor += GetFloor;

            e2 = new Elevator(mainform, 235, eStartHeight);
            e2.SendFloor += GetFloor;

            e3 = new Elevator(mainform, 378, eStartHeight);
            e3.SendFloor += GetFloor;

            e4 = new Elevator(mainform, 521, eStartHeight);
            e4.SendFloor += GetFloor;

            e5 = new Elevator(mainform, 664, eStartHeight);
            e5.SendFloor += GetFloor;
        }

        public void GetFloor(Elevator current)
        {
            switch (current.myNum)
            {
                case 0:
                    lblE1.Text = $"Floor " + current.floorAt.ToString();
                    break;
                case 1:
                    lblE2.Text = $"Floor " + current.floorAt.ToString();
                    break;
                case 2:
                    lblE3.Text = $"Floor " + current.floorAt.ToString();
                    break;
                case 3:
                    lblE4.Text = $"Floor " + current.floorAt.ToString();
                    break;
                case 4:
                    lblE5.Text = $"Floor " + current.floorAt.ToString();
                    break;
            }
        }

        private void cmbDoor1_SelectedValueChanged_1(object sender, EventArgs e)
        {
            ChangeFloor(e1, cmbDoor1);
        }

        private void cmbDoor2_SelectedValueChanged_1(object sender, EventArgs e)
        {
            ChangeFloor(e2, cmbDoor2);
        }

        private void cmbDoor3_SelectedValueChanged_1(object sender, EventArgs e)
        {
            ChangeFloor(e3, cmbDoor3);
        }

        private void cmbDoor4_SelectedValueChanged_1(object sender, EventArgs e)
        {
            ChangeFloor(e4, cmbDoor4);
        }

        private void cmbDoor5_SelectedValueChanged_1(object sender, EventArgs e)
        {
            ChangeFloor(e5, cmbDoor5);
        }

        public void ChangeFloor(Elevator vator, ComboBox cmb)
        {
            vator.floorPick = int.Parse(cmb.SelectedItem.ToString());
        }
    }
}
