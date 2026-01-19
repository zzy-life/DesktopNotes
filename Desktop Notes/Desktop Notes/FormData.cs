using System.Drawing;
using System;

namespace Desktop_Notes
{
    public class FormData
    {
        public Point Location { get; set; }
        public Size FormSize { get; set; }
        public string data { get; set; } 
        public int theme { get; set; }
        public double opacity { get; set; }
        public string title { get; set; }
        public bool hidden { get; set; }
        public bool topmost { get; set; }
        public Theme customTheme { get; set; }
        public DateTime creationTime { get; set; } 
        public Style customStyle { get; set; }
        public int currentStyle { get; set; }

        public FormData() { }
        public FormData(MainForm form)
        {
            Location = form.Location;
            FormSize = form.Size;
            data = form.notebox1.Rtf; 
            theme = form.CurrentTheme;
            opacity = form.Opacity;
            hidden = !form.Visible;
            title = form.Title;
            topmost = form.TopMost;
            customTheme = form.CustomTheme;
            creationTime = form.CreationTime;
            customStyle = form.CustomStyle;
            currentStyle = form.CurrentStyle;
        }
    }

    public class Theme
    {
        public Theme() { DefaultTheme(); }
        public Theme(string name, Color text, Color back, Color top)
        {
            Name = name;
            TextColor = text;
            BackColor = back;
            TopBarColor = top;
        }

        public string Name { get; set; }
        public Color TextColor { get; set; }
        public Color BackColor { get; set; }
        public Color TopBarColor { get; set; }

        private void DefaultTheme()
        {
            Name = "Default";
            TextColor = Color.Black;
            BackColor = Color.FromArgb(255, 255, 200);
            TopBarColor = Color.FromArgb(245, 240, 180);
        }
    }

    public class Style
    {
        public Style() { DefaultStyle(); }
        public Style(string name, string family, float size, string top)
        {
            Name = name;
            FontFamily = family;
            FontSize = size;
            FStyle = FontStyle.Bold;
        }

        public string Name { get; set; }
        public string FontFamily { get; set; }
        public float FontSize { get; set; }
        public FontStyle FStyle { get; set; }

        public Font GetFont()
        {
            return new Font(FontFamily, FontSize, FStyle);
        }

        private void DefaultStyle()
        {
            Name = "Default";
            FontFamily = "Segoe Print";
            FontSize = 11.0F;
            FStyle = FontStyle.Regular;
        }
    }

    // 默认便签设置类，用于保存上一次使用的样式设置
    public class DefaultNoteSettings
    {
        public int theme { get; set; }
        public int style { get; set; }
        public double opacity { get; set; }
        public Theme customTheme { get; set; }
        public Style customStyle { get; set; }

        public DefaultNoteSettings()
        {
            // 设置初始默认值
            theme = 1; // 默认主题
            style = 1; // 默认样式
            opacity = 0.95; // 默认不透明度
            customTheme = new Theme();
            customStyle = new Style();
        }
    }
}
