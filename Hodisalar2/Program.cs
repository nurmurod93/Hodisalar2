namespace Hodisalar2
{
    public class Program
    {
        public static void Main(string[] args) 
        {
            var file = new File()
            {
                Name = "Garri Potter",
                Formati = "Pdf",
                Hajmi = 14 
            };

            var fileEncoder = new FileEncoder();
            var mailServise = new MailServise();
            var messageServise = new MessageServise();

            fileEncoder.FileniOgir += mailServise.FileShifrlanadiganPochtaUchun;
            
            fileEncoder.FileniOgir += messageServise.FileShifirlanadiXabarUchun;

            fileEncoder.Shifirla(file);
        }
    }
}