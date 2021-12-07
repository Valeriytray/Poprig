using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gaaaa
{
    public partial class Form1 : Form
    {
        Model1 db = new Model1();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            agentBindingSource.DataSource = db.Agent.ToList();
            agentTypeBindingSource.DataSource = db.AgentType.ToList();
        }

        private void agentDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                agentBindingSource.DataSource = db.Agent.OrderByDescending(ag => ag.Priority).ToList();
            }
            else
            {
                agentBindingSource.DataSource = db.Agent.OrderBy(ag => ag.Priority).ToList();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            agentBindingSource.DataSource = db.Agent.OrderBy(ag => ag.AgentTypeID).ToList();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue == null) return;
            int n = (int)comboBox1.SelectedValue;
            agentBindingSource.DataSource = db.Agent.Where(x => x.AgentTypeID == n).ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            agentBindingSource.DataSource = null;
            agentBindingSource.DataSource = db.Agent.ToList<Agent>();
        }

        private void agentDataGridView_CurrentCellChanged(object sender, EventArgs e)
        {

        }

        private void agentBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            //Agent agent = (Agent)agentBindingSource.Current;
            //try
            //{
            //    if (agent == null) return;
            //    if (agent.Logo != "")
            //    {
            //        string str = agent.Logo.Substring(1);
            //        LogoPict.Image = Image.FromFile(str);
            //    }
            //    else
            //    {
            //        LogoPict.Image = Image.FromFile("agents\\picture.png");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Agent agent = (Agent)agentBindingSource.Current;
            Form2 frm = new Form2();
            frm.db = db;
            frm.agent = null;
            DialogResult dr = frm.ShowDialog(); ;
            if (dr == DialogResult.OK)
            {
                agentBindingSource.DataSource = null;
                agentBindingSource.DataSource = db.Agent.ToList();
            }
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.InnerException.Message);
            }
        }

        private void delButton_Click(object sender, EventArgs e)
        {
            Agent ag = (Agent)agentBindingSource.Current;
            DialogResult dr = MessageBox.Show("Вы действтиельно хотите удалить водителя - " +
                ag.Title.ToString() + "?", "Удаление водителя",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                db.Agent.Remove(ag);
                try
                {
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            agentBindingSource.DataSource = db.Agent.ToList();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            Agent agent = (Agent)agentBindingSource.Current;
            Form2 frm = new Form2();
            frm.db = db;
            frm.agent = agent;
            DialogResult dr = frm.ShowDialog(); ;
            if (dr == DialogResult.OK)
            {
                agentBindingSource.DataSource = null;
                agentBindingSource.DataSource = db.Agent.ToList();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
