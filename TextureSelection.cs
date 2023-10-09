// Code written by Gabriel Mailhot, 05/10/2023.

#region

using System.Reflection;

#endregion

namespace TEOBStarfieldTextureReplacer
{
   public partial class TextureSelection : Form
   {
      public TextureSelection(string vanillaTexture)
      {
         InitializeComponent();
         Text = @"Select replacer for " + vanillaTexture;
         LoadTextures();
         SelectedTextureName = string.Empty;
      }

      public string SelectedTextureName { get; private set; }

      #region private

      private string GetTextureFolder()
      {
         var strExeFilePath = Assembly.GetExecutingAssembly().Location;
         var strWorkPath = Path.GetDirectoryName(strExeFilePath);
         var texturePath = $@"{strWorkPath}\Textures";

         return texturePath;
      }


      private void LoadTextures()
      {
         IEnumerable<string> files = Directory.GetFiles(GetTextureFolder()).Where(file => file.ToLower().EndsWith("jpg"));

         foreach (var file in files)
         {
            var panel = new Panel
            {
               Size = new Size(255, 255),
               BackgroundImage = Image.FromFile(file)
            };

            panel.Click += (sender, e) =>
            {
               SelectedTextureName = file;
               Close();
            };

            flowLayoutPanelTexture.Controls.Add(panel);
         }
      }

      #endregion
   }
}