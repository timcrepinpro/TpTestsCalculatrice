namespace TpTestsCalculatrice.Tests; 
 
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
} 