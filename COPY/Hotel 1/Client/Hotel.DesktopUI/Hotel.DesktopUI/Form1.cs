using Hotel.DesktopUI.HotelServiceReference;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel.DesktopUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCallService(object sender, EventArgs e)
        {
            var service = new HotelServiceClient();
            string message = service.DoWork();
            MessageBox.Show(message);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var service = new HotelServiceClient();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var service = new HotelServiceClient();
            string message = service.DoWork();

            MessageBox.Show(message);
        }

        private void btnGetList_Click(object sender, EventArgs e)
        {
            var service = new HotelServiceClient();
            //string message = service.DoWork();
            //MessageBox.Show(message);

            string[] roomList1 = service.RoomInfoString();
            foreach (string roomItem in roomList1)
            {
                listBox1.Items.Add(roomItem);
            }


            //List<Room> roomList1 = RoomInfo();
            //foreach(Room roomItem in roomList1)
            //{
            //    listBox1.ControlAdded(roomItem);
            //}

        }

        
    }
}
