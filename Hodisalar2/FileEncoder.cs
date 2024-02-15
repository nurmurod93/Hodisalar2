namespace Hodisalar2
{
     public class FileniShifirlaEventArgs : EventArgs
    {
        public File File { get; set; }
    }

    public class FileEncoder
    {
        public event EventHandler<FileniShifirlaEventArgs> FileniOgir;
    
        public void Shifirla(File file) 
        {
            Console.WriteLine("Fileni bayt formatga o'girdi.");
            Thread.Sleep(4000);

            BaytgaOgiribShifirlanganda(file);
        }

        protected virtual void BaytgaOgiribShifirlanganda(File file)
        {
            if(file != null) 
            {
                FileniOgir(this, new FileniShifirlaEventArgs() { File = file });
            }
        }
    }

}