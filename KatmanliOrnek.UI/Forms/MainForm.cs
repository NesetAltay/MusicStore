using KatmanliOrnek.BLL.Abstract.IServices;
using KatmanliOrnek.UI.LoginUser;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KatmanliOrnek.UI.Forms
{
    public partial class MainForm : Form
    {
        private readonly IPlakService _service;

        public MainForm(IPlakService plakService)
        {
            InitializeComponent();
            _service = plakService;
        }


        private void ListedFill()
        {
            dgvPlakDetail.DataSource = _service.GetAll().Data;
            dgvDiscontinued.DataSource = _service.DiscontinuedPlakList(true).Data;
            dgvContinued.DataSource = _service.DiscontinuedPlakList(false).Data;
            dgvLastTen.DataSource = _service.LastTenAddedPlak().Data;
            dgvDiscounted.DataSource = _service.DiscountedPlakList().Data;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show(ActiveUser.ActiveUserName, ActiveUser.Role.ToString());
            ListedFill();
        }
    }
}
