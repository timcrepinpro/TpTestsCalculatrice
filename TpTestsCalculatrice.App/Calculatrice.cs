public class Calculatrice 
{ 
    public int Addition(int a, int b) 
    { 
        return a + b; 
    } 
 
    public int Soustraction(int a, int b) 
    { 
        return a - b; 
    } 
 
    public int Multiplication(int a, int b) 
    { 
        return a * b; 
    } 
 
    public double Division(double a, double b) 
    { 
        if (b == 0) 
        { 
            throw new Exception("Division par zéro"); 
        } 
 
        return a / b; 
    } 
 
    public bool EstPair(int nombre) 
    { 
        return nombre % 2 == 0; 
    } 
 
    public int Max(int a, int b) 
    { 
        return a > b ? a : b; 
    } 
} 