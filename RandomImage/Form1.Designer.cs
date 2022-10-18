namespace RandomImage {
    partial class Form1 {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent() {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbxRandomAlgorithm = new System.Windows.Forms.ListBox();
            this.numHeight = new System.Windows.Forms.NumericUpDown();
            this.numWidth = new System.Windows.Forms.NumericUpDown();
            this.btnAlloc = new System.Windows.Forms.Button();
            this.btnRandom = new System.Windows.Forms.Button();
            this.ibxDraw = new ShimLib.ImageBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbxRandomAlgorithm);
            this.panel1.Controls.Add(this.numHeight);
            this.panel1.Controls.Add(this.numWidth);
            this.panel1.Controls.Add(this.btnAlloc);
            this.panel1.Controls.Add(this.btnRandom);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1298, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(233, 879);
            this.panel1.TabIndex = 0;
            // 
            // lbxRandomAlgorithm
            // 
            this.lbxRandomAlgorithm.FormattingEnabled = true;
            this.lbxRandomAlgorithm.ItemHeight = 12;
            this.lbxRandomAlgorithm.Items.AddRange(new object[] {
            "System.Random",
            "CRT rnad()",
            "MyRand()"});
            this.lbxRandomAlgorithm.Location = new System.Drawing.Point(6, 95);
            this.lbxRandomAlgorithm.Name = "lbxRandomAlgorithm";
            this.lbxRandomAlgorithm.Size = new System.Drawing.Size(120, 76);
            this.lbxRandomAlgorithm.TabIndex = 4;
            // 
            // numHeight
            // 
            this.numHeight.Location = new System.Drawing.Point(6, 39);
            this.numHeight.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numHeight.Name = "numHeight";
            this.numHeight.Size = new System.Drawing.Size(120, 21);
            this.numHeight.TabIndex = 3;
            this.numHeight.Value = new decimal(new int[] {
            8192,
            0,
            0,
            0});
            // 
            // numWidth
            // 
            this.numWidth.Location = new System.Drawing.Point(6, 12);
            this.numWidth.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numWidth.Name = "numWidth";
            this.numWidth.Size = new System.Drawing.Size(120, 21);
            this.numWidth.TabIndex = 2;
            this.numWidth.Value = new decimal(new int[] {
            8192,
            0,
            0,
            0});
            // 
            // btnAlloc
            // 
            this.btnAlloc.Location = new System.Drawing.Point(6, 66);
            this.btnAlloc.Name = "btnAlloc";
            this.btnAlloc.Size = new System.Drawing.Size(75, 23);
            this.btnAlloc.TabIndex = 1;
            this.btnAlloc.Text = "Alloc";
            this.btnAlloc.UseVisualStyleBackColor = true;
            this.btnAlloc.Click += new System.EventHandler(this.btnAlloc_Click);
            // 
            // btnRandom
            // 
            this.btnRandom.Location = new System.Drawing.Point(6, 177);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(75, 23);
            this.btnRandom.TabIndex = 0;
            this.btnRandom.Text = "Random";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // ibxDraw
            // 
            this.ibxDraw.BackColor = System.Drawing.Color.Gray;
            this.ibxDraw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ibxDraw.Location = new System.Drawing.Point(0, 0);
            this.ibxDraw.Name = "ibxDraw";
            this.ibxDraw.Option.CenterLineColor = System.Drawing.Color.Yellow;
            this.ibxDraw.Option.ColorMap = ShimLib.EColorMap.Turbo;
            this.ibxDraw.Option.CustomValueMax = 255D;
            this.ibxDraw.Option.CustomValueMin = 0D;
            this.ibxDraw.Option.FloatDigit = 3;
            this.ibxDraw.Option.InfoEFont = ShimLib.EFont.unifont_13_0_06_bdf;
            this.ibxDraw.Option.MaxZoomLevel = 16;
            this.ibxDraw.Option.MinZoomLevel = -16;
            this.ibxDraw.Option.PanClampMargin = 20;
            this.ibxDraw.Option.RoiRectangleColor = System.Drawing.Color.Blue;
            this.ibxDraw.Option.TimeCheckCount = 100;
            this.ibxDraw.Option.UseColorMap = false;
            this.ibxDraw.Option.UseCustomValueRange = false;
            this.ibxDraw.Option.UseDrawCenterLine = true;
            this.ibxDraw.Option.UseDrawCursorInfo = true;
            this.ibxDraw.Option.UseDrawDebugInfo = true;
            this.ibxDraw.Option.UseDrawPixelValue = true;
            this.ibxDraw.Option.UseDrawRoiRectangles = true;
            this.ibxDraw.Option.UsePalette = false;
            this.ibxDraw.Option.UsePanClamp = true;
            this.ibxDraw.Option.UseParallelToDraw = false;
            this.ibxDraw.Option.UseShowText = false;
            this.ibxDraw.Size = new System.Drawing.Size(1298, 879);
            this.ibxDraw.SzPan = new System.Drawing.Size(0, 0);
            this.ibxDraw.TabIndex = 1;
            this.ibxDraw.Text = "imageBox1";
            this.ibxDraw.ZoomLevel = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1531, 879);
            this.Controls.Add(this.ibxDraw);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWidth)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private ShimLib.ImageBox ibxDraw;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.NumericUpDown numHeight;
        private System.Windows.Forms.NumericUpDown numWidth;
        private System.Windows.Forms.Button btnAlloc;
        private System.Windows.Forms.ListBox lbxRandomAlgorithm;
    }
}

