
namespace beautySalon
{
    partial class RecordShow
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecordShow));
            this.panelServiceAdd = new System.Windows.Forms.Panel();
            this.lblNameForm = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblNameSalon = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.panelBack = new System.Windows.Forms.Panel();
            this.tableRecord = new System.Windows.Forms.DataGridView();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.panelServiceAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.panelBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableRecord)).BeginInit();
            this.SuspendLayout();
            // 
            // panelServiceAdd
            // 
            this.panelServiceAdd.BackColor = System.Drawing.Color.White;
            this.panelServiceAdd.Controls.Add(this.lblNameForm);
            this.panelServiceAdd.Controls.Add(this.btnClose);
            this.panelServiceAdd.Controls.Add(this.lblNameSalon);
            this.panelServiceAdd.Controls.Add(this.picLogo);
            this.panelServiceAdd.Controls.Add(this.panelFooter);
            this.panelServiceAdd.Controls.Add(this.panelBack);
            this.panelServiceAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelServiceAdd.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panelServiceAdd.Location = new System.Drawing.Point(0, 0);
            this.panelServiceAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelServiceAdd.Name = "panelServiceAdd";
            this.panelServiceAdd.Size = new System.Drawing.Size(1189, 576);
            this.panelServiceAdd.TabIndex = 4;
            // 
            // lblNameForm
            // 
            this.lblNameForm.AutoSize = true;
            this.lblNameForm.Location = new System.Drawing.Point(452, 27);
            this.lblNameForm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNameForm.Name = "lblNameForm";
            this.lblNameForm.Size = new System.Drawing.Size(187, 23);
            this.lblNameForm.TabIndex = 9;
            this.lblNameForm.Text = " Ближайшие записи";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1124, 15);
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
            this.panelFooter.Location = new System.Drawing.Point(0, 514);
            this.panelFooter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(1189, 62);
            this.panelFooter.TabIndex = 0;
            // 
            // panelBack
            // 
            this.panelBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.panelBack.Controls.Add(this.tableRecord);
            this.panelBack.Location = new System.Drawing.Point(88, 94);
            this.panelBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelBack.Name = "panelBack";
            this.panelBack.Size = new System.Drawing.Size(1034, 400);
            this.panelBack.TabIndex = 11;
            // 
            // tableRecord
            // 
            this.tableRecord.AllowUserToAddRows = false;
            this.tableRecord.AllowUserToDeleteRows = false;
            this.tableRecord.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableRecord.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tableRecord.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.tableRecord.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tableRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableRecord.Cursor = System.Windows.Forms.Cursors.IBeam;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(74)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tableRecord.DefaultCellStyle = dataGridViewCellStyle1;
            this.tableRecord.Location = new System.Drawing.Point(27, 20);
            this.tableRecord.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableRecord.MultiSelect = false;
            this.tableRecord.Name = "tableRecord";
            this.tableRecord.ReadOnly = true;
            this.tableRecord.RowHeadersVisible = false;
            this.tableRecord.RowHeadersWidth = 51;
            this.tableRecord.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tableRecord.Size = new System.Drawing.Size(980, 359);
            this.tableRecord.TabIndex = 26;
            // 
            // Timer
            // 
            this.Timer.Interval = 30000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // RecordShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 576);
            this.ControlBox = false;
            this.Controls.Add(this.panelServiceAdd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "RecordShow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.RecordShow_Load);
            this.panelServiceAdd.ResumeLayout(false);
            this.panelServiceAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.panelBack.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tableRecord)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelServiceAdd;
        private System.Windows.Forms.Label lblNameForm;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblNameSalon;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Panel panelBack;
        private System.Windows.Forms.DataGridView tableRecord;
        private System.Windows.Forms.Timer Timer;
    }
}