using System.Media;
using System.IO;
using System.Windows.Forms;

namespace TVScreenDisplay
{
    /// <summary>
    /// Handles the methods for calling out the queue number
    /// in Bahasa Indonesia through playing .wav files.
    /// </summary>
    class CallClass
    {
        public bool isInitialised;

        /// <summary>
        /// Default constructor.
        /// </summary>
        public CallClass()
        {
            isInitialised = true;
        }

        /// <summary>
        /// Converts a number to its verbal representation (e.g. 1 to "one"),
        /// but in Bahasa Indonesia instead of English (so 1 to "satu").
        /// </summary>
        /// <param name="number">The queue number from the form.</param>
        /// <returns>The queue number's verbal representation as a string.</returns>
        public string StringConvert(int number)
        {
            string[] indoValues = { "", "satu", "dua", "tiga", "empat", "lima", "enam", "tujuh", "delapan", "sembilan", "sepuluh", "sebelas" };
            string blank = "";

            if (number < 12)
            {
                return (' ' + indoValues[number]);
            }
            else if (number < 20)
            {
                return (this.StringConvert(number - 10) + " belas");
            }
            else if (number < 100)
            {
                if (number % 10 == 0)
                {
                    return this.StringConvert((int)number / 10) + " puluh";
                }
                else
                {
                    return this.StringConvert((int)number / 10) + " puluh" + this.StringConvert(number % 10);
                }
            }
            else if (number < 200)
            {
                if (number == 100)
                {
                    return " seratus";
                }
                else
                {
                    return " seratus" + this.StringConvert(number - 100);
                }
            }
            else if (number < 1000)
            {
                if (number % 100 == 0)
                {
                    return (this.StringConvert((int)number / 100) + " ratus");
                }
                else
                {
                    return (this.StringConvert((int)number / 100) + " ratus") + this.StringConvert(number % 100);
                }
            }
            else
            {
                return blank.Trim();
            }
        }

        /// <summary>
        /// Plays the first/introductory portion of the queue call.
        /// English translation: "Queue number..."
        /// </summary>
        public void CallIntro()
        {
            SoundPlayer playIntro = new SoundPlayer(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "sounds\\nomor-urut.wav"));
            playIntro.PlaySync();
        }

        /// <summary>
        /// Plays the queue number portion of the queue call.
        /// </summary>
        /// <param name="str">The queue number's verbal representation as a string.</param>
        public void CallQueue(string str)
        {
            string[] spaceNumbers;
            spaceNumbers = str.Split(' ');

            for (int i = 1; i < spaceNumbers.Length; i++)
            {
                SoundPlayer playQueue = new SoundPlayer(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "sounds\\" + spaceNumbers[i] + ".wav"));
                playQueue.PlaySync();
            }
        }

        /// <summary>
        /// Plays the middle portion of the queue call.
        /// English translation: "...to locket..."
        /// </summary>
        public void CallToCounter()
        {
            SoundPlayer playToCounter = new SoundPlayer(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "sounds\\loket.wav"));
            playToCounter.PlaySync();
        }

        /// <summary>
        /// Plays the last (CS counter number) portion of the queue call.
        /// </summary>
        /// <param name="num">The CS counter number.</param>
        public void CallCounterNumber(int num)
        {
            string[] counterNums = { "", "satu", "dua", "tiga", "empat", "lima" };

            SoundPlayer playCounterNumber = new SoundPlayer(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "sounds\\" + counterNums[num] + ".wav"));
            playCounterNumber.PlaySync();
        }
    }


}
