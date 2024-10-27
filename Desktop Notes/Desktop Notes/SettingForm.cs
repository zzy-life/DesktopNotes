using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Desktop_Notes
{
    public partial class SettingForm : Form
    {
        MainForm form = null;

        public SettingForm(MainForm form)
        {
            InitializeComponent();

            load_themes();
            load_styles();
            this.form = form;
            load_settings();
        }

        void load_defaults()
        {
            MainForm def = new MainForm(0);
            form.CurrentTheme = def.CurrentTheme;
            form.CurrentStyle = def.CurrentStyle;
            form.Opacity = def.Opacity;
            load_settings();
        }

        void load_themes()
        {
            List<string> items = new List<string>();
            for (int i = 0; i < Program.Themes.Count; ++i)
            {
                items.Add(string.Format("{0} : {1}",
                    i + 1, Program.Themes[i].Name));
            }

            theme_sel.Items.Clear();
            theme_sel.Items.AddRange(items.ToArray()); 
        }
        void load_styles()
        {
            List<string> items = new List<string>();
            for (int i = 0; i < Program.Styles.Count; ++i)
            {
                items.Add(string.Format("{0} : {1}",
                    i + 1, Program.Styles[i].Name));
            }

            style_sel.Items.Clear();
            style_sel.Items.AddRange(items.ToArray()); 
        }

        void load_settings()
        {
            settheme();
            setstyle();
            opacity_val.Value = (decimal)form.Opacity;
            theme_sel.SelectedIndex = form.CurrentTheme;
            style_sel.SelectedIndex = form.CurrentStyle;
        }

        void settheme()
        {
            Theme th = Program.Themes[form.CurrentTheme];
            if (th.Name == "Custom") th = form.CustomTheme;
            topbar_color.BackColor = th.TopBarColor;
            back_color.BackColor = th.BackColor;
            text_color.BackColor = th.TextColor;
        }
        void setstyle()
        {
            Style th = Program.Styles[form.CurrentStyle];
            if (th.Name == "Custom") th = form.CustomStyle;
            current_font.Font = th.GetFont();
            current_font.Text = th.FontFamily;
            font_size.Value = (decimal)th.FontSize;
        }

        private void default_Click(object sender, LinkLabelLinkClickedEventArgs e)
        {
            load_defaults();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            form.Save();
            this.Close();
        }

        //theme changed
        private void theme_sel_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                form.CurrentTheme = (int)theme_sel.SelectedIndex;
                settheme();
            }
            catch { }
        }
        private void style_sel_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                form.CurrentStyle = (int)style_sel.SelectedIndex;
                setstyle();
            }
            catch { }
        }
        
        //change values 
        private void current_font_Click(object sender, EventArgs e)
        {
            FontDialog fod = new FontDialog();
            fod.Font = form.CustomStyle.GetFont();
            if (fod.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                form.CustomStyle.FontSize = fod.Font.Size;
                form.CustomStyle.FontFamily = fod.Font.FontFamily.ToString();
                form.CustomStyle.FStyle = fod.Font.Style;
                if (style_sel.SelectedIndex != 0)
                {
                    style_sel.SelectedIndex = 0;
                }
                else
                {
                    form.ReloadStyle();
                    form.Save();
                    setstyle();
                }
            }
        }

        private void font_size_ValueChanged(object sender, EventArgs e)
        {
            Style th = Program.Styles[form.CurrentStyle];
            if (th.Name == "Custom") th = form.CustomStyle;
            if (th.FontSize == (float)font_size.Value) return;

            form.CustomStyle.FontSize = (float)font_size.Value;
            if (style_sel.SelectedIndex != 0)
            {
                style_sel.SelectedIndex = 0;
            }
            else
            {
                form.ReloadStyle();
                form.Save();
                setstyle();
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            decimal v = (decimal)trackBar1.Value / 100;
            if (opacity_val.Value != v) opacity_val.Value = v;
        }

        private void opacity_val_ValueChanged(object sender, EventArgs e)
        {
            form.Opacity = (double)opacity_val.Value;
            int v = (int)(opacity_val.Value * 100);
            if (v >= trackBar1.Minimum && v != trackBar1.Value) trackBar1.Value = v;
        }

        //change custom themes
        private void topbar_color_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.Color = topbar_color.BackColor;
            if(cd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                form.CustomTheme.TopBarColor = cd.Color;
                if (theme_sel.SelectedIndex != 0)
                {
                    theme_sel.SelectedIndex = 0;
                }
                else
                {
                    form.ReloadTheme();
                    form.Save();
                    settheme();
                }
            }
        }

        private void back_color_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.Color = back_color.BackColor;
            if (cd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                form.CustomTheme.BackColor = cd.Color;
                if (theme_sel.SelectedIndex != 0)
                {
                    theme_sel.SelectedIndex = 0;
                }
                else
                {
                    form.ReloadTheme();
                    form.Save();
                    settheme();
                }
            }
        }

        private void text_color_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.Color = text_color.BackColor;
            if (cd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                form.CustomTheme.TextColor = cd.Color;
                if (theme_sel.SelectedIndex != 0)
                {
                    theme_sel.SelectedIndex = 0;
                }
                else
                {
                    form.ReloadTheme();
                    form.Save();
                    settheme();
                }
            }           
        }


    }
}
