namespace _HW3_2014707040_유진혁
{
    partial class frmChild
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
            this.pnlBoard = new DoubleBufferPanel();
            this.SuspendLayout();
            // 
            // pnlBoard
            // 
            this.pnlBoard.BackColor = System.Drawing.Color.Transparent;
            this.pnlBoard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlBoard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBoard.Location = new System.Drawing.Point(0, 0);
            this.pnlBoard.Name = "pnlBoard";
            this.pnlBoard.Size = new System.Drawing.Size(821, 573);
            this.pnlBoard.TabIndex = 0;
            this.pnlBoard.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlBoard_Paint);
            this.pnlBoard.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlBoard_MouseDown);
            this.pnlBoard.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlBoard_MouseMove);
            this.pnlBoard.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlBoard_MouseUp);
            // 
            // frmChild
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(821, 573);
            this.Controls.Add(this.pnlBoard);
            this.Name = "frmChild";
            this.Text = "제목 없음";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmChild_FormClosing);
            this.Load += new System.EventHandler(this.frmChild_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DoubleBufferPanel pnlBoard;
    }

    // 더블 버퍼링 패널
    public class DoubleBufferPanel : System.Windows.Forms.Panel
    {
        public DoubleBufferPanel()
        {
            this.SetStyle(System.Windows.Forms.ControlStyles.DoubleBuffer |
                          System.Windows.Forms.ControlStyles.UserPaint |
                          System.Windows.Forms.ControlStyles.AllPaintingInWmPaint, true);
            this.UpdateStyles();
        }
    }
}