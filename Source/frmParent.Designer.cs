namespace _HW3_2014707040_유진혁
{
    partial class frmParent
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.mnsMenu = new System.Windows.Forms.MenuStrip();
            this.tsmiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNew = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiImage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiClear = new System.Windows.Forms.ToolStripMenuItem();
            this.tsTool = new System.Windows.Forms.ToolStrip();
            this.tsbtnColor = new System.Windows.Forms.ToolStripButton();
            this.tsbtnPencil = new System.Windows.Forms.ToolStripButton();
            this.tsbtnBrush = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnLine = new System.Windows.Forms.ToolStripButton();
            this.tsbtnRectangle = new System.Windows.Forms.ToolStripButton();
            this.tsbtnOval = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsddbLineWidth = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmi1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi3 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi4 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi5 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsddbFill = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmiNotFill = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFill = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsMenu.SuspendLayout();
            this.tsTool.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnsMenu
            // 
            this.mnsMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFile,
            this.tsmiImage});
            this.mnsMenu.Location = new System.Drawing.Point(0, 0);
            this.mnsMenu.Name = "mnsMenu";
            this.mnsMenu.Size = new System.Drawing.Size(1217, 28);
            this.mnsMenu.TabIndex = 1;
            this.mnsMenu.Text = "menuStrip1";
            // 
            // tsmiFile
            // 
            this.tsmiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNew,
            this.tsmiOpen,
            this.tsmiSave,
            this.toolStripSeparator1,
            this.tsmiExit});
            this.tsmiFile.Name = "tsmiFile";
            this.tsmiFile.Size = new System.Drawing.Size(68, 24);
            this.tsmiFile.Text = "파일(&F)";
            // 
            // tsmiNew
            // 
            this.tsmiNew.Name = "tsmiNew";
            this.tsmiNew.Size = new System.Drawing.Size(185, 26);
            this.tsmiNew.Text = "새로 만들기(&N)";
            this.tsmiNew.Click += new System.EventHandler(this.tsmiNew_Click);
            // 
            // tsmiOpen
            // 
            this.tsmiOpen.Name = "tsmiOpen";
            this.tsmiOpen.Size = new System.Drawing.Size(185, 26);
            this.tsmiOpen.Text = "열기(&O)";
            this.tsmiOpen.Click += new System.EventHandler(this.tsmiOpen_Click);
            // 
            // tsmiSave
            // 
            this.tsmiSave.Enabled = false;
            this.tsmiSave.Name = "tsmiSave";
            this.tsmiSave.Size = new System.Drawing.Size(185, 26);
            this.tsmiSave.Text = "저장(&S)";
            this.tsmiSave.Click += new System.EventHandler(this.tsmiSave_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(182, 6);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(185, 26);
            this.tsmiExit.Text = "끝내기(&X)";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // tsmiImage
            // 
            this.tsmiImage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiClear});
            this.tsmiImage.Name = "tsmiImage";
            this.tsmiImage.Size = new System.Drawing.Size(80, 24);
            this.tsmiImage.Text = "이미지(&I)";
            // 
            // tsmiClear
            // 
            this.tsmiClear.Enabled = false;
            this.tsmiClear.Name = "tsmiClear";
            this.tsmiClear.Size = new System.Drawing.Size(200, 26);
            this.tsmiClear.Text = "이미지 지우기(&N)";
            this.tsmiClear.Click += new System.EventHandler(this.tsmiClear_Click);
            // 
            // tsTool
            // 
            this.tsTool.Dock = System.Windows.Forms.DockStyle.Left;
            this.tsTool.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsTool.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnColor,
            this.tsbtnPencil,
            this.tsbtnBrush,
            this.toolStripSeparator2,
            this.tsbtnLine,
            this.tsbtnRectangle,
            this.tsbtnOval,
            this.toolStripSeparator3,
            this.tsddbLineWidth,
            this.tsddbFill});
            this.tsTool.Location = new System.Drawing.Point(0, 28);
            this.tsTool.Name = "tsTool";
            this.tsTool.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tsTool.Size = new System.Drawing.Size(38, 789);
            this.tsTool.TabIndex = 2;
            this.tsTool.Text = "toolStrip1";
            // 
            // tsbtnColor
            // 
            this.tsbtnColor.AutoSize = false;
            this.tsbtnColor.BackColor = System.Drawing.Color.Black;
            this.tsbtnColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnColor.Name = "tsbtnColor";
            this.tsbtnColor.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.tsbtnColor.Size = new System.Drawing.Size(37, 37);
            this.tsbtnColor.Click += new System.EventHandler(this.tsbtnColor_Click);
            // 
            // tsbtnPencil
            // 
            this.tsbtnPencil.AutoSize = false;
            this.tsbtnPencil.Checked = true;
            this.tsbtnPencil.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsbtnPencil.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnPencil.Image = global::_HW3_2014707040_유진혁.Properties.Resources.pencil_48;
            this.tsbtnPencil.Name = "tsbtnPencil";
            this.tsbtnPencil.Size = new System.Drawing.Size(37, 37);
            this.tsbtnPencil.Click += new System.EventHandler(this.tsbtnPencil_Click);
            // 
            // tsbtnBrush
            // 
            this.tsbtnBrush.AutoSize = false;
            this.tsbtnBrush.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnBrush.Image = global::_HW3_2014707040_유진혁.Properties.Resources.brush_48;
            this.tsbtnBrush.Name = "tsbtnBrush";
            this.tsbtnBrush.Size = new System.Drawing.Size(37, 37);
            this.tsbtnBrush.Click += new System.EventHandler(this.tsbtnBrush_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(35, 6);
            // 
            // tsbtnLine
            // 
            this.tsbtnLine.AutoSize = false;
            this.tsbtnLine.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnLine.Image = global::_HW3_2014707040_유진혁.Properties.Resources.line_48;
            this.tsbtnLine.Name = "tsbtnLine";
            this.tsbtnLine.Size = new System.Drawing.Size(37, 37);
            this.tsbtnLine.Click += new System.EventHandler(this.tsbtnLine_Click);
            // 
            // tsbtnRectangle
            // 
            this.tsbtnRectangle.AutoSize = false;
            this.tsbtnRectangle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnRectangle.Image = global::_HW3_2014707040_유진혁.Properties.Resources.rectangular_48;
            this.tsbtnRectangle.Name = "tsbtnRectangle";
            this.tsbtnRectangle.Size = new System.Drawing.Size(37, 37);
            this.tsbtnRectangle.Click += new System.EventHandler(this.tsbtnRectangular_Click);
            // 
            // tsbtnOval
            // 
            this.tsbtnOval.AutoSize = false;
            this.tsbtnOval.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnOval.Image = global::_HW3_2014707040_유진혁.Properties.Resources.oval_48;
            this.tsbtnOval.Name = "tsbtnOval";
            this.tsbtnOval.Size = new System.Drawing.Size(37, 37);
            this.tsbtnOval.Click += new System.EventHandler(this.tsbtnOval_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(35, 6);
            // 
            // tsddbLineWidth
            // 
            this.tsddbLineWidth.AutoSize = false;
            this.tsddbLineWidth.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsddbLineWidth.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi1,
            this.tsmi2,
            this.tsmi3,
            this.tsmi4,
            this.tsmi5});
            this.tsddbLineWidth.Image = global::_HW3_2014707040_유진혁.Properties.Resources.line_width_48;
            this.tsddbLineWidth.Name = "tsddbLineWidth";
            this.tsddbLineWidth.ShowDropDownArrow = false;
            this.tsddbLineWidth.Size = new System.Drawing.Size(37, 37);
            // 
            // tsmi1
            // 
            this.tsmi1.Checked = true;
            this.tsmi1.CheckOnClick = true;
            this.tsmi1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmi1.Name = "tsmi1";
            this.tsmi1.Size = new System.Drawing.Size(92, 26);
            this.tsmi1.Text = "1";
            this.tsmi1.Click += new System.EventHandler(this.tsmi1_Click);
            // 
            // tsmi2
            // 
            this.tsmi2.CheckOnClick = true;
            this.tsmi2.Name = "tsmi2";
            this.tsmi2.Size = new System.Drawing.Size(92, 26);
            this.tsmi2.Text = "2";
            this.tsmi2.Click += new System.EventHandler(this.tsmi2_Click);
            // 
            // tsmi3
            // 
            this.tsmi3.CheckOnClick = true;
            this.tsmi3.Name = "tsmi3";
            this.tsmi3.Size = new System.Drawing.Size(92, 26);
            this.tsmi3.Text = "3";
            this.tsmi3.Click += new System.EventHandler(this.tsmi3_Click);
            // 
            // tsmi4
            // 
            this.tsmi4.CheckOnClick = true;
            this.tsmi4.Name = "tsmi4";
            this.tsmi4.Size = new System.Drawing.Size(92, 26);
            this.tsmi4.Text = "4";
            this.tsmi4.Click += new System.EventHandler(this.tsmi4_Click);
            // 
            // tsmi5
            // 
            this.tsmi5.CheckOnClick = true;
            this.tsmi5.Name = "tsmi5";
            this.tsmi5.Size = new System.Drawing.Size(92, 26);
            this.tsmi5.Text = "5";
            this.tsmi5.Click += new System.EventHandler(this.tsmi5_Click);
            // 
            // tsddbFill
            // 
            this.tsddbFill.AutoSize = false;
            this.tsddbFill.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsddbFill.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNotFill,
            this.tsmiFill});
            this.tsddbFill.Image = global::_HW3_2014707040_유진혁.Properties.Resources.rectangle_48;
            this.tsddbFill.Name = "tsddbFill";
            this.tsddbFill.ShowDropDownArrow = false;
            this.tsddbFill.Size = new System.Drawing.Size(37, 37);
            // 
            // tsmiNotFill
            // 
            this.tsmiNotFill.Checked = true;
            this.tsmiNotFill.CheckOnClick = true;
            this.tsmiNotFill.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiNotFill.Name = "tsmiNotFill";
            this.tsmiNotFill.Size = new System.Drawing.Size(164, 26);
            this.tsmiNotFill.Text = "채우기 없음";
            this.tsmiNotFill.Click += new System.EventHandler(this.tsmiNotFill_Click);
            // 
            // tsmiFill
            // 
            this.tsmiFill.CheckOnClick = true;
            this.tsmiFill.Name = "tsmiFill";
            this.tsmiFill.Size = new System.Drawing.Size(164, 26);
            this.tsmiFill.Text = "단색";
            this.tsmiFill.Click += new System.EventHandler(this.tsmiFill_Click);
            // 
            // frmParent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 817);
            this.Controls.Add(this.tsTool);
            this.Controls.Add(this.mnsMenu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnsMenu;
            this.Name = "frmParent";
            this.Text = "그림판";
            this.mnsMenu.ResumeLayout(false);
            this.mnsMenu.PerformLayout();
            this.tsTool.ResumeLayout(false);
            this.tsTool.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmiFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiNew;
        private System.Windows.Forms.ToolStripMenuItem tsmiOpen;
        private System.Windows.Forms.ToolStripMenuItem tsmiSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ToolStripMenuItem tsmiImage;
        private System.Windows.Forms.ToolStripMenuItem tsmiClear;
        private System.Windows.Forms.ToolStrip tsTool;
        private System.Windows.Forms.ToolStripButton tsbtnColor;
        private System.Windows.Forms.ToolStripButton tsbtnPencil;
        private System.Windows.Forms.ToolStripButton tsbtnBrush;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbtnLine;
        private System.Windows.Forms.ToolStripButton tsbtnRectangle;
        private System.Windows.Forms.ToolStripButton tsbtnOval;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripDropDownButton tsddbLineWidth;
        private System.Windows.Forms.ToolStripDropDownButton tsddbFill;
        private System.Windows.Forms.ToolStripMenuItem tsmi1;
        private System.Windows.Forms.ToolStripMenuItem tsmi2;
        private System.Windows.Forms.ToolStripMenuItem tsmi3;
        private System.Windows.Forms.ToolStripMenuItem tsmi4;
        private System.Windows.Forms.ToolStripMenuItem tsmi5;
        private System.Windows.Forms.ToolStripMenuItem tsmiNotFill;
        private System.Windows.Forms.ToolStripMenuItem tsmiFill;
    }
}

