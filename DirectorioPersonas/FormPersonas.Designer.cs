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
            gridControlCuentas = new DevExpress.XtraGrid.GridControl();
            creditoBindingSource = new BindingSource(components);
            gridViewCuentas = new DevExpress.XtraGrid.Views.Grid.GridView();
            colPersona = new DevExpress.XtraGrid.Columns.GridColumn();
            colSucursal = new DevExpress.XtraGrid.Columns.GridColumn();
            colSocio = new DevExpress.XtraGrid.Columns.GridColumn();
            colCredito = new DevExpress.XtraGrid.Columns.GridColumn();
            colRazonSocial = new DevExpress.XtraGrid.Columns.GridColumn();
            colDomicilio = new DevExpress.XtraGrid.Columns.GridColumn();
            colRFC = new DevExpress.XtraGrid.Columns.GridColumn();
            colRegimenFiscal = new DevExpress.XtraGrid.Columns.GridColumn();
            colCodigoPostal = new DevExpress.XtraGrid.Columns.GridColumn();
            Root = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            personaBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)layoutControl1).BeginInit();
            layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridControlCuentas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)creditoBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridViewCuentas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Root).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)personaBindingSource).BeginInit();
            SuspendLayout();
            // 
            // layoutControl1
            // 
            layoutControl1.Controls.Add(gridControlCuentas);
            layoutControl1.Dock = DockStyle.Fill;
            layoutControl1.Location = new System.Drawing.Point(0, 0);
            layoutControl1.Name = "layoutControl1";
            layoutControl1.Root = Root;
            layoutControl1.Size = new System.Drawing.Size(1141, 617);
            layoutControl1.TabIndex = 0;
            layoutControl1.Text = "layoutControl1";
            // 
            // gridControlCuentas
            // 
            gridControlCuentas.DataSource = creditoBindingSource;
            gridControlCuentas.Location = new System.Drawing.Point(3, 3);
            gridControlCuentas.MainView = gridViewCuentas;
            gridControlCuentas.Name = "gridControlCuentas";
            gridControlCuentas.Size = new System.Drawing.Size(1135, 611);
            gridControlCuentas.TabIndex = 4;
            gridControlCuentas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridViewCuentas });
            gridControlCuentas.DoubleClick += gridControlCuentas_DoubleClick;
            // 
            // gridViewCuentas
            // 
            gridViewCuentas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colPersona, colSucursal, colSocio, colCredito, colRazonSocial, colDomicilio, colRFC, colRegimenFiscal, colCodigoPostal });
            gridViewCuentas.GridControl = gridControlCuentas;
            gridViewCuentas.Name = "gridViewCuentas";
            gridViewCuentas.OptionsSelection.MultiSelect = true;
            gridViewCuentas.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect;
            gridViewCuentas.OptionsView.ShowAutoFilterRow = true;
            gridViewCuentas.OptionsView.ShowFooter = true;
            gridViewCuentas.OptionsView.ShowGroupPanel = false;
            // 
            // colPersona
            // 
            colPersona.Caption = "Persona";
            colPersona.FieldName = "Socio.Persona.IdPersona";
            colPersona.Name = "colPersona";
            colPersona.OptionsColumn.AllowEdit = false;
            colPersona.Visible = true;
            colPersona.VisibleIndex = 0;
            // 
            // colSucursal
            // 
            colSucursal.Caption = "Sucursal";
            colSucursal.FieldName = "Socio.Sucursal.Descripcion";
            colSucursal.Name = "colSucursal";
            colSucursal.OptionsColumn.AllowEdit = false;
            colSucursal.Visible = true;
            colSucursal.VisibleIndex = 1;
            // 
            // colSocio
            // 
            colSocio.Caption = "Socio";
            colSocio.FieldName = "Socio.Codigo";
            colSocio.Name = "colSocio";
            colSocio.OptionsColumn.AllowEdit = false;
            colSocio.Visible = true;
            colSocio.VisibleIndex = 2;
            // 
            // colCredito
            // 
            colCredito.Caption = "Crédito";
            colCredito.FieldName = "Codigo";
            colCredito.Name = "colCredito";
            colCredito.OptionsColumn.AllowEdit = false;
            colCredito.Visible = true;
            colCredito.VisibleIndex = 3;
            // 
            // colRazonSocial
            // 
            colRazonSocial.Caption = "Razón Social";
            colRazonSocial.FieldName = "Socio.Persona.RazonSocial";
            colRazonSocial.Name = "colRazonSocial";
            colRazonSocial.OptionsColumn.AllowEdit = false;
            colRazonSocial.Visible = true;
            colRazonSocial.VisibleIndex = 4;
            colRazonSocial.Width = 250;
            // 
            // colDomicilio
            // 
            colDomicilio.Caption = "Domicilio";
            colDomicilio.FieldName = "Socio.Persona.Domicilio";
            colDomicilio.Name = "colDomicilio";
            colDomicilio.OptionsColumn.AllowEdit = false;
            colDomicilio.Visible = true;
            colDomicilio.VisibleIndex = 5;
            colDomicilio.Width = 400;
            // 
            // colRFC
            // 
            colRFC.Caption = "RFC";
            colRFC.FieldName = "Socio.Persona.RFC";
            colRFC.Name = "colRFC";
            colRFC.OptionsColumn.AllowEdit = false;
            colRFC.Visible = true;
            colRFC.VisibleIndex = 6;
            colRFC.Width = 100;
            // 
            // colRegimenFiscal
            // 
            colRegimenFiscal.Caption = "Regimen Fiscal";
            colRegimenFiscal.FieldName = "Socio.Persona.RegimenFiscal";
            colRegimenFiscal.Name = "colRegimenFiscal";
            colRegimenFiscal.OptionsColumn.AllowEdit = false;
            colRegimenFiscal.Visible = true;
            colRegimenFiscal.VisibleIndex = 7;
            colRegimenFiscal.Width = 100;
            // 
            // colCodigoPostal
            // 
            colCodigoPostal.Caption = "Código Postal";
            colCodigoPostal.FieldName = "Socio.Persona.CodigoPostal";
            colCodigoPostal.Name = "colCodigoPostal";
            colCodigoPostal.OptionsColumn.AllowEdit = false;
            colCodigoPostal.Visible = true;
            colCodigoPostal.VisibleIndex = 8;
            colCodigoPostal.Width = 100;
            // 
            // Root
            // 
            Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            Root.GroupBordersVisible = false;
            Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem1 });
            Root.Name = "Root";
            Root.Padding = new DevExpress.XtraLayout.Utils.Padding(1, 1, 1, 1);
            Root.Size = new System.Drawing.Size(1141, 617);
            Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            layoutControlItem1.Control = gridControlCuentas;
            layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            layoutControlItem1.Name = "layoutControlItem1";
            layoutControlItem1.Size = new System.Drawing.Size(1139, 615);
            layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            layoutControlItem1.TextVisible = false;
            // 
            // FormPersonas
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1141, 617);
            Controls.Add(layoutControl1);
            Name = "FormPersonas";
            Text = "Créditos";
            WindowState = FormWindowState.Maximized;
            Load += FormPersonas_Load;
            ((System.ComponentModel.ISupportInitialize)layoutControl1).EndInit();
            layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridControlCuentas).EndInit();
            ((System.ComponentModel.ISupportInitialize)creditoBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridViewCuentas).EndInit();
            ((System.ComponentModel.ISupportInitialize)Root).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)personaBindingSource).EndInit();
            ResumeLayout(false);
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
        private DevExpress.XtraGrid.Columns.GridColumn colDomicilio;
        private DevExpress.XtraGrid.Columns.GridColumn colRegimenFiscal;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigoPostal;
        private BindingSource creditoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colSocio;
        private DevExpress.XtraGrid.Columns.GridColumn colSucursal;
        private DevExpress.XtraGrid.Columns.GridColumn colCredito;
        private DevExpress.XtraGrid.Columns.GridColumn colPersona;
    }
}

