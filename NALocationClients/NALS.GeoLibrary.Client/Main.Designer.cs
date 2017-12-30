namespace NALS.GeoLibrary.Client
{
    partial class Main
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
            this.lblCount = new System.Windows.Forms.Label();
            this.lstDispay = new System.Windows.Forms.ListBox();
            this.lblTwo = new System.Windows.Forms.Label();
            this.txtState = new System.Windows.Forms.TextBox();
            this.btnGetZipCodes = new System.Windows.Forms.Button();
            this.lblOne = new System.Windows.Forms.Label();
            this.txtZipCode = new System.Windows.Forms.TextBox();
            this.btnZipCode = new System.Windows.Forms.Button();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnUpdateCityBatch = new System.Windows.Forms.Button();
            this.labelLine = new System.Windows.Forms.Label();
            this.lstUpdate = new System.Windows.Forms.ListBox();
            this.txtPOCode = new System.Windows.Forms.TextBox();
            this.lblEnterCode = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdateSingleCity = new System.Windows.Forms.Button();
            this.btnGetStateCode = new System.Windows.Forms.Button();
            this.btnGetStatesCodes = new System.Windows.Forms.Button();
            this.btnUpdateByBatch = new System.Windows.Forms.Button();
            this.lstStates = new System.Windows.Forms.ListView();
            this.lblFault = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCount
            // 
            this.lblCount.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.ForeColor = System.Drawing.Color.LightCoral;
            this.lblCount.Location = new System.Drawing.Point(234, 273);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(100, 23);
            this.lblCount.TabIndex = 34;
            this.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstDispay
            // 
            this.lstDispay.BackColor = System.Drawing.SystemColors.MenuText;
            this.lstDispay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstDispay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lstDispay.FormattingEnabled = true;
            this.lstDispay.ItemHeight = 25;
            this.lstDispay.Location = new System.Drawing.Point(234, 12);
            this.lstDispay.Name = "lstDispay";
            this.lstDispay.Size = new System.Drawing.Size(372, 254);
            this.lstDispay.TabIndex = 33;
            // 
            // lblTwo
            // 
            this.lblTwo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTwo.Location = new System.Drawing.Point(-85, 219);
            this.lblTwo.Name = "lblTwo";
            this.lblTwo.Size = new System.Drawing.Size(97, 23);
            this.lblTwo.TabIndex = 32;
            this.lblTwo.Text = "State:";
            this.lblTwo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtState
            // 
            this.txtState.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtState.Location = new System.Drawing.Point(18, 165);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(193, 26);
            this.txtState.TabIndex = 31;
            this.txtState.Text = "MA";
            // 
            // btnGetZipCodes
            // 
            this.btnGetZipCodes.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGetZipCodes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetZipCodes.ForeColor = System.Drawing.Color.Violet;
            this.btnGetZipCodes.Location = new System.Drawing.Point(18, 197);
            this.btnGetZipCodes.Name = "btnGetZipCodes";
            this.btnGetZipCodes.Size = new System.Drawing.Size(128, 30);
            this.btnGetZipCodes.TabIndex = 30;
            this.btnGetZipCodes.Text = "Get Zip Codes";
            this.btnGetZipCodes.UseVisualStyleBackColor = false;
            this.btnGetZipCodes.Click += new System.EventHandler(this.btnGetZipCodes_Click);
            // 
            // lblOne
            // 
            this.lblOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOne.Location = new System.Drawing.Point(-85, 111);
            this.lblOne.Name = "lblOne";
            this.lblOne.Size = new System.Drawing.Size(97, 23);
            this.lblOne.TabIndex = 29;
            this.lblOne.Text = "Zip Code:";
            this.lblOne.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtZipCode
            // 
            this.txtZipCode.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtZipCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtZipCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtZipCode.Location = new System.Drawing.Point(18, 83);
            this.txtZipCode.Name = "txtZipCode";
            this.txtZipCode.Size = new System.Drawing.Size(193, 26);
            this.txtZipCode.TabIndex = 28;
            this.txtZipCode.Text = "01002";
            // 
            // btnZipCode
            // 
            this.btnZipCode.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnZipCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZipCode.ForeColor = System.Drawing.Color.Violet;
            this.btnZipCode.Location = new System.Drawing.Point(18, 115);
            this.btnZipCode.Name = "btnZipCode";
            this.btnZipCode.Size = new System.Drawing.Size(128, 30);
            this.btnZipCode.TabIndex = 27;
            this.btnZipCode.Text = "Get Zip Info";
            this.btnZipCode.UseVisualStyleBackColor = false;
            this.btnZipCode.Click += new System.EventHandler(this.btnZipCode_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.ForeColor = System.Drawing.Color.Yellow;
            this.txtUserName.Location = new System.Drawing.Point(18, 29);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(193, 15);
            this.txtUserName.TabIndex = 35;
            this.txtUserName.Text = "BillyBob";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.Yellow;
            this.txtPassword.Location = new System.Drawing.Point(18, 50);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(193, 15);
            this.txtPassword.TabIndex = 36;
            this.txtPassword.Text = "TouchDown33";
            // 
            // btnUpdateCityBatch
            // 
            this.btnUpdateCityBatch.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUpdateCityBatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateCityBatch.ForeColor = System.Drawing.Color.Lime;
            this.btnUpdateCityBatch.Location = new System.Drawing.Point(34, 389);
            this.btnUpdateCityBatch.Name = "btnUpdateCityBatch";
            this.btnUpdateCityBatch.Size = new System.Drawing.Size(178, 56);
            this.btnUpdateCityBatch.TabIndex = 37;
            this.btnUpdateCityBatch.Text = "Update All City P.0. Codes";
            this.btnUpdateCityBatch.UseVisualStyleBackColor = false;
            this.btnUpdateCityBatch.EnabledChanged += new System.EventHandler(this.btnUpdateCityBatch_EnabledChanged);
            this.btnUpdateCityBatch.Click += new System.EventHandler(this.btnUpdateCityBatch_Click);
            // 
            // labelLine
            // 
            this.labelLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelLine.Location = new System.Drawing.Point(34, 305);
            this.labelLine.Name = "labelLine";
            this.labelLine.Size = new System.Drawing.Size(569, 10);
            this.labelLine.TabIndex = 39;
            // 
            // lstUpdate
            // 
            this.lstUpdate.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lstUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstUpdate.ForeColor = System.Drawing.Color.Lime;
            this.lstUpdate.FormattingEnabled = true;
            this.lstUpdate.ItemHeight = 16;
            this.lstUpdate.Location = new System.Drawing.Point(234, 327);
            this.lstUpdate.Name = "lstUpdate";
            this.lstUpdate.Size = new System.Drawing.Size(372, 116);
            this.lstUpdate.TabIndex = 38;
            // 
            // txtPOCode
            // 
            this.txtPOCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPOCode.Location = new System.Drawing.Point(441, 448);
            this.txtPOCode.MaxLength = 4;
            this.txtPOCode.Name = "txtPOCode";
            this.txtPOCode.Size = new System.Drawing.Size(162, 22);
            this.txtPOCode.TabIndex = 40;
            this.txtPOCode.TextChanged += new System.EventHandler(this.txtPOCode_TextChanged);
            this.txtPOCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPOCode_KeyPress);
            // 
            // lblEnterCode
            // 
            this.lblEnterCode.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEnterCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterCode.ForeColor = System.Drawing.Color.Lime;
            this.lblEnterCode.Location = new System.Drawing.Point(234, 448);
            this.lblEnterCode.Name = "lblEnterCode";
            this.lblEnterCode.Size = new System.Drawing.Size(202, 22);
            this.lblEnterCode.TabIndex = 41;
            this.lblEnterCode.Text = "Enter 4 Letter P.O. Code";
            this.lblEnterCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(15, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 23);
            this.label1.TabIndex = 42;
            this.label1.Text = "Extrernal User";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnUpdateSingleCity
            // 
            this.btnUpdateSingleCity.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUpdateSingleCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateSingleCity.ForeColor = System.Drawing.Color.Lime;
            this.btnUpdateSingleCity.Location = new System.Drawing.Point(34, 327);
            this.btnUpdateSingleCity.Name = "btnUpdateSingleCity";
            this.btnUpdateSingleCity.Size = new System.Drawing.Size(178, 56);
            this.btnUpdateSingleCity.TabIndex = 43;
            this.btnUpdateSingleCity.Text = "Update Selected City P.0. Code";
            this.btnUpdateSingleCity.UseVisualStyleBackColor = false;
            this.btnUpdateSingleCity.EnabledChanged += new System.EventHandler(this.btnUpdateSingleCity_EnabledChanged);
            this.btnUpdateSingleCity.Click += new System.EventHandler(this.btnUpdateSingleCity_Click);
            // 
            // btnGetStateCode
            // 
            this.btnGetStateCode.Location = new System.Drawing.Point(632, 19);
            this.btnGetStateCode.Name = "btnGetStateCode";
            this.btnGetStateCode.Size = new System.Drawing.Size(148, 23);
            this.btnGetStateCode.TabIndex = 44;
            this.btnGetStateCode.Text = "Get State Code";
            this.btnGetStateCode.UseVisualStyleBackColor = true;
            this.btnGetStateCode.Click += new System.EventHandler(this.btnGetStateCode_Click);
            // 
            // btnGetStatesCodes
            // 
            this.btnGetStatesCodes.Location = new System.Drawing.Point(786, 19);
            this.btnGetStatesCodes.Name = "btnGetStatesCodes";
            this.btnGetStatesCodes.Size = new System.Drawing.Size(258, 23);
            this.btnGetStatesCodes.TabIndex = 45;
            this.btnGetStatesCodes.Text = "Get All Primary State Codes";
            this.btnGetStatesCodes.UseVisualStyleBackColor = true;
            this.btnGetStatesCodes.Click += new System.EventHandler(this.btnGetStatesCodes_Click);
            // 
            // btnUpdateByBatch
            // 
            this.btnUpdateByBatch.Location = new System.Drawing.Point(632, 448);
            this.btnUpdateByBatch.Name = "btnUpdateByBatch";
            this.btnUpdateByBatch.Size = new System.Drawing.Size(412, 23);
            this.btnUpdateByBatch.TabIndex = 46;
            this.btnUpdateByBatch.Text = "Update State Code By Batch";
            this.btnUpdateByBatch.UseVisualStyleBackColor = true;
            this.btnUpdateByBatch.Click += new System.EventHandler(this.btnUpdateByBatch_Click);
            // 
            // lstStates
            // 
            this.lstStates.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstStates.FullRowSelect = true;
            this.lstStates.GridLines = true;
            this.lstStates.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstStates.LabelEdit = true;
            this.lstStates.Location = new System.Drawing.Point(632, 67);
            this.lstStates.Name = "lstStates";
            this.lstStates.Size = new System.Drawing.Size(412, 362);
            this.lstStates.TabIndex = 47;
            this.lstStates.UseCompatibleStateImageBehavior = false;
            this.lstStates.View = System.Windows.Forms.View.Details;
            // 
            // lblFault
            // 
            this.lblFault.BackColor = System.Drawing.Color.Black;
            this.lblFault.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFault.ForeColor = System.Drawing.Color.Red;
            this.lblFault.Location = new System.Drawing.Point(31, 482);
            this.lblFault.Name = "lblFault";
            this.lblFault.Size = new System.Drawing.Size(1013, 175);
            this.lblFault.TabIndex = 48;
            this.lblFault.Text = "Fault Message";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 651);
            this.Controls.Add(this.lblFault);
            this.Controls.Add(this.lstStates);
            this.Controls.Add(this.btnUpdateByBatch);
            this.Controls.Add(this.btnGetStatesCodes);
            this.Controls.Add(this.btnGetStateCode);
            this.Controls.Add(this.btnUpdateSingleCity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblEnterCode);
            this.Controls.Add(this.txtPOCode);
            this.Controls.Add(this.labelLine);
            this.Controls.Add(this.lstUpdate);
            this.Controls.Add(this.btnUpdateCityBatch);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.lstDispay);
            this.Controls.Add(this.lblTwo);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.btnGetZipCodes);
            this.Controls.Add(this.lblOne);
            this.Controls.Add(this.txtZipCode);
            this.Controls.Add(this.btnZipCode);
            this.Name = "Main";
            this.Text = "WCF Demo";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.ListBox lstDispay;
        private System.Windows.Forms.Label lblTwo;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.Button btnGetZipCodes;
        private System.Windows.Forms.Label lblOne;
        private System.Windows.Forms.TextBox txtZipCode;
        private System.Windows.Forms.Button btnZipCode;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnUpdateCityBatch;
        private System.Windows.Forms.Label labelLine;
        private System.Windows.Forms.ListBox lstUpdate;
        private System.Windows.Forms.TextBox txtPOCode;
        private System.Windows.Forms.Label lblEnterCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdateSingleCity;
        private System.Windows.Forms.Button btnGetStateCode;
        private System.Windows.Forms.Button btnGetStatesCodes;
        private System.Windows.Forms.Button btnUpdateByBatch;
        private System.Windows.Forms.ListView lstStates;
        private System.Windows.Forms.Label lblFault;
    }
}

