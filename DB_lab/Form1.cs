using DataBaseConnection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_lab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ModelsOfModules model = new ModelsOfModules();
            model.ModelName = ModelTextBox.Text;
            model.ModelRadius = RadiusTextBox.Text;

            AccomondationDBContext context = new AccomondationDBContext();
            context.Models.Add(model);
            context.SaveChanges();
        }
    }
}
