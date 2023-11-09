using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTO.Chill
{
    public class DailyTaskDTO
    {
        public string Activity { get; set; }
        public string Type { get; set; }
        public int Participants { get; set; }
        public int Price { get; set; }
        public string Link { get; set; }
        public string Key { get; set; }
        public double Accessibility { get; set; }
    }
}
