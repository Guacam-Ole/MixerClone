
namespace McUI
{
    partial class SoundSelector
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
            this.Source = new System.Windows.Forms.Label();
            this.SourceDeviceSelector = new System.Windows.Forms.ComboBox();
            this.TargetDeviceSelector = new System.Windows.Forms.ComboBox();
            this.Target = new System.Windows.Forms.Label();
            this.Ok = new System.Windows.Forms.Button();
            this.CallGitHub = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // Source
            // 
            this.Source.AutoSize = true;
            this.Source.Location = new System.Drawing.Point(13, 13);
            this.Source.Name = "Source";
            this.Source.Size = new System.Drawing.Size(108, 20);
            this.Source.TabIndex = 0;
            this.Source.Text = "Source-Device:";
            // 
            // SourceDeviceSelector
            // 
            this.SourceDeviceSelector.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SourceDeviceSelector.DisplayMember = "Value";
            this.SourceDeviceSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SourceDeviceSelector.FormattingEnabled = true;
            this.SourceDeviceSelector.Location = new System.Drawing.Point(127, 13);
            this.SourceDeviceSelector.Name = "SourceDeviceSelector";
            this.SourceDeviceSelector.Size = new System.Drawing.Size(482, 28);
            this.SourceDeviceSelector.TabIndex = 1;
            this.SourceDeviceSelector.ValueMember = "Key";
            this.SourceDeviceSelector.SelectedValueChanged += new System.EventHandler(this.ComboChanged);
            // 
            // TargetDeviceSelector
            // 
            this.TargetDeviceSelector.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TargetDeviceSelector.DisplayMember = "Value";
            this.TargetDeviceSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TargetDeviceSelector.FormattingEnabled = true;
            this.TargetDeviceSelector.Location = new System.Drawing.Point(127, 71);
            this.TargetDeviceSelector.Name = "TargetDeviceSelector";
            this.TargetDeviceSelector.Size = new System.Drawing.Size(482, 28);
            this.TargetDeviceSelector.TabIndex = 3;
            this.TargetDeviceSelector.ValueMember = "Key";
            this.TargetDeviceSelector.SelectedValueChanged += new System.EventHandler(this.ComboChanged);
            // 
            // Target
            // 
            this.Target.AutoSize = true;
            this.Target.Location = new System.Drawing.Point(13, 71);
            this.Target.Name = "Target";
            this.Target.Size = new System.Drawing.Size(104, 20);
            this.Target.TabIndex = 2;
            this.Target.Text = "Target-Device:";
            // 
            // Ok
            // 
            this.Ok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Ok.Location = new System.Drawing.Point(516, 178);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(94, 29);
            this.Ok.TabIndex = 4;
            this.Ok.Text = "Ok";
            this.Ok.UseVisualStyleBackColor = true;
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // CallGitHub
            // 
            this.CallGitHub.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CallGitHub.AutoSize = true;
            this.CallGitHub.Location = new System.Drawing.Point(13, 182);
            this.CallGitHub.Name = "CallGitHub";
            this.CallGitHub.Size = new System.Drawing.Size(68, 20);
            this.CallGitHub.TabIndex = 5;
            this.CallGitHub.TabStop = true;
            this.CallGitHub.Text = "Get Help";
            this.CallGitHub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CallGitHub_LinkClicked);
            // 
            // SoundSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 219);
            this.Controls.Add(this.CallGitHub);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.TargetDeviceSelector);
            this.Controls.Add(this.Target);
            this.Controls.Add(this.SourceDeviceSelector);
            this.Controls.Add(this.Source);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SoundSelector";
            this.Text = "MixerClone";
            this.Load += new System.EventHandler(this.SoundSelector_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Source;
        private System.Windows.Forms.ComboBox SourceDeviceSelector;
        private System.Windows.Forms.ComboBox TargetDeviceSelector;
        private System.Windows.Forms.Label Target;
        private System.Windows.Forms.Button Ok;
        private System.Windows.Forms.LinkLabel CallGitHub;
    }
}