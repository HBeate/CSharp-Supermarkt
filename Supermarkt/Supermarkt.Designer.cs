namespace Supermarkt
{
    partial class Supermarkt
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lbItem = new System.Windows.Forms.Label();
            this.lbAmount = new System.Windows.Forms.Label();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.tbItem = new System.Windows.Forms.TextBox();
            this.lBoxItems = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(540, 56);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(119, 34);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Hinzufügen";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(664, 57);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(110, 34);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "Entfernen";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lbItem
            // 
            this.lbItem.AutoSize = true;
            this.lbItem.Location = new System.Drawing.Point(18, 65);
            this.lbItem.Name = "lbItem";
            this.lbItem.Size = new System.Drawing.Size(57, 17);
            this.lbItem.TabIndex = 2;
            this.lbItem.Text = "Produkt";
            // 
            // lbAmount
            // 
            this.lbAmount.AutoSize = true;
            this.lbAmount.Location = new System.Drawing.Point(393, 65);
            this.lbAmount.Name = "lbAmount";
            this.lbAmount.Size = new System.Drawing.Size(51, 17);
            this.lbAmount.TabIndex = 3;
            this.lbAmount.Text = "Anzahl";
            // 
            // tbAmount
            // 
            this.tbAmount.Location = new System.Drawing.Point(450, 63);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(70, 22);
            this.tbAmount.TabIndex = 2;
            this.tbAmount.Text = "1";
            // 
            // tbItem
            // 
            this.tbItem.Location = new System.Drawing.Point(83, 63);
            this.tbItem.Name = "tbItem";
            this.tbItem.Size = new System.Drawing.Size(257, 22);
            this.tbItem.TabIndex = 1;
            // 
            // lBoxItems
            // 
            this.lBoxItems.FormattingEnabled = true;
            this.lBoxItems.ItemHeight = 16;
            this.lBoxItems.Location = new System.Drawing.Point(15, 147);
            this.lBoxItems.Name = "lBoxItems";
            this.lBoxItems.Size = new System.Drawing.Size(759, 228);
            this.lBoxItems.TabIndex = 7;
            // 
            // Supermarkt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lBoxItems);
            this.Controls.Add(this.tbItem);
            this.Controls.Add(this.tbAmount);
            this.Controls.Add(this.lbAmount);
            this.Controls.Add(this.lbItem);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Name = "Supermarkt";
            this.Text = "Supermarkt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label lbItem;
        private System.Windows.Forms.Label lbAmount;
        private System.Windows.Forms.TextBox tbAmount;
        private System.Windows.Forms.TextBox tbItem;
        private System.Windows.Forms.ListBox lBoxItems;
    }
}

