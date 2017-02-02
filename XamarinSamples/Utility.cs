using System;
namespace XamarinSamples
{
    public class Utility
    {
        public Utility()
        {
        }

        /// <summary>
        /// ログ簡略化
        /// </summary>
        public static void Log<Type>(Type t)
        {
            System.Diagnostics.Debug.WriteLine(t);
        }
    }
}
