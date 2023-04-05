using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR2
{
    internal class ClsMarsh
    {
        private string startA;
        private string endB;
        private string number;
        // свойства для доступа к полям
        public string StartA
        {
            get { return startA; }//возвращает значение поля
            set { startA = value; } //устанавливает значение поля
        }
        public string EndB
        {
            get { return endB; }
            set { endB = value; }
        }
        public string Number
        {
            get { return number; }
            set { number = value; }
        }

        //методы 
        //конструктор без параметров задает значения полей по умолчанию
        public ClsMarsh()
        {
            startA = "";
            endB = "";
            endB = "";
        }
        //конструктор с параметрами
        public ClsMarsh(string A, string n, string B)
        {
            startA = A;
            endB = B;
            endB = n;
        }
        //метод вывода на экран
        public string PrintToScreen()
        {
            string line = $"Маршрут начинается: {startA} маршрут заканчивается: {endB}" + "\n";
            line += $"Номер маршрута: {number}" + "\n";

            return line;
        }
        public void SaveToFile(string filename)
        {
            StreamWriter streamWriter = new StreamWriter(filename, true, Encoding.Default);
            streamWriter.WriteLine("Маршрут");
            streamWriter.WriteLine($"Начало маршрута: {startA}");
            streamWriter.WriteLine($"Конец маршрута: {endB.ToString()}");
            streamWriter.WriteLine($"Номер маршрута: {number.ToString()}");
            streamWriter.Close();
        }
    }
}
