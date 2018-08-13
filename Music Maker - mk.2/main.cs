using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music_Maker___mk._2
{
    public partial class main : Form
    {
        Form second;

        public main()
        {
            InitializeComponent();

            resize.DoWork += new DoWorkEventHandler(resize_DoWork);
        }

        private void main_Load(object sender, EventArgs e)
        {
            main_SizeChanged(new object(), new EventArgs());
        }

        private void main_SizeChanged(object sender, EventArgs e)
        {
            // -10 (group box padding left + right)
            // -6 (for each gap between 2 buttons)
            // devide the altered group box width by the number of buttons to find button sizes
            // position = previous button location + its size + 6
            if (!resize.IsBusy) { resize.RunWorkerAsync(); }
            
        }

        private void button_Kick_Click(object sender, EventArgs e)
        {

            second = new Form1();
           
            second.Show();
        }

        private void button_Info_Click(object sender, EventArgs e)
        {

        }

        private void resize_DoWork(object sender, DoWorkEventArgs e)
        {

            System.Threading.Thread.Sleep(80);

            int buttonNb = 0;

            Size buttonSize = new Size((groupBox_Queue.Size.Width - 24) / 3, 31);

            foreach (Button button in groupBox_Queue.Controls.OfType<Button>())
            {
                int margin = 6;
                if (buttonNb > 0) { margin = 6 + (6 * buttonNb); }

                Point buttonLocation = new Point(buttonSize.Width * buttonNb + margin, groupBox_Queue.Size.Height - buttonSize.Height - 6);

                this.Invoke(new MethodInvoker(delegate {
                    button.Size = buttonSize;
                    button.Location = buttonLocation;
                }));

                buttonNb++;

            }

            Size textBox_PlayingSize = new Size(((groupBox_Playing.Size.Width - 18) / 4) * 3, textBox_Playing.Size.Height);
            Size button_SkipSize = new Size(((groupBox_Playing.Size.Width - 18) / 4), button_Skip.Size.Height);
            Point button_SkipLocation = new Point(textBox_Playing.Location.X + textBox_PlayingSize.Width + 6, button_Skip.Location.Y);
            Point groupBox_PlayingLocation = new Point(groupBox_Playing.Location.X, groupBox_Queue.Location.Y + groupBox_Queue.Size.Height + 6);

            this.Invoke(new MethodInvoker(delegate {
                textBox_Playing.Size = textBox_PlayingSize;
                button_Skip.Size = button_SkipSize;
                button_Skip.Location = button_SkipLocation;
                groupBox_Playing.Location = groupBox_PlayingLocation;
            }));

            int column_WidthOuter = (listView_Queue.Size.Width / 4) * 2;
            int column_WidthInner = (listView_Queue.Size.Width / 4);

            this.Invoke(new MethodInvoker(delegate
            {
                column_Title.Width = column_WidthOuter;
                column_VideoId.Width = column_WidthInner;
                column_Requester.Width = column_WidthInner;
            }));
        }

        private void button_BanUser_Click(object sender, EventArgs e)
        {
            second.Dispose();
        }

        private void listBox_Queue_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

