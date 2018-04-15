﻿using System;
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
        public Form1()
        {
            InitializeComponent();
        }

        RepairRequest GetModelFromUI()
        {
            return new RepairRequest()
            {
                Filled = Date.Value,
                Faults = ListOfFaults.Items.OfType<FaultType>().ToList(),
                
            };
        }

        private void SetModelToUI(RepairRequest rep)
        {
            ButtonDelete.Enabled = false;
            Date.Value = rep.Filled;
            ListOfFaults.Items.Clear();
            foreach (var e in rep.Faults)
            {
                ListOfFaults.Items.Add(e);
            }       
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
            }
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            var si = ListOfFaults.SelectedIndex;
            ListOfFaults.Items.RemoveAt(si);
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
    }
}