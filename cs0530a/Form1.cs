using System.Xml;

namespace cs0530a
{
    public partial class Form1 : Form
    {
        int vx = -10;
        int vy = -10;
        public Form1()
        {
            InitializeComponent();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Left += vx;
            label1.Top += vy;


            if (label1.Left < 0)
            {
                vx = -vx;
            }
                if (label1.Top < 0)
                {
                vy = -vy;
            }
            }
        

        private void label1_Click_1(object sender, EventArgs e)
        {
            vx = -vx;
            vy = -vy;
            
        }
    }
}
