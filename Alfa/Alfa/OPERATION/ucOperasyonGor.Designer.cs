﻿namespace Alfa.OPERATION
{
    partial class ucOperasyonGor
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_Duzenle = new System.Windows.Forms.Button();
            this.button_Sil = new System.Windows.Forms.Button();
            this.button_Ekle = new System.Windows.Forms.Button();
            this.buton_incele = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_No = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.btn_duzen_kyt = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1085, 374);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            // 
            // button_Duzenle
            // 
            this.button_Duzenle.BackColor = System.Drawing.Color.Silver;
            this.button_Duzenle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Duzenle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_Duzenle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Duzenle.Image = global::Alfa.Properties.Resources.pencil_50px;
            this.button_Duzenle.Location = new System.Drawing.Point(151, 3);
            this.button_Duzenle.Name = "button_Duzenle";
            this.button_Duzenle.Size = new System.Drawing.Size(68, 61);
            this.button_Duzenle.TabIndex = 13;
            this.button_Duzenle.UseVisualStyleBackColor = false;
            this.button_Duzenle.Click += new System.EventHandler(this.button_Duzenle_Click);
            // 
            // button_Sil
            // 
            this.button_Sil.BackColor = System.Drawing.Color.Silver;
            this.button_Sil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Sil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_Sil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Sil.Image = global::Alfa.Properties.Resources.icons8_trash_48;
            this.button_Sil.Location = new System.Drawing.Point(77, 3);
            this.button_Sil.Name = "button_Sil";
            this.button_Sil.Size = new System.Drawing.Size(68, 61);
            this.button_Sil.TabIndex = 12;
            this.button_Sil.UseVisualStyleBackColor = false;
            this.button_Sil.Click += new System.EventHandler(this.button_Sil_Click);
            // 
            // button_Ekle
            // 
            this.button_Ekle.BackColor = System.Drawing.Color.Silver;
            this.button_Ekle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Ekle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_Ekle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Ekle.Image = global::Alfa.Properties.Resources.add_48px;
            this.button_Ekle.Location = new System.Drawing.Point(3, 3);
            this.button_Ekle.Name = "button_Ekle";
            this.button_Ekle.Size = new System.Drawing.Size(68, 61);
            this.button_Ekle.TabIndex = 11;
            this.button_Ekle.UseVisualStyleBackColor = false;
            this.button_Ekle.Click += new System.EventHandler(this.button1_Click);
            // 
            // buton_incele
            // 
            this.buton_incele.BackColor = System.Drawing.Color.Silver;
            this.buton_incele.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buton_incele.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buton_incele.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buton_incele.Image = global::Alfa.Properties.Resources.view_file_50px;
            this.buton_incele.Location = new System.Drawing.Point(225, 3);
            this.buton_incele.Name = "buton_incele";
            this.buton_incele.Size = new System.Drawing.Size(68, 61);
            this.buton_incele.TabIndex = 14;
            this.buton_incele.UseVisualStyleBackColor = false;
            this.buton_incele.Click += new System.EventHandler(this.buton_incele_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Silver;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 188F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1091, 568);
            this.tableLayoutPanel1.TabIndex = 15;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.41935F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.58065F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 98F));
            this.tableLayoutPanel4.Controls.Add(this.textBox_Name, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.textBox_No, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.btn_ekle, 2, 1);
            this.tableLayoutPanel4.Controls.Add(this.btn_duzen_kyt, 2, 2);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 383);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.06897F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.93103F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(624, 182);
            this.tableLayoutPanel4.TabIndex = 24;
            // 
            // textBox_Name
            // 
            this.textBox_Name.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox_Name.Location = new System.Drawing.Point(278, 139);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(153, 20);
            this.textBox_Name.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(151, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "OPERASYON ADI:";
            // 
            // textBox_No
            // 
            this.textBox_No.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox_No.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_No.Location = new System.Drawing.Point(278, 72);
            this.textBox_No.Name = "textBox_No";
            this.textBox_No.Size = new System.Drawing.Size(153, 20);
            this.textBox_No.TabIndex = 10;
            this.textBox_No.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_No_KeyDown_1);
            this.textBox_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_No_KeyPress);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(102, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "OPERASYON NUMARASI:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(3, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 16);
            this.label4.TabIndex = 25;
            this.label4.Text = "OPERAYON EKLEME";
            // 
            // btn_ekle
            // 
            this.btn_ekle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_ekle.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_ekle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ekle.Image = global::Alfa.Properties.Resources.ekle;
            this.btn_ekle.Location = new System.Drawing.Point(537, 52);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(75, 60);
            this.btn_ekle.TabIndex = 26;
            this.btn_ekle.UseVisualStyleBackColor = false;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // btn_duzen_kyt
            // 
            this.btn_duzen_kyt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_duzen_kyt.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_duzen_kyt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_duzen_kyt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_duzen_kyt.Image = global::Alfa.Properties.Resources.approve_and_update_48px;
            this.btn_duzen_kyt.Location = new System.Drawing.Point(538, 119);
            this.btn_duzen_kyt.Name = "btn_duzen_kyt";
            this.btn_duzen_kyt.Size = new System.Drawing.Size(73, 57);
            this.btn_duzen_kyt.TabIndex = 23;
            this.btn_duzen_kyt.UseVisualStyleBackColor = false;
            this.btn_duzen_kyt.Visible = false;
            this.btn_duzen_kyt.Click += new System.EventHandler(this.btn_duzen_kyt_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Silver;
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.buton_incele, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.button_Duzenle, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.button_Ekle, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.button_Sil, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 577);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(296, 67);
            this.tableLayoutPanel2.TabIndex = 16;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.Silver;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.71716F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.28284F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1097, 647);
            this.tableLayoutPanel3.TabIndex = 17;
            // 
            // ucOperasyonGor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel3);
            this.Name = "ucOperasyonGor";
            this.Size = new System.Drawing.Size(1097, 647);
            this.Load += new System.EventHandler(this.ucOperasyonGor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_Duzenle;
        private System.Windows.Forms.Button button_Sil;
        private System.Windows.Forms.Button button_Ekle;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buton_incele;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textBox_Name;
        public System.Windows.Forms.TextBox textBox_No;
        public System.Windows.Forms.Button btn_duzen_kyt;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Button btn_ekle;
    }
}
