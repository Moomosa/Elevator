namespace Elevator2
{
    partial class Elevator
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblFloor = new System.Windows.Forms.Label();
            this.picDoor = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picDoor)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFloor
            // 
            this.lblFloor.AutoSize = true;
            this.lblFloor.Location = new System.Drawing.Point(12, 73);
            this.lblFloor.Name = "lblFloor";
            this.lblFloor.Size = new System.Drawing.Size(38, 15);
            this.lblFloor.TabIndex = 0;
            this.lblFloor.Text = "label1";
            // 
            // picDoor
            // 
            this.picDoor.Location = new System.Drawing.Point(3, 3);
            this.picDoor.Name = "picDoor";
            this.picDoor.Size = new System.Drawing.Size(67, 67);
            this.picDoor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDoor.TabIndex = 1;
            this.picDoor.TabStop = false;
            // 
            // Elevator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.picDoor);
            this.Controls.Add(this.lblFloor);
            this.Name = "Elevator";
            this.Size = new System.Drawing.Size(74, 93);
            ((System.ComponentModel.ISupportInitialize)(this.picDoor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblFloor;
        private PictureBox picDoor;
    }
}
