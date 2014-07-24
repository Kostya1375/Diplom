using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplom
{
    public class Logic
    {
        string answer;
        int[] microclimat_parametrs = new int[4];

        public void SetAnswer(string a)
        {
            answer = a;
        }

        public string SetTextLabel()
        {
            if (microclimat_parametrs[0] == 2 & microclimat_parametrs[1] == 2 & microclimat_parametrs[2] == 2 & microclimat_parametrs[3] == 1)
            {
                answer = "Опасно";
            }
            if (microclimat_parametrs[0] == 2 & microclimat_parametrs[1] == 2 & microclimat_parametrs[2] == 2 & microclimat_parametrs[3] == 0)
            {
                answer = "Не опасно";
            }
            return answer;
        }

        public void SetAllParametrsMicro(int i, int param)
        {
            microclimat_parametrs[i] = param;
        }
    }
}
