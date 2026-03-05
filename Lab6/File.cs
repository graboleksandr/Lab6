using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    public abstract class File
    {
        public string fileName;
        public double sizeMb;
        public abstract void Open();
    }

    public class ImageFile : File
    {
        public override void Open() => Console.WriteLine($"[Image Viewer] Відкрито фото {fileName}. Розмір: {sizeMb} MB.");
    }

    public class TextFile : File
    {
        public override void Open() => Console.WriteLine($"[Notepad++] Читання документа {fileName}. Розмір: {sizeMb} MB.");
    }

    public class VideoFile : File
    {
        public override void Open() => Console.WriteLine($"[VLC Player] Запуск відео {fileName}. Розмір: {sizeMb} MB.");
    }

   /* public class Program
    {
        public static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            List<File> files = new List<File> {
                new ImageFile { fileName = "cat.jpg", sizeMb = 2.4 },
                new TextFile { fileName = "lab6.txt", sizeMb = 0.1 },
                new VideoFile { fileName = "vlog.mp4", sizeMb = 500 }
            };
            foreach (var f in files) f.Open();
        }
    }*/
}
