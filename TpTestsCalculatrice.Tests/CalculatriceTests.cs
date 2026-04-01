namespace TpTestsCalculatrice.Tests;
using Microsoft.VisualStudio.TestTools.UnitTesting; 
using TpTestsCalculatrice.App; 

[TestClass]
public class CalculatriceTests
{
    [TestMethod]
    public void Addition_Retourne5_Si2Plus3()
    {
        Calculatrice calc = new Calculatrice();
        int resultat = calc.Addition(2, 3);
        Assert.AreEqual(5, resultat);
    }

    [TestMethod]
    public void Soustraction_Retourne2_Si5Moins3()
    {
        Calculatrice calc = new Calculatrice();
        int resultat = calc.Soustraction(5, 3);
        Assert.AreEqual(2, resultat);
    }

    [TestMethod]
    public void Division_Retourne5_Si10DivisePar2()
    {
        Calculatrice calc = new Calculatrice();
        double resultat = calc.Division(10, 2);
        Assert.AreEqual(5, resultat);
    }

    [TestMethod]
    public void Division_LeveUneException_SiDivisionParZero()
    {
        Calculatrice calc = new Calculatrice();
        Assert.Throws<Exception>(() => 
        {
            calc.Division(10, 0);
        });
    }
 

    [TestMethod]
    public void EstPair_RetourneTrue_SiNombrePair()
    {
        Calculatrice calc = new Calculatrice();
        bool resultat = calc.EstPair(4);
        Assert.IsTrue(resultat); 
    }

    [TestMethod]
    public void EstPair_RetourneFalse_SiNombreImpair()
    {
        Calculatrice calc = new Calculatrice();
        bool resultat = calc.EstPair(5);
        Assert.IsFalse(resultat); 
    }
    [TestMethod]
    public void Addition_Retourne0()
    {
        Calculatrice calc = new Calculatrice();
        double resultat = calc.Addition(0, 0);
        Assert.AreEqual(0, resultat);        
    }
    [TestMethod]
    public void Addition_Retourne0v2()
    {
        Calculatrice calc = new Calculatrice();
        double resultat = calc.Addition(-1, 1);
        Assert.AreEqual(0, resultat);        
    }
    [TestMethod]
    public void Addition_Retourne300()
    {
        Calculatrice calc = new Calculatrice();
        double resultat = calc.Addition(100, 200);
        Assert.AreEqual(300, resultat);        
    }

    [TestMethod]
    public void max_retourne()
    {
        Calculatrice calc = new Calculatrice();
        int resultat = calc.Max(3, 7);
        Assert.AreEqual(7, resultat);
        resultat = calc.Max(10, 2);
        Assert.AreEqual(10, resultat);
        resultat = calc.Max(5, 5);
        Assert.AreEqual(5, resultat);
        
    }
 

}