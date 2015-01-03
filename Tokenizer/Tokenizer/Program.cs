using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tokenizer
{
    class Program
    {


        static void Main(string[] args)
        {
            string str = "az8158][gx-5][gy-5][gz-5][ax317][ay6][az8177][gx-5][gy-5][gz-5][ax311][ay9][az8190][gx-5][gy-5][gz-4][ax341][ay6][az8164][gx-4][gy-4][gz-5][ax342][ay4][az8170][gx-4][gy-5][gz-5][ax328][ay1][az8171][gx-4][gy-4][gz-4][ax327][ay1][az8207][gx-4][gy-4][gz-4][ax335][ay-9][az8195][gx-5][gy-4][gz-4][ax328][ay-9][az8165][gx-5][gy-4][gz-4][ax324][ay-20][az8167][gx-5][gy-5][gz-4][ax328][ay-12][az8171][gx-5][gy-5][gz-4][ax329][ay4][az8184][gx-5][gy-5][gz-4][ax339][ay11][az8179][gx-4][gy-5][gz-5][ax338][ay-13][az8";
            str = Tokenizer.trim(str);
            Console.WriteLine(str);
            List<string> test = Tokenizer.getTokens(str);
            for (int i = 0; i < test.Count; i++)
            {
                Console.WriteLine(test[i]);
            }

            test.Clear();
        }
    }
}
