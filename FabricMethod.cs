using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricMethod
{
    class FabricMethod
    {
        static void Main(string[] args)
        {
            Messege mess = new SimpleMessege("Leo");
            Type tp = mess.Create();

            mess = new AudioMessege("Petr");
            Type tp1 = mess.Create();

            mess = new VideoMessege("Vlad");
            Type tp2 = mess.Create();

            Console.ReadLine();
        }
    }
    // абстрактный класс строительной компании
    abstract class Messege
    {
        public string Sender { get; set; }

        public Messege(string n)
        {
            Sender = n;
        }
        // фабричный метод
        abstract public Type Create();
    }
    // составоляем обычное сообщения
    class SimpleMessege: Messege
    {
        
        public SimpleMessege(string n) : base(n)
        { }

        public override Type Create()
        {
            return new SimpleType();
        }
    }
    // составоляем голосовое сообщения
    class AudioMessege : Messege
    {
        public AudioMessege(string n) : base(n)
        { }

        public override Type Create()
        {
            return new AudioType();
        }
    }
    // составоляем Втдео сообщения
    class VideoMessege : Messege
    {
        public VideoMessege(string n) : base(n)
        { }

        public override Type Create()
        {
            return new VideoType();
        }
    }

    abstract class Type
    { }

    class SimpleType : Type
    {
        public SimpleType()
        {
            Console.WriteLine("Type: SMS");
        }
    }
    class AudioType : Type
    {
        public AudioType()
        {
            Console.WriteLine("Type: Audio messege");
        }
    }
    class VideoType : Type
    {
        public VideoType()
        {
            Console.WriteLine("Type: Video messege");
        }
    }
}
