using System;
using System.Drawing;

namespace _HW3_2014707040_유진혁
{
    /// <summary>
    /// 사각형 표현 클래스
    /// </summary>
    class MyRect
    {
        // 변수 선언부
        private Rectangle rect; // 사각형
        private int thick; // 사각형 선의 두께
        private Color color; // 사각형 색상
        private bool isFilled; // 사각형 채우기 여부

        // 기본 생성자
        public MyRect()
        {
            rect = new Rectangle();
            thick = 1;
            color = Color.Black;
            isFilled = false;
        }

        // 사각형 설정 함수
        public void setRect(Point start, Point finish, int thick, Color color, bool fill)
        {
            // 사각형 좌표 설정
            rect.X = Math.Min(start.X, finish.X);
            rect.Y = Math.Min(start.Y, finish.Y);
            rect.Width = Math.Abs(finish.X - start.X);
            rect.Height = Math.Abs(finish.Y - start.Y);

            this.thick = thick;
            this.color = color;
            this.isFilled = fill;
        }

        // 멤버 변수 getter 함수
        public Rectangle getRect() => rect;
        public int getThick() => thick;
        public Color getColor() => color; 
        public bool getFill() => isFilled;
    }
}
