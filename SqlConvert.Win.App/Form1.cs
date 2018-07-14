using SqlConvert.Domain;
using SqlConvert.Domain.Structs;
using SqlConvert.InfraSql.Connections;
using SqlConvert.InfraSql.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SqlConvert.Win.App
{
    public partial class FormMainForm : Form
    {
        public FormMainForm()
        {
            InitializeComponent();

            InitializeControls();
        }

        private void InitializeControls()
        {
            tabControl1.SelectedIndexChanged += TabControl1_SelectedIndexChanged;
            comboBox1.DataSource = Enum.GetValues(typeof(ServerType));
            comboBox2.DataSource = Enum.GetValues(typeof(ServerType));
            dataGridViewTables.SelectionChanged += DataGridViewTables_SelectionChanged;
        }

        private void DataGridViewTables_SelectionChanged(object sender, EventArgs e)
        {
            var index = dataGridViewTables.CurrentCell.RowIndex;
            if (index < 0)
                return;
            var table = dataGridViewTables.Rows[index].DataBoundItem as Table;
            if (table != null)
                dataGridViewColumns.DataSource = table.Columns;
        }

        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        TabPage PreviousTab { get; set; }

        void Next()
        {
            PreviousTab = tabControl1.SelectedTab;

            ValidSourceSelection();
            ServerType serverTypeSource = ServerType.MSSqlServer;
            if (tabControl1.SelectedTab == tabPageSource)
                tabControl1.SelectedTab = tabPageDestination;


            else if (tabControl1.SelectedTab == tabPageDestination)
            {
                serverTypeSource = (ServerType)comboBox1.SelectedItem;
                if (serverTypeSource == ServerType.MSSqlServer)
                    tabControl1.SelectedTab = tabPageSqlServer;
                else if (serverTypeSource == ServerType.PostGres)
                    tabControl1.SelectedTab = tabPagePostgres;
            }
            else if (tabControl1.SelectedTab == tabPageSqlServer)
            {
                serverTypeSource = (ServerType)comboBox2.SelectedItem;
                if (serverTypeSource == ServerType.MSSqlServer)
                    tabControl1.SelectedTab = tabPageSqlServer;
                else if (serverTypeSource == ServerType.PostGres)
                    tabControl1.SelectedTab = tabPagePostgres;
            }
            else
            {
                tabControl1.SelectedTab = tabPageSummary;
            }
        }

        private void ValidSourceSelection()
        {
            if (tabControl1.SelectedTab == tabPageSource && comboBox1.SelectedItem == null)
                throw new Exception("Select a database source");

            else if (tabControl1.SelectedTab == tabPageDestination && comboBox2.SelectedItem == null)
                throw new Exception("Select a database destination");
            if (tabControl1.SelectedTab == tabPageDestination && comboBox1.SelectedItem.Equals(comboBox2.SelectedItem))
                throw new Exception("Source and destino can't be same");
        }

        void Previous()
        {
            if (PreviousTab == null) return;

            tabControl1.SelectedTab = PreviousTab;
            var index = tabControl1.TabPages.IndexOf(PreviousTab);
            if (index > 0)
                PreviousTab = tabControl1.TabPages[index - 1];
            else
                PreviousTab = tabControl1.TabPages[index];
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            try
            {
                Next();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonNext1_Click(object sender, EventArgs e)
        {
            try
            {
                Next();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonNext2_Click(object sender, EventArgs e)
        {
            try
            {
                Next();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonNext3_Click(object sender, EventArgs e)
        {
            try
            {
                Next();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonPrev1_Click(object sender, EventArgs e)
        {
            try
            {
                Previous();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonPrev2_Click(object sender, EventArgs e)
        {
            try
            {
                Previous();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonPrev3_Click(object sender, EventArgs e)
        {
            try
            {
                Previous();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonPrev4_Click(object sender, EventArgs e)
        {
            try
            {
                Previous();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void buttonFinish_Click(object sender, EventArgs e)
        {
            try
            {
                var conn = new Connection();
                if ((ServerType)comboBox1.SelectedItem == ServerType.MSSqlServer)
                    conn.Connect(connectionParamControlMsSql.ConnectionParam);
                else
                    conn.Connect(connectionParamControlPostgre.ConnectionParam);

                ITableRepository tableRepository = new TableRepository(conn);

                dataGridViewTables.DataSource = tableRepository.GetTables();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
