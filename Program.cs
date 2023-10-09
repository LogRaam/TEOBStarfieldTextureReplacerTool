// Code written by Gabriel Mailhot, 05/10/2023.

namespace TEOBStarfieldTextureReplacer
{
   internal static class Program
   {
      #region private

      /// <summary>
      ///   The main entry point for the application.
      /// </summary>
      [STAThread]
      private static void Main()
      {
         // To customize application configuration such as set high DPI settings or default font,
         // see https://aka.ms/applicationconfiguration.
         ApplicationConfiguration.Initialize();
         Application.Run(new MainForm());
         //Application.Run(new TextureSelection());
      }

      #endregion
   }
}