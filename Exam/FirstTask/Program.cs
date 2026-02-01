using System.Globalization;

namespace FirstTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Enter a number within 1 and 100: ");
            //var son = int.Parse(Console.ReadLine()!);
            //var result = ConvertNumberToStringName(son);
            //Console.WriteLine(result);

            Console.Write("Enter a number within 1 and 100: ");
            Console.WriteLine(ConvertNumberToStringName(int.Parse(Console.ReadLine()!)));
        }

        public static string ConvertNumberToStringName(int number)
        {
            var son = number;

            string[] digits = ["bir", "ikki", "uch", "tort", "besh", "olti", "etti", "sakkiz", "to'qiz"];
            string[] onlik = ["o'n", "yigirma", "o'tiz", "qirq", "ellik", "oltmush", "etmush", "sakson", "to'qson"];

            var result = string.Empty;
            if (son < 10)
                result = digits[son - 1];
            else if (son > 10 && son < 100)
            {
                var sonStr = son.ToString();
                var firstDiggit = sonStr[0].ToString();
                var secondDiggit = sonStr[1].ToString();

                var first = onlik[int.Parse(firstDiggit) - 1];
                var second = digits[int.Parse(secondDiggit) - 1];
                string emptySpace = " ";
                result = first + emptySpace + second;
            }
            else
                return "Wrong number";

            return result;
        }

        public static void PrintHello()
        {
            // 1 Savol
            Console.WriteLine("Son kiriting: ");
            var number = int.Parse(Console.ReadLine());
            switch (number)
            {
                case 1:
                    Console.WriteLine("bir");
                    break;
                case 2:
                    Console.WriteLine("ikki");
                    break;
                case 3:
                    Console.WriteLine("uch");
                    break;
                case 4:
                    Console.WriteLine("tort");
                    break;
                case 5:
                    Console.WriteLine("besh");
                    break;
                case 6:
                    Console.WriteLine("olti");
                    break;
                case 7:
                    Console.WriteLine("yetti");
                    break;
                case 8:
                    Console.WriteLine("sakkis");
                    break;
                case 9:
                    Console.WriteLine("toqis");
                    break;
                case 10:
                    Console.WriteLine("o'n");
                    break;
                case 11:
                    Console.WriteLine("o'n bir");
                    break;
                case 12:
                    Console.WriteLine("o'n bir");
                    break;
                case 13:
                    Console.WriteLine("o'n uch");
                    break;
                case 14:
                    Console.WriteLine("o'n tort");
                    break;
                case 15:
                    Console.WriteLine("o'n besh");
                    break;
                case 16:
                    Console.WriteLine("o'n olti");
                    break;
                case 17:
                    Console.WriteLine("o'n yetti");
                    break;
                case 18:
                    Console.WriteLine("o'n sakkiz");
                    break;
                case 19:
                    Console.WriteLine("o'n to'qqiz");
                    break;
                case 20:
                    Console.WriteLine("yigirma");
                    break;
                case 21:
                    Console.WriteLine("yigirma bir");
                    break;
                case 22:
                    Console.WriteLine("yigirma ikki");
                    break;
                case 23:
                    Console.WriteLine("yigirma uch");
                    break;
                case 24:
                    Console.WriteLine("yigirma to'rt");
                    break;
                case 25:
                    Console.WriteLine("yigirma besh");
                    break;
                case 26:
                    Console.WriteLine("yigirma olti");
                    break;
                case 27:
                    Console.WriteLine("yigirma yetti");
                    break;
                case 28:
                    Console.WriteLine("yigirma sakkiz");
                    break;
                case 29:
                    Console.WriteLine("yigirma to'qqiz");
                    break;
                case 30:
                    Console.WriteLine("o'ttiz");
                    break;
                case 31:
                    Console.WriteLine("o'ttiz bir");
                    break;
                case 32:
                    Console.WriteLine("o'ttiz ikki");
                    break;
                case 33:
                    Console.WriteLine("o'ttiz uch");
                    break;
                case 34:
                    Console.WriteLine("o'ttiz to'rt");
                    break;
                case 35:
                    Console.WriteLine("o'ttiz besh");
                    break;
                case 36:
                    Console.WriteLine("o'ttiz olti");
                    break;
                case 37:
                    Console.WriteLine("o'ttiz yetti");
                    break;
                case 38:
                    Console.WriteLine("o'ttiz sakkiz");
                    break;
                case 39:
                    Console.WriteLine("o'ttiz to'qqiz");
                    break;
                case 40:
                    Console.WriteLine("qirq");
                    break;
                case 41:
                    Console.WriteLine("qirq bir");
                    break;
                case 42:
                    Console.WriteLine("qirq ikki");
                    break;
                case 43:
                    Console.WriteLine("qirq uch");
                    break;
                case 44:
                    Console.WriteLine("qirq to'rt");
                    break;
                case 45:
                    Console.WriteLine("qirq besh");
                    break;
                case 46:
                    Console.WriteLine("qirq olti");
                    break;
                case 47:
                    Console.WriteLine("qirq yetti");
                    break;
                case 48:
                    Console.WriteLine("qirq sakkiz");
                    break;
                case 49:
                    Console.WriteLine("qirq to'qqiz");
                    break;
                case 50:
                    Console.WriteLine("ellik");
                    break;
                case 51:
                    Console.WriteLine("ellik bir");
                    break;
                case 52:
                    Console.WriteLine("ellik ikki");
                    break;
                case 53:
                    Console.WriteLine("ellik uch");
                    break;
                case 54:
                    Console.WriteLine("ellik to'rt");
                    break;
                case 55:
                    Console.WriteLine("ellik besh");
                    break;
                case 56:
                    Console.WriteLine("ellik olti");
                    break;
                case 57:
                    Console.WriteLine("ellik yetti");
                    break;
                case 58:
                    Console.WriteLine("ellik sakkiz");
                    break;
                case 59:
                    Console.WriteLine("ellik to'qqiz");
                    break;
                case 60:
                    Console.WriteLine("oltmish");
                    break;
                case 61:
                    Console.WriteLine("oltmish bir");
                    break;
                case 62:
                    Console.WriteLine("oltmish ikki");
                    break;
                case 63:
                    Console.WriteLine("oltmish uch");
                    break;
                case 64:
                    Console.WriteLine("oltmish to'rt");
                    break;
                case 65:
                    Console.WriteLine("oltmish besh");
                    break;
                case 66:
                    Console.WriteLine("oltmish olti");
                    break;
                case 67:
                    Console.WriteLine("oltmish yetti");
                    break;
                case 68:
                    Console.WriteLine("oltmish sakkiz");
                    break;
                case 69:
                    Console.WriteLine("oltmish to'qqiz");
                    break;
                case 70:
                    Console.WriteLine("yetmish");
                    break;
                case 71:
                    Console.WriteLine("yetmish bir");
                    break;
                case 72:
                    Console.WriteLine("yetmish ikki");
                    break;
                case 73:
                    Console.WriteLine("yetmish uch");
                    break;
                case 74:
                    Console.WriteLine("yetmish to'rt");
                    break;
                case 75:
                    Console.WriteLine("yetmish besh");
                    break;
                case 76:
                    Console.WriteLine("yetmish olti");
                    break;
                case 77:
                    Console.WriteLine("yetmish yetti");
                    break;
                case 78:
                    Console.WriteLine("yetmish sakkiz");
                    break;
                case 79:
                    Console.WriteLine("yetmish to'qqiz");
                    break;
                case 80:
                    Console.WriteLine("sakson");
                    break;
                case 81:
                    Console.WriteLine("sakson bir");
                    break;
                case 82:
                    Console.WriteLine("sakson ikki");
                    break;
                case 83:
                    Console.WriteLine("sakson uch");
                    break;
                case 84:
                    Console.WriteLine("sakson to'rt");
                    break;
                case 85:
                    Console.WriteLine("sakson besh");
                    break;
                case 86:
                    Console.WriteLine("sakson olti");
                    break;
                case 87:
                    Console.WriteLine("sakson yetti");
                    break;
                case 88:
                    Console.WriteLine("sakson sakkiz");
                    break;
                case 89:
                    Console.WriteLine("sakson to'qqiz");
                    break;
                case 90:
                    Console.WriteLine("to'qson");
                    break;
                case 91:
                    Console.WriteLine("to'qson bir");
                    break;
                case 92:
                    Console.WriteLine("to'qson ikki");
                    break;
                case 93:
                    Console.WriteLine("to'qson uch");
                    break;
                case 94:
                    Console.WriteLine("to'qson to'rt");
                    break;
                case 95:
                    Console.WriteLine("to'qson besh");
                    break;
                case 96:
                    Console.WriteLine("to'qson olti");
                    break;
                case 97:
                    Console.WriteLine("to'qson yetti");
                    break;
                case 98:
                    Console.WriteLine("to'qson sakkiz");
                    break;
                case 99:
                    Console.WriteLine("to'qson to'qqiz");
                    break;
                default:
                    Console.WriteLine("Faqat 1-99 oralig'ida kiriting");
                    break;
            }
        }
    }
}
