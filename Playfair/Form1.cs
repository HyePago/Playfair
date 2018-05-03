using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Playfair
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        // 암호화 Button 클릭 시 호출
        private void Encryption_Click(object sender, EventArgs e)
        {
            if (Message.Text.Equals(""))
            {
                MessageBox.Show("평문을 입력하여주세요.");
                return;
            } else if (keyText.Text.Equals(""))
            {
                MessageBox.Show("암호키를 입력하여주세요.");
                return;
            }

            PlayfairEngine engine = new PlayfairEngine();
            char[,] cipherPlate = new char[5, 5]; // 암호판 생성
            int k = 0; // 암호판에 알파벳을 넣을 때 사용할 변수

            string key = keyText.Text.ToLower() ; // 입력받은 암호키를 소문자로 변환하여서 저장

            engine.Create_CipherPlate(key, ref cipherPlate);

            char[,] arr_plain = new char[Message.TextLength, 2]; // 평뮨을 2글자씩 짤라서 넣어줄 배열
            string plainText = Message.Text.ToLower();
            int n = 0, m = 0;

            for (int i = 0; i < Message.TextLength; i++)
            {
                if (plainText[i].Equals(' ')) continue; // 공백은 넘어감.
                if(i == Message.TextLength-1 && m == 0) // 홀수로 끝나서 한 문자만 남았을 경우
                {
                    arr_plain[n, m] = plainText[i];
                    arr_plain[n, 1] = 'x'; // 마지막 공간을 'x'로 채워줌
                    n++;
                    break;
                }
                if (m == 0) // 2글자씩 들어가는 곳에서 첫번째 공간에 넣을 때
                {
                    arr_plain[n, m] = plainText[i];
                    m = 1;
                    continue;
                }

                if (arr_plain[n, 0].Equals(plainText[i])) // 2글자 씩 들어가는 데 순서대로 들어가면 똑같은 문자가 들어가게 될 경우
                {
                    i--; // 이 문자가 안들어가니까 다음 순서에 이 문자를 넣어주기 위하여
                    arr_plain[n, m] = 'x'; // 'x' 입력
                    n++;
                    m = 0;
                    continue;
                }

                arr_plain[n, m] = plainText[i]; // 위 조건에 속하지 않을 경우
                m = 0;
                n++;
            }

            char[ , ] chipher_text = new char[n, 2]; // 암호화를 한 문장을 넣을 공간
            int x1 = 0, x2 = 0, y1 = 0, y2 = 0;

            for (int i = 0; i < n; i++) 
            {
                for(int j=0; j < 5; j++)
                {
                    for(k=0; k<5; k++)
                    {
                        if (cipherPlate[j, k].Equals(arr_plain[i, 0])) // 두 글자 중 첫 문자의 위치를 찾는 조건
                        {
                            x1 = j;
                            y1 = k;
                        }
                        else if(cipherPlate[j, k].Equals(arr_plain[i, 1])) // 두 글자 중 두번째 문자의 위치를 찾는 조건
                        {
                            x2 = j;
                            y2 = k;
                        }
                    }
                }

                if(y1 == y2) // 같은 열에있으면
                {
                    chipher_text[i, 0] = cipherPlate[x1 + 1, y1];
                    chipher_text[i, 1] = cipherPlate[x2 + 1, y2];
                    continue;
                } else if(x1 == x2) // 같은 행에 있으면
                {
                    chipher_text[i, 0] = cipherPlate[x1, y1 + 1];
                    chipher_text[i, 1] = cipherPlate[x2, y2 + 1];
                    continue;
                }

                // 둘 다 아니면
                chipher_text[i, 0] = cipherPlate[x2, y1];
                chipher_text[i, 1] = cipherPlate[x1, y2];
            }

            string result = "";

            for(int i=0; i<n; i++)
            {
                result += chipher_text[i, 0];
                result += chipher_text[i, 1];
            }

            ChipherText.Text = result; // 암호문 출력
        }

        private void Decryption_Click(object sender, EventArgs e)
        {
            if (DecryptionText.Text.Equals(""))
            {
                MessageBox.Show("복호문을 입력하여주세요.");
                return;
            }
            else if (keyText.Text.Equals(""))
            {
                MessageBox.Show("암호키를 입력하여주세요.");
                return;
            }

            PlayfairEngine engine = new PlayfairEngine();
            char[,] cipherPlate = new char[5, 5]; // 암호판 생성
            int k = 0; // 암호판에 알파벳을 넣을 때 사용할 변수

            string key = keyText.Text.ToLower(); // 입력받은 암호키를 소문자로 변환하여서 저장

            engine.Create_CipherPlate(key, ref cipherPlate);

            char[,] arr_decryption = new char[DecryptionText.TextLength, 2]; // 복호문을 2글자 씩 잘라서 넣어줄 배열
            string decryptionText = DecryptionText.Text;
            int n = 0, m = 0;

            for (int i = 0; i < DecryptionText.TextLength; i++)
            {
                if (decryptionText[i].Equals(' ')) continue; // 공백은 넘어감.
                if (i == DecryptionText.TextLength - 1 && m == 0) // 홀수로 끝나서 한 문자만 남았을 경우
                {
                    arr_decryption[n, m] = decryptionText[i];
                    arr_decryption[n, 1] = 'x'; // 마지막 공간을 'x'로 채워줌
                    n++;
                    break;
                }
                if (m == 0) // 2글자씩 들어가는 곳에서 첫번째 공간에 넣을 때
                {
                    arr_decryption[n, m] = decryptionText[i];
                    m = 1;
                    continue;
                }

                if (arr_decryption[n, 0].Equals(decryptionText[i])) // 2글자 씩 들어가는 데 순서대로 들어가면 똑같은 문자가 들어가게 될 경우
                {
                    i--; // 이 문자가 안들어가니까 다음 순서에 이 문자를 넣어주기 위하여
                    arr_decryption[n, m] = 'x'; // 'x' 입력
                    n++;
                    m = 0;
                    continue;
                }

                arr_decryption[n, m] = decryptionText[i]; // 위 조건에 속하지 않을 경우
                m = 0;
                n++;
            }

            char[,] plain_text = new char[n, 2]; // 암호화를 한 문장을 넣을 공간
            int x1 = 0, x2 = 0, y1 = 0, y2 = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    for (k = 0; k < 5; k++)
                    {
                        if (cipherPlate[j, k].Equals(arr_decryption[i, 0])) // 두 글자 중 첫 문자의 위치를 찾는 조건
                        {
                            x1 = j;
                            y1 = k;
                        }
                        else if (cipherPlate[j, k].Equals(arr_decryption[i, 1])) // 두 글자 중 두번째 문자의 위치를 찾는 조건
                        {
                            x2 = j;
                            y2 = k;
                        }
                    }
                }

                if (y1 == y2) // 같은 열에있으면
                {
                    plain_text[i, 0] = cipherPlate[x1 - 1, y1];
                    plain_text[i, 1] = cipherPlate[x2 - 1, y2];
                    continue;
                }
                else if (x1 == x2) // 같은 행에 있으면
                {
                    plain_text[i, 0] = cipherPlate[x1, y1 - 1];
                    plain_text[i, 1] = cipherPlate[x2, y2 - 1];
                    continue;
                }

                // 둘 다 아니면
                plain_text[i, 0] = cipherPlate[x2, y1];
                plain_text[i, 1] = cipherPlate[x1, y2];
            }

            string result = "";

            for (int i = 0; i < n; i++)
            {
                result += plain_text[i, 0];
                result += plain_text[i, 1];
            }

            Message.Text = result; // 암호문 출력
        }
    }
}
