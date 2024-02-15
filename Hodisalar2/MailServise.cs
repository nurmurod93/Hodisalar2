namespace Hodisalar2
{
    public class MailServise
    {
        public void FileShifrlanadiganPochtaUchun(object sourse, FileniShifirlaEventArgs args)
        {
            Console.WriteLine("MailServise: Pochta jo'natilyabdi - " + args.File.Hajmi);
        }
    }
}