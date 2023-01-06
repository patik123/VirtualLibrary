namespace VirtualLibrary
{
    partial class VirtualLibraryMain
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
            this.SeznamKnjig = new System.Windows.Forms.ListView();
            this.bookTitleInput = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bookTitleLabel = new System.Windows.Forms.Label();
            this.AddBook = new System.Windows.Forms.Button();
            this.bookAuthorLabel = new System.Windows.Forms.Label();
            this.bookAuthorInput = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SeznamKnjig
            // 
            this.SeznamKnjig.HideSelection = false;
            this.SeznamKnjig.Location = new System.Drawing.Point(12, 12);
            this.SeznamKnjig.Name = "SeznamKnjig";
            this.SeznamKnjig.Size = new System.Drawing.Size(776, 97);
            this.SeznamKnjig.TabIndex = 0;
            this.SeznamKnjig.UseCompatibleStateImageBehavior = false;
            // 
            // bookTitleInput
            // 
            this.bookTitleInput.Location = new System.Drawing.Point(59, 15);
            this.bookTitleInput.Name = "bookTitleInput";
            this.bookTitleInput.Size = new System.Drawing.Size(341, 22);
            this.bookTitleInput.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bookAuthorLabel);
            this.panel1.Controls.Add(this.bookAuthorInput);
            this.panel1.Controls.Add(this.AddBook);
            this.panel1.Controls.Add(this.bookTitleLabel);
            this.panel1.Controls.Add(this.bookTitleInput);
            this.panel1.Location = new System.Drawing.Point(12, 231);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(403, 207);
            this.panel1.TabIndex = 2;
            // 
            // bookTitleLabel
            // 
            this.bookTitleLabel.AutoSize = true;
            this.bookTitleLabel.Location = new System.Drawing.Point(3, 18);
            this.bookTitleLabel.Name = "bookTitleLabel";
            this.bookTitleLabel.Size = new System.Drawing.Size(50, 16);
            this.bookTitleLabel.TabIndex = 2;
            this.bookTitleLabel.Text = "Naslov";
            // 
            // AddBook
            // 
            this.AddBook.Location = new System.Drawing.Point(6, 181);
            this.AddBook.Name = "AddBook";
            this.AddBook.Size = new System.Drawing.Size(75, 23);
            this.AddBook.TabIndex = 3;
            this.AddBook.Text = "Dodaj knjigo";
            this.AddBook.UseVisualStyleBackColor = true;
            this.AddBook.Click += new System.EventHandler(this.AddBook_Click);
            // 
            // bookAuthorLabel
            // 
            this.bookAuthorLabel.AutoSize = true;
            this.bookAuthorLabel.Location = new System.Drawing.Point(3, 51);
            this.bookAuthorLabel.Name = "bookAuthorLabel";
            this.bookAuthorLabel.Size = new System.Drawing.Size(38, 16);
            this.bookAuthorLabel.TabIndex = 5;
            this.bookAuthorLabel.Text = "Avtor";
            // 
            // bookAuthorInput
            // 
            this.bookAuthorInput.Location = new System.Drawing.Point(59, 48);
            this.bookAuthorInput.Name = "bookAuthorInput";
            this.bookAuthorInput.Size = new System.Drawing.Size(341, 22);
            this.bookAuthorInput.TabIndex = 4;
            // 
            // VirtualLibraryMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SeznamKnjig);
            this.Name = "VirtualLibraryMain";
            this.Text = "VirtualLibrary";
            this.Load += new System.EventHandler(this.VirtualLibraryMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView SeznamKnjig;
        private System.Windows.Forms.TextBox bookTitleInput;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label bookTitleLabel;
        private System.Windows.Forms.Button AddBook;
        private System.Windows.Forms.Label bookAuthorLabel;
        private System.Windows.Forms.TextBox bookAuthorInput;
    }
}

