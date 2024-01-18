namespace WinFormsClient
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            ComboBoxSucursal = new CoreControlesUsuario.UI.UserControlComboBoxEdit();
            pictureEdit1 = new PictureEdit();
            btnSalir = new SimpleButton();
            btnAceptar = new SimpleButton();
            txtContraseña = new TextEdit();
            txtUsurio = new TextEdit();
            layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            emptySpaceItem8 = new DevExpress.XtraLayout.EmptySpaceItem();
            emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            simpleSeparator1 = new DevExpress.XtraLayout.SimpleSeparator();
            layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
            layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)layoutControl1).BeginInit();
            layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ComboBoxSucursal.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtContraseña.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtUsurio.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroup1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)simpleSeparator1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem6).BeginInit();
            SuspendLayout();
            // 
            // layoutControl1
            // 
            layoutControl1.Controls.Add(ComboBoxSucursal);
            layoutControl1.Controls.Add(pictureEdit1);
            layoutControl1.Controls.Add(btnSalir);
            layoutControl1.Controls.Add(btnAceptar);
            layoutControl1.Controls.Add(txtContraseña);
            layoutControl1.Controls.Add(txtUsurio);
            layoutControl1.Dock = DockStyle.Fill;
            layoutControl1.Location = new System.Drawing.Point(0, 0);
            layoutControl1.Margin = new Padding(4, 3, 4, 3);
            layoutControl1.Name = "layoutControl1";
            layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(846, 8, 650, 400);
            layoutControl1.Root = layoutControlGroup1;
            layoutControl1.Size = new System.Drawing.Size(500, 188);
            layoutControl1.TabIndex = 0;
            layoutControl1.Text = "layoutControl1";
            // 
            // ComboBoxSucursal
            // 
            ComboBoxSucursal.CharacterCasing = CharacterCasing.Upper;
            ComboBoxSucursal.EnterMoveNextControl = true;
            ComboBoxSucursal.IgnoreReadOnly = false;
            ComboBoxSucursal.Location = new System.Drawing.Point(183, 88);
            ComboBoxSucursal.Name = "ComboBoxSucursal";
            ComboBoxSucursal.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            ComboBoxSucursal.Properties.Appearance.Options.UseFont = true;
            ComboBoxSucursal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            ComboBoxSucursal.Properties.CharacterCasing = CharacterCasing.Upper;
            ComboBoxSucursal.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            ComboBoxSucursal.Size = new System.Drawing.Size(314, 24);
            ComboBoxSucursal.StyleController = layoutControl1;
            ComboBoxSucursal.TabIndex = 9;
            // 
            // pictureEdit1
            // 
            pictureEdit1.EditValue = resources.GetObject("pictureEdit1.EditValue");
            pictureEdit1.Location = new System.Drawing.Point(3, 28);
            pictureEdit1.Margin = new Padding(4, 3, 4, 3);
            pictureEdit1.Name = "pictureEdit1";
            pictureEdit1.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control;
            pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            pictureEdit1.Size = new System.Drawing.Size(102, 101);
            pictureEdit1.StyleController = layoutControl1;
            pictureEdit1.TabIndex = 8;
            // 
            // btnSalir
            // 
            btnSalir.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            btnSalir.Appearance.ForeColor = System.Drawing.Color.Blue;
            btnSalir.Appearance.Options.UseFont = true;
            btnSalir.Appearance.Options.UseForeColor = true;
            btnSalir.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnSalir.ImageOptions.Image");
            btnSalir.Location = new System.Drawing.Point(345, 147);
            btnSalir.Margin = new Padding(4, 3, 4, 3);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new System.Drawing.Size(152, 28);
            btnSalir.StyleController = layoutControl1;
            btnSalir.TabIndex = 7;
            btnSalir.Text = "&Salir";
            // 
            // btnAceptar
            // 
            btnAceptar.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            btnAceptar.Appearance.ForeColor = System.Drawing.Color.Blue;
            btnAceptar.Appearance.Options.UseFont = true;
            btnAceptar.Appearance.Options.UseForeColor = true;
            btnAceptar.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnAceptar.ImageOptions.Image");
            btnAceptar.Location = new System.Drawing.Point(187, 147);
            btnAceptar.Margin = new Padding(4, 3, 4, 3);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new System.Drawing.Size(154, 28);
            btnAceptar.StyleController = layoutControl1;
            btnAceptar.TabIndex = 6;
            btnAceptar.Text = "&Aceptar";
            btnAceptar.Click += btnAceptar_Click;
            // 
            // txtContraseña
            // 
            txtContraseña.EnterMoveNextControl = true;
            txtContraseña.Location = new System.Drawing.Point(183, 58);
            txtContraseña.Margin = new Padding(4, 3, 4, 3);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            txtContraseña.Properties.Appearance.Options.UseFont = true;
            txtContraseña.Properties.PasswordChar = '*';
            txtContraseña.Size = new System.Drawing.Size(314, 26);
            txtContraseña.StyleController = layoutControl1;
            txtContraseña.TabIndex = 5;
            // 
            // txtUsurio
            // 
            txtUsurio.EditValue = "";
            txtUsurio.EnterMoveNextControl = true;
            txtUsurio.Location = new System.Drawing.Point(183, 28);
            txtUsurio.Margin = new Padding(4, 3, 4, 3);
            txtUsurio.Name = "txtUsurio";
            txtUsurio.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            txtUsurio.Properties.Appearance.Options.UseFont = true;
            txtUsurio.Properties.CharacterCasing = CharacterCasing.Upper;
            txtUsurio.Size = new System.Drawing.Size(314, 26);
            txtUsurio.StyleController = layoutControl1;
            txtUsurio.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            layoutControlGroup1.GroupBordersVisible = false;
            layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem1, layoutControlItem2, layoutControlItem3, layoutControlItem4, emptySpaceItem8, emptySpaceItem2, simpleSeparator1, layoutControlItem5, emptySpaceItem1, emptySpaceItem3, emptySpaceItem4, layoutControlItem6 });
            layoutControlGroup1.Name = "Root";
            layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(1, 1, 1, 1);
            layoutControlGroup1.Size = new System.Drawing.Size(500, 188);
            layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            layoutControlItem1.AppearanceItemCaption.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            layoutControlItem1.AppearanceItemCaption.Options.UseFont = true;
            layoutControlItem1.AppearanceItemCaption.Options.UseTextOptions = true;
            layoutControlItem1.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            layoutControlItem1.Control = txtUsurio;
            layoutControlItem1.Location = new System.Drawing.Point(106, 25);
            layoutControlItem1.Name = "layoutControlItem1";
            layoutControlItem1.Size = new System.Drawing.Size(392, 30);
            layoutControlItem1.Text = "Usuario";
            layoutControlItem1.TextSize = new System.Drawing.Size(70, 19);
            // 
            // layoutControlItem2
            // 
            layoutControlItem2.AppearanceItemCaption.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            layoutControlItem2.AppearanceItemCaption.Options.UseFont = true;
            layoutControlItem2.AppearanceItemCaption.Options.UseTextOptions = true;
            layoutControlItem2.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            layoutControlItem2.Control = txtContraseña;
            layoutControlItem2.Location = new System.Drawing.Point(106, 55);
            layoutControlItem2.Name = "layoutControlItem2";
            layoutControlItem2.Size = new System.Drawing.Size(392, 30);
            layoutControlItem2.Text = "Contraseña";
            layoutControlItem2.TextSize = new System.Drawing.Size(70, 19);
            // 
            // layoutControlItem3
            // 
            layoutControlItem3.Control = btnAceptar;
            layoutControlItem3.Location = new System.Drawing.Point(184, 144);
            layoutControlItem3.Name = "layoutControlItem3";
            layoutControlItem3.Size = new System.Drawing.Size(158, 32);
            layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            layoutControlItem4.Control = btnSalir;
            layoutControlItem4.Location = new System.Drawing.Point(342, 144);
            layoutControlItem4.Name = "layoutControlItem4";
            layoutControlItem4.Size = new System.Drawing.Size(156, 32);
            layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            layoutControlItem4.TextVisible = false;
            // 
            // emptySpaceItem8
            // 
            emptySpaceItem8.AllowHotTrack = false;
            emptySpaceItem8.Location = new System.Drawing.Point(0, 176);
            emptySpaceItem8.Name = "emptySpaceItem8";
            emptySpaceItem8.Size = new System.Drawing.Size(498, 10);
            emptySpaceItem8.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            emptySpaceItem2.AllowHotTrack = false;
            emptySpaceItem2.Location = new System.Drawing.Point(106, 113);
            emptySpaceItem2.Name = "emptySpaceItem2";
            emptySpaceItem2.Size = new System.Drawing.Size(392, 17);
            emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // simpleSeparator1
            // 
            simpleSeparator1.AllowHotTrack = false;
            simpleSeparator1.Location = new System.Drawing.Point(0, 130);
            simpleSeparator1.Name = "simpleSeparator1";
            simpleSeparator1.Size = new System.Drawing.Size(498, 4);
            simpleSeparator1.Spacing = new DevExpress.XtraLayout.Utils.Padding(1, 1, 1, 1);
            // 
            // layoutControlItem5
            // 
            layoutControlItem5.Control = pictureEdit1;
            layoutControlItem5.Location = new System.Drawing.Point(0, 25);
            layoutControlItem5.Name = "layoutControlItem5";
            layoutControlItem5.Size = new System.Drawing.Size(106, 105);
            layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            layoutControlItem5.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            emptySpaceItem1.AllowHotTrack = false;
            emptySpaceItem1.Location = new System.Drawing.Point(0, 0);
            emptySpaceItem1.Name = "emptySpaceItem1";
            emptySpaceItem1.Size = new System.Drawing.Size(498, 25);
            emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem3
            // 
            emptySpaceItem3.AllowHotTrack = false;
            emptySpaceItem3.Location = new System.Drawing.Point(0, 144);
            emptySpaceItem3.Name = "emptySpaceItem3";
            emptySpaceItem3.Size = new System.Drawing.Size(184, 32);
            emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem4
            // 
            emptySpaceItem4.AllowHotTrack = false;
            emptySpaceItem4.Location = new System.Drawing.Point(0, 134);
            emptySpaceItem4.Name = "emptySpaceItem4";
            emptySpaceItem4.Size = new System.Drawing.Size(498, 10);
            emptySpaceItem4.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem6
            // 
            layoutControlItem6.AppearanceItemCaption.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            layoutControlItem6.AppearanceItemCaption.Options.UseFont = true;
            layoutControlItem6.AppearanceItemCaption.Options.UseTextOptions = true;
            layoutControlItem6.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            layoutControlItem6.Control = ComboBoxSucursal;
            layoutControlItem6.Location = new System.Drawing.Point(106, 85);
            layoutControlItem6.Name = "layoutControlItem6";
            layoutControlItem6.Size = new System.Drawing.Size(392, 28);
            layoutControlItem6.Text = "Sucursal";
            layoutControlItem6.TextSize = new System.Drawing.Size(70, 19);
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(500, 188);
            Controls.Add(layoutControl1);
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio Sesión";
            Load += FormLogin_Load;
            ((System.ComponentModel.ISupportInitialize)layoutControl1).EndInit();
            layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ComboBoxSucursal.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtContraseña.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtUsurio.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroup1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem4).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem8).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem2).EndInit();
            ((System.ComponentModel.ISupportInitialize)simpleSeparator1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem5).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem3).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem4).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem6).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private TextEdit txtContraseña;
        private TextEdit txtUsurio;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private SimpleButton btnSalir;
        private SimpleButton btnAceptar;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem8;
        private PictureEdit pictureEdit1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.SimpleSeparator simpleSeparator1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
        private CoreControlesUsuario.UI.UserControlComboBoxEdit ComboBoxSucursal;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
    }
}