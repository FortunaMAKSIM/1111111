using Microsoft.EntityFrameworkCore;
using TestApp.Data;

namespace TestApp
{
    public partial class Form1 : Form
    {
        private readonly MyDbContext _dbContext;
        public Form1(MyDbContext dbContext)
        {
            InitializeComponent();
            _dbContext = dbContext;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = LogTb.Text;
            string password = PassTb.Text;
            

            var user = _dbContext.Main.FirstOrDefault(s => s.Login == username && s.Password == password);
            

            if (user != null)
            {
                string role = user.Role;
                if (role == "Adm")
                {
                    Form2 form2 = new Form2(_dbContext);
                    form2.Show();
                    this.Hide();
                }
                else if(role == "User")
                {
                    Form3 form3 = new Form3(_dbContext);
                    form3.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Неправельный логин или пароль!", "Ошибка", MessageBoxButtons.OK);
            }
        }
    }
}
