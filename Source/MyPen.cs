using System.Collections.Generic;
using System.Drawing;

namespace _HW3_2014707040_유진혁
{
    /// <summary>
    /// 연필/브러쉬 (곡선) 표현 클래스
    /// </summary>
    class MyPen
    {
        // 변수 선언부
        private List<MyLines> lines; // 직선 집합

        // 기본 생성자
        public MyPen()
        {
            lines = new List<MyLines>();
        }

        // 직선을 컬렉션에 추가하는 함수
        public void setLine(Point start, Point finish, int thick, Color color)
        {
            MyLines line = new MyLines(); // 직선 생성
            line.setPoint(start, finish, thick, color); // 직선 설정 
            lines.Add(line); // 컬렉션에 추가
        }

        // 멤버 변수 getter 함수
        public List<MyLines> getLine() => lines;
    }
}
