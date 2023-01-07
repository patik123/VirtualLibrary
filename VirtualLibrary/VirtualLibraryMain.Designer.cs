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
            this.updateButton = new System.Windows.Forms.Button();
            this.bookPagesLabel = new System.Windows.Forms.Label();
            this.bookPagesInput = new System.Windows.Forms.TextBox();
            this.bookYearLabel = new System.Windows.Forms.Label();
            this.bookYearInput = new System.Windows.Forms.TextBox();
            this.bookPublisherLabel = new System.Windows.Forms.Label();
            this.bookPublisherInput = new System.Windows.Forms.TextBox();
            this.bookISBNLabel = new System.Windows.Forms.Label();
            this.bookISBNInput = new System.Windows.Forms.TextBox();
            this.bookAuthorLabel = new System.Windows.Forms.Label();
            this.bookAuthorInput = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.bookTitleLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SeznamKnjig
            // 
            this.SeznamKnjig.FullRowSelect = true;
            this.SeznamKnjig.GridLines = true;
            this.SeznamKnjig.HideSelection = false;
            this.SeznamKnjig.Location = new System.Drawing.Point(12, 12);
            this.SeznamKnjig.Name = "SeznamKnjig";
            this.SeznamKnjig.Size = new System.Drawing.Size(776, 185);
            this.SeznamKnjig.TabIndex = 0;
            this.SeznamKnjig.UseCompatibleStateImageBehavior = false;
            this.SeznamKnjig.SelectedIndexChanged += new System.EventHandler(this.SeznamKnjig_SelectedIndexChanged);
            // 
            // bookTitleInput
            // 
            this.bookTitleInput.Location = new System.Drawing.Point(110, 15);
            this.bookTitleInput.Name = "bookTitleInput";
            this.bookTitleInput.Size = new System.Drawing.Size(290, 22);
            this.bookTitleInput.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.updateButton);
            this.panel1.Controls.Add(this.bookPagesLabel);
            this.panel1.Controls.Add(this.bookPagesInput);
            this.panel1.Controls.Add(this.bookYearLabel);
            this.panel1.Controls.Add(this.bookYearInput);
            this.panel1.Controls.Add(this.bookPublisherLabel);
            this.panel1.Controls.Add(this.bookPublisherInput);
            this.panel1.Controls.Add(this.bookISBNLabel);
            this.panel1.Controls.Add(this.bookISBNInput);
            this.panel1.Controls.Add(this.bookAuthorLabel);
            this.panel1.Controls.Add(this.bookAuthorInput);
            this.panel1.Controls.Add(this.addButton);
            this.panel1.Controls.Add(this.bookTitleLabel);
            this.panel1.Controls.Add(this.bookTitleInput);
            this.panel1.Location = new System.Drawing.Point(12, 203);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(411, 235);
            this.panel1.TabIndex = 2;
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(132)))), ((int)(((byte)(199)))));
            this.updateButton.Location = new System.Drawing.Point(88, 201);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(107, 31);
            this.updateButton.TabIndex = 14;
            this.updateButton.Text = "Posodobi";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // bookPagesLabel
            // 
            this.bookPagesLabel.AutoSize = true;
            this.bookPagesLabel.Location = new System.Drawing.Point(3, 160);
            this.bookPagesLabel.Name = "bookPagesLabel";
            this.bookPagesLabel.Size = new System.Drawing.Size(83, 16);
            this.bookPagesLabel.TabIndex = 13;
            this.bookPagesLabel.Text = "Število strani";
            // 
            // bookPagesInput
            // 
            this.bookPagesInput.Location = new System.Drawing.Point(110, 160);
            this.bookPagesInput.Name = "bookPagesInput";
            this.bookPagesInput.Size = new System.Drawing.Size(290, 22);
            this.bookPagesInput.TabIndex = 12;
            // 
            // bookYearLabel
            // 
            this.bookYearLabel.AutoSize = true;
            this.bookYearLabel.Location = new System.Drawing.Point(3, 132);
            this.bookYearLabel.Name = "bookYearLabel";
            this.bookYearLabel.Size = new System.Drawing.Size(72, 16);
            this.bookYearLabel.TabIndex = 11;
            this.bookYearLabel.Text = "Leto izdaje";
            // 
            // bookYearInput
            // 
            this.bookYearInput.Location = new System.Drawing.Point(110, 132);
            this.bookYearInput.Name = "bookYearInput";
            this.bookYearInput.Size = new System.Drawing.Size(290, 22);
            this.bookYearInput.TabIndex = 10;
            // 
            // bookPublisherLabel
            // 
            this.bookPublisherLabel.AutoSize = true;
            this.bookPublisherLabel.Location = new System.Drawing.Point(3, 104);
            this.bookPublisherLabel.Name = "bookPublisherLabel";
            this.bookPublisherLabel.Size = new System.Drawing.Size(56, 16);
            this.bookPublisherLabel.TabIndex = 9;
            this.bookPublisherLabel.Text = "Zalozba";
            // 
            // bookPublisherInput
            // 
            this.bookPublisherInput.Location = new System.Drawing.Point(110, 104);
            this.bookPublisherInput.Name = "bookPublisherInput";
            this.bookPublisherInput.Size = new System.Drawing.Size(290, 22);
            this.bookPublisherInput.TabIndex = 8;
            // 
            // bookISBNLabel
            // 
            this.bookISBNLabel.AutoSize = true;
            this.bookISBNLabel.Location = new System.Drawing.Point(3, 76);
            this.bookISBNLabel.Name = "bookISBNLabel";
            this.bookISBNLabel.Size = new System.Drawing.Size(38, 16);
            this.bookISBNLabel.TabIndex = 7;
            this.bookISBNLabel.Text = "ISBN";
            // 
            // bookISBNInput
            // 
            this.bookISBNInput.Location = new System.Drawing.Point(110, 76);
            this.bookISBNInput.Name = "bookISBNInput";
            this.bookISBNInput.Size = new System.Drawing.Size(290, 22);
            this.bookISBNInput.TabIndex = 6;
            // 
            // bookAuthorLabel
            // 
            this.bookAuthorLabel.AutoSize = true;
            this.bookAuthorLabel.Location = new System.Drawing.Point(3, 45);
            this.bookAuthorLabel.Name = "bookAuthorLabel";
            this.bookAuthorLabel.Size = new System.Drawing.Size(38, 16);
            this.bookAuthorLabel.TabIndex = 5;
            this.bookAuthorLabel.Text = "Avtor";
            // 
            // bookAuthorInput
            // 
            this.bookAuthorInput.Location = new System.Drawing.Point(110, 45);
            this.bookAuthorInput.Name = "bookAuthorInput";
            this.bookAuthorInput.Size = new System.Drawing.Size(290, 22);
            this.bookAuthorInput.TabIndex = 4;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(163)))), ((int)(((byte)(74)))));
            this.addButton.Location = new System.Drawing.Point(6, 201);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(80, 31);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Dodaj knjigo";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.AddBook_Click);
            // 
            // bookTitleLabel
            // 
            this.bookTitleLabel.AutoSize = true;
            this.bookTitleLabel.Location = new System.Drawing.Point(3, 15);
            this.bookTitleLabel.Name = "bookTitleLabel";
            this.bookTitleLabel.Size = new System.Drawing.Size(50, 16);
            this.bookTitleLabel.TabIndex = 2;
            this.bookTitleLabel.Text = "Naslov";
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
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label bookAuthorLabel;
        private System.Windows.Forms.TextBox bookAuthorInput;
        private System.Windows.Forms.Label bookISBNLabel;
        private System.Windows.Forms.TextBox bookISBNInput;
        private System.Windows.Forms.Label bookPublisherLabel;
        private System.Windows.Forms.TextBox bookPublisherInput;
        private System.Windows.Forms.Label bookPagesLabel;
        private System.Windows.Forms.TextBox bookPagesInput;
        private System.Windows.Forms.Label bookYearLabel;
        private System.Windows.Forms.TextBox bookYearInput;
        private System.Windows.Forms.Button updateButton;
    }
}

