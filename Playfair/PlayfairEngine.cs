using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playfair
{
    class PlayfairEngine
    {
        // Create 암호판 생성
        public void Create_CipherPlate(string key,ref char[ , ] cipherPlate)
        {
            int sw = 0; // Q랑 Z를 한 칸에 넣기 위해 Z일 때 넘기기 위해서 & 전에 넣었던 알파벳을 넣지 않기 위해서 조건을 걸기 위해 사용되는 변수
            int k = 0;

            for (int i = 0; i < key.Length; i++)
            {
                if (key[i].Equals(' ')) continue; // 공백이 있으면 그 문자는 넘기고 다음 문자를 입력받음.

                sw = 0;

                for (int j = 0; j < i; j++)
                {
                    // 이 문자가 암호판에 들어가 있는가, 지금 검사하는 것이 'z'인가
                    if (key[i].Equals(key[j]) || key[i].Equals('z'))
                    {
                        sw = 1;
                        break;
                    }
                }

                if (sw == 0) // 검사에서 안 걸린 친구들만 playfiar(암호판)에 넣어준다.
                {
                    cipherPlate[k / 5, k % 5] = key[i];
                    k++;
                }
            }

            for (char i = 'a'; i <= 'z'; i++) // 암호키 문자를 넣은 후 'a'부터 중복되지 않는 값을 넣어줌.
            {
                sw = 0;

                for (int j = 0; j < k; j++)
                {
                    if (cipherPlate[j / 5, j % 5].Equals(i) || i.Equals('z'))
                    {
                        sw = 1;
                        break;
                    }
                }

                if (sw == 0)
                {
                    cipherPlate[k / 5, k % 5] = i;
                    k++;
                }
            }
        }

        // 2글자씩 나누는 것

    }
}
