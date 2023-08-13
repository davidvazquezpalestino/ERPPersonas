namespace WinFormsClient
{
    partial class FormDomicilios
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
            gridControlDomicilio = new DevExpress.XtraGrid.GridControl();
            domiciliosBindingSource = new BindingSource(components);
            gridViewDomicilio = new DevExpress.XtraGrid.Views.Grid.GridView();
            colDomicilio = new DevExpress.XtraGrid.Columns.GridColumn();
            colTipoDomicilio = new DevExpress.XtraGrid.Columns.GridColumn();
            colCalle = new DevExpress.XtraGrid.Columns.GridColumn();
            colNumeroExterior = new DevExpress.XtraGrid.Columns.GridColumn();
            colNumeroInterior = new DevExpress.XtraGrid.Columns.GridColumn();
            colCalles = new DevExpress.XtraGrid.Columns.GridColumn();
            colCodigoPostal = new DevExpress.XtraGrid.Columns.GridColumn();
            colAsentamiento = new DevExpress.XtraGrid.Columns.GridColumn();
            colCiudad = new DevExpress.XtraGrid.Columns.GridColumn();
            colMunicipio = new DevExpress.XtraGrid.Columns.GridColumn();
            colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            colPais = new DevExpress.XtraGrid.Columns.GridColumn();
            colReferencia = new DevExpress.XtraGrid.Columns.GridColumn();
            dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            btnGuardar = new SimpleButton();
            Root = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            gridIdDomicilio = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)gridControlDomicilio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)domiciliosBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridViewDomicilio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataLayoutControl1).BeginInit();
            dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Root).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).BeginInit();
            SuspendLayout();
            // 
            // gridControlDomicilio
            // 
            gridControlDomicilio.DataSource = domiciliosBindingSource;
            gridControlDomicilio.Location = new System.Drawing.Point(3, 35);
            gridControlDomicilio.MainView = gridViewDomicilio;
            gridControlDomicilio.Name = "gridControlDomicilio";
            gridControlDomicilio.Size = new System.Drawing.Size(978, 536);
            gridControlDomicilio.TabIndex = 2;
            gridControlDomicilio.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridViewDomicilio });
            // 
            // domiciliosBindingSource
            // 
            domiciliosBindingSource.DataSource = typeof(Domicilios);
            // 
            // gridViewDomicilio
            // 
            gridViewDomicilio.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { gridIdDomicilio, colDomicilio, colTipoDomicilio, colCalle, colNumeroExterior, colNumeroInterior, colCalles, colCodigoPostal, colAsentamiento, colCiudad, colMunicipio, colEstado, colPais, colReferencia });
            gridViewDomicilio.GridControl = gridControlDomicilio;
            gridViewDomicilio.Name = "gridViewDomicilio";
            gridViewDomicilio.OptionsSelection.MultiSelect = true;
            gridViewDomicilio.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect;
            gridViewDomicilio.OptionsView.ShowAutoFilterRow = true;
            gridViewDomicilio.OptionsView.ShowFooter = true;
            gridViewDomicilio.OptionsView.ShowGroupPanel = false;
            // 
            // colDomicilio
            // 
            colDomicilio.FieldName = "Domicilio";
            colDomicilio.Name = "colDomicilio";
            colDomicilio.Visible = true;
            colDomicilio.VisibleIndex = 0;
            // 
            // colTipoDomicilio
            // 
            colTipoDomicilio.Caption = "Tipo";
            colTipoDomicilio.FieldName = "TipoDetalle.Descripcion";
            colTipoDomicilio.Name = "colTipoDomicilio";
            colTipoDomicilio.Visible = true;
            colTipoDomicilio.VisibleIndex = 1;
            // 
            // colCalle
            // 
            colCalle.FieldName = "Calle";
            colCalle.Name = "colCalle";
            colCalle.Visible = true;
            colCalle.VisibleIndex = 2;
            // 
            // colNumeroExterior
            // 
            colNumeroExterior.FieldName = "NumeroExterior";
            colNumeroExterior.Name = "colNumeroExterior";
            colNumeroExterior.Visible = true;
            colNumeroExterior.VisibleIndex = 3;
            // 
            // colNumeroInterior
            // 
            colNumeroInterior.FieldName = "NumeroInterior";
            colNumeroInterior.Name = "colNumeroInterior";
            colNumeroInterior.Visible = true;
            colNumeroInterior.VisibleIndex = 4;
            // 
            // colCalles
            // 
            colCalles.FieldName = "Calles";
            colCalles.Name = "colCalles";
            colCalles.Visible = true;
            colCalles.VisibleIndex = 5;
            // 
            // colCodigoPostal
            // 
            colCodigoPostal.FieldName = "CodigoPostal";
            colCodigoPostal.Name = "colCodigoPostal";
            colCodigoPostal.Visible = true;
            colCodigoPostal.VisibleIndex = 6;
            // 
            // colAsentamiento
            // 
            colAsentamiento.FieldName = "Asentamiento";
            colAsentamiento.Name = "colAsentamiento";
            colAsentamiento.Visible = true;
            colAsentamiento.VisibleIndex = 7;
            // 
            // colCiudad
            // 
            colCiudad.FieldName = "Ciudad";
            colCiudad.Name = "colCiudad";
            colCiudad.Visible = true;
            colCiudad.VisibleIndex = 8;
            // 
            // colMunicipio
            // 
            colMunicipio.FieldName = "Municipio";
            colMunicipio.Name = "colMunicipio";
            colMunicipio.Visible = true;
            colMunicipio.VisibleIndex = 9;
            // 
            // colEstado
            // 
            colEstado.FieldName = "Estado";
            colEstado.Name = "colEstado";
            colEstado.Visible = true;
            colEstado.VisibleIndex = 10;
            // 
            // colPais
            // 
            colPais.FieldName = "Pais";
            colPais.Name = "colPais";
            colPais.Visible = true;
            colPais.VisibleIndex = 11;
            // 
            // colReferencia
            // 
            colReferencia.FieldName = "Referencia";
            colReferencia.Name = "colReferencia";
            colReferencia.Visible = true;
            colReferencia.VisibleIndex = 12;
            // 
            // dataLayoutControl1
            // 
            dataLayoutControl1.Controls.Add(btnGuardar);
            dataLayoutControl1.Controls.Add(gridControlDomicilio);
            dataLayoutControl1.Dock = DockStyle.Fill;
            dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
            dataLayoutControl1.Name = "dataLayoutControl1";
            dataLayoutControl1.Root = Root;
            dataLayoutControl1.Size = new System.Drawing.Size(984, 574);
            dataLayoutControl1.TabIndex = 6;
            dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // btnGuardar
            // 
            btnGuardar.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnGuardar.Appearance.Options.UseFont = true;
            btnGuardar.Location = new System.Drawing.Point(698, 3);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new System.Drawing.Size(283, 28);
            btnGuardar.StyleController = dataLayoutControl1;
            btnGuardar.TabIndex = 0;
            btnGuardar.Text = "Guardar";
            btnGuardar.Click += btnGuardar_Click;
            // 
            // Root
            // 
            Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            Root.GroupBordersVisible = false;
            Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem1, layoutControlItem2, emptySpaceItem1 });
            Root.Name = "Root";
            Root.Padding = new DevExpress.XtraLayout.Utils.Padding(1, 1, 1, 1);
            Root.Size = new System.Drawing.Size(984, 574);
            Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            layoutControlItem1.Control = gridControlDomicilio;
            layoutControlItem1.Location = new System.Drawing.Point(0, 32);
            layoutControlItem1.Name = "layoutControlItem1";
            layoutControlItem1.Size = new System.Drawing.Size(982, 540);
            layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            layoutControlItem2.Control = btnGuardar;
            layoutControlItem2.Location = new System.Drawing.Point(695, 0);
            layoutControlItem2.Name = "layoutControlItem2";
            layoutControlItem2.Size = new System.Drawing.Size(287, 32);
            layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            layoutControlItem2.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            emptySpaceItem1.AllowHotTrack = false;
            emptySpaceItem1.Location = new System.Drawing.Point(0, 0);
            emptySpaceItem1.Name = "emptySpaceItem1";
            emptySpaceItem1.Size = new System.Drawing.Size(695, 32);
            emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // gridIdDomicilio
            // 
            gridIdDomicilio.Caption = "IdDomicilio";
            gridIdDomicilio.FieldName = "IdDomicilio";
            gridIdDomicilio.Name = "gridIdDomicilio";
            gridIdDomicilio.Visible = true;
            gridIdDomicilio.VisibleIndex = 13;
            // 
            // FormDomicilios
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(984, 574);
            Controls.Add(dataLayoutControl1);
            Name = "FormDomicilios";
            Text = "FormDomicilios";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)gridControlDomicilio).EndInit();
            ((System.ComponentModel.ISupportInitialize)domiciliosBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridViewDomicilio).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataLayoutControl1).EndInit();
            dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Root).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlDomicilio;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDomicilio;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private BindingSource domiciliosBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colCalle;
        private DevExpress.XtraGrid.Columns.GridColumn colNumeroExterior;
        private DevExpress.XtraGrid.Columns.GridColumn colNumeroInterior;
        private DevExpress.XtraGrid.Columns.GridColumn colCalles;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigoPostal;
        private DevExpress.XtraGrid.Columns.GridColumn colAsentamiento;
        private DevExpress.XtraGrid.Columns.GridColumn colCiudad;
        private DevExpress.XtraGrid.Columns.GridColumn colMunicipio;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private DevExpress.XtraGrid.Columns.GridColumn colPais;
        private DevExpress.XtraGrid.Columns.GridColumn colReferencia;
        private DevExpress.XtraGrid.Columns.GridColumn colDomicilio;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoDomicilio;
        private SimpleButton btnGuardar;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraGrid.Columns.GridColumn gridIdDomicilio;
    }
}