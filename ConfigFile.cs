// Code written by Gabriel Mailhot, 05/10/2023.

namespace TEOBStarfieldTextureReplacer
{
   internal class ConfigFile
   {
      internal void CreateIniFile(DirectoryInfo starfieldDirectory)
      {
         if (!starfieldDirectory.Exists) throw new DirectoryNotFoundException("The folder " + starfieldDirectory.Name + " doesn't exist.  Ensure that the path entered in the text field in step 1 exists on your computer and matches the directory used by Starfield.");


         var fileName = "StarfieldCustom.ini";
         var fileIni = new FileInfo(Path.Combine(starfieldDirectory.FullName, fileName));

         if (fileIni.Exists)
         {
            MessageBox.Show(fileName + @" already exists.  It won't be overriden.");

            return;
         }

         var s = fileIni.CreateText();
         s.WriteLine("[Archive]");
         s.WriteLine("bInvalidateOlderFiles=1");
         s.WriteLine("sResourceDataDirsFinal=");
         s.Close();
         MessageBox.Show(fileName + @" created successfuly.");
      }
   }
}