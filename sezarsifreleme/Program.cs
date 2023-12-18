using System;

namespace sezarsifreleme
{
    internal class Program
    {
        public static char[] alfabelower = { 'a','b','c','ç', 'd','e','f', 'g', 'ğ', 'h', 'ı', 'i', 'j', 'k', 'l', 'm', 'n',
              'o', 'ö', 'p', 'r', 's', 'ş', 't', 'u', 'ü', 'v', 'y', 'z'};
        public static char[] alfabeupper = { 'A','B','C','Ç', 'D','E','F', 'G', 'Ğ', 'H', 'I', 'İ', 'J', 'K', 'L', 'M', 'N',
              'O', 'Ö', 'P', 'R', 'S', 'Ş', 'T', 'U', 'Ü', 'V', 'Y', 'Z'};
        public static char[] numbers = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        static void Main(string[] args)
        {
            Console.Title = "Sezar Şifreleme-Çözme";
            Console.WriteLine("Merhaba Sezar Şifreleme Programına Hoşgeldiniz");
        baslangic:
            Console.WriteLine("Lütfen Hangi işlemi yapacağınızı Seçiniz: \n 1-Şifrelemek \n 2-Çözmek");
            String veri = Console.ReadLine();
            Console.WriteLine();
            if (veri == "1")
            {
                Console.WriteLine("Sezar Şifreleme şıkkını seçtiniz.\nŞimdi bize şifrelememiz gereken metini girermisin:");
                String metin = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("Şifrelemek istediğiniz metin: " + metin + "\n\nŞifrelenen Metin: " + encrypt(metin));
                Console.WriteLine();
            }
            else if (veri == "2")
            {
                Console.WriteLine("Sezar Şifre Çözme şıkkını seçtiniz.\nŞimdi bize çözmemiz gereken metini girermisin:");
                String metin = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("Çözmek istediğiniz metin: " + metin + "\n\nÇözülen Metin: " + decrypt(metin));
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Lütfen 1 veya 2 şeklinde seçim yapınız\n");
                goto baslangic;
            }
            Console.WriteLine("Şifreleme İşlemi tamamlandı.\nYeni bir şifreleme yapmak istiyorsan evet yazarak baştan başlatabilirsin\n(evet dışında herhangi bir şey yazarsan program kapanacaktır).");
            String islem = Console.ReadLine();
            Console.WriteLine();
            if (islem == "evet")
            {
                goto baslangic;
            }
            else
            {
                Environment.Exit(0);
            }
        }
        public static String crypt(string text, int key)
        {
            String sifreliyazi = "";
            foreach (char c in text)
            {
                for (int i = 0; i < 29; i++)
                {
                    if (c == alfabelower[i])
                    {
                        sifreliyazi += alfabelower[(i + key) % 29];
                    }
                    else if (c == alfabeupper[i])
                    {
                        sifreliyazi += alfabeupper[(i + key) % 29];
                    }
                }
            }
            return sifreliyazi;
        }
        public static String encrypt(string text) { return crypt(text, 3); }
        public static String decrypt(string text) { return crypt(text, 26); }
    }
}
