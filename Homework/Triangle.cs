using System;


class Programm{ 
    static void Main(){ 
        TrianglePascal TrianglePasc = new TrianglePascal();
        TrianglePasc.FillTriangle(5, new triangle[2,3]);
        TrianglePasc.PrintTriangle();
        TrianglePasc.Magic();
        

}
}