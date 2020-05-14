using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace _HW3_2014707040_유진혁
{
    /// <summary>
    /// 자식 Form
    /// </summary>
    public partial class frmChild : Form
    {
        private frmParent parent;   // 부모 Form
        public Image img;   // 이미지
        private Point p;    // 마우스 좌표 저장
        private Pen pen;    // 선 그리기 객체
        private Brush brush;   // 채우기 객체
        private List<MyPen> myPen;  // 그려진 곡선(연필) 저장 컬렉션
        private List<MyLines> myLines;  // 그려진 직선 저장 컬렉션
        private List<MyRect> myRect;    // 그려진 사각형 저장 컬렉션
        private List<MyOval> myOval;    // 그려진 타원 저장 컬렉션
        private bool isClicked; // 마우스 클릭 여부

        // 패널 반환 프로퍼티
        public DoubleBufferPanel board
        {
            get { return pnlBoard; }
        }

        // 기본 생성자
        public frmChild()
        {
            InitializeComponent();
            img = new Bitmap(pnlBoard.Width, pnlBoard.Height);
            p = new Point();
            myPen = new List<MyPen>();
            myLines = new List<MyLines>();
            myRect = new List<MyRect>();
            myOval = new List<MyOval>();
            myPen.Add(new MyPen());
            myLines.Add(new MyLines());
            myRect.Add(new MyRect());
            myOval.Add(new MyOval());
            isClicked = false;
        }

        // Form 로드 시 부모 Form 객체 및 Pen 객체 설정
        private void frmChild_Load(object sender, EventArgs e)
        {
            parent = ParentForm as frmParent;
            pen = new Pen(parent.color);
        }

        // 그리기 함수
        private void pnlBoard_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias; // 앤티 앨리어싱 적용

            img = new Bitmap(img);  // 이미지 새로고침
            g.DrawImage(img, new Point(0, 0));  // 이미지 그리기

            // 저장된 곡선 그리기
            foreach(MyPen pencil in myPen)
            {
                foreach (MyLines line in pencil.getLine())
                {
                    pen = new Pen(line.getColor(), line.getThick());
                    g.DrawLine(pen, line.getPoint1(), line.getPoint2());
                }
            }
            // 저장된 직선 그리기
            foreach(MyLines line in myLines)
            {
                pen = new Pen(line.getColor(), line.getThick());
                g.DrawLine(pen, line.getPoint1(), line.getPoint2());
            }
            // 저장된 사각형 그리기
            foreach(MyRect rect in myRect)
            {
                if (rect.getFill())
                {
                    brush = new SolidBrush(rect.getColor());
                    g.FillRectangle(brush, rect.getRect());
                }
                else
                {
                    pen = new Pen(rect.getColor(), rect.getThick());
                    g.DrawRectangle(pen, rect.getRect());
                }
            }
            // 저장된 타원 그리기
            foreach(MyOval oval in myOval)
            {
                if (oval.getFill())
                {
                    brush = new SolidBrush(oval.getColor());
                    g.FillEllipse(brush, oval.getRectO());
                }
                else
                {
                    pen = new Pen(oval.getColor(), oval.getThick());
                    g.DrawEllipse(pen, oval.getRectO());
                }
            }
        }

        // 마지막 Form 닫을 때 저장 및 이미지 지우기 버튼 비활성화
        private void frmChild_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(ParentForm.MdiChildren.Length == 1)
            {
                parent.saveButton.Enabled = false;
                parent.clearButton.Enabled = false;
            }
        }

        // 마우스 누를 때 눌린 위치 저장
        private void pnlBoard_MouseDown(object sender, MouseEventArgs e)
        {
            p.X = e.X;
            p.Y = e.Y;
            isClicked = true;
        }

        // 마우스 눌린 상태로 이동 시 추가된 도형 설정
        private void pnlBoard_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isClicked) return;
            if (e.Button == MouseButtons.Left)
            {
                switch (parent.mode)
                {
                    // 연필 모드
                    case DrawMode.Pencil:
                        myPen[myPen.Count - 1].setLine(p, e.Location, 1, parent.color); // 직선 집합에 두께 1 새 직선 추가
                        // 좌표 갱신
                        p.X = e.X;
                        p.Y = e.Y;
                        break;
                    // 브러쉬 모드
                    case DrawMode.Brush:
                        myPen[myPen.Count - 1].setLine(p, e.Location, 5, parent.color); // 직선 집합에 두께 5 새 직선 추가
                        // 좌표 갱신
                        p.X = e.X;
                        p.Y = e.Y;
                        break;
                    // 직선 모드
                    case DrawMode.Line:
                        myLines[myLines.Count - 1].setPoint(p, e.Location, parent.thick, parent.color); // 직선 설정
                        break;
                    // 사각형 모드
                    case DrawMode.Rectangle:
                        myRect[myRect.Count - 1].setRect(p, e.Location, parent.thick, parent.color, parent.fillMode);   // 사각형 설정
                        break;
                    // 타원 모드
                    case DrawMode.Oval:
                        myOval[myOval.Count - 1].setRectO(p, e.Location, parent.thick, parent.color, parent.fillMode);  // 타원 설정
                        break;
            }


            // 패널 다시 그리기
            pnlBoard.Invalidate(true);
            pnlBoard.Update();
        }
        }

        // 마우스 놓으면 그려질 새 도형 추가
        private void pnlBoard_MouseUp(object sender, MouseEventArgs e)
        {
            isClicked = false;
            if (e.Button == MouseButtons.Left)
            {
                switch (parent.mode)
                {
                    case (DrawMode.Pencil | DrawMode.Brush):
                        myPen.Add(new MyPen());
                        break;
                    case DrawMode.Line:
                        myLines.Add(new MyLines());
                        break;
                    case DrawMode.Rectangle:
                        myRect.Add(new MyRect());
                        break;
                    case DrawMode.Oval:
                        myOval.Add(new MyOval());
                        break;
                }
            }
        }

        // 이미지 지우기 함수
        public void Clear()
        {
            myPen.Clear();
            myLines.Clear();
            myRect.Clear();
            myOval.Clear();
            myPen.Add(new MyPen());
            myLines.Add(new MyLines());
            myRect.Add(new MyRect());
            myOval.Add(new MyOval());
            img = new Bitmap(pnlBoard.Width, pnlBoard.Height);
            pnlBoard.Refresh();
        }
    }
}
