
namespace OgrenciNotKayitSistemi
{
    partial class FrmOgretmenDetay
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
            this.tBLDERSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbNotKayitDataSet = new OgrenciNotKayitSistemi.DbNotKayitDataSet();
            this.tBL_DERSTableAdapter = new OgrenciNotKayitSistemi.DbNotKayitDataSetTableAdapters.TBL_DERSTableAdapter();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.oGRIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oGRNUMARADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oGRADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oGRSOYADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oGRS1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oGRS2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oGRS3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oRTALAMADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dURUMDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.labelOgrenciBilgiSinav3 = new System.Windows.Forms.Label();
            this.labelOgrenciBilgiSinav3Value = new System.Windows.Forms.Label();
            this.labelDurumOrtalamaValue = new System.Windows.Forms.Label();
            this.labelOgrenciBilgiSinav2 = new System.Windows.Forms.Label();
            this.labelDurumOrtalama = new System.Windows.Forms.Label();
            this.labelOgrenciBilgiSinav2Value = new System.Windows.Forms.Label();
            this.labelOgrenciBilgiSinav1 = new System.Windows.Forms.Label();
            this.labelOgrenciBilgiSinav1Value = new System.Windows.Forms.Label();
            this.labelOgrenciBilgiNumara = new System.Windows.Forms.Label();
            this.labelOgrenciBilgiNumaraValue = new System.Windows.Forms.Label();
            this.labelOgrenciBilgiSoyad = new System.Windows.Forms.Label();
            this.labelOgrenciBilgiSoyadValue = new System.Windows.Forms.Label();
            this.labelOgrenciBilgiAd = new System.Windows.Forms.Label();
            this.labelOgrenciBilgiAdValue = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelDurumOgrenciSayisi = new System.Windows.Forms.Label();
            this.labelDurumOgrenciSayisiValue = new System.Windows.Forms.Label();
            this.labelDurumKalanSayisi = new System.Windows.Forms.Label();
            this.labelDurumKalanSayisiValue = new System.Windows.Forms.Label();
            this.labelDurumGecenSayisi = new System.Windows.Forms.Label();
            this.labelDurumGecenSayisiValue = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelSinavNotlariOgrenciNo = new System.Windows.Forms.Label();
            this.cmbBoxNumara = new System.Windows.Forms.ComboBox();
            this.buttonSinavGuncelle = new System.Windows.Forms.Button();
            this.labelSinavNotlariSinav3 = new System.Windows.Forms.Label();
            this.labelSinavNotlariSinav2 = new System.Windows.Forms.Label();
            this.sinavEkleTextBox1 = new System.Windows.Forms.TextBox();
            this.sinavEkleTextBox2 = new System.Windows.Forms.TextBox();
            this.sinavEkleTextBox3 = new System.Windows.Forms.TextBox();
            this.labelSinavNotlariSinav1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOgrenciEkle = new System.Windows.Forms.Button();
            this.labelOgrenciEkleNumara = new System.Windows.Forms.Label();
            this.labelOgrenciEkleAd = new System.Windows.Forms.Label();
            this.labelOgrenciEkleSoyad = new System.Windows.Forms.Label();
            this.ogrenciEkleMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.ogrenciEkleAd = new System.Windows.Forms.TextBox();
            this.ogrenciEkleSoyad = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.lblBilgiDurum = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tBLDERSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbNotKayitDataSet)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tBLDERSBindingSource
            // 
            this.tBLDERSBindingSource.DataMember = "TBL_DERS";
            this.tBLDERSBindingSource.DataSource = this.dbNotKayitDataSet;
            // 
            // dbNotKayitDataSet
            // 
            this.dbNotKayitDataSet.DataSetName = "DbNotKayitDataSet";
            this.dbNotKayitDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBL_DERSTableAdapter
            // 
            this.tBL_DERSTableAdapter.ClearBeforeFill = true;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tabPage4.Controls.Add(this.dataGridView1);
            this.tabPage4.Location = new System.Drawing.Point(4, 27);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1009, 300);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Öğrenci Listesi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.oGRIDDataGridViewTextBoxColumn,
            this.oGRNUMARADataGridViewTextBoxColumn,
            this.oGRADDataGridViewTextBoxColumn,
            this.oGRSOYADDataGridViewTextBoxColumn,
            this.oGRS1DataGridViewTextBoxColumn,
            this.oGRS2DataGridViewTextBoxColumn,
            this.oGRS3DataGridViewTextBoxColumn,
            this.oRTALAMADataGridViewTextBoxColumn,
            this.dURUMDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.tBLDERSBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1003, 294);
            this.dataGridView1.TabIndex = 0;
            // 
            // oGRIDDataGridViewTextBoxColumn
            // 
            this.oGRIDDataGridViewTextBoxColumn.DataPropertyName = "OGRID";
            this.oGRIDDataGridViewTextBoxColumn.HeaderText = "OGRID";
            this.oGRIDDataGridViewTextBoxColumn.Name = "oGRIDDataGridViewTextBoxColumn";
            this.oGRIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.oGRIDDataGridViewTextBoxColumn.Width = 86;
            // 
            // oGRNUMARADataGridViewTextBoxColumn
            // 
            this.oGRNUMARADataGridViewTextBoxColumn.DataPropertyName = "OGRNUMARA";
            this.oGRNUMARADataGridViewTextBoxColumn.HeaderText = "OGRNUMARA";
            this.oGRNUMARADataGridViewTextBoxColumn.Name = "oGRNUMARADataGridViewTextBoxColumn";
            this.oGRNUMARADataGridViewTextBoxColumn.Width = 140;
            // 
            // oGRADDataGridViewTextBoxColumn
            // 
            this.oGRADDataGridViewTextBoxColumn.DataPropertyName = "OGRAD";
            this.oGRADDataGridViewTextBoxColumn.HeaderText = "OGRAD";
            this.oGRADDataGridViewTextBoxColumn.Name = "oGRADDataGridViewTextBoxColumn";
            this.oGRADDataGridViewTextBoxColumn.Width = 90;
            // 
            // oGRSOYADDataGridViewTextBoxColumn
            // 
            this.oGRSOYADDataGridViewTextBoxColumn.DataPropertyName = "OGRSOYAD";
            this.oGRSOYADDataGridViewTextBoxColumn.HeaderText = "OGRSOYAD";
            this.oGRSOYADDataGridViewTextBoxColumn.Name = "oGRSOYADDataGridViewTextBoxColumn";
            this.oGRSOYADDataGridViewTextBoxColumn.Width = 122;
            // 
            // oGRS1DataGridViewTextBoxColumn
            // 
            this.oGRS1DataGridViewTextBoxColumn.DataPropertyName = "OGRS1";
            this.oGRS1DataGridViewTextBoxColumn.HeaderText = "OGRS1";
            this.oGRS1DataGridViewTextBoxColumn.Name = "oGRS1DataGridViewTextBoxColumn";
            this.oGRS1DataGridViewTextBoxColumn.Width = 85;
            // 
            // oGRS2DataGridViewTextBoxColumn
            // 
            this.oGRS2DataGridViewTextBoxColumn.DataPropertyName = "OGRS2";
            this.oGRS2DataGridViewTextBoxColumn.HeaderText = "OGRS2";
            this.oGRS2DataGridViewTextBoxColumn.Name = "oGRS2DataGridViewTextBoxColumn";
            this.oGRS2DataGridViewTextBoxColumn.Width = 86;
            // 
            // oGRS3DataGridViewTextBoxColumn
            // 
            this.oGRS3DataGridViewTextBoxColumn.DataPropertyName = "OGRS3";
            this.oGRS3DataGridViewTextBoxColumn.HeaderText = "OGRS3";
            this.oGRS3DataGridViewTextBoxColumn.Name = "oGRS3DataGridViewTextBoxColumn";
            this.oGRS3DataGridViewTextBoxColumn.Width = 86;
            // 
            // oRTALAMADataGridViewTextBoxColumn
            // 
            this.oRTALAMADataGridViewTextBoxColumn.DataPropertyName = "ORTALAMA";
            this.oRTALAMADataGridViewTextBoxColumn.HeaderText = "ORTALAMA";
            this.oRTALAMADataGridViewTextBoxColumn.Name = "oRTALAMADataGridViewTextBoxColumn";
            this.oRTALAMADataGridViewTextBoxColumn.Width = 125;
            // 
            // dURUMDataGridViewCheckBoxColumn
            // 
            this.dURUMDataGridViewCheckBoxColumn.DataPropertyName = "DURUM";
            this.dURUMDataGridViewCheckBoxColumn.HeaderText = "DURUM";
            this.dURUMDataGridViewCheckBoxColumn.Name = "dURUMDataGridViewCheckBoxColumn";
            this.dURUMDataGridViewCheckBoxColumn.Width = 75;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1009, 300);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Öğrenci Ekle";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Silver;
            this.groupBox4.Controls.Add(this.lblBilgiDurum);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.labelOgrenciBilgiSinav3);
            this.groupBox4.Controls.Add(this.labelOgrenciBilgiSinav3Value);
            this.groupBox4.Controls.Add(this.labelDurumOrtalamaValue);
            this.groupBox4.Controls.Add(this.labelOgrenciBilgiSinav2);
            this.groupBox4.Controls.Add(this.labelDurumOrtalama);
            this.groupBox4.Controls.Add(this.labelOgrenciBilgiSinav2Value);
            this.groupBox4.Controls.Add(this.labelOgrenciBilgiSinav1);
            this.groupBox4.Controls.Add(this.labelOgrenciBilgiSinav1Value);
            this.groupBox4.Controls.Add(this.labelOgrenciBilgiNumara);
            this.groupBox4.Controls.Add(this.labelOgrenciBilgiNumaraValue);
            this.groupBox4.Controls.Add(this.labelOgrenciBilgiSoyad);
            this.groupBox4.Controls.Add(this.labelOgrenciBilgiSoyadValue);
            this.groupBox4.Controls.Add(this.labelOgrenciBilgiAd);
            this.groupBox4.Controls.Add(this.labelOgrenciBilgiAdValue);
            this.groupBox4.Location = new System.Drawing.Point(594, 8);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(201, 284);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Öğrenci Bilgi";
            // 
            // labelOgrenciBilgiSinav3
            // 
            this.labelOgrenciBilgiSinav3.AutoSize = true;
            this.labelOgrenciBilgiSinav3.Location = new System.Drawing.Point(18, 189);
            this.labelOgrenciBilgiSinav3.Name = "labelOgrenciBilgiSinav3";
            this.labelOgrenciBilgiSinav3.Size = new System.Drawing.Size(69, 18);
            this.labelOgrenciBilgiSinav3.TabIndex = 11;
            this.labelOgrenciBilgiSinav3.Text = "Sınav 3 :";
            // 
            // labelOgrenciBilgiSinav3Value
            // 
            this.labelOgrenciBilgiSinav3Value.AutoSize = true;
            this.labelOgrenciBilgiSinav3Value.Location = new System.Drawing.Point(117, 189);
            this.labelOgrenciBilgiSinav3Value.Name = "labelOgrenciBilgiSinav3Value";
            this.labelOgrenciBilgiSinav3Value.Size = new System.Drawing.Size(28, 18);
            this.labelOgrenciBilgiSinav3Value.TabIndex = 10;
            this.labelOgrenciBilgiSinav3Value.Text = "00";
            // 
            // labelDurumOrtalamaValue
            // 
            this.labelDurumOrtalamaValue.AutoSize = true;
            this.labelDurumOrtalamaValue.Location = new System.Drawing.Point(117, 218);
            this.labelDurumOrtalamaValue.Name = "labelDurumOrtalamaValue";
            this.labelDurumOrtalamaValue.Size = new System.Drawing.Size(28, 18);
            this.labelDurumOrtalamaValue.TabIndex = 0;
            this.labelDurumOrtalamaValue.Text = "00";
            this.labelDurumOrtalamaValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelOgrenciBilgiSinav2
            // 
            this.labelOgrenciBilgiSinav2.AutoSize = true;
            this.labelOgrenciBilgiSinav2.Location = new System.Drawing.Point(19, 160);
            this.labelOgrenciBilgiSinav2.Name = "labelOgrenciBilgiSinav2";
            this.labelOgrenciBilgiSinav2.Size = new System.Drawing.Size(69, 18);
            this.labelOgrenciBilgiSinav2.TabIndex = 9;
            this.labelOgrenciBilgiSinav2.Text = "Sınav 2 :";
            // 
            // labelDurumOrtalama
            // 
            this.labelDurumOrtalama.AutoSize = true;
            this.labelDurumOrtalama.Location = new System.Drawing.Point(19, 218);
            this.labelDurumOrtalama.Name = "labelDurumOrtalama";
            this.labelDurumOrtalama.Size = new System.Drawing.Size(84, 18);
            this.labelDurumOrtalama.TabIndex = 3;
            this.labelDurumOrtalama.Text = "Ortalama :";
            // 
            // labelOgrenciBilgiSinav2Value
            // 
            this.labelOgrenciBilgiSinav2Value.AutoSize = true;
            this.labelOgrenciBilgiSinav2Value.Location = new System.Drawing.Point(118, 160);
            this.labelOgrenciBilgiSinav2Value.Name = "labelOgrenciBilgiSinav2Value";
            this.labelOgrenciBilgiSinav2Value.Size = new System.Drawing.Size(28, 18);
            this.labelOgrenciBilgiSinav2Value.TabIndex = 8;
            this.labelOgrenciBilgiSinav2Value.Text = "00";
            // 
            // labelOgrenciBilgiSinav1
            // 
            this.labelOgrenciBilgiSinav1.AutoSize = true;
            this.labelOgrenciBilgiSinav1.Location = new System.Drawing.Point(19, 131);
            this.labelOgrenciBilgiSinav1.Name = "labelOgrenciBilgiSinav1";
            this.labelOgrenciBilgiSinav1.Size = new System.Drawing.Size(68, 18);
            this.labelOgrenciBilgiSinav1.TabIndex = 7;
            this.labelOgrenciBilgiSinav1.Text = "Sınav 1 :";
            // 
            // labelOgrenciBilgiSinav1Value
            // 
            this.labelOgrenciBilgiSinav1Value.AutoSize = true;
            this.labelOgrenciBilgiSinav1Value.Location = new System.Drawing.Point(118, 131);
            this.labelOgrenciBilgiSinav1Value.Name = "labelOgrenciBilgiSinav1Value";
            this.labelOgrenciBilgiSinav1Value.Size = new System.Drawing.Size(28, 18);
            this.labelOgrenciBilgiSinav1Value.TabIndex = 6;
            this.labelOgrenciBilgiSinav1Value.Text = "00";
            // 
            // labelOgrenciBilgiNumara
            // 
            this.labelOgrenciBilgiNumara.AutoSize = true;
            this.labelOgrenciBilgiNumara.Location = new System.Drawing.Point(19, 102);
            this.labelOgrenciBilgiNumara.Name = "labelOgrenciBilgiNumara";
            this.labelOgrenciBilgiNumara.Size = new System.Drawing.Size(75, 18);
            this.labelOgrenciBilgiNumara.TabIndex = 5;
            this.labelOgrenciBilgiNumara.Text = "Numara :";
            // 
            // labelOgrenciBilgiNumaraValue
            // 
            this.labelOgrenciBilgiNumaraValue.AutoSize = true;
            this.labelOgrenciBilgiNumaraValue.Location = new System.Drawing.Point(118, 102);
            this.labelOgrenciBilgiNumaraValue.Name = "labelOgrenciBilgiNumaraValue";
            this.labelOgrenciBilgiNumaraValue.Size = new System.Drawing.Size(48, 18);
            this.labelOgrenciBilgiNumaraValue.TabIndex = 4;
            this.labelOgrenciBilgiNumaraValue.Text = "0000";
            // 
            // labelOgrenciBilgiSoyad
            // 
            this.labelOgrenciBilgiSoyad.AutoSize = true;
            this.labelOgrenciBilgiSoyad.Location = new System.Drawing.Point(18, 73);
            this.labelOgrenciBilgiSoyad.Name = "labelOgrenciBilgiSoyad";
            this.labelOgrenciBilgiSoyad.Size = new System.Drawing.Size(60, 18);
            this.labelOgrenciBilgiSoyad.TabIndex = 3;
            this.labelOgrenciBilgiSoyad.Text = "Soyad :";
            // 
            // labelOgrenciBilgiSoyadValue
            // 
            this.labelOgrenciBilgiSoyadValue.AutoSize = true;
            this.labelOgrenciBilgiSoyadValue.Location = new System.Drawing.Point(118, 73);
            this.labelOgrenciBilgiSoyadValue.Name = "labelOgrenciBilgiSoyadValue";
            this.labelOgrenciBilgiSoyadValue.Size = new System.Drawing.Size(52, 18);
            this.labelOgrenciBilgiSoyadValue.TabIndex = 2;
            this.labelOgrenciBilgiSoyadValue.Text = "NULL";
            // 
            // labelOgrenciBilgiAd
            // 
            this.labelOgrenciBilgiAd.AutoSize = true;
            this.labelOgrenciBilgiAd.Location = new System.Drawing.Point(19, 44);
            this.labelOgrenciBilgiAd.Name = "labelOgrenciBilgiAd";
            this.labelOgrenciBilgiAd.Size = new System.Drawing.Size(37, 18);
            this.labelOgrenciBilgiAd.TabIndex = 1;
            this.labelOgrenciBilgiAd.Text = "Ad :";
            // 
            // labelOgrenciBilgiAdValue
            // 
            this.labelOgrenciBilgiAdValue.AutoSize = true;
            this.labelOgrenciBilgiAdValue.Location = new System.Drawing.Point(118, 44);
            this.labelOgrenciBilgiAdValue.Name = "labelOgrenciBilgiAdValue";
            this.labelOgrenciBilgiAdValue.Size = new System.Drawing.Size(52, 18);
            this.labelOgrenciBilgiAdValue.TabIndex = 0;
            this.labelOgrenciBilgiAdValue.Text = "NULL";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Silver;
            this.groupBox3.Controls.Add(this.labelDurumOgrenciSayisi);
            this.groupBox3.Controls.Add(this.labelDurumOgrenciSayisiValue);
            this.groupBox3.Controls.Add(this.labelDurumKalanSayisi);
            this.groupBox3.Controls.Add(this.labelDurumKalanSayisiValue);
            this.groupBox3.Controls.Add(this.labelDurumGecenSayisi);
            this.groupBox3.Controls.Add(this.labelDurumGecenSayisiValue);
            this.groupBox3.Location = new System.Drawing.Point(801, 8);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 284);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Durum";
            // 
            // labelDurumOgrenciSayisi
            // 
            this.labelDurumOgrenciSayisi.AutoSize = true;
            this.labelDurumOgrenciSayisi.Location = new System.Drawing.Point(23, 43);
            this.labelDurumOgrenciSayisi.Name = "labelDurumOgrenciSayisi";
            this.labelDurumOgrenciSayisi.Size = new System.Drawing.Size(117, 18);
            this.labelDurumOgrenciSayisi.TabIndex = 7;
            this.labelDurumOgrenciSayisi.Text = "Öğrenci Sayısı :";
            // 
            // labelDurumOgrenciSayisiValue
            // 
            this.labelDurumOgrenciSayisiValue.AutoSize = true;
            this.labelDurumOgrenciSayisiValue.Location = new System.Drawing.Point(146, 43);
            this.labelDurumOgrenciSayisiValue.Name = "labelDurumOgrenciSayisiValue";
            this.labelDurumOgrenciSayisiValue.Size = new System.Drawing.Size(28, 18);
            this.labelDurumOgrenciSayisiValue.TabIndex = 6;
            this.labelDurumOgrenciSayisiValue.Text = "00";
            // 
            // labelDurumKalanSayisi
            // 
            this.labelDurumKalanSayisi.AutoSize = true;
            this.labelDurumKalanSayisi.Location = new System.Drawing.Point(22, 142);
            this.labelDurumKalanSayisi.Name = "labelDurumKalanSayisi";
            this.labelDurumKalanSayisi.Size = new System.Drawing.Size(93, 18);
            this.labelDurumKalanSayisi.TabIndex = 5;
            this.labelDurumKalanSayisi.Text = "Kalan Sayısı";
            // 
            // labelDurumKalanSayisiValue
            // 
            this.labelDurumKalanSayisiValue.AutoSize = true;
            this.labelDurumKalanSayisiValue.Location = new System.Drawing.Point(146, 142);
            this.labelDurumKalanSayisiValue.Name = "labelDurumKalanSayisiValue";
            this.labelDurumKalanSayisiValue.Size = new System.Drawing.Size(28, 18);
            this.labelDurumKalanSayisiValue.TabIndex = 2;
            this.labelDurumKalanSayisiValue.Text = "00";
            // 
            // labelDurumGecenSayisi
            // 
            this.labelDurumGecenSayisi.AutoSize = true;
            this.labelDurumGecenSayisi.Location = new System.Drawing.Point(23, 93);
            this.labelDurumGecenSayisi.Name = "labelDurumGecenSayisi";
            this.labelDurumGecenSayisi.Size = new System.Drawing.Size(106, 18);
            this.labelDurumGecenSayisi.TabIndex = 4;
            this.labelDurumGecenSayisi.Text = "Geçen Sayısı :";
            // 
            // labelDurumGecenSayisiValue
            // 
            this.labelDurumGecenSayisiValue.AutoSize = true;
            this.labelDurumGecenSayisiValue.Location = new System.Drawing.Point(146, 93);
            this.labelDurumGecenSayisiValue.Name = "labelDurumGecenSayisiValue";
            this.labelDurumGecenSayisiValue.Size = new System.Drawing.Size(28, 18);
            this.labelDurumGecenSayisiValue.TabIndex = 1;
            this.labelDurumGecenSayisiValue.Text = "00";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Silver;
            this.groupBox2.Controls.Add(this.labelSinavNotlariOgrenciNo);
            this.groupBox2.Controls.Add(this.cmbBoxNumara);
            this.groupBox2.Controls.Add(this.buttonSinavGuncelle);
            this.groupBox2.Controls.Add(this.labelSinavNotlariSinav3);
            this.groupBox2.Controls.Add(this.labelSinavNotlariSinav2);
            this.groupBox2.Controls.Add(this.sinavEkleTextBox1);
            this.groupBox2.Controls.Add(this.sinavEkleTextBox2);
            this.groupBox2.Controls.Add(this.sinavEkleTextBox3);
            this.groupBox2.Controls.Add(this.labelSinavNotlariSinav1);
            this.groupBox2.Location = new System.Drawing.Point(304, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(283, 284);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sınav Notları";
            // 
            // labelSinavNotlariOgrenciNo
            // 
            this.labelSinavNotlariOgrenciNo.AutoSize = true;
            this.labelSinavNotlariOgrenciNo.Location = new System.Drawing.Point(12, 43);
            this.labelSinavNotlariOgrenciNo.Name = "labelSinavNotlariOgrenciNo";
            this.labelSinavNotlariOgrenciNo.Size = new System.Drawing.Size(96, 18);
            this.labelSinavNotlariOgrenciNo.TabIndex = 8;
            this.labelSinavNotlariOgrenciNo.Text = "Öğrenci No :";
            // 
            // cmbBoxNumara
            // 
            this.cmbBoxNumara.DataSource = this.tBLDERSBindingSource;
            this.cmbBoxNumara.DisplayMember = "OGRNUMARA";
            this.cmbBoxNumara.FormattingEnabled = true;
            this.cmbBoxNumara.Location = new System.Drawing.Point(114, 40);
            this.cmbBoxNumara.Name = "cmbBoxNumara";
            this.cmbBoxNumara.Size = new System.Drawing.Size(154, 26);
            this.cmbBoxNumara.TabIndex = 7;
            this.cmbBoxNumara.ValueMember = "OGRNUMARA";
            this.cmbBoxNumara.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // buttonSinavGuncelle
            // 
            this.buttonSinavGuncelle.BackColor = System.Drawing.Color.SeaGreen;
            this.buttonSinavGuncelle.Location = new System.Drawing.Point(114, 225);
            this.buttonSinavGuncelle.Name = "buttonSinavGuncelle";
            this.buttonSinavGuncelle.Size = new System.Drawing.Size(154, 41);
            this.buttonSinavGuncelle.TabIndex = 3;
            this.buttonSinavGuncelle.Text = "Güncelle";
            this.buttonSinavGuncelle.UseVisualStyleBackColor = false;
            this.buttonSinavGuncelle.Click += new System.EventHandler(this.buttonSinavGuncelle_Click);
            // 
            // labelSinavNotlariSinav3
            // 
            this.labelSinavNotlariSinav3.AutoSize = true;
            this.labelSinavNotlariSinav3.Location = new System.Drawing.Point(12, 186);
            this.labelSinavNotlariSinav3.Name = "labelSinavNotlariSinav3";
            this.labelSinavNotlariSinav3.Size = new System.Drawing.Size(69, 18);
            this.labelSinavNotlariSinav3.TabIndex = 6;
            this.labelSinavNotlariSinav3.Text = "Sınav 3 :";
            // 
            // labelSinavNotlariSinav2
            // 
            this.labelSinavNotlariSinav2.AutoSize = true;
            this.labelSinavNotlariSinav2.Location = new System.Drawing.Point(12, 137);
            this.labelSinavNotlariSinav2.Name = "labelSinavNotlariSinav2";
            this.labelSinavNotlariSinav2.Size = new System.Drawing.Size(69, 18);
            this.labelSinavNotlariSinav2.TabIndex = 5;
            this.labelSinavNotlariSinav2.Text = "Sınav 2 :";
            // 
            // sinavEkleTextBox1
            // 
            this.sinavEkleTextBox1.Location = new System.Drawing.Point(114, 87);
            this.sinavEkleTextBox1.MaxLength = 3;
            this.sinavEkleTextBox1.Name = "sinavEkleTextBox1";
            this.sinavEkleTextBox1.Size = new System.Drawing.Size(154, 26);
            this.sinavEkleTextBox1.TabIndex = 0;
            this.sinavEkleTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sinavEkleTextBox1_KeyPress);
            // 
            // sinavEkleTextBox2
            // 
            this.sinavEkleTextBox2.Location = new System.Drawing.Point(114, 134);
            this.sinavEkleTextBox2.Name = "sinavEkleTextBox2";
            this.sinavEkleTextBox2.Size = new System.Drawing.Size(154, 26);
            this.sinavEkleTextBox2.TabIndex = 1;
            this.sinavEkleTextBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sinavEkleTextBox2_KeyPress);
            // 
            // sinavEkleTextBox3
            // 
            this.sinavEkleTextBox3.Location = new System.Drawing.Point(114, 183);
            this.sinavEkleTextBox3.MaxLength = 32768;
            this.sinavEkleTextBox3.Name = "sinavEkleTextBox3";
            this.sinavEkleTextBox3.Size = new System.Drawing.Size(154, 26);
            this.sinavEkleTextBox3.TabIndex = 2;
            this.sinavEkleTextBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sinavEkleTextBox3_KeyPress);
            // 
            // labelSinavNotlariSinav1
            // 
            this.labelSinavNotlariSinav1.AutoSize = true;
            this.labelSinavNotlariSinav1.Location = new System.Drawing.Point(12, 90);
            this.labelSinavNotlariSinav1.Name = "labelSinavNotlariSinav1";
            this.labelSinavNotlariSinav1.Size = new System.Drawing.Size(68, 18);
            this.labelSinavNotlariSinav1.TabIndex = 4;
            this.labelSinavNotlariSinav1.Text = "Sınav 1 :";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.btnOgrenciEkle);
            this.groupBox1.Controls.Add(this.labelOgrenciEkleNumara);
            this.groupBox1.Controls.Add(this.labelOgrenciEkleAd);
            this.groupBox1.Controls.Add(this.labelOgrenciEkleSoyad);
            this.groupBox1.Controls.Add(this.ogrenciEkleMaskedTextBox);
            this.groupBox1.Controls.Add(this.ogrenciEkleAd);
            this.groupBox1.Controls.Add(this.ogrenciEkleSoyad);
            this.groupBox1.Location = new System.Drawing.Point(8, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 284);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğrenci Ekle";
            // 
            // btnOgrenciEkle
            // 
            this.btnOgrenciEkle.BackColor = System.Drawing.Color.SeaGreen;
            this.btnOgrenciEkle.Location = new System.Drawing.Point(112, 175);
            this.btnOgrenciEkle.Name = "btnOgrenciEkle";
            this.btnOgrenciEkle.Size = new System.Drawing.Size(154, 41);
            this.btnOgrenciEkle.TabIndex = 3;
            this.btnOgrenciEkle.Text = "Öğrenci Kaydet";
            this.btnOgrenciEkle.UseVisualStyleBackColor = false;
            this.btnOgrenciEkle.Click += new System.EventHandler(this.btnOgrenciEkle_Click);
            // 
            // labelOgrenciEkleNumara
            // 
            this.labelOgrenciEkleNumara.AutoSize = true;
            this.labelOgrenciEkleNumara.Location = new System.Drawing.Point(20, 43);
            this.labelOgrenciEkleNumara.Name = "labelOgrenciEkleNumara";
            this.labelOgrenciEkleNumara.Size = new System.Drawing.Size(75, 18);
            this.labelOgrenciEkleNumara.TabIndex = 4;
            this.labelOgrenciEkleNumara.Text = "Numara :";
            // 
            // labelOgrenciEkleAd
            // 
            this.labelOgrenciEkleAd.AutoSize = true;
            this.labelOgrenciEkleAd.Location = new System.Drawing.Point(20, 90);
            this.labelOgrenciEkleAd.Name = "labelOgrenciEkleAd";
            this.labelOgrenciEkleAd.Size = new System.Drawing.Size(37, 18);
            this.labelOgrenciEkleAd.TabIndex = 5;
            this.labelOgrenciEkleAd.Text = "Ad :";
            // 
            // labelOgrenciEkleSoyad
            // 
            this.labelOgrenciEkleSoyad.AutoSize = true;
            this.labelOgrenciEkleSoyad.Location = new System.Drawing.Point(20, 137);
            this.labelOgrenciEkleSoyad.Name = "labelOgrenciEkleSoyad";
            this.labelOgrenciEkleSoyad.Size = new System.Drawing.Size(60, 18);
            this.labelOgrenciEkleSoyad.TabIndex = 6;
            this.labelOgrenciEkleSoyad.Text = "Soyad :";
            // 
            // ogrenciEkleMaskedTextBox
            // 
            this.ogrenciEkleMaskedTextBox.Location = new System.Drawing.Point(112, 40);
            this.ogrenciEkleMaskedTextBox.Mask = "0000";
            this.ogrenciEkleMaskedTextBox.Name = "ogrenciEkleMaskedTextBox";
            this.ogrenciEkleMaskedTextBox.Size = new System.Drawing.Size(154, 26);
            this.ogrenciEkleMaskedTextBox.TabIndex = 0;
            this.ogrenciEkleMaskedTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ogrenciEkleMaskedTextBox_KeyPress);
            // 
            // ogrenciEkleAd
            // 
            this.ogrenciEkleAd.Location = new System.Drawing.Point(112, 87);
            this.ogrenciEkleAd.Name = "ogrenciEkleAd";
            this.ogrenciEkleAd.Size = new System.Drawing.Size(154, 26);
            this.ogrenciEkleAd.TabIndex = 1;
            this.ogrenciEkleAd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ogrenciEkleAd_KeyPress);
            // 
            // ogrenciEkleSoyad
            // 
            this.ogrenciEkleSoyad.Location = new System.Drawing.Point(112, 134);
            this.ogrenciEkleSoyad.Name = "ogrenciEkleSoyad";
            this.ogrenciEkleSoyad.Size = new System.Drawing.Size(154, 26);
            this.ogrenciEkleSoyad.TabIndex = 2;
            this.ogrenciEkleSoyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ogrenciEkleSoyad_KeyPress);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1017, 331);
            this.tabControl1.TabIndex = 0;
            // 
            // lblBilgiDurum
            // 
            this.lblBilgiDurum.AutoSize = true;
            this.lblBilgiDurum.Location = new System.Drawing.Point(117, 247);
            this.lblBilgiDurum.Name = "lblBilgiDurum";
            this.lblBilgiDurum.Size = new System.Drawing.Size(28, 18);
            this.lblBilgiDurum.TabIndex = 12;
            this.lblBilgiDurum.Text = "00";
            this.lblBilgiDurum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 18);
            this.label2.TabIndex = 13;
            this.label2.Text = "Durum :";
            // 
            // FrmOgretmenDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1017, 331);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmOgretmenDetay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğretmen Detay";
            this.Load += new System.EventHandler(this.FrmOgretmenDetay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tBLDERSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbNotKayitDataSet)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DbNotKayitDataSet dbNotKayitDataSet;
        private System.Windows.Forms.BindingSource tBLDERSBindingSource;
        private DbNotKayitDataSetTableAdapters.TBL_DERSTableAdapter tBL_DERSTableAdapter;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn oGRIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oGRNUMARADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oGRADDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oGRSOYADDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oGRS1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oGRS2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oGRS3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oRTALAMADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dURUMDataGridViewCheckBoxColumn;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label labelDurumKalanSayisi;
        private System.Windows.Forms.Label labelDurumKalanSayisiValue;
        private System.Windows.Forms.Label labelDurumOrtalamaValue;
        private System.Windows.Forms.Label labelDurumOrtalama;
        private System.Windows.Forms.Label labelDurumGecenSayisi;
        private System.Windows.Forms.Label labelDurumGecenSayisiValue;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonSinavGuncelle;
        private System.Windows.Forms.Label labelSinavNotlariSinav3;
        private System.Windows.Forms.Label labelSinavNotlariSinav2;
        private System.Windows.Forms.TextBox sinavEkleTextBox1;
        private System.Windows.Forms.TextBox sinavEkleTextBox2;
        private System.Windows.Forms.TextBox sinavEkleTextBox3;
        private System.Windows.Forms.Label labelSinavNotlariSinav1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOgrenciEkle;
        private System.Windows.Forms.Label labelOgrenciEkleNumara;
        private System.Windows.Forms.Label labelOgrenciEkleAd;
        private System.Windows.Forms.Label labelOgrenciEkleSoyad;
        private System.Windows.Forms.MaskedTextBox ogrenciEkleMaskedTextBox;
        private System.Windows.Forms.TextBox ogrenciEkleAd;
        private System.Windows.Forms.TextBox ogrenciEkleSoyad;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cmbBoxNumara;
        private System.Windows.Forms.Label labelSinavNotlariOgrenciNo;
        private System.Windows.Forms.Label labelOgrenciBilgiNumara;
        private System.Windows.Forms.Label labelOgrenciBilgiNumaraValue;
        private System.Windows.Forms.Label labelOgrenciBilgiSoyad;
        private System.Windows.Forms.Label labelOgrenciBilgiSoyadValue;
        private System.Windows.Forms.Label labelOgrenciBilgiAd;
        private System.Windows.Forms.Label labelOgrenciBilgiAdValue;
        private System.Windows.Forms.Label labelOgrenciBilgiSinav3;
        private System.Windows.Forms.Label labelOgrenciBilgiSinav3Value;
        private System.Windows.Forms.Label labelOgrenciBilgiSinav2;
        private System.Windows.Forms.Label labelOgrenciBilgiSinav2Value;
        private System.Windows.Forms.Label labelOgrenciBilgiSinav1;
        private System.Windows.Forms.Label labelOgrenciBilgiSinav1Value;
        private System.Windows.Forms.Label labelDurumOgrenciSayisi;
        private System.Windows.Forms.Label labelDurumOgrenciSayisiValue;
        private System.Windows.Forms.Label lblBilgiDurum;
        private System.Windows.Forms.Label label2;
    }
}