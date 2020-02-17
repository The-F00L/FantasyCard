using System;
using System.Collections.Generic;
using System.Text;

namespace Fantasycard
{
    class Card
    {
        private int _power;
        private string _name,_faction,_race,_class;

        public Card(int power, string name, string faction, string race, string @class)
        {
            _power = power;
            _name = name;
            _faction = faction;
            _race = race;
            _class = @class;
        }

        public override string ToString()
        {
            return "power " + _power + " name " + _name + " faction " + _faction + " race " + _race + " class " + _class;
        }

        public int getPower()
        {
            return _power;
        }
        public string getName() {
            return _name;
        }
        public string getFaction()
        {
            return _faction;
        }
        public string getRace()
        {
            return _race;
        }
        public string getClass()
        {
            return _class;
        }
        
    }
}
