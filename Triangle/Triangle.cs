using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    public class Triangle
    {

        public static string TriangleAnalyze(int s1, int s2, int s3)
        {
            String triangleType = "Not Recognized";


            if (s1 <= 0 || s2 <= 0 || s3 <= 0)
            {
                Console.WriteLine("Sides can't produce a triangle");
            }

            if (s1 > 0 && s2 > 0 && s3 > 0)
            {
                if (((s1 + s2) > s3) && (s2 + s3) > s1 && (s1 + s3) > s2)
                {

                    if (s1 == s2 && s2 == s3)
                    {
                        triangleType = "Equilateral Triangle";
                    }

                    else if (s1 == s2 || s2 == s3 || s3 == s1)
                    {
                        triangleType = "Isosceles Triangle";
                    }
                    else
                    {
                        triangleType = "Scalene Triangle";
                    }
                }
            }

            return triangleType;
        }

    }
}
