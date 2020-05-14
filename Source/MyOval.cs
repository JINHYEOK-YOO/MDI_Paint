using System;
using System.Drawing;

namespace _HW3_2014707040_유진혁
{
    /// <summary>
    /// 타원 표현 클래스
    /// </summary>
    class MyOval
    {
        // 변수 선언부
        private Rectangle rectO; // 타원에 외접하는 사각형
        private int thick;  // 타원 선의 두께
        private Color color;    // 타원 색상
        private bool isFilled;  // 타원 채우기 여부

        // 기본 생성자
        public MyOval()
        {
            rectO = new Rectangle();
            thick = 1;
            color = Color.Black;
            isFilled = false;
        }

        // 타원 설정 함수
        public void setRectO(Point start, Point finish, int thick, Color color, bool fill)
        {
            rectO.X = Math.Min(start.X, finish.X);
            rectO.Y = Math.Min(start.Y, finish.Y);
            rectO.Width = Math.Abs(start.X - finish.X);
            rectO.Height = Math.Abs(start.Y - finish.Y);
            this.thick = thick;
            this.color = color;
            this.isFilled = fill;
        }

        // 멤버 변수 getter 함수
        public Rectangle getRectO() => rectO;
        public int getThick() => thick;
        public Color getColor() => color;
        public bool getFill() => isFilled;
    }
}
