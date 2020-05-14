using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

namespace _HW3_2014707040_유진혁
{
    /// <summary>
    /// 그리기 모드 열거형
    /// </summary>
    public enum DrawMode
    {
        Pencil,
        Brush,
        Line,
        Rectangle,
        Oval
    }

    /// <summary>
    ///  부모 Form
    /// </summary>
    public partial class frmParent : Form
    {
        // 저장 버튼 참조 프로퍼티
        public ToolStripMenuItem saveButton
        {
            get { return tsmiSave; }
            set { tsmiSave = value; }
        }

        // 이미지 지우기 버튼 참조 프로퍼티
        public ToolStripMenuItem clearButton
        {
            get { return tsmiClear; }
            set { tsmiClear = value; }
        }

        // 선택한 색 반환 프로퍼티
        public Color color => tsbtnColor.BackColor;

        // 그리기 모드 프로퍼티
        public DrawMode mode
        {
            get
            {
                if (tsbtnPencil.Checked)
                    return DrawMode.Pencil;
                else if (tsbtnBrush.Checked)
                    return DrawMode.Brush;
                else if (tsbtnLine.Checked)
                    return DrawMode.Line;
                else if (tsbtnRectangle.Checked)
                    return DrawMode.Rectangle;
                else if (tsbtnOval.Checked)
                    return DrawMode.Oval;
                else
                    return 0;
            }
        }

        // 선 두께 지정 프로퍼티
        public int thick
        {
            get
            {
                if (tsmi1.Checked)
                    return 1;
                else if (tsmi2.Checked)
                    return 2;
                else if (tsmi3.Checked)
                    return 3;
                else if (tsmi4.Checked)
                    return 4;
                else if (tsmi5.Checked)
                    return 5;
                else
                    return 0;
            }
        }

        // 채우기 모드 반환 프로퍼티
        public bool fillMode => tsmiFill.Checked;

        // 기본 생성자
        public frmParent()
        {
            InitializeComponent();
        }

        // 새로 만들기
        private void tsmiNew_Click(object sender, EventArgs e)
        {
            frmChild child = new frmChild();    // 자식 Form 생성
            if (MdiChildren.Length == 0)    // 자식 Form 처음 생성될 때
            {
                child.WindowState = FormWindowState.Maximized;  // 창 최대화
                tsmiSave.Enabled = true;    // 저장 버튼 활성화
                tsmiClear.Enabled = true;   // 이미지 지우기 버튼 활성화
            }
            else
            {
                // 열려 있는 자식 Form들 창 크기 기본으로
                foreach (Form form in MdiChildren)
                    form.WindowState = FormWindowState.Normal;
            }
            child.MdiParent = this; // 부모 지정
            child.Show();
        }

        // 열기
        private void tsmiOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdOpen = new OpenFileDialog(); // Dialog 생성
            // 확장자 필터 설정
            ofdOpen.Filter = "JPEG (*.jpg; *.jpeg)|*.jpg; *jpeg|"
                + "비트맵 파일 (*.bmp)|*.bmp |"
                + "GIF (*.gif)|*.gif|"
                + "PNG (*.PNG)|*.png|"
                + "모든 그림 파일 (*.jpg; *.jpeg; *.bmp; *.gif; *.png)|*.jpg; *.jpeg; *.bmp; *.gif; *.png";

            if (ofdOpen.ShowDialog() == DialogResult.OK)
            {
                frmChild child = new frmChild();    // 자식 Form 생성
                child.img = Image.FromFile(ofdOpen.FileName);   // 이미지 열기
                if (MdiChildren.Length == 0)    // 자식 Form 처음 생성될 때
                {
                    tsmiSave.Enabled = true;    // 저장 버튼 활성화
                    tsmiClear.Enabled = true;   // 이미지 지우기 버튼 활성화
                }
                else
                {
                    // 열려 있는 자식 Form 창 크기 기본으로
                    foreach (Form form in MdiChildren)
                        form.WindowState = FormWindowState.Normal;
                }
                child.MdiParent = this; // 부모 지정
                child.Size = new Size(child.img.Width + 16, child.img.Height + 39); // Form 크기 설정
                child.Text = Path.GetFileName(ofdOpen.FileName);    // Form Text 설정
                child.Show();
            }
        }

        // 저장
        private void tsmiSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfdSave = new SaveFileDialog();  // Dialog 생성
            // 확장자 필터 설정
            sfdSave.Filter = "JPEG (*.jpg; *.jpeg)|*.jpg; *jpeg|"
                + "비트맵 파일 (*.bmp)|*.bmp |"
                + "GIF (*.gif)|*.gif|"
                + "PNG (*.PNG)|*.png";

