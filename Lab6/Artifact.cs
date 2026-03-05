using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6_Task3
{
    public class Artifact
    {
        protected int id;

        public Artifact(int id)
        {
            this.id = id;
        }

        public virtual void Identify()
        {
            Console.WriteLine($"[Artifact ID: {id}] Це невідомий стародавній предмет.");
        }
    }

    public class MagicScroll : Artifact
    {
        public MagicScroll(int id) : base(id) { }

        public override void Identify()
        {
            Console.WriteLine($"[Magic Scroll ID: {id}] Це сувій з закляттям вогню. Випромінює тепло.");
        }
    }

    public class AncientSword : Artifact
    {
        public AncientSword(int id) : base(id) { }

        public override void Identify()
        {
            Console.WriteLine($"[Ancient Sword ID: {id}] Це легендарний меч. Лезо все ще гостре.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            List<Artifact> inventory = new List<Artifact>();

            inventory.Add(new MagicScroll(101));
            inventory.Add(new AncientSword(202));
            inventory.Add(new Artifact(303));

            Console.WriteLine("--- Аналіз інвентарю (Динамічний поліморфізм) ---");

            foreach (var item in inventory)
            {
                item.Identify();
            }

            Console.WriteLine("\nНатисніть будь-яку клавішу для виходу...");
            Console.ReadKey();
        }
    }
}


