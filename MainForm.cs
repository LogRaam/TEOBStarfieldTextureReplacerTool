// Code written by Gabriel Mailhot, 05/10/2023.

#region

using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;

#endregion

namespace TEOBStarfieldTextureReplacer
{
   public partial class MainForm : Form
   {
      private readonly ConfigFile _configFile;
      private string _replacerTexture = string.Empty;
      private string _selectedBlueTexture = string.Empty;
      private string _selectedBrownDarkTexture = string.Empty;
      private string _selectedBrownTexture = string.Empty;
      private string _selectedCopperTexture = string.Empty;
      private string _selectedDeadTexture = string.Empty;
      private string _selectedGreenTexture = string.Empty;
      private string _selectedGreyTexture = string.Empty;
      private string _selectedHazelTexture = string.Empty;
      private string _selectedIronTexture = string.Empty;
      private string _selectedRedDevilTexture = string.Empty;
      private string _selectedRedTexture = string.Empty;
      private string _selectedSulfurTexture = string.Empty;
      private string _vanillaTexture = string.Empty;


      public MainForm()
      {
         InitializeComponent();
         _configFile = new ConfigFile();
      }

      #region private

      private void btnApply_Click(object sender, EventArgs e)
      {
         GenerateReplacerTextures();
         MessageBox.Show(@"All textures have been generated. You can close this tool. Have fun!");
      }

      private void btnCreateIniFile_Click(object sender, EventArgs e)
      {
         _configFile.CreateIniFile(new DirectoryInfo(txtTextureDirectory.Text));
      }

      private void FixScleraOpacity()
      {
         var source = RetrieveTextureFolder() + "\\" + "eye_sclera_opacity.dds";
         var gameDir = new DirectoryInfo(txtTextureDirectory.Text);
         var dest = new FileInfo(gameDir.FullName + "\\eye_sclera_opacity.dds");

         File.Copy(source, dest.FullName, true);
      }

      private void GenerateReplacerTextures()
      {
         FixScleraOpacity();
         GenerateTexture("iris_blue_color.dds", _selectedBlueTexture);
         GenerateTexture("iris_brown_color.dds", _selectedBrownTexture);
         GenerateTexture("iris_browndark_color.dds", _selectedBrownDarkTexture);
         GenerateTexture("iris_copper_color.dds", _selectedCopperTexture);
         GenerateTexture("iris_dead_color.dds", _selectedDeadTexture);
         GenerateTexture("iris_green_color.dds", _selectedGreenTexture);
         GenerateTexture("iris_grey_color.dds", _selectedGreyTexture);
         GenerateTexture("iris_hazel_color.dds", _selectedHazelTexture);
         GenerateTexture("iris_iron_color.dds", _selectedIronTexture);
         GenerateTexture("iris_reddevil_color.dds", _selectedRedDevilTexture);
         GenerateTexture("iris_red_color.dds", _selectedRedTexture);
         GenerateTexture("iris_sulfur_color.dds", _selectedSulfurTexture);
      }

      private void GenerateTexture(string originTextureName, string choosenTexture)
      {
         if (string.IsNullOrEmpty(choosenTexture)) choosenTexture = RetrieveTextureFolder() + "\\Vanilla\\" + originTextureName;

         var gameDir = new DirectoryInfo(txtTextureDirectory.Text);


         if (!gameDir.Exists)
         {
            MessageBox.Show(@"The fodler " + gameDir.Name + @" not found on this computer.  Please provide a valid path before applying for.");

            return;
         }


         var originTextureFile = new FileInfo(gameDir.FullName +"\\" + originTextureName);

         if (originTextureFile.Exists) originTextureFile.Delete();

         var selectedTexture = new FileInfo(choosenTexture.Replace(".jpg", ".dds"));
         File.Copy(selectedTexture.FullName, originTextureFile.FullName, true);
      }

      private void lblLink_Click(object sender, EventArgs e)
      {
         OpenUrl("https://www.nexusmods.com/starfield/mods/493?tab=description");
      }

