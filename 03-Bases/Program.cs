using System;

namespace Bases;

class Program
{
    static void Main(string[] args)
    {
        // Demander a l'utilisateur ercire son nom.
        Console.Write("Quel est ton nom ?" );

      
        // creation de la variable nom on utilise sring pour des chaines de caractere
        // + Ajout de la fonction ReadLine pour que l'utilisateur 
        // puisse ecrire son nom dans la console.
        string nom = Console.ReadLine();
         
          // Exercice 1 : demander l'age a l'utitlisateur

          // Je demande a l'utilisateur d' ecrire son age
          Console.Write("Quel est votre age ?" );


          // creation de la variable Age on utiliseras string + int.Parse pour transformer
          // la chaine de caracter en int -> soit en nombres entiers 
          // + Ajout de la fonction ReadLine pour que l'utilisateur 
          // puisse lire son Age dans la console.
          string ageStr =Console.ReadLine();

          // 0,1,2,3,4,5 ...; -> int
          int ageNum = int.Parse(ageStr);

          // Affichage du texte final.
          Console.WriteLine("Bonjour, vous vous appellez " + nom  +  ", vous avez "  + ageNum +  " ans");


          // Ajout d'une nouvelle d'une nouvelle variable int
          int ageProchain = ageNum + 1;
          Console.WriteLine("bientot vous aurez " + ageProchain + " ans");
        
    }
}
