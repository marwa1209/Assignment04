using Assignment03.interfaces.question1;
using Assignment03.interfaces.question2;
using Assignment03.interfaces.question3;
using Assignment03.question2Classes;
using Assignment03.question3Classes;

namespace Assignment03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part1

            #region q1
            ///question 1=>What is the primary purpose of an interface in C#?
            ///b) To define a blueprint for a class
            #endregion

            #region q2
            ///question 2=>Which of the following is NOT a valid access modifier for interface members in C#?
            ///a) private
            #endregion

            #region q3
            ///question 3=>Can an interface contain fields in C#?
            ///b) No
            #endregion

            #region q4
            ///question 4=>In C#, can an interface inherit from another interface?
            ///b) Yes, interfaces can inherit from multiple interfaces
            #endregion

            #region q5
            ///question 5=>Which keyword is used to implement an interface in a class in C#?
            ///d) implements
            #endregion

            #region q6
            ///question 5=>Can an interface contain static methods in C#?
            ///a) Yes
            #endregion

            #region q7
            ///question 7=>In C#, can an interface have explicit access modifiers for its members?
            ///b) No, all members are implicitly public
            #endregion

            #region q8
            ///question 8=>What is the purpose of an explicit interface implementation in C#?
            ///b) To provide a clear separation between interface and class members
            #endregion

            #region q9
            ///question 9=>In C#, can an interface have a constructor?
            ///b) No, interfaces cannot have constructors
            #endregion

            #region q10
            ///question 10=>How can a C# class implement multiple interfaces?
            ///c) By separating interface names with commas
            #endregion

            #endregion

            #region Part2
            #region q1
            ///ICircle circle = new Circle(5);
            ///IRectangle rectangle = new Rectangle(4, 6);
            ///circle.DisplayShapeInfo();
            ///rectangle.DisplayShapeInfo();
            #endregion

            #region q2
            ///IAuthenticationService authService =new BasicAuthenticationService();
            ///Console.WriteLine(authService.AuthenticateUser("marwa", "123456"));
            ///authService.AuthorizeUser("Ahmed", "Customer");

            #endregion

            #region q3
            INotificationService emailService = new EmailNotificationService();
            INotificationService smsService = new SmsNotificationService();
            INotificationService pushService = new PushNotificationService();

            emailService.SendNotification("email@example.com", "Hello via Email!");
            smsService.SendNotification("01223875489", "Hello sms");
            pushService.SendNotification("marwa", "Hello  Push Notification");

            INotificationService notificationService = new SmsNotificationService();
            notificationService.SendNotification("987-654-3210", "Switched to SMS service!");
            #endregion
            #endregion
        }
    }
}
