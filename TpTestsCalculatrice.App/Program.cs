

namespace TpTestsCalculatrice.App;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Calculatrice calc = new Calculatrice(); 
 
        Console.WriteLine(calc.Addition(2, 3)); 
        Console.WriteLine(calc.Division(10, 2)); 
    }
}


/*
car il teste pour tres peut de possibiliter


Répondre aux questions suivantes : 
1. Quelle est la différence entre un test manuel et un test unitaire ? 
le test manuel est un test quon rentre une fosi dans le code , le test dans un projesct separer est un code specialement concu pou tester
2. Pourquoi place-t-on les tests dans un projet séparé ? 
pour pouvoir les enlever plus facilement
3. Pourquoi faut-il tester plusieurs cas pour une même méthode ? 
car la methode peut marcher pour un cetain cas mais pas pour dautre
4. Que signifient les trois étapes de la méthode AAA ? 
○ Arrange 
○ Act 
○ Assert 
Arrange prepare le test
act apelle la fonction a tester
assert verrifie le resultat
*/