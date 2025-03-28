namespace TelaInicial
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            logopizza = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)logopizza).BeginInit();
            SuspendLayout();
            // 
            // logopizza
            // 
            logopizza.Dock = DockStyle.Bottom;
            logopizza.Image = (Image)resources.GetObject("logopizza.Image");
            logopizza.Location = new Point(0, 244);
            logopizza.Name = "logopizza";
            logopizza.Size = new Size(1486, 506);
            logopizza.TabIndex = 0;
            logopizza.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(1486, 750);
            Controls.Add(logopizza);
            Font = new Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(6, 5, 6, 5);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)logopizza).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public PictureBox logopizza;
    }
}
