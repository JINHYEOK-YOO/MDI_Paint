using System.Drawing;

namespace _HW3_2014707040_유진혁
{
    /// <summary>
    /// 직선 표현 클래스
    /// </summary>
    class MyLines
    {
        // 변수 선언부
        private Point[] point = new Point[2];   // 직선 시작점과 끝점
        private int thick;  // 직선 두께
        private Color color;    // 직선 색상

        // 기본 생성자
        public MyLines()
        {
            point[0] = new Point();
            point[1] = new Point();
            thick = 1;
            color = Color.Black;
        }

        // 직선 설정 함수
        public void setPoint(Point start, Point finish, int thick, Color color)
        {
            point[0] = start;
            point[1] = finish;
            this.thick = thick;
            this.color = color;
        }

        // 멤버 변수 getter 함수
        public Point getPoint1() => point[0];
        public Point getPoint2() => point[1];
        public int getThick() =>  thick;
        public Color getColor() => color;
    }
}
