using System;

    namespace SOLANKYTUXUATHIEN
    {
        class Program
        {
            static void Main(string[] args)
            {
               Console.Write("Nhap vao chuoi: ");
            string message = Console.ReadLine();
            //Xóa khoảng trắng khỏi chuỗi
            message = message.Replace(" ", string.Empty);
            //sử dụng vòng lặp while và for để lặp và đếm số lần xuất hiện của ký tự
            while (message.Length > 0)
            {
                Console.Write(message[0] + " : ");
                int count = 0;
                for (int j = 0; j < message.Length; j++)
                {
                    if (message[0] == message[j])
                    {
                        count++;
                    }
                }
                Console.WriteLine(count);
                message = message.Replace(message[0].ToString(), string.Empty);
            }
            }
        }
    }
