using System;
namespace BoHan_SOLID
{
    //This is for demonstrating Dependency Inversion Principle
    //Notification is loosely coupled, the Send method will behave based on the associated injection: Mail, Email or SMS
    public class Notification
    {
        private IMessage iMessage;
        public Notification(IMessage pMessage)
        {
            iMessage = pMessage;
        }

        public void Send() {
            iMessage.SendNotificationMessage();
        }
    }

    public interface IMessage {
        void SendNotificationMessage();
    }

    public class Mail: IMessage { 
        public void SendNotificationMessage() {
            Console.WriteLine("Mail Notification sent");
        }
    }

    public class Email: IMessage { 
        public void SendNotificationMessage() {
            Console.WriteLine("Email Notification sent");
        }
    }

    public class SMS: IMessage { 
        public void SendNotificationMessage() {
            Console.WriteLine("SMS Notification sent");
        }
    }
}
