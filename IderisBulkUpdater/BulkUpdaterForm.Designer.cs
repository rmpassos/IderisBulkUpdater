
namespace IderisBulkUpdater
{
    partial class BulkUpdaterForm
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
            this.token = new System.Windows.Forms.TextBox();
            this.lblToken = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.dg = new System.Windows.Forms.DataGridView();
            this.lblOffset = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btnBuscarProdutos = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnEnviarIderis = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // token
            // 
            this.token.Location = new System.Drawing.Point(109, 15);
            this.token.Name = "token";
            this.token.PasswordChar = '*';
            this.token.Size = new System.Drawing.Size(354, 23);
            this.token.TabIndex = 0;
            this.token.UseSystemPasswordChar = true;
            // 
            // lblToken
            // 
            this.lblToken.AutoSize = true;
            this.lblToken.Location = new System.Drawing.Point(3, 18);
            this.lblToken.Name = "lblToken";
            this.lblToken.Size = new System.Drawing.Size(100, 15);
            this.lblToken.TabIndex = 1;
            this.lblToken.Text = "Token integração:";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(469, 15);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Log in";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // dg
            // 
            this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dg.Location = new System.Drawing.Point(0, 0);
            this.dg.Name = "dg";
            this.dg.RowTemplate.Height = 25;
            this.dg.Size = new System.Drawing.Size(1526, 494);
            this.dg.TabIndex = 3;
            // 
            // lblOffset
            // 
            this.lblOffset.AutoSize = true;
            this.lblOffset.Location = new System.Drawing.Point(550, 17);
            this.lblOffset.Name = "lblOffset";
            this.lblOffset.Size = new System.Drawing.Size(39, 15);
            this.lblOffset.TabIndex = 5;
            this.lblOffset.Text = "Offset";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(595, 14);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(48, 23);
            this.numericUpDown1.TabIndex = 6;
            // 
            // btnBuscarProdutos
            // 
            this.btnBuscarProdutos.Location = new System.Drawing.Point(649, 14);
            this.btnBuscarProdutos.Name = "btnBuscarProdutos";
            this.btnBuscarProdutos.Size = new System.Drawing.Size(98, 23);
            this.btnBuscarProdutos.TabIndex = 7;
            this.btnBuscarProdutos.Text = "BuscarProdutos";
            this.btnBuscarProdutos.UseVisualStyleBackColor = true;
            this.btnBuscarProdutos.Click += new System.EventHandler(this.btnBuscarProdutos_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnEnviarIderis);
            this.splitContainer1.Panel1.Controls.Add(this.token);
            this.splitContainer1.Panel1.Controls.Add(this.lblToken);
            this.splitContainer1.Panel1.Controls.Add(this.btnBuscarProdutos);
            this.splitContainer1.Panel1.Controls.Add(this.numericUpDown1);
            this.splitContainer1.Panel1.Controls.Add(this.btnLogin);
            this.splitContainer1.Panel1.Controls.Add(this.lblOffset);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dg);
            this.splitContainer1.Size = new System.Drawing.Size(1526, 608);
            this.splitContainer1.SplitterDistance = 110;
            this.splitContainer1.TabIndex = 8;
            // 
            // btnEnviarIderis
            // 
            this.btnEnviarIderis.Location = new System.Drawing.Point(753, 14);
            this.btnEnviarIderis.Name = "btnEnviarIderis";
            this.btnEnviarIderis.Size = new System.Drawing.Size(98, 23);
            this.btnEnviarIderis.TabIndex = 10;
            this.btnEnviarIderis.Text = "Enviar p/ Ideris";
            this.btnEnviarIderis.UseVisualStyleBackColor = true;
            this.btnEnviarIderis.Click += new System.EventHandler(this.ris_Click);
            // 
            // BulkUpdaterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1526, 608);
            this.Controls.Add(this.splitContainer1);
            this.Name = "BulkUpdaterForm";
            this.Text = "Ideris Bulk Updater";
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox token;
        private System.Windows.Forms.Label lblToken;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.DataGridView dg;
        private System.Windows.Forms.Label lblOffset;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btnBuscarProdutos;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnEnviarIderis;
    }
}

