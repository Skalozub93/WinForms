namespace WinForms
{
    public partial class Form1 : Form
    {
        //public Form1()
        //{
        //    InitializeComponent();
        //    StartPosition = FormStartPosition.CenterParent;

        //}   

        private void button2_Click(object sender, EventArgs e)
        {
            Random X = new Random();
            Random Y = new Random();

            int x = X.Next(this.Width - this.button2.Width - 50);
            int y = Y.Next(this.Height - this.button2.Height - 50);

            button2.Location = new Point(x, y);
   
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Resize(object sender, EventArgs e)
        {

        }

        private void button2_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            switch(e.KeyCode)
            {
                case Keys.Down:
                    {
                        if(this.Top + this.Height < Screen.PrimaryScreen.Bounds.Bottom)
                        {
                            SetDesktopLocation(this.Left, this.Top + 50);
                        }
                    }
                    break;
                case Keys.Up:
                    {
                        if(this.Top > 0)
                        {
                            SetDesktopLocation(this.Left, this.Top - 50);
                        }
                    }
                    break;
                case Keys.Left:
                    {
                        if(this.Left > 0)
                        {
                            SetDesktopLocation(this.Left - 50, this.Top);
                        }
                    }
                    break;
                case Keys.Right:
                    {
                        if((this.Left + this.Width) == Screen.PrimaryScreen.Bounds.Right)
                        {
                            SetDesktopLocation(this.Left + 50, this.Top);
                        }
                    }
                    break;
                case Keys.Enter:
                    {
                        button2.Enabled = true;
                    }
                    break;

                default:
                    break;
            }
           
        }     
    }
}