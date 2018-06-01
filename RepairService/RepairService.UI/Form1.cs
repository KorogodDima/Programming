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
    
    public partial class Form1 : Form
    {
        public RepairRequest rr = new RepairRequest();
        public Form1()
        {
            
            InitializeComponent();

        }
        private void radioButtons_CheckedChanged(object sender, EventArgs e)
        {
            if (ButtonSmartphone.Checked)
            {
                rr.Type = DeviceType.Smartphone;
            }
            else if (ButtonTablet.Checked)
            {
                rr.Type = DeviceType.Tablet;
            }
            else if (ButtonLaptop.Checked)
            {
                rr.Type = DeviceType.Laptop;
            }
            else if (ButtonPC.Checked)
            {
                rr.Type = DeviceType.PC;
            }
        }

        RepairRequest GetModelFromUI()
        {
            return new RepairRequest()
            {
                Filled = Date.Value,
                FullName = CustomerName.Text,
                Model = ModelName.Text,
                Type = rr.Type,
                Faults = ListOfFaults.Items.OfType<FaultType>().ToList(),
                Price = PriceBox.Value,
            };
        }

        private void SetModelToUI(RepairRequest rep)
        {
            ButtonDelete.Enabled = false;
            Date.Value = rep.Filled;
            CustomerName.Text = rep.FullName;
            ModelName.Text = rep.Model;
            switch (rep.Type)
            {
                case DeviceType.Smartphone:
                    ButtonSmartphone.Checked = true;
                    break;
                case DeviceType.Tablet:
                    ButtonTablet.Checked = true;
                    break;
                case DeviceType.Laptop:
                    ButtonLaptop.Checked = true;
                    break;
                case DeviceType.PC:
                    ButtonPC.Checked = true;
                    break;
            }
            ListOfFaults.Items.Clear();
            foreach (var e in rep.Faults)
            {
                ListOfFaults.Items.Add(e);
            }
            PriceBox.Value = rep.Price;
        }

        private void ListOfFaults_SelectedIndexChanged(object sender, EventArgs e)
        {
            var ft = ListOfFaults.SelectedItem as FaultType;
            if (ft == null)
                return;
            var form = new FaultsForm(ft.Clone());
            var res = form.ShowDialog(this);
            if (res == DialogResult.OK)
            {
                var si = ListOfFaults.SelectedIndex;
                ListOfFaults.Items.RemoveAt(si);
                ListOfFaults.Items.Insert(si, form.ft);
            }
        }

        private void ListOfFaults_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ButtonDelete.Enabled = true;
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            var form = new FaultsForm(new FaultType());
            var res = form.ShowDialog(this);
            if (res == DialogResult.OK)
            {
                ListOfFaults.Items.Add(form.ft);
                RecalculatePrice();
            }
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            var si = ListOfFaults.SelectedIndex;
            ListOfFaults.Items.RemoveAt(si);
            RecalculatePrice();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog() { Filter = "Файлы заказов|*.repserv" };
            var result = sfd.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                var rep = GetModelFromUI();
                RequestHelper.WriteToFile(sfd.FileName, rep);
            }
        }

        private void ButtonOpen_Click_1(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog() { Filter = "Файл заказа|*.repserv" };
            var result = ofd.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                var rep = RequestHelper.LoadFromFile(ofd.FileName);
                SetModelToUI(rep);
            }
        }
        private void RecalculatePrice()
        {
            var rr = GetModelFromUI();
            decimal price = 200;
            foreach (var e in rr.Faults)
            {
                double cf = Convert.ToDouble(e.Coefficient);
                price += (decimal)(500 * cf);
            }

            PriceBox.Value = price;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var lv = new LicenceValidator();
            if (!lv.HasLicense)
            {
                MessageBox.Show("Лицензия не найдена. Купите её за 2 рубля где-нибудь.");
                Application.Exit();
            }
            if (!lv.IsValid)
            {
                MessageBox.Show("Лицензия просрочена. Купите её за 2 рубля где-нибудь.");
                Application.Exit();
            }
        }
    }
}
