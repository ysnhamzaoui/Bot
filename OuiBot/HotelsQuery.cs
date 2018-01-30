using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OuiBot
{
    using System;
    using Microsoft.Bot.Builder.FormFlow;

    [Serializable]
    public class HotelsQuery
    {
        [Prompt("Vous cherchez un hotêl dans quelle {&}")]
        public string Ville { get; set; }

        [Prompt("Pour quelle date {&}?")]
        public DateTime Date { get; set; }

        [Numeric(1, int.MaxValue)]
        [Prompt("Pour combien de {&}?")]
        public int Nuits { get; set; }

        [Prompt("Quel est votre {&} par nuit ?")]
        public int Budget { get; set; }

        [Numeric(1, 5)]
        [Prompt("Pour combien de {&}?")]
        public int Classement { get; set; }
    }
}