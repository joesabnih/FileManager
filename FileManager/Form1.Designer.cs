namespace FileManager
{
    partial class Form1
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
            this.btnOpen = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnForward = new System.Windows.Forms.Button();
            this.btnCreateFolder = new System.Windows.Forms.Button();
            this.btnDelFolder = new System.Windows.Forms.Button();
            this.btnCreateTxt = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.txtFolderName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnChange = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.richtxt = new System.Windows.Forms.RichTextBox();
            this.txtPathFile = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnFromMove = new System.Windows.Forms.Button();
            this.btnToMove = new System.Windows.Forms.Button();
            this.btnFromCopy = new System.Windows.Forms.Button();
            this.btnTOCopy = new System.Windows.Forms.Button();
            this.btnFromMoveText = new System.Windows.Forms.Button();
            this.btnToMoveText = new System.Windows.Forms.Button();
            this.btnFromCopyText = new System.Windows.Forms.Button();
            this.btnToCopyText = new System.Windows.Forms.Button();
            this.txtPathFolder = new System.Windows.Forms.TextBox();
            this.txtpathFileM = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(449, 53);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Browse";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(29, 53);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(414, 22);
            this.txtPath.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 6;
            // 
            // webBrowser
            // 
            this.webBrowser.Location = new System.Drawing.Point(29, 110);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(746, 293);
            this.webBrowser.TabIndex = 3;
            this.webBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser_DocumentCompleted);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(29, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnForward
            // 
            this.btnForward.Location = new System.Drawing.Point(121, 12);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(75, 23);
            this.btnForward.TabIndex = 5;
            this.btnForward.Text = "Forward";
            this.btnForward.UseVisualStyleBackColor = true;
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // btnCreateFolder
            // 
            this.btnCreateFolder.Location = new System.Drawing.Point(242, 82);
            this.btnCreateFolder.Name = "btnCreateFolder";
            this.btnCreateFolder.Size = new System.Drawing.Size(111, 23);
            this.btnCreateFolder.TabIndex = 7;
            this.btnCreateFolder.Text = "Create Folder";
            this.btnCreateFolder.UseVisualStyleBackColor = true;
            this.btnCreateFolder.Click += new System.EventHandler(this.btnCreateFolder_Click);
            // 
            // btnDelFolder
            // 
            this.btnDelFolder.Location = new System.Drawing.Point(368, 82);
            this.btnDelFolder.Name = "btnDelFolder";
            this.btnDelFolder.Size = new System.Drawing.Size(75, 23);
            this.btnDelFolder.TabIndex = 8;
            this.btnDelFolder.Text = "Delete Folder";
            this.btnDelFolder.UseVisualStyleBackColor = true;
            this.btnDelFolder.Click += new System.EventHandler(this.btnDelFolder_Click);
            // 
            // btnCreateTxt
            // 
            this.btnCreateTxt.Location = new System.Drawing.Point(254, 440);
            this.btnCreateTxt.Name = "btnCreateTxt";
            this.btnCreateTxt.Size = new System.Drawing.Size(123, 22);
            this.btnCreateTxt.TabIndex = 9;
            this.btnCreateTxt.Text = "Create Text File";
            this.btnCreateTxt.UseVisualStyleBackColor = true;
            this.btnCreateTxt.Click += new System.EventHandler(this.btnCreateTxt_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 34;
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(137, 440);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(100, 22);
            this.txtFileName.TabIndex = 11;
            // 
            // txtFolderName
            // 
            this.txtFolderName.Location = new System.Drawing.Point(121, 82);
            this.txtFolderName.Name = "txtFolderName";
            this.txtFolderName.Size = new System.Drawing.Size(115, 22);
            this.txtFolderName.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Folder name";
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(449, 82);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(92, 22);
            this.btnChange.TabIndex = 14;
            this.btnChange.Text = "Rename";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(392, 412);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 26);
            this.button1.TabIndex = 15;
            this.button1.Text = "Load File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(392, 438);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 24);
            this.button2.TabIndex = 16;
            this.button2.Text = "Save Text";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(557, 439);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 17;
            this.button3.Text = "Elimaned Text";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // richtxt
            // 
            this.richtxt.Location = new System.Drawing.Point(29, 463);
            this.richtxt.Name = "richtxt";
            this.richtxt.Size = new System.Drawing.Size(746, 130);
            this.richtxt.TabIndex = 18;
            this.richtxt.Text = "";
            // 
            // txtPathFile
            // 
            this.txtPathFile.Location = new System.Drawing.Point(31, 414);
            this.txtPathFile.Name = "txtPathFile";
            this.txtPathFile.Size = new System.Drawing.Size(345, 22);
            this.txtPathFile.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(825, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Move Folder";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(825, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "Copy Folder";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(860, 466);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 16);
            this.label6.TabIndex = 22;
            this.label6.Text = "Move File";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(860, 538);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 16);
            this.label7.TabIndex = 23;
            this.label7.Text = "Copy File";
            // 
            // btnFromMove
            // 
            this.btnFromMove.Location = new System.Drawing.Point(801, 147);
            this.btnFromMove.Name = "btnFromMove";
            this.btnFromMove.Size = new System.Drawing.Size(75, 23);
            this.btnFromMove.TabIndex = 24;
            this.btnFromMove.Text = "From";
            this.btnFromMove.UseVisualStyleBackColor = true;
            this.btnFromMove.Click += new System.EventHandler(this.btnFromMove_Click);
            // 
            // btnToMove
            // 
            this.btnToMove.Location = new System.Drawing.Point(904, 147);
            this.btnToMove.Name = "btnToMove";
            this.btnToMove.Size = new System.Drawing.Size(75, 23);
            this.btnToMove.TabIndex = 25;
            this.btnToMove.Text = "To";
            this.btnToMove.UseVisualStyleBackColor = true;
            this.btnToMove.Click += new System.EventHandler(this.btnToMove_Click);
            // 
            // btnFromCopy
            // 
            this.btnFromCopy.Location = new System.Drawing.Point(801, 237);
            this.btnFromCopy.Name = "btnFromCopy";
            this.btnFromCopy.Size = new System.Drawing.Size(75, 23);
            this.btnFromCopy.TabIndex = 26;
            this.btnFromCopy.Text = "From";
            this.btnFromCopy.UseVisualStyleBackColor = true;
            this.btnFromCopy.Click += new System.EventHandler(this.btnFromCopy_Click);
            // 
            // btnTOCopy
            // 
            this.btnTOCopy.Location = new System.Drawing.Point(904, 237);
            this.btnTOCopy.Name = "btnTOCopy";
            this.btnTOCopy.Size = new System.Drawing.Size(75, 23);
            this.btnTOCopy.TabIndex = 27;
            this.btnTOCopy.Text = "To";
            this.btnTOCopy.UseVisualStyleBackColor = true;
            this.btnTOCopy.Click += new System.EventHandler(this.btnTOCopy_Click);
            // 
            // btnFromMoveText
            // 
            this.btnFromMoveText.Location = new System.Drawing.Point(801, 495);
            this.btnFromMoveText.Name = "btnFromMoveText";
            this.btnFromMoveText.Size = new System.Drawing.Size(75, 23);
            this.btnFromMoveText.TabIndex = 28;
            this.btnFromMoveText.Text = "From";
            this.btnFromMoveText.UseVisualStyleBackColor = true;
            this.btnFromMoveText.Click += new System.EventHandler(this.btnFromMoveText_Click);
            // 
            // btnToMoveText
            // 
            this.btnToMoveText.Location = new System.Drawing.Point(904, 495);
            this.btnToMoveText.Name = "btnToMoveText";
            this.btnToMoveText.Size = new System.Drawing.Size(75, 23);
            this.btnToMoveText.TabIndex = 29;
            this.btnToMoveText.Text = "To";
            this.btnToMoveText.UseVisualStyleBackColor = true;
            this.btnToMoveText.Click += new System.EventHandler(this.btnToMoveText_Click);
            // 
            // btnFromCopyText
            // 
            this.btnFromCopyText.Location = new System.Drawing.Point(801, 570);
            this.btnFromCopyText.Name = "btnFromCopyText";
            this.btnFromCopyText.Size = new System.Drawing.Size(75, 23);
            this.btnFromCopyText.TabIndex = 30;
            this.btnFromCopyText.Text = "From";
            this.btnFromCopyText.UseVisualStyleBackColor = true;
            this.btnFromCopyText.Click += new System.EventHandler(this.btnFromCopyText_Click);
            // 
            // btnToCopyText
            // 
            this.btnToCopyText.Location = new System.Drawing.Point(904, 570);
            this.btnToCopyText.Name = "btnToCopyText";
            this.btnToCopyText.Size = new System.Drawing.Size(75, 23);
            this.btnToCopyText.TabIndex = 31;
            this.btnToCopyText.Text = "to";
            this.btnToCopyText.UseVisualStyleBackColor = true;
            this.btnToCopyText.Click += new System.EventHandler(this.btnToCopyText_Click);
            // 
            // txtPathFolder
            // 
            this.txtPathFolder.Location = new System.Drawing.Point(801, 85);
            this.txtPathFolder.Name = "txtPathFolder";
            this.txtPathFolder.Size = new System.Drawing.Size(178, 22);
            this.txtPathFolder.TabIndex = 32;
            // 
            // txtpathFileM
            // 
            this.txtpathFileM.Location = new System.Drawing.Point(801, 437);
            this.txtpathFileM.Name = "txtpathFileM";
            this.txtpathFileM.Size = new System.Drawing.Size(178, 22);
            this.txtpathFileM.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 442);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 16);
            this.label8.TabIndex = 35;
            this.label8.Text = "File Name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 634);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtpathFileM);
            this.Controls.Add(this.txtPathFolder);
            this.Controls.Add(this.btnToCopyText);
            this.Controls.Add(this.btnFromCopyText);
            this.Controls.Add(this.btnToMoveText);
            this.Controls.Add(this.btnFromMoveText);
            this.Controls.Add(this.btnTOCopy);
            this.Controls.Add(this.btnFromCopy);
            this.Controls.Add(this.btnToMove);
            this.Controls.Add(this.btnFromMove);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPathFile);
            this.Controls.Add(this.richtxt);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFolderName);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCreateTxt);
            this.Controls.Add(this.btnDelFolder);
            this.Controls.Add(this.btnCreateFolder);
            this.Controls.Add(this.btnForward);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.btnOpen);
            this.Name = "Form1";
            this.Text = "Remove File";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.Button btnCreateFolder;
        private System.Windows.Forms.Button btnDelFolder;
        private System.Windows.Forms.Button btnCreateTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.TextBox txtFolderName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RichTextBox richtxt;
        private System.Windows.Forms.TextBox txtPathFile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnFromMove;
        private System.Windows.Forms.Button btnToMove;
        private System.Windows.Forms.Button btnFromCopy;
        private System.Windows.Forms.Button btnTOCopy;
        private System.Windows.Forms.Button btnFromMoveText;
        private System.Windows.Forms.Button btnToMoveText;
        private System.Windows.Forms.Button btnFromCopyText;
        private System.Windows.Forms.Button btnToCopyText;
        private System.Windows.Forms.TextBox txtPathFolder;
        private System.Windows.Forms.TextBox txtpathFileM;
        private System.Windows.Forms.Label label8;
    }
}

