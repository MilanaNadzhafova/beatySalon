
namespace beautySalon
{
    partial class ListOfServices
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListOfServices));
            this.panelService = new System.Windows.Forms.Panel();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cmbDiscountFiltr = new System.Windows.Forms.ComboBox();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.cmbPriceSort = new System.Windows.Forms.ComboBox();
            this.lblPriceSort = new System.Windows.Forms.Label();
            this.lblPages = new System.Windows.Forms.Label();
            this.lblNameForm = new System.Windows.Forms.Label();
            this.panelButton = new System.Windows.Forms.Panel();
            this.btnComingRecorf = new System.Windows.Forms.Button();
            this.btnRecordClient = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tableService = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblNameSalon = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.panelService.SuspendLayout();
            this.panelButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableService)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelService
            // 
            this.panelService.Controls.Add(this.lblSearch);
            this.panelService.Controls.Add(this.txtSearch);
            this.panelService.Controls.Add(this.cmbDiscountFiltr);
            this.panelService.Controls.Add(this.lblDiscount);
            this.panelService.Controls.Add(this.cmbPriceSort);
            this.panelService.Controls.Add(this.lblPriceSort);
            this.panelService.Controls.Add(this.lblPages);
            this.panelService.Controls.Add(this.lblNameForm);
            this.panelService.Controls.Add(this.panelButton);
            this.panelService.Controls.Add(this.tableService);
            this.panelService.Controls.Add(this.btnClose);
            this.panelService.Controls.Add(this.lblNameSalon);
            this.panelService.Controls.Add(this.picLogo);
            this.panelService.Controls.Add(this.panelFooter);
            this.panelService.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelService.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panelService.Location = new System.Drawing.Point(0, 0);
            this.panelService.Name = "panelService";
            this.panelService.Size = new System.Drawing.Size(1054, 596);
            this.panelService.TabIndex = 1;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(725, 73);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(48, 18);
            this.lblSearch.TabIndex = 15;
            this.lblSearch.Text = "Поиск";
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.txtSearch.Location = new System.Drawing.Point(779, 70);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(263, 26);
            this.txtSearch.TabIndex = 14;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // cmbDiscountFiltr
            // 
            this.cmbDiscountFiltr.AutoCompleteCustomSource.AddRange(new string[] {
            "Нет",
            "По возрастанию",
            "По убыванию"});
            this.cmbDiscountFiltr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.cmbDiscountFiltr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDiscountFiltr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbDiscountFiltr.FormattingEnabled = true;
            this.cmbDiscountFiltr.Items.AddRange(new object[] {
            "Все записи",
            "От 0% до 5%",
            "От 5% до 15%",
            "От 15% до 30%",
            "От 30% до 70%",
            "От 70% до 100%"});
            this.cmbDiscountFiltr.Location = new System.Drawing.Point(495, 70);
            this.cmbDiscountFiltr.Name = "cmbDiscountFiltr";
            this.cmbDiscountFiltr.Size = new System.Drawing.Size(224, 26);
            this.cmbDiscountFiltr.TabIndex = 12;
            this.cmbDiscountFiltr.SelectedIndexChanged += new System.EventHandler(this.cmbDiscountFiltr_SelectedIndexChanged);
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Location = new System.Drawing.Point(436, 73);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(55, 18);
            this.lblDiscount.TabIndex = 13;
            this.lblDiscount.Text = "Скидка";
            // 
            // cmbPriceSort
            // 
            this.cmbPriceSort.AutoCompleteCustomSource.AddRange(new string[] {
            "Нет",
            "По возрастанию",
            "По убыванию"});
            this.cmbPriceSort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.cmbPriceSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPriceSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbPriceSort.FormattingEnabled = true;
            this.cmbPriceSort.Items.AddRange(new object[] {
            "Все записи",
            "По возрастанию",
            "По убыванию"});
            this.cmbPriceSort.Location = new System.Drawing.Point(204, 70);
            this.cmbPriceSort.Name = "cmbPriceSort";
            this.cmbPriceSort.Size = new System.Drawing.Size(224, 26);
            this.cmbPriceSort.TabIndex = 10;
            this.cmbPriceSort.SelectedIndexChanged += new System.EventHandler(this.cmbPriceSort_SelectedIndexChanged);
            // 
            // lblPriceSort
            // 
            this.lblPriceSort.AutoSize = true;
            this.lblPriceSort.Location = new System.Drawing.Point(12, 73);
            this.lblPriceSort.Name = "lblPriceSort";
            this.lblPriceSort.Size = new System.Drawing.Size(186, 18);
            this.lblPriceSort.TabIndex = 11;
            this.lblPriceSort.Text = "Сортировка по стоимости";
            // 
            // lblPages
            // 
            this.lblPages.AutoSize = true;
            this.lblPages.Location = new System.Drawing.Point(9, 509);
            this.lblPages.Name = "lblPages";
            this.lblPages.Size = new System.Drawing.Size(81, 18);
            this.lblPages.TabIndex = 0;
            this.lblPages.Text = "200 из 450";
            // 
            // lblNameForm
            // 
            this.lblNameForm.AutoSize = true;
            this.lblNameForm.Location = new System.Drawing.Point(518, 21);
            this.lblNameForm.Name = "lblNameForm";
            this.lblNameForm.Size = new System.Drawing.Size(97, 18);
            this.lblNameForm.TabIndex = 9;
            this.lblNameForm.Text = "Список услуг";
            // 
            // panelButton
            // 
            this.panelButton.BackColor = System.Drawing.Color.Transparent;
            this.panelButton.Controls.Add(this.btnComingRecorf);
            this.panelButton.Controls.Add(this.btnRecordClient);
            this.panelButton.Controls.Add(this.btnDelete);
            this.panelButton.Controls.Add(this.btnEdit);
            this.panelButton.Controls.Add(this.btnAdd);
            this.panelButton.Location = new System.Drawing.Point(401, 491);
            this.panelButton.Name = "panelButton";
            this.panelButton.Size = new System.Drawing.Size(641, 45);
            this.panelButton.TabIndex = 8;
            this.panelButton.Paint += new System.Windows.Forms.PaintEventHandler(this.panelButton_Paint);
            // 
            // btnComingRecorf
            // 
            this.btnComingRecorf.Location = new System.Drawing.Point(474, 14);
            this.btnComingRecorf.Name = "btnComingRecorf";
            this.btnComingRecorf.Size = new System.Drawing.Size(165, 28);
            this.btnComingRecorf.TabIndex = 4;
            this.btnComingRecorf.Text = "Ближайшие записи";
            this.btnComingRecorf.UseVisualStyleBackColor = true;
            this.btnComingRecorf.Click += new System.EventHandler(this.btnComingRecorf_Click);
            // 
            // btnRecordClient
            // 
            this.btnRecordClient.Location = new System.Drawing.Point(324, 14);
            this.btnRecordClient.Name = "btnRecordClient";
            this.btnRecordClient.Size = new System.Drawing.Size(144, 28);
            this.btnRecordClient.TabIndex = 3;
            this.btnRecordClient.Text = "Запись клиента";
            this.btnRecordClient.UseVisualStyleBackColor = true;
            this.btnRecordClient.Click += new System.EventHandler(this.btnRecordClient_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(213, 14);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(105, 28);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(101, 14);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(105, 28);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Изменить";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(3, 14);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(93, 28);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tableService
            // 
            this.tableService.AllowUserToAddRows = false;
            this.tableService.AllowUserToDeleteRows = false;
            this.tableService.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableService.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tableService.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.tableService.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableService.Cursor = System.Windows.Forms.Cursors.IBeam;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(74)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tableService.DefaultCellStyle = dataGridViewCellStyle1;
            this.tableService.Location = new System.Drawing.Point(12, 107);
            this.tableService.MultiSelect = false;
            this.tableService.Name = "tableService";
            this.tableService.ReadOnly = true;
            this.tableService.RowHeadersVisible = false;
            this.tableService.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tableService.Size = new System.Drawing.Size(1030, 378);
            this.tableService.TabIndex = 7;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1003, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(39, 35);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblNameSalon
            // 
            this.lblNameSalon.AutoSize = true;
            this.lblNameSalon.Location = new System.Drawing.Point(63, 12);
            this.lblNameSalon.Name = "lblNameSalon";
            this.lblNameSalon.Size = new System.Drawing.Size(87, 36);
            this.lblNameSalon.TabIndex = 2;
            this.lblNameSalon.Text = "бархатные \r\nбровки";
            // 
            // picLogo
            // 
            this.picLogo.Image = global::beautySalon.Properties.Resources.beauty;
            this.picLogo.Location = new System.Drawing.Point(12, 12);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(45, 37);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 1;
            this.picLogo.TabStop = false;
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 546);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(1054, 50);
            this.panelFooter.TabIndex = 0;
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // ListOfServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1054, 596);
            this.ControlBox = false;
            this.Controls.Add(this.panelService);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ListOfServices";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ListOfServices_Load);
            this.panelService.ResumeLayout(false);
            this.panelService.PerformLayout();
            this.panelButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tableService)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelService;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblNameSalon;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.DataGridView tableService;
        private System.Windows.Forms.Panel panelButton;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnComingRecorf;
        private System.Windows.Forms.Button btnRecordClient;
        private System.Windows.Forms.Label lblNameForm;
        private System.Windows.Forms.Label lblPages;
        private System.Windows.Forms.ComboBox cmbPriceSort;
        private System.Windows.Forms.Label lblPriceSort;
        private System.Windows.Forms.ComboBox cmbDiscountFiltr;
        private System.Windows.Forms.Label lblDiscount;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
    }
}