      private void OpenUrl(string url)
      {
         try
         {
            Process.Start(url);
         }
         catch
         {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
               url = url.Replace("&", "^&");
               Process.Start(new ProcessStartInfo(url) {UseShellExecute = true});
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
               Process.Start("xdg-open", url);
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            {
               Process.Start("open", url);
            }
         }
      }

      private void panelBlue_Click(object sender, EventArgs e)
      {
         _vanillaTexture = "iris_blue_color.dds";
         ShowTextureSelection();
         _selectedBlueTexture = _replacerTexture;
         SetupSelectedTexture(panelBlue);
      }

      private void panelBrown_Click(object sender, EventArgs e)
      {
         _vanillaTexture = "iris_brown_color.dds";
         ShowTextureSelection();
         _selectedBrownTexture = _replacerTexture;
         SetupSelectedTexture(panelBrown);
      }

      private void panelBrownDark_Click(object sender, EventArgs e)
      {
         _vanillaTexture = "iris_browndark_color.dds";
         ShowTextureSelection();
         _selectedBrownDarkTexture = _replacerTexture;
         SetupSelectedTexture(panelBrownDark);
      }

      private void panelCopper_Click(object sender, EventArgs e)
      {
         _vanillaTexture = "iris_copper_color.dds";
         ShowTextureSelection();
         _selectedCopperTexture = _replacerTexture;
         SetupSelectedTexture(panelCopper);
      }

      private void panelDead_Click(object sender, EventArgs e)
      {
         _vanillaTexture = "iris_dead_color.dds";
         ShowTextureSelection();
         _selectedDeadTexture = _replacerTexture;
         SetupSelectedTexture(panelDead);
      }

      private void panelGreen_Click(object sender, EventArgs e)
      {
         _vanillaTexture = "iris_green_color.dds";
         ShowTextureSelection();
         _selectedGreenTexture = _replacerTexture;
         SetupSelectedTexture(panelGreen);
      }

      private void panelGrey_Click(object sender, EventArgs e)
      {
         _vanillaTexture = "iris_grey_color.dds";
         ShowTextureSelection();
         _selectedGreyTexture = _replacerTexture;
         SetupSelectedTexture(panelGrey);
      }

      private void panelHazel_Click(object sender, EventArgs e)
      {
         _vanillaTexture = "iris_hazel_color.dds";
         ShowTextureSelection();
         _selectedHazelTexture = _replacerTexture;
         SetupSelectedTexture(panelHazel);
      }

      private void panelIron_Click(object sender, EventArgs e)
      {
         _vanillaTexture = "iris_iron_color.dds";
         ShowTextureSelection();
         _selectedIronTexture = _replacerTexture;
         SetupSelectedTexture(panelIron);
      }

      private void panelRed_Click(object sender, EventArgs e)
      {
         _vanillaTexture = "iris_red_color.dds";
         ShowTextureSelection();
         _selectedRedTexture = _replacerTexture;
         SetupSelectedTexture(panelRed);
      }

      private void panelRedDevil_Click(object sender, EventArgs e)
      {
         _vanillaTexture = "iris_reddevil_color.dds";
         ShowTextureSelection();
         _selectedRedDevilTexture = _replacerTexture;
         SetupSelectedTexture(panelRedDevil);
      }

      private void panelSulfur_Click(object sender, EventArgs e)
      {
         _vanillaTexture = "iris_sulfur_color.dds";
         ShowTextureSelection();
         _selectedSulfurTexture = _replacerTexture;
         SetupSelectedTexture(panelSulfur);
      }

      private string RetrieveTextureFolder()
      {
         var strExeFilePath = Assembly.GetExecutingAssembly().Location;
         var strWorkPath = Path.GetDirectoryName(strExeFilePath);
         var texturePath = $@"{strWorkPath}\Textures";

         return texturePath;
      }

      private void SetupSelectedTexture(in Panel panel)
      {
         if (string.IsNullOrEmpty(_replacerTexture)) return;

         panel.BackgroundImage = Image.FromFile(_replacerTexture);
      }

      private void ShowTextureSelection()
      {
         var form = new TextureSelection(_vanillaTexture);
         form.ShowDialog();
         _replacerTexture = form.SelectedTextureName;
      }

      #endregion
   }
}