namespace Hodisalar2
{
    public class MessageServise
    {
        public void FileShifirlanadiXabarUchun(object sourse, FileniShifirlaEventArgs args)
        {
            Console.WriteLine("MessageServise: Xabar jo'natyabdi - " + args.File.Hajmi);
        }
    }
}