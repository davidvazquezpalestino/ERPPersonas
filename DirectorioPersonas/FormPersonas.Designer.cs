namespace WinFormsClient
{
    partial class FormPersonas
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
            components = new System.ComponentModel.Container();
            layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            ComboBoxSucursales = new DotNet.CoreControlesUsuario.UI.UserControlComboBoxEdit();
            ButtonQuery = new SimpleButton();
            ButtonUpdate = new SimpleButton();
            gridControlCuentas = new DevExpress.XtraGrid.GridControl();
            creditoBindingSource = new BindingSource(components);
            gridViewCuentas = new DevExpress.XtraGrid.Views.Grid.GridView();
            ColClasificacionCredito = new DevExpress.XtraGrid.Columns.GridColumn();
            ColPeriodo = new DevExpress.XtraGrid.Columns.GridColumn();
            colSucursal = new DevExpress.XtraGrid.Columns.GridColumn();
            colSocio = new DevExpress.XtraGrid.Columns.GridColumn();
            colCredito = new DevExpress.XtraGrid.Columns.GridColumn();
            colRazonSocial = new DevExpress.XtraGrid.Columns.GridColumn();
            colNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            colRFC = new DevExpress.XtraGrid.Columns.GridColumn();
            colRegimenFiscal = new DevExpress.XtraGrid.Columns.GridColumn();
            colCodigoPostal = new DevExpress.XtraGrid.Columns.GridColumn();
            colMail = new DevExpress.XtraGrid.Columns.GridColumn();
            repositoryItemButtonEdit1 = new RepositoryItemButtonEdit();
            layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            Root = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            personaBindingSource = new BindingSource(components);
            barManager1 = new DevExpress.XtraBars.BarManager(components);
            bar3 = new DevExpress.XtraBars.Bar();
            barButton = new DevExpress.XtraBars.BarButtonItem();
            barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            barEditItem1 = new DevExpress.XtraBars.BarEditItem();
            repositoryItemHypertextLabel1 = new RepositoryItemHypertextLabel();
            barEditItem2 = new DevExpress.XtraBars.BarEditItem();
            repositoryItemHyperLinkEdit1 = new RepositoryItemHyperLinkEdit();
            ((System.ComponentModel.ISupportInitialize)layoutControl1).BeginInit();
            layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ComboBoxSucursales.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridControlCuentas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)creditoBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridViewCuentas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemButtonEdit1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Root).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)personaBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)barManager1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemHypertextLabel1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemHyperLinkEdit1).BeginInit();
            SuspendLayout();
            // 
            // layoutControl1
            // 
            layoutControl1.Controls.Add(ComboBoxSucursales);
            layoutControl1.Controls.Add(ButtonQuery);
            layoutControl1.Controls.Add(ButtonUpdate);
            layoutControl1.Controls.Add(gridControlCuentas);
            layoutControl1.Dock = DockStyle.Fill;
            layoutControl1.HiddenItems.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem3 });
            layoutControl1.Location = new System.Drawing.Point(0, 0);
            layoutControl1.Name = "layoutControl1";
            layoutControl1.Root = Root;
            layoutControl1.Size = new System.Drawing.Size(1045, 592);
            layoutControl1.TabIndex = 0;
            layoutControl1.Text = "layoutControl1";
            // 
            // ComboBoxSucursales
            // 
            ComboBoxSucursales.CharacterCasing = CharacterCasing.Upper;
            ComboBoxSucursales.EnterMoveNextControl = true;
            ComboBoxSucursales.IgnoreReadOnly = false;
            ComboBoxSucursales.Location = new System.Drawing.Point(74, 3);
            ComboBoxSucursales.Name = "ComboBoxSucursales";
            ComboBoxSucursales.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            ComboBoxSucursales.Properties.Appearance.Options.UseFont = true;
            ComboBoxSucursales.Properties.Buttons.AddRange(new EditorButton[] { new EditorButton(ButtonPredefines.Combo) });
            ComboBoxSucursales.Properties.CharacterCasing = CharacterCasing.Upper;
            ComboBoxSucursales.Properties.TextEditStyle = TextEditStyles.DisableTextEditor;
            ComboBoxSucursales.Size = new System.Drawing.Size(159, 26);
            ComboBoxSucursales.StyleController = layoutControl1;
            ComboBoxSucursales.TabIndex = 4;
            // 
            // ButtonQuery
            // 
            ButtonQuery.Appearance.BackColor = DXSkinColors.FillColors.Primary;
            ButtonQuery.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            ButtonQuery.Appearance.Options.UseBackColor = true;
            ButtonQuery.Appearance.Options.UseFont = true;
            ButtonQuery.Location = new System.Drawing.Point(780, 3);
            ButtonQuery.Name = "ButtonQuery";
            ButtonQuery.Size = new System.Drawing.Size(124, 28);
            ButtonQuery.StyleController = layoutControl1;
            ButtonQuery.TabIndex = 0;
            ButtonQuery.Text = "Actualizar";
            ButtonQuery.Visible = false;
            ButtonQuery.Click += ButtonQuery_Click;
            // 
            // ButtonUpdate
            // 
            ButtonUpdate.Appearance.BackColor = DXSkinColors.FillColors.Primary;
            ButtonUpdate.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            ButtonUpdate.Appearance.Options.UseBackColor = true;
            ButtonUpdate.Appearance.Options.UseFont = true;
            ButtonUpdate.Location = new System.Drawing.Point(895, 3);
            ButtonUpdate.Name = "ButtonUpdate";
            ButtonUpdate.Size = new System.Drawing.Size(147, 26);
            ButtonUpdate.StyleController = layoutControl1;
            ButtonUpdate.TabIndex = 2;
            ButtonUpdate.Text = "Guardar";
            ButtonUpdate.Click += ButtonGuardar_Click;
            // 
            // gridControlCuentas
            // 
            gridControlCuentas.DataSource = creditoBindingSource;
            gridControlCuentas.Location = new System.Drawing.Point(3, 33);
            gridControlCuentas.MainView = gridViewCuentas;
            gridControlCuentas.Name = "gridControlCuentas";
            gridControlCuentas.RepositoryItems.AddRange(new RepositoryItem[] { repositoryItemButtonEdit1 });
            gridControlCuentas.Size = new System.Drawing.Size(1039, 556);
            gridControlCuentas.TabIndex = 3;
            gridControlCuentas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridViewCuentas });
            // 
            // gridViewCuentas
            // 
            gridViewCuentas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { ColClasificacionCredito, ColPeriodo, colSucursal, colSocio, colCredito, colRazonSocial, colNombre, colRFC, colRegimenFiscal, colCodigoPostal, colMail });
            gridViewCuentas.GridControl = gridControlCuentas;
            gridViewCuentas.Name = "gridViewCuentas";
            gridViewCuentas.OptionsSelection.MultiSelect = true;
            gridViewCuentas.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect;
            gridViewCuentas.OptionsView.ShowAutoFilterRow = true;
            gridViewCuentas.OptionsView.ShowFooter = true;
            gridViewCuentas.OptionsView.ShowGroupPanel = false;
            // 
            // ColClasificacionCredito
            // 
            ColClasificacionCredito.Caption = "Clasificación";
            ColClasificacionCredito.FieldName = "TipoCredito.Descripcion";
            ColClasificacionCredito.Name = "ColClasificacionCredito";
            ColClasificacionCredito.Visible = true;
            ColClasificacionCredito.VisibleIndex = 0;
            ColClasificacionCredito.Width = 65;
            // 
            // ColPeriodo
            // 
            ColPeriodo.Caption = "Fecha";
            ColPeriodo.FieldName = "FechaEntrega";
            ColPeriodo.Name = "ColPeriodo";
            ColPeriodo.ToolTip = "Fecha de desembolso";
            ColPeriodo.Visible = true;
            ColPeriodo.VisibleIndex = 1;
            ColPeriodo.Width = 65;
            // 
            // colSucursal
            // 
            colSucursal.Caption = "Sucursal";
            colSucursal.FieldName = "Socio.Sucursal.Descripcion";
            colSucursal.Name = "colSucursal";
            colSucursal.OptionsColumn.AllowEdit = false;
            colSucursal.Visible = true;
            colSucursal.VisibleIndex = 2;
            colSucursal.Width = 65;
            // 
            // colSocio
            // 
            colSocio.Caption = "Socio";
            colSocio.FieldName = "Socio.Codigo";
            colSocio.Name = "colSocio";
            colSocio.OptionsColumn.AllowEdit = false;
            colSocio.Visible = true;
            colSocio.VisibleIndex = 3;
            colSocio.Width = 65;
            // 
            // colCredito
            // 
            colCredito.Caption = "Crédito";
            colCredito.FieldName = "Codigo";
            colCredito.Name = "colCredito";
            colCredito.OptionsColumn.AllowEdit = false;
            colCredito.Visible = true;
            colCredito.VisibleIndex = 4;
            colCredito.Width = 65;
            // 
            // colRazonSocial
            // 
            colRazonSocial.Caption = "Razón Social";
            colRazonSocial.FieldName = "Socio.Persona.RazonSocial";
            colRazonSocial.Name = "colRazonSocial";
            colRazonSocial.Visible = true;
            colRazonSocial.VisibleIndex = 5;
            colRazonSocial.Width = 174;
            // 
            // colNombre
            // 
            colNombre.Caption = "Nombre";
            colNombre.FieldName = "Socio.Persona.Nombre";
            colNombre.Name = "colNombre";
            colNombre.OptionsColumn.ReadOnly = true;
            colNombre.Visible = true;
            colNombre.VisibleIndex = 6;
            // 
            // colRFC
            // 
            colRFC.Caption = "RFC";
            colRFC.FieldName = "Socio.Persona.RFC";
            colRFC.Name = "colRFC";
            colRFC.OptionsColumn.AllowEdit = false;
            colRFC.Visible = true;
            colRFC.VisibleIndex = 7;
            colRFC.Width = 109;
            // 
            // colRegimenFiscal
            // 
            colRegimenFiscal.Caption = "Regimen Fiscal";
            colRegimenFiscal.FieldName = "Socio.Persona.RegimenFiscal";
            colRegimenFiscal.Name = "colRegimenFiscal";
            colRegimenFiscal.Visible = true;
            colRegimenFiscal.VisibleIndex = 8;
            colRegimenFiscal.Width = 124;
            // 
            // colCodigoPostal
            // 
            colCodigoPostal.Caption = "Código Postal";
            colCodigoPostal.FieldName = "Socio.Persona.CodigoPostal";
            colCodigoPostal.Name = "colCodigoPostal";
            colCodigoPostal.Visible = true;
            colCodigoPostal.VisibleIndex = 9;
            colCodigoPostal.Width = 115;
            // 
            // colMail
            // 
            colMail.Caption = "Correo";
            colMail.FieldName = "Socio.Persona.Email.Emails";
            colMail.Name = "colMail";
            colMail.Visible = true;
            colMail.VisibleIndex = 10;
            // 
            // repositoryItemButtonEdit1
            // 
            repositoryItemButtonEdit1.AutoHeight = false;
            repositoryItemButtonEdit1.Buttons.AddRange(new EditorButton[] { new EditorButton() });
            repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            repositoryItemButtonEdit1.TextEditStyle = TextEditStyles.HideTextEditor;
            repositoryItemButtonEdit1.ButtonClick += FormPersonas_Click;
            // 
            // layoutControlItem3
            // 
            layoutControlItem3.Control = ButtonQuery;
            layoutControlItem3.Location = new System.Drawing.Point(777, 0);
            layoutControlItem3.Name = "layoutControlItem3";
            layoutControlItem3.Size = new System.Drawing.Size(128, 32);
            layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            layoutControlItem3.TextVisible = false;
            // 
            // Root
            // 
            Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            Root.GroupBordersVisible = false;
            Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem1, layoutControlItem2, emptySpaceItem1, layoutControlItem4 });
            Root.Name = "Root";
            Root.Padding = new DevExpress.XtraLayout.Utils.Padding(1, 1, 1, 1);
            Root.Size = new System.Drawing.Size(1045, 592);
            Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            layoutControlItem1.Control = gridControlCuentas;
            layoutControlItem1.Location = new System.Drawing.Point(0, 30);
            layoutControlItem1.Name = "layoutControlItem1";
            layoutControlItem1.Size = new System.Drawing.Size(1043, 560);
            layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            layoutControlItem2.Control = ButtonUpdate;
            layoutControlItem2.Location = new System.Drawing.Point(892, 0);
            layoutControlItem2.Name = "layoutControlItem2";
            layoutControlItem2.Size = new System.Drawing.Size(151, 30);
            layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            layoutControlItem2.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            emptySpaceItem1.AllowHotTrack = false;
            emptySpaceItem1.Location = new System.Drawing.Point(234, 0);
            emptySpaceItem1.Name = "emptySpaceItem1";
            emptySpaceItem1.Size = new System.Drawing.Size(658, 30);
            emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem4
            // 
            layoutControlItem4.AppearanceItemCaption.Font = new System.Drawing.Font("Segoe UI", 12F);
            layoutControlItem4.AppearanceItemCaption.Options.UseFont = true;
            layoutControlItem4.AppearanceItemCaption.Options.UseTextOptions = true;
            layoutControlItem4.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            layoutControlItem4.Control = ComboBoxSucursales;
            layoutControlItem4.Location = new System.Drawing.Point(0, 0);
            layoutControlItem4.Name = "layoutControlItem4";
            layoutControlItem4.Size = new System.Drawing.Size(234, 30);
            layoutControlItem4.Text = "Sucursal";
            layoutControlItem4.TextLocation = DevExpress.Utils.Locations.Left;
            layoutControlItem4.TextSize = new System.Drawing.Size(59, 21);
            // 
            // barManager1
            // 
            barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] { bar3 });
            barManager1.DockControls.Add(barDockControlTop);
            barManager1.DockControls.Add(barDockControlBottom);
            barManager1.DockControls.Add(barDockControlLeft);
            barManager1.DockControls.Add(barDockControlRight);
            barManager1.Form = this;
            barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] { barEditItem1, barEditItem2, barButton });
            barManager1.MaxItemId = 3;
            barManager1.RepositoryItems.AddRange(new RepositoryItem[] { repositoryItemHypertextLabel1, repositoryItemHyperLinkEdit1 });
            barManager1.StatusBar = bar3;
            // 
            // bar3
            // 
            bar3.BarName = "Status bar";
            bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            bar3.DockCol = 0;
            bar3.DockRow = 0;
            bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] { new DevExpress.XtraBars.LinkPersistInfo(barButton) });
            bar3.OptionsBar.AllowQuickCustomization = false;
            bar3.OptionsBar.DrawDragBorder = false;
            bar3.OptionsBar.UseWholeRow = true;
            bar3.Text = "Status bar";
            // 
            // barButton
            // 
            barButton.Caption = "1.0.0.13";
            barButton.Id = 2;
            barButton.Name = "barButton";
            // 
            // barDockControlTop
            // 
            barDockControlTop.CausesValidation = false;
            barDockControlTop.Dock = DockStyle.Top;
            barDockControlTop.Location = new System.Drawing.Point(0, 0);
            barDockControlTop.Manager = barManager1;
            barDockControlTop.Size = new System.Drawing.Size(1045, 0);
            // 
            // barDockControlBottom
            // 
            barDockControlBottom.CausesValidation = false;
            barDockControlBottom.Dock = DockStyle.Bottom;
            barDockControlBottom.Location = new System.Drawing.Point(0, 592);
            barDockControlBottom.Manager = barManager1;
            barDockControlBottom.Size = new System.Drawing.Size(1045, 29);
            // 
            // barDockControlLeft
            // 
            barDockControlLeft.CausesValidation = false;
            barDockControlLeft.Dock = DockStyle.Left;
            barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            barDockControlLeft.Manager = barManager1;
            barDockControlLeft.Size = new System.Drawing.Size(0, 592);
            // 
            // barDockControlRight
            // 
            barDockControlRight.CausesValidation = false;
            barDockControlRight.Dock = DockStyle.Right;
            barDockControlRight.Location = new System.Drawing.Point(1045, 0);
            barDockControlRight.Manager = barManager1;
            barDockControlRight.Size = new System.Drawing.Size(0, 592);
            // 
            // barEditItem1
            // 
            barEditItem1.Caption = "barEditItem1";
            barEditItem1.Edit = repositoryItemHypertextLabel1;
            barEditItem1.Id = 0;
            barEditItem1.Name = "barEditItem1";
            // 
            // repositoryItemHypertextLabel1
            // 
            repositoryItemHypertextLabel1.Name = "repositoryItemHypertextLabel1";
            // 
            // barEditItem2
            // 
            barEditItem2.Caption = "1.0.0.13";
            barEditItem2.Edit = repositoryItemHyperLinkEdit1;
            barEditItem2.Id = 1;
            barEditItem2.Name = "barEditItem2";
            barEditItem2.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.Caption;
            // 
            // repositoryItemHyperLinkEdit1
            // 
            repositoryItemHyperLinkEdit1.AutoHeight = false;
            repositoryItemHyperLinkEdit1.ButtonsStyle = BorderStyles.NoBorder;
            repositoryItemHyperLinkEdit1.Name = "repositoryItemHyperLinkEdit1";
            // 
            // FormPersonas
            // 
            Appearance.Options.UseFont = true;
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1045, 621);
            Controls.Add(layoutControl1);
            Controls.Add(barDockControlLeft);
            Controls.Add(barDockControlRight);
            Controls.Add(barDockControlBottom);
            Controls.Add(barDockControlTop);
            Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F);
            Name = "FormPersonas";
            Text = "Créditos";
            WindowState = FormWindowState.Maximized;
            FormClosed += FormPersonas_FormClosed;
            Load += FormPersonas_Load;
            ((System.ComponentModel.ISupportInitialize)layoutControl1).EndInit();
            layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ComboBoxSucursales.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridControlCuentas).EndInit();
            ((System.ComponentModel.ISupportInitialize)creditoBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridViewCuentas).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemButtonEdit1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).EndInit();
            ((System.ComponentModel.ISupportInitialize)Root).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem4).EndInit();
            ((System.ComponentModel.ISupportInitialize)personaBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)barManager1).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemHypertextLabel1).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemHyperLinkEdit1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraGrid.GridControl gridControlCuentas;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCuentas;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private BindingSource personaBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colRazonSocial;
        private DevExpress.XtraGrid.Columns.GridColumn colRFC;
        private DevExpress.XtraGrid.Columns.GridColumn colRegimenFiscal;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigoPostal;
        private BindingSource creditoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colSocio;
        private DevExpress.XtraGrid.Columns.GridColumn colSucursal;
        private DevExpress.XtraGrid.Columns.GridColumn colCredito;
        private SimpleButton ButtonUpdate;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private SimpleButton ButtonQuery;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraGrid.Columns.GridColumn ColPeriodo;
        private DevExpress.XtraGrid.Columns.GridColumn ColClasificacionCredito;
        private DevExpress.XtraGrid.Columns.GridColumn colMail;
        private DotNet.CoreControlesUsuario.UI.UserControlComboBoxEdit ComboBoxSucursales;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        
        private RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarEditItem barEditItem2;
        private RepositoryItemHyperLinkEdit repositoryItemHyperLinkEdit1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarEditItem barEditItem1;
        private RepositoryItemHypertextLabel repositoryItemHypertextLabel1;
        private DevExpress.XtraBars.BarButtonItem barButton;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre;
    }
}

