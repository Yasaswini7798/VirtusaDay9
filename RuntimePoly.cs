using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtusaDay9
{
    class MusicPlayer
    {
        public virtual void play()
        {
            Console.WriteLine("song plays");
        }
        public virtual void stop()
        {
            Console.WriteLine("song stopped");
        }
    }
    class VLC : MusicPlayer
    {
        public override void play()
        {
            Console.WriteLine("VLC-->song plays");
        }
        public virtual void stop()
        {
            Console.WriteLine("VLC-->song stopped");
        }
    }
    class MediaPlayer : MusicPlayer
    {
        public override void play()
        {
            Console.WriteLine("MediaPlayer-->song plays");
        }
        public virtual void stop()
        {
            Console.WriteLine("MediaPLayer-->song stopped");
        }
    }
    class RuntimePoly
    {
        static void Main(string[] args)
        {
            MusicPlayer ob = new VLC();
            MusicPlayer ob1 = new MediaPlayer();
            ob.play();
            ob1.play();
            ob.stop();

        }
    }
}
