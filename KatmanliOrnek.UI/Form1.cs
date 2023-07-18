using KatmanliOrnek.BLL.Abstract.IServices;
using KatmanliOrnek.Models.VMs.UserVMs;
using KatmanliOrnek.UI.Forms;
using KatmanliOrnek.UI.LoginUser;

namespace KatmanliOrnek.UI
{
    public partial class Form1 : Form
    {
        private readonly IAdminService _service;

        public Form1(IAdminService adminService)
        {
            InitializeComponent();
            _service = adminService;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           var login = _service.Login(txtUserName.Text, txtPassword.Text);

            if (login == null )
            {
                MessageBox.Show("Bilgilerinizi kontrol edin");
                return;
            }

            bool isAdmin = login.Data.Role == Core.Enums.Role.Admin;

            ActiveUser.Role = login.Data.Role;
            ActiveUser.ActiveUserName = login.Data.UserName;

            if (isAdmin)
            {
                Form mainForm = EfContextForm.EfContextForm.ConfigureService<MainForm>();
                this.Hide();
                mainForm.ShowDialog();
                this.Close();
            }

           
        }
    }
}