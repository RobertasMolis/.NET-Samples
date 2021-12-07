using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameApp
{
    public class NPC
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public int HitPoints { get; set; }

        public void Attack()
        {
            Console.WriteLine("You was attacked "+Name+"");
        }
    }
}
