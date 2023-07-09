namespace CAFETARIA_MANAGEMENT
{
    partial class Dashboard
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
            Guna.UI2.AnimatorNS.Animation animation1 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLogOut = new System.Windows.Forms.LinkLabel();
            this.btnRemove = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.btnMake = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Transition1 = new Guna.UI2.WinForms.Guna2Transition();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse5 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse6 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btn_minimize = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.uC_RemoveMeals1 = new CAFETARIA_MANAGEMENT.AllUserControls.UC_RemoveMeals();
            this.uC_UpdateMeals1 = new CAFETARIA_MANAGEMENT.AllUserControls.UC_UpdateMeals();
            this.uC_Makesale1 = new CAFETARIA_MANAGEMENT.AllUserControls.UC_Makesale();
            this.uC_Addmeals1 = new CAFETARIA_MANAGEMENT.AllUserControls.UC_Addmeals();
            this.uC_welcome1 = new CAFETARIA_MANAGEMENT.AllUserControls.UC_welcome();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.linkLogOut);
            this.panel1.Controls.Add(this.btnRemove);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btnMake);
            this.guna2Transition1.SetDecoration(this.panel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel1.Location = new System.Drawing.Point(12, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 470);
            this.panel1.TabIndex = 0;
            // 
            // linkLogOut
            // 
            this.linkLogOut.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.linkLogOut, Guna.UI2.AnimatorNS.DecorationType.None);
            this.linkLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLogOut.LinkColor = System.Drawing.Color.Red;
            this.linkLogOut.Location = new System.Drawing.Point(54, 400);
            this.linkLogOut.Name = "linkLogOut";
            this.linkLogOut.Size = new System.Drawing.Size(68, 20);
            this.linkLogOut.TabIndex = 1;
            this.linkLogOut.TabStop = true;
            this.linkLogOut.Text = "LogOut";
            this.linkLogOut.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLogOut_LinkClicked);
            // 
            // btnRemove
            // 
            this.btnRemove.BorderRadius = 15;
            this.btnRemove.CheckedState.Parent = this.btnRemove;
            this.btnRemove.CustomImages.Parent = this.btnRemove;
            this.guna2Transition1.SetDecoration(this.btnRemove, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnRemove.FillColor = System.Drawing.Color.MidnightBlue;
            this.btnRemove.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.HoverState.Parent = this.btnRemove;
            this.btnRemove.Location = new System.Drawing.Point(17, 269);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.ShadowDecoration.Parent = this.btnRemove;
            this.btnRemove.Size = new System.Drawing.Size(194, 45);
            this.btnRemove.TabIndex = 0;
            this.btnRemove.Text = "Remove Meals";
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BorderRadius = 15;
            this.btnUpdate.CheckedState.Parent = this.btnUpdate;
            this.btnUpdate.CustomImages.Parent = this.btnUpdate;
            this.guna2Transition1.SetDecoration(this.btnUpdate, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnUpdate.FillColor = System.Drawing.Color.MidnightBlue;
            this.btnUpdate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.HoverState.Parent = this.btnUpdate;
            this.btnUpdate.Location = new System.Drawing.Point(17, 201);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.ShadowDecoration.Parent = this.btnUpdate;
            this.btnUpdate.Size = new System.Drawing.Size(194, 45);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "Update Meals";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BorderRadius = 15;
            this.btnAdd.CheckedState.Parent = this.btnAdd;
            this.btnAdd.CustomImages.Parent = this.btnAdd;
            this.guna2Transition1.SetDecoration(this.btnAdd, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnAdd.FillColor = System.Drawing.Color.MidnightBlue;
            this.btnAdd.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.HoverState.Parent = this.btnAdd;
            this.btnAdd.Location = new System.Drawing.Point(17, 135);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ShadowDecoration.Parent = this.btnAdd;
            this.btnAdd.Size = new System.Drawing.Size(194, 45);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add Meals";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnMake
            // 
            this.btnMake.BorderRadius = 15;
            this.btnMake.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnMake.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnMake.CheckedState.Parent = this.btnMake;
            this.btnMake.CustomImages.Parent = this.btnMake;
            this.guna2Transition1.SetDecoration(this.btnMake, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnMake.FillColor = System.Drawing.Color.MidnightBlue;
            this.btnMake.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMake.ForeColor = System.Drawing.Color.White;
            this.btnMake.HoverState.Parent = this.btnMake;
            this.btnMake.Location = new System.Drawing.Point(17, 67);
            this.btnMake.Name = "btnMake";
            this.btnMake.ShadowDecoration.Parent = this.btnMake;
            this.btnMake.Size = new System.Drawing.Size(194, 45);
            this.btnMake.TabIndex = 0;
            this.btnMake.Text = "Make a Sale";
            this.btnMake.Click += new System.EventHandler(this.btnMake_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel2.Controls.Add(this.uC_RemoveMeals1);
            this.panel2.Controls.Add(this.uC_UpdateMeals1);
            this.panel2.Controls.Add(this.uC_Makesale1);
            this.panel2.Controls.Add(this.uC_Addmeals1);
            this.panel2.Controls.Add(this.uC_welcome1);
            this.guna2Transition1.SetDecoration(this.panel2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel2.Location = new System.Drawing.Point(211, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(844, 470);
            this.panel2.TabIndex = 1;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 30;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.BorderRadius = 30;
            this.guna2Elipse3.TargetControl = this.panel2;
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.BorderRadius = 30;
            this.guna2Elipse4.TargetControl = this.panel2;
            // 
            // guna2Transition1
            // 
            this.guna2Transition1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.VertSlide;
            this.guna2Transition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.guna2Transition1.DefaultAnimation = animation1;
            this.guna2Transition1.MaxAnimationTime = 3000;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.label1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Unispace", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Honeydew;
            this.label1.Location = new System.Drawing.Point(50, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(843, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "MURANGA UNIVERSITY CAFETERIA MANAGEMENT SYSTEM\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.label2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Forte", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(385, 514);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(282, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Designed by GIBSON";
            // 
            // btnExit
            // 
            this.btnExit.BorderRadius = 14;
            this.btnExit.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.btnExit.CheckedState.Parent = this.btnExit;
            this.btnExit.CustomImages.Parent = this.btnExit;
            this.guna2Transition1.SetDecoration(this.btnExit, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnExit.FillColor = System.Drawing.Color.DarkRed;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.HoverState.Parent = this.btnExit;
            this.btnExit.Location = new System.Drawing.Point(862, 513);
            this.btnExit.Name = "btnExit";
            this.btnExit.ShadowDecoration.Parent = this.btnExit;
            this.btnExit.Size = new System.Drawing.Size(109, 32);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "EXIT";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // guna2Elipse5
            // 
            this.guna2Elipse5.BorderRadius = 30;
            this.guna2Elipse5.TargetControl = this.panel2;
            // 
            // guna2Elipse6
            // 
            this.guna2Elipse6.BorderRadius = 30;
            this.guna2Elipse6.TargetControl = this.panel2;
            // 
            // btn_minimize
            // 
            this.guna2Transition1.SetDecoration(this.btn_minimize, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btn_minimize.Image = global::CAFETARIA_MANAGEMENT.Properties.Resources.minimize;
            this.btn_minimize.Location = new System.Drawing.Point(938, 8);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.Size = new System.Drawing.Size(33, 23);
            this.btn_minimize.TabIndex = 5;
            this.btn_minimize.UseVisualStyleBackColor = true;
            this.btn_minimize.Click += new System.EventHandler(this.btn_minimize_Click);
            // 
            // btn_close
            // 
            this.guna2Transition1.SetDecoration(this.btn_close, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btn_close.ForeColor = System.Drawing.Color.SlateBlue;
            this.btn_close.Image = global::CAFETARIA_MANAGEMENT.Properties.Resources.icons8_macos_close_30;
            this.btn_close.Location = new System.Drawing.Point(977, 8);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(33, 23);
            this.btn_close.TabIndex = 5;
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // uC_RemoveMeals1
            // 
            this.uC_RemoveMeals1.BackColor = System.Drawing.Color.MediumPurple;
            this.guna2Transition1.SetDecoration(this.uC_RemoveMeals1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.uC_RemoveMeals1.Location = new System.Drawing.Point(0, 0);
            this.uC_RemoveMeals1.Name = "uC_RemoveMeals1";
            this.uC_RemoveMeals1.Size = new System.Drawing.Size(812, 470);
            this.uC_RemoveMeals1.TabIndex = 4;
            // 
            // uC_UpdateMeals1
            // 
            this.uC_UpdateMeals1.BackColor = System.Drawing.Color.MediumPurple;
            this.guna2Transition1.SetDecoration(this.uC_UpdateMeals1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.uC_UpdateMeals1.Location = new System.Drawing.Point(0, -3);
            this.uC_UpdateMeals1.Name = "uC_UpdateMeals1";
            this.uC_UpdateMeals1.Size = new System.Drawing.Size(815, 473);
            this.uC_UpdateMeals1.TabIndex = 3;
            // 
            // uC_Makesale1
            // 
            this.uC_Makesale1.BackColor = System.Drawing.Color.MediumPurple;
            this.guna2Transition1.SetDecoration(this.uC_Makesale1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.uC_Makesale1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uC_Makesale1.Location = new System.Drawing.Point(0, -13);
            this.uC_Makesale1.Margin = new System.Windows.Forms.Padding(4);
            this.uC_Makesale1.Name = "uC_Makesale1";
            this.uC_Makesale1.Size = new System.Drawing.Size(819, 483);
            this.uC_Makesale1.TabIndex = 2;
            this.uC_Makesale1.Load += new System.EventHandler(this.uC_Makesale1_Load);
            // 
            // uC_Addmeals1
            // 
            this.uC_Addmeals1.BackColor = System.Drawing.Color.MediumPurple;
            this.guna2Transition1.SetDecoration(this.uC_Addmeals1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.uC_Addmeals1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uC_Addmeals1.Location = new System.Drawing.Point(0, 0);
            this.uC_Addmeals1.Margin = new System.Windows.Forms.Padding(4);
            this.uC_Addmeals1.Name = "uC_Addmeals1";
            this.uC_Addmeals1.Size = new System.Drawing.Size(819, 483);
            this.uC_Addmeals1.TabIndex = 1;
            // 
            // uC_welcome1
            // 
            this.uC_welcome1.BackColor = System.Drawing.Color.White;
            this.guna2Transition1.SetDecoration(this.uC_welcome1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.uC_welcome1.Location = new System.Drawing.Point(-51, -3);
            this.uC_welcome1.Name = "uC_welcome1";
            this.uC_welcome1.Size = new System.Drawing.Size(870, 470);
            this.uC_welcome1.TabIndex = 0;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(1022, 546);
            this.Controls.Add(this.btn_minimize);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.guna2Transition1.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnRemove;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2Button btnMake;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.LinkLabel linkLogOut;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private AllUserControls.UC_welcome uC_welcome1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private AllUserControls.UC_Addmeals uC_Addmeals1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private AllUserControls.UC_Makesale uC_Makesale1;
        private Guna.UI2.WinForms.Guna2Transition guna2Transition1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse5;
        private AllUserControls.UC_UpdateMeals uC_UpdateMeals1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse6;
        private AllUserControls.UC_RemoveMeals uC_RemoveMeals1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btnExit;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_minimize;
    }
}