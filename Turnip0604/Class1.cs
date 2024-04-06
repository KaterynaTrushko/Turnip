using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Turnip0604
    {
    public interface ICharacter
        {
        public int Pawer { get; set; }
        public string Name { get; set; }
        public void CallForHelp(Character obj);
        public void Pull();
        
        }

    public class Character : ICharacter
        {
        public int Pawer { get; set; }
        public string Name { get; set; }
        public Character(string name, int pawer) 
            {
            this.Name = name;
            this.Pawer = pawer;
            }

        public void Pull() 
            {
            Console.WriteLine("Pull!");
            }
        public void CallForHelp(Character obj) 
            {
            Console.WriteLine($"{obj} come here to help!");
            }

        public override string ToString() 
            {
            return Name;
            }

        }

    public class Plant
        {
        public int Pawer { get; set; }
        public string Name { get; set; }
        public Plant(string name, int pawer)
            {
            this.Name = name;
            this.Pawer = pawer;
            }
        }

    public class Turnip : Plant
        {
        public Turnip(string name, int pawer) : base(name, pawer)
            {
            this.Name = name;
            this.Pawer = pawer;
            }
        }
    }
