namespace CRCCalc
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.grpOption = new System.Windows.Forms.GroupBox();
            this.llbCheckupdate = new System.Windows.Forms.LinkLabel();
            this.lnkMoreOption = new System.Windows.Forms.LinkLabel();
            this.chkReflectedResult = new System.Windows.Forms.CheckBox();
            this.chkCustomInitialValue = new System.Windows.Forms.CheckBox();
            this.chkCustomPolynomial = new System.Windows.Forms.CheckBox();
            this.txtPolynomial = new System.Windows.Forms.TextBox();
            this.txtInitialValue = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbInitialValue = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbPolynomial = new System.Windows.Forms.ComboBox();
            this.epPolynomial = new System.Windows.Forms.ErrorProvider(this.components);
            this.epInitialValue = new System.Windows.Forms.ErrorProvider(this.components);
            this.optString = new System.Windows.Forms.RadioButton();
            this.optHex = new System.Windows.Forms.RadioButton();
            this.epInput = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.llbFormatInfo = new System.Windows.Forms.LinkLabel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.toolTipMain = new System.Windows.Forms.ToolTip(this.components);
            this.grpOption.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epPolynomial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epInitialValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epInput)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.Location = new System.Drawing.Point(15, 24);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(384, 24);
            this.txtInput.TabIndex = 0;
            this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // txtResult
            // 
            this.txtResult.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.Location = new System.Drawing.Point(15, 24);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(256, 24);
            this.txtResult.TabIndex = 3;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(278, 24);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(121, 24);
            this.btnCalc.TabIndex = 5;
            this.btnCalc.Text = "Calc";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // grpOption
            // 
            this.grpOption.Controls.Add(this.llbCheckupdate);
            this.grpOption.Controls.Add(this.lnkMoreOption);
            this.grpOption.Controls.Add(this.chkReflectedResult);
            this.grpOption.Controls.Add(this.chkCustomInitialValue);
            this.grpOption.Controls.Add(this.chkCustomPolynomial);
            this.grpOption.Controls.Add(this.txtPolynomial);
            this.grpOption.Controls.Add(this.txtInitialValue);
            this.grpOption.Controls.Add(this.label6);
            this.grpOption.Controls.Add(this.cmbInitialValue);
            this.grpOption.Controls.Add(this.label4);
            this.grpOption.Controls.Add(this.cmbPolynomial);
            this.grpOption.Location = new System.Drawing.Point(12, 172);
            this.grpOption.Name = "grpOption";
            this.grpOption.Size = new System.Drawing.Size(425, 190);
            this.grpOption.TabIndex = 6;
            this.grpOption.TabStop = false;
            this.grpOption.Text = "Options";
            // 
            // llbCheckupdate
            // 
            this.llbCheckupdate.AutoSize = true;
            this.llbCheckupdate.Location = new System.Drawing.Point(331, 170);
            this.llbCheckupdate.Name = "llbCheckupdate";
            this.llbCheckupdate.Size = new System.Drawing.Size(89, 13);
            this.llbCheckupdate.TabIndex = 16;
            this.llbCheckupdate.TabStop = true;
            this.llbCheckupdate.Text = "Check for update";
            this.llbCheckupdate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbCheckupdate_LinkClicked);
            // 
            // lnkMoreOption
            // 
            this.lnkMoreOption.BackColor = System.Drawing.Color.Transparent;
            this.lnkMoreOption.Location = new System.Drawing.Point(308, 7);
            this.lnkMoreOption.Name = "lnkMoreOption";
            this.lnkMoreOption.Size = new System.Drawing.Size(118, 23);
            this.lnkMoreOption.TabIndex = 15;
            this.lnkMoreOption.TabStop = true;
            this.lnkMoreOption.Text = "hide options..";
            this.lnkMoreOption.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lnkMoreOption.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkMoreOption_LinkClicked);
            // 
            // chkReflectedResult
            // 
            this.chkReflectedResult.AutoSize = true;
            this.chkReflectedResult.Location = new System.Drawing.Point(118, 162);
            this.chkReflectedResult.Name = "chkReflectedResult";
            this.chkReflectedResult.Size = new System.Drawing.Size(105, 17);
            this.chkReflectedResult.TabIndex = 14;
            this.chkReflectedResult.Text = "Reflected Result";
            this.chkReflectedResult.UseVisualStyleBackColor = true;
            this.chkReflectedResult.CheckedChanged += new System.EventHandler(this.chkReflectedResult_CheckedChanged);
            // 
            // chkCustomInitialValue
            // 
            this.chkCustomInitialValue.AutoSize = true;
            this.chkCustomInitialValue.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkCustomInitialValue.Location = new System.Drawing.Point(47, 128);
            this.chkCustomInitialValue.Name = "chkCustomInitialValue";
            this.chkCustomInitialValue.Size = new System.Drawing.Size(61, 17);
            this.chkCustomInitialValue.TabIndex = 13;
            this.chkCustomInitialValue.Text = "Custom";
            this.chkCustomInitialValue.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chkCustomInitialValue.UseVisualStyleBackColor = true;
            this.chkCustomInitialValue.CheckedChanged += new System.EventHandler(this.chkCustomInitialValue_CheckedChanged);
            // 
            // chkCustomPolynomial
            // 
            this.chkCustomPolynomial.AutoSize = true;
            this.chkCustomPolynomial.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkCustomPolynomial.Location = new System.Drawing.Point(47, 59);
            this.chkCustomPolynomial.Name = "chkCustomPolynomial";
            this.chkCustomPolynomial.Size = new System.Drawing.Size(61, 17);
            this.chkCustomPolynomial.TabIndex = 12;
            this.chkCustomPolynomial.Text = "Custom";
            this.chkCustomPolynomial.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chkCustomPolynomial.UseVisualStyleBackColor = true;
            this.chkCustomPolynomial.CheckedChanged += new System.EventHandler(this.chkCustomPolynomial_CheckedChanged);
            // 
            // txtPolynomial
            // 
            this.txtPolynomial.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPolynomial.Location = new System.Drawing.Point(118, 60);
            this.txtPolynomial.Name = "txtPolynomial";
            this.txtPolynomial.ReadOnly = true;
            this.txtPolynomial.Size = new System.Drawing.Size(179, 22);
            this.txtPolynomial.TabIndex = 11;
            this.txtPolynomial.TextChanged += new System.EventHandler(this.txtPolynomial_TextChanged);
            // 
            // txtInitialValue
            // 
            this.txtInitialValue.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInitialValue.Location = new System.Drawing.Point(118, 125);
            this.txtInitialValue.Name = "txtInitialValue";
            this.txtInitialValue.ReadOnly = true;
            this.txtInitialValue.Size = new System.Drawing.Size(179, 22);
            this.txtInitialValue.TabIndex = 10;
            this.txtInitialValue.TextChanged += new System.EventHandler(this.txtInitialValue_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Initial Value";
            // 
            // cmbInitialValue
            // 
            this.cmbInitialValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInitialValue.FormattingEnabled = true;
            this.cmbInitialValue.Location = new System.Drawing.Point(118, 98);
            this.cmbInitialValue.Name = "cmbInitialValue";
            this.cmbInitialValue.Size = new System.Drawing.Size(179, 21);
            this.cmbInitialValue.TabIndex = 7;
            this.cmbInitialValue.SelectedIndexChanged += new System.EventHandler(this.cmbInitialValue_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Polynomial";
            // 
            // cmbPolynomial
            // 
            this.cmbPolynomial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPolynomial.FormattingEnabled = true;
            this.cmbPolynomial.Location = new System.Drawing.Point(118, 33);
            this.cmbPolynomial.Name = "cmbPolynomial";
            this.cmbPolynomial.Size = new System.Drawing.Size(179, 21);
            this.cmbPolynomial.TabIndex = 0;
            this.cmbPolynomial.SelectedIndexChanged += new System.EventHandler(this.cmbPolynomial_SelectedIndexChanged);
            // 
            // epPolynomial
            // 
            this.epPolynomial.ContainerControl = this;
            this.epPolynomial.Icon = ((System.Drawing.Icon)(resources.GetObject("epPolynomial.Icon")));
            // 
            // epInitialValue
            // 
            this.epInitialValue.ContainerControl = this;
            this.epInitialValue.Icon = ((System.Drawing.Icon)(resources.GetObject("epInitialValue.Icon")));
            // 
            // optString
            // 
            this.optString.AutoSize = true;
            this.optString.Location = new System.Drawing.Point(297, 54);
            this.optString.Name = "optString";
            this.optString.Size = new System.Drawing.Size(52, 17);
            this.optString.TabIndex = 7;
            this.optString.Text = "String";
            this.optString.UseVisualStyleBackColor = true;
            // 
            // optHex
            // 
            this.optHex.AutoSize = true;
            this.optHex.Checked = true;
            this.optHex.Location = new System.Drawing.Point(355, 54);
            this.optHex.Name = "optHex";
            this.optHex.Size = new System.Drawing.Size(44, 17);
            this.optHex.TabIndex = 8;
            this.optHex.TabStop = true;
            this.optHex.Text = "Hex";
            this.optHex.UseVisualStyleBackColor = true;
            this.optHex.CheckedChanged += new System.EventHandler(this.optHex_CheckedChanged);
            // 
            // epInput
            // 
            this.epInput.ContainerControl = this;
            this.epInput.Icon = ((System.Drawing.Icon)(resources.GetObject("epInput.Icon")));
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.llbFormatInfo);
            this.groupBox2.Controls.Add(this.txtInput);
            this.groupBox2.Controls.Add(this.optHex);
            this.groupBox2.Controls.Add(this.optString);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(425, 84);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Input";
            // 
            // llbFormatInfo
            // 
            this.llbFormatInfo.AutoSize = true;
            this.llbFormatInfo.Location = new System.Drawing.Point(12, 56);
            this.llbFormatInfo.Name = "llbFormatInfo";
            this.llbFormatInfo.Size = new System.Drawing.Size(64, 13);
            this.llbFormatInfo.TabIndex = 9;
            this.llbFormatInfo.TabStop = true;
            this.llbFormatInfo.Text = "Hex format?";
            this.llbFormatInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbFormatInfo_LinkClicked);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnCalc);
            this.groupBox3.Controls.Add(this.txtResult);
            this.groupBox3.Location = new System.Drawing.Point(12, 102);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(425, 64);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Result";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 373);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grpOption);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "CRC Calculator";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.grpOption.ResumeLayout(false);
            this.grpOption.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epPolynomial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epInitialValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epInput)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.GroupBox grpOption;
        private System.Windows.Forms.ComboBox cmbPolynomial;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbInitialValue;
        private System.Windows.Forms.TextBox txtPolynomial;
        private System.Windows.Forms.TextBox txtInitialValue;
        private System.Windows.Forms.CheckBox chkCustomInitialValue;
        private System.Windows.Forms.CheckBox chkCustomPolynomial;
        private System.Windows.Forms.ErrorProvider epPolynomial;
        private System.Windows.Forms.ErrorProvider epInitialValue;
        private System.Windows.Forms.CheckBox chkReflectedResult;
        private System.Windows.Forms.RadioButton optHex;
        private System.Windows.Forms.RadioButton optString;
        private System.Windows.Forms.ErrorProvider epInput;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.LinkLabel lnkMoreOption;
        private System.Windows.Forms.LinkLabel llbFormatInfo;
        private System.Windows.Forms.ToolTip toolTipMain;
        private System.Windows.Forms.LinkLabel llbCheckupdate;
    }
}

