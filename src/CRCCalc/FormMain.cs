using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRCCalc
{
    public partial class FormMain : Form
    {
        CRC16 crc16 = new CRC16(ECrcInitialValue.Zeros, ECrcPolynomial.CRC16_IBM, false);

        public FormMain()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtInput.Text))
            {
                MessageBox.Show("Please Enter Input!");
                return;
            }

            byte[] data;
            if (optHex.Checked)
            {
                data = txtInput.Text.ParseHexToBytes();
            }
            else
            {
                data = txtInput.Text.ParseStringToBytes();
            }

            if (data == null || data.Length <= 0)
            {
                MessageBox.Show("Invalid Input!");
                return;
            }

            ushort result = crc16.GetChecksum(data);
            txtResult.Text = string.Format("0x{0:X4}", result);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            cmbPolynomial.DataSource = System.Enum.GetValues(typeof(ECrcPolynomial));
            cmbPolynomial.Text = "CRC16_IBM";

            cmbInitialValue.DataSource = System.Enum.GetValues(typeof(ECrcInitialValue));
            cmbInitialValue.Text = "Zeros";

            lnkMoreOption_LinkClicked(null, null);
        }

        private void cmbPolynomial_SelectedIndexChanged(object sender, EventArgs e)
        {
            crc16.CrcPolynomial = (ECrcPolynomial)Enum.Parse(typeof(ECrcPolynomial), cmbPolynomial.SelectedValue.ToString());
            txtPolynomial.Text = string.Format("0x{0:X4}", (ushort)crc16.CrcPolynomial);
        }

        private void cmbInitialValue_SelectedIndexChanged(object sender, EventArgs e)
        {
            crc16.CrcInitialValue = (ECrcInitialValue)Enum.Parse(typeof(ECrcInitialValue), cmbInitialValue.SelectedValue.ToString());
            txtInitialValue.Text = string.Format("0x{0:X4}", (ushort)crc16.CrcInitialValue);
        }

        private void chkCustomPolynomial_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCustomPolynomial.Checked)
            {
                txtPolynomial.ReadOnly = false;
                cmbPolynomial.Enabled = false;
            }
            else
            {
                txtPolynomial.ReadOnly = true;
                cmbPolynomial.Enabled = true;
            }
        }

        private void chkCustomInitialValue_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCustomInitialValue.Checked)
            {
                txtInitialValue.ReadOnly = false;
                cmbInitialValue.Enabled = false;
            }
            else
            {
                txtInitialValue.ReadOnly = true;
                cmbInitialValue.Enabled = true;
            }
        }

        private void txtPolynomial_TextChanged(object sender, EventArgs e)
        {
            if (!HexUtils.IsHex16Bit(txtPolynomial.Text))
            {
                epPolynomial.SetError(txtPolynomial, "Invalid!");
            }
            else
            {
                epPolynomial.Clear();
            }
        }

        private void txtInitialValue_TextChanged(object sender, EventArgs e)
        {
            if (!HexUtils.IsHex16Bit(txtInitialValue.Text))
            {
                epInitialValue.SetError(txtInitialValue, "Invalid!");
            }
            else
            {
                epInitialValue.Clear();
            }
        }
        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            if (optHex.Checked && !HexUtils.IsHex(txtInput.Text))
            {
                epInput.SetError(txtInput, "Invalid!");
            }
            else
            {
                epInput.Clear();
            }
        }

        private void chkReflectedResult_CheckedChanged(object sender, EventArgs e)
        {
            crc16.Reflected = chkReflectedResult.Checked;
        }

        private void optHex_CheckedChanged(object sender, EventArgs e)
        {
            lblHexFormat.Visible = optHex.Checked;
            txtInput_TextChanged(null, null);
        }

        private void lnkMoreOption_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (lnkMoreOption.Text.StartsWith("show"))
            {
                lnkMoreOption.Text = lnkMoreOption.Text.Replace("show", "hide");
                grpOption.Height += 165;
                this.Height += 165;
            }
            else
            {
                lnkMoreOption.Text = lnkMoreOption.Text.Replace("hide", "show");
                grpOption.Height -= 165;
                this.Height -= 165;
            }
        }

    }
}
