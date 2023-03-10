double radius;
double length, area, volume;
Figures FG;
FG = new Figures();
CalcFigures CF;
radius = Convert.ToDouble(Console.ReadLine());
CF = FG.Get_Length;
length = CF(radius);
Console.WriteLine(Math.Round(length, 4));
CF = FG.Get_Area; // присвоить делегату метод Get_Area
area = CF(radius);
Console.WriteLine(Math.Round(area, 4));
CF = FG.Get_Volume; // присвоить делегату метод Get_Volume
volume = CF(radius); // вызов метода Get_Volume
Console.WriteLine(Math.Round(volume, 4));
class Figures
{
    public double Get_Length(double r)
    {


        double length;
        length = 3.1415 * 2 * r;
        return length;
    }
    public double Get_Area(double r)
    {
        double area;
        area = 3.1415 * r * r;
        return area;
    }
    public double Get_Volume(double r)
    {
        double volume;
        volume = 4.0 / 3.0 * 3.1415 * r * r * r;
        return volume;
    }
}
delegate double CalcFigures(double r);
