
namespace SendKeysTo
{
    partial class SendKeysForm
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
            this.processLabel = new System.Windows.Forms.Label();
            this.processBox = new System.Windows.Forms.ComboBox();
            this.textArea = new System.Windows.Forms.TextBox();
            this.sendKeysBtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuDropdown = new System.Windows.Forms.ToolStripMenuItem();
            this.RefreshProcListOpt = new System.Windows.Forms.ToolStripMenuItem();
            this.WordWrapOpt = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // processLabel
            // 
            this.processLabel.AutoSize = true;
            this.processLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.processLabel.Location = new System.Drawing.Point(0, 0);
            this.processLabel.Name = "processLabel";
            this.processLabel.Size = new System.Drawing.Size(48, 13);
            this.processLabel.TabIndex = 0;
            this.processLabel.Text = "Process:";
            // 
            // processBox
            // 
            this.processBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.processBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.processBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.processBox.FormattingEnabled = true;
            this.processBox.Location = new System.Drawing.Point(48, 0);
            this.processBox.Margin = new System.Windows.Forms.Padding(5);
            this.processBox.Name = "processBox";
            this.processBox.Size = new System.Drawing.Size(747, 21);
            this.processBox.Sorted = true;
            this.processBox.TabIndex = 1;
            // 
            // textArea
            // 
            this.textArea.AllowDrop = true;
            this.textArea.CausesValidation = false;
            this.textArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textArea.HideSelection = false;
            this.textArea.Location = new System.Drawing.Point(0, 54);
            this.textArea.Margin = new System.Windows.Forms.Padding(0);
            this.textArea.MinimumSize = new System.Drawing.Size(100, 50);
            this.textArea.Multiline = true;
            this.textArea.Name = "textArea";
            this.textArea.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textArea.Size = new System.Drawing.Size(795, 493);
            this.textArea.TabIndex = 2;
            this.textArea.WordWrap = false;
            // 
            // sendKeysBtn
            // 
            this.sendKeysBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.sendKeysBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sendKeysBtn.Location = new System.Drawing.Point(0, 547);
            this.sendKeysBtn.MaximumSize = new System.Drawing.Size(0, 30);
            this.sendKeysBtn.MinimumSize = new System.Drawing.Size(0, 30);
            this.sendKeysBtn.Name = "sendKeysBtn";
            this.sendKeysBtn.Size = new System.Drawing.Size(795, 30);
            this.sendKeysBtn.TabIndex = 3;
            this.sendKeysBtn.Text = "Send text to selected process";
            this.sendKeysBtn.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuDropdown});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(795, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuDropdown
            // 
            this.MenuDropdown.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RefreshProcListOpt,
            this.WordWrapOpt});
            this.MenuDropdown.Name = "MenuDropdown";
            this.MenuDropdown.Size = new System.Drawing.Size(50, 20);
            this.MenuDropdown.Text = "Menu";
            // 
            // RefreshProcListOpt
            // 
            this.RefreshProcListOpt.Name = "RefreshProcListOpt";
            this.RefreshProcListOpt.Size = new System.Drawing.Size(177, 22);
            this.RefreshProcListOpt.Text = "Refresh Process List";
            this.RefreshProcListOpt.Click += new System.EventHandler(this.RefreshProcListOpt_Click);
            // 
            // WordWrapOpt
            // 
            this.WordWrapOpt.Name = "WordWrapOpt";
            this.WordWrapOpt.Size = new System.Drawing.Size(177, 22);
            this.WordWrapOpt.Text = "Word Wrap";
            this.WordWrapOpt.Click += new System.EventHandler(this.WordWrapOpt_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.processBox);
            this.panel1.Controls.Add(this.processLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.MaximumSize = new System.Drawing.Size(0, 30);
            this.panel1.MinimumSize = new System.Drawing.Size(0, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(795, 30);
            this.panel1.TabIndex = 6;
            // 
            // SendKeysForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 577);
            this.Controls.Add(this.textArea);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sendKeysBtn);
            this.Controls.Add(this.menuStrip1);
            this.Name = "SendKeysForm";
            this.Text = "SendKeysTo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label processLabel;
        private System.Windows.Forms.ComboBox processBox;
        private System.Windows.Forms.TextBox textArea;
        private System.Windows.Forms.Button sendKeysBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuDropdown;
        private System.Windows.Forms.ToolStripMenuItem RefreshProcListOpt;
        private System.Windows.Forms.ToolStripMenuItem WordWrapOpt;
        private System.Windows.Forms.Panel panel1;
    }
}

