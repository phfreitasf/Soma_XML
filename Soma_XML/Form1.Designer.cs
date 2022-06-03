﻿namespace Soma_XML
{
    partial class Form1 
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.gridXMLS = new System.Windows.Forms.DataGridView();
            this.Emissao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Serie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RSTOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelTotal = new MaterialSkin.Controls.MaterialLabel();
            this.labelRS = new MaterialSkin.Controls.MaterialLabel();
            this.labelMoeda = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.gridXMLS)).BeginInit();
            this.SuspendLayout();
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(12, 82);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(88, 39);
            this.materialRaisedButton1.TabIndex = 1;
            this.materialRaisedButton1.Text = "Selecionar pasta";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // gridXMLS
            // 
            this.gridXMLS.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.gridXMLS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridXMLS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Emissao,
            this.Nota,
            this.Serie,
            this.RSTOTAL});
            this.gridXMLS.EnableHeadersVisualStyles = false;
            this.gridXMLS.Location = new System.Drawing.Point(1, 134);
            this.gridXMLS.Name = "gridXMLS";
            this.gridXMLS.ReadOnly = true;
            this.gridXMLS.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gridXMLS.RowHeadersVisible = false;
            this.gridXMLS.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gridXMLS.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridXMLS.RowTemplate.DividerHeight = 1;
            this.gridXMLS.RowTemplate.Height = 25;
            this.gridXMLS.RowTemplate.ReadOnly = true;
            this.gridXMLS.Size = new System.Drawing.Size(456, 348);
            this.gridXMLS.TabIndex = 2;
            // 
            // Emissao
            // 
            this.Emissao.HeaderText = "Emissão";
            this.Emissao.Name = "Emissao";
            this.Emissao.ReadOnly = true;
            // 
            // Nota
            // 
            this.Nota.HeaderText = "Nota";
            this.Nota.Name = "Nota";
            this.Nota.ReadOnly = true;
            // 
            // Serie
            // 
            this.Serie.HeaderText = "Série";
            this.Serie.Name = "Serie";
            this.Serie.ReadOnly = true;
            // 
            // RSTOTAL
            // 
            this.RSTOTAL.HeaderText = "R$ TOTAL";
            this.RSTOTAL.Name = "RSTOTAL";
            this.RSTOTAL.ReadOnly = true;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Depth = 0;
            this.labelTotal.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelTotal.Location = new System.Drawing.Point(15, 503);
            this.labelTotal.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(44, 19);
            this.labelTotal.TabIndex = 3;
            this.labelTotal.Text = "Total";
            // 
            // labelRS
            // 
            this.labelRS.AutoSize = true;
            this.labelRS.Depth = 0;
            this.labelRS.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelRS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelRS.Location = new System.Drawing.Point(90, 503);
            this.labelRS.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelRS.Name = "labelRS";
            this.labelRS.Size = new System.Drawing.Size(36, 19);
            this.labelRS.TabIndex = 2;
            this.labelRS.Text = "0,00";
            // 
            // labelMoeda
            // 
            this.labelMoeda.AutoSize = true;
            this.labelMoeda.Depth = 0;
            this.labelMoeda.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMoeda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelMoeda.Location = new System.Drawing.Point(65, 503);
            this.labelMoeda.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.labelMoeda.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelMoeda.Name = "labelMoeda";
            this.labelMoeda.Size = new System.Drawing.Size(26, 19);
            this.labelMoeda.TabIndex = 1;
            this.labelMoeda.Text = "R$";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 566);
            this.Controls.Add(this.labelMoeda);
            this.Controls.Add(this.labelRS);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.gridXMLS);
            this.Controls.Add(this.materialRaisedButton1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Sizable = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "XEMELE";
            ((System.ComponentModel.ISupportInitialize)(this.gridXMLS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private System.Windows.Forms.DataGridView gridXMLS;
        private MaterialSkin.Controls.MaterialLabel labelTotal;
        private MaterialSkin.Controls.MaterialLabel labelRS;
        private MaterialSkin.Controls.MaterialLabel labelMoeda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Emissao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nota;
        private System.Windows.Forms.DataGridViewTextBoxColumn Serie;
        private System.Windows.Forms.DataGridViewTextBoxColumn RSTOTAL;
    }
}
