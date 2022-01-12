using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using Microsoft.Win32;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace WpfTutorialSamples.Rich_text_controls
{
	public partial class RichTextEditorSample : Window
	{
		public RichTextEditorSample()
		{
			InitializeComponent();
		}

		private void Open_Executed(object sender, ExecutedRoutedEventArgs e)
		{
			OpenFileDialog dlg = new OpenFileDialog();
			dlg.Filter = "Rich Text Format (*.rtf)|*.rtf|All files (*.*)|*.*";
			if (dlg.ShowDialog() == true)
			{
				FileStream fileStream = new FileStream(dlg.FileName, FileMode.Open);
				TextRange range = new TextRange(rtbEditor.Document.ContentStart, rtbEditor.Document.ContentEnd);
				range.Load(fileStream, DataFormats.Rtf);
			}
		}

		private void Save_Executed(object sender, ExecutedRoutedEventArgs e)
		{
			SaveFileDialog dlg = new SaveFileDialog();
			dlg.Filter = "Rich Text Format (*.rtf)|*.rtf|All files (*.*)|*.*";
			if (dlg.ShowDialog() == true)
			{
				FileStream fileStream = new FileStream(dlg.FileName, FileMode.Create);
				TextRange range = new TextRange(rtbEditor.Document.ContentStart, rtbEditor.Document.ContentEnd);
				range.Save(fileStream, DataFormats.Rtf);
			}
        }
		internal int FindImages(string slugName, DirectoryInfo outputFolder)
		{
			if (slugName != null)
			{
				List<string> filePathList = Directory.GetFiles(outputFolder.FullName).ToList();
				List<string> filePathList_ToBeDeleted = new List<string>();
				foreach (string filePath in filePathList)
				{
					if (Path.GetFileNameWithoutExtension(filePath).ToLower().Contains("_70x70"))
					{
						image1.Source = new BitmapImage(new Uri(filePath));
					}
				}
				int count = 0;

				return count;
			}
		}
		public partial class ToolbarSample : Window
		{
			public ToolbarSample()
			{

			}

			private void CommonCommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
			{
				e.CanExecute = true;
			}
		}

        private void CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {

        }
    }
}