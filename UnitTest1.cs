using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Teoria
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void DuplicateWords()
        {

            string word = "Around the world world";
            int l;

            word = word.ToLower();

            string[] lyrics = word.Split(' ');

            for (int i = 0; i < lyrics.Length; i++)
            {
                l = 1;



                for (int j = i + 1; j < lyrics.Length; j++)
                {
                    if (lyrics[i].Equals(lyrics[j]))
                    {
                        bool ln = true;
                        l++;

                        lyrics[j] = "0";
                        if (l > 1 && lyrics[i] != "0")
                            
                        Assert.IsTrue(ln);



                    }
                }

            }


        }


        [TestMethod]
        public void NoDuplicateWords()
        {

            string word = "Please dont stop the music";
            int l;

            word = word.ToLower();

            string[] lyrics = word.Split(' ');

            for (int i = 0; i < lyrics.Length; i++)
            {
                l = 1;



                for (int j = i + 1; j < lyrics.Length; j++)
                {
                    if (lyrics[i].Equals(lyrics[j]))
                    {
                        bool ln = true;
                        l++;

                        lyrics[j] = "0";


                        bool nl = bool.Parse(lyrics[j]);
                        Assert.IsFalse(nl);

                    }
                }

            }


        }

    }
}
