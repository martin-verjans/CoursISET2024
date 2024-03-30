namespace Tic_Tac_Toe
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_2_2 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_2_1 = new System.Windows.Forms.Button();
            this.btn_2_0 = new System.Windows.Forms.Button();
            this.btn_1_1 = new System.Windows.Forms.Button();
            this.btn_1_0 = new System.Windows.Forms.Button();
            this.btn_0_2 = new System.Windows.Forms.Button();
            this.btn_0_1 = new System.Windows.Forms.Button();
            this.btn_1_2 = new System.Windows.Forms.Button();
            this.btn_0_0 = new System.Windows.Forms.Button();
            this.lblStatusText = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.btnNewGame, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblStatusText, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(630, 504);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(3, 3);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(112, 59);
            this.btnNewGame.TabIndex = 0;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 2);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel2.Controls.Add(this.btn_2_2, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.btn_2_1, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.btn_2_0, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.btn_1_1, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.btn_1_0, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btn_0_2, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_0_1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_1_2, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.btn_0_0, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 68);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(624, 433);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // btn_2_2
            // 
            this.btn_2_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_2_2.ImageIndex = 0;
            this.btn_2_2.ImageList = this.imageList1;
            this.btn_2_2.Location = new System.Drawing.Point(420, 292);
            this.btn_2_2.Name = "btn_2_2";
            this.btn_2_2.Size = new System.Drawing.Size(201, 138);
            this.btn_2_2.TabIndex = 8;
            this.btn_2_2.UseVisualStyleBackColor = true;
            this.btn_2_2.Click += new System.EventHandler(this.ButtonClick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Empty.bmp");
            this.imageList1.Images.SetKeyName(1, "Circle.bmp");
            this.imageList1.Images.SetKeyName(2, "Cross.bmp");
            // 
            // btn_2_1
            // 
            this.btn_2_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_2_1.ImageIndex = 0;
            this.btn_2_1.ImageList = this.imageList1;
            this.btn_2_1.Location = new System.Drawing.Point(208, 292);
            this.btn_2_1.Name = "btn_2_1";
            this.btn_2_1.Size = new System.Drawing.Size(206, 138);
            this.btn_2_1.TabIndex = 7;
            this.btn_2_1.UseVisualStyleBackColor = true;
            this.btn_2_1.Click += new System.EventHandler(this.ButtonClick);
            // 
            // btn_2_0
            // 
            this.btn_2_0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_2_0.ImageIndex = 0;
            this.btn_2_0.ImageList = this.imageList1;
            this.btn_2_0.Location = new System.Drawing.Point(3, 292);
            this.btn_2_0.Name = "btn_2_0";
            this.btn_2_0.Size = new System.Drawing.Size(199, 138);
            this.btn_2_0.TabIndex = 6;
            this.btn_2_0.UseVisualStyleBackColor = true;
            this.btn_2_0.Click += new System.EventHandler(this.ButtonClick);
            // 
            // btn_1_1
            // 
            this.btn_1_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_1_1.ImageIndex = 0;
            this.btn_1_1.ImageList = this.imageList1;
            this.btn_1_1.Location = new System.Drawing.Point(208, 145);
            this.btn_1_1.Name = "btn_1_1";
            this.btn_1_1.Size = new System.Drawing.Size(206, 141);
            this.btn_1_1.TabIndex = 5;
            this.btn_1_1.UseVisualStyleBackColor = true;
            this.btn_1_1.Click += new System.EventHandler(this.ButtonClick);
            // 
            // btn_1_0
            // 
            this.btn_1_0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_1_0.ImageIndex = 0;
            this.btn_1_0.ImageList = this.imageList1;
            this.btn_1_0.Location = new System.Drawing.Point(3, 145);
            this.btn_1_0.Name = "btn_1_0";
            this.btn_1_0.Size = new System.Drawing.Size(199, 141);
            this.btn_1_0.TabIndex = 4;
            this.btn_1_0.UseVisualStyleBackColor = true;
            this.btn_1_0.Click += new System.EventHandler(this.ButtonClick);
            // 
            // btn_0_2
            // 
            this.btn_0_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_0_2.ImageIndex = 0;
            this.btn_0_2.ImageList = this.imageList1;
            this.btn_0_2.Location = new System.Drawing.Point(420, 3);
            this.btn_0_2.Name = "btn_0_2";
            this.btn_0_2.Size = new System.Drawing.Size(201, 136);
            this.btn_0_2.TabIndex = 3;
            this.btn_0_2.Tag = "";
            this.btn_0_2.UseVisualStyleBackColor = true;
            this.btn_0_2.Click += new System.EventHandler(this.ButtonClick);
            // 
            // btn_0_1
            // 
            this.btn_0_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_0_1.ImageIndex = 0;
            this.btn_0_1.ImageList = this.imageList1;
            this.btn_0_1.Location = new System.Drawing.Point(208, 3);
            this.btn_0_1.Name = "btn_0_1";
            this.btn_0_1.Size = new System.Drawing.Size(206, 136);
            this.btn_0_1.TabIndex = 2;
            this.btn_0_1.UseVisualStyleBackColor = true;
            this.btn_0_1.Click += new System.EventHandler(this.ButtonClick);
            // 
            // btn_1_2
            // 
            this.btn_1_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_1_2.ImageIndex = 0;
            this.btn_1_2.ImageList = this.imageList1;
            this.btn_1_2.Location = new System.Drawing.Point(420, 145);
            this.btn_1_2.Name = "btn_1_2";
            this.btn_1_2.Size = new System.Drawing.Size(201, 141);
            this.btn_1_2.TabIndex = 1;
            this.btn_1_2.UseVisualStyleBackColor = true;
            this.btn_1_2.Click += new System.EventHandler(this.ButtonClick);
            // 
            // btn_0_0
            // 
            this.btn_0_0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_0_0.ImageIndex = 0;
            this.btn_0_0.ImageList = this.imageList1;
            this.btn_0_0.Location = new System.Drawing.Point(3, 3);
            this.btn_0_0.Name = "btn_0_0";
            this.btn_0_0.Size = new System.Drawing.Size(199, 136);
            this.btn_0_0.TabIndex = 0;
            this.btn_0_0.UseVisualStyleBackColor = true;
            this.btn_0_0.Click += new System.EventHandler(this.ButtonClick);
            // 
            // lblStatusText
            // 
            this.lblStatusText.AutoSize = true;
            this.lblStatusText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStatusText.Location = new System.Drawing.Point(121, 0);
            this.lblStatusText.Name = "lblStatusText";
            this.lblStatusText.Size = new System.Drawing.Size(506, 65);
            this.lblStatusText.TabIndex = 2;
            this.lblStatusText.Text = "Press New Game";
            this.lblStatusText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 504);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Tic-Tac-Toe";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btn_0_0;
        private System.Windows.Forms.Label lblStatusText;
        private System.Windows.Forms.Button btn_2_2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btn_2_1;
        private System.Windows.Forms.Button btn_2_0;
        private System.Windows.Forms.Button btn_1_1;
        private System.Windows.Forms.Button btn_1_0;
        private System.Windows.Forms.Button btn_0_2;
        private System.Windows.Forms.Button btn_0_1;
        private System.Windows.Forms.Button btn_1_2;
    }
}

