﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_model
{
    public class VideoPlayer : Player
    {
        public int PictureQuality { get; set; }

        public int GuaranteePeriod { get; set; }

        public override string ToString() => "Цена: " + Price.ToString() + ", Цвет: " + Color + ", Модель: " + Model + ", Объём памяти: " + Memory.ToString() +
            ", Качество изображения: " + PictureQuality.ToString() + ", Срок гарантии: " + GuaranteePeriod.ToString();

        public override string AskInformationFromConsultant()
        {
            return "Полная информация о товаре — " + ToString() + "\nЕсли вы хотите узнать более полную информацию, то я предоставлю вам ознакомительный документ о товаре.";
        }

        public string TryWatchVideo()
        {
            Random random = new Random();
            return (random.Next(0, 200) < 47) ? "Во время просмотра видео произошла ошибка." : "Вы успешно посмотрели видео.";
        }

        public string ChangeVolume() => "Громкость была изменена.";
    }
}
