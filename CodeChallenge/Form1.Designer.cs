
namespace CodeChallenge
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.loadButton = new System.Windows.Forms.Button();
            this.myGridView = new System.Windows.Forms.DataGridView();
            this.changeChar = new System.Windows.Forms.Button();
            this.myCombo = new System.Windows.Forms.ComboBox();
            this.populateCombo = new System.Windows.Forms.Button();
            this.comboShow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.myGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // loadButton
            // 
            resources.ApplyResources(this.loadButton, "loadButton");
            this.loadButton.Name = "loadButton";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // myGridView
            // 
            this.myGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.myGridView, "myGridView");
            this.myGridView.Name = "myGridView";
            this.myGridView.RowTemplate.Height = 24;
            // 
            // changeChar
            // 
            resources.ApplyResources(this.changeChar, "changeChar");
            this.changeChar.Name = "changeChar";
            this.changeChar.UseVisualStyleBackColor = true;
            this.changeChar.Click += new System.EventHandler(this.changeChar_Click);
            // 
            // myCombo
            // 
            this.myCombo.FormattingEnabled = true;
            resources.ApplyResources(this.myCombo, "myCombo");
            this.myCombo.Name = "myCombo";
            // 
            // populateCombo
            // 
            resources.ApplyResources(this.populateCombo, "populateCombo");
            this.populateCombo.Name = "populateCombo";
            this.populateCombo.UseVisualStyleBackColor = true;
            this.populateCombo.Click += new System.EventHandler(this.populateCombo_Click);
            // 
            // comboShow
            // 
            resources.ApplyResources(this.comboShow, "comboShow");
            this.comboShow.Name = "comboShow";
            this.comboShow.UseVisualStyleBackColor = true;
            this.comboShow.Click += new System.EventHandler(this.comboShow_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboShow);
            this.Controls.Add(this.populateCombo);
            this.Controls.Add(this.myCombo);
            this.Controls.Add(this.changeChar);
            this.Controls.Add(this.myGridView);
            this.Controls.Add(this.loadButton);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.myGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.DataGridView myGridView;
        private System.Windows.Forms.Button changeChar;
        private System.Windows.Forms.ComboBox myCombo;
        private System.Windows.Forms.Button populateCombo;
        private System.Windows.Forms.Button comboShow;
    }
}

