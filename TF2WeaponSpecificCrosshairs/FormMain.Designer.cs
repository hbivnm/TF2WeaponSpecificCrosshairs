﻿namespace TF2WeaponSpecificCrosshairs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.textBoxTF2Path = new System.Windows.Forms.TextBox();
            this.lblTF2Path = new System.Windows.Forms.Label();
            this.textBoxDebugger = new System.Windows.Forms.TextBox();
            this.cbClass = new System.Windows.Forms.ComboBox();
            this.cbWeapon = new System.Windows.Forms.ComboBox();
            this.cbCrosshair = new System.Windows.Forms.ComboBox();
            this.lblClass = new System.Windows.Forms.Label();
            this.lblWeapon = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listViewChosenCrosshairs = new System.Windows.Forms.ListView();
            this.btnRemoveSelected = new System.Windows.Forms.Button();
            this.btnAddCrosshair = new System.Windows.Forms.Button();
            this.pictureBoxCrosshair = new System.Windows.Forms.PictureBox();
            this.btnReload = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCrosshair)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxTF2Path
            // 
            this.textBoxTF2Path.Location = new System.Drawing.Point(15, 24);
            this.textBoxTF2Path.Name = "textBoxTF2Path";
            this.textBoxTF2Path.Size = new System.Drawing.Size(364, 20);
            this.textBoxTF2Path.TabIndex = 3;
            this.textBoxTF2Path.Text = "C:\\Program Files (x86)\\Steam\\steamapps\\common\\Team Fortress 2";
            // 
            // lblTF2Path
            // 
            this.lblTF2Path.AutoSize = true;
            this.lblTF2Path.Location = new System.Drawing.Point(12, 9);
            this.lblTF2Path.Name = "lblTF2Path";
            this.lblTF2Path.Size = new System.Drawing.Size(54, 13);
            this.lblTF2Path.TabIndex = 2;
            this.lblTF2Path.Text = "TF2 Path:";
            // 
            // textBoxDebugger
            // 
            this.textBoxDebugger.BackColor = System.Drawing.Color.Black;
            this.textBoxDebugger.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxDebugger.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDebugger.ForeColor = System.Drawing.SystemColors.Control;
            this.textBoxDebugger.Location = new System.Drawing.Point(12, 385);
            this.textBoxDebugger.Multiline = true;
            this.textBoxDebugger.Name = "textBoxDebugger";
            this.textBoxDebugger.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDebugger.Size = new System.Drawing.Size(837, 154);
            this.textBoxDebugger.TabIndex = 4;
            // 
            // cbClass
            // 
            this.cbClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClass.FormattingEnabled = true;
            this.cbClass.Location = new System.Drawing.Point(71, 50);
            this.cbClass.Name = "cbClass";
            this.cbClass.Size = new System.Drawing.Size(154, 21);
            this.cbClass.TabIndex = 5;
            // 
            // cbWeapon
            // 
            this.cbWeapon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbWeapon.DropDownWidth = 420;
            this.cbWeapon.Enabled = false;
            this.cbWeapon.FormattingEnabled = true;
            this.cbWeapon.Location = new System.Drawing.Point(71, 77);
            this.cbWeapon.Name = "cbWeapon";
            this.cbWeapon.Size = new System.Drawing.Size(154, 21);
            this.cbWeapon.TabIndex = 6;
            // 
            // cbCrosshair
            // 
            this.cbCrosshair.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCrosshair.DropDownWidth = 140;
            this.cbCrosshair.Enabled = false;
            this.cbCrosshair.FormattingEnabled = true;
            this.cbCrosshair.Location = new System.Drawing.Point(71, 104);
            this.cbCrosshair.Name = "cbCrosshair";
            this.cbCrosshair.Size = new System.Drawing.Size(154, 21);
            this.cbCrosshair.TabIndex = 7;
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(30, 53);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(35, 13);
            this.lblClass.TabIndex = 8;
            this.lblClass.Text = "Class:";
            // 
            // lblWeapon
            // 
            this.lblWeapon.AutoSize = true;
            this.lblWeapon.Location = new System.Drawing.Point(14, 80);
            this.lblWeapon.Name = "lblWeapon";
            this.lblWeapon.Size = new System.Drawing.Size(51, 13);
            this.lblWeapon.TabIndex = 9;
            this.lblWeapon.Text = "Weapon:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Crosshair:";
            // 
            // listViewChosenCrosshairs
            // 
            this.listViewChosenCrosshairs.FullRowSelect = true;
            this.listViewChosenCrosshairs.GridLines = true;
            this.listViewChosenCrosshairs.HideSelection = false;
            this.listViewChosenCrosshairs.Location = new System.Drawing.Point(12, 225);
            this.listViewChosenCrosshairs.Name = "listViewChosenCrosshairs";
            this.listViewChosenCrosshairs.Size = new System.Drawing.Size(837, 154);
            this.listViewChosenCrosshairs.TabIndex = 12;
            this.listViewChosenCrosshairs.UseCompatibleStateImageBehavior = false;
            this.listViewChosenCrosshairs.View = System.Windows.Forms.View.Details;
            // 
            // btnRemoveSelected
            // 
            this.btnRemoveSelected.Enabled = false;
            this.btnRemoveSelected.Image = global::TF2WeaponSpecificCrosshairs.Properties.Resources.cross;
            this.btnRemoveSelected.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemoveSelected.Location = new System.Drawing.Point(12, 197);
            this.btnRemoveSelected.Name = "btnRemoveSelected";
            this.btnRemoveSelected.Size = new System.Drawing.Size(113, 22);
            this.btnRemoveSelected.TabIndex = 14;
            this.btnRemoveSelected.Text = "Remove selected";
            this.btnRemoveSelected.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoveSelected.UseVisualStyleBackColor = true;
            this.btnRemoveSelected.Click += new System.EventHandler(this.btnRemoveSelected_Click);
            // 
            // btnAddCrosshair
            // 
            this.btnAddCrosshair.Enabled = false;
            this.btnAddCrosshair.Image = global::TF2WeaponSpecificCrosshairs.Properties.Resources.tick;
            this.btnAddCrosshair.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddCrosshair.Location = new System.Drawing.Point(231, 131);
            this.btnAddCrosshair.Name = "btnAddCrosshair";
            this.btnAddCrosshair.Size = new System.Drawing.Size(75, 29);
            this.btnAddCrosshair.TabIndex = 13;
            this.btnAddCrosshair.Text = "   Add";
            this.btnAddCrosshair.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddCrosshair.UseVisualStyleBackColor = true;
            this.btnAddCrosshair.Click += new System.EventHandler(this.btnAddCrosshair_Click);
            // 
            // pictureBoxCrosshair
            // 
            this.pictureBoxCrosshair.BackgroundImage = global::TF2WeaponSpecificCrosshairs.Properties.Resources.cp_badlands;
            this.pictureBoxCrosshair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBoxCrosshair.Image = global::TF2WeaponSpecificCrosshairs.Properties.Resources.TF2WSC;
            this.pictureBoxCrosshair.Location = new System.Drawing.Point(231, 50);
            this.pictureBoxCrosshair.Name = "pictureBoxCrosshair";
            this.pictureBoxCrosshair.Size = new System.Drawing.Size(75, 75);
            this.pictureBoxCrosshair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxCrosshair.TabIndex = 11;
            this.pictureBoxCrosshair.TabStop = false;
            // 
            // btnReload
            // 
            this.btnReload.Image = global::TF2WeaponSpecificCrosshairs.Properties.Resources.arrow_circle_double_135;
            this.btnReload.Location = new System.Drawing.Point(820, 12);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(32, 32);
            this.btnReload.TabIndex = 0;
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 551);
            this.Controls.Add(this.btnRemoveSelected);
            this.Controls.Add(this.btnAddCrosshair);
            this.Controls.Add(this.listViewChosenCrosshairs);
            this.Controls.Add(this.pictureBoxCrosshair);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblWeapon);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.cbCrosshair);
            this.Controls.Add(this.cbWeapon);
            this.Controls.Add(this.cbClass);
            this.Controls.Add(this.textBoxDebugger);
            this.Controls.Add(this.textBoxTF2Path);
            this.Controls.Add(this.lblTF2Path);
            this.Controls.Add(this.btnReload);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "TF2 Weapon Specific Crosshairs";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCrosshair)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.TextBox textBoxTF2Path;
        private System.Windows.Forms.Label lblTF2Path;
        private System.Windows.Forms.TextBox textBoxDebugger;
        private System.Windows.Forms.ComboBox cbClass;
        private System.Windows.Forms.ComboBox cbWeapon;
        private System.Windows.Forms.ComboBox cbCrosshair;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Label lblWeapon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBoxCrosshair;
        private System.Windows.Forms.ListView listViewChosenCrosshairs;
        private System.Windows.Forms.Button btnAddCrosshair;
        private System.Windows.Forms.Button btnRemoveSelected;
    }
}

