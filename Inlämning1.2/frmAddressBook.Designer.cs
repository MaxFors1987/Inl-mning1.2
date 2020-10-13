namespace Inlämning1._2
{
    partial class frmAddressBook
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
            this.listViewList = new System.Windows.Forms.ListView();
            this.Namn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Adress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Postnummer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ort = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Telefonnummer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Mail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cboxTypeSearch = new System.Windows.Forms.ComboBox();
            this.txtSearchBox = new System.Windows.Forms.TextBox();
            this.BtSearch = new System.Windows.Forms.Button();
            this.txtBoxFullName = new System.Windows.Forms.TextBox();
            this.txtBoxAddress = new System.Windows.Forms.TextBox();
            this.txtBoxPostalNumber = new System.Windows.Forms.TextBox();
            this.txtBoxCity = new System.Windows.Forms.TextBox();
            this.txtBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtBoxMail = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAdress = new System.Windows.Forms.Label();
            this.lblPostalNumber = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.BtSave = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.BtRemove = new System.Windows.Forms.Button();
            this.BtClearFields = new System.Windows.Forms.Button();
            this.BtShowAll = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listViewList
            // 
            this.listViewList.BackColor = System.Drawing.SystemColors.Window;
            this.listViewList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Namn,
            this.Adress,
            this.Postnummer,
            this.Ort,
            this.Telefonnummer,
            this.Mail});
            this.listViewList.GridLines = true;
            this.listViewList.HideSelection = false;
            this.listViewList.Location = new System.Drawing.Point(12, 284);
            this.listViewList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listViewList.Name = "listViewList";
            this.listViewList.Size = new System.Drawing.Size(1033, 224);
            this.listViewList.TabIndex = 0;
            this.listViewList.UseCompatibleStateImageBehavior = false;
            this.listViewList.View = System.Windows.Forms.View.Details;
            this.listViewList.SelectedIndexChanged += new System.EventHandler(this.ViewSelectedItemsTextBox);
            // 
            // Namn
            // 
            this.Namn.Text = "Namn";
            this.Namn.Width = 121;
            // 
            // Adress
            // 
            this.Adress.Text = "Adress";
            this.Adress.Width = 106;
            // 
            // Postnummer
            // 
            this.Postnummer.Text = "Postnummer";
            this.Postnummer.Width = 129;
            // 
            // Ort
            // 
            this.Ort.Text = "Ort";
            this.Ort.Width = 105;
            // 
            // Telefonnummer
            // 
            this.Telefonnummer.Text = "Telefonnummer";
            this.Telefonnummer.Width = 125;
            // 
            // Mail
            // 
            this.Mail.Text = "Mail";
            this.Mail.Width = 138;
            // 
            // cboxTypeSearch
            // 
            this.cboxTypeSearch.FormattingEnabled = true;
            this.cboxTypeSearch.Location = new System.Drawing.Point(13, 254);
            this.cboxTypeSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboxTypeSearch.Name = "cboxTypeSearch";
            this.cboxTypeSearch.Size = new System.Drawing.Size(183, 24);
            this.cboxTypeSearch.TabIndex = 1;
            // 
            // txtSearchBox
            // 
            this.txtSearchBox.Location = new System.Drawing.Point(219, 254);
            this.txtSearchBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearchBox.Multiline = true;
            this.txtSearchBox.Name = "txtSearchBox";
            this.txtSearchBox.Size = new System.Drawing.Size(316, 25);
            this.txtSearchBox.TabIndex = 2;
            // 
            // BtSearch
            // 
            this.BtSearch.Location = new System.Drawing.Point(549, 254);
            this.BtSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtSearch.Name = "BtSearch";
            this.BtSearch.Size = new System.Drawing.Size(75, 25);
            this.BtSearch.TabIndex = 3;
            this.BtSearch.Text = "Search";
            this.BtSearch.UseVisualStyleBackColor = true;
            this.BtSearch.Click += new System.EventHandler(this.BtSearch_Click);
            // 
            // txtBoxFullName
            // 
            this.txtBoxFullName.Location = new System.Drawing.Point(13, 34);
            this.txtBoxFullName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxFullName.Name = "txtBoxFullName";
            this.txtBoxFullName.Size = new System.Drawing.Size(251, 22);
            this.txtBoxFullName.TabIndex = 4;
            // 
            // txtBoxAddress
            // 
            this.txtBoxAddress.Location = new System.Drawing.Point(13, 63);
            this.txtBoxAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxAddress.Name = "txtBoxAddress";
            this.txtBoxAddress.Size = new System.Drawing.Size(251, 22);
            this.txtBoxAddress.TabIndex = 6;
            // 
            // txtBoxPostalNumber
            // 
            this.txtBoxPostalNumber.Location = new System.Drawing.Point(13, 91);
            this.txtBoxPostalNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxPostalNumber.Name = "txtBoxPostalNumber";
            this.txtBoxPostalNumber.Size = new System.Drawing.Size(251, 22);
            this.txtBoxPostalNumber.TabIndex = 7;
            // 
            // txtBoxCity
            // 
            this.txtBoxCity.Location = new System.Drawing.Point(13, 119);
            this.txtBoxCity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxCity.Name = "txtBoxCity";
            this.txtBoxCity.Size = new System.Drawing.Size(251, 22);
            this.txtBoxCity.TabIndex = 8;
            // 
            // txtBoxPhoneNumber
            // 
            this.txtBoxPhoneNumber.Location = new System.Drawing.Point(13, 146);
            this.txtBoxPhoneNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxPhoneNumber.Name = "txtBoxPhoneNumber";
            this.txtBoxPhoneNumber.Size = new System.Drawing.Size(251, 22);
            this.txtBoxPhoneNumber.TabIndex = 9;
            // 
            // txtBoxMail
            // 
            this.txtBoxMail.Location = new System.Drawing.Point(13, 175);
            this.txtBoxMail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxMail.Name = "txtBoxMail";
            this.txtBoxMail.Size = new System.Drawing.Size(251, 22);
            this.txtBoxMail.TabIndex = 10;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(291, 39);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 17);
            this.lblName.TabIndex = 12;
            this.lblName.Text = "Namn";
            // 
            // lblAdress
            // 
            this.lblAdress.AutoSize = true;
            this.lblAdress.Location = new System.Drawing.Point(291, 68);
            this.lblAdress.Name = "lblAdress";
            this.lblAdress.Size = new System.Drawing.Size(52, 17);
            this.lblAdress.TabIndex = 13;
            this.lblAdress.Text = "Adress";
            // 
            // lblPostalNumber
            // 
            this.lblPostalNumber.AutoSize = true;
            this.lblPostalNumber.Location = new System.Drawing.Point(291, 96);
            this.lblPostalNumber.Name = "lblPostalNumber";
            this.lblPostalNumber.Size = new System.Drawing.Size(87, 17);
            this.lblPostalNumber.TabIndex = 14;
            this.lblPostalNumber.Text = "Postnummer";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(291, 124);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(28, 17);
            this.lblCity.TabIndex = 15;
            this.lblCity.Text = "Ort";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(291, 153);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(107, 17);
            this.lblPhoneNumber.TabIndex = 16;
            this.lblPhoneNumber.Text = "Telefonnummer";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(291, 180);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(33, 17);
            this.lblMail.TabIndex = 17;
            this.lblMail.Text = "Mail";
            // 
            // BtSave
            // 
            this.BtSave.Location = new System.Drawing.Point(459, 34);
            this.BtSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtSave.Name = "BtSave";
            this.BtSave.Size = new System.Drawing.Size(135, 28);
            this.BtSave.TabIndex = 18;
            this.BtSave.Text = "Save";
            this.BtSave.UseVisualStyleBackColor = true;
            this.BtSave.Click += new System.EventHandler(this.BtSave_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.Location = new System.Drawing.Point(459, 69);
            this.btUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(135, 31);
            this.btUpdate.TabIndex = 19;
            this.btUpdate.Text = "Update Selected";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // BtRemove
            // 
            this.BtRemove.Location = new System.Drawing.Point(459, 106);
            this.BtRemove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtRemove.Name = "BtRemove";
            this.BtRemove.Size = new System.Drawing.Size(135, 34);
            this.BtRemove.TabIndex = 20;
            this.BtRemove.Text = "Remove Selected";
            this.BtRemove.UseVisualStyleBackColor = true;
            this.BtRemove.Click += new System.EventHandler(this.BtRemove_Click);
            // 
            // BtClearFields
            // 
            this.BtClearFields.Location = new System.Drawing.Point(459, 146);
            this.BtClearFields.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtClearFields.Name = "BtClearFields";
            this.BtClearFields.Size = new System.Drawing.Size(135, 32);
            this.BtClearFields.TabIndex = 21;
            this.BtClearFields.Text = "Clear";
            this.BtClearFields.UseVisualStyleBackColor = true;
            this.BtClearFields.Click += new System.EventHandler(this.BtClearFields_Click);
            // 
            // BtShowAll
            // 
            this.BtShowAll.Location = new System.Drawing.Point(459, 185);
            this.BtShowAll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtShowAll.Name = "BtShowAll";
            this.BtShowAll.Size = new System.Drawing.Size(135, 31);
            this.BtShowAll.TabIndex = 22;
            this.BtShowAll.Text = "Show all";
            this.BtShowAll.UseVisualStyleBackColor = true;
            this.BtShowAll.Click += new System.EventHandler(this.BtShowAll_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "Söktyp";
            // 
            // frmAddressBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 519);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtShowAll);
            this.Controls.Add(this.BtClearFields);
            this.Controls.Add(this.BtRemove);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.BtSave);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblPostalNumber);
            this.Controls.Add(this.lblAdress);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtBoxMail);
            this.Controls.Add(this.txtBoxPhoneNumber);
            this.Controls.Add(this.txtBoxCity);
            this.Controls.Add(this.txtBoxPostalNumber);
            this.Controls.Add(this.txtBoxAddress);
            this.Controls.Add(this.txtBoxFullName);
            this.Controls.Add(this.BtSearch);
            this.Controls.Add(this.txtSearchBox);
            this.Controls.Add(this.cboxTypeSearch);
            this.Controls.Add(this.listViewList);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmAddressBook";
            this.Text = "Adressbok";
            this.Load += new System.EventHandler(this.frmAddressBook_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cboxTypeSearch;
        private System.Windows.Forms.Button BtSearch;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAdress;
        private System.Windows.Forms.Label lblPostalNumber;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.ColumnHeader Namn;
        private System.Windows.Forms.ColumnHeader Adress;
        private System.Windows.Forms.ColumnHeader Postnummer;
        private System.Windows.Forms.ColumnHeader Ort;
        private System.Windows.Forms.ColumnHeader Telefonnummer;
        private System.Windows.Forms.ColumnHeader Mail;
        private System.Windows.Forms.Button BtSave;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button BtRemove;
        private System.Windows.Forms.Button BtClearFields;
        private System.Windows.Forms.Button BtShowAll;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ListView listViewList;
        public System.Windows.Forms.TextBox txtSearchBox;
        public System.Windows.Forms.TextBox txtBoxFullName;
        public System.Windows.Forms.TextBox txtBoxAddress;
        public System.Windows.Forms.TextBox txtBoxPostalNumber;
        public System.Windows.Forms.TextBox txtBoxCity;
        public System.Windows.Forms.TextBox txtBoxPhoneNumber;
        public System.Windows.Forms.TextBox txtBoxMail;
    }
}

