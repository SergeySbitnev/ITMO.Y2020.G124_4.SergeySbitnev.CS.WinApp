using System;

namespace ITMO.CS.WinApp.ExamWork.IntersectionPoint
{
    class Point
    {
        double x, y;
        public Point(double coordinateX, double coordinateY)
        {
            x = coordinateX;
            y = coordinateY;
        }

        public static string SearchForTheIntersectionPoint(Point pointA, Point pointB, Point pointC, Point pointD)
        {
            string answer;

            //Сheck segments

            if (CheckSegment(pointA.x, pointA.y, pointB.x, pointB.y) == false ||
                CheckSegment(pointC.x, pointC.y, pointD.x, pointD.y) == false)
            {
                return answer = "Ошибка введенных координат!";
            }

            //Exchange fr A<B and C<D, if necessary
            CheckingPointsOnXCoordinate(ref pointA, ref pointB);
            CheckingPointsOnXCoordinate(ref pointC, ref pointD);

            //Check horizontal entry
            if ((pointB.x < pointC.x) || (pointD.x < pointA.x))
            {
                return answer = "Отрезки не пересекаются!";
            }

            //Checking the verticality
            if ((pointA.x == pointB.x) && (pointC.x == pointD.x))
            {
                if (pointA.x == pointC.x)
                {
                    if (!((Math.Max(pointA.y, pointB.y) < Math.Min(pointC.y, pointD.y)) ||
                          (Math.Min(pointA.y, pointB.y) > Math.Max(pointC.y, pointD.y))))
                    {
                        return answer = "Отрезки имеют общую ординату!";
                    }
                    else
                    {
                        return answer = "Отрезки не пересекаются!";
                    }
                }
            }


            //Checking if the first segment is vertical
            if (pointA.x == pointB.x)
            {
                double generalXAB = pointA.x;
                double angularCoefficient = (pointC.y - pointD.y) / (pointC.x - pointD.x);
                double freeVariable = pointC.y - angularCoefficient * pointC.x;
                double generalY = angularCoefficient * generalXAB + freeVariable;

                if (pointC.x <= generalXAB && pointD.x >= generalXAB &&
                    Math.Min(pointA.y, pointB.y) <= generalY &&
                    Math.Max(pointA.y, pointB.y) >= generalY)
                {
                    return answer = "Точка пересечения: координата x = " + generalXAB.ToString("F2") + ", координата y = " + generalY.ToString("F2");
                }
                else
                {
                    return answer = "Отрезки не пересекаются!";
                }
            }

            //Checking if the second segment is vertical
            if (pointC.x == pointD.x)
            {
                double generalXCD = pointC.x;
                double angularCoefficient = (pointA.y - pointB.y) / (pointA.x - pointB.x);
                double freeVariable = pointA.y - angularCoefficient * pointA.x;
                double generalY = angularCoefficient * generalXCD + freeVariable;

                if (pointA.x <= generalXCD && pointB.x >= generalXCD &&
                    Math.Min(pointC.y, pointD.y) <= generalY &&
                    Math.Max(pointC.y, pointD.y) >= generalY)
                {
                    return answer = "Точка пересечения: координата x = " + generalXCD.ToString("F2") + ", координата y = " + generalY.ToString("F2");
                }
                else
                {
                    return answer = "Отрезки не пересекаются!";
                }
            }

            //Segments AB and CD is not vertical
            double angularCoefficientAB = (pointA.y - pointB.y) / (pointA.x - pointB.x);
            double angularCoefficientCD = (pointC.y - pointD.y) / (pointC.x - pointD.x);
            double freeVariableAB = pointA.y - angularCoefficientAB * pointA.x;
            double freeVariableCD = pointC.y - angularCoefficientCD * pointC.x;

            if (angularCoefficientAB == angularCoefficientCD)
            {
                return answer = "Отрезки не пересекаются!";
            }

            double generalX = (freeVariableCD - freeVariableAB) / (angularCoefficientAB - angularCoefficientCD);

            if ((generalX < Math.Max(pointA.x, pointC.x)) || (generalX > Math.Min(pointB.x, pointD.x)))
            {
                return answer = "Отрезки имеют общую абциссу!";
            }
            else
            {
                double generalY = angularCoefficientAB * generalX + freeVariableAB;
                return answer = "Точка пересечения: координата x = " + generalX.ToString("F2") + ", координата y = " + generalY.ToString("F2");
            }
        }



        private static bool CheckSegment(double point1X, double point1Y, double point2X, double point2Y)
        {
            if ((point1X == point2X) && (point1Y == point2Y))
            {
                return false;
            }
            return true;
        }

        private static void CheckingPointsOnXCoordinate(ref Point firstPoint, ref Point secondPoint)
        {
            if (secondPoint.x < firstPoint.x)
            {
                Point temp = firstPoint;
                firstPoint = secondPoint;
                secondPoint = temp;
            }
        }
    }
}
