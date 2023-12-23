namespace Graphics;

public class Line
{
    public Point startPoint{get;set;}
    public Point endPoint{get;set;} 

    public Line{
        this.startPoint = new Point(0,0);
        this.endPoint = new Point(0,0);
    }   

}