using System;
using System.Collections.Generic;

namespace LesMissions 
{
    public class TrainingC{
        public static void ParcourirUneListe(){

        // Création de ma liste

            List<string> MissionsRed = new List<string>();


        // Je vais ajouter des éléments dans ma liste
    // Pour ajouter quelque chose dans ma liste :
        // MissionsRed.Add("");
        
            MissionsRed.Add("1/ Ecrire un texte sur le feu");
            MissionsRed.Add("2/ Ecrire un texte fantastique avec des chats");
            MissionsRed.Add("3/ Ecrire un texte sur le thème des 'apparences'");
            MissionsRed.Add("4/ Ecrire un texte sans verbe !");
            MissionsRed.Add("5/Ecrire un texte pessimiste avec un msg d'espoir à la fin ");

            Console.WriteLine("Liste des missions de RedKitty");
            foreach(string item in MissionsRed){
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(item);
            
            }

        }

    }
}
