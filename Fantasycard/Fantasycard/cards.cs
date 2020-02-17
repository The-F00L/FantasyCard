using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Fantasycard
{

    class Cards
    {
        List<Card> cards = new List<Card>();

        public void beolvas() {
            try
            {


                using (StreamReader sr = new StreamReader("fantasycard.csv"))
                {
                    
                    String line = sr.ReadLine();
                    line = sr.ReadLine();
                    while ((line = sr.ReadLine()) != null) {
                         string[] dataLine = line.Split(";");
                        cards.Add(new Card(Convert.ToInt32(dataLine[0]),dataLine[1],dataLine[2],dataLine[3],dataLine[4]));
                    }
                   // Console.WriteLine(line);
                }

                foreach (Card card in cards)
                {
                    Console.WriteLine(card);
                }

            }
            catch (IOException e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }


        public string leeroy() {
            foreach (Card card in cards)
            {
                if (card.getName().Equals("Leeroy"))
                {
                    return card.getRace() + " " + card.getClass();
                }
            }

            return null;
        }


        public string powerMinSearch() {
            int min = cards[0].getPower();
            string minName=cards[0].getName();
            for (int i = 0; i < cards.Count; i++)
            {
                if (cards[i].getPower()<min)
                {
                    min = cards[i].getPower();
                    minName = cards[i].getName();
                }
            }
            return min + ":" + minName;

        }

        public string powerMaxSearch()
        {
            int max = cards[0].getPower();
            string maxName = cards[0].getName();
            for (int i = 0; i < cards.Count; i++)
            {
                if (cards[i].getPower() > max)
                {
                    max = cards[i].getPower();
                    maxName = cards[i].getName();
                }
            }
            return max + ":" + maxName;

        }

        public string compSearchDwarf() {
            for (int i = 0; i < cards.Count; i++)
            {
                if (cards[i].getRace().ToLower().Equals("dwarf") && cards[i].getPower() == 4000)
                {
                    return cards[i].getName();
                }
            }
            return null;
        }

        public string compSearchOrc() {
            string orcs="";
            for (int i = 0; i < cards.Count; i++)
            {
                if (cards[i].getRace().ToLower().Equals("orc") && cards[i].getPower() >= 4500 && cards[i].getFaction().Equals("Laughing Skull"))
                {
                    orcs +=cards[i].getPower()+":"+ cards[i].getName() + " " + cards[i].getRace() + " " + cards[i].getClass()+"\n";
                }
            }
            return orcs;

        }

        public String raceSearch() {
            int dbHuman = 0, dbOrc = 0, dbElf = 0,dbDwarf=0 ;
            for (int i = 0; i < cards.Count; i++)
            {
                if (cards[i].getRace().ToLower().Equals("human"))
                {
                    dbHuman++;
                }
                else if (cards[i].getRace().ToLower().Equals("orc"))
                {
                    dbOrc++;
                }
                else if (cards[i].getRace().ToLower().Equals("elf"))
                {
                    dbElf++;
                }
                else if (cards[i].getRace().ToLower().Equals("dwarf"))
                {
                    dbDwarf++;
                }
                
            }
            return "Human " + dbHuman + "db\n" + "Orc " + dbOrc + "db\n" + "Elf " + dbElf + "db\n" + "Dwarf " + dbOrc + "db";
        }


        public void raceByMin() {
            
            for (int i = 0; i < cards.Count; i++)
            {
               
                
            }

        }

        public void animal() {
            List<Card> animalDeck = new List<Card>();
            for (int i = 0; i < cards.Count; i++)
            {
                if (cards[i].getFaction().ToLower().Equals("animal"))
                {
                    animalDeck.Add(cards[i]);
                }
            }
            animalDeck.Sort();
          
            using (StreamWriter writetext = new StreamWriter("animal.txt"))
            {
                foreach (Card card in animalDeck)
                {
                    writetext.WriteLine(card);
                }

               
            }
        }

    }
}
