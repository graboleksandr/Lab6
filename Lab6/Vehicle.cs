using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    public interface IRefuelable
    {
        void Refill();
    }

    public abstract class Vehicle
    {
        public string brand;
        public int speed;
        public abstract void Move();
    }

    public class Bicycle : Vehicle
    {
        public override void Move() => Console.WriteLine($"Велосипед {brand} їде по доріжці.");
    }

    public class Airplane : Vehicle, IRefuelable
    {
        public override void Move() => Console.WriteLine($"Літак {brand} летить у небі.");
        public void Refill() => Console.WriteLine($"[Заправка] {brand} заправлено авіапаливом.");
    }

    public class Car : Vehicle, IRefuelable
    {
        public override void Move() => Console.WriteLine($"Машина {brand} їде по шосе.");
        public void Refill() => Console.WriteLine($"[Заправка] {brand} заправлено бензином.");
    }
}
