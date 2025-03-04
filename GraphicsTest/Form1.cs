using System.Drawing.Text;

namespace GraphicsTest
{
    public partial class Form1 : Form
    {

        private Pen BlackPen;
        private Brush YellowBrush;
        private Brush BrownBrush;
        private Image CharacterImage;
        public Form1()
        {
            InitializeComponent();
            BlackPen = new Pen(Color.Black);
            YellowBrush = new SolidBrush(Color.LightGoldenrodYellow);
            BrownBrush = new SolidBrush(Color.SandyBrown);
            // CharacterImage = Image.FromFile()
           
           
        }

        private void DrawFrame(object sender, PaintEventArgs e)
        {
            //drawlines
            //e.Graphics.DrawLine(BlackPen, 0, 0, this.Width / 2, this.Height / 2);
            
            //draw the ground
            Rectangle Sun = new Rectangle(50, 50, 100, 100);
            Rectangle Ground = new Rectangle(
                0,
                this.Height - 100,
                this.Width,
                100
            );

            e.Graphics.FillRectangle(BrownBrush, Ground);

            // draw the sun
            e.Graphics.FillEllipse(YellowBrush, Sun);

            // draw a character
         
        }   
    }
}
