using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace Elevator2
{
    public partial class Elevator : UserControl
    {
        public delegate void SendFloorVal(Elevator vator);
        public event SendFloorVal SendFloor;

        SoundPlayer player = new("Boat Cruise.wav");
        Timer Movingtimer = new Timer();
        private static int counter = 0;
        public int myNum;
        private enum MovingState { Stopped, Moving, Opening, Closing };
        private MovingState movingState;
        private bool UpOrDown;
        public int floorAt = 1;
        private int[] floorLevels = new int[] { 500, 400, 300, 200, 100, 0 };
        public int floorPick = 1;
        private int doorCounter;

        public Elevator(Form mainForm, int x, int y)
        {
            InitializeComponent();
            movingState = MovingState.Stopped;
            picDoor.Image = Form1.doorPics[1];
            lblFloor.Text = "Floor " + floorAt;
            Left = x;
            Top = y;
            myNum = counter;
            counter++;

            Movingtimer.Interval = 10;
            Movingtimer.Tick += MovingTimer_Tick;
            Movingtimer.Enabled = true;
            mainForm.Controls.Add(this);
        }

        private void MovingTimer_Tick(object? sender, EventArgs e)
        {
            switch (movingState)
            {
                case MovingState.Stopped:
                    player.Stop();
                    if (floorPick > floorAt)
                    {
                        UpOrDown = true;
                        doorCounter = 3;
                        movingState = MovingState.Closing;
                        floorAt++;
                    }
                    else if (floorPick < floorAt)
                    {
                        UpOrDown = false;
                        doorCounter = 3;
                        movingState = MovingState.Closing;
                        floorAt--;
                    }
                    else
                        movingState = MovingState.Stopped;
                    break;

                case MovingState.Moving:
                    picDoor.Image = Form1.doorPics[0];
                    if (UpOrDown) Top -= 1;
                    else Top += 1;

                    if (Top == floorLevels[floorAt - 1])
                    {
                        lblFloor.Text = $"Floor {floorAt}";
                        SendFloor.Invoke(this);
                        if (floorPick != floorAt)
                        {
                            if (UpOrDown) floorAt++;
                            else floorAt--;
                        }
                        else
                        {
                            movingState = MovingState.Opening;
                            doorCounter = 44;
                            floorAt = floorPick;
                        }
                    }
                    break;

                case MovingState.Opening:
                    picDoor.Image = Form1.doorPics[doorCounter - 1];
                    doorCounter--;
                    if (doorCounter == 3) movingState = MovingState.Stopped;
                    break;

                case MovingState.Closing:
                    picDoor.Image = Form1.doorPics[doorCounter - 1];
                    player.Play();
                    doorCounter++;
                    if (doorCounter == 44) movingState = MovingState.Moving;
                    break;
            }
        }
    }
}
