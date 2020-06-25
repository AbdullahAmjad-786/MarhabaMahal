using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity.Migrations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MarhabaDatabase;

namespace MarhabaMahal.Views
{
    public partial class ChangeTcpSettings : Form
    {
        public ChangeTcpSettings()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            bool dataCorrect = true;
            MarhabaEntities entities = new MarhabaEntities();
            var settings = entities.tcp_settings.FirstOrDefault();
            if (txtIP != null)
                settings.IPAddress = txtIP.Text.ToString();
            else
            {
                dataCorrect = false;
                MessageBox.Show("IP not Entered");
            }

            if (txtPort != null)
                settings.Port = txtPort.Text.ToString();
            else
            {
                dataCorrect = false;
                MessageBox.Show("Port not Entered");
            }

            if (txtPath != null)
                settings.Path = txtPath.Text.ToString();
            else
            {
                dataCorrect = false;
                MessageBox.Show("Path not Entered");
            }

            if (dataCorrect)
            {
                entities.tcp_settings.AddOrUpdate(settings);
                entities.SaveChanges();
                MessageBox.Show("TCP Settings Updated", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ChangeTcpSettings_Load(object sender, EventArgs e)
        {
            MarhabaEntities entities = new MarhabaEntities();
            var settings = entities.tcp_settings.FirstOrDefault();
            txtIP.Text = settings.IPAddress;
            txtPort.Text = settings.Port;
            txtPath.Text = settings.Path;
        }

        public string getIP()
        {
            MarhabaEntities entities = new MarhabaEntities();
            var settings = entities.tcp_settings.FirstOrDefault();
            string ip = settings.IPAddress;
            return ip;
        }

        public void setIP(string ip)
        {
            MarhabaEntities entities = new MarhabaEntities();
            var settings = entities.tcp_settings.FirstOrDefault();
            settings.IPAddress = ip ;
            entities.tcp_settings.AddOrUpdate(settings);
            entities.SaveChanges();
        }

        public int getPort()
        {
            MarhabaEntities entities = new MarhabaEntities();
            var settings = entities.tcp_settings.FirstOrDefault();
            int port = Int32.Parse(settings.Port);
            return port;
        }

        public string getPath()
        {
            MarhabaEntities entities = new MarhabaEntities();
            var settings = entities.tcp_settings.FirstOrDefault();
            string path = settings.Path;
            return path;
        }
    }
}
