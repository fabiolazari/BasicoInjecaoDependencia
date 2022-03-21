using System;

namespace BasicoInjecaoDependencia
{
    public class Program
    {
        static void Main(string[] args)
        {

        }
    }

    //The wrong way
    public class Notification_wrong
    {
        public void Send()
        {
            // TODO
        }
    }

    public class UserCommand_wrong
    {
        public void Handle()
        {
            var notification = new Notification_wrong();

            notification.Send();
        }
    }

    public class UserCommand_half_wrong
    {
        protected Notification_wrong _notification;

        public UserCommand_half_wrong(Notification_wrong notification)
        {
            _notification = notification;
        }

        public void Handle()
        {
            _notification.Send();
        }
    }


    //Now using in addition the Dep. Injection, the Dep. Invertion principle
    public interface INotification
    {
        public void Send();
    }

    public class Notification : INotification
    {
        public void Send()
        {
            // TODO
        }
    }

    public class HipChatNotification : INotification
    {
        public void Send()
        {
            // TODO
        }
    }

    public class SlackNotification : INotification
    {
        public void Send()
        {
            // TODO
        }
    }

    public class UserCommand
    {
        protected INotification _notification;

        public UserCommand(INotification notification)
        {
            _notification = notification;
        }

        public void Handle()
        {
            _notification.Send();
        }
    }
}
