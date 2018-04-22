using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Servise;

namespace RepairService.UI
{
    public partial class FaultsForm : Form
    {
        public FaultType ft { get; set; }

        public FaultsForm(FaultType ft)
        {
            this.ft = ft;
            InitializeComponent();
        }

        private void FaultsForm_Load(object sender, EventArgs e)
        {
            DescriptionBox.Text = ft.Description;
            CoefficientBox.Text = ft.Coefficient;
        }
        private void ButtonOk_Click(object sender, EventArgs e)
        {
            ft.Description = DescriptionBox.Text;
            ft.Coefficient = CoefficientBox.Text;
            ft.Cost = Convert.ToDecimal(ft.Coefficient) * 500;
        }

    }
}