            if(sfdSave.ShowDialog() == DialogResult.OK)
            {
                Panel panel = (ActiveMdiChild as frmChild).board;   // 활성화된 자식 Form의 패널
                Image img = (ActiveMdiChild as frmChild).img;   // 활성화된 자식 Form의 img 변수
                Bitmap bmp = new Bitmap(panel.Width, panel.Height); // 이미지 담을 bitmap 생성
                panel.DrawToBitmap(bmp, new Rectangle(0, 0, panel.Width, panel.Height));    // 패널 이미지 bitmap에 저장

                if (img != null) img.Dispose(); // 이미지 리소스 해제

                try
                {
                    // 이미 있는 파일 덮어쓰기
                    if (File.Exists(sfdSave.FileName))
                        File.Delete(sfdSave.FileName);

                    switch (sfdSave.FilterIndex)
                    {
                        case 1:
                            bmp.Save(sfdSave.FileName, ImageFormat.Jpeg);   // JPG로 저장
                            break;

                        case 2:
                            bmp.Save(sfdSave.FileName, ImageFormat.Bmp);    // BMP로 저장 
                            break;

                        case 3:
                            bmp.Save(sfdSave.FileName, ImageFormat.Gif);    // GIF로 저장
                            break;
                        case 4:
                            bmp.Save(sfdSave.FileName, ImageFormat.Png);    // PNG로 저장
                            break;
                        default:
                            break;
                    }
                }
                finally { bmp.Dispose(); } // bitmap 리소스 해제
                ActiveMdiChild.Text = Path.GetFileName(sfdSave.FileName);   // 자식 Form Text 변경
                img = Image.FromFile(sfdSave.FileName); // 저장한 이미지로 다시 열기
            }
        }

        // 색 변경
        private void tsbtnColor_Click(object sender, EventArgs e)
        {
            ColorDialog cldColor = new ColorDialog();   // Dialog 생성
            if (cldColor.ShowDialog() == DialogResult.OK)
                tsbtnColor.BackColor = cldColor.Color;  // 선택한 색으로 배경 변경
        }

        // 그리기 모드 전환
        private void tsbtnPencil_Click(object sender, EventArgs e)
        {
            tsbtnPencil.Checked = true;
            tsbtnBrush.Checked = false;
            tsbtnLine.Checked = false;
            tsbtnRectangle.Checked = false;
            tsbtnOval.Checked = false;
        }
        private void tsbtnBrush_Click(object sender, EventArgs e)
        {
            tsbtnPencil.Checked = false;
            tsbtnBrush.Checked = true;
            tsbtnLine.Checked = false;
            tsbtnRectangle.Checked = false;
            tsbtnOval.Checked = false;
        }
        private void tsbtnLine_Click(object sender, EventArgs e)
        {
            tsbtnPencil.Checked = false;
            tsbtnBrush.Checked = false;
            tsbtnLine.Checked = true;
            tsbtnRectangle.Checked = false;
            tsbtnOval.Checked = false;
        }
        private void tsbtnRectangular_Click(object sender, EventArgs e)
        {
            tsbtnPencil.Checked = false;
            tsbtnBrush.Checked = false;
            tsbtnLine.Checked = false;
            tsbtnRectangle.Checked = true;
            tsbtnOval.Checked = false;
        }
        private void tsbtnOval_Click(object sender, EventArgs e)
        {
            tsbtnPencil.Checked = false;
            tsbtnBrush.Checked = false;
            tsbtnLine.Checked = false;
            tsbtnRectangle.Checked = false;
            tsbtnOval.Checked = true;
        }

        // 선 두께 전환
        private void tsmi1_Click(object sender, EventArgs e)
        {
            tsmi1.Checked = true;
            tsmi2.Checked = false;
            tsmi3.Checked = false;
            tsmi4.Checked = false;
            tsmi5.Checked = false;
        }
        private void tsmi2_Click(object sender, EventArgs e)
        {
            tsmi1.Checked = false;
            tsmi2.Checked = true;
            tsmi3.Checked = false;
            tsmi4.Checked = false;
            tsmi5.Checked = false;
        }
        private void tsmi3_Click(object sender, EventArgs e)
        {
            tsmi1.Checked = false;
            tsmi2.Checked = false;
            tsmi3.Checked = true;
            tsmi4.Checked = false;
            tsmi5.Checked = false;
        }
        private void tsmi4_Click(object sender, EventArgs e)
        {
            tsmi1.Checked = false;
            tsmi2.Checked = false;
            tsmi3.Checked = false;
            tsmi4.Checked = true;
            tsmi5.Checked = false;
        }
        private void tsmi5_Click(object sender, EventArgs e)
        {
            tsmi1.Checked = false;
            tsmi2.Checked = false;
            tsmi3.Checked = false;
            tsmi4.Checked = false;
            tsmi5.Checked = true;
        }

        // 채우기 모드 전환
        private void tsmiNotFill_Click(object sender, EventArgs e)
        {
            tsmiNotFill.Checked = true;
            tsmiFill.Checked = false;
        }
        private void tsmiFill_Click(object sender, EventArgs e)
        {
            tsmiNotFill.Checked = false;
            tsmiFill.Checked = true;
        }

        // 이미지 지우기
        private void tsmiClear_Click(object sender, EventArgs e)
        {
            frmChild child = ActiveMdiChild as frmChild;    // 활성화된 자식 Form
            child.Clear();
        }

        // 끝내기
        private void tsmiExit_Click(object sender, EventArgs e) => Close();
    }
} 
