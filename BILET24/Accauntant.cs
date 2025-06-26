using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    enum Post
    {
        Менеджер = 160,
        Разработчик = 180,
        Тестировщик = 170
    }

    class Accauntant
    {
        public bool AskForBonus(Post worker, int hours)
        {
            return hours > (int)worker;
        }
    }

}
