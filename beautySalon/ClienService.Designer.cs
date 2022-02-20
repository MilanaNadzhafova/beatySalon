
namespace beautySalon
{
    partial class ClienService
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClienService));
            this.panelServiceAdd = new System.Windows.Forms.Panel();
            this.lblNameForm = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblNameSalon = new System.Windows.Forms.Label();
            this.btnAddClientService = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.panelBack = new System.Windows.Forms.Panel();
            this.txtTimeEnd = new System.Windows.Forms.MaskedTextBox();
            this.lblTimeEnd = new System.Windows.Forms.Label();
            this.txtTimeStart = new System.Windows.Forms.MaskedTextBox();
            this.lblTimeStart = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.dateService = new System.Windows.Forms.DateTimePicker();
            this.lblServiceDuration = new System.Windows.Forms.Label();
            this.lblServiceName = new System.Windows.Forms.Label();
            this.tableClient = new System.Windows.Forms.DataGridView();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.panelServiceAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.panelBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableClient)).BeginInit();
            this.SuspendLayout();
            // 
            // panelServiceAdd
            // 
            this.panelServiceAdd.BackColor = System.Drawing.Color.White;
            this.panelServiceAdd.Controls.Add(this.lblNameForm);
            this.panelServiceAdd.Controls.Add(this.btnClose);
            this.panelServiceAdd.Controls.Add(this.lblNameSalon);
            this.panelServiceAdd.Controls.Add(this.btnAddClientService);
            this.panelServiceAdd.Controls.Add(this.picLogo);
            this.panelServiceAdd.Controls.Add(this.panelFooter);
            this.panelServiceAdd.Controls.Add(this.panelBack);
            this.panelServiceAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelServiceAdd.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panelServiceAdd.Location = new System.Drawing.Point(0, 0);
            this.panelServiceAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelServiceAdd.Name = "panelServiceAdd";
            this.panelServiceAdd.Size = new System.Drawing.Size(1067, 634);
            this.panelServiceAdd.TabIndex = 3;
            // 
            // lblNameForm
            // 
            this.lblNameForm.AutoSize = true;
            this.lblNameForm.Location = new System.Drawing.Point(452, 27);
            this.lblNameForm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNameForm.Name = "lblNameForm";
            this.lblNameForm.Size = new System.Drawing.Size(148, 23);
            this.lblNameForm.TabIndex = 9;
            this.lblNameForm.Text = "Запись клиента";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(999, 17);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(52, 43);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblNameSalon
            // 
            this.lblNameSalon.AutoSize = true;
            this.lblNameSalon.Location = new System.Drawing.Point(84, 15);
            this.lblNameSalon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNameSalon.Name = "lblNameSalon";
            this.lblNameSalon.Size = new System.Drawing.Size(109, 46);
            this.lblNameSalon.TabIndex = 2;
            this.lblNameSalon.Text = "бархатные \r\nбровки";
            // 
            // btnAddClientService
            // 
            this.btnAddClientService.Location = new System.Drawing.Point(428, 510);
            this.btnAddClientService.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddClientService.Name = "btnAddClientService";
            this.btnAddClientService.Size = new System.Drawing.Size(215, 43);
            this.btnAddClientService.TabIndex = 0;
            this.btnAddClientService.Text = "Записать клиента";
            this.btnAddClientService.UseVisualStyleBackColor = true;
            this.btnAddClientService.Click += new System.EventHandler(this.btnAddClientService_Click);
            // 
            // picLogo
            // 
            this.picLogo.Image = global::beautySalon.Properties.Resources.beauty;
            this.picLogo.Location = new System.Drawing.Point(16, 15);
            this.picLogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(60, 46);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 1;
            this.picLogo.TabStop = false;
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 572);
            this.panelFooter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(1067, 62);
            this.panelFooter.TabIndex = 0;
            // 
            // panelBack
            // 
            this.panelBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.panelBack.Controls.Add(this.txtTimeEnd);
            this.panelBack.Controls.Add(this.lblTimeEnd);
            this.panelBack.Controls.Add(this.txtTimeStart);
            this.panelBack.Controls.Add(this.lblTimeStart);
            this.panelBack.Controls.Add(this.lbDate);
            this.panelBack.Controls.Add(this.dateService);
            this.panelBack.Controls.Add(this.lblServiceDuration);
            this.panelBack.Controls.Add(this.lblServiceName);
            this.panelBack.Controls.Add(this.tableClient);
            this.panelBack.Controls.Add(this.lblDescription);
            this.panelBack.Controls.Add(this.lblDuration);
            this.panelBack.Controls.Add(this.lblName);
            this.panelBack.Location = new System.Drawing.Point(88, 94);
            this.panelBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelBack.Name = "panelBack";
            this.panelBack.Size = new System.Drawing.Size(879, 400);
            this.panelBack.TabIndex = 11;
            this.panelBack.Paint += new System.Windows.Forms.PaintEventHandler(this.panelBack_Paint);
            // 
            // txtTimeEnd
            // 
            this.txtTimeEnd.Location = new System.Drawing.Point(44, 347);
            this.txtTimeEnd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTimeEnd.Mask = "00:00";
            this.txtTimeEnd.Name = "txtTimeEnd";
            this.txtTimeEnd.ReadOnly = true;
            this.txtTimeEnd.Size = new System.Drawing.Size(128, 30);
            this.txtTimeEnd.TabIndex = 35;
            this.txtTimeEnd.ValidatingType = typeof(System.DateTime);
            // 
            // lblTimeEnd
            // 
            this.lblTimeEnd.AutoSize = true;
            this.lblTimeEnd.Location = new System.Drawing.Point(40, 321);
            this.lblTimeEnd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTimeEnd.Name = "lblTimeEnd";
            this.lblTimeEnd.Size = new System.Drawing.Size(169, 23);
            this.lblTimeEnd.TabIndex = 34;
            this.lblTimeEnd.Text = "Время окончания:";
            // 
            // txtTimeStart
            // 
            this.txtTimeStart.Location = new System.Drawing.Point(44, 267);
            this.txtTimeStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTimeStart.Mask = "00:00";
            this.txtTimeStart.Name = "txtTimeStart";
            this.txtTimeStart.Size = new System.Drawing.Size(128, 30);
            this.txtTimeStart.TabIndex = 33;
            this.txtTimeStart.ValidatingType = typeof(System.DateTime);
            this.txtTimeStart.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtTimeStart_MaskInputRejected);
            this.txtTimeStart.TextChanged += new System.EventHandler(this.txtTimeStart_TextChanged);
            this.txtTimeStart.Leave += new System.EventHandler(this.txtTimeStart_Leave);
            // 
            // lblTimeStart
            // 
            this.lblTimeStart.AutoSize = true;
            this.lblTimeStart.Location = new System.Drawing.Point(40, 241);
            this.lblTimeStart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTimeStart.Name = "lblTimeStart";
            this.lblTimeStart.Size = new System.Drawing.Size(139, 23);
            this.lblTimeStart.TabIndex = 32;
            this.lblTimeStart.Text = "Время начала:";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Location = new System.Drawing.Point(40, 162);
            this.lbDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(208, 23);
            this.lbDate.TabIndex = 30;
            this.lbDate.Text = "Дата оказания услуги:";
            // 
            // dateService
            // 
            this.dateService.Location = new System.Drawing.Point(44, 188);
            this.dateService.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateService.Name = "dateService";
            this.dateService.Size = new System.Drawing.Size(265, 30);
            this.dateService.TabIndex = 29;
            // 
            // lblServiceDuration
            // 
            this.lblServiceDuration.AutoSize = true;
            this.lblServiceDuration.Location = new System.Drawing.Point(40, 118);
            this.lblServiceDuration.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblServiceDuration.Name = "lblServiceDuration";
            this.lblServiceDuration.Size = new System.Drawing.Size(217, 23);
            this.lblServiceDuration.TabIndex = 28;
            this.lblServiceDuration.Text = "Длительность (в мин.):";
            // 
            // lblServiceName
            // 
            this.lblServiceName.AutoSize = true;
            this.lblServiceName.Location = new System.Drawing.Point(40, 52);
            this.lblServiceName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblServiceName.Name = "lblServiceName";
            this.lblServiceName.Size = new System.Drawing.Size(146, 23);
            this.lblServiceName.TabIndex = 27;
            this.lblServiceName.Text = "Наименование:";
            // 
            // tableClient
            // 
            this.tableClient.AllowUserToAddRows = false;
            this.tableClient.AllowUserToDeleteRows = false;
            this.tableClient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableClient.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tableClient.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.tableClient.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tableClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableClient.Cursor = System.Windows.Forms.Cursors.IBeam;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(74)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tableClient.DefaultCellStyle = dataGridViewCellStyle1;
            this.tableClient.Location = new System.Drawing.Point(355, 52);
            this.tableClient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableClient.MultiSelect = false;
            this.tableClient.Name = "tableClient";
            this.tableClient.ReadOnly = true;
            this.tableClient.RowHeadersVisible = false;
            this.tableClient.RowHeadersWidth = 51;
            this.tableClient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tableClient.Size = new System.Drawing.Size(483, 327);
            this.tableClient.TabIndex = 26;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(351, 26);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(80, 23);
            this.lblDescription.TabIndex = 20;
            this.lblDescription.Text = "Клиент:";
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Location = new System.Drawing.Point(40, 96);
            this.lblDuration.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(217, 23);
            this.lblDuration.TabIndex = 16;
            this.lblDuration.Text = "Длительность (в мин.):";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(40, 26);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(146, 23);
            this.lblName.TabIndex = 12;
            this.lblName.Text = "Наименование:";
            // 
            // ClienService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 634);
            this.ControlBox = false;
            this.Controls.Add(this.panelServiceAdd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ClienService";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ClienService_Load);
            this.panelServiceAdd.ResumeLayout(false);
            this.panelServiceAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.panelBack.ResumeLayout(false);
            this.panelBack.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableClient)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelServiceAdd;
        private System.Windows.Forms.Label lblNameForm;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblNameSalon;
        private System.Windows.Forms.Button btnAddClientService;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Panel panelBack;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.DateTimePicker dateService;
        private System.Windows.Forms.Label lblServiceDuration;
        private System.Windows.Forms.Label lblServiceName;
        private System.Windows.Forms.DataGridView tableClient;
        private System.Windows.Forms.MaskedTextBox txtTimeEnd;
        private System.Windows.Forms.Label lblTimeEnd;
        private System.Windows.Forms.MaskedTextBox txtTimeStart;
        private System.Windows.Forms.Label lblTimeStart;
    }
}