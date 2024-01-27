namespace Task1;

public class Math
{
    const double _pi = 3.14;
    const double _E = 2.71;


    public double Abs(double minpil)
    {
     minpil = _pi;
     return Abs(minpil); 
    }
    public float Abs(float fl)
    {
        fl = (float)_E;
        return fl;

    }
    // public int Abs(int value)
    // {
            
     // }
    public double Pow(double x, double y)
    {
        x = _pi;
        y = _E;
        return x * y;   
    }
    public double Sqrt(double d)
    {
            for (int i = 0; i < d; i++)
            {
                if(i*i==d)
                {
                    return i;
                }
                else{
                    return 0;
                }
            }
            return d;
    }
    public int Max(int val1, int val2)
    {
            val1 =(int)_pi;
            val2 = (int) _E;

            return Max(val1,val2);
    }
    public int Min(int val1, int val2)
    { 
            val1 =(int)_pi;
            val2 = (int) _E;

            return Min(val1,val2);  
    }

}
