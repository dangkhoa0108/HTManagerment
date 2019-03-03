namespace HTManagement.UI
{
    partial class UnitManagerControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.Sparkline.LineSparklineView lineSparklineView1 = new DevExpress.Sparkline.LineSparklineView();
            this.sparklineEdit1 = new DevExpress.XtraEditors.SparklineEdit();
            ((System.ComponentModel.ISupportInitialize)(this.sparklineEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // sparklineEdit1
            // 
            this.sparklineEdit1.Location = new System.Drawing.Point(421, 123);
            this.sparklineEdit1.Name = "sparklineEdit1";
            lineSparklineView1.ScaleFactor = 1F;
            this.sparklineEdit1.Properties.View = lineSparklineView1;
            this.sparklineEdit1.Size = new System.Drawing.Size(75, 14);
            this.sparklineEdit1.TabIndex = 0;
            // 
            // UnitManagerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sparklineEdit1);
            this.Name = "UnitManagerControl";
            this.Size = new System.Drawing.Size(1252, 687);
            ((System.ComponentModel.ISupportInitialize)(this.sparklineEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SparklineEdit sparklineEdit1;
    }
}
