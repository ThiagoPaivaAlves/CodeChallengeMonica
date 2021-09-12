
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.idInput = new System.Windows.Forms.TextBox();
            this.depthInput = new System.Windows.Forms.TextBox();
            this.commentsInput = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.dateInput = new System.Windows.Forms.DateTimePicker();
            this.deleteButton = new System.Windows.Forms.Button();
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
            resources.ApplyResources(this.myGridView, "myGridView");
            this.myGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
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
            resources.ApplyResources(this.myCombo, "myCombo");
            this.myCombo.FormattingEnabled = true;
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
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // nameInput
            // 
            resources.ApplyResources(this.nameInput, "nameInput");
            this.nameInput.Name = "nameInput";
            // 
            // idInput
            // 
            resources.ApplyResources(this.idInput, "idInput");
            this.idInput.Name = "idInput";
            // 
            // depthInput
            // 
            resources.ApplyResources(this.depthInput, "depthInput");
            this.depthInput.Name = "depthInput";
            // 
            // commentsInput
            // 
            resources.ApplyResources(this.commentsInput, "commentsInput");
            this.commentsInput.Name = "commentsInput";
            // 
            // addButton
            // 
            resources.ApplyResources(this.addButton, "addButton");
            this.addButton.Name = "addButton";
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // dateInput
            // 
            resources.ApplyResources(this.dateInput, "dateInput");
            this.dateInput.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateInput.Name = "dateInput";
            // 
            // deleteButton
            // 
            resources.ApplyResources(this.deleteButton, "deleteButton");
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.dateInput);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.commentsInput);
            this.Controls.Add(this.depthInput);
            this.Controls.Add(this.idInput);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboShow);
            this.Controls.Add(this.populateCombo);
            this.Controls.Add(this.myCombo);
            this.Controls.Add(this.changeChar);
            this.Controls.Add(this.myGridView);
            this.Controls.Add(this.loadButton);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.myGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.DataGridView myGridView;
        private System.Windows.Forms.Button changeChar;
        private System.Windows.Forms.ComboBox myCombo;
        private System.Windows.Forms.Button populateCombo;
        private System.Windows.Forms.Button comboShow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.TextBox idInput;
        private System.Windows.Forms.TextBox depthInput;
        private System.Windows.Forms.TextBox commentsInput;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.DateTimePicker dateInput;
        private System.Windows.Forms.Button deleteButton;
    }
}

