using System;
using System.Reflection;
using System.Windows;
using YaMoControlDesign.Data;

namespace YaMoControlDesign.Tools
{

    /// <summary>
    ///     资源帮助类
    /// </summary>
    public class ResourceHelper
    {
        private static ResourceDictionary _theme;

        /// <summary>
        ///     获取资源
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static T GetResource<T>(string key)
        {
            if (Application.Current.TryFindResource(key) is T resource)
            {
                return resource;
            }

            return default;
        }

        internal static T GetResourceInternal<T>(string key)
        {
            if (GetTheme()[key] is T resource)
            {
                return resource;
            }

            return default;
        }

        /// <summary>
        ///     获取皮肤
        /// </summary>
        public static ResourceDictionary GetSkin(Assembly assembly, string themePath, SkinType skin)
        {
            try
            {
                var uri = new Uri($"pack://application:,,,/{assembly.GetName().Name};component/{themePath}/Skin{skin}.xaml");
                return new ResourceDictionary
                {
                    Source = uri
                };
            }
            catch
            {
                return new ResourceDictionary
                {
                    Source = new Uri($"pack://application:,,,/{assembly.GetName().Name};component/{themePath}/Skin{SkinType.Default}.xaml")
                };
            }
        }

        /// <summary>
        ///     get HandyControl skin
        /// </summary>
        /// <param name="skin"></param>
        /// <returns></returns>
        public static ResourceDictionary GetSkin(SkinType skin) => new ResourceDictionary()
        {
            Source = new Uri($"pack://application:,,,/YaMoControlDesign;component/Themes/Skin{skin}.xaml")
        };

        /// <summary>
        ///     get HandyControl theme
        /// </summary>
        public static ResourceDictionary GetTheme()
        {
            if (_theme == null)
            {
                return _theme = GetStandaloneTheme();
            }
            return _theme;
        }

        public static ResourceDictionary GetStandaloneTheme()
        {
            return new ResourceDictionary()
            {
                Source = new Uri("pack://application:,,,/YaMoControlDesign;component/Themes/Generic.xaml")
            };
        }
    }
}