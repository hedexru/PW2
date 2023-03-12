using System.Globalization;

namespace PW2_task3
{
    internal class Program
    {
        class TaskSolution
        {
            static int j = 0;
            private static string valueEdit (string text, int k)
            {
                var Alfabet = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
                var letterQty = Alfabet.Length;
                var valueSetted ="";
                
                for (int i = 0; i < text.Length; i++)
                { 
                    var c = text[i];
                    var index = Alfabet.IndexOf(c);
                    var codeIndex = (letterQty + index + k) % letterQty;
                    valueSetted += Alfabet[codeIndex];
                }
                if (j == 0)
                {
                    Console.WriteLine($"Зашифрованное сообщение: {valueSetted}");
                    j = 1;
                }
                return valueSetted;
            }
            public static string Encrypt(string plainMessage, int key)
            {
                valueEdit(plainMessage, key);
                return plainMessage;
            }
            public static string Decrypt(string encryptedMessage, int key)
                => valueEdit(encryptedMessage, -key);
        }
        static void Main(string[] args)
        {
            TaskSolution taskSolution = new TaskSolution();

            Console.WriteLine("Введите текст для шифра (заглавные буквы):");
            string gettedValue = Console.ReadLine();
            Console.Write("Введите ключ: ");
            var secretKey = Convert.ToInt32(Console.ReadLine());
            var encryptedText = TaskSolution.Encrypt(gettedValue, secretKey);
            Console.WriteLine("Расшифрованное сообщение: {0}", TaskSolution.Decrypt(encryptedText, secretKey));

        }
    }
}