namespace TEOBStarfieldTextureReplacer
{
    partial class TextureSelection
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
            flowLayoutPanelTexture = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // flowLayoutPanelTexture
            // 
            flowLayoutPanelTexture.AutoScroll = true;
            flowLayoutPanelTexture.AutoSize = true;
            flowLayoutPanelTexture.BackColor = Color.FromArgb(64, 64, 64);
            flowLayoutPanelTexture.Dock = DockStyle.Fill;
            flowLayoutPanelTexture.Location = new Point(0, 0);
            flowLayoutPanelTexture.Name = "flowLayoutPanelTexture";
            flowLayoutPanelTexture.Size = new Size(1902, 1153);
            flowLayoutPanelTexture.TabIndex = 0;
            // 
            // TextureSelection
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1902, 1153);
            Controls.Add(flowLayoutPanelTexture);
            DoubleBuffered = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TextureSelection";
            ShowIcon = false;
            SizeGripStyle = SizeGripStyle.Show;
            Text = "TextureSelection";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanelTexture;
    }
}