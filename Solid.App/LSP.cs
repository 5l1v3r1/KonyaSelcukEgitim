namespace Solid.App.LSP
{
    public interface ITakePhoto
    {
          void TakePhoto();


    }

    public abstract class Phone
    {
        public virtual void Call()
        {
            Console.WriteLine("Arama yapıldı.");
        }
        //public abstract void TakePhoto();
    }


    public class Nokia3310 : Phone
    {
        public override void Call()
        {
            Console.WriteLine("Arama yapıldı.(Nokia)");
        }

       
    }

    public class IPhone15 : Phone,ITakePhoto
    {
        public override void Call()
        {
            Console.WriteLine("Arama yapıldı.(IPhone)");
        }

        public  void TakePhoto()
        {
            Console.WriteLine("Fotograf çekildi.(IPhone)");
        }
    }

    
}
