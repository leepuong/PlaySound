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

namespace PlaySound
{
    public partial class frmPlaySound : Form
    {
        private SoundPlayer soundPlayerFF;
        private SoundPlayer soundPlayerAH;
        private SoundPlayer soundPlayer;
        public frmPlaySound()
        {
            InitializeComponent();

            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;

            // Đi lên hai cấp để đến được thư mục gốc của dự án
            string projectDirectory = System.IO.Path.GetFullPath(System.IO.Path.Combine(baseDirectory, @"..\..\"));

            // Kết hợp đường dẫn thư mục gốc với thư mục Resources và tên file âm thanh
            string soundFileFF = System.IO.Path.Combine(projectDirectory, "Resources", "freefiresound.wav");
            string soundFileAH = System.IO.Path.Combine(projectDirectory, "Resources", "anghieusound.wav");



            soundPlayerFF = new SoundPlayer(soundFileFF);


            // Gán sự kiện Click cho btnPlaySound
            btnFF.Click += btnFF_Click;


            soundPlayerAH = new SoundPlayer(soundFileAH);

            // Gán sự kiện Click cho btnPlaySound
            btnAngHiu.Click += btnAngHiu_Click;


            lblStop.Click += lblStop_Click;
        }

        private void btnFF_Click(object sender, EventArgs e)
        {
            try
            {
                soundPlayerFF.Play();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error playing sound: " + ex.Message);
            }

        }

        private void btnAngHiu_Click(object sender, EventArgs e)
        {
            try
            {
                soundPlayerAH.Play();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error playing sound: " + ex.Message);
            }
        }

        private void lblStop_Click(object sender, EventArgs e)
        {
            try
            {
                soundPlayerAH.Stop();
                soundPlayerFF.Stop();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error stopping sound: " + ex.Message);
            }
        }
    }
}
