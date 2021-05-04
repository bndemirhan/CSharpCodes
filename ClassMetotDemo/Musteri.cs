using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class Musteri
    {
        public int musteriId { get; set; }

        public string musteriAd { get; set; }
        public string musteriSoyad { get; set; }
        public long musteriTel { get; set; } //int veri tipi telefon numarası rakamları için yeterli gelmedi, bu sebeple daha büyük kapasiteye sahip olan long'u kullandık.
        public string musteriMail { get; set; }

    }
}
