using System;


namespace _03.Rot13_Cipher
{
    public class StartUp
    {
        public static void Main()
        {
            // TODO: Cipher the given string by ROT13 rules

            string message = "Test"; // EXPECTED : Grfg

            var charArr = message.ToCharArray();

            for (int i = 0; i < charArr.Length; i++)
            {
                var charNum = (int)charArr[i];
                if (charNum >= 'a' & charNum <= 'z')
                {
                    if (charNum > 'm') charNum -= 13;
                    else charNum += 13;
                }
                else if (charNum >= 'A' & charNum <= 'Z')
                {
                    if (charNum > 'M') charNum -= 13;
                    else charNum += 13;
                }
                charArr[i] = (char)charNum;
            }

            
            Console.WriteLine(new string(charArr));
            
        }
    }
}
