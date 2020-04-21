using System.Collections.Specialized;
using System.Windows.Forms;
using TheBox.Common.Localization;

namespace TheBox.Localization
{
    public interface ILocalizationHelper
    {
        StringCollection GetSupportedLanguages();

        TextProvider GetTextProvider();
        void SetTextProvider(TextProvider value);
        TextProvider GetLanguage();
        TextProvider GetLanguage(string language);
        void LocalizeControl(Control control);
        void LocalizeMenu(ContextMenuStrip contextMenuStrip);
        void LocalizeMenu(Menu menu);
        void LocalizeMenu(ToolStripMenuItem toolStripMenuItem);
    }
}