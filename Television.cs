using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_work_3
{
    public class Television
    {
        public string Brand;
        public string Model;
        public int ScreenSize;
        public string Resolution;
        public bool IsSmartTV;
        public int SoundPower;
        public bool IsOn;
        public int Brightness;

        public void TurnOn()
        {
            IsOn = true;
            Console.WriteLine("Телевізор увімкнено.");
        }

        public void TurnOff()
        {
            IsOn = false;
            Console.WriteLine("Телевізор вимкнено.");
        }

        public void AdjustBrightness(int level)
        {
            if (level < 0 || level > 100)
            {
                Console.WriteLine("Рівень яскравості повинен бути від 0 до 100.");
            }
            else
            {
                Brightness = level;
                Console.WriteLine($"Яскравість встановлена на рівні {Brightness}%.");
            }
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Бренд: {Brand}");
            Console.WriteLine($"Модель: {Model}");
            Console.WriteLine($"Діагональ екрану: {ScreenSize}\"");
            Console.WriteLine($"Роздільна здатність: {Resolution}");
            Console.WriteLine($"Smart TV: {(IsSmartTV ? "Так" : "Ні")}");
            Console.WriteLine($"Потужність звуку: {SoundPower} Вт");
            Console.WriteLine($"Стан: {(IsOn ? "Увімкнено" : "Вимкнено")}");
            Console.WriteLine($"Яскравість: {Brightness}");
        }
    }
}
