using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3d_IK
{
    public partial class Form1 : Form
    {
        Bitmap bmp = new Bitmap(500, 500);
        Graphics gr;
        List<MyPoint> Coord = new List<MyPoint>();
        List<MyPoint> Points = new List<MyPoint>();
        List<MyEdge> Edges = new List<MyEdge>();
        List<MyFace> Faces = new List<MyFace>();

        double X0;
        double Y0;

        Color background = Color.White;
        Color contour = Color.Blue;
        Color fill = Color.Blue;

        public Form1()
        {
            X0 = (double)bmp.Width/4;
            Y0 = (double)bmp.Width / 2;
            InitializeComponent();
        }

        public double[,] Multiply(double[,] M1, double[,] M2)
        {
            if (M1.GetLength(1) != M2.GetLength(0)) throw new Exception("Error");
            double[,] Rez = new double[M1.GetLength(0), M2.GetLength(1)];

            for (int i = 0; i < M1.GetLength(0); i++)
            {
                for (int j = 0; j < M2.GetLength(1); j++)
                {
                    for (int k = 0; k < M2.GetLength(0); k++)
                    {
                        Rez[i, j] += M1[i, k] * M2[k, j];
                    }
                }
            }
            return Rez;
        }

        public double[,] Transfer(double dx, double dy, double dz)
        {
            var matrix = new[,]
            {
                { 1d, 0d, 0d, 0d },
                { 0d, 1d, 0d, 0d },
                { 0d, 0d, 1d, 0d },
                { dx, dy, dz, 1d }
            };
            return matrix;
        }

        public double[,] Scale(double Sx, double Sy, double Sz)
        {
            var matrix = new[,]
            {
                { Sx, 0d, 0d, 0d },
                { 0d, Sy, 0d, 0d },
                { 0d, 0d, Sz, 0d },
                { 0d, 0d, 0d, 1d }
            };
            return matrix;
        }

        public List<MyPoint> Action(double[,] M, List<MyPoint> list)
        {
            double[,] buff;

            for (int i = 0; i < list.Count; i++)
            {
                buff = Multiply(list[i].ToMatr(), M);
                list[i].X = buff[0, 0];
                list[i].Y = buff[0, 1];
                list[i].Z = buff[0, 2];
                list[i].W = buff[0, 3];
            }
            return list;
        }

        public double[,] RotateX(double angle)
        {
            if (angle < 0) angle += 360;
            var matrix = new[,]
            {
                {1d, 0d, 0d, 0d},
                {0d, Math.Cos(angle * Math.PI / 180d), Math.Sin(angle * Math.PI / 180d), 0d},
                {0d, -Math.Sin(angle * Math.PI / 180d), Math.Cos(angle * Math.PI / 180d), 0d},
                {0d, 0d, 0d, 1d}
            };
            return matrix;
        }

        public double[,] RotateY(double angle)
        {
            if (angle < 0) angle += 360;
            var matrix = new[,]
            {
                {Math.Cos(angle * Math.PI / 180d), 0d, -Math.Sin(angle * Math.PI / 180d), 0d},
                {0d, 1d, 0d, 0d},
                {Math.Sin(angle * Math.PI / 180d), 0d, Math.Cos(angle * Math.PI / 180d), 0d},
                {0d, 0d, 0d, 1d}
            };
            return matrix;
        }

        public double[,] RotateZ(double angle)
        {
            if (angle < 0) angle += 360;
            var matrix = new[,]
            {
                {Math.Cos(angle * Math.PI / 180d), Math.Sin(angle * Math.PI / 180d), 0d, 0d},
                {-Math.Sin(angle * Math.PI / 180d), Math.Cos(angle * Math.PI / 180d), 0d, 0d},
                {0d, 0d, 1d, 0d},
                {0d, 0d, 0d, 1d}
            };
            return matrix;
        }

        public double[,] Perspective(double d)
        {
            var matrix = new[,]
            {
                {1d, 0d, 0d, 0d},
                {0d, 1d, 0d, 0d},
                {0d, 0d, 1d, 1d/d},
                {0d, 0d, 0d, 0d}
            };
            return matrix;
        }

        public double[,] Oblique(double a, double L)
        {
            var matrix = new[,]
            {
                {1d, 0d, 0d, 0d},
                {0d, 1d, 0d, 0d},
                {Math.Cos(a * Math.PI / 180d) * L, Math.Sin(a * Math.PI / 180d) * L, 1d, 0d},
                {0d, 0d, 0d, 1d}
            };
            return matrix;
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBoxA.Text);
            double b = Convert.ToDouble(textBoxB.Text);
            double c = Convert.ToDouble(textBoxC.Text);
            double h = Convert.ToDouble(textBoxH.Text);
            CreateModel(a, b, c, h);
            Draw();
        }

        private void buttonRotate_Click(object sender, EventArgs e)
        {
            double[,] X = RotateX(Convert.ToDouble(textBoxRotateX.Text));
            double[,] Y = RotateY(Convert.ToDouble(textBoxRotateY.Text));
            double[,] Z = RotateZ(Convert.ToDouble(textBoxRotateZ.Text));
            Points = Action(Multiply(Multiply(X, Y), Z), Points);
            Draw();
        }

        private void buttonMove_Click(object sender, EventArgs e)
        {

            double[,] T = Transfer(Convert.ToDouble(textBoxMoveX.Text),
                                   Convert.ToDouble(textBoxMoveY.Text),
                                   Convert.ToDouble(textBoxMoveZ.Text));
            Points = Action(T, Points);
            Draw();
        }

        private void buttonScale_Click(object sender, EventArgs e)
        {
            double[,] S = Scale(Convert.ToDouble(textBoxScaleX.Text),
                                Convert.ToDouble(textBoxScaleY.Text),
                                Convert.ToDouble(textBoxScaleZ.Text));
            Points = Action(S, Points);
            Draw();
        }

        public void CreateModel(double a, double b, double c, double h)
        {
            Points.Clear();
            Edges.Clear();
            Faces.Clear();


            Points.Add(new MyPoint(0d, 0d, 0d, 1d)); int n0 = Points.Count - 1;         //0
            Points.Add(new MyPoint(a, 0d, 0d, 1d)); int n1 = Points.Count - 1;          //1
            Points.Add(new MyPoint(a, h-a, 0d, 1d)); int n2 = Points.Count - 1;         //2
            Points.Add(new MyPoint(c-a, h-a, 0d, 1d)); int n3 = Points.Count - 1;       //3
            Points.Add(new MyPoint(a, 0d, b, 1d)); int n4 = Points.Count - 1;           //4
            Points.Add(new MyPoint(c-a, 0d, 0d, 1d)); int n5 = Points.Count - 1;        //5
            Points.Add(new MyPoint(c, 0d, 0d, 1d)); int n6 = Points.Count - 1;         //6
            Points.Add(new MyPoint(c, h, b, 1d)); int n7 = Points.Count - 1;         //7
            Points.Add(new MyPoint(0d, h, b, 1d)); int n8 = Points.Count - 1;         //8
            Points.Add(new MyPoint(c, 0d, b, 1d)); int n9 = Points.Count - 1;         //9
            Points.Add(new MyPoint(c, h, 0d, 1d)); int n10 = Points.Count - 1;         //10
            Points.Add(new MyPoint(0d, h, 0d, 1d)); int n11 = Points.Count - 1;         //11
            Points.Add(new MyPoint(c-a, 0d, b, 1d)); int n12 = Points.Count - 1;         //12
            Points.Add(new MyPoint(c-a, h-a, b, 1d)); int n13 = Points.Count - 1;         //13
            Points.Add(new MyPoint(a, h-a, b, 1d)); int n14 = Points.Count - 1;         //14
            Points.Add(new MyPoint(0d, 0d, b, 1d)); int n15 = Points.Count - 1;         //15

            Edges.Add(new MyEdge(n0, n15));
            Edges.Add(new MyEdge(n0, n11));
            Edges.Add(new MyEdge(n0, n1));

            Edges.Add(new MyEdge(n1, n2));
            Edges.Add(new MyEdge(n1, n4));

            Edges.Add(new MyEdge(n2, n14));
            Edges.Add(new MyEdge(n2, n3));

            Edges.Add(new MyEdge(n3, n13));
            Edges.Add(new MyEdge(n3, n5));

            Edges.Add(new MyEdge(n4, n15));
            Edges.Add(new MyEdge(n4, n14));

            Edges.Add(new MyEdge(n5, n12));
            Edges.Add(new MyEdge(n5, n6));


            Edges.Add(new MyEdge(n6, n10));
            Edges.Add(new MyEdge(n6, n9));

            Edges.Add(new MyEdge(n7, n9));
            Edges.Add(new MyEdge(n7, n10));
            Edges.Add(new MyEdge(n7, n8));

            Edges.Add(new MyEdge(n8, n11));
            Edges.Add(new MyEdge(n8, n15));

            Edges.Add(new MyEdge(n9, n12));

            Edges.Add(new MyEdge(n10, n11));

            Edges.Add(new MyEdge(n12, n13));

            Edges.Add(new MyEdge(n13, n14));

          /*  Faces.Add(new MyFace(new List<int>() { n0, n1, n2, n3, n5, n6, n10, n11 }));
            Faces.Add(new MyFace(new List<int>() { n15, n4, n14, n13, n12, n9, n7, n8 }));

            Faces.Add(new MyFace(new List<int>() { n0, n1, n4, n15 }));
            Faces.Add(new MyFace(new List<int>() { n5, n6, n9, n12 }));
            Faces.Add(new MyFace(new List<int>() { n2, n3, n13, n14 }));
            Faces.Add(new MyFace(new List<int>() { n11, n10, n7, n8 }));


            Faces.Add(new MyFace(new List<int>() { n0, n11, n8, n15 }));
            Faces.Add(new MyFace(new List<int>() { n1, n2, n14, n4 }));
            Faces.Add(new MyFace(new List<int>() { n5, n3, n13, n12 }));
            Faces.Add(new MyFace(new List<int>() { n6, n10, n7, n9 }));*/
        }

        public void Draw()
        {
                DrawEdges();
       
        }

        public void DrawEdges()
        {
            gr = Graphics.FromImage(bmp);
            gr.Clear(background);
            Pen pen = new Pen(contour);

            SysCoord();

            List<MyPoint> localPoints = Projection();

            for (int i = 0; i < Edges.Count; i++)
            {
                gr.DrawLine(pen,
                    Convert.ToInt32(Math.Round(X0 + localPoints[Edges[i].P1].X)),
                    Convert.ToInt32(Math.Round(Y0 - localPoints[Edges[i].P1].Y)),
                    Convert.ToInt32(Math.Round(X0 + localPoints[Edges[i].P2].X)),
                    Convert.ToInt32(Math.Round(Y0 - localPoints[Edges[i].P2].Y))
                    );
            }
            pictureBox1.Image = bmp;
        }

        public void SysCoord()
        {
            Coord.Clear();
            
            //OX
            Coord.Add(new MyPoint(230d, 0d, 0d, 1d));
            Coord.Add(new MyPoint(0d, 0d, 0d, 1d));
            Coord.Add(new MyPoint(250d, 0d, 0d, 1d));

            //OY
            Coord.Add(new MyPoint(0d, 230d, 0d, 1d));
            Coord.Add(new MyPoint(0d, 0d, 0d, 1d));
            Coord.Add(new MyPoint(0d, 250d, 0d, 1d));

            //OZ
            Coord.Add(new MyPoint(0d, 0d, 230d, 1d));
            Coord.Add(new MyPoint(0d, 0d, 0d, 1d));
            Coord.Add(new MyPoint(0d, 0d, 250d, 1d));

            double[,] M = null;

            if (radioButtonProfile.Checked)
            {
                M = RotateY(90);
            }

            if (radioButtonHorizontal.Checked)
            {
                M = RotateX(270);
            }


            if (radioButtonPerspective.Checked)
            {
                double[,] buff;
                double d = Convert.ToDouble(textBoxD.Text);
                double p = Convert.ToDouble(textBoxRo.Text);
                M = Multiply(RotateZ(Convert.ToDouble(textBoxEpsilon.Text)), RotateX(Convert.ToDouble(textBoxFi.Text)));

                for (int i = 0; i < Coord.Count; i++)
                {
                    buff = Multiply(Coord[i].ToMatr(), M);
                    buff[0, 2] = buff[0, 2] + p;
                    if ((buff[0, 2] < 0.001d) && (buff[0, 2] >= 0)) { buff[0, 2] = 0.001d; }
                    if ((buff[0, 2] > -0.001d) && (buff[0, 2] < 0)) { buff[0, 2] = -0.001d; }
                    Coord[i].X = buff[0, 0] / (buff[0, 2] / d);
                    Coord[i].Y = buff[0, 1] / (buff[0, 2] / d);
                    Coord[i].Z = buff[0, 2];
                    Coord[i].W = 1;
                }
                M = null;
            }

            if (radioButtonAxonometric.Checked)
            {
                M = Multiply(RotateY(Convert.ToDouble(textBoxPsi.Text)), RotateX(Convert.ToDouble(textBoxFiAx.Text)));
            }

            if (radioButtonOblique.Checked)
            {
                M = Oblique(Convert.ToDouble(textBoxAlpha.Text), Convert.ToDouble(textBoxL.Text));
            }

            if (M != null)
            {
                double[,] buff;
                for (int i = 0; i < Coord.Count; i++)
                {
                    buff = Multiply(Coord[i].ToMatr(), M);
                    Coord[i].X = buff[0, 0];
                    Coord[i].Y = buff[0, 1];
                    Coord[i].Z = buff[0, 2];
                    Coord[i].W = buff[0, 3];
                }
            }

            gr = Graphics.FromImage(bmp);
            gr.DrawLine(Pens.Red,
                        Convert.ToInt32(Math.Round(X0 + Coord[1].Y)),
                        Convert.ToInt32(Math.Round(Y0 - Coord[1].X)),
                        Convert.ToInt32(Math.Round(X0 + Coord[2].X)),
                        Convert.ToInt32(Math.Round(Y0 - Coord[2].Y)));
            gr.DrawLine(Pens.Red,
                        Convert.ToInt32(Math.Round(X0 + Coord[4].X)),
                        Convert.ToInt32(Math.Round(Y0 - Coord[4].Y)),
                        Convert.ToInt32(Math.Round(X0 + Coord[5].X)),
                        Convert.ToInt32(Math.Round(Y0 - Coord[5].Y)));
            gr.DrawLine(Pens.Red,
                        Convert.ToInt32(Math.Round(X0 + Coord[7].X)),
                        Convert.ToInt32(Math.Round(Y0 - Coord[7].Y)),
                        Convert.ToInt32(Math.Round(X0 + Coord[8].X)),
                        Convert.ToInt32(Math.Round(Y0 - Coord[8].Y)));

            gr.DrawString("X", new Font("Microsoft Sans Serif", 12, FontStyle.Bold),
                          new SolidBrush(Color.Black),
                          Convert.ToInt32(Math.Round(X0 + Coord[0].X)),
                          Convert.ToInt32(Math.Round(Y0 - Coord[0].Y)));
            gr.DrawString("Y", new Font("Microsoft Sans Serif", 12, FontStyle.Bold),
                          new SolidBrush(Color.Black),
                          Convert.ToInt32(Math.Round(X0 + Coord[3].X)),
                          Convert.ToInt32(Math.Round(Y0 - Coord[3].Y)));
            gr.DrawString("Z", new Font("Microsoft Sans Serif", 12, FontStyle.Bold),
                          new SolidBrush(Color.Black),
                          Convert.ToInt32(Math.Round(X0 + Coord[6].X)),
                          Convert.ToInt32(Math.Round(Y0 - Coord[6].Y)));

        }

        public List<MyPoint> Projection()
        {
            List<MyPoint> localPoints = new List<MyPoint>();
            foreach (MyPoint p in Points)
            {
                localPoints.Add(new MyPoint(p));
            }

            double[,] M;

            if (radioButtonProfile.Checked)
            {
                M = RotateY(90);
                localPoints = Action(M, localPoints);
            }

            if (radioButtonHorizontal.Checked)
            {
                M = RotateX(270);
                localPoints = Action(M, localPoints);
            }


            if (radioButtonPerspective.Checked)
            {
                double[,] buff;
                double d = Convert.ToDouble(textBoxD.Text);
                double p = Convert.ToDouble(textBoxRo.Text);
                M = Multiply(RotateZ(Convert.ToDouble(textBoxEpsilon.Text)), RotateX(Convert.ToDouble(textBoxFi.Text)));

                for (int i = 0; i < localPoints.Count; i++)
                {
                    buff = Multiply(localPoints[i].ToMatr(), M);
                    buff[0, 2] = buff[0, 2] + p;
                    if ((buff[0, 2] < 0.001d) && (buff[0, 2] >= 0)) { buff[0, 2] = 0.001d; }
                    if ((buff[0, 2] > -0.001d) && (buff[0, 2] < 0)) { buff[0, 2] = -0.001d; }
                    localPoints[i].X = buff[0, 0] / (buff[0, 2] / d);
                    localPoints[i].Y = buff[0, 1] / (buff[0, 2] / d);
                    localPoints[i].Z = buff[0, 2];
                    localPoints[i].W = 1;
                }
            }
            if (radioButtonAxonometric.Checked)
            {
                M = Multiply(RotateY(Convert.ToDouble(textBoxPsi.Text)), RotateX(Convert.ToDouble(textBoxFiAx.Text)));
                localPoints = Action(M, localPoints);
            }
            if (radioButtonOblique.Checked)
            {
                M = Oblique(Convert.ToDouble(textBoxAlpha.Text), Convert.ToDouble(textBoxL.Text));
                localPoints = Action(M, localPoints);
            }

            return localPoints;
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            Draw();
        }
    }





    public class MyPoint
    {
        public double X, Y, Z, W;

        public MyPoint(){ }

        public MyPoint(double X, double Y, double Z, double W)
        {
            this.X = X;
            this.Y = Y;
            this.Z = Z;
            this.W = W;
        }

        public MyPoint(MyPoint p)
        {
            X = p.X;
            Y = p.Y;
            Z = p.Z;
            W = p.W;
        }

        public double[,] ToMatr()
        {
            double[,] Rez = new double[1, 4];
            Rez[0, 0] = X;
            Rez[0, 1] = Y;
            Rez[0, 2] = Z;
            Rez[0, 3] = W;
            return Rez;
        }
    }

    public class MyEdge
    {
        public int P1;
        public int P2;

        public MyEdge() { }
        public MyEdge(int a, int b)
        {
            P1 = a;
            P2 = b;
        }
    }

    public class MyFace
    {
        public List<int> F = new List<int>();
        public MyFace() { }
        public MyFace(List<int> L)
        {
            F = new List<int>(L);
        }
        public Point[] ToArray(List<MyPoint> P, int x0, int y0)
        {
            Point[] Arr = new Point[F.Count];
            for (int i = 0; i < Arr.Length; i++)
            {
                Arr[i].X = x0 + Convert.ToInt32(Math.Round(P[F[i]].X));
                Arr[i].Y = y0 - Convert.ToInt32(Math.Round(P[F[i]].Y));
            }
            return Arr;
        }
    }
}
