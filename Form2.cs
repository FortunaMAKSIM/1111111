using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestApp.Data;

namespace TestApp
{
    public partial class Form2 : Form
    {
        private readonly MyDbContext _dbContext;
        public Form2(MyDbContext dbContext)
        {
            InitializeComponent();
            _dbContext = dbContext;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
