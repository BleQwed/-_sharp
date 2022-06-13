using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Model
{
    public class MediaPlayer : Player
    {
        public int ConnectionQuality { get; set; }

        public int NumberOfDifferentConnectionTypes { get; set; }

        public override string ToString() => "Цена: " + Price.ToString() + ", Цвет: " + Color + ", Модель: " + Model + ", Объём памяти: " + Memory.ToString() +
            ", Качество соединения: " + ConnectionQuality.ToString() + ", Количество различных типов подключения: " + NumberOfDifferentConnectionTypes.ToString();

        public override string AskInformationFromConsultant() => "Полная информация о товаре — " + ToString() +
            "\nЕсли вы хотите, то можете ознакомиться с качеством соединения, можем проверить плеер на каком-либо телевизоре.";

        public string TryConnect()
        {
            Random random = new Random();
            return (random.Next(0, 200) < 52) ? "Во время подключения произошла ошибка." : "Вы успешно подключили плеер.";
        }
    }
}
