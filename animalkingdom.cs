using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    class animalkingdom

    //variables
    {
         string typesofannelide;
         string typesofMollusca;
         string typesofArthropods;
         string typesofNippers;
         string typesofPlatyhelminthes;
         string typesofPurifiera;
         string typesofChordatesvertebrate;
         string typesofInvertebrates;
         string typesofVertebrates;


        //constructor
        public animalkingdom(string typesofannelide, string typesofMollusca, string typesofArthropods, string typesofNippers, string typesofPlatyhelminthes, string typesofPurifiera, string typesofChordatesvertebrate, string typesofInvertebrates, string typesofVertebrates)
        {
            this.typesofannelide = typesofannelide;
            this.typesofMollusca = typesofMollusca;
            this.typesofArthropods = typesofArthropods;
            this.typesofNippers = typesofNippers;
            this.typesofPlatyhelminthes = typesofPlatyhelminthes;
            this.typesofPurifiera = typesofPurifiera;
            this.typesofChordatesvertebrate = typesofChordatesvertebrate;
            this.typesofInvertebrates = typesofInvertebrates;
            this.typesofVertebrates = typesofVertebrates;
        }

        public animalkingdom(string typesofInvertebrates, string typesofVertebrates)
        {
            this.typesofInvertebrates = "Sponge";
            this.typesofVertebrates = "fish";
            // the other by deualt
        }

        public animalkingdom(string typesofannelide, string typesofMollusca, string Nippers)
        {
            this.typesofannelide = "Ringedworms";
            this.typesofMollusca = "pinctada";
            this.typesofNippers = "Antedon";
        }

        public animalkingdom()
        {

        }
        public animalkingdom(string typesofannelide, string typesofMollusca, string typesofArthropods, string typesofNippers, string typesofPlatyhelminthes)

        {
            this.typesofannelide = "typesofannelide";
            this.typesofMollusca = "typesofMollusca";
            this.typesofArthropods = "typesofArthropods";
            this.typesofNippers = "typesofNippers";
            this.typesofPlatyhelminthes = "typesofPlatyhelminthes";
        }

        //methods
        public void animalkingdom1()
        {
            string typesofannelide;
            string typesofMollusca;
            string typesofArthropods;
            string typesofNippers;
            string typesofPlatyhelminthes;
            string typesofPurifiera;
            string typesofChordatesvertebrate;
            string typesofInvertebrates;
            string typesofVertebrates;
        }

      /*  public string show(string typesofPlatyhelminthes,string typesofChordatesvertebrate,string typesofInvertebrates,string typesofVertebrates)
        {
             this. typesofPlatyhelminthes = "typesofPlatyhelminthes";
             this. typesofChordatesvertebrate = "typesofChordatesvertebrate";
             this. typesofInvertebrates= "typesofInvertebrates";
             this. typesofVertebrates = "typesofVertebrates";

            Console.WriteLine(typesofPlatyhelminthes, typesofChordatesvertebrate, typesofInvertebrates, typesofVertebrates);
            return (typesofPlatyhelminthes, typesofChordatesvertebrate, typesofInvertebrates, typesofVertebrates);
        }*/

        public void animalkingdom2()
        {
            Console.WriteLine("typesofPlatyhelminthes:" + typesofPlatyhelminthes);      
        }
        public void animalkingdom3()
        {
            Console.WriteLine(" typesofChordatesvertebrate:" + typesofChordatesvertebrate);
        }
        public void animalkingdom4() 
        {
            Console.WriteLine();
        }
        public string animalkingdom5(string typesofPurifiera) 
        {
            Console.WriteLine("typesofPurifiera:" + typesofPurifiera);
            return(typesofPurifiera);
        }
        public string animalkingdom6(string typesofPurifiera)
        {
            Console.WriteLine("typesofPurifiera:" + typesofPurifiera);
            return(typesofPurifiera);
        }





    }

    
}