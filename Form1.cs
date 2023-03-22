using ExampleProgramForDBConn.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExampleProgramForDBConn
{
    public partial class Form1 : Form
    {

        dbEntities db = new dbEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ExempluTabel exempluTabel = new ExempluTabel();
            exempluTabel.ceva = "info1";
            exempluTabel.altceva = "alta info 2";

            db.ExempluTabels.Add(exempluTabel);

            exempluTabel.ceva = "Gigel";
            exempluTabel.altceva = "Cornel";

            db.ExempluTabels.Add(exempluTabel);
            db.SaveChanges();

            dataGridView1.DataSource = db.ExempluTabels.ToList();
        }
    }
}
