using System;

namespace _2013_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            do
            {
                Console.WriteLine("Enter number of messages");
                n = int.Parse(Console.ReadLine());
            } while (n > 100);

            Message[] messages = new Message[n];
            InputData(messages);
            FirstSort(messages);
            OutputData(messages);
            SecondSort(messages);
            ThirdProblem(messages);
            ThirdSort(messages);
            FourthProblem(messages);


        }

        public static void InputData(Message[] messages)
        {
            for (int i = 0; i < messages.Length; i++)
            {

                Message message = new Message();

                Console.WriteLine("Enter title of the message");
                message.TitleOfMessage = Console.ReadLine();

                Console.WriteLine("Enter text of the message");
                message.TextOfMessage = Console.ReadLine();

                Console.WriteLine("Enter date added");
                message.DateAdded = Console.ReadLine();

                message.DateTimeAdded = DateTime.Parse(message.DateAdded);

                Console.WriteLine("Enter date of availability");
                message.DateAvailable = Console.ReadLine();

                message.DateTimeAvailable = DateTime.Parse(message.DateAvailable);

                Console.WriteLine("Enter date of cation activation");
                message.DateCautionActivated = Console.ReadLine();

                message.DateTimeCautionActivated = DateTime.Parse(message.DateCautionActivated);

                Console.WriteLine("Enter hour of caution activation");
                message.HourCautionActivated = Console.ReadLine();

                message.DateHourCautionActivated = DateTime.Parse(message.HourCautionActivated);

                Console.WriteLine("Enter purpose of message");
                message.MessagePurpose = Console.ReadLine();

                messages[i] = message;

            }
        }
        public static void FirstSort(Message[] messages)
        {
            for (int i = 0; i < messages.Length; i++)
            {
                for (int j = i + 1; j < messages.Length; j++)
                {
                    if (messages[i].TitleOfMessage.CompareTo(messages[j].TitleOfMessage) > 0)
                    {
                        Message temp = messages[i];
                        messages[i] = messages[j];
                        messages[j] = temp;
                    }
                }
            }
        }
        public static void OutputData(Message[] messages)
        {
            for (int i = 0; i < messages.Length; i++)
            {
                Console.WriteLine(messages[i].TitleOfMessage + "; "
                    + messages[i].TextOfMessage + "; "
                    + messages[i].DateAdded + "; "
                    + messages[i].DateAvailable);
            }
        }
        public static void SecondSort(Message[] messages)
        {
            for (int i = 0; i < messages.Length; i++)
            {
                for (int j = i + 1; j < messages.Length; j++)
                {
                    if (messages[i].HourCautionActivated.CompareTo(messages[j].HourCautionActivated) > 0)
                    {
                        Message temp = messages[i];
                        messages[i] = messages[j];
                        messages[j] = temp;
                    }
                }
            }
        }
        public static void ThirdProblem(Message[] messages)
        {

            Console.WriteLine("Enter date");
            string date1 = Console.ReadLine();
            DateTime dateTime = DateTime.Parse(date1);

            for (int i = 0; i < messages.Length; i++)
            {
                if (DateTime.Compare(messages[i].DateTimeCautionActivated, dateTime) == 0  && messages[i].MessagePurpose.Contains("лични"))
                {
                    Console.WriteLine(messages[i].TitleOfMessage + "; "
                    + messages[i].TextOfMessage + "; "
                    + messages[i].DateAdded + "; "
                    + messages[i].DateAvailable);
                }
            }
        }
        public static void ThirdSort(Message[] messages)
        {
            for (int i = 0; i < messages.Length; i++)
            {
                for (int j = i + 1; j < messages.Length; j++)
                {
                    if (messages[i].DateTimeAdded.CompareTo(messages[j].DateTimeAdded) > 0)
                    {
                        Message temp = messages[i];
                        messages[i] = messages[j];
                        messages[j] = temp;
                    }
                    else if (messages[i].DateTimeAdded.CompareTo(messages[j].DateTimeAdded) == 0)
                    {
                        if (messages[i].TitleOfMessage.CompareTo(messages[j].TitleOfMessage) > 0)
                        {
                            Message temp = messages[i];
                            messages[i] = messages[j];
                            messages[j] = temp;
                        }
                    }
                }
            }
        }
        public static void FourthProblem(Message[] messages)
        {
            Console.WriteLine("Enter a date to compare");
            string date = Console.ReadLine();
            DateTime dateTime = DateTime.Parse(date);

            for (int i = 0; i < messages.Length; i++)
            {
                if (messages[i].DateTimeAdded < dateTime)
                {
                    TimeSpan span = dateTime - messages[i].DateTimeAdded;
                    Console.WriteLine(messages[i].TitleOfMessage + "; "
                    + messages[i].TextOfMessage + "; "
                    + messages[i].DateAdded + "; "
                    + messages[i].DateAvailable);
                    Console.WriteLine("The difference is {0} days", span.Days);
                }
            }
        }

    }
}
