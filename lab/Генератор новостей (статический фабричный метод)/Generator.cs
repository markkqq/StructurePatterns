using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab
{
    public static class Generator
    {
        public static Note GenerateNote(string type, string content, string topic)
        {
            switch (type)
            {
                case "спорт":
                    return new SportNote(content, topic);
                case "политика":
                    return new PoliticsNote(content, topic);
                case "культура":
                    return new CultureNote(content, topic);
                default:
                    return new Note("без названия", "неизвестен");
            }
        }
    }
}
