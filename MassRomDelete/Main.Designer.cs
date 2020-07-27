namespace MassRomDelete
{
    partial class Main
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtRomsFolder = new System.Windows.Forms.TextBox();
            this.btnRomsFolder = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtNameFilter = new System.Windows.Forms.TextBox();
            this.txtGenreFilter = new System.Windows.Forms.TextBox();
            this.romsFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.imagesFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.cbNameFilter = new System.Windows.Forms.CheckBox();
            this.cbGenreFilter = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Roms Folder";
            // 
            // txtRomsFolder
            // 
            this.txtRomsFolder.Location = new System.Drawing.Point(91, 20);
            this.txtRomsFolder.Name = "txtRomsFolder";
            this.txtRomsFolder.Size = new System.Drawing.Size(364, 20);
            this.txtRomsFolder.TabIndex = 1;
            // 
            // btnRomsFolder
            // 
            this.btnRomsFolder.Location = new System.Drawing.Point(461, 19);
            this.btnRomsFolder.Name = "btnRomsFolder";
            this.btnRomsFolder.Size = new System.Drawing.Size(25, 20);
            this.btnRomsFolder.TabIndex = 2;
            this.btnRomsFolder.Text = "...";
            this.btnRomsFolder.UseVisualStyleBackColor = true;
            this.btnRomsFolder.Click += new System.EventHandler(this.BtnRomsFolder_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(209, 116);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // txtNameFilter
            // 
            this.txtNameFilter.Location = new System.Drawing.Point(91, 48);
            this.txtNameFilter.Name = "txtNameFilter";
            this.txtNameFilter.Size = new System.Drawing.Size(364, 20);
            this.txtNameFilter.TabIndex = 4;
            // 
            // txtGenreFilter
            // 
            this.txtGenreFilter.Location = new System.Drawing.Point(91, 74);
            this.txtGenreFilter.Name = "txtGenreFilter";
            this.txtGenreFilter.Size = new System.Drawing.Size(364, 20);
            this.txtGenreFilter.TabIndex = 6;
            // 
            // romsFolderDialog
            // 
            this.romsFolderDialog.ShowNewFolderButton = false;
            // 
            // imagesFolderDialog
            // 
            this.imagesFolderDialog.ShowNewFolderButton = false;
            // 
            // cbNameFilter
            // 
            this.cbNameFilter.AutoSize = true;
            this.cbNameFilter.Location = new System.Drawing.Point(5, 51);
            this.cbNameFilter.Name = "cbNameFilter";
            this.cbNameFilter.Size = new System.Drawing.Size(79, 17);
            this.cbNameFilter.TabIndex = 3;
            this.cbNameFilter.Text = "Name Filter";
            this.cbNameFilter.UseVisualStyleBackColor = true;
            // 
            // cbGenreFilter
            // 
            this.cbGenreFilter.AutoSize = true;
            this.cbGenreFilter.Location = new System.Drawing.Point(5, 77);
            this.cbGenreFilter.Name = "cbGenreFilter";
            this.cbGenreFilter.Size = new System.Drawing.Size(80, 17);
            this.cbGenreFilter.TabIndex = 5;
            this.cbGenreFilter.Text = "Genre Filter";
            this.cbGenreFilter.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 151);
            this.Controls.Add(this.cbGenreFilter);
            this.Controls.Add(this.cbNameFilter);
            this.Controls.Add(this.txtGenreFilter);
            this.Controls.Add(this.txtNameFilter);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnRomsFolder);
            this.Controls.Add(this.txtRomsFolder);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Massive Roms Delete";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRomsFolder;
        private System.Windows.Forms.Button btnRomsFolder;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtNameFilter;
        private System.Windows.Forms.TextBox txtGenreFilter;
        private System.Windows.Forms.FolderBrowserDialog romsFolderDialog;
        private System.Windows.Forms.FolderBrowserDialog imagesFolderDialog;
        private System.Windows.Forms.CheckBox cbNameFilter;
        private System.Windows.Forms.CheckBox cbGenreFilter;
    }
}