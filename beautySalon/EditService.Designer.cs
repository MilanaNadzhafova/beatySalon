
namespace beautySalon
{
    partial class EditService
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditService));
            this.panelServiceAdd = new System.Windows.Forms.Panel();
            this.lblNameForm = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblNameSalon = new System.Windows.Forms.Label();
            this.btnChangeService = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.panelBack = new System.Windows.Forms.Panel();
            this.btnDeletePhoto = new System.Windows.Forms.Button();
            this.btnAddMorePhoto = new System.Windows.Forms.Button();
            this.tablePicture = new System.Windows.Forms.DataGridView();
            this.txtDiscount = new System.Windows.Forms.NumericUpDown();
            this.txtDuration = new System.Windows.Forms.NumericUpDown();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.btnAddPhoto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.picService = new System.Windows.Forms.PictureBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.panelServiceAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.panelBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiscount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picService)).BeginInit();
            this.SuspendLayout();
            // 
            // panelServiceAdd
            // 
            this.panelServiceAdd.BackColor = System.Drawing.Color.White;
            this.panelServiceAdd.Controls.Add(this.panelBack);
            this.panelServiceAdd.Controls.Add(this.lblNameForm);
            this.panelServiceAdd.Controls.Add(this.btnClose);
            this.panelServiceAdd.Controls.Add(this.lblNameSalon);
            this.panelServiceAdd.Controls.Add(this.btnChangeService);
            this.panelServiceAdd.Controls.Add(this.picLogo);
            this.panelServiceAdd.Controls.Add(this.panelFooter);
            this.panelServiceAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelServiceAdd.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panelServiceAdd.Location = new System.Drawing.Point(0, 0);
            this.panelServiceAdd.Name = "panelServiceAdd";
            this.panelServiceAdd.Size = new System.Drawing.Size(800, 738);
            this.panelServiceAdd.TabIndex = 3;
            // 
            // lblNameForm
            // 
            this.lblNameForm.AutoSize = true;
            this.lblNameForm.Location = new System.Drawing.Point(339, 22);
            this.lblNameForm.Name = "lblNameForm";
            this.lblNameForm.Size = new System.Drawing.Size(133, 18);
            this.lblNameForm.TabIndex = 9;
            this.lblNameForm.Text = "Изменение услуги";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(727, 14);
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
            // btnChangeService
            // 
            this.btnChangeService.Location = new System.Drawing.Point(326, 636);
            this.btnChangeService.Name = "btnChangeService";
            this.btnChangeService.Size = new System.Drawing.Size(161, 35);
            this.btnChangeService.TabIndex = 0;
            this.btnChangeService.Text = "Изменить услугу";
            this.btnChangeService.UseVisualStyleBackColor = true;
            this.btnChangeService.Click += new System.EventHandler(this.btnChangeService_Click);
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
            this.panelFooter.Location = new System.Drawing.Point(0, 688);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(800, 50);
            this.panelFooter.TabIndex = 0;
            // 
            // panelBack
            // 
            this.panelBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.panelBack.Controls.Add(this.btnDeletePhoto);
            this.panelBack.Controls.Add(this.btnAddMorePhoto);
            this.panelBack.Controls.Add(this.tablePicture);
            this.panelBack.Controls.Add(this.txtDiscount);
            this.panelBack.Controls.Add(this.txtDuration);
            this.panelBack.Controls.Add(this.txtDescription);
            this.panelBack.Controls.Add(this.btnAddPhoto);
            this.panelBack.Controls.Add(this.label1);
            this.panelBack.Controls.Add(this.picService);
            this.panelBack.Controls.Add(this.lblDescription);
            this.panelBack.Controls.Add(this.lblDiscount);
            this.panelBack.Controls.Add(this.lblDuration);
            this.panelBack.Controls.Add(this.lblPrice);
            this.panelBack.Controls.Add(this.txtPrice);
            this.panelBack.Controls.Add(this.lblName);
            this.panelBack.Controls.Add(this.txtName);
            this.panelBack.Location = new System.Drawing.Point(71, 68);
            this.panelBack.Name = "panelBack";
            this.panelBack.Size = new System.Drawing.Size(659, 551);
            this.panelBack.TabIndex = 12;
            // 
            // btnDeletePhoto
            // 
            this.btnDeletePhoto.Location = new System.Drawing.Point(477, 494);
            this.btnDeletePhoto.Name = "btnDeletePhoto";
            this.btnDeletePhoto.Size = new System.Drawing.Size(161, 34);
            this.btnDeletePhoto.TabIndex = 29;
            this.btnDeletePhoto.Text = "Удалить фото";
            this.btnDeletePhoto.UseVisualStyleBackColor = true;
            this.btnDeletePhoto.Click += new System.EventHandler(this.btnDeletePhoto_Click);
            // 
            // btnAddMorePhoto
            // 
            this.btnAddMorePhoto.Location = new System.Drawing.Point(291, 494);
            this.btnAddMorePhoto.Name = "btnAddMorePhoto";
            this.btnAddMorePhoto.Size = new System.Drawing.Size(161, 34);
            this.btnAddMorePhoto.TabIndex = 28;
            this.btnAddMorePhoto.Text = "Добавить фото";
            this.btnAddMorePhoto.UseVisualStyleBackColor = true;
            this.btnAddMorePhoto.Click += new System.EventHandler(this.btnAddMorePhoto_Click);
            // 
            // tablePicture
            // 
            this.tablePicture.AllowUserToAddRows = false;
            this.tablePicture.AllowUserToDeleteRows = false;
            this.tablePicture.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablePicture.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tablePicture.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.tablePicture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tablePicture.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablePicture.Cursor = System.Windows.Forms.Cursors.IBeam;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(74)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablePicture.DefaultCellStyle = dataGridViewCellStyle1;
            this.tablePicture.Location = new System.Drawing.Point(17, 276);
            this.tablePicture.Margin = new System.Windows.Forms.Padding(4);
            this.tablePicture.MultiSelect = false;
            this.tablePicture.Name = "tablePicture";
            this.tablePicture.ReadOnly = true;
            this.tablePicture.RowHeadersVisible = false;
            this.tablePicture.RowHeadersWidth = 51;
            this.tablePicture.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablePicture.Size = new System.Drawing.Size(618, 211);
            this.tablePicture.TabIndex = 27;
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(13, 217);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(185, 26);
            this.txtDiscount.TabIndex = 25;
            // 
            // txtDuration
            // 
            this.txtDuration.Location = new System.Drawing.Point(13, 156);
            this.txtDuration.Maximum = new decimal(new int[] {
            240,
            0,
            0,
            0});
            this.txtDuration.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(185, 26);
            this.txtDuration.TabIndex = 24;
            this.txtDuration.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(229, 29);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(210, 218);
            this.txtDescription.TabIndex = 23;
            this.txtDescription.Text = "";
            // 
            // btnAddPhoto
            // 
            this.btnAddPhoto.Location = new System.Drawing.Point(17, 494);
            this.btnAddPhoto.Name = "btnAddPhoto";
            this.btnAddPhoto.Size = new System.Drawing.Size(252, 34);
            this.btnAddPhoto.TabIndex = 12;
            this.btnAddPhoto.Text = "Выбрать главным изображением";
            this.btnAddPhoto.UseVisualStyleBackColor = true;
            this.btnAddPhoto.Click += new System.EventHandler(this.btnAddPhoto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(469, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 18);
            this.label1.TabIndex = 22;
            this.label1.Text = "Изображение:";
            // 
            // picService
            // 
            this.picService.Location = new System.Drawing.Point(472, 33);
            this.picService.Name = "picService";
            this.picService.Size = new System.Drawing.Size(166, 170);
            this.picService.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picService.TabIndex = 21;
            this.picService.TabStop = false;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(226, 8);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(79, 18);
            this.lblDescription.TabIndex = 20;
            this.lblDescription.Text = "Описание:";
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Location = new System.Drawing.Point(14, 195);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(105, 18);
            this.lblDiscount.TabIndex = 18;
            this.lblDiscount.Text = "Скидка (в %):";
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Location = new System.Drawing.Point(14, 132);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(171, 18);
            this.lblDuration.TabIndex = 16;
            this.lblDuration.Text = "Длительность (в мин.):";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(14, 68);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(146, 18);
            this.lblPrice.TabIndex = 14;
            this.lblPrice.Text = "Стоимость (в руб.):";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(13, 89);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(185, 26);
            this.txtPrice.TabIndex = 13;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(14, 8);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(113, 18);
            this.lblName.TabIndex = 12;
            this.lblName.Text = "Наименование:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(13, 29);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(185, 26);
            this.txtName.TabIndex = 10;
            // 
            // EditService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 738);
            this.ControlBox = false;
            this.Controls.Add(this.panelServiceAdd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditService";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "`";
            this.Load += new System.EventHandler(this.EditService_Load);
            this.panelServiceAdd.ResumeLayout(false);
            this.panelServiceAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.panelBack.ResumeLayout(false);
            this.panelBack.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiscount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picService)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelServiceAdd;
        private System.Windows.Forms.Label lblNameForm;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblNameSalon;
        private System.Windows.Forms.Button btnChangeService;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Panel panelBack;
        private System.Windows.Forms.Button btnDeletePhoto;
        private System.Windows.Forms.Button btnAddMorePhoto;
        private System.Windows.Forms.DataGridView tablePicture;
        private System.Windows.Forms.NumericUpDown txtDiscount;
        private System.Windows.Forms.NumericUpDown txtDuration;
        private System.Windows.Forms.RichTextBox txtDescription;
        private System.Windows.Forms.Button btnAddPhoto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picService;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
    }
}