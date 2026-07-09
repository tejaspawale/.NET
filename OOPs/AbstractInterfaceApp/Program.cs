

namespace TestApp;

using TflDrawing;
public class Program
{
    public static void Main(string [] args)
    {
        Shape theShape= new Line();
        theShape.Draw();
        theShape.Drop();


        IPrintable printer=(IPrintable)theShape;
        IPortable prototype = (IPortable)theShape;
        printer.Print();
        prototype.Print();
        
    


    }
}