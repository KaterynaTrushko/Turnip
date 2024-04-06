

namespace Turnip0604
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            var characters = new List<Character>();
            characters.Add(new Character("grandpa", 40));
            characters.Add(new Character("grandma", 30));
            characters.Add(new Character("granddaughter", 20));
            characters.Add(new Character("dog", 10));

            Turnip turnip = new("turnip", 110);

            int accumulator = 0;
            for(var i = 0; i < characters.Count; i++) 
                {
                accumulator += characters[i].Pawer;
                if (accumulator < turnip.Pawer)
                    {
                    if((i + 1 ) < characters.Count) characters[i].CallForHelp(characters[i + 1]);
                    }
                else {
                    Character newGiro = new("nextGiro", 20);
                    }
                }

            Plant newPlan = new Plant ("tomato", 10);
            }
        }
    }