namespace Lab2B
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Hairdresser = new System.Windows.Forms.GroupBox();
            this.radioLaura = new System.Windows.Forms.RadioButton();
            this.radioSue = new System.Windows.Forms.RadioButton();
            this.radioRon = new System.Windows.Forms.RadioButton();
            this.radioPat = new System.Windows.Forms.RadioButton();
            this.radioJane = new System.Windows.Forms.RadioButton();
            this.Services = new System.Windows.Forms.GroupBox();
            this.checkExtensions = new System.Windows.Forms.CheckBox();
            this.checkHighlights = new System.Windows.Forms.CheckBox();
            this.checkColour = new System.Windows.Forms.CheckBox();
            this.checkCut = new System.Windows.Forms.CheckBox();
            this.ClientType = new System.Windows.Forms.GroupBox();
            this.radioSenior = new System.Windows.Forms.RadioButton();
            this.radioStudent = new System.Windows.Forms.RadioButton();
            this.radioChild = new System.Windows.Forms.RadioButton();
            this.radioStandard = new System.Windows.Forms.RadioButton();
            this.ClientVisits = new System.Windows.Forms.GroupBox();
            this.textBoxClient = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.calculate = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.totalprice = new System.Windows.Forms.Label();
            this.answerLabel = new System.Windows.Forms.Label();
            this.Hairdresser.SuspendLayout();
            this.Services.SuspendLayout();
            this.ClientType.SuspendLayout();
            this.ClientVisits.SuspendLayout();
            this.SuspendLayout();
            // 
            // Hairdresser
            // 
            resources.ApplyResources(this.Hairdresser, "Hairdresser");
            this.Hairdresser.Controls.Add(this.radioLaura);
            this.Hairdresser.Controls.Add(this.radioSue);
            this.Hairdresser.Controls.Add(this.radioRon);
            this.Hairdresser.Controls.Add(this.radioPat);
            this.Hairdresser.Controls.Add(this.radioJane);
            this.Hairdresser.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Hairdresser.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Hairdresser.Name = "Hairdresser";
            this.Hairdresser.TabStop = false;
            this.Hairdresser.Enter += new System.EventHandler(this.Hairdresser_Enter);
            // 
            // radioLaura
            // 
            this.radioLaura.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton;
            resources.ApplyResources(this.radioLaura, "radioLaura");
            this.radioLaura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioLaura.Name = "radioLaura";
            this.radioLaura.UseVisualStyleBackColor = true;
            // 
            // radioSue
            // 
            this.radioSue.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton;
            resources.ApplyResources(this.radioSue, "radioSue");
            this.radioSue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioSue.Name = "radioSue";
            this.radioSue.UseVisualStyleBackColor = true;
            // 
            // radioRon
            // 
            this.radioRon.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton;
            resources.ApplyResources(this.radioRon, "radioRon");
            this.radioRon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioRon.Name = "radioRon";
            this.radioRon.UseVisualStyleBackColor = true;
            // 
            // radioPat
            // 
            this.radioPat.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton;
            resources.ApplyResources(this.radioPat, "radioPat");
            this.radioPat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioPat.Name = "radioPat";
            this.radioPat.UseVisualStyleBackColor = true;
            // 
            // radioJane
            // 
            this.radioJane.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton;
            resources.ApplyResources(this.radioJane, "radioJane");
            this.radioJane.Checked = true;
            this.radioJane.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioJane.Name = "radioJane";
            this.radioJane.TabStop = true;
            this.radioJane.UseVisualStyleBackColor = true;
            // 
            // Services
            // 
            resources.ApplyResources(this.Services, "Services");
            this.Services.Controls.Add(this.checkExtensions);
            this.Services.Controls.Add(this.checkHighlights);
            this.Services.Controls.Add(this.checkColour);
            this.Services.Controls.Add(this.checkCut);
            this.Services.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Services.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Services.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Services.Name = "Services";
            this.Services.TabStop = false;
            // 
            // checkExtensions
            // 
            this.checkExtensions.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            resources.ApplyResources(this.checkExtensions, "checkExtensions");
            this.checkExtensions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkExtensions.Name = "checkExtensions";
            this.checkExtensions.UseVisualStyleBackColor = true;
            // 
            // checkHighlights
            // 
            this.checkHighlights.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            resources.ApplyResources(this.checkHighlights, "checkHighlights");
            this.checkHighlights.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkHighlights.Name = "checkHighlights";
            this.checkHighlights.UseVisualStyleBackColor = true;
            // 
            // checkColour
            // 
            this.checkColour.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            resources.ApplyResources(this.checkColour, "checkColour");
            this.checkColour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkColour.Name = "checkColour";
            this.checkColour.UseVisualStyleBackColor = true;
            // 
            // checkCut
            // 
            this.checkCut.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            resources.ApplyResources(this.checkCut, "checkCut");
            this.checkCut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkCut.Name = "checkCut";
            this.checkCut.UseVisualStyleBackColor = true;
            // 
            // ClientType
            // 
            this.ClientType.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientType.Controls.Add(this.radioSenior);
            this.ClientType.Controls.Add(this.radioStudent);
            this.ClientType.Controls.Add(this.radioChild);
            this.ClientType.Controls.Add(this.radioStandard);
            this.ClientType.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ClientType.FlatStyle = System.Windows.Forms.FlatStyle.System;
            resources.ApplyResources(this.ClientType, "ClientType");
            this.ClientType.Name = "ClientType";
            this.ClientType.TabStop = false;
            // 
            // radioSenior
            // 
            this.radioSenior.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton;
            resources.ApplyResources(this.radioSenior, "radioSenior");
            this.radioSenior.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioSenior.Name = "radioSenior";
            this.radioSenior.UseVisualStyleBackColor = true;
            // 
            // radioStudent
            // 
            this.radioStudent.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton;
            resources.ApplyResources(this.radioStudent, "radioStudent");
            this.radioStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioStudent.Name = "radioStudent";
            this.radioStudent.UseVisualStyleBackColor = true;
            // 
            // radioChild
            // 
            this.radioChild.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton;
            resources.ApplyResources(this.radioChild, "radioChild");
            this.radioChild.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioChild.Name = "radioChild";
            this.radioChild.UseVisualStyleBackColor = true;
            // 
            // radioStandard
            // 
            this.radioStandard.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton;
            resources.ApplyResources(this.radioStandard, "radioStandard");
            this.radioStandard.Checked = true;
            this.radioStandard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioStandard.Name = "radioStandard";
            this.radioStandard.TabStop = true;
            this.radioStandard.UseVisualStyleBackColor = true;
            // 
            // ClientVisits
            // 
            resources.ApplyResources(this.ClientVisits, "ClientVisits");
            this.ClientVisits.Controls.Add(this.textBoxClient);
            this.ClientVisits.Controls.Add(this.label3);
            this.ClientVisits.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ClientVisits.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ClientVisits.Name = "ClientVisits";
            this.ClientVisits.TabStop = false;
            // 
            // textBoxClient
            // 
            this.textBoxClient.AccessibleRole = System.Windows.Forms.AccessibleRole.Dial;
            this.textBoxClient.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBoxClient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.textBoxClient, "textBoxClient");
            this.textBoxClient.Name = "textBoxClient";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // calculate
            // 
            this.calculate.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.calculate.BackColor = System.Drawing.Color.MediumBlue;
            resources.ApplyResources(this.calculate, "calculate");
            this.calculate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.calculate.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.calculate.FlatAppearance.BorderSize = 2;
            this.calculate.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.calculate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.calculate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.calculate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.calculate.Name = "calculate";
            this.calculate.UseVisualStyleBackColor = false;
            this.calculate.Click += new System.EventHandler(this.button1_Click);
            // 
            // clear
            // 
            this.clear.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.clear.BackColor = System.Drawing.Color.MediumBlue;
            this.clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clear.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.clear.FlatAppearance.BorderSize = 2;
            this.clear.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.clear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            resources.ApplyResources(this.clear, "clear");
            this.clear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.clear.Name = "clear";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.button2_Click);
            // 
            // exit
            // 
            this.exit.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.exit.BackColor = System.Drawing.Color.MediumBlue;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.exit.FlatAppearance.BorderSize = 2;
            this.exit.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            resources.ApplyResources(this.exit, "exit");
            this.exit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exit.Name = "exit";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.button3_Click);
            // 
            // totalprice
            // 
            resources.ApplyResources(this.totalprice, "totalprice");
            this.totalprice.Name = "totalprice";
            // 
            // answerLabel
            // 
            resources.ApplyResources(this.answerLabel, "answerLabel");
            this.answerLabel.Name = "answerLabel";
            this.answerLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.Controls.Add(this.answerLabel);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.totalprice);
            this.Controls.Add(this.ClientType);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.ClientVisits);
            this.Controls.Add(this.Services);
            this.Controls.Add(this.Hairdresser);
            this.Controls.Add(this.clear);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Hairdresser.ResumeLayout(false);
            this.Hairdresser.PerformLayout();
            this.Services.ResumeLayout(false);
            this.Services.PerformLayout();
            this.ClientType.ResumeLayout(false);
            this.ClientType.PerformLayout();
            this.ClientVisits.ResumeLayout(false);
            this.ClientVisits.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Hairdresser;
        private System.Windows.Forms.GroupBox Services;
        private System.Windows.Forms.GroupBox ClientType;
        private System.Windows.Forms.GroupBox ClientVisits;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.RadioButton radioLaura;
        private System.Windows.Forms.RadioButton radioSue;
        private System.Windows.Forms.RadioButton radioRon;
        private System.Windows.Forms.RadioButton radioPat;
        private System.Windows.Forms.RadioButton radioJane;
        private System.Windows.Forms.CheckBox checkExtensions;
        private System.Windows.Forms.CheckBox checkHighlights;
        private System.Windows.Forms.CheckBox checkColour;
        private System.Windows.Forms.CheckBox checkCut;
        private System.Windows.Forms.RadioButton radioSenior;
        private System.Windows.Forms.RadioButton radioStudent;
        private System.Windows.Forms.RadioButton radioChild;
        private System.Windows.Forms.RadioButton radioStandard;
        private System.Windows.Forms.TextBox textBoxClient;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label totalprice;
        private System.Windows.Forms.Label answerLabel;
    }
}

