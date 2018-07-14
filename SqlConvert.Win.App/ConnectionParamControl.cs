using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SqlConvert.Domain;
using SqlConvert.Domain.Connections;
using SqlConvert.InfraSql.Connections;

namespace SqlConvert.Win.App
{
    public partial class ConnectionParamControl : UserControl
    {
        public ConnectionParamControl()
        {
            InitializeComponent();
        }

        public string Server { get { return textBoxServer.Text; } set { textBoxServer.Text = value; } }
        public string User { get { return textBoxUser.Text; } set { textBoxUser.Text = value; } }
        public string Password { get { return textBoxPassword.Text; } set { textBoxPassword.Text = value; } }
        public string Database { get { return textBoxDatabase.Text; } set { textBoxDatabase.Text = value; } }

        public int Port
        {
            get
            {
                if (string.IsNullOrEmpty(maskedTextBoxPort.Text))
                    return 0;
                else
                    return Convert.ToInt32(maskedTextBoxPort.Text);
            }
            set { maskedTextBoxPort.Text = value.ToString(); }
        }

        public ServerType ServerType { get; set; }

        private ConnectionParam _connParam;

        public ConnectionParam ConnectionParam
        {
            get
            {
                if (_connParam == null)
                    _connParam = new ConnectionParam();
                _connParam.ServerType = this.ServerType;
                _connParam.Database = this.Database;
                _connParam.User = this.User;
                _connParam.Password = this.Password;
                _connParam.Port = this.Port;
                _connParam.Server = this.Server;
                return _connParam;
            }
            set { _connParam = value; }
        }


        private void buttonTest_Click(object sender, EventArgs e)
        {
            try
            {

                ConnectionParam.Database = this.Database;
                ConnectionParam.User = this.User;
                ConnectionParam.Password = this.Password;
                ConnectionParam.Server = this.Server;

                IConnection conn = new Connection();
                conn.Connect(ConnectionParam);
                if (conn.Connected)
                    pictureBox1.Image = Properties.Resources.success;
                else
                    pictureBox1.Image = Properties.Resources.error;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
