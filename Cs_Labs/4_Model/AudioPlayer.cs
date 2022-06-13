using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Model
{
    public class AudioPlayer : Player
    {
        public int AudioQuality { get; set; }

        public int NumberOfAdditionalHeadset { get; set; }

        public override string ToString() => "Цена: " + Price.ToString() + ", Цвет: " + Color + ", Модель: " + Model + ", Объём памяти: " + Memory.ToString() +
            ", Качество аудио: " + AudioQuality.ToString() + ", Количество дополнительной гарнитуры в комплекте: " + NumberOfAdditionalHeadset.ToString();

        public override string AskInformationFromConsultant() => "Полная информация о товаре — " + ToString() +
            "\nЕсли вы хотите, то можете ознакомиться с качеством звука, за дополнительной информацией обращайтесь ко мне, я выдам соответствующий буклет.";

        public string TryListeningMusic()
        {
            Random random = new Random();
            return (random.Next(0, 200) < 52) ? "Во время прослушивания музыки произошла какая-то ошибка." : "Вы успешно послушали музыку.";
        }

        public double FindOutTheValueForMoneyRatio(int timeWithoutCharging) => (AudioQuality * timeWithoutCharging * Memory / (Price != 0 ? Price : 1)) + NumberOfAdditionalHeadset * 0.05;
    }
}
