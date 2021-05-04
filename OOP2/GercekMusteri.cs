using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{

    // interface imkanı olduğu müddetçe interface kullan. abstract classlarda inheritance kullan.

    class GercekMusteri :Musteri

    {
        //Individual
  
            public string TcNo { get; set; }
            public string Adi { get; set; }
            public string Soyadi { get; set; }
        
    }
}